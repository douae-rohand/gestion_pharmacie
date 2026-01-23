using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class Notification : Form
    {
        private string connectionString = "data source =IN-5CG3444P44\\GI2;initial catalog = Pharmacie; integrated security = SSPI; TrustServerCertificate=True";

        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            // Initialiser le ComboBox
            comboNiveau.Items.Clear();
            comboNiveau.Items.AddRange(new string[] { "Tous", "Critique", "Urgent", "Attention" });
            comboNiveau.SelectedIndex = 0;

            // Charger les données
            ChargerAlertes();
            ChargerStatistiques();
        }

        private void ChargerStatistiques()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                            COUNT(CASE WHEN quantiteStocke = 0 THEN 1 END) AS Critique,
                            COUNT(CASE WHEN quantiteStocke > 0 AND quantiteStocke <= (seuilAlerte * 0.5) THEN 1 END) AS Urgent,
                            COUNT(CASE WHEN quantiteStocke > (seuilAlerte * 0.5) AND quantiteStocke <= seuilAlerte THEN 1 END) AS Attention
                        FROM Medicament
                        WHERE quantiteStocke <= seuilAlerte";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        labelStatCritiqueValeur.Text = reader["Critique"].ToString();
                        labelStatUrgentValeur.Text = reader["Urgent"].ToString();
                        labelStatAttentionValeur.Text = reader["Attention"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerAlertes(string niveauFiltre = "Tous")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string whereClause = "";
                    switch (niveauFiltre)
                    {
                        case "Critique":
                            whereClause = "AND m.quantiteStocke = 0";
                            break;
                        case "Urgent":
                            whereClause = "AND m.quantiteStocke > 0 AND m.quantiteStocke <= (m.seuilAlerte * 0.5)";
                            break;
                        case "Attention":
                            whereClause = "AND m.quantiteStocke > (m.seuilAlerte * 0.5) AND m.quantiteStocke <= m.seuilAlerte";
                            break;
                    }

                    // Requête adaptée à la nouvelle structure avec la table fournit
                    string query = $@"
                        SELECT 
                            m.reference AS 'Référence',
                            m.nomMed AS 'Nom Médicament',
                            c.nomCategorie AS 'Catégorie',
                            m.quantiteStocke AS 'Stock Actuel',
                            m.seuilAlerte AS 'Seuil Alerte',
                            (m.seuilAlerte - m.quantiteStocke) AS 'Manquant',
                            CASE 
                                WHEN m.quantiteStocke = 0 THEN 'CRITIQUE'
                                WHEN m.quantiteStocke <= (m.seuilAlerte * 0.5) THEN 'URGENT'
                                ELSE 'ATTENTION'
                            END AS 'Niveau',
                            ISNULL(f.nomEntreprise, 'Aucun fournisseur') AS 'Fournisseur',
                            ISNULL(f.telephone, 'N/A') AS 'Tél. Fournisseur',
                            ISNULL(fo.prixAchat, 0) AS 'Prix Achat',
                            m.prixVente AS 'Prix Vente',
                            m.datePeremption AS 'Date Péremption'
                        FROM Medicament m
                        LEFT JOIN Categories c ON m.idCategorie = c.idCategorie
                        LEFT JOIN fournit fo ON m.idMed = fo.idMed
                        LEFT JOIN Fournisseurs f ON fo.idFournisseur = f.idFournisseur
                        WHERE m.quantiteStocke <= m.seuilAlerte {whereClause}
                        ORDER BY 
                            CASE 
                                WHEN m.quantiteStocke = 0 THEN 1
                                WHEN m.quantiteStocke <= (m.seuilAlerte * 0.5) THEN 2
                                ELSE 3
                            END,
                            m.quantiteStocke ASC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewAlertes.DataSource = dt;

                    // Configuration des colonnes
                    ConfigurerDataGridView();

                    // Format date
                    if (dataGridViewAlertes.Columns.Contains("Date Péremption"))
                    {
                        dataGridViewAlertes.Columns["Date Péremption"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }

                    // Format prix
                    if (dataGridViewAlertes.Columns.Contains("Prix Achat"))
                    {
                        dataGridViewAlertes.Columns["Prix Achat"].DefaultCellStyle.Format = "N2";
                    }
                    if (dataGridViewAlertes.Columns.Contains("Prix Vente"))
                    {
                        dataGridViewAlertes.Columns["Prix Vente"].DefaultCellStyle.Format = "N2";
                    }

                    // Colorer les lignes selon le niveau d'alerte
                    foreach (DataGridViewRow row in dataGridViewAlertes.Rows)
                    {
                        if (row.Cells["Niveau"].Value != null)
                        {
                            string niveau = row.Cells["Niveau"].Value.ToString();

                            switch (niveau)
                            {
                                case "CRITIQUE":
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                                    row.DefaultCellStyle.ForeColor = Color.FromArgb(139, 0, 0);
                                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                                    break;
                                case "URGENT":
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 237, 213);
                                    row.DefaultCellStyle.ForeColor = Color.FromArgb(139, 69, 19);
                                    break;
                                case "ATTENTION":
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 224);
                                    row.DefaultCellStyle.ForeColor = Color.FromArgb(139, 115, 85);
                                    break;
                            }
                        }
                    }

                    // Afficher le nombre d'alertes
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Aucune alerte de stock !",
                            "Stock OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Optionnel: afficher le nombre d'alertes dans le titre ou une étiquette
                        this.Text = $"Notifications - {dt.Rows.Count} alerte(s)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des alertes :\n{ex.Message}\n\nDétails: {ex.StackTrace}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurerDataGridView()
        {
            // Configuration de l'apparence du DataGridView
            dataGridViewAlertes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlertes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlertes.MultiSelect = false;
            dataGridViewAlertes.ReadOnly = true;
            dataGridViewAlertes.AllowUserToAddRows = false;
            dataGridViewAlertes.AllowUserToDeleteRows = false;

            // Configuration des largeurs de colonnes spécifiques
            if (dataGridViewAlertes.Columns.Contains("Référence"))
                dataGridViewAlertes.Columns["Référence"].FillWeight = 80;

            if (dataGridViewAlertes.Columns.Contains("Nom Médicament"))
                dataGridViewAlertes.Columns["Nom Médicament"].FillWeight = 120;

            if (dataGridViewAlertes.Columns.Contains("Catégorie"))
                dataGridViewAlertes.Columns["Catégorie"].FillWeight = 90;

            if (dataGridViewAlertes.Columns.Contains("Stock Actuel"))
                dataGridViewAlertes.Columns["Stock Actuel"].FillWeight = 70;

            if (dataGridViewAlertes.Columns.Contains("Seuil Alerte"))
                dataGridViewAlertes.Columns["Seuil Alerte"].FillWeight = 70;

            if (dataGridViewAlertes.Columns.Contains("Manquant"))
                dataGridViewAlertes.Columns["Manquant"].FillWeight = 70;

            if (dataGridViewAlertes.Columns.Contains("Niveau"))
                dataGridViewAlertes.Columns["Niveau"].FillWeight = 80;

            if (dataGridViewAlertes.Columns.Contains("Fournisseur"))
                dataGridViewAlertes.Columns["Fournisseur"].FillWeight = 100;

            if (dataGridViewAlertes.Columns.Contains("Tél. Fournisseur"))
                dataGridViewAlertes.Columns["Tél. Fournisseur"].FillWeight = 90;

            if (dataGridViewAlertes.Columns.Contains("Prix Achat"))
                dataGridViewAlertes.Columns["Prix Achat"].FillWeight = 70;

            if (dataGridViewAlertes.Columns.Contains("Prix Vente"))
                dataGridViewAlertes.Columns["Prix Vente"].FillWeight = 70;

            if (dataGridViewAlertes.Columns.Contains("Date Péremption"))
                dataGridViewAlertes.Columns["Date Péremption"].FillWeight = 90;
        }

        private void comboNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNiveau.SelectedItem != null)
            {
                ChargerAlertes(comboNiveau.SelectedItem.ToString());
            }
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            string niveauActuel = comboNiveau.SelectedItem?.ToString() ?? "Tous";
            ChargerAlertes(niveauActuel);
            ChargerStatistiques();
            MessageBox.Show("Données actualisées avec succès!", "Actualisation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.Close();
            }
        }

        private void buttonMedicaments_Click(object sender, EventArgs e)
        {
            EspaceAdmin adminForm = new EspaceAdmin();
            adminForm.Show();
            this.Close();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ConsulterClients clients = new ConsulterClients();
            clients.Show();
            this.Close();
        }

        private void dataGridViewAlertes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optionnel: afficher les détails du médicament sélectionné
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAlertes.Rows[e.RowIndex];
                string reference = row.Cells["Référence"].Value?.ToString() ?? "";
                string nomMed = row.Cells["Nom Médicament"].Value?.ToString() ?? "";
                string niveau = row.Cells["Niveau"].Value?.ToString() ?? "";

                // Vous pouvez ajouter ici une action spécifique
                // Par exemple, ouvrir un formulaire de détails ou de commande
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void buttonCommande_Click(object sender, EventArgs e)
        {
            FormListeCommandes comm = new FormListeCommandes();
            comm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListeFournisseurs fournisseurs = new FormListeFournisseurs();
            fournisseurs.Show();
            this.Close();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}