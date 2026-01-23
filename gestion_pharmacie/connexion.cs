using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gestion_pharmacie
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        private void connexion_Load(object sender, EventArgs e)
        {
        }

        private void buttonvalider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textemail.Text) || string.IsNullOrWhiteSpace(textpassword.Text))
            {
                labelmessage.ForeColor = Color.Red;
                labelmessage.Text = "Il faut remplir tous les champs";
                return;
            }

            SqlConnection connexion = null;
            try
            {
                connexion = new SqlConnection();
                connexion.ConnectionString = "data source = IN-5CG3444P44\\GI2;initial catalog = Pharmacie; integrated security = SSPI; TrustServerCertificate=True";

                // Requête SQL adaptée à la nouvelle base de données
                string sql = "SELECT * FROM Pharmacien WHERE email = @email AND password = @password";

                connexion.Open();
                SqlCommand cmd = new SqlCommand(sql, connexion);

                // Utilisation de paramètres pour éviter les injections SQL
                cmd.Parameters.AddWithValue("@email", textemail.Text.Trim());
                cmd.Parameters.AddWithValue("@password", textpassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Récupérer les informations de l'administrateur
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    int idAdmin = Convert.ToInt32(reader["idAdmin"]);

                    // Ouvrir l'espace admin
                    EspaceAdmin adminForm = new EspaceAdmin();
                    // Vous pouvez passer l'idAdmin au formulaire si nécessaire
                    // adminForm.IdAdmin = idAdmin;
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    labelmessage.ForeColor = Color.Red;
                    labelmessage.Text = "L'email ou le mot de passe est incorrect";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connexion != null && connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }
        }

        private void labeltitre_Click(object sender, EventArgs e)
        {
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}