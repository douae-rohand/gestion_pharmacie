using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class FormDetailsMedicament : Form
    {
        public FormDetailsMedicament(SqlDataReader reader)
        {
            InitializeComponent();

            // Charger les données du médicament
            ChargerDonneesMedicament(reader);
        }

        private void ChargerDonneesMedicament(SqlDataReader reader)
        {
            try
            {
                // Informations principales
                labelReference.Text = $"Réf: {reader["reference"]}";
                labelNomMedicament.Text = reader["nomMed"].ToString();

                // Informations générales
                labelDescription.Text = reader["description"].ToString();
                labelCategorie.Text = reader["nomCategorie"].ToString();
                labelDateCreation.Text = Convert.ToDateTime(reader["dateCreation"]).ToString("dd/MM/yyyy");

                // Stock
                labelQuantiteStock.Text = reader["quantiteStocke"].ToString();
                labelSeuilAlerte.Text = reader["seuilAlerte"].ToString();
                labelDatePeremption.Text = Convert.ToDateTime(reader["datePeremption"]).ToString("dd/MM/yyyy");

                // Vérifier si le stock est faible
                int quantiteStock = Convert.ToInt32(reader["quantiteStocke"]);
                int seuilAlerte = Convert.ToInt32(reader["seuilAlerte"]);

                if (quantiteStock <= seuilAlerte)
                {
                    labelQuantiteStock.ForeColor = Color.FromArgb(231, 76, 60); // Rouge
                    labelQuantiteStock.Font = new Font(labelQuantiteStock.Font, FontStyle.Bold);
                }
                else if (quantiteStock <= seuilAlerte * 1.5)
                {
                    labelQuantiteStock.ForeColor = Color.FromArgb(243, 156, 18); // Orange
                }
                else
                {
                    labelQuantiteStock.ForeColor = Color.FromArgb(39, 174, 96); // Vert
                }

                // Prix - Récupérer depuis la table fournit
                decimal prixAchat = reader["prixAchat"] != DBNull.Value ? Convert.ToDecimal(reader["prixAchat"]) : 0;
                decimal prixVente = Convert.ToDecimal(reader["prixVente"]);
                labelPrixAchat.Text = $"{prixAchat:F2} DH";
                labelPrixVente.Text = $"{prixVente:F2} DH";

                // Fournisseur
                labelNomEntreprise.Text = reader["nomEntreprise"].ToString();
                labelTelephone.Text = reader["telephone"].ToString();

                // Charger l'image
                if (reader["photo"] != DBNull.Value)
                {
                    byte[] photoBytes = (byte[])reader["photo"];
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        pictureBoxMedicament.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Image par défaut si pas de photo
                    pictureBoxMedicament.BackColor = Color.FromArgb(233, 244, 238);
                    // Vous pouvez ajouter une image par défaut ici
                }

                // Vérifier la date de péremption
                DateTime datePeremption = Convert.ToDateTime(reader["datePeremption"]);
                TimeSpan difference = datePeremption - DateTime.Now;

                if (difference.TotalDays < 0)
                {
                    labelDatePeremption.ForeColor = Color.FromArgb(231, 76, 60); // Rouge - Expiré
                    labelDatePeremption.Font = new Font(labelDatePeremption.Font, FontStyle.Bold);
                    labelDatePeremption.Text += " ⚠️ EXPIRÉ";
                }
                else if (difference.TotalDays <= 30)
                {
                    labelDatePeremption.ForeColor = Color.FromArgb(243, 156, 18); // Orange - Bientôt expiré
                    labelDatePeremption.Font = new Font(labelDatePeremption.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}