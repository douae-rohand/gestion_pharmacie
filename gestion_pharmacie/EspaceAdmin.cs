using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class EspaceAdmin : Form
    {
        private string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        public EspaceAdmin()
        {
            InitializeComponent();
            Medicament.SetConnectionString(connectionString);
        }

        #region Chargement du Formulaire

        private void EspaceAdmin_Load(object sender, EventArgs e)
        {
            ChargerStatistiques();
            ChargerMedicaments();
            ConfigurerDataGridView();
        }

        #endregion

        #region Chargement des Données

        private void ChargerStatistiques()
        {
            try
            {
                MedicamentStatistiques stats = Medicament.ObtenirStatistiques();

                // Mettre à jour les labels
                labelStatTotalValeur.Text = stats.TotalMedicaments.ToString();
                labelStatCategoriesValeur.Text = stats.MedicamentsPeremption.ToString();
                labelStatStockValeur.Text = stats.StockTotal.ToString() + " unités";
                labelStatAlertesValeur.Text = stats.AlertesStock.ToString();

                // Changer les couleurs selon les alertes
                panelStatCategories.BackColor = stats.MedicamentsPeremption > 0
                    ? Color.FromArgb(231, 76, 60)  // Rouge
                    : Color.FromArgb(46, 204, 113); // Vert

                panelStatAlertes.BackColor = stats.AlertesStock > 0
                    ? Color.FromArgb(231, 76, 60)  // Rouge
                    : Color.FromArgb(46, 204, 113); // Vert
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerMedicaments(string whereClause = "")
        {
            try
            {
                DataTable dt = Medicament.ObtenirTous(whereClause);
                dataGridView.DataSource = dt;
                ColorerLignesPeremption();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des médicaments :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurerDataGridView()
        {
            // Masquer la colonne idMed
            if (dataGridView.Columns.Contains("idMed"))
            {
                dataGridView.Columns["idMed"].Visible = false;
            }

            // Configuration de la culture pour l'affichage des prix
            var culture = new System.Globalization.CultureInfo("fr-FR");
            culture.NumberFormat.CurrencySymbol = "DH";
            culture.NumberFormat.CurrencyDecimalDigits = 2;

            // Formater les colonnes de prix
            if (dataGridView.Columns.Contains("prixAchat"))
            {
                dataGridView.Columns["prixAchat"].DefaultCellStyle.Format = "C";
                dataGridView.Columns["prixAchat"].DefaultCellStyle.FormatProvider = culture;
                dataGridView.Columns["prixAchat"].HeaderText = "Prix Achat";
            }

            if (dataGridView.Columns.Contains("prixVente"))
            {
                dataGridView.Columns["prixVente"].DefaultCellStyle.Format = "C";
                dataGridView.Columns["prixVente"].DefaultCellStyle.FormatProvider = culture;
                dataGridView.Columns["prixVente"].HeaderText = "Prix Vente";
            }

            // Formater les colonnes de dates
            if (dataGridView.Columns.Contains("datePeremption"))
            {
                dataGridView.Columns["datePeremption"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.Columns["datePeremption"].HeaderText = "Date Péremption";
            }

            if (dataGridView.Columns.Contains("dateCreation"))
            {
                dataGridView.Columns["dateCreation"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.Columns["dateCreation"].HeaderText = "Date Création";
            }

            // Renommer les en-têtes
            if (dataGridView.Columns.Contains("quantiteStocke"))
                dataGridView.Columns["quantiteStocke"].HeaderText = "Stock";

            if (dataGridView.Columns.Contains("seuilAlerte"))
                dataGridView.Columns["seuilAlerte"].HeaderText = "Seuil Alerte";

            if (dataGridView.Columns.Contains("nomMed"))
                dataGridView.Columns["nomMed"].HeaderText = "Nom Médicament";

            if (dataGridView.Columns.Contains("reference"))
                dataGridView.Columns["reference"].HeaderText = "Référence";

            // Ajuster les largeurs
            if (dataGridView.Columns.Contains("description"))
            {
                dataGridView.Columns["description"].Width = 200;
                dataGridView.Columns["description"].HeaderText = "Description";
            }

            if (dataGridView.Columns.Contains("nomMed"))
                dataGridView.Columns["nomMed"].Width = 150;

            if (dataGridView.Columns.Contains("Categorie"))
                dataGridView.Columns["Categorie"].Width = 120;

            if (dataGridView.Columns.Contains("Fournisseur"))
                dataGridView.Columns["Fournisseur"].Width = 150;

            ColorerLignesPeremption();
        }

        private void ColorerLignesPeremption()
        {
            DateTime dateLimite = DateTime.Now.AddMonths(3);
            Color rougePastel = Color.FromArgb(255, 182, 193);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["datePeremption"].Value != null &&
                    row.Cells["datePeremption"].Value != DBNull.Value)
                {
                    DateTime datePeremption = Convert.ToDateTime(row.Cells["datePeremption"].Value);

                    if (datePeremption <= dateLimite)
                    {
                        row.DefaultCellStyle.BackColor = rougePastel;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        #endregion

        #region Gestion des Clics sur le DataGridView

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idMedicament = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["idMed"].Value);
                string nomMedicament = dataGridView.Rows[e.RowIndex].Cells["nomMed"].Value.ToString();

                if (dataGridView.Columns[e.ColumnIndex].Name == "Supprimer")
                {
                    DialogResult result = MessageBox.Show(
                        $"Voulez-vous vraiment supprimer le médicament '{nomMedicament}' ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        SupprimerMedicament(idMedicament);
                    }
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "Modifier")
                {
                    ModifierMedicament(idMedicament);
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "Details")
                {
                    AfficherDetailsMedicament(idMedicament);
                }
            }
        }

        #endregion

        #region Opérations CRUD

        private void SupprimerMedicament(int idMedicament)
        {
            try
            {
                if (Medicament.Supprimer(idMedicament))
                {
                    MessageBox.Show("Médicament supprimé avec succès !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChargerMedicaments();
                    ChargerStatistiques();
                }
                else
                {
                    MessageBox.Show("Échec de la suppression du médicament.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifierMedicament(int idMedicament)
        {
            try
            {
                Medicament medicament = Medicament.ObtenirParId(idMedicament);

                if (medicament != null)
                {
                    // Créer un objet anonyme compatible avec FormAjouterMedicament
                    var medicamentData = new
                    {
                        idMed = medicament.IdMed,
                        reference = medicament.Reference,
                        nomMed = medicament.NomMed,
                        description = medicament.Description,
                        photo = medicament.Photo != null ? (object)medicament.Photo : DBNull.Value,
                        idCategorie = medicament.IdCategorie.HasValue ? (object)medicament.IdCategorie.Value : DBNull.Value,
                        idFournisseur = medicament.IdFournisseur.HasValue ? (object)medicament.IdFournisseur.Value : DBNull.Value,
                        prixAchat = medicament.PrixAchat.HasValue ? (object)medicament.PrixAchat.Value : 0,
                        prixVente = medicament.PrixVente,
                        quantiteStocke = medicament.QuantiteStocke,
                        seuilAlerte = medicament.SeuilAlerte,
                        datePeremption = medicament.DatePeremption,
                        nomCategorie = medicament.NomCategorie,
                        NomFournisseur = medicament.NomFournisseur
                    };

                    FormAjouterMedicament formModif = new FormAjouterMedicament(medicamentData);

                    if (formModif.ShowDialog() == DialogResult.OK)
                    {
                        ChargerMedicaments();
                        ChargerStatistiques();
                        MessageBox.Show("Médicament modifié avec succès!",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Médicament introuvable !", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du médicament :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherDetailsMedicament(int idMedicament)
        {
            try
            {
                Medicament medicament = Medicament.ObtenirParId(idMedicament);

                if (medicament != null)
                {
                    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"SELECT 
                                        m.idMed, m.reference, m.nomMed, m.description, m.photo,
                                        m.prixVente, m.quantiteStocke, m.seuilAlerte,
                                        m.datePeremption, m.dateCreation,
                                        c.nomCategorie, f.nomEntreprise, f.telephone, fr.prixAchat
                                        FROM Medicament m
                                        LEFT JOIN Categories c ON m.idCategorie = c.idCategorie
                                        LEFT JOIN fournit fr ON m.idMed = fr.idMed
                                        LEFT JOIN Fournisseurs f ON fr.idFournisseur = f.idFournisseur
                                        WHERE m.idMed = @IdMedicament";

                        var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@IdMedicament", idMedicament);
                        var reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            FormDetailsMedicament formDetails = new FormDetailsMedicament(reader);
                            formDetails.ShowDialog();
                        }
                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Médicament introuvable !", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'affichage des détails :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Recherche

        private void RechercherMedicaments()
        {
            string critere = combocritere.SelectedItem?.ToString();
            string valeurRecherche = textrecherche.Text.Trim();

            if (string.IsNullOrEmpty(critere))
            {
                MessageBox.Show("Veuillez sélectionner un critère de recherche.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (critere != "Près d'expirer" && string.IsNullOrEmpty(valeurRecherche))
            {
                MessageBox.Show("Veuillez saisir une valeur de recherche.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string whereClause = "";

            try
            {
                switch (critere)
                {
                    case "Nom médicament":
                        whereClause = "m.nomMed LIKE @valeur";
                        break;

                    case "Fournisseurs":
                        whereClause = "f.nomEntreprise LIKE @valeur";
                        break;

                    case "Référence":
                        whereClause = "m.reference LIKE @valeur";
                        break;

                    case "Date de péremption":
                        if (valeurRecherche.Length < 10)
                            return;

                        DateTime datePeremption;
                        string[] formats = {
                            "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "d-M-yyyy",
                            "dd/MM/yy", "d/M/yy", "dd-MM-yy", "d-M-yy", "yyyy-MM-dd"
                        };

                        if (DateTime.TryParseExact(valeurRecherche, formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None, out datePeremption))
                        {
                            whereClause = $"m.datePeremption = '{datePeremption:yyyy-MM-dd}'";
                        }
                        else
                        {
                            MessageBox.Show("Format de date invalide. Utilisez dd/MM/yyyy",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;

                    case "Seuil alerte":
                        if (valeurRecherche.StartsWith(">") || valeurRecherche.StartsWith("<") || valeurRecherche.StartsWith("="))
                        {
                            string operateur = valeurRecherche.Substring(0, 1);
                            string valeur = valeurRecherche.Substring(1).Trim();

                            if (int.TryParse(valeur, out int seuilOperateur))
                            {
                                whereClause = $"m.seuilAlerte {operateur} {seuilOperateur}";
                            }
                            else
                            {
                                MessageBox.Show("Veuillez saisir un nombre valide après l'opérateur (ex: >10, <5, =15).",
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (int.TryParse(valeurRecherche, out int seuilAlerte))
                        {
                            whereClause = $"m.seuilAlerte = {seuilAlerte}";
                        }
                        else
                        {
                            MessageBox.Show("Veuillez saisir un nombre valide pour le seuil d'alerte (ex: 10, >5, <15).",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;

                    case "Près d'expirer":
                        DateTime dateLimite = DateTime.Now.AddMonths(3);
                        whereClause = $"m.datePeremption <= '{dateLimite:yyyy-MM-dd}'";
                        break;

                    default:
                        MessageBox.Show("Critère de recherche non valide",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Recherche avec ou sans paramètres
                if (whereClause.Contains("@valeur"))
                {
                    DataTable dt = Medicament.RechercherAvecParametres(whereClause, valeurRecherche);
                    dataGridView.DataSource = dt;
                }
                else
                {
                    ChargerMedicaments(whereClause);
                }

                ColorerLignesPeremption();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event Handlers - Boutons

        private void buttonajouter_Click(object sender, EventArgs e)
        {
            FormAjouterMedicament formAjouter = new FormAjouterMedicament();
            if (formAjouter.ShowDialog() == DialogResult.OK)
            {
                ChargerMedicaments();
                ChargerStatistiques();
            }
        }

        private void buttonrecherche_Click(object sender, EventArgs e)
        {
            RechercherMedicaments();
        }

        private void buttonRafraichir_Click(object sender, EventArgs e)
        {
            ChargerMedicaments();
            ChargerStatistiques();
            textrecherche.Clear();
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textrecherche.Text))
            {
                ChargerMedicaments();
            }
            else
            {
                RechercherMedicaments();
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

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ConsulterClients clients = new ConsulterClients();
            clients.Show();
            this.Hide();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            Notification notifForm = new Notification();
            notifForm.Show();
            this.Hide();
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            FormListeCommandes formListeCommandes = new FormListeCommandes();
            formListeCommandes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListeFournisseurs fournisseurs = new FormListeFournisseurs();
            fournisseurs.Show();
            this.Hide();
        }

        #endregion

        #region Event Handlers - Autres

        private void labelMenuTitre_Click(object sender, EventArgs e) { }

        private void textrecherche_TextChanged_1(object sender, EventArgs e) { }

        private void combocritere_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void buttonMedicaments_Click(object sender, EventArgs e) { }

        #endregion

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}