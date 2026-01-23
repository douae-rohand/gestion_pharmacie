using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class FormListeCommandes : Form
    {
        private SqlConnection connexion;
        private DataTable dataTableCommandes;
        private string connectionString = "data source =IN-5CG3444P44\\GI2;initial catalog = Pharmacie; integrated security = SSPI; TrustServerCertificate=True";

        public FormListeCommandes()
        {
            InitializeComponent();
            connexion = new SqlConnection();
            connexion.ConnectionString = connectionString;
        }

        private void FormListeCommandes_Load(object sender, EventArgs e)
        {
            ChargerStatistiques();
            ChargerCommandes();
            ConfigurerDataGridView();
        }

        private void ChargerStatistiques()
        {
            try
            {
                var stats = Commande.ObtenirStatistiques();
                labelStatTotalValeur.Text = stats.TotalCommandes.ToString();
                labelStatEnCoursValeur.Text = stats.CommandesEnCours.ToString();
                labelStatValideesValeur.Text = stats.CommandesValidees.ToString();
                labelStatLivreesValeur.Text = stats.CommandesLivrees.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerCommandes(string whereClause = "")
        {
            try
            {
                dataTableCommandes = Commande.ObtenirTous(whereClause);
                dataGridViewCommandes.DataSource = dataTableCommandes;

                // Colorier les lignes selon le statut
                ColorierLignesStatut();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des commandes: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurerDataGridView()
        {
            // Masquer la colonne idCommande
            if (dataGridViewCommandes.Columns.Contains("idCommande"))
            {
                dataGridViewCommandes.Columns["idCommande"].Visible = false;
            }

            // Formater les colonnes
            var culture = new System.Globalization.CultureInfo("fr-FR");
            culture.NumberFormat.CurrencySymbol = "DH";
            culture.NumberFormat.CurrencyDecimalDigits = 2;

            if (dataGridViewCommandes.Columns.Contains("montantTotale"))
            {
                dataGridViewCommandes.Columns["montantTotale"].DefaultCellStyle.Format = "C";
                dataGridViewCommandes.Columns["montantTotale"].DefaultCellStyle.FormatProvider = culture;
                dataGridViewCommandes.Columns["montantTotale"].HeaderText = "Montant Total";
                dataGridViewCommandes.Columns["montantTotale"].Width = 120;
            }

            if (dataGridViewCommandes.Columns.Contains("dateCommande"))
            {
                dataGridViewCommandes.Columns["dateCommande"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dataGridViewCommandes.Columns["dateCommande"].HeaderText = "Date Commande";
                dataGridViewCommandes.Columns["dateCommande"].Width = 150;
            }

            if (dataGridViewCommandes.Columns.Contains("dateLivraison"))
            {
                dataGridViewCommandes.Columns["dateLivraison"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewCommandes.Columns["dateLivraison"].HeaderText = "Date Livraison";
                dataGridViewCommandes.Columns["dateLivraison"].Width = 120;
            }

            if (dataGridViewCommandes.Columns.Contains("Client"))
            {
                dataGridViewCommandes.Columns["Client"].Width = 150;
            }

            if (dataGridViewCommandes.Columns.Contains("CIN"))
            {
                dataGridViewCommandes.Columns["CIN"].Width = 100;
            }

            if (dataGridViewCommandes.Columns.Contains("telephone"))
            {
                dataGridViewCommandes.Columns["telephone"].HeaderText = "Téléphone";
                dataGridViewCommandes.Columns["telephone"].Width = 120;
            }

            if (dataGridViewCommandes.Columns.Contains("statut"))
            {
                dataGridViewCommandes.Columns["statut"].HeaderText = "Statut";
                dataGridViewCommandes.Columns["statut"].Width = 100;
            }

            if (dataGridViewCommandes.Columns.Contains("Pharmacien"))
            {
                dataGridViewCommandes.Columns["Pharmacien"].Width = 130;
            }

            if (dataGridViewCommandes.Columns.Contains("NbArticles"))
            {
                dataGridViewCommandes.Columns["NbArticles"].HeaderText = "Nb Articles";
                dataGridViewCommandes.Columns["NbArticles"].Width = 100;
            }
        }

        private void ColorierLignesStatut()
        {
            foreach (DataGridViewRow row in dataGridViewCommandes.Rows)
            {
                if (row.Cells["statut"].Value != null)
                {
                    string statut = row.Cells["statut"].Value.ToString();
                    switch (statut)
                    {
                        case "En cours":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205); // Jaune clair
                            break;
                        case "Validée":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(209, 236, 241); // Bleu clair
                            break;
                        case "Livrée":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218); // Vert clair
                            break;
                        case "Annulée":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218); // Rouge clair
                            break;
                    }
                }
            }
        }

        private void dataGridViewCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewCommandes.Columns[e.ColumnIndex].Name == "Supprimer")
                {
                    int idCommande = Convert.ToInt32(dataGridViewCommandes.Rows[e.RowIndex].Cells["idCommande"].Value);
                    string client = dataGridViewCommandes.Rows[e.RowIndex].Cells["Client"].Value.ToString();

                    DialogResult result = MessageBox.Show(
                        $"Voulez-vous vraiment supprimer la commande du client '{client}' ?\n\nAttention : Cela supprimera également toutes les lignes de commande et la facture associée.",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        SupprimerCommande(idCommande);
                    }
                }
                else if (dataGridViewCommandes.Columns[e.ColumnIndex].Name == "Modifier")
                {
                    int idCommande = Convert.ToInt32(dataGridViewCommandes.Rows[e.RowIndex].Cells["idCommande"].Value);
                    ModifierCommande(idCommande);
                }
                else if (dataGridViewCommandes.Columns[e.ColumnIndex].Name == "Details")
                {
                    int idCommande = Convert.ToInt32(dataGridViewCommandes.Rows[e.RowIndex].Cells["idCommande"].Value);
                    AfficherDetailsCommande(idCommande);
                }
                else if (dataGridViewCommandes.Columns[e.ColumnIndex].Name == "Facture")
                {
                    int idCommande = Convert.ToInt32(dataGridViewCommandes.Rows[e.RowIndex].Cells["idCommande"].Value);
                    OuvrirFacture(idCommande);
                }

            }
        }

        private void textRecherche_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textRecherche.Text))
            {
                ChargerCommandes();
            }
            else
            {
                RechercherCommandes();
            }
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            RechercherCommandes();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterCommande formAjouter = new FormAjouterCommande();
            if (formAjouter.ShowDialog() == DialogResult.OK)
            {
                ChargerCommandes();
                ChargerStatistiques();
            }
        }

        private void RechercherCommandes()
        {
            string critere = comboCritere.SelectedItem?.ToString();
            string valeurRecherche = textRecherche.Text.Trim();

            if (string.IsNullOrEmpty(critere) || string.IsNullOrEmpty(valeurRecherche))
            {
                MessageBox.Show("Veuillez sélectionner un critère et saisir une valeur de recherche.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (critere == "Date")
                {
                    if (valeurRecherche.Length < 10) return;

                    DateTime dateCommande;
                    string[] formats = {
                        "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "d-M-yyyy",
                        "dd/MM/yy", "d/M/yy", "dd-MM-yy", "d-M-yy", "yyyy-MM-dd"
                    };
                    if (DateTime.TryParseExact(valeurRecherche, formats,
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None, out dateCommande))
                    {
                        valeurRecherche = dateCommande.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        MessageBox.Show("Format de date invalide. Utilisez dd/MM/yyyy",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                dataTableCommandes = Commande.Rechercher(critere, valeurRecherche);
                dataGridViewCommandes.DataSource = dataTableCommandes;
                ColorierLignesStatut();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SupprimerCommande(int idCommande)
        {
            try
            {
                if (Commande.Supprimer(idCommande))
                {
                    MessageBox.Show("Commande supprimée avec succès !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Rafraîchir automatiquement
                    ChargerCommandes();
                    ChargerStatistiques();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifierCommande(int idCommande)
        {
            try
            {
                Commande commande = Commande.ObtenirParId(idCommande);

                if (commande != null)
                {
                    // Adapter l'objet Commande pour le constructeur de FormAjouterCommande
                    // Note: Idéalement, FormAjouterCommande devrait accepter un objet Commande directement
                    var commandeAnon = new
                    {
                        idCommande = commande.IdCommande,
                        dateCommande = commande.DateCommande,
                        montantTotale = commande.MontantTotale,
                        statut = commande.Statut,
                        dateLivraison = commande.DateLivraison,
                        idClient = commande.IdClient,
                        idAdmin = commande.IdAdmin
                    };

                    FormAjouterCommande formModif = new FormAjouterCommande(commandeAnon);

                    if (formModif.ShowDialog() == DialogResult.OK)
                    {
                        ChargerCommandes();
                        ChargerStatistiques();
                    }
                }
                else
                {
                    MessageBox.Show("Commande non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Dans FormListeCommandes.cs
        // Remplacez la méthode AfficherDetailsCommande par celle-ci :

        private void AfficherDetailsCommande(int idCommande)
        {
            try
            {
                // Récupérer les détails de la commande
                string sql = @"SELECT c.idCommande, c.dateCommande, c.montantTotale, c.statut, c.dateLivraison,
                             cl.nom + ' ' + cl.prenom AS nomClient, cl.CIN, cl.telephone, cl.adresse
                      FROM Commandes c
                      INNER JOIN Client cl ON c.idClient = cl.idClient
                      WHERE c.idCommande = @id";

                connexion.Open();
                SqlCommand cmd = new SqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@id", idCommande);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Créer le formulaire de détails avec design moderne
                    Form formDetails = new Form
                    {
                        Text = "Détails de la Commande",
                        Size = new Size(1000, 750),
                        StartPosition = FormStartPosition.CenterScreen,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        MaximizeBox = false,
                        MinimizeBox = false,
                        BackColor = Color.FromArgb(252, 248, 243)
                    };

                    // ===== HEADER =====
                    Panel panelHeader = new Panel
                    {
                        Dock = DockStyle.Top,
                        Height = 100,
                        BackColor = Color.FromArgb(34, 62, 91)
                    };

                    Label lblTitre = new Label
                    {
                        Text = "👁️ Détails de la Commande",
                        Font = new Font("Segoe UI", 20, FontStyle.Bold),
                        ForeColor = Color.FromArgb(252, 248, 243),
                        Location = new Point(30, 20),
                        AutoSize = true
                    };

                    Label lblSousTitre = new Label
                    {
                        Text = $"Commande N° {idCommande}",
                        Font = new Font("Segoe UI", 10),
                        ForeColor = Color.FromArgb(233, 244, 238),
                        Location = new Point(35, 65),
                        AutoSize = true
                    };

                    panelHeader.Controls.Add(lblTitre);
                    panelHeader.Controls.Add(lblSousTitre);

                    // ===== PANEL PRINCIPAL =====
                    Panel panelMain = new Panel
                    {
                        Location = new Point(30, 120),
                        Size = new Size(940, 570),
                        BackColor = Color.FromArgb(252, 248, 243),
                        AutoScroll = true
                    };

                    int yPos = 0;

                    // ===== GROUPE INFO COMMANDE =====
                    GroupBox groupCommande = new GroupBox
                    {
                        Text = "📋 Informations de la Commande",
                        Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        ForeColor = Color.FromArgb(34, 62, 91),
                        Location = new Point(0, yPos),
                        Size = new Size(920, 130),
                        BackColor = Color.White
                    };

                    // Statut avec couleur
                    Color statutColor = GetStatutColor(reader["statut"].ToString());

                    AddInfoLabel(groupCommande, "N° Commande:", idCommande.ToString(), 20, 30);
                    AddInfoLabel(groupCommande, "Date commande:", Convert.ToDateTime(reader["dateCommande"]).ToString("dd/MM/yyyy HH:mm"), 20, 60);
                    AddInfoLabel(groupCommande, "Date livraison:",
                        reader["dateLivraison"] != DBNull.Value ?
                        Convert.ToDateTime(reader["dateLivraison"]).ToString("dd/MM/yyyy") : "Non définie",
                        480, 60);

                    // Statut avec badge coloré
                    Label lblStatutTitle = new Label
                    {
                        Text = "Statut:",
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = Color.FromArgb(100, 100, 100),
                        Location = new Point(480, 30),
                        AutoSize = true
                    };

                    Label lblStatutValue = new Label
                    {
                        Text = reader["statut"].ToString(),
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = statutColor,
                        Location = new Point(560, 28),
                        Size = new Size(120, 30),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    groupCommande.Controls.Add(lblStatutTitle);
                    groupCommande.Controls.Add(lblStatutValue);

                    AddInfoLabel(groupCommande, "Montant total:",
                        Convert.ToDecimal(reader["montantTotale"]).ToString("0.00") + " DH",
                        20, 90, true);

                    panelMain.Controls.Add(groupCommande);
                    yPos += 145;

                    // ===== GROUPE CLIENT =====
                    GroupBox groupClient = new GroupBox
                    {
                        Text = "👤 Informations Client",
                        Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        ForeColor = Color.FromArgb(34, 62, 91),
                        Location = new Point(0, yPos),
                        Size = new Size(920, 110),
                        BackColor = Color.White
                    };

                    AddInfoLabel(groupClient, "Nom complet:", reader["nomClient"].ToString(), 20, 30);
                    AddInfoLabel(groupClient, "CIN:", reader["CIN"].ToString(), 480, 30);
                    AddInfoLabel(groupClient, "Téléphone:", reader["telephone"].ToString(), 20, 60);
                    AddInfoLabel(groupClient, "Adresse:", reader["adresse"].ToString(), 480, 60);

                    panelMain.Controls.Add(groupClient);
                    yPos += 125;

                    reader.Close();

                    // ===== GROUPE MÉDICAMENTS =====
                    GroupBox groupMedicaments = new GroupBox
                    {
                        Text = "💊 Médicaments Commandés",
                        Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        ForeColor = Color.FromArgb(34, 62, 91),
                        Location = new Point(0, yPos),
                        Size = new Size(920, 270),
                        BackColor = Color.White
                    };

                    // DataGridView pour les lignes
                    DataGridView dgvLignes = new DataGridView
                    {
                        Location = new Point(15, 35),
                        Size = new Size(890, 220),
                        BackgroundColor = Color.FromArgb(252, 248, 243),
                        BorderStyle = BorderStyle.None,
                        AllowUserToAddRows = false,
                        AllowUserToDeleteRows = false,
                        ReadOnly = true,
                        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        RowHeadersVisible = false,
                        EnableHeadersVisualStyles = false
                    };

                    // Style des en-têtes
                    dgvLignes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 62, 91);
                    dgvLignes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvLignes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dgvLignes.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);
                    dgvLignes.ColumnHeadersHeight = 45;

                    // Style des cellules
                    dgvLignes.DefaultCellStyle.BackColor = Color.White;
                    dgvLignes.DefaultCellStyle.ForeColor = Color.FromArgb(34, 62, 91);
                    dgvLignes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 244, 238);
                    dgvLignes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(34, 62, 91);
                    dgvLignes.DefaultCellStyle.Padding = new Padding(8);
                    dgvLignes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    dgvLignes.RowTemplate.Height = 40;
                    dgvLignes.GridColor = Color.FromArgb(233, 244, 238);
                    dgvLignes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

                    // Charger les lignes
                    string sqlLignes = @"SELECT m.nomMed AS Médicament, m.reference AS Référence,
                                       lc.quantite AS Quantité, lc.prixUnitaire AS 'Prix Unitaire',
                                       lc.prixTotale AS 'Prix Total'
                                FROM ligneCommande lc
                                INNER JOIN Medicament m ON lc.idMed = m.idMed
                                WHERE lc.idCommande = @id";

                    SqlDataAdapter da = new SqlDataAdapter(sqlLignes, connexion);
                    da.SelectCommand.Parameters.AddWithValue("@id", idCommande);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLignes.DataSource = dt;

                    // Formater les colonnes de prix
                    if (dgvLignes.Columns.Contains("Prix Unitaire"))
                        dgvLignes.Columns["Prix Unitaire"].DefaultCellStyle.Format = "0.00 DH";
                    if (dgvLignes.Columns.Contains("Prix Total"))
                        dgvLignes.Columns["Prix Total"].DefaultCellStyle.Format = "0.00 DH";

                    groupMedicaments.Controls.Add(dgvLignes);
                    panelMain.Controls.Add(groupMedicaments);

                    // ===== BOUTON FERMER =====
                    Button btnFermer = new Button
                    {
                        Text = "✕ Fermer",
                        Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        Size = new Size(150, 45),
                        Location = new Point(820, yPos + 280),
                        BackColor = Color.FromArgb(235, 203, 176),
                        ForeColor = Color.FromArgb(34, 62, 91),
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand
                    };
                    btnFermer.FlatAppearance.BorderSize = 0;
                    btnFermer.Click += (s, ev) => formDetails.Close();
                    panelMain.Controls.Add(btnFermer);

                    formDetails.Controls.Add(panelHeader);
                    formDetails.Controls.Add(panelMain);
                    formDetails.ShowDialog();
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des détails: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
        }

        // Méthode helper pour ajouter des labels d'information
        private void AddInfoLabel(Control parent, string title, string value, int x, int y, bool highlight = false)
        {
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(x, y),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 10, highlight ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = highlight ? Color.FromArgb(246, 145, 118) : Color.FromArgb(34, 62, 91),
                Location = new Point(x + 150, y),
                AutoSize = true
            };

            parent.Controls.Add(lblTitle);
            parent.Controls.Add(lblValue);
        }

        // Méthode pour obtenir la couleur du statut
        private Color GetStatutColor(string statut)
        {
            switch (statut)
            {
                case "En cours":
                    return Color.FromArgb(246, 145, 118); // Orange
                case "Validée":
                    return Color.FromArgb(46, 204, 113); // Vert
                case "Livrée":
                    return Color.FromArgb(52, 152, 219); // Bleu
                case "Annulée":
                    return Color.FromArgb(231, 76, 60); // Rouge
                default:
                    return Color.FromArgb(149, 165, 166); // Gris
            }
        }

        private void OuvrirFacture(int idCommande)
        {
            try
            {
                connexion.Open();

                // Vérifier si une facture existe déjà
                string queryCheck = "SELECT idFacture FROM Factures WHERE idCommande = @idCommande";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, connexion);
                cmdCheck.Parameters.AddWithValue("@idCommande", idCommande);

                object result = cmdCheck.ExecuteScalar();
                int idFacture = 0;

                if (result != null)
                {
                    // La facture existe déjà
                    idFacture = Convert.ToInt32(result);
                    connexion.Close();
                }
                else
                {
                    // Créer une nouvelle facture avec TOUS les attributs requis

                    // 1. Récupérer les informations de la commande
                    string queryCommande = @"SELECT c.montantTotale 
                                    FROM Commandes c 
                                    WHERE c.idCommande = @idCommande";

                    SqlCommand cmdCommande = new SqlCommand(queryCommande, connexion);
                    cmdCommande.Parameters.AddWithValue("@idCommande", idCommande);

                    decimal montantTotal = 0;
                    object montantResult = cmdCommande.ExecuteScalar();

                    if (montantResult != null)
                    {
                        montantTotal = Convert.ToDecimal(montantResult);
                    }
                    else
                    {
                        connexion.Close();
                        MessageBox.Show("Commande introuvable.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 2. Générer le numéro de facture unique
                    string numFacture = "FACT-" + DateTime.Now.ToString("yyyyMMdd") + "-" + idCommande.ToString("D5");

                    // 3. Insérer la facture avec TOUS les attributs
                    string queryInsert = @"INSERT INTO Factures 
                                  (numFacture, dateFacture, datePaiement, statusPaiement, 
                                   modePaiement, idCommande) 
                                  VALUES 
                                  (@numFacture, @dateFacture, NULL, @statusPaiement, 
                                   NULL, @idCommande);
                                  SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdInsert = new SqlCommand(queryInsert, connexion);
                    cmdInsert.Parameters.AddWithValue("@numFacture", numFacture);
                    cmdInsert.Parameters.AddWithValue("@dateFacture", DateTime.Now);
                    cmdInsert.Parameters.AddWithValue("@statusPaiement", "Non payée");
                    cmdInsert.Parameters.AddWithValue("@idCommande", idCommande);

                    idFacture = Convert.ToInt32(cmdInsert.ExecuteScalar());
                    connexion.Close();

                    MessageBox.Show("Facture générée avec succès !\nNuméro: " + numFacture,
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Ouvrir le formulaire de la facture
                FormFacture f = new FormFacture(idCommande);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération de la facture: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            FormListeFournisseurs fournisseurs = new FormListeFournisseurs();
            fournisseurs.Show();
            this.Close();
        }

        private void panelStatTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMedicaments_Click(object sender, EventArgs e)
        {
            EspaceAdmin admin = new EspaceAdmin();
            admin.Show();
            this.Close();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ConsulterClients clients = new ConsulterClients();
            clients.Show();
            this.Close();
        }

        private void buttonAlertes_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.Show();
            this.Close();
        }

        private void buttonCommandes_Click(object sender, EventArgs e)
        {

        }

        private void labelTitre_Click(object sender, EventArgs e)
        {

        }

        private void buttonRafraichir_Click(object sender, EventArgs e)
        {
            ChargerCommandes();
            ChargerStatistiques();
            textRecherche.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (connexion != null && connexion.State == ConnectionState.Open)
                connexion.Close();
            base.OnFormClosing(e);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}