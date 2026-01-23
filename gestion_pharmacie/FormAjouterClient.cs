using System;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class FormAjouterClient : Form
    {
        private bool isModification = false;
        private Client clientExistant;
        private string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        #region Constructeurs

        // CONSTRUCTEUR POUR L'AJOUT
        public FormAjouterClient()
        {
            InitializeComponent();
            Client.SetConnectionString(connectionString);
        }

        // CONSTRUCTEUR POUR LA MODIFICATION
        public FormAjouterClient(dynamic clientData) : this()
        {
            isModification = true;

            // Convertir l'objet anonyme en instance de Client
            clientExistant = new Client
            {
                IdClient = Convert.ToInt32(clientData.idClient),
                Nom = clientData.nom?.ToString() ?? "",
                Prenom = clientData.prenom?.ToString() ?? "",
                CIN = clientData.CIN?.ToString() ?? "",
                Telephone = clientData.telephone?.ToString() ?? "",
                Adresse = clientData.adresse?.ToString() ?? "",
                Ville = clientData.ville?.ToString() ?? "",
                CodePostale = clientData.codePostale?.ToString() ?? "",
                DateNaissance = clientData.dateNaissance != null ? Convert.ToDateTime(clientData.dateNaissance) : (DateTime?)null
            };

            labelTitre.Text = "✏️ Modifier un Client";
            buttonAjouter.Text = "Modifier";
            Text = "Gestion Pharmacie - Modifier un Client";
        }

        #endregion

        #region Chargement du Formulaire

        private void FormAjouterClient_Load(object sender, EventArgs e)
        {
            if (isModification && clientExistant != null)
            {
                RemplirChamps();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (isModification && clientExistant != null)
            {
                RemplirChamps();
            }
        }

        private void RemplirChamps()
        {
            try
            {
                textNom.Text = clientExistant.Nom;
                textPrenom.Text = clientExistant.Prenom;
                textCIN.Text = clientExistant.CIN;
                textTelephone.Text = clientExistant.Telephone;
                textAdresse.Text = clientExistant.Adresse;
                textVille.Text = clientExistant.Ville;
                textCodePostal.Text = clientExistant.CodePostale;

                // Date de naissance
                if (clientExistant.DateNaissance.HasValue)
                {
                    dateTimePickerNaissance.Value = clientExistant.DateNaissance.Value;
                }

                // Désactiver le CIN en modification (clé unique)
                textCIN.Enabled = false;
                textCIN.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du remplissage des champs :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Validation et Enregistrement

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (ValiderFormulaire())
            {
                if (isModification)
                {
                    ModifierClient();
                }
                else
                {
                    AjouterClient();
                }
            }
        }

        private bool ValiderFormulaire()
        {
            // Créer un client temporaire pour la validation
            Client clientTemp = new Client
            {
                Nom = textNom.Text.Trim(),
                Prenom = textPrenom.Text.Trim(),
                CIN = textCIN.Text.Trim(),
                Telephone = textTelephone.Text.Trim(),
                DateNaissance = dateTimePickerNaissance.Value
            };

            // Utiliser la méthode de validation de la classe Client
            string messageErreur;
            if (!clientTemp.Valider(out messageErreur))
            {
                MessageBox.Show(messageErreur, "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Vérifier si le client est mineur
            if (clientTemp.EstMineur())
            {
                DialogResult result = MessageBox.Show(
                    $"Le client a {clientTemp.Age} ans (mineur). Voulez-vous continuer ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return false;
            }

            return true;
        }

        private void AjouterClient()
        {
            try
            {
                // Créer une instance de Client avec les données du formulaire
                Client nouveauClient = new Client
                {
                    Nom = textNom.Text.Trim(),
                    Prenom = textPrenom.Text.Trim(),
                    CIN = textCIN.Text.Trim(),
                    Telephone = textTelephone.Text.Trim(),
                    Adresse = textAdresse.Text.Trim(),
                    Ville = textVille.Text.Trim(),
                    CodePostale = textCodePostal.Text.Trim(),
                    DateNaissance = dateTimePickerNaissance.Value.Date,
                    IdAdmin = 1 // ID de l'admin connecté (à adapter selon votre système de connexion)
                };

                // Appeler la méthode Ajouter() de la classe Client
                if (nouveauClient.Ajouter())
                {
                    MessageBox.Show(
                        $"Client ajouté avec succès !\nID: {nouveauClient.IdClient}",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout du client.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du client :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifierClient()
        {
            try
            {
                // Mettre à jour les propriétés du client existant
                clientExistant.Nom = textNom.Text.Trim();
                clientExistant.Prenom = textPrenom.Text.Trim();
                clientExistant.Telephone = textTelephone.Text.Trim();
                clientExistant.Adresse = textAdresse.Text.Trim();
                clientExistant.Ville = textVille.Text.Trim();
                clientExistant.CodePostale = textCodePostal.Text.Trim();
                clientExistant.DateNaissance = dateTimePickerNaissance.Value.Date;

                // Appeler la méthode Modifier() de la classe Client
                if (clientExistant.Modifier())
                {
                    MessageBox.Show("Client modifié avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Aucune modification n'a été effectuée.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du client :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Boutons et Événements

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void panelHeader_Paint(object sender, PaintEventArgs e) { }

        private void panelHeader_Paint_1(object sender, PaintEventArgs e) { }

        private void panelMain_Paint(object sender, PaintEventArgs e) { }

        #endregion

        private void groupBoxInfos_Enter(object sender, EventArgs e)
        {

        }
    }
}