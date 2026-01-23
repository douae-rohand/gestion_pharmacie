using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace gestion_pharmacie
{
    /// <summary>
    /// Classe représentant un fournisseur
    /// </summary>
    public class Fournisseur
    {
        #region Propriétés
        public int IdFournisseur { get; set; }
        public string NomEntreprise { get; set; }
        public string Telephone { get; set; }
        #endregion

        #region Connexion Base de Données
        private static string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        public static void SetConnectionString(string connString)
        {
            connectionString = connString;
        }
        #endregion

        #region Constructeurs
        public Fournisseur() { }

        public Fournisseur(string nomEntreprise, string telephone)
        {
            NomEntreprise = nomEntreprise;
            Telephone = telephone;
        }
        #endregion

        #region Méthodes CRUD

        /// <summary>
        /// Ajouter un nouveau fournisseur
        /// </summary>
        public bool Ajouter()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Fournisseurs (nomEntreprise, telephone) 
                                    VALUES (@nom, @tel);
                                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", NomEntreprise);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrWhiteSpace(Telephone) ? (object)DBNull.Value : Telephone);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        IdFournisseur = Convert.ToInt32(result);
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de l'ajout du fournisseur : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Modifier un fournisseur existant
        /// </summary>
        public bool Modifier()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Fournisseurs 
                                    SET nomEntreprise = @nom, 
                                        telephone = @tel 
                                    WHERE idFournisseur = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", NomEntreprise);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrWhiteSpace(Telephone) ? (object)DBNull.Value : Telephone);
                    cmd.Parameters.AddWithValue("@id", IdFournisseur);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la modification du fournisseur : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Supprimer un fournisseur
        /// </summary>
        public static bool Supprimer(int idFournisseur)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Fournisseurs WHERE idFournisseur = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idFournisseur);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la suppression du fournisseur : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes de Recherche et Liste

        /// <summary>
        /// Obtenir tous les fournisseurs
        /// </summary>
        public static DataTable ObtenirTous()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT idFournisseur, nomEntreprise, telephone FROM Fournisseurs ORDER BY nomEntreprise";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement des fournisseurs : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Rechercher des fournisseurs
        /// </summary>
        public static DataTable Rechercher(string critere, string valeur)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT idFournisseur, nomEntreprise, telephone FROM Fournisseurs WHERE ";

                    switch (critere)
                    {
                        case "Fournisseur":
                            query += "nomEntreprise LIKE @recherche";
                            break;
                        case "Telephone":
                            query += "telephone LIKE @recherche";
                            break;
                        default:
                            query += "nomEntreprise LIKE @recherche";
                            break;
                    }

                    query += " ORDER BY nomEntreprise";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@recherche", "%" + valeur + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la recherche des fournisseurs : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes Statistiques

        /// <summary>
        /// Obtenir le nombre total de fournisseurs
        /// </summary>
        public static int ObtenirNombreTotal()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Fournisseurs";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du calcul des statistiques : {ex.Message}", ex);
            }
        }

        #endregion
    }
}
