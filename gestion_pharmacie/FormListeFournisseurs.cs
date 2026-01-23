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
    public partial class FormListeFournisseurs : Form
    {
        // Chaîne de connexion à la base de données
        private SqlConnection connexion;
        private string connectionString = "data source =IN-5CG3444P44\\GI2;initial catalog = Pharmacie; integrated security = SSPI; TrustServerCertificate=True";

        public FormListeFournisseurs()
        {
            InitializeComponent();
            connexion = new SqlConnection();
            connexion.ConnectionString = connectionString;
            ConfigurerDataGridView();
            ChargerFournisseurs();
            AfficherStatistiques();
            InitialiserEvenements();
        }

        private void ConfigurerDataGridView()
        {
            // Configuration des colonnes du DataGridView
            clientGridView.Columns.Clear();
            clientGridView.ReadOnly = false; // Permettre la modification

            // Colonne ID (cachée)
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "idFournisseur";
            colId.HeaderText = "ID";
            colId.ReadOnly = true;
            colId.Visible = false;
            clientGridView.Columns.Add(colId);

            // Colonne Nom Entreprise (éditable)
            DataGridViewTextBoxColumn colNom = new DataGridViewTextBoxColumn();
            colNom.Name = "nomEntreprise";
            colNom.HeaderText = "Nom de l'Entreprise";
            colNom.Width = 400;
            colNom.ReadOnly = false;
            clientGridView.Columns.Add(colNom);

            // Colonne Téléphone (éditable)
            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.Name = "telephone";
            colTel.HeaderText = "Téléphone";
            colTel.Width = 200;
            colTel.ReadOnly = false;
            clientGridView.Columns.Add(colTel);

            // Bouton Enregistrer
            DataGridViewButtonColumn btnEnregistrer = new DataGridViewButtonColumn();
            btnEnregistrer.Name = "Enregistrer";
            btnEnregistrer.HeaderText = "Enregistrer";
            btnEnregistrer.Text = "💾";
            btnEnregistrer.UseColumnTextForButtonValue = true;
            btnEnregistrer.Width = 120;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            clientGridView.Columns.Add(btnEnregistrer);

            // Bouton Supprimer
            DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
            btnSupprimer.Name = "Supprimer";
            btnSupprimer.HeaderText = "Supprimer";
            btnSupprimer.Text = "🗑️";
            btnSupprimer.UseColumnTextForButtonValue = true;
            btnSupprimer.Width = 120;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            clientGridView.Columns.Add(btnSupprimer);

            // Événements
            clientGridView.CellContentClick += ClientGridView_CellContentClick;
            clientGridView.CellBeginEdit += ClientGridView_CellBeginEdit;
            clientGridView.CellEndEdit += ClientGridView_CellEndEdit;
        }

        private void ClientGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Sauvegarder la valeur originale avant modification
            if (clientGridView.Rows[e.RowIndex].Tag == null)
            {
                clientGridView.Rows[e.RowIndex].Tag = new Dictionary<string, object>();
            }

            var originalValues = (Dictionary<string, object>)clientGridView.Rows[e.RowIndex].Tag;
            string columnName = clientGridView.Columns[e.ColumnIndex].Name;

            if (!originalValues.ContainsKey(columnName))
            {
                originalValues[columnName] = clientGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private void ClientGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Changer la couleur de la ligne modifiée
            clientGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 205); // Jaune clair
        }

        private void ChargerFournisseurs()
        {
            try
            {
                DataTable dt = Fournisseur.ObtenirTous();
                clientGridView.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int index = clientGridView.Rows.Add(
                        row["idFournisseur"],
                        row["nomEntreprise"],
                        row["telephone"] != DBNull.Value ? row["telephone"] : ""
                    );

                    // Réinitialiser la couleur de fond
                    clientGridView.Rows[index].DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherStatistiques()
        {
            try
            {
                int total = Fournisseur.ObtenirNombreTotal();
                labelStatTotalValeur.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du calcul des statistiques: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (clientGridView.Rows[e.RowIndex].Cells["idFournisseur"].Value == null ||
                clientGridView.Rows[e.RowIndex].Cells["idFournisseur"].Value.ToString() == "0")
            {
                // C'est une nouvelle ligne
                if (clientGridView.Columns[e.ColumnIndex].Name == "Enregistrer")
                {
                    AjouterNouveauFournisseur(e.RowIndex);
                }
            }
            else
            {
                // C'est une ligne existante
                int idFournisseur = Convert.ToInt32(clientGridView.Rows[e.RowIndex].Cells["idFournisseur"].Value);

                if (clientGridView.Columns[e.ColumnIndex].Name == "Enregistrer")
                {
                    EnregistrerModifications(e.RowIndex);
                }
                else if (clientGridView.Columns[e.ColumnIndex].Name == "Supprimer")
                {
                    string nomEntreprise = clientGridView.Rows[e.RowIndex].Cells["nomEntreprise"].Value?.ToString() ?? "";
                    SupprimerFournisseur(idFournisseur, nomEntreprise);
                }
            }
        }

        private void AjouterNouveauFournisseur(int rowIndex)
        {
            try
            {
                // Récupérer les valeurs de la ligne
                string nomEntreprise = clientGridView.Rows[rowIndex].Cells["nomEntreprise"].Value?.ToString()?.Trim() ?? "";
                string telephone = clientGridView.Rows[rowIndex].Cells["telephone"].Value?.ToString()?.Trim() ?? "";

                // Validation
                if (string.IsNullOrWhiteSpace(nomEntreprise))
                {
                    MessageBox.Show("Le nom de l'entreprise ne peut pas être vide.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Fournisseur nouveauFournisseur = new Fournisseur(nomEntreprise, telephone);

                if (nouveauFournisseur.Ajouter())
                {
                    MessageBox.Show("Fournisseur ajouté avec succès!",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recharger la liste
                    ChargerFournisseurs();
                    AfficherStatistiques();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnregistrerModifications(int rowIndex)
        {
            try
            {
                // Récupérer les valeurs de la ligne
                int idFournisseur = Convert.ToInt32(clientGridView.Rows[rowIndex].Cells["idFournisseur"].Value);
                string nomEntreprise = clientGridView.Rows[rowIndex].Cells["nomEntreprise"].Value?.ToString()?.Trim() ?? "";
                string telephone = clientGridView.Rows[rowIndex].Cells["telephone"].Value?.ToString()?.Trim() ?? "";

                // Validation
                if (string.IsNullOrWhiteSpace(nomEntreprise))
                {
                    MessageBox.Show("Le nom de l'entreprise ne peut pas être vide.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Fournisseur fournisseur = new Fournisseur
                {
                    IdFournisseur = idFournisseur,
                    NomEntreprise = nomEntreprise,
                    Telephone = telephone
                };

                if (fournisseur.Modifier())
                {
                    MessageBox.Show("Fournisseur modifié avec succès!",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Réinitialiser la couleur de fond
                    clientGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                    clientGridView.Rows[rowIndex].Tag = null; // Effacer les valeurs originales
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SupprimerFournisseur(int idFournisseur, string nomEntreprise)
        {
            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer le fournisseur '{nomEntreprise}' ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Fournisseur.Supprimer(idFournisseur))
                    {
                        MessageBox.Show("Fournisseur supprimé avec succès!",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChargerFournisseurs();
                        AfficherStatistiques();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression: " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textRecherche_TextChanged(object sender, EventArgs e)
        {
            // Recherche dynamique pendant la saisie
            if (string.IsNullOrWhiteSpace(textRecherche.Text))
            {
                ChargerFournisseurs();
            }
            else
            {
                RechercherFournisseurs();
            }
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            RechercherFournisseurs();
        }

        private void RechercherFournisseurs()
        {
            string critere = comboCritere.Text;
            string recherche = textRecherche.Text.Trim();

            if (string.IsNullOrEmpty(critere))
            {
                MessageBox.Show("Veuillez sélectionner un critère de recherche.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = Fournisseur.Rechercher(critere, recherche);
                clientGridView.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    clientGridView.Rows.Add(
                        row["idFournisseur"],
                        row["nomEntreprise"],
                        row["telephone"] != DBNull.Value ? row["telephone"] : ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // Ajouter une nouvelle ligne vide dans le DataGridView
            int index = clientGridView.Rows.Add(0, "", "");

            // Mettre en surbrillance la nouvelle ligne
            clientGridView.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); // Vert clair

            // Commencer l'édition sur la cellule du nom
            clientGridView.CurrentCell = clientGridView.Rows[index].Cells["nomEntreprise"];
            clientGridView.BeginEdit(true);

            MessageBox.Show("Remplissez les informations du nouveau fournisseur, puis cliquez sur 💾 pour enregistrer.",
                "Nouveau fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRafraichir_Click(object sender, EventArgs e)
        {
            textRecherche.Clear();
            comboCritere.SelectedIndex = -1;
            ChargerFournisseurs();
            AfficherStatistiques();
        }

        private void InitialiserEvenements()
        {
            buttonRecherche.Click += buttonRecherche_Click;
            buttonAjouter.Click += buttonAjouter_Click;
            buttonRafraichir.Click += buttonRafraichir_Click;
            buttonDeconnexion.Click += buttonDeconnexion_Click;
            textRecherche.TextChanged += textRecherche_TextChanged;

            // Sélectionner le premier critère par défaut
            if (comboCritere.Items.Count > 0)
            {
                comboCritere.SelectedIndex = 0;
            }
        }

        private void labelTitre_Click(object sender, EventArgs e)
        {
            // Événement vide
        }

        private void buttonMedicaments_Click(object sender, EventArgs e)
        {
            EspaceAdmin medicaments = new EspaceAdmin();
            medicaments.Show();
            this.Close();
        }

        private void buttonCommandes_Click(object sender, EventArgs e)
        {
            FormListeCommandes commandes = new FormListeCommandes();
            commandes.Show();
            this.Close();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ConsulterClients consulterClients = new ConsulterClients();
            consulterClients.Show();
            this.Close();
        }

        private void buttonAlertes_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.Show();
            this.Close();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment vous déconnecter ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Retour à la page de connexion
                connexion login = new connexion();
                login.Show();
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (connexion != null && connexion.State == ConnectionState.Open)
                connexion.Close();
            base.OnFormClosing(e);
        }

        private void clientGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}