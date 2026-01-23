using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace gestion_pharmacie
{
    /// <summary>
    /// Classe représentant une commande
    /// </summary>
    public class Commande
    {
        #region Propriétés
        public int IdCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public decimal MontantTotale { get; set; }
        public string Statut { get; set; }
        public DateTime? DateLivraison { get; set; }
        public int? IdAdmin { get; set; }
        public int IdClient { get; set; }

        // Propriétés supplémentaires pour l'affichage
        public string NomClient { get; set; }
        public string CINClient { get; set; }
        public string TelephoneClient { get; set; }
        public string NomPharmacien { get; set; }
        public int NbArticles { get; set; }
        #endregion

        #region Connexion Base de Données
        private static string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie;integrated security=SSPI;TrustServerCertificate=True";

        public static void SetConnectionString(string connString)
        {
            connectionString = connString;
        }
        #endregion

        #region Constructeurs
        public Commande() { }
        #endregion

        #region Méthodes CRUD

        /// <summary>
        /// Ajouter une nouvelle commande avec ses lignes
        /// </summary>
        public bool Ajouter(List<LigneCommande> lignes)
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                transaction = conn.BeginTransaction();

                // 1. Insérer la commande
                string sqlCommande = @"INSERT INTO Commandes 
                                      (dateCommande, montantTotale, statut, dateLivraison, idAdmin, idClient)
                                      VALUES (@dateCommande, @montantTotale, @statut, @dateLivraison, @idAdmin, @idClient);
                                      SELECT SCOPE_IDENTITY();";

                SqlCommand cmdCommande = new SqlCommand(sqlCommande, conn, transaction);
                cmdCommande.Parameters.AddWithValue("@dateCommande", DateCommande);
                cmdCommande.Parameters.AddWithValue("@montantTotale", MontantTotale);
                cmdCommande.Parameters.AddWithValue("@statut", Statut);
                cmdCommande.Parameters.AddWithValue("@dateLivraison", DateLivraison.HasValue ? (object)DateLivraison.Value : DBNull.Value);
                cmdCommande.Parameters.AddWithValue("@idAdmin", IdAdmin.HasValue ? (object)IdAdmin.Value : DBNull.Value);
                cmdCommande.Parameters.AddWithValue("@idClient", IdClient);

                object result = cmdCommande.ExecuteScalar();
                if (result != null)
                {
                    IdCommande = Convert.ToInt32(result);

                    // 2. Insérer les lignes de commande et mettre à jour le stock
                    foreach (var ligne in lignes)
                    {
                        string sqlLigne = @"INSERT INTO ligneCommande (idCommande, idMed, quantite, prixUnitaire)
                                           VALUES (@idCommande, @idMed, @quantite, @prixUnitaire)";

                        SqlCommand cmdLigne = new SqlCommand(sqlLigne, conn, transaction);
                        cmdLigne.Parameters.AddWithValue("@idCommande", IdCommande);
                        cmdLigne.Parameters.AddWithValue("@idMed", ligne.IdMed);
                        cmdLigne.Parameters.AddWithValue("@quantite", ligne.Quantite);
                        cmdLigne.Parameters.AddWithValue("@prixUnitaire", ligne.PrixUnitaire);
                        cmdLigne.ExecuteNonQuery();

                        // Mettre à jour le stock
                        string sqlUpdateStock = @"UPDATE Medicament 
                                                 SET quantiteStocke = quantiteStocke - @quantite 
                                                 WHERE idMed = @idMed";

                        SqlCommand cmdStock = new SqlCommand(sqlUpdateStock, conn, transaction);
                        cmdStock.Parameters.AddWithValue("@quantite", ligne.Quantite);
                        cmdStock.Parameters.AddWithValue("@idMed", ligne.IdMed);
                        cmdStock.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception($"Erreur lors de l'ajout de la commande : {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        /// <summary>
        /// Modifier une commande existante
        /// </summary>
        public bool Modifier(List<LigneCommande> nouvellesLignes, string ancienStatut)
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                transaction = conn.BeginTransaction();

                // CAS 1 : Annulation
                if (Statut == "Annulée" && ancienStatut != "Annulée")
                {
                    // Restaurer le stock
                    string sqlRestoreStock = @"UPDATE Medicament 
                                      SET quantiteStocke = quantiteStocke + lc.quantite
                                      FROM Medicament m
                                      INNER JOIN ligneCommande lc ON m.idMed = lc.idMed
                                      WHERE lc.idCommande = @idCommande";

                    SqlCommand cmdRestore = new SqlCommand(sqlRestoreStock, conn, transaction);
                    cmdRestore.Parameters.AddWithValue("@idCommande", IdCommande);
                    cmdRestore.ExecuteNonQuery();

                    // Mettre à jour le statut
                    string sqlUpdate = "UPDATE Commandes SET statut = @statut WHERE idCommande = @idCommande";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn, transaction);
                    cmdUpdate.Parameters.AddWithValue("@statut", Statut);
                    cmdUpdate.Parameters.AddWithValue("@idCommande", IdCommande);
                    cmdUpdate.ExecuteNonQuery();
                }
                // CAS 2 : Réactivation
                else if (ancienStatut == "Annulée" && Statut != "Annulée")
                {
                    // Diminuer le stock
                    string sqlReduceStock = @"UPDATE Medicament 
                                     SET quantiteStocke = quantiteStocke - lc.quantite
                                     FROM Medicament m
                                     INNER JOIN ligneCommande lc ON m.idMed = lc.idMed
                                     WHERE lc.idCommande = @idCommande";

                    SqlCommand cmdReduce = new SqlCommand(sqlReduceStock, conn, transaction);
                    cmdReduce.Parameters.AddWithValue("@idCommande", IdCommande);
                    cmdReduce.ExecuteNonQuery();

                    // Mettre à jour la commande
                    UpdateCommandeDetails(conn, transaction);
                }
                // CAS 3 : Modification normale
                else
                {
                    // 1. Restaurer le stock des anciennes lignes
                    string sqlRestoreStock = @"UPDATE Medicament 
                                      SET quantiteStocke = quantiteStocke + lc.quantite
                                      FROM Medicament m
                                      INNER JOIN ligneCommande lc ON m.idMed = lc.idMed
                                      WHERE lc.idCommande = @idCommande";

                    SqlCommand cmdRestore = new SqlCommand(sqlRestoreStock, conn, transaction);
                    cmdRestore.Parameters.AddWithValue("@idCommande", IdCommande);
                    cmdRestore.ExecuteNonQuery();

                    // 2. Supprimer les anciennes lignes
                    string sqlDeleteLignes = "DELETE FROM ligneCommande WHERE idCommande = @idCommande";
                    SqlCommand cmdDelete = new SqlCommand(sqlDeleteLignes, conn, transaction);
                    cmdDelete.Parameters.AddWithValue("@idCommande", IdCommande);
                    cmdDelete.ExecuteNonQuery();

                    // 3. Mettre à jour la commande
                    UpdateCommandeDetails(conn, transaction);

                    // 4. Insérer les nouvelles lignes et mettre à jour le stock
                    foreach (var ligne in nouvellesLignes)
                    {
                        string sqlLigne = @"INSERT INTO ligneCommande (idCommande, idMed, quantite, prixUnitaire)
                                           VALUES (@idCommande, @idMed, @quantite, @prixUnitaire)";

                        SqlCommand cmdLigne = new SqlCommand(sqlLigne, conn, transaction);
                        cmdLigne.Parameters.AddWithValue("@idCommande", IdCommande);
                        cmdLigne.Parameters.AddWithValue("@idMed", ligne.IdMed);
                        cmdLigne.Parameters.AddWithValue("@quantite", ligne.Quantite);
                        cmdLigne.Parameters.AddWithValue("@prixUnitaire", ligne.PrixUnitaire);
                        cmdLigne.ExecuteNonQuery();

                        // Mettre à jour le stock
                        string sqlUpdateStock = @"UPDATE Medicament 
                                                 SET quantiteStocke = quantiteStocke - @quantite 
                                                 WHERE idMed = @idMed";

                        SqlCommand cmdStock = new SqlCommand(sqlUpdateStock, conn, transaction);
                        cmdStock.Parameters.AddWithValue("@quantite", ligne.Quantite);
                        cmdStock.Parameters.AddWithValue("@idMed", ligne.IdMed);
                        cmdStock.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception($"Erreur lors de la modification de la commande : {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void UpdateCommandeDetails(SqlConnection conn, SqlTransaction transaction)
        {
            string sqlCommande = @"UPDATE Commandes SET 
                                  dateCommande = @dateCommande,
                                  montantTotale = @montantTotale,
                                  statut = @statut,
                                  dateLivraison = @dateLivraison,
                                  idClient = @idClient
                                  WHERE idCommande = @idCommande";

            SqlCommand cmdCommande = new SqlCommand(sqlCommande, conn, transaction);
            cmdCommande.Parameters.AddWithValue("@dateCommande", DateCommande);
            cmdCommande.Parameters.AddWithValue("@montantTotale", MontantTotale);
            cmdCommande.Parameters.AddWithValue("@statut", Statut);
            cmdCommande.Parameters.AddWithValue("@dateLivraison", DateLivraison.HasValue ? (object)DateLivraison.Value : DBNull.Value);
            cmdCommande.Parameters.AddWithValue("@idClient", IdClient);
            cmdCommande.Parameters.AddWithValue("@idCommande", IdCommande);
            cmdCommande.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprimer une commande
        /// </summary>
        public static bool Supprimer(int idCommande)
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                transaction = conn.BeginTransaction();

                // 1. Supprimer la facture
                string sqlDeleteFacture = "DELETE FROM Factures WHERE idCommande = @idCommande";
                SqlCommand cmdDeleteFacture = new SqlCommand(sqlDeleteFacture, conn, transaction);
                cmdDeleteFacture.Parameters.AddWithValue("@idCommande", idCommande);
                cmdDeleteFacture.ExecuteNonQuery();

                // 2. Restaurer le stock
                string sqlRestoreStock = @"UPDATE Medicament 
                                  SET quantiteStocke = quantiteStocke + lc.quantite
                                  FROM Medicament m
                                  INNER JOIN ligneCommande lc ON m.idMed = lc.idMed
                                  WHERE lc.idCommande = @idCommande";

                SqlCommand cmdRestore = new SqlCommand(sqlRestoreStock, conn, transaction);
                cmdRestore.Parameters.AddWithValue("@idCommande", idCommande);
                cmdRestore.ExecuteNonQuery();

                // 3. Supprimer les lignes
                string sqlDeleteLignes = "DELETE FROM ligneCommande WHERE idCommande = @idCommande";
                SqlCommand cmdDeleteLignes = new SqlCommand(sqlDeleteLignes, conn, transaction);
                cmdDeleteLignes.Parameters.AddWithValue("@idCommande", idCommande);
                cmdDeleteLignes.ExecuteNonQuery();

                // 4. Supprimer la commande
                string sqlDelete = "DELETE FROM Commandes WHERE idCommande = @idCommande";
                SqlCommand cmdDelete = new SqlCommand(sqlDelete, conn, transaction);
                cmdDelete.Parameters.AddWithValue("@idCommande", idCommande);
                int rowsAffected = cmdDelete.ExecuteNonQuery();

                transaction.Commit();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception($"Erreur lors de la suppression de la commande : {ex.Message}", ex);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        #endregion

        #region Méthodes de Recherche et Liste

        /// <summary>
        /// Obtenir toutes les commandes
        /// </summary>
        public static DataTable ObtenirTous(string whereClause = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    c.idCommande,
                                    c.dateCommande,
                                    CONCAT(cl.nom, ' ', cl.prenom) AS Client,
                                    cl.CIN,
                                    cl.telephone,
                                    c.montantTotale,
                                    c.statut,
                                    c.dateLivraison,
                                    CONCAT(p.nom, ' ', p.prenom) AS Pharmacien,
                                    (SELECT COUNT(*) FROM ligneCommande WHERE idCommande = c.idCommande) AS NbArticles
                                   FROM Commandes c
                                   LEFT JOIN Client cl ON c.idClient = cl.idClient
                                   LEFT JOIN Pharmacien p ON c.idAdmin = p.idAdmin";

                    if (!string.IsNullOrEmpty(whereClause))
                    {
                        query += " " + whereClause;
                    }

                    query += " ORDER BY c.dateCommande DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement des commandes : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Rechercher des commandes
        /// </summary>
        public static DataTable Rechercher(string critere, string valeur)
        {
            string whereClause = "";
            switch (critere)
            {
                case "Client":
                    whereClause = "WHERE (cl.nom LIKE '%" + valeur + "%' OR cl.prenom LIKE '%" + valeur + "%')";
                    break;
                case "CIN":
                    whereClause = "WHERE cl.CIN LIKE '%" + valeur + "%'";
                    break;
                case "Statut":
                    whereClause = "WHERE c.statut LIKE '%" + valeur + "%'";
                    break;
                case "Date":
                    // La gestion de la date doit être faite avant l'appel pour formater la valeur
                    whereClause = $"WHERE CAST(c.dateCommande AS DATE) = '{valeur}'";
                    break;
            }

            return ObtenirTous(whereClause);
        }

        /// <summary>
        /// Obtenir une commande par son ID
        /// </summary>
        public static Commande ObtenirParId(int idCommande)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT c.idCommande, c.dateCommande, c.montantTotale, c.statut, 
                                  c.dateLivraison, c.idClient, c.idAdmin
                                  FROM Commandes c
                                  WHERE c.idCommande = @idCommande";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idCommande", idCommande);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Commande
                            {
                                IdCommande = Convert.ToInt32(reader["idCommande"]),
                                DateCommande = Convert.ToDateTime(reader["dateCommande"]),
                                MontantTotale = Convert.ToDecimal(reader["montantTotale"]),
                                Statut = reader["statut"].ToString(),
                                DateLivraison = reader["dateLivraison"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["dateLivraison"]) : null,
                                IdClient = Convert.ToInt32(reader["idClient"]),
                                IdAdmin = reader["idAdmin"] != DBNull.Value ? (int?)Convert.ToInt32(reader["idAdmin"]) : null
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la récupération de la commande : {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Obtenir les lignes d'une commande
        /// </summary>
        public static List<LigneCommande> ObtenirLignes(int idCommande)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT lc.idMed, m.nomMed, lc.quantite, lc.prixUnitaire
                                    FROM ligneCommande lc
                                    INNER JOIN Medicament m ON lc.idMed = m.idMed
                                    WHERE lc.idCommande = @idCommande";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idCommande", idCommande);

                    List<LigneCommande> lignes = new List<LigneCommande>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lignes.Add(new LigneCommande
                            {
                                IdMed = Convert.ToInt32(reader["idMed"]),
                                NomMed = reader["nomMed"].ToString(),
                                Quantite = Convert.ToInt32(reader["quantite"]),
                                PrixUnitaire = Convert.ToDecimal(reader["prixUnitaire"])
                            });
                        }
                    }
                    return lignes;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement des lignes : {ex.Message}", ex);
            }
        }

        #endregion

        #region Méthodes Statistiques

        /// <summary>
        /// Obtenir les statistiques des commandes
        /// </summary>
        public static CommandeStatistiques ObtenirStatistiques()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    COUNT(DISTINCT c.idCommande) AS TotalCommandes,
                                    COUNT(CASE WHEN c.statut = 'En cours' THEN 1 END) AS CommandesEnCours,
                                    COUNT(CASE WHEN c.statut = 'Validée' THEN 1 END) AS CommandesValidees,
                                    COUNT(CASE WHEN c.statut = 'Livrée' THEN 1 END) AS CommandesLivrees,
                                    ISNULL(SUM(c.montantTotale), 0) AS MontantTotal
                                FROM Commandes c";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new CommandeStatistiques
                            {
                                TotalCommandes = Convert.ToInt32(reader["TotalCommandes"]),
                                CommandesEnCours = Convert.ToInt32(reader["CommandesEnCours"]),
                                CommandesValidees = Convert.ToInt32(reader["CommandesValidees"]),
                                CommandesLivrees = Convert.ToInt32(reader["CommandesLivrees"]),
                                MontantTotal = Convert.ToDecimal(reader["MontantTotal"])
                            };
                        }
                    }
                }
                return new CommandeStatistiques();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du calcul des statistiques : {ex.Message}", ex);
            }
        }

        #endregion
    }

    /// <summary>
    /// Classe représentant une ligne de commande
    /// </summary>
    public class LigneCommande
    {
        public int IdMed { get; set; }
        public string NomMed { get; set; }
        public int Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }
        public decimal PrixTotal => Quantite * PrixUnitaire;
    }

    /// <summary>
    /// Classe pour les statistiques des commandes
    /// </summary>
    public class CommandeStatistiques
    {
        public int TotalCommandes { get; set; }
        public int CommandesEnCours { get; set; }
        public int CommandesValidees { get; set; }
        public int CommandesLivrees { get; set; }
        public decimal MontantTotal { get; set; }
    }
}
