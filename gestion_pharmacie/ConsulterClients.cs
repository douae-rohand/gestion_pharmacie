using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class ConsulterClients : Form
    {
        private string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        public ConsulterClients()
        {
            InitializeComponent();
            // Configurer la chaîne de connexion pour la classe Client
            Client.SetConnectionString(connectionString);
        }

        private void ConsulterClients_Load(object sender, EventArgs e)
        {
            ChargerStatistiques();
            ChargerClients();
            ConfigurerComboBoxRecherche();
        }

        #region Chargement des Données

        private void ChargerStatistiques()
        {
            try
            {
                ClientStatistiques stats = Client.ObtenirStatistiques();

                labelStatTotalValeur.Text = stats.TotalClients.ToString();
                labelStatActifsValeur.Text = stats.ClientsActifs.ToString();
                labelStatRevenuValeur.Text = stats.RevenuTotal.ToString("N2") + " DH";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerClients(string whereClause = "")
        {
            try
            {
                DataTable dt = Client.ObtenirTousAvecStatistiques(whereClause);
                clientGridView.DataSource = dt;
                PersonnaliserColonnes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des clients :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonnaliserColonnes()
        {
            if (clientGridView.Columns.Count > 0)
            {
                // Masquer l'ID
                if (clientGridView.Columns.Contains("idClient"))
                    clientGridView.Columns["idClient"].Visible = false;

                // Renommer les en-têtes
                clientGridView.Columns["Nom"].HeaderText = "Nom";
                clientGridView.Columns["Prenom"].HeaderText = "Prénom";
                clientGridView.Columns["CIN"].HeaderText = "CIN";
                clientGridView.Columns["Telephone"].HeaderText = "Téléphone";
                clientGridView.Columns["Adresse"].HeaderText = "Adresse";
                clientGridView.Columns["Ville"].HeaderText = "Ville";
                clientGridView.Columns["CodePostal"].HeaderText = "Code Postal";
                clientGridView.Columns["DateNaissance"].HeaderText = "Date de Naissance";
                clientGridView.Columns["DateInscription"].HeaderText = "Date d'Inscription";
                clientGridView.Columns["Age"].HeaderText = "Âge";
                clientGridView.Columns["NombreCommandes"].HeaderText = "Nbr Commandes";
                clientGridView.Columns["MontantTotalAchats"].HeaderText = "Total Achats (DH)";

                // Format des dates
                if (clientGridView.Columns.Contains("DateNaissance"))
                    clientGridView.Columns["DateNaissance"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (clientGridView.Columns.Contains("DateInscription"))
                    clientGridView.Columns["DateInscription"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                // Format des montants
                if (clientGridView.Columns.Contains("MontantTotalAchats"))
                {
                    clientGridView.Columns["MontantTotalAchats"].DefaultCellStyle.Format = "N2";
                    clientGridView.Columns["MontantTotalAchats"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Positionner les boutons à la fin
                if (clientGridView.Columns.Contains("Supprimer"))
                    clientGridView.Columns["Supprimer"].DisplayIndex = clientGridView.Columns.Count - 1;
                if (clientGridView.Columns.Contains("Modifier"))
                    clientGridView.Columns["Modifier"].DisplayIndex = clientGridView.Columns.Count - 1;
            }
        }

        private void ConfigurerComboBoxRecherche()
        {
            combocritere.Items.Clear();
            combocritere.Items.AddRange(new object[]
            {
                "Nom",
                "Prénom",
                "CIN",
                "Téléphone",
                "Ville",
                "Date de naissance",
                "Âge",
                "Nombre de commandes"
            });
            combocritere.SelectedIndex = 0;
        }

        #endregion

        #region Gestion des Clics sur le DataGridView

        private void clientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Bouton SUPPRIMER
                if (clientGridView.Columns[e.ColumnIndex].Name == "Supprimer")
                {
                    int idClient = Convert.ToInt32(clientGridView.Rows[e.RowIndex].Cells["idClient"].Value);
                    string nomComplet = clientGridView.Rows[e.RowIndex].Cells["Nom"].Value + " " +
                                       clientGridView.Rows[e.RowIndex].Cells["Prenom"].Value;

                    DialogResult result = MessageBox.Show(
                        $"Êtes-vous sûr de vouloir supprimer le client :\n{nomComplet} ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        SupprimerClient(idClient);
                    }
                }
                // Bouton MODIFIER
                else if (clientGridView.Columns[e.ColumnIndex].Name == "Modifier")
                {
                    int idClient = Convert.ToInt32(clientGridView.Rows[e.RowIndex].Cells["idClient"].Value);
                    ModifierClient(idClient);
                }
            }
        }

        #endregion

        #region Opérations CRUD

        private void SupprimerClient(int idClient)
        {
            try
            {
                // Vérifier les commandes liées
                int nombreCommandes = Client.ObtenirNombreCommandes(idClient);

                if (nombreCommandes > 0)
                {
                    DialogResult result = MessageBox.Show(
                        $"Ce client a {nombreCommandes} commande(s) associée(s).\n\n" +
                        "Voulez-vous vraiment supprimer ce client et toutes ses commandes ?",
                        "Attention - Données liées",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                        return;
                }

                // Supprimer le client
                if (Client.Supprimer(idClient))
                {
                    MessageBox.Show("Client supprimé avec succès !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChargerClients();
                    ChargerStatistiques();
                }
                else
                {
                    MessageBox.Show("Échec de la suppression du client.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifierClient(int idClient)
        {
            try
            {
                Client client = Client.ObtenirParId(idClient);

                if (client != null)
                {
                    // Créer un objet anonyme compatible avec FormAjouterClient
                    var clientData = new
                    {
                        idClient = client.IdClient,
                        nom = client.Nom,
                        prenom = client.Prenom,
                        CIN = client.CIN,
                        telephone = client.Telephone,
                        adresse = client.Adresse,
                        ville = client.Ville,
                        codePostale = client.CodePostale,
                        dateNaissance = client.DateNaissance
                    };

                    FormAjouterClient formModifier = new FormAjouterClient(clientData);
                    if (formModifier.ShowDialog() == DialogResult.OK)
                    {
                        ChargerClients();
                        ChargerStatistiques();
                    }
                }
                else
                {
                    MessageBox.Show("Client introuvable !", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du client :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Recherche

        private void RechercherClients()
        {
            string critere = combocritere.SelectedItem?.ToString();
            string valeurRecherche = textrecherche.Text.Trim();

            if (string.IsNullOrEmpty(critere) || string.IsNullOrEmpty(valeurRecherche))
            {
                MessageBox.Show("Veuillez sélectionner un critère et saisir une valeur de recherche.",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            string whereClause = "";

            switch (critere)
            {
                case "Nom":
                    whereClause = $"WHERE c.nom LIKE '%{valeurRecherche}%'";
                    break;

                case "Prénom":
                    whereClause = $"WHERE c.prenom LIKE '%{valeurRecherche}%'";
                    break;

                case "CIN":
                    whereClause = $"WHERE c.CIN LIKE '%{valeurRecherche}%'";
                    break;

                case "Téléphone":
                    string telRecherche = valeurRecherche.Replace(" ", "").Replace("-", "").Replace(".", "");
                    whereClause = $"WHERE REPLACE(REPLACE(REPLACE(c.telephone, ' ', ''), '-', ''), '.', '') LIKE '%{telRecherche}%'";
                    break;

                case "Ville":
                    whereClause = $"WHERE c.ville LIKE '%{valeurRecherche}%'";
                    break;

                case "Date de naissance":
                    if (valeurRecherche.Length < 10)
                        return;

                    DateTime dateNaissance;
                    string[] formats = {
                        "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "d-M-yyyy",
                        "dd/MM/yy", "d/M/yy", "dd-MM-yy", "d-M-yy", "yyyy-MM-dd"
                    };

                    if (DateTime.TryParseExact(valeurRecherche, formats,
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None, out dateNaissance))
                    {
                        whereClause = $"WHERE c.dateNaissance = '{dateNaissance:yyyy-MM-dd}'";
                    }
                    else
                    {
                        MessageBox.Show("Format de date invalide. Formats acceptés : dd/MM/yyyy, dd-MM-yyyy, yyyy-MM-dd",
                                        "Erreur",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    break;

                case "Âge":
                    if (valeurRecherche.StartsWith(">") || valeurRecherche.StartsWith("<") || valeurRecherche.StartsWith("="))
                    {
                        string operateur = valeurRecherche.Substring(0, 1);
                        string valeur = valeurRecherche.Substring(1).Trim();

                        if (int.TryParse(valeur, out int ageOperateur))
                        {
                            whereClause = $@"WHERE DATEDIFF(YEAR, c.dateNaissance, GETDATE()) - 
                                    CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, c.dateNaissance, GETDATE()), c.dateNaissance) > GETDATE() 
                                    THEN 1 ELSE 0 END {operateur} {ageOperateur}";
                        }
                        else
                        {
                            MessageBox.Show("Veuillez saisir un nombre valide après l'opérateur (ex: >18, <65, =30).",
                                            "Erreur",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (int.TryParse(valeurRecherche, out int age))
                    {
                        whereClause = $@"WHERE DATEDIFF(YEAR, c.dateNaissance, GETDATE()) - 
                                CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, c.dateNaissance, GETDATE()), c.dateNaissance) > GETDATE() 
                                THEN 1 ELSE 0 END = {age}";
                    }
                    else
                    {
                        MessageBox.Show("Veuillez saisir un nombre valide pour l'âge (ex: 25, >18, <65).",
                                        "Erreur",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    break;

                case "Nombre de commandes":
                    if (valeurRecherche.StartsWith(">") || valeurRecherche.StartsWith("<") || valeurRecherche.StartsWith("="))
                    {
                        string operateur = valeurRecherche.Substring(0, 1);
                        string valeur = valeurRecherche.Substring(1).Trim();

                        if (int.TryParse(valeur, out int nbCommandesOperateur))
                        {
                            whereClause = $"HAVING COUNT(DISTINCT cmd.idCommande) {operateur} {nbCommandesOperateur}";
                        }
                        else
                        {
                            MessageBox.Show("Veuillez saisir un nombre valide après l'opérateur (ex: >5, <10, =3).",
                                            "Erreur",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (int.TryParse(valeurRecherche, out int nbCommandes))
                    {
                        whereClause = $"HAVING COUNT(DISTINCT cmd.idCommande) = {nbCommandes}";
                    }
                    else
                    {
                        MessageBox.Show("Veuillez saisir un nombre valide pour le nombre de commandes (ex: 5, >10, <3).",
                                        "Erreur",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    break;

                default:
                    MessageBox.Show("Critère de recherche non valide.",
                                    "Erreur",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
            }

            ChargerClients(whereClause);
        }

        #endregion

        #region Event Handlers - Boutons

        private void button2_Click(object sender, EventArgs e)
        {
            FormAjouterClient formAjouter = new FormAjouterClient();
            if (formAjouter.ShowDialog() == DialogResult.OK)
            {
                ChargerClients();
                ChargerStatistiques();
            }
        }

        private void buttonrecherche_Click(object sender, EventArgs e)
        {
            RechercherClients();
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textrecherche.Text))
            {
                ChargerClients();
            }
            else
            {
                RechercherClients();
            }
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment vous déconnecter ?",
                "Déconnexion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                connexion login = new connexion();
                login.Show();
                this.Hide();
            }
        }

        private void buttonMedicaments_Click(object sender, EventArgs e)
        {
            EspaceAdmin adminForm = new EspaceAdmin();
            adminForm.Show();
            this.Hide();
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            Notification notifForm = new Notification();
            notifForm.Show();
            this.Hide();
        }

        private void buttonCommande_Click(object sender, EventArgs e)
        {
            FormListeCommandes listeCommandes = new FormListeCommandes();
            listeCommandes.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListeFournisseurs fournisseurs = new FormListeFournisseurs();
            fournisseurs.Show();
            this.Close();
        }

        #endregion

        #region Event Handlers - Autres

        private void combocritere_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void panelHeader_Paint(object sender, PaintEventArgs e) { }

        private void panelHeader_Paint_1(object sender, PaintEventArgs e) { }

        #endregion
    }
}