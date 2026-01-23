using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace gestion_pharmacie
{
    /// <summary>
    /// Classe représentant un client de la pharmacie
    /// </summary>
    public class Client
    {
        #region Propriétés
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostale { get; set; }
        public string Telephone { get; set; }
        public DateTime DateCreation { get; set; }
        public int? IdAdmin { get; set; }

        // Propriétés calculées/supplémentaires
        public int Age
        {
            get
            {
                if (!DateNaissance.HasValue) return 0;
                int age = DateTime.Now.Year - DateNaissance.Value.Year;
                if (DateTime.Now < DateNaissance.Value.AddYears(age)) age--;
                return age;
            }
        }

        public string NomComplet => $"{Nom} {Prenom}";
        #endregion

        #region Connexion Base de Données
        private static string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        public static void SetConnectionString(string connString)
        {
            connectionString = connString;
        }
        #endregion

        #region Constructeurs
        public Client() { }

        public Client(string nom, string prenom, string cin, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            CIN = cin;
            Telephone = telephone;
        }
        #endregion

        #region Méthodes CRUD

        /// <summary>
        /// Ajouter un nouveau client dans la base de données
        /// </summary>
        public bool Ajouter()
        {
            try
            {
                // Vérifier si le CIN existe déjà
                if (CINExiste(CIN))
                {
                    throw new Exception("Ce CIN est déjà enregistré !");
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Client 
                                    (nom, prenom, CIN, dateNaissance, adresse, ville, codePostale, telephone, dateCreation, idAdmin)
                                    VALUES 
                                    (@nom, @prenom, @cin, @dateNaissance, @adresse, @ville, @codePostale, @telephone, GETDATE(), @idAdmin);
                                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", Nom);
                    cmd.Parameters.AddWithValue("@prenom", Prenom);
                    cmd.Parameters.AddWithValue("@cin", CIN);
                    cmd.Parameters.AddWithValue("@dateNaissance", DateNaissance.HasValue ? (object)DateNaissance.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@adresse", string.IsNullOrEmpty(Adresse) ? (object)DBNull.Value : Adresse);
                    cmd.Parameters.AddWithValue("@ville", string.IsNullOrEmpty(Ville) ? (object)DBNull.Value : Ville);
                    cmd.Parameters.AddWithValue("@codePostale", string.IsNullOrEmpty(CodePostale) ? (object)DBNull.Value : CodePostale);
                    cmd.Parameters.AddWithValue("@telephone", string.IsNullOrEmpty(Telephone) ? (object)DBNull.Value : Telephone);
                    cmd.Parameters.AddWithValue("@idAdmin", IdAdmin.HasValue ? (object)IdAdmin.Value : DBNull.Value);

                    // Récupérer l'ID du client inséré
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        IdClient = Convert.ToInt32(result);
                        return true;
                    }
                    return false;
                }
            }
            catch (SqlException sqlEx)
            {
                // Erreur de contrainte UNIQUE (CIN déjà existant)
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    throw new Exception("Ce CIN existe déjà dans la base de données !", sqlEx);
                }
                throw new Exception($"Erreur SQL lors de l'ajout du client : {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de l'ajout du client : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Modifier un client existant
        /// </summary>
        public bool Modifier()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Client SET
                                    nom = @nom,
                                    prenom = @prenom,
                                    telephone = @telephone,
                                    adresse = @adresse,
                                    ville = @ville,
                                    codePostale = @codePostale,
                                    dateNaissance = @dateNaissance
                                    WHERE idClient = @idClient";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idClient", IdClient);
                    cmd.Parameters.AddWithValue("@nom", Nom);
                    cmd.Parameters.AddWithValue("@prenom", Prenom);
                    cmd.Parameters.AddWithValue("@telephone", string.IsNullOrEmpty(Telephone) ? (object)DBNull.Value : Telephone);
                    cmd.Parameters.AddWithValue("@adresse", string.IsNullOrEmpty(Adresse) ? (object)DBNull.Value : Adresse);
                    cmd.Parameters.AddWithValue("@ville", string.IsNullOrEmpty(Ville) ? (object)DBNull.Value : Ville);
                    cmd.Parameters.AddWithValue("@codePostale", string.IsNullOrEmpty(CodePostale) ? (object)DBNull.Value : CodePostale);
                    cmd.Parameters.AddWithValue("@dateNaissance", DateNaissance.HasValue ? (object)DateNaissance.Value : DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la modification du client : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Supprimer un client par son ID
        /// </summary>
        public static bool Supprimer(int idClient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Supprimer les factures liées
                        string deleteFactures = @"DELETE FROM Factures 
                                                 WHERE idCommande IN 
                                                 (SELECT idCommande FROM Commandes WHERE idClient = @idClient)";
                        SqlCommand cmdFactures = new SqlCommand(deleteFactures, conn, transaction);
                        cmdFactures.Parameters.AddWithValue("@idClient", idClient);
                        cmdFactures.ExecuteNonQuery();

                        // Supprimer les lignes de commandes
                        string deleteLignes = @"DELETE FROM ligneCommande 
                                               WHERE idCommande IN 
                                               (SELECT idCommande FROM Commandes WHERE idClient = @idClient)";
                        SqlCommand cmdLignes = new SqlCommand(deleteLignes, conn, transaction);
                        cmdLignes.Parameters.AddWithValue("@idClient", idClient);
                        cmdLignes.ExecuteNonQuery();

                        // Supprimer les commandes
                        string deleteCommandes = "DELETE FROM Commandes WHERE idClient = @idClient";
                        SqlCommand cmdCommandes = new SqlCommand(deleteCommandes, conn, transaction);
                        cmdCommandes.Parameters.AddWithValue("@idClient", idClient);
                        cmdCommandes.ExecuteNonQuery();

                        // Supprimer le client
                        string deleteClient = "DELETE FROM Client WHERE idClient = @idClient";
                        SqlCommand cmdClient = new SqlCommand(deleteClient, conn, transaction);
                        cmdClient.Parameters.AddWithValue("@idClient", idClient);
                        int rowsAffected = cmdClient.ExecuteNonQuery();

                        transaction.Commit();
                        return rowsAffected > 0;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la suppression du client : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Récupérer un client par son ID
        /// </summary>
        public static Client ObtenirParId(int idClient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT idClient, nom, prenom, CIN, telephone, adresse, 
                                    ville, codePostale, dateNaissance, dateCreation, idAdmin
                                    FROM Client WHERE idClient = @idClient";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idClient", idClient);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Client
                            {
                                IdClient = Convert.ToInt32(reader["idClient"]),
                                Nom = reader["nom"].ToString(),
                                Prenom = reader["prenom"].ToString(),
                                CIN = reader["CIN"].ToString(),
                                Telephone = reader.IsDBNull(reader.GetOrdinal("telephone")) ? "" : reader["telephone"].ToString(),
                                Adresse = reader.IsDBNull(reader.GetOrdinal("adresse")) ? "" : reader["adresse"].ToString(),
                                Ville = reader.IsDBNull(reader.GetOrdinal("ville")) ? "" : reader["ville"].ToString(),
                                CodePostale = reader.IsDBNull(reader.GetOrdinal("codePostale")) ? "" : reader["codePostale"].ToString(),
                                DateNaissance = reader.IsDBNull(reader.GetOrdinal("dateNaissance")) ? (DateTime?)null : Convert.ToDateTime(reader["dateNaissance"]),
                                DateCreation = Convert.ToDateTime(reader["dateCreation"]),
                                IdAdmin = reader.IsDBNull(reader.GetOrdinal("idAdmin")) ? (int?)null : Convert.ToInt32(reader["idAdmin"])
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la récupération du client : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes de Recherche et Liste

        /// <summary>
        /// Obtenir tous les clients avec leurs statistiques
        /// </summary>
        public static DataTable ObtenirTousAvecStatistiques(string whereClause = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    bool isHaving = whereClause.Contains("HAVING");
                    string finalWhereClause = isHaving ? "" : whereClause;
                    string finalHavingClause = isHaving ? whereClause : "";

                    string query = $@"SELECT 
                                c.idClient,
                                c.nom AS Nom,
                                c.prenom AS Prenom,
                                c.CIN,
                                c.telephone AS Telephone,
                                c.adresse AS Adresse,
                                c.ville AS Ville,
                                c.codePostale AS CodePostal,
                                c.dateNaissance AS DateNaissance,
                                c.dateCreation AS DateInscription,
                                DATEDIFF(YEAR, c.dateNaissance, GETDATE()) - 
                                CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, c.dateNaissance, GETDATE()), c.dateNaissance) > GETDATE() 
                                THEN 1 ELSE 0 END AS Age,
                                COUNT(DISTINCT cmd.idCommande) AS NombreCommandes,
                                ISNULL(SUM(cmd.montantTotale), 0) AS MontantTotalAchats
                            FROM Client c
                            LEFT JOIN Commandes cmd ON c.idClient = cmd.idClient
                            {(string.IsNullOrEmpty(finalWhereClause) ? "" : finalWhereClause)}
                            GROUP BY 
                                c.idClient, c.nom, c.prenom, c.CIN, c.telephone, 
                                c.adresse, c.ville, c.codePostale, c.dateNaissance, c.dateCreation
                            {finalHavingClause}
                            ORDER BY c.nom, c.prenom";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement des clients : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Vérifier si un client a des commandes
        /// </summary>
        public static int ObtenirNombreCommandes(int idClient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Commandes WHERE idClient = @idClient";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idClient", idClient);
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la vérification des commandes : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes Statistiques

        /// <summary>
        /// Obtenir les statistiques globales des clients
        /// </summary>
        public static ClientStatistiques ObtenirStatistiques()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                    COUNT(DISTINCT c.idClient) AS TotalClients,
                                    COUNT(DISTINCT CASE WHEN cmd.idCommande IS NOT NULL THEN c.idClient END) AS ClientsActifs,
                                    ISNULL(SUM(cmd.montantTotale), 0) AS RevenuTotal
                                FROM Client c
                                LEFT JOIN Commandes cmd ON c.idClient = cmd.idClient";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ClientStatistiques
                            {
                                TotalClients = Convert.ToInt32(reader["TotalClients"]),
                                ClientsActifs = Convert.ToInt32(reader["ClientsActifs"]),
                                RevenuTotal = Convert.ToDecimal(reader["RevenuTotal"])
                            };
                        }
                    }
                }
                return new ClientStatistiques();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement des statistiques : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes de Validation

        /// <summary>
        /// Vérifier si le CIN existe déjà
        /// </summary>
        public static bool CINExiste(string cin, int? idClientExclure = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = idClientExclure.HasValue
                        ? "SELECT COUNT(*) FROM Client WHERE CIN = @cin AND idClient != @idClient"
                        : "SELECT COUNT(*) FROM Client WHERE CIN = @cin";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cin", cin);
                    if (idClientExclure.HasValue)
                        cmd.Parameters.AddWithValue("@idClient", idClientExclure.Value);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la vérification du CIN : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Valider les données du client
        /// </summary>
        public bool Valider(out string messageErreur)
        {
            messageErreur = "";

            if (string.IsNullOrWhiteSpace(Nom))
            {
                messageErreur = "Le nom est obligatoire.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Prenom))
            {
                messageErreur = "Le prénom est obligatoire.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(CIN))
            {
                messageErreur = "Le CIN est obligatoire.";
                return false;
            }

            if (CIN.Length < 6)
            {
                messageErreur = "Le CIN doit contenir au moins 6 caractères.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Telephone))
            {
                messageErreur = "Le téléphone est obligatoire.";
                return false;
            }

            if (DateNaissance.HasValue && DateNaissance.Value >= DateTime.Now)
            {
                messageErreur = "La date de naissance ne peut pas être dans le futur.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Vérifier l'âge minimum (retourne true si le client est mineur)
        /// </summary>
        public bool EstMineur()
        {
            return Age < 18;
        }

        #endregion
    }

    /// <summary>
    /// Classe pour les statistiques des clients
    /// </summary>
    public class ClientStatistiques
    {
        public int TotalClients { get; set; }
        public int ClientsActifs { get; set; }
        public decimal RevenuTotal { get; set; }
    }
}