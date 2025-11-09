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
            if ((textemail.Text == "") || (textpassword.Text == ""))
            {
                labelmessage.ForeColor = Color.Red;
                labelmessage.Text = "il faut remplire tous les champs";
            }
            else
            {
                SqlConnection connexion = new SqlConnection();
                connexion.ConnectionString = "data source = IN-5CG3444P44\\GI2;initial catalog = GestionPharmacie; integrated security = SSPI; TrustServerCertificate=True";
                string sql = "select * from Users where Email= '" + textemail.Text + "' and Password = '" + textpassword.Text + "'";
                connexion.Open();
                SqlCommand cmd = new SqlCommand(sql, connexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["role"].ToString();

                    // Vérifier le rôle et rediriger
                    if (role == "Administrateur")
                    {
                        EspaceAdmin adminForm = new EspaceAdmin();
                        adminForm.Show();
                    }
                    else if (role == "Client")
                    {
                        EspaceClient clinetForm = new EspaceClient();
                        clinetForm.Show();
                    }
                    else if (role == "Fournisseur")
                    {
                        EspaceFournisseur fournisseurForm = new EspaceFournisseur();
                        fournisseurForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Rôle non reconnu !");
                    }
                    this.Hide();
                }
                else
                {
                    labelmessage.ForeColor = Color.Red;
                    labelmessage.Text = "le mots de passe ou email est incorrecte";
                }
                connexion.Close();
            }
        }
    }
}
