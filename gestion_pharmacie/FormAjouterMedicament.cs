using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class FormAjouterMedicament : Form
    {
        private SqlConnection connexion;
        private bool isModification = false;
        private Medicament medicamentActuel;
        private string cheminPhoto = "";
        private byte[] photoBytes = null;

        #region Constructeurs

        public FormAjouterMedicament()
        {
            InitializeComponent();
            InitializeConnection();
            medicamentActuel = new Medicament();
        }

        // CONSTRUCTEUR POUR LA MODIFICATION
        public FormAjouterMedicament(dynamic medicamentData) : this()
        {
            isModification = true;
            Text = "Modifier un médicament";
            label1.Text = "Modifier un médicament";
            buttonajoute.Text = "Modifier";

            // Charger le médicament depuis la base de données
            int idMed = Convert.ToInt32(medicamentData.idMed);
            medicamentActuel = Medicament.ObtenirParId(idMed);
        }

        #endregion

        #region Initialisation

        private void InitializeConnection()
        {
            connexion = new SqlConnection();
            connexion.ConnectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";
        }

        private void FormAjouterMedicament_Load(object sender, EventArgs e)
        {
            ChargerCategories();
            ChargerFournisseurs();

            // Si c'est une modification, remplir les champs
            if (isModification && medicamentActuel != null)
            {
                RemplirChamps();
            }
        }

        #endregion

        #region Chargement des Données

        private void ChargerCategories()
        {
            try
            {
                string sql = "SELECT idCategorie, nomCategorie FROM Categories ORDER BY nomCategorie";
                connexion.Open();
                SqlDataAdapter dp = new SqlDataAdapter(sql, connexion);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                comboBoxcategorie.DataSource = dt;
                comboBoxcategorie.DisplayMember = "nomCategorie";
                comboBoxcategorie.ValueMember = "idCategorie";
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
        }

        private void ChargerFournisseurs()
        {
            try
            {
                string sql = @"SELECT idFournisseur, nomEntreprise 
                              FROM Fournisseurs 
                              ORDER BY nomEntreprise";
                connexion.Open();
                SqlDataAdapter dp = new SqlDataAdapter(sql, connexion);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                comboBoxfornisseur.DataSource = dt;
                comboBoxfornisseur.DisplayMember = "nomEntreprise";
                comboBoxfornisseur.ValueMember = "idFournisseur";
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement fournisseurs : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
        }

        #endregion

        #region Remplissage des Champs (Modification)

        private void RemplirChamps()
        {
            if (medicamentActuel == null) return;

            try
            {
                // Informations de base
                textreference.Text = medicamentActuel.Reference ?? "";
                textnom.Text = medicamentActuel.NomMed ?? "";
                textdescription.Text = medicamentActuel.Description ?? "";

                // Catégorie
                if (medicamentActuel.IdCategorie.HasValue)
                {
                    comboBoxcategorie.SelectedValue = medicamentActuel.IdCategorie.Value;
                }

                // Fournisseur
                if (medicamentActuel.IdFournisseur.HasValue)
                {
                    comboBoxfornisseur.SelectedValue = medicamentActuel.IdFournisseur.Value;
                }

                // Prix
                if (medicamentActuel.PrixAchat.HasValue)
                {
                    prixachat.Value = medicamentActuel.PrixAchat.Value;
                }
                prixvente.Value = medicamentActuel.PrixVente;

                // Quantités
                quantite.Value = medicamentActuel.QuantiteStocke;
                seuil.Value = medicamentActuel.SeuilAlerte;

                // Date de péremption
                dateTimePicker.Value = medicamentActuel.DatePeremption;

                // Photo
                if (medicamentActuel.Photo != null && medicamentActuel.Photo.Length > 0)
                {
                    photoBytes = medicamentActuel.Photo;
                    ChargerPhotoDepuisBytes(photoBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du remplissage des champs: {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerPhotoDepuisBytes(byte[] bytes)
        {
            try
            {
                if (bytes != null && bytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        picturemedicament.Image = Image.FromStream(ms);
                        textpath.Text = "[Photo chargée depuis la base de données]";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de la photo: {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Gestion de la Photo

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Affichage dans PictureBox
                    picturemedicament.Image = Image.FromFile(dialog.FileName);
                    cheminPhoto = dialog.FileName;
                    textpath.Text = dialog.FileName;

                    // Convertir l'image en bytes
                    photoBytes = File.ReadAllBytes(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement de la photo: {ex.Message}",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Validation

        private bool ValiderFormulaire()
        {
            // Vérifications de base
            if (string.IsNullOrWhiteSpace(textreference.Text))
            {
                MessageBox.Show("Veuillez saisir la référence du médicament.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textreference.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textnom.Text))
            {
                MessageBox.Show("Veuillez saisir le nom du médicament.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textnom.Focus();
                return false;
            }

            if (comboBoxcategorie.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxcategorie.Focus();
                return false;
            }

            // Validation des prix
            if (prixvente.Value <= 0)
            {
                MessageBox.Show("Le prix de vente doit être supérieur à 0.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prixvente.Focus();
                return false;
            }

            // Si un fournisseur est sélectionné, le prix d'achat est obligatoire
            if (comboBoxfornisseur.SelectedValue != null && prixachat.Value <= 0)
            {
                MessageBox.Show("Le prix d'achat doit être supérieur à 0 lorsqu'un fournisseur est sélectionné.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prixachat.Focus();
                return false;
            }

            if (prixachat.Value > 0 && prixvente.Value < prixachat.Value)
            {
                MessageBox.Show("Le prix de vente doit être supérieur ou égal au prix d'achat.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prixvente.Focus();
                return false;
            }

            // Validation des quantités
            if (quantite.Value < 0)
            {
                MessageBox.Show("La quantité en stock ne peut pas être négative.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantite.Focus();
                return false;
            }

            if (seuil.Value < 0)
            {
                MessageBox.Show("Le seuil d'alerte ne peut pas être négatif.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                seuil.Focus();
                return false;
            }

            // Validation de la date de péremption
            if (dateTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("La date de péremption doit être dans le futur.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Opérations CRUD

        private void buttonajoute_Click(object sender, EventArgs e)
        {
            if (!ValiderFormulaire())
                return;

            try
            {
                // Remplir l'objet Medicament avec les valeurs du formulaire
                PreparerMedicament();

                // Appeler la méthode appropriée
                bool succes = isModification ? medicamentActuel.Modifier() : medicamentActuel.Ajouter();

                if (succes)
                {
                    string message = isModification
                        ? "Médicament modifié avec succès!"
                        : "Médicament ajouté avec succès!";

                    MessageBox.Show(message, "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite lors de l'opération.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreparerMedicament()
        {
            // Informations de base
            medicamentActuel.Reference = textreference.Text.Trim();
            medicamentActuel.NomMed = textnom.Text.Trim();
            medicamentActuel.Description = string.IsNullOrWhiteSpace(textdescription.Text)
                ? null
                : textdescription.Text.Trim();

            // Photo
            medicamentActuel.Photo = photoBytes;

            // Catégorie
            medicamentActuel.IdCategorie = comboBoxcategorie.SelectedValue != null
                ? (int?)Convert.ToInt32(comboBoxcategorie.SelectedValue)
                : null;

            // Fournisseur et prix d'achat
            medicamentActuel.IdFournisseur = comboBoxfornisseur.SelectedValue != null
                ? (int?)Convert.ToInt32(comboBoxfornisseur.SelectedValue)
                : null;

            medicamentActuel.PrixAchat = medicamentActuel.IdFournisseur.HasValue && prixachat.Value > 0
                ? (decimal?)prixachat.Value
                : null;

            // Prix et quantités
            medicamentActuel.PrixVente = prixvente.Value;
            medicamentActuel.QuantiteStocke = (int)quantite.Value;
            medicamentActuel.SeuilAlerte = (int)seuil.Value;

            // Date de péremption
            medicamentActuel.DatePeremption = dateTimePicker.Value;

            // Statut
            medicamentActuel.Statut = "actif";
        }

        #endregion

        #region Gestion des Événements

        private void buttonannuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (connexion != null && connexion.State == ConnectionState.Open)
                connexion.Close();
            base.OnFormClosing(e);
        }
        #endregion

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupinfo_Enter(object sender, EventArgs e)
        {

        }
    }
}