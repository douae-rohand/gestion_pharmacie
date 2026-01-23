using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class FormAjouterCommande : Form
    {
        private SqlConnection connexion;
        private bool isModification = false;
        private dynamic commandeExistante;
        private DataTable dtLignesCommande;
        private int idCommandeModif = 0;
        private string connectionString = "data source =IN-5CG3444P44\\GI2;initial catalog = Pharmacie; integrated security = SSPI; TrustServerCertificate=True";

        public FormAjouterCommande()
        {
            InitializeComponent();
            InitializeConnection();
            InitializeDataTable();
        }

        // CONSTRUCTEUR POUR LA MODIFICATION
        public FormAjouterCommande(dynamic commandeExistante)
        {
            InitializeComponent();
            InitializeConnection();
            InitializeDataTable();

            // Marquer comme modification
            isModification = true;
            this.commandeExistante = commandeExistante;
            idCommandeModif = Convert.ToInt32(commandeExistante.idCommande);

            // Charger les données
            this.Load += (s, e) =>
            {
                // Sélectionner le client
                comboBoxClient.SelectedValue = commandeExistante.idClient;

                // Définir les dates
                dateCommande.Value = Convert.ToDateTime(commandeExistante.dateCommande);

                if (commandeExistante.dateLivraison != null)
                {
                    dateLivraison.Value = Convert.ToDateTime(commandeExistante.dateLivraison);
                }

                // Définir le statut
                comboBoxStatut.SelectedItem = commandeExistante.statut.ToString();

                // Charger les lignes de commande existantes
                ChargerLignesCommandeExistantes(idCommandeModif);
            };
        }

        private void InitializeConnection()
        {
            connexion = new SqlConnection();
            connexion.ConnectionString = connectionString;
        }

        private void InitializeDataTable()
        {
            dtLignesCommande = new DataTable();
            dtLignesCommande.Columns.Add("idMed", typeof(int));
            dtLignesCommande.Columns.Add("Médicament", typeof(string));
            dtLignesCommande.Columns.Add("Quantité", typeof(int));
            dtLignesCommande.Columns.Add("Prix Unitaire", typeof(decimal));
            dtLignesCommande.Columns.Add("Prix Total", typeof(decimal));

            dataGridViewLignes.DataSource = dtLignesCommande;
            if (dataGridViewLignes.Columns.Contains("idMed"))
                dataGridViewLignes.Columns["idMed"].Visible = false;
        }

        private void FormAjouterCommande_Load(object sender, EventArgs e)
        {
            ChargerClients();
            ChargerMedicaments();

            // Initialiser le statut
            if (comboBoxStatut.Items.Count == 0)
            {
                comboBoxStatut.Items.AddRange(new string[] { "En cours", "Validée", "Annulée", "Livrée" });
            }

            if (!isModification)
            {
                dateCommande.Value = DateTime.Now;
                dateLivraison.Value = DateTime.Now.AddDays(7);
                comboBoxStatut.SelectedIndex = 0; // En cours
            }

            comboBoxStatut.SelectedIndexChanged += comboBoxStatut_SelectedIndexChanged;

            CalculerMontantTotal();
        }

        private void ChargerClients()
        {
            try
            {
                string sql = @"SELECT idClient, 
                              CONCAT(nom, ' ', prenom, ' - CIN: ', CIN) AS nomComplet 
                              FROM Client 
                              ORDER BY nom, prenom";
                connexion.Open();
                SqlDataAdapter dp = new SqlDataAdapter(sql, connexion);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                comboBoxClient.DataSource = dt;
                comboBoxClient.DisplayMember = "nomComplet";
                comboBoxClient.ValueMember = "idClient";
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement clients : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
        }

        private void ChargerMedicaments()
        {
            try
            {
                string sql = @"SELECT idMed, 
                              CONCAT(nomMed, ' - ', reference, ' (Stock: ', quantiteStocke, ')') AS nomComplet,
                              prixVente,
                              quantiteStocke
                              FROM Medicament 
                              WHERE quantiteStocke > 0
                              and statut = 'actif'
                              ORDER BY nomMed";
                connexion.Open();
                SqlDataAdapter dp = new SqlDataAdapter(sql, connexion);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                comboBoxMedicament.DataSource = dt;
                comboBoxMedicament.DisplayMember = "nomComplet";
                comboBoxMedicament.ValueMember = "idMed";
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement médicaments : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
        }

        private void ChargerLignesCommandeExistantes(int idCommande)
        {
            try
            {
                List<LigneCommande> lignes = Commande.ObtenirLignes(idCommande);
                dtLignesCommande.Clear();

                foreach (var ligne in lignes)
                {
                    dtLignesCommande.Rows.Add(
                        ligne.IdMed,
                        ligne.NomMed,
                        ligne.Quantite,
                        ligne.PrixUnitaire,
                        ligne.PrixTotal
                    );
                }

                CalculerMontantTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des lignes: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMedicament.SelectedValue != null)
            {
                try
                {
                    DataRowView selectedRow = (DataRowView)comboBoxMedicament.SelectedItem;
                    if (selectedRow != null)
                    {
                        numericPrixUnitaire.Value = Convert.ToDecimal(selectedRow["prixVente"]);
                        int stockDisponible = Convert.ToInt32(selectedRow["quantiteStocke"]);
                        numericQuantite.Maximum = stockDisponible;
                    }
                }
                catch { }
            }
        }

        private void buttonAjouterLigne_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicament.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un médicament.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericQuantite.Value <= 0)
            {
                MessageBox.Show("La quantité doit être supérieure à 0.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int idMed = Convert.ToInt32(comboBoxMedicament.SelectedValue);

                // Vérifier si le médicament est déjà dans la liste
                foreach (DataRow row in dtLignesCommande.Rows)
                {
                    if (Convert.ToInt32(row["idMed"]) == idMed)
                    {
                        MessageBox.Show("Ce médicament est déjà dans la commande. Modifiez la quantité si nécessaire.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                DataRowView selectedMed = (DataRowView)comboBoxMedicament.SelectedItem;
                string nomMed = selectedMed["nomComplet"].ToString();
                decimal quantite = numericQuantite.Value;
                decimal prixUnitaire = numericPrixUnitaire.Value;
                decimal prixTotal = quantite * prixUnitaire;

                dtLignesCommande.Rows.Add(idMed, nomMed, quantite, prixUnitaire, prixTotal);

                CalculerMontantTotal();

                // Réinitialiser les champs
                comboBoxMedicament.SelectedIndex = -1;
                numericQuantite.Value = 1;
                numericPrixUnitaire.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSupprimerLigne_Click(object sender, EventArgs e)
        {
            if (dataGridViewLignes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewLignes.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridViewLignes.Rows.Remove(row);
                        }
                    }
                    CalculerMontantTotal();
                }
            }
        }

        private void CalculerMontantTotal()
        {
            try
            {
                decimal total = 0;

                if (dtLignesCommande != null && dtLignesCommande.Rows.Count > 0)
                {
                    foreach (DataRow row in dtLignesCommande.Rows)
                    {
                        if (row["Prix Total"] != DBNull.Value)
                        {
                            total += Convert.ToDecimal(row["Prix Total"]);
                        }
                    }
                }

                textMontantTotal.Text = total.ToString("0.00") + " DH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du calcul du total: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValiderFormulaire()
        {
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxClient.Focus();
                return false;
            }

            if (dtLignesCommande.Rows.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins un médicament à la commande.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateLivraison.Value < dateCommande.Value)
            {
                MessageBox.Show("La date de livraison ne peut pas être antérieure à la date de commande.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateLivraison.Focus();
                return false;
            }

            return true;
        }

        private List<LigneCommande> ConvertirDataTableEnListe()
        {
            List<LigneCommande> lignes = new List<LigneCommande>();
            foreach (DataRow row in dtLignesCommande.Rows)
            {
                lignes.Add(new LigneCommande
                {
                    IdMed = Convert.ToInt32(row["idMed"]),
                    NomMed = row["Médicament"].ToString(),
                    Quantite = Convert.ToInt32(row["Quantité"]),
                    PrixUnitaire = Convert.ToDecimal(row["Prix Unitaire"])
                });
            }
            return lignes;
        }

        private void AjouterCommande()
        {
            try
            {
                decimal montantTotal = 0;
                foreach (DataRow row in dtLignesCommande.Rows)
                {
                    montantTotal += Convert.ToDecimal(row["Prix Total"]);
                }

                Commande nouvelleCommande = new Commande
                {
                    DateCommande = dateCommande.Value,
                    MontantTotale = montantTotal,
                    Statut = comboBoxStatut.Text,
                    DateLivraison = dateLivraison.Value,
                    IdAdmin = 1, // ID de l'admin connecté
                    IdClient = Convert.ToInt32(comboBoxClient.SelectedValue)
                };

                List<LigneCommande> lignes = ConvertirDataTableEnListe();

                if (nouvelleCommande.Ajouter(lignes))
                {
                    MessageBox.Show("Commande ajoutée avec succès!\nLa facture pourra être générée depuis la liste des commandes.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifierCommande()
        {
            try
            {
                decimal montantTotal = 0;
                foreach (DataRow row in dtLignesCommande.Rows)
                {
                    montantTotal += Convert.ToDecimal(row["Prix Total"]);
                }

                Commande commandeModifiee = new Commande
                {
                    IdCommande = idCommandeModif,
                    DateCommande = dateCommande.Value,
                    MontantTotale = montantTotal,
                    Statut = comboBoxStatut.Text,
                    DateLivraison = dateLivraison.Value,
                    IdClient = Convert.ToInt32(comboBoxClient.SelectedValue)
                };

                List<LigneCommande> lignes = ConvertirDataTableEnListe();
                string ancienStatut = commandeExistante.statut.ToString();

                if (commandeModifiee.Modifier(lignes, ancienStatut))
                {
                    MessageBox.Show("Commande modifiée avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification: " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonajouter_Click(object sender, EventArgs e)
        {
            if (ValiderFormulaire())
            {
                if (isModification)
                {
                    ModifierCommande();
                }
                else
                {
                    AjouterCommande();
                }
            }
        }

        private void buttonannuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBoxStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifier si on passe en mode modification et que le statut change vers "Annulée"
            if (isModification && comboBoxStatut.Text == "Annulée" &&
                commandeExistante.statut.ToString() != "Annulée")
            {
                DialogResult result = MessageBox.Show(
                    "Attention ! En annulant cette commande, les quantités des médicaments seront restaurées dans le stock.\n\nConfirmez-vous l'annulation ?",
                    "Confirmation d'annulation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    // Restaurer l'ancien statut
                    comboBoxStatut.Text = commandeExistante.statut.ToString();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (connexion != null && connexion.State == ConnectionState.Open)
                connexion.Close();
            base.OnFormClosing(e);
        }

        private void textMontantTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxInfoCommande_Enter(object sender, EventArgs e)
        {

        }
    }
}