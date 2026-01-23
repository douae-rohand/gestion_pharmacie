using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace gestion_pharmacie
{
    /// <summary>
    /// Classe représentant un médicament de la pharmacie
    /// </summary>
    public class Medicament
    {
        #region Propriétés
        public int IdMed { get; set; }
        public string NomMed { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public decimal PrixVente { get; set; }
        public int QuantiteStocke { get; set; }
        public int SeuilAlerte { get; set; }
        public DateTime DatePeremption { get; set; }
        public DateTime DateCreation { get; set; }
        public int? IdCategorie { get; set; }
        public string Statut { get; set; } = "actif";

        // Propriétés supplémentaires pour les relations
        public string NomCategorie { get; set; }
        public int? IdFournisseur { get; set; }
        public string NomFournisseur { get; set; }
        public decimal? PrixAchat { get; set; }

        // Propriétés calculées
        public bool EstProcheDatePeremption => DatePeremption <= DateTime.Now.AddMonths(3);
        public bool EstEnRupture => QuantiteStocke <= SeuilAlerte;
        public int JoursAvantPeremption => (DatePeremption - DateTime.Now).Days;
        #endregion

        #region Connexion Base de Données
        private static string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        public static void SetConnectionString(string connString)
        {
            connectionString = connString;
        }
        #endregion

        #region Constructeurs
        public Medicament() { }

        public Medicament(string nomMed, string reference, decimal prixVente)
        {
            NomMed = nomMed;
            Reference = reference;
            PrixVente = prixVente;
        }
        #endregion

        #region Méthodes CRUD

        /// <summary>
        /// Ajouter un nouveau médicament dans la base de données
        /// </summary>
        public bool Ajouter()
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                // Validation avant insertion
                string messageErreur;
                if (!Valider(out messageErreur))
                {
                    throw new Exception(messageErreur);
                }

                // Vérifier si la référence existe déjà
                if (ReferenceExiste(Reference))
                {
                    throw new Exception("Cette référence existe déjà !");
                }

                conn = new SqlConnection(connectionString);
                conn.Open();
                transaction = conn.BeginTransaction();

                // 1. Insérer le médicament
                string queryMed = @"INSERT INTO Medicament 
                                   (nomMed, reference, description, photo, prixVente, quantiteStocke, 
                                    seuilAlerte, datePeremption, dateCreation, idCategorie, statut)
                                   VALUES 
                                   (@nomMed, @reference, @description, @photo, @prixVente, @quantiteStocke,
                                    @seuilAlerte, @datePeremption, GETDATE(), @idCategorie, @statut);
                                   SELECT SCOPE_IDENTITY();";

                SqlCommand cmdMed = new SqlCommand(queryMed, conn, transaction);
                cmdMed.Parameters.AddWithValue("@nomMed", NomMed);
                cmdMed.Parameters.AddWithValue("@reference", Reference);
                cmdMed.Parameters.AddWithValue("@description", string.IsNullOrEmpty(Description) ? (object)DBNull.Value : Description);
                cmdMed.Parameters.AddWithValue("@photo", Photo != null && Photo.Length > 0 ? (object)Photo : DBNull.Value);
                cmdMed.Parameters.AddWithValue("@prixVente", PrixVente);
                cmdMed.Parameters.AddWithValue("@quantiteStocke", QuantiteStocke);
                cmdMed.Parameters.AddWithValue("@seuilAlerte", SeuilAlerte);
                cmdMed.Parameters.AddWithValue("@datePeremption", DatePeremption);
                cmdMed.Parameters.AddWithValue("@idCategorie", IdCategorie.HasValue ? (object)IdCategorie.Value : DBNull.Value);
                cmdMed.Parameters.AddWithValue("@statut", Statut);

                object result = cmdMed.ExecuteScalar();
                if (result != null)
                {
                    IdMed = Convert.ToInt32(result);

                    // 2. Insérer la relation avec le fournisseur si spécifié
                    if (IdFournisseur.HasValue && PrixAchat.HasValue)
                    {
                        string queryFournit = @"INSERT INTO fournit (idFournisseur, idMed, prixAchat)
                                               VALUES (@idFournisseur, @idMed, @prixAchat)";

                        SqlCommand cmdFournit = new SqlCommand(queryFournit, conn, transaction);
                        cmdFournit.Parameters.AddWithValue("@idFournisseur", IdFournisseur.Value);
                        cmdFournit.Parameters.AddWithValue("@idMed", IdMed);
                        cmdFournit.Parameters.AddWithValue("@prixAchat", PrixAchat.Value);
                        cmdFournit.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }

                transaction.Rollback();
                return false;
            }
            catch (SqlException sqlEx)
            {
                transaction?.Rollback();

                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    throw new Exception("Cette référence existe déjà dans la base de données !", sqlEx);
                }
                throw new Exception($"Erreur SQL lors de l'ajout du médicament : {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception($"Erreur lors de l'ajout du médicament : {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        /// <summary>
        /// Modifier un médicament existant
        /// </summary>
        public bool Modifier()
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                // Validation avant modification
                string messageErreur;
                if (!Valider(out messageErreur))
                {
                    throw new Exception(messageErreur);
                }

                conn = new SqlConnection(connectionString);
                conn.Open();
                transaction = conn.BeginTransaction();

                // 1. Mettre à jour le médicament
                string queryMed = @"UPDATE Medicament SET
                                   nomMed = @nomMed,
                                   reference = @reference,
                                   description = @description,
                                   photo = @photo,
                                   prixVente = @prixVente,
                                   quantiteStocke = @quantiteStocke,
                                   seuilAlerte = @seuilAlerte,
                                   datePeremption = @datePeremption,
                                   idCategorie = @idCategorie
                                   WHERE idMed = @idMed";

                SqlCommand cmdMed = new SqlCommand(queryMed, conn, transaction);
                cmdMed.Parameters.AddWithValue("@idMed", IdMed);
                cmdMed.Parameters.AddWithValue("@nomMed", NomMed);
                cmdMed.Parameters.AddWithValue("@reference", Reference);
                cmdMed.Parameters.AddWithValue("@description", string.IsNullOrEmpty(Description) ? (object)DBNull.Value : Description);
                cmdMed.Parameters.AddWithValue("@photo", Photo != null && Photo.Length > 0 ? (object)Photo : DBNull.Value);
                cmdMed.Parameters.AddWithValue("@prixVente", PrixVente);
                cmdMed.Parameters.AddWithValue("@quantiteStocke", QuantiteStocke);
                cmdMed.Parameters.AddWithValue("@seuilAlerte", SeuilAlerte);
                cmdMed.Parameters.AddWithValue("@datePeremption", DatePeremption);
                cmdMed.Parameters.AddWithValue("@idCategorie", IdCategorie.HasValue ? (object)IdCategorie.Value : DBNull.Value);

                int rowsAffected = cmdMed.ExecuteNonQuery();

                // 2. Gérer la relation fournisseur
                // D'abord supprimer l'ancien lien
                string deleteFournit = "DELETE FROM fournit WHERE idMed = @idMed";
                SqlCommand cmdDelete = new SqlCommand(deleteFournit, conn, transaction);
                cmdDelete.Parameters.AddWithValue("@idMed", IdMed);
                cmdDelete.ExecuteNonQuery();

                // Puis insérer le nouveau lien si un fournisseur est spécifié
                if (IdFournisseur.HasValue && PrixAchat.HasValue)
                {
                    string insertFournit = @"INSERT INTO fournit (idFournisseur, idMed, prixAchat)
                                            VALUES (@idFournisseur, @idMed, @prixAchat)";
                    SqlCommand cmdFournit = new SqlCommand(insertFournit, conn, transaction);
                    cmdFournit.Parameters.AddWithValue("@idFournisseur", IdFournisseur.Value);
                    cmdFournit.Parameters.AddWithValue("@idMed", IdMed);
                    cmdFournit.Parameters.AddWithValue("@prixAchat", PrixAchat.Value);
                    cmdFournit.ExecuteNonQuery();
                }

                transaction.Commit();
                return rowsAffected > 0;
            }
            catch (SqlException sqlEx)
            {
                transaction?.Rollback();

                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    throw new Exception("Cette référence existe déjà dans la base de données !", sqlEx);
                }
                throw new Exception($"Erreur SQL lors de la modification : {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception($"Erreur lors de la modification du médicament : {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        /// <summary>
        /// Supprimer un médicament (suppression logique - statut = 'inactif')
        /// </summary>
        public static bool Supprimer(int idMed)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Medicament SET statut = 'inactif' WHERE idMed = @idMed";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idMed", idMed);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                {
                    throw new Exception("Impossible de supprimer ce médicament car il est référencé dans des commandes.", sqlEx);
                }
                throw new Exception($"Erreur SQL lors de la suppression : {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la suppression du médicament : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Récupérer un médicament par son ID avec toutes ses informations
        /// </summary>
        public static Medicament ObtenirParId(int idMed)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    m.idMed, m.reference, m.nomMed, m.description, m.photo,
                                    m.prixVente, m.quantiteStocke, m.seuilAlerte, 
                                    m.datePeremption, m.dateCreation, m.statut,
                                    m.idCategorie, c.nomCategorie,
                                    fo.idFournisseur, fo.prixAchat,
                                    f.nomEntreprise AS NomFournisseur
                                    FROM Medicament m
                                    LEFT JOIN Categories c ON m.idCategorie = c.idCategorie
                                    LEFT JOIN fournit fo ON m.idMed = fo.idMed
                                    LEFT JOIN Fournisseurs f ON fo.idFournisseur = f.idFournisseur
                                    WHERE m.idMed = @idMed";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idMed", idMed);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Medicament
                            {
                                IdMed = Convert.ToInt32(reader["idMed"]),
                                Reference = reader["reference"].ToString(),
                                NomMed = reader["nomMed"].ToString(),
                                Description = reader.IsDBNull(reader.GetOrdinal("description")) ? "" : reader["description"].ToString(),
                                Photo = reader.IsDBNull(reader.GetOrdinal("photo")) ? null : (byte[])reader["photo"],
                                PrixVente = Convert.ToDecimal(reader["prixVente"]),
                                QuantiteStocke = Convert.ToInt32(reader["quantiteStocke"]),
                                SeuilAlerte = Convert.ToInt32(reader["seuilAlerte"]),
                                DatePeremption = Convert.ToDateTime(reader["datePeremption"]),
                                DateCreation = Convert.ToDateTime(reader["dateCreation"]),
                                Statut = reader["statut"].ToString(),
                                IdCategorie = reader.IsDBNull(reader.GetOrdinal("idCategorie")) ? (int?)null : Convert.ToInt32(reader["idCategorie"]),
                                NomCategorie = reader.IsDBNull(reader.GetOrdinal("nomCategorie")) ? "" : reader["nomCategorie"].ToString(),
                                IdFournisseur = reader.IsDBNull(reader.GetOrdinal("idFournisseur")) ? (int?)null : Convert.ToInt32(reader["idFournisseur"]),
                                NomFournisseur = reader.IsDBNull(reader.GetOrdinal("NomFournisseur")) ? "" : reader["NomFournisseur"].ToString(),
                                PrixAchat = reader.IsDBNull(reader.GetOrdinal("prixAchat")) ? (decimal?)null : Convert.ToDecimal(reader["prixAchat"])
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la récupération du médicament : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes de Recherche et Liste

        /// <summary>
        /// Obtenir tous les médicaments actifs avec leurs informations complètes
        /// </summary>
        public static DataTable ObtenirTous(string whereClause = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT m.idMed, m.reference, m.nomMed, m.description, 
                                    c.nomCategorie AS Categorie, 
                                    f.nomEntreprise AS Fournisseur,
                                    fo.prixAchat, 
                                    m.prixVente, 
                                    m.quantiteStocke, 
                                    m.seuilAlerte,
                                    m.datePeremption, 
                                    m.dateCreation
                                    FROM Medicament m 
                                    LEFT JOIN Categories c ON m.idCategorie = c.idCategorie 
                                    LEFT JOIN fournit fo ON m.idMed = fo.idMed
                                    LEFT JOIN Fournisseurs f ON fo.idFournisseur = f.idFournisseur
                                    WHERE m.statut = 'actif'";

                    if (!string.IsNullOrEmpty(whereClause))
                    {
                        query += " AND " + whereClause;
                    }

                    query += " ORDER BY m.reference";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement des médicaments : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Rechercher des médicaments avec paramètres (pour LIKE)
        /// </summary>
        public static DataTable RechercherAvecParametres(string whereClause, string valeurRecherche)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT m.idMed, m.reference, m.nomMed, m.description, 
                                    c.nomCategorie AS Categorie, 
                                    f.nomEntreprise AS Fournisseur,
                                    fo.prixAchat, 
                                    m.prixVente, 
                                    m.quantiteStocke, 
                                    m.seuilAlerte,
                                    m.datePeremption, 
                                    m.dateCreation
                                    FROM Medicament m 
                                    LEFT JOIN Categories c ON m.idCategorie = c.idCategorie 
                                    LEFT JOIN fournit fo ON m.idMed = fo.idMed
                                    LEFT JOIN Fournisseurs f ON fo.idFournisseur = f.idFournisseur
                                    WHERE m.statut = 'actif' AND " + whereClause + " ORDER BY m.reference";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@valeur", "%" + valeurRecherche + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la recherche des médicaments : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes Statistiques

        /// <summary>
        /// Obtenir les statistiques globales des médicaments
        /// </summary>
        public static MedicamentStatistiques ObtenirStatistiques()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    COUNT(DISTINCT CASE WHEN m.statut = 'actif' THEN m.idMed END) AS TotalMedicaments,
                                    COUNT(CASE WHEN m.statut = 'actif' AND m.datePeremption <= DATEADD(MONTH, 3, GETDATE()) THEN 1 END) AS MedicamentsPeremption,
                                    ISNULL(SUM(CASE WHEN m.statut = 'actif' THEN m.quantiteStocke ELSE 0 END), 0) AS StockTotal,
                                    COUNT(CASE WHEN m.statut = 'actif' AND m.quantiteStocke <= m.seuilAlerte THEN 1 END) AS AlertesStock
                                    FROM Medicament m";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new MedicamentStatistiques
                            {
                                TotalMedicaments = Convert.ToInt32(reader["TotalMedicaments"]),
                                MedicamentsPeremption = Convert.ToInt32(reader["MedicamentsPeremption"]),
                                StockTotal = Convert.ToInt32(reader["StockTotal"]),
                                AlertesStock = Convert.ToInt32(reader["AlertesStock"])
                            };
                        }
                    }
                }
                return new MedicamentStatistiques();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement des statistiques : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes de Validation

        /// <summary>
        /// Vérifier si la référence existe déjà
        /// </summary>
        public static bool ReferenceExiste(string reference, int? idMedExclure = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = idMedExclure.HasValue
                        ? "SELECT COUNT(*) FROM Medicament WHERE reference = @reference AND idMed != @idMed"
                        : "SELECT COUNT(*) FROM Medicament WHERE reference = @reference";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@reference", reference);
                    if (idMedExclure.HasValue)
                        cmd.Parameters.AddWithValue("@idMed", idMedExclure.Value);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la vérification de la référence : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Valider les données du médicament
        /// </summary>
        public bool Valider(out string messageErreur)
        {
            messageErreur = "";

            if (string.IsNullOrWhiteSpace(NomMed))
            {
                messageErreur = "Le nom du médicament est obligatoire.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Reference))
            {
                messageErreur = "La référence est obligatoire.";
                return false;
            }

            if (PrixVente <= 0)
            {
                messageErreur = "Le prix de vente doit être supérieur à 0.";
                return false;
            }

            if (QuantiteStocke < 0)
            {
                messageErreur = "La quantité en stock ne peut pas être négative.";
                return false;
            }

            if (SeuilAlerte < 0)
            {
                messageErreur = "Le seuil d'alerte ne peut pas être négatif.";
                return false;
            }

            if (DatePeremption <= DateTime.Now)
            {
                messageErreur = "La date de péremption doit être dans le futur.";
                return false;
            }

            // Validation du prix d'achat si un fournisseur est spécifié
            if (IdFournisseur.HasValue && (!PrixAchat.HasValue || PrixAchat.Value <= 0))
            {
                messageErreur = "Le prix d'achat doit être supérieur à 0 lorsqu'un fournisseur est sélectionné.";
                return false;
            }

            if (PrixAchat.HasValue && PrixAchat.Value > PrixVente)
            {
                messageErreur = "Le prix de vente doit être supérieur ou égal au prix d'achat.";
                return false;
            }

            return true;
        }

        #endregion
    }

    /// <summary>
    /// Classe pour les statistiques des médicaments
    /// </summary>
    public class MedicamentStatistiques
    {
        public int TotalMedicaments { get; set; }
        public int MedicamentsPeremption { get; set; }
        public int StockTotal { get; set; }
        public int AlertesStock { get; set; }
    }
}