using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace gestion_pharmacie
{
    internal class ImpressionCommande
    {
        private int _idCommande;
        private PrintDocument _printDocument;

        private DataRow facture;
        private DataRow commande;
        private DataRow client;
        private DataTable details;

        private string connectionString = "data source=IN-5CG3444P44\\GI2;initial catalog=Pharmacie; integrated security=SSPI; TrustServerCertificate=True";

        // Couleurs du thème
        private Color colorPrimary = Color.FromArgb(34, 62, 91);
        private Color colorSecondary = Color.FromArgb(246, 145, 118);
        private Color colorAccent = Color.FromArgb(233, 244, 238);
        private Color colorBackground = Color.FromArgb(252, 248, 243);

        public ImpressionCommande(int idCommande)
        {
            _idCommande = idCommande;
            _printDocument = new PrintDocument();
            _printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void Imprimer()
        {
            ChargerDonnees();

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = _printDocument;
            preview.Width = 900;
            preview.Height = 700;

            if (preview.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _printDocument.Print();
            }
        }

        private void ChargerDonnees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Charger facture
                SqlDataAdapter daFacture = new SqlDataAdapter(
                    "SELECT * FROM Factures WHERE idCommande = " + _idCommande, conn);
                DataTable dtFacture = new DataTable();
                daFacture.Fill(dtFacture);
                facture = dtFacture.Rows[0];

                // Charger commande
                SqlDataAdapter daCommande = new SqlDataAdapter(
                    @"SELECT c.*, cl.nom, cl.prenom, cl.telephone, cl.adresse, cl.CIN 
                      FROM Commandes c
                      LEFT JOIN Client cl ON cl.idClient = c.idClient
                      WHERE idCommande = " + _idCommande, conn);

                DataTable dtCommande = new DataTable();
                daCommande.Fill(dtCommande);
                commande = dtCommande.Rows[0];
                client = dtCommande.Rows[0];

                // Charger détails
                SqlDataAdapter daDetails = new SqlDataAdapter(
                    @"SELECT m.reference AS Ref, m.nomMed AS Medicament, lc.quantite AS Qte,
                             lc.prixUnitaire AS Prix, lc.prixTotale AS Total
                      FROM ligneCommande lc
                      INNER JOIN Medicament m ON lc.idMed = m.idMed
                      WHERE lc.idCommande = " + _idCommande, conn);

                details = new DataTable();
                daDetails.Fill(details);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fonts
            Font fontTitle = new Font("Segoe UI", 24, FontStyle.Bold);
            Font fontSectionTitle = new Font("Segoe UI", 14, FontStyle.Bold);
            Font fontBold = new Font("Segoe UI", 10, FontStyle.Bold);
            Font fontRegular = new Font("Segoe UI", 10);
            Font fontSmall = new Font("Segoe UI", 9);

            // Brushes et Pens
            Brush brushPrimary = new SolidBrush(colorPrimary);
            Brush brushSecondary = new SolidBrush(colorSecondary);
            Brush brushBlack = Brushes.Black;
            Brush brushGray = Brushes.Gray;
            Brush brushWhite = Brushes.White;
            Pen penPrimary = new Pen(colorPrimary, 2);
            Pen penLight = new Pen(colorAccent, 1);

            float y = 30;
            float left = 50;
            float right = e.PageBounds.Width - 50;
            float width = right - left;

            // ===== HEADER AVEC FOND COLORÉ =====
            RectangleF headerRect = new RectangleF(left, y, width, 80);
            g.FillRectangle(brushPrimary, headerRect);

            g.DrawString("💊 PHARMACIE", fontTitle, brushWhite, left + 20, y + 15);
            g.DrawString("FACTURE N° " + facture["numFacture"], fontSectionTitle, new SolidBrush(colorAccent), left + 20, y + 50);

            y += 100;

            // ===== INFORMATIONS FACTURE ET CLIENT SUR DEUX COLONNES =====
            float colWidth = width / 2 - 10;

            // COLONNE GAUCHE - Info Facture
            DrawSectionBox(g, left, y, colWidth, 140, "📄 Informations Facture", brushPrimary);
            float yCol = y + 40;

            DrawInfoLine(g, "Date facture:", Convert.ToDateTime(facture["dateFacture"]).ToString("dd/MM/yyyy HH:mm"),
                        left + 15, yCol, fontBold, fontRegular);
            yCol += 25;

            DrawInfoLine(g, "Statut paiement:", facture["statusPaiement"].ToString(),
                        left + 15, yCol, fontBold, fontRegular);
            yCol += 25;

            DrawInfoLine(g, "Mode paiement:", facture["modePaiement"] == DBNull.Value ? "—" : facture["modePaiement"].ToString(),
                        left + 15, yCol, fontBold, fontRegular);
            yCol += 25;

            if (facture["datePaiement"] != DBNull.Value)
            {
                DrawInfoLine(g, "Date paiement:", Convert.ToDateTime(facture["datePaiement"]).ToString("dd/MM/yyyy HH:mm"),
                            left + 15, yCol, fontBold, fontRegular);
            }

            // COLONNE DROITE - Info Client
            float rightCol = left + colWidth + 20;
            DrawSectionBox(g, rightCol, y, colWidth, 140, "👤 Client", brushPrimary);
            yCol = y + 40;

            DrawInfoLine(g, "Nom:", client["nom"] + " " + client["prenom"],
                        rightCol + 15, yCol, fontBold, fontRegular);
            yCol += 25;

            DrawInfoLine(g, "CIN:", client["CIN"].ToString(),
                        rightCol + 15, yCol, fontBold, fontRegular);
            yCol += 25;

            DrawInfoLine(g, "Téléphone:", client["telephone"].ToString(),
                        rightCol + 15, yCol, fontBold, fontRegular);
            yCol += 25;

            DrawInfoLine(g, "Adresse:", client["adresse"].ToString(),
                        rightCol + 15, yCol, fontBold, fontRegular);

            y += 160;

            // ===== DÉTAILS COMMANDE =====
            DrawSectionBox(g, left, y, width, 25, "📦 Détails de la Commande", brushSecondary);
            y += 35;

            // En-têtes du tableau avec fond coloré
            RectangleF tableHeaderRect = new RectangleF(left, y, width, 30);
            g.FillRectangle(brushPrimary, tableHeaderRect);

            g.DrawString("Réf", fontBold, brushWhite, left + 10, y + 8);
            g.DrawString("Médicament", fontBold, brushWhite, left + 80, y + 8);
            g.DrawString("Qté", fontBold, brushWhite, right - 280, y + 8);
            g.DrawString("Prix Unit.", fontBold, brushWhite, right - 200, y + 8);
            g.DrawString("Total", fontBold, brushWhite, right - 100, y + 8);

            y += 35;

            decimal totalCommande = 0;
            bool alternateRow = false;

            foreach (DataRow row in details.Rows)
            {
                // Fond alterné pour les lignes
                if (alternateRow)
                {
                    RectangleF rowRect = new RectangleF(left, y - 2, width, 25);
                    g.FillRectangle(new SolidBrush(colorBackground), rowRect);
                }

                g.DrawString(row["Ref"].ToString(), fontSmall, brushBlack, left + 10, y);
                g.DrawString(row["Medicament"].ToString(), fontSmall, brushBlack, left + 80, y);
                g.DrawString(row["Qte"].ToString(), fontSmall, brushBlack, right - 280, y);
                g.DrawString(Convert.ToDecimal(row["Prix"]).ToString("0.00") + " DH", fontSmall, brushBlack, right - 200, y);
                g.DrawString(Convert.ToDecimal(row["Total"]).ToString("0.00") + " DH", fontBold, brushBlack, right - 100, y);

                totalCommande += Convert.ToDecimal(row["Total"]);
                y += 25;
                alternateRow = !alternateRow;

                if (y > e.PageBounds.Height - 200)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // ===== LIGNE TOTALE =====
            y += 10;
            g.DrawLine(penPrimary, left, y, right, y);
            y += 15;

            // Encadré pour le total
            RectangleF totalRect = new RectangleF(right - 250, y, 250, 40);
            g.FillRectangle(brushSecondary, totalRect);
            g.DrawString("MONTANT TOTAL", fontBold, brushWhite, right - 240, y + 6);
            g.DrawString(totalCommande.ToString("0.00") + " DH", fontTitle, brushWhite, right - 210, y + 8);

            // ===== FOOTER =====
            y = e.PageBounds.Height - 100;
            g.DrawLine(penLight, left, y, right, y);
            y += 15;

            // Message de remerciement avec icône
            g.DrawString("Merci pour votre confiance ! 💙", fontBold, brushSecondary, left, y);

            // Date et heure de génération
            string dateGeneration = "Document généré le " + DateTime.Now.ToString("dd/MM/yyyy à HH:mm");
            SizeF textSize = g.MeasureString(dateGeneration, fontSmall);
            g.DrawString(dateGeneration, fontSmall, brushGray, right - textSize.Width, y);

            y += 25;
            g.DrawString("📍 Adresse de la pharmacie | 📞 +212 XXX XXX XXX", fontSmall, brushGray, left, y);

            e.HasMorePages = false;
        }

        // Méthode helper pour dessiner une boîte de section
        private void DrawSectionBox(Graphics g, float x, float y, float width, float height, string title, Brush brush)
        {
            // Bordure
            g.DrawRectangle(new Pen(brush, 2), x, y, width, height);

            // Titre
            Font fontTitle = new Font("Segoe UI", 11, FontStyle.Bold);
            g.DrawString(title, fontTitle, brush, x + 10, y + 8);
        }

        // Méthode helper pour dessiner une ligne d'information
        private void DrawInfoLine(Graphics g, string label, string value, float x, float y, Font fontLabel, Font fontValue)
        {
            g.DrawString(label, fontLabel, Brushes.Gray, x, y);
            g.DrawString(value, fontValue, Brushes.Black, x + 130, y);
        }
    }
}