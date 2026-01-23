using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class FormFacture : Form
    {
        private int _idCommande;
        private int _idFacture;
        private string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        public FormFacture(int idCommande)
        {
            InitializeComponent();
            _idCommande = idCommande;
        }

        private void FormFacture_Load(object sender, EventArgs e)
        {
            ChargerFacture();
            ChargerDetailsCommande();
        }

        private void ChargerFacture()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT f.*, c.montantTotale 
                                   FROM Factures f
                                   INNER JOIN Commandes c ON f.idCommande = c.idCommande
                                   WHERE f.idCommande = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _idCommande);

                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        _idFacture = Convert.ToInt32(r["idFacture"]);
                        labelNumFactureValeur.Text = r["numFacture"].ToString();
                        labelDateFactureValeur.Text = Convert.ToDateTime(r["dateFacture"]).ToString("dd/MM/yyyy HH:mm");
                        labelMontantValeur.Text = Convert.ToDecimal(r["montantTotale"]).ToString("0.00") + " DH";

                        comboStatut.Text = r["statusPaiement"].ToString();

                        if (r["modePaiement"] != DBNull.Value)
                            comboMode.Text = r["modePaiement"].ToString();

                        if (r["datePaiement"] != DBNull.Value)
                            labelDatePaiementValeur.Text = Convert.ToDateTime(r["datePaiement"]).ToString("dd/MM/yyyy HH:mm");
                        else
                            labelDatePaiementValeur.Text = "Non payée";

                        // Mettre à jour la couleur selon le statut
                        UpdateStatutColor();
                    }
                    else
                    {
                        MessageBox.Show("Facture introuvable pour cette commande.",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de la facture :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerDetailsCommande()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT 
                                    CONCAT(cl.nom, ' ', cl.prenom) AS Client,
                                    cl.telephone,
                                    c.dateCommande,
                                    c.statut
                                   FROM Commandes c
                                   LEFT JOIN Client cl ON c.idClient = cl.idClient
                                   WHERE c.idCommande = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _idCommande);

                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        labelClientValeur.Text = r["Client"].ToString();
                        labelTelephoneValeur.Text = r["telephone"].ToString();
                        labelDateCommandeValeur.Text = Convert.ToDateTime(r["dateCommande"]).ToString("dd/MM/yyyy HH:mm");
                        labelStatutCommandeValeur.Text = r["statut"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des détails :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatutColor()
        {
            switch (comboStatut.Text)
            {
                case "Payée":
                    panelStatut.BackColor = Color.FromArgb(46, 204, 113);
                    break;
                case "Partiellement payée":
                    panelStatut.BackColor = Color.FromArgb(241, 196, 15);
                    break;
                case "Non payée":
                    panelStatut.BackColor = Color.FromArgb(231, 76, 60);
                    break;
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboStatut.Text))
                {
                    MessageBox.Show("Veuillez sélectionner un statut de paiement.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE Factures 
                                   SET statusPaiement = @statut, 
                                       modePaiement = @mode,
                                       datePaiement = @date
                                   WHERE idFacture = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@statut", comboStatut.Text);
                    cmd.Parameters.AddWithValue("@mode",
                        string.IsNullOrWhiteSpace(comboMode.Text) ? DBNull.Value : (object)comboMode.Text);

                    // Si le statut est "Payée", on met la date actuelle
                    if (comboStatut.Text == "Payée")
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    else
                        cmd.Parameters.AddWithValue("@date", DBNull.Value);

                    cmd.Parameters.AddWithValue("@id", _idFacture);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Facture mise à jour avec succès !",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recharger les données
                        ChargerFacture();
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                ImpressionCommande imp = new ImpressionCommande(_idCommande);
                imp.Imprimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'impression :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatutColor();

            // Si le statut est "Non payée", vider le mode de paiement
            if (comboStatut.Text == "Non payée")
            {
                comboMode.SelectedIndex = -1;
                comboMode.Enabled = false;
            }
            else
            {
                comboMode.Enabled = true;
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}