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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void buttonconn_Click(object sender, EventArgs e)
        {
            connexion connForm = new connexion();
            connForm.Show();
            this.Hide();
        }

        private void buttonvalider_Click(object sender, EventArgs e)
        {
            // Validation des champs (ville n'existe plus dans la nouvelle DB)
            if (string.IsNullOrWhiteSpace(textnom.Text) ||
                string.IsNullOrWhiteSpace(textprenom.Text) ||
                string.IsNullOrWhiteSpace(textemail.Text) ||
                string.IsNullOrWhiteSpace(texttele.Text) ||
                string.IsNullOrWhiteSpace(textadresse.Text) ||
                string.IsNullOrWhiteSpace(textpassword.Text) ||
                string.IsNullOrWhiteSpace(textcofirmer.Text))
            {
                labelmessage.ForeColor = Color.Red;
                labelmessage.Text = "Il faut remplir tous les champs";
                return;
            }

            // Vérifier que les mots de passe correspondent
            if (textpassword.Text != textcofirmer.Text)
            {
                labelmessage.ForeColor = Color.Red;
                labelmessage.Text = "Les mots de passe ne correspondent pas.";
                return;
            }

            // Validation simple de l'email
            if (!textemail.Text.Contains("@"))
            {
                labelmessage.ForeColor = Color.Red;
                labelmessage.Text = "Veuillez entrer un email valide";
                return;
            }

            SqlConnection connexion = null;
            try
            {
                connexion = new SqlConnection();
                connexion.ConnectionString = "data source = IN-5CG3444P44\\GI2;initial catalog = Pharmacie; integrated security = SSPI; TrustServerCertificate=True";
                connexion.Open();

                // Vérifier si email existe déjà - AVEC PARAMÈTRES pour éviter injection SQL
                string sqlCheck = "SELECT COUNT(*) FROM Pharmacien WHERE email = @email";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, connexion);
                cmdCheck.Parameters.AddWithValue("@email", textemail.Text.Trim());

                int count = (int)cmdCheck.ExecuteScalar();

                if (count > 0)
                {
                    labelmessage.ForeColor = Color.Red;
                    labelmessage.Text = "Cet email existe déjà.";
                    return;
                }

                // Ajouter un nouveau pharmacien - AVEC PARAMÈTRES pour éviter injection SQL
                string sqlInsert = @"INSERT INTO Pharmacien (nom, prenom, email, telephone, adresse, password) 
                                    VALUES (@nom, @prenom, @email, @telephone, @adresse, @password)";

                SqlCommand cmdInsert = new SqlCommand(sqlInsert, connexion);
                cmdInsert.Parameters.AddWithValue("@nom", textnom.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@prenom", textprenom.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@email", textemail.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@telephone", texttele.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@adresse", textadresse.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@password", textpassword.Text); // IMPORTANT: Il faudrait hasher le mot de passe

                cmdInsert.ExecuteNonQuery();

                // Message de succès
                labelmessage.ForeColor = Color.Green;
                labelmessage.Text = "Compte créé avec succès !";

                // Vider les champs
                textnom.Clear();
                textprenom.Clear();
                textemail.Clear();
                texttele.Clear();
                textadresse.Clear();
                textpassword.Clear();
                textcofirmer.Clear();
            }
            catch (SqlException ex)
            {
                labelmessage.ForeColor = Color.Red;
                labelmessage.Text = "Erreur lors de l'inscription : " + ex.Message;
            }
            catch (Exception ex)
            {
                labelmessage.ForeColor = Color.Red;
                labelmessage.Text = "Erreur : " + ex.Message;
            }
            finally
            {
                if (connexion != null && connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}