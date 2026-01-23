namespace gestion_pharmacie
{
    partial class FormDetailsMedicament
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitre = new Label();
            panelPrincipal = new Panel();
            panelGauche = new Panel();
            pictureBoxMedicament = new PictureBox();
            labelReference = new Label();
            labelNomMedicament = new Label();
            panelDroite = new Panel();
            panelInfosGenerales = new Panel();
            labelInfosGeneralesTitre = new Label();
            labelDescriptionTitre = new Label();
            labelDescription = new Label();
            labelCategorieTitre = new Label();
            labelCategorie = new Label();
            labelDateCreationTitre = new Label();
            labelDateCreation = new Label();
            panelStock = new Panel();
            labelStockTitre = new Label();
            labelQuantiteStockTitre = new Label();
            labelQuantiteStock = new Label();
            labelSeuilAlerteTitre = new Label();
            labelSeuilAlerte = new Label();
            labelDatePeremptionTitre = new Label();
            labelDatePeremption = new Label();
            panelPrix = new Panel();
            labelPrixTitre = new Label();
            labelPrixAchatTitre = new Label();
            labelPrixAchat = new Label();
            labelPrixVenteTitre = new Label();
            labelPrixVente = new Label();
            panelFournisseur = new Panel();
            labelFournisseurTitre = new Label();
            labelNomEntrepriseTitre = new Label();
            labelNomEntreprise = new Label();
            labelTelephoneTitre = new Label();
            labelTelephone = new Label();
            panelHeader.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMedicament).BeginInit();
            panelDroite.SuspendLayout();
            panelInfosGenerales.SuspendLayout();
            panelStock.SuspendLayout();
            panelPrix.SuspendLayout();
            panelFournisseur.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(34, 62, 91);
            panelHeader.Controls.Add(labelTitre);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(2, 2, 2, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1120, 64);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitre.ForeColor = Color.White;
            labelTitre.Location = new Point(24, 18);
            labelTitre.Margin = new Padding(2, 0, 2, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(349, 41);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "📋 Détails Médicament";
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(242, 231, 211);
            panelPrincipal.Controls.Add(panelGauche);
            panelPrincipal.Controls.Add(panelDroite);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 64);
            panelPrincipal.Margin = new Padding(2, 2, 2, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(24, 24, 24, 24);
            panelPrincipal.Size = new Size(1120, 656);
            panelPrincipal.TabIndex = 1;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // panelGauche
            // 
            panelGauche.BackColor = Color.White;
            panelGauche.Controls.Add(pictureBoxMedicament);
            panelGauche.Controls.Add(labelReference);
            panelGauche.Controls.Add(labelNomMedicament);
            panelGauche.Location = new Point(24, 24);
            panelGauche.Margin = new Padding(2, 2, 2, 2);
            panelGauche.Name = "panelGauche";
            panelGauche.Padding = new Padding(20, 20, 20, 20);
            panelGauche.Size = new Size(360, 608);
            panelGauche.TabIndex = 0;
            // 
            // pictureBoxMedicament
            // 
            pictureBoxMedicament.BackColor = Color.FromArgb(233, 244, 238);
            pictureBoxMedicament.Location = new Point(20, 20);
            pictureBoxMedicament.Margin = new Padding(2, 2, 2, 2);
            pictureBoxMedicament.Name = "pictureBoxMedicament";
            pictureBoxMedicament.Size = new Size(320, 320);
            pictureBoxMedicament.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMedicament.TabIndex = 0;
            pictureBoxMedicament.TabStop = false;
            // 
            // labelReference
            // 
            labelReference.AutoSize = true;
            labelReference.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelReference.ForeColor = Color.FromArgb(246, 145, 118);
            labelReference.Location = new Point(20, 360);
            labelReference.Margin = new Padding(2, 0, 2, 0);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(157, 28);
            labelReference.TabIndex = 1;
            labelReference.Text = "Réf: MED-0001";
            // 
            // labelNomMedicament
            // 
            labelNomMedicament.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelNomMedicament.ForeColor = Color.FromArgb(34, 62, 91);
            labelNomMedicament.Location = new Point(20, 400);
            labelNomMedicament.Margin = new Padding(2, 0, 2, 0);
            labelNomMedicament.Name = "labelNomMedicament";
            labelNomMedicament.Size = new Size(320, 192);
            labelNomMedicament.TabIndex = 2;
            labelNomMedicament.Text = "Nom du Médicament";
            // 
            // panelDroite
            // 
            panelDroite.AutoScroll = true;
            panelDroite.BackColor = Color.FromArgb(242, 231, 211);
            panelDroite.Controls.Add(panelInfosGenerales);
            panelDroite.Controls.Add(panelStock);
            panelDroite.Controls.Add(panelPrix);
            panelDroite.Controls.Add(panelFournisseur);
            panelDroite.Location = new Point(408, 24);
            panelDroite.Margin = new Padding(2, 2, 2, 2);
            panelDroite.Name = "panelDroite";
            panelDroite.Size = new Size(702, 608);
            panelDroite.TabIndex = 1;
            // 
            // panelInfosGenerales
            // 
            panelInfosGenerales.BackColor = Color.White;
            panelInfosGenerales.Controls.Add(labelInfosGeneralesTitre);
            panelInfosGenerales.Controls.Add(labelDescriptionTitre);
            panelInfosGenerales.Controls.Add(labelDescription);
            panelInfosGenerales.Controls.Add(labelCategorieTitre);
            panelInfosGenerales.Controls.Add(labelCategorie);
            panelInfosGenerales.Controls.Add(labelDateCreationTitre);
            panelInfosGenerales.Controls.Add(labelDateCreation);
            panelInfosGenerales.Location = new Point(0, 0);
            panelInfosGenerales.Margin = new Padding(2, 2, 2, 2);
            panelInfosGenerales.Name = "panelInfosGenerales";
            panelInfosGenerales.Padding = new Padding(20, 20, 20, 20);
            panelInfosGenerales.Size = new Size(672, 224);
            panelInfosGenerales.TabIndex = 0;
            // 
            // labelInfosGeneralesTitre
            // 
            labelInfosGeneralesTitre.AutoSize = true;
            labelInfosGeneralesTitre.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelInfosGeneralesTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelInfosGeneralesTitre.Location = new Point(20, 20);
            labelInfosGeneralesTitre.Margin = new Padding(2, 0, 2, 0);
            labelInfosGeneralesTitre.Name = "labelInfosGeneralesTitre";
            labelInfosGeneralesTitre.Size = new Size(291, 30);
            labelInfosGeneralesTitre.TabIndex = 0;
            labelInfosGeneralesTitre.Text = "📝 Informations Générales";
            // 
            // labelDescriptionTitre
            // 
            labelDescriptionTitre.AutoSize = true;
            labelDescriptionTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDescriptionTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelDescriptionTitre.Location = new Point(20, 64);
            labelDescriptionTitre.Margin = new Padding(2, 0, 2, 0);
            labelDescriptionTitre.Name = "labelDescriptionTitre";
            labelDescriptionTitre.Size = new Size(112, 23);
            labelDescriptionTitre.TabIndex = 1;
            labelDescriptionTitre.Text = "Description :";
            // 
            // labelDescription
            // 
            labelDescription.Font = new Font("Segoe UI", 10F);
            labelDescription.ForeColor = Color.FromArgb(34, 62, 91);
            labelDescription.Location = new Point(20, 92);
            labelDescription.Margin = new Padding(2, 0, 2, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(632, 48);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Description du médicament";
            // 
            // labelCategorieTitre
            // 
            labelCategorieTitre.AutoSize = true;
            labelCategorieTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCategorieTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelCategorieTitre.Location = new Point(20, 152);
            labelCategorieTitre.Margin = new Padding(2, 0, 2, 0);
            labelCategorieTitre.Name = "labelCategorieTitre";
            labelCategorieTitre.Size = new Size(98, 23);
            labelCategorieTitre.TabIndex = 3;
            labelCategorieTitre.Text = "Catégorie :";
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.Font = new Font("Segoe UI", 10F);
            labelCategorie.ForeColor = Color.FromArgb(34, 62, 91);
            labelCategorie.Location = new Point(120, 152);
            labelCategorie.Margin = new Padding(2, 0, 2, 0);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(84, 23);
            labelCategorie.TabIndex = 4;
            labelCategorie.Text = "Catégorie";
            // 
            // labelDateCreationTitre
            // 
            labelDateCreationTitre.AutoSize = true;
            labelDateCreationTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDateCreationTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelDateCreationTitre.Location = new Point(20, 184);
            labelDateCreationTitre.Margin = new Padding(2, 0, 2, 0);
            labelDateCreationTitre.Name = "labelDateCreationTitre";
            labelDateCreationTitre.Size = new Size(156, 23);
            labelDateCreationTitre.TabIndex = 5;
            labelDateCreationTitre.Text = "Date de Création :";
            // 
            // labelDateCreation
            // 
            labelDateCreation.AutoSize = true;
            labelDateCreation.Font = new Font("Segoe UI", 10F);
            labelDateCreation.ForeColor = Color.FromArgb(34, 62, 91);
            labelDateCreation.Location = new Point(171, 184);
            labelDateCreation.Margin = new Padding(2, 0, 2, 0);
            labelDateCreation.Name = "labelDateCreation";
            labelDateCreation.Size = new Size(96, 23);
            labelDateCreation.TabIndex = 6;
            labelDateCreation.Text = "01/01/2024";
            // 
            // panelStock
            // 
            panelStock.BackColor = Color.White;
            panelStock.Controls.Add(labelStockTitre);
            panelStock.Controls.Add(labelQuantiteStockTitre);
            panelStock.Controls.Add(labelQuantiteStock);
            panelStock.Controls.Add(labelSeuilAlerteTitre);
            panelStock.Controls.Add(labelSeuilAlerte);
            panelStock.Controls.Add(labelDatePeremptionTitre);
            panelStock.Controls.Add(labelDatePeremption);
            panelStock.Location = new Point(0, 240);
            panelStock.Margin = new Padding(2, 2, 2, 2);
            panelStock.Name = "panelStock";
            panelStock.Padding = new Padding(20, 20, 20, 20);
            panelStock.Size = new Size(672, 160);
            panelStock.TabIndex = 1;
            // 
            // labelStockTitre
            // 
            labelStockTitre.AutoSize = true;
            labelStockTitre.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelStockTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelStockTitre.Location = new Point(20, 20);
            labelStockTitre.Margin = new Padding(2, 0, 2, 0);
            labelStockTitre.Name = "labelStockTitre";
            labelStockTitre.Size = new Size(191, 30);
            labelStockTitre.TabIndex = 0;
            labelStockTitre.Text = "📦 Gestion Stock";
            // 
            // labelQuantiteStockTitre
            // 
            labelQuantiteStockTitre.AutoSize = true;
            labelQuantiteStockTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelQuantiteStockTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelQuantiteStockTitre.Location = new Point(20, 64);
            labelQuantiteStockTitre.Margin = new Padding(2, 0, 2, 0);
            labelQuantiteStockTitre.Name = "labelQuantiteStockTitre";
            labelQuantiteStockTitre.Size = new Size(164, 23);
            labelQuantiteStockTitre.TabIndex = 1;
            labelQuantiteStockTitre.Text = "Quantité en Stock :";
            // 
            // labelQuantiteStock
            // 
            labelQuantiteStock.AutoSize = true;
            labelQuantiteStock.Font = new Font("Segoe UI", 10F);
            labelQuantiteStock.ForeColor = Color.FromArgb(34, 62, 91);
            labelQuantiteStock.Location = new Point(179, 64);
            labelQuantiteStock.Margin = new Padding(2, 0, 2, 0);
            labelQuantiteStock.Name = "labelQuantiteStock";
            labelQuantiteStock.Size = new Size(19, 23);
            labelQuantiteStock.TabIndex = 2;
            labelQuantiteStock.Text = "0";
            // 
            // labelSeuilAlerteTitre
            // 
            labelSeuilAlerteTitre.AutoSize = true;
            labelSeuilAlerteTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSeuilAlerteTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelSeuilAlerteTitre.Location = new Point(20, 96);
            labelSeuilAlerteTitre.Margin = new Padding(2, 0, 2, 0);
            labelSeuilAlerteTitre.Name = "labelSeuilAlerteTitre";
            labelSeuilAlerteTitre.Size = new Size(113, 23);
            labelSeuilAlerteTitre.TabIndex = 3;
            labelSeuilAlerteTitre.Text = "Seuil Alerte :";
            // 
            // labelSeuilAlerte
            // 
            labelSeuilAlerte.AutoSize = true;
            labelSeuilAlerte.Font = new Font("Segoe UI", 10F);
            labelSeuilAlerte.ForeColor = Color.FromArgb(34, 62, 91);
            labelSeuilAlerte.Location = new Point(132, 96);
            labelSeuilAlerte.Margin = new Padding(2, 0, 2, 0);
            labelSeuilAlerte.Name = "labelSeuilAlerte";
            labelSeuilAlerte.Size = new Size(19, 23);
            labelSeuilAlerte.TabIndex = 4;
            labelSeuilAlerte.Text = "0";
            // 
            // labelDatePeremptionTitre
            // 
            labelDatePeremptionTitre.AutoSize = true;
            labelDatePeremptionTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDatePeremptionTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelDatePeremptionTitre.Location = new Point(20, 128);
            labelDatePeremptionTitre.Margin = new Padding(2, 0, 2, 0);
            labelDatePeremptionTitre.Name = "labelDatePeremptionTitre";
            labelDatePeremptionTitre.Size = new Size(181, 23);
            labelDatePeremptionTitre.TabIndex = 5;
            labelDatePeremptionTitre.Text = "Date de Péremption :";
            // 
            // labelDatePeremption
            // 
            labelDatePeremption.AutoSize = true;
            labelDatePeremption.Font = new Font("Segoe UI", 10F);
            labelDatePeremption.ForeColor = Color.FromArgb(34, 62, 91);
            labelDatePeremption.Location = new Point(194, 128);
            labelDatePeremption.Margin = new Padding(2, 0, 2, 0);
            labelDatePeremption.Name = "labelDatePeremption";
            labelDatePeremption.Size = new Size(96, 23);
            labelDatePeremption.TabIndex = 6;
            labelDatePeremption.Text = "01/01/2025";
            // 
            // panelPrix
            // 
            panelPrix.BackColor = Color.White;
            panelPrix.Controls.Add(labelPrixTitre);
            panelPrix.Controls.Add(labelPrixAchatTitre);
            panelPrix.Controls.Add(labelPrixAchat);
            panelPrix.Controls.Add(labelPrixVenteTitre);
            panelPrix.Controls.Add(labelPrixVente);
            panelPrix.Location = new Point(0, 416);
            panelPrix.Margin = new Padding(2, 2, 2, 2);
            panelPrix.Name = "panelPrix";
            panelPrix.Padding = new Padding(20, 20, 20, 20);
            panelPrix.Size = new Size(672, 108);
            panelPrix.TabIndex = 2;
            // 
            // labelPrixTitre
            // 
            labelPrixTitre.AutoSize = true;
            labelPrixTitre.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelPrixTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrixTitre.Location = new Point(20, 20);
            labelPrixTitre.Margin = new Padding(2, 0, 2, 0);
            labelPrixTitre.Name = "labelPrixTitre";
            labelPrixTitre.Size = new Size(166, 30);
            labelPrixTitre.TabIndex = 0;
            labelPrixTitre.Text = "💰 Tarification";
            // 
            // labelPrixAchatTitre
            // 
            labelPrixAchatTitre.AutoSize = true;
            labelPrixAchatTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPrixAchatTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrixAchatTitre.Location = new Point(20, 64);
            labelPrixAchatTitre.Margin = new Padding(2, 0, 2, 0);
            labelPrixAchatTitre.Name = "labelPrixAchatTitre";
            labelPrixAchatTitre.Size = new Size(118, 23);
            labelPrixAchatTitre.TabIndex = 1;
            labelPrixAchatTitre.Text = "Prix d'Achat :";
            // 
            // labelPrixAchat
            // 
            labelPrixAchat.AutoSize = true;
            labelPrixAchat.Font = new Font("Segoe UI", 10F);
            labelPrixAchat.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrixAchat.Location = new Point(136, 64);
            labelPrixAchat.Margin = new Padding(2, 0, 2, 0);
            labelPrixAchat.Name = "labelPrixAchat";
            labelPrixAchat.Size = new Size(70, 23);
            labelPrixAchat.TabIndex = 2;
            labelPrixAchat.Text = "0.00 DH";
            // 
            // labelPrixVenteTitre
            // 
            labelPrixVenteTitre.AutoSize = true;
            labelPrixVenteTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPrixVenteTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrixVenteTitre.Location = new Point(336, 64);
            labelPrixVenteTitre.Margin = new Padding(2, 0, 2, 0);
            labelPrixVenteTitre.Name = "labelPrixVenteTitre";
            labelPrixVenteTitre.Size = new Size(126, 23);
            labelPrixVenteTitre.TabIndex = 3;
            labelPrixVenteTitre.Text = "Prix de Vente :";
            // 
            // labelPrixVente
            // 
            labelPrixVente.AutoSize = true;
            labelPrixVente.Font = new Font("Segoe UI", 10F);
            labelPrixVente.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrixVente.Location = new Point(460, 64);
            labelPrixVente.Margin = new Padding(2, 0, 2, 0);
            labelPrixVente.Name = "labelPrixVente";
            labelPrixVente.Size = new Size(70, 23);
            labelPrixVente.TabIndex = 4;
            labelPrixVente.Text = "0.00 DH";
            // 
            // panelFournisseur
            // 
            panelFournisseur.BackColor = Color.White;
            panelFournisseur.Controls.Add(labelFournisseurTitre);
            panelFournisseur.Controls.Add(labelNomEntrepriseTitre);
            panelFournisseur.Controls.Add(labelNomEntreprise);
            panelFournisseur.Controls.Add(labelTelephoneTitre);
            panelFournisseur.Controls.Add(labelTelephone);
            panelFournisseur.Location = new Point(0, 540);
            panelFournisseur.Margin = new Padding(2, 2, 2, 2);
            panelFournisseur.Name = "panelFournisseur";
            panelFournisseur.Padding = new Padding(20, 20, 20, 20);
            panelFournisseur.Size = new Size(672, 132);
            panelFournisseur.TabIndex = 3;
            // 
            // labelFournisseurTitre
            // 
            labelFournisseurTitre.AutoSize = true;
            labelFournisseurTitre.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelFournisseurTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelFournisseurTitre.Location = new Point(20, 20);
            labelFournisseurTitre.Margin = new Padding(2, 0, 2, 0);
            labelFournisseurTitre.Name = "labelFournisseurTitre";
            labelFournisseurTitre.Size = new Size(169, 30);
            labelFournisseurTitre.TabIndex = 0;
            labelFournisseurTitre.Text = "👥 Fournisseur";
            // 
            // labelNomEntrepriseTitre
            // 
            labelNomEntrepriseTitre.AutoSize = true;
            labelNomEntrepriseTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelNomEntrepriseTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelNomEntrepriseTitre.Location = new Point(20, 64);
            labelNomEntrepriseTitre.Margin = new Padding(2, 0, 2, 0);
            labelNomEntrepriseTitre.Name = "labelNomEntrepriseTitre";
            labelNomEntrepriseTitre.Size = new Size(101, 23);
            labelNomEntrepriseTitre.TabIndex = 1;
            labelNomEntrepriseTitre.Text = "Entreprise :";
            // 
            // labelNomEntreprise
            // 
            labelNomEntreprise.AutoSize = true;
            labelNomEntreprise.Font = new Font("Segoe UI", 10F);
            labelNomEntreprise.ForeColor = Color.FromArgb(34, 62, 91);
            labelNomEntreprise.Location = new Point(120, 64);
            labelNomEntreprise.Margin = new Padding(2, 0, 2, 0);
            labelNomEntreprise.Name = "labelNomEntreprise";
            labelNomEntreprise.Size = new Size(161, 23);
            labelNomEntreprise.TabIndex = 2;
            labelNomEntreprise.Text = "Nom de l'entreprise";
            // 
            // labelTelephoneTitre
            // 
            labelTelephoneTitre.AutoSize = true;
            labelTelephoneTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTelephoneTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelTelephoneTitre.Location = new Point(20, 96);
            labelTelephoneTitre.Margin = new Padding(2, 0, 2, 0);
            labelTelephoneTitre.Name = "labelTelephoneTitre";
            labelTelephoneTitre.Size = new Size(101, 23);
            labelTelephoneTitre.TabIndex = 3;
            labelTelephoneTitre.Text = "Téléphone :";
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Font = new Font("Segoe UI", 10F);
            labelTelephone.ForeColor = Color.FromArgb(34, 62, 91);
            labelTelephone.Location = new Point(121, 96);
            labelTelephone.Margin = new Padding(2, 0, 2, 0);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(133, 23);
            labelTelephone.TabIndex = 4;
            labelTelephone.Text = "+212 6XX XX XX";
            // 
            // FormDetailsMedicament
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 211);
            ClientSize = new Size(1120, 720);
            Controls.Add(panelPrincipal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDetailsMedicament";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Détails du Médicament";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelGauche.ResumeLayout(false);
            panelGauche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMedicament).EndInit();
            panelDroite.ResumeLayout(false);
            panelInfosGenerales.ResumeLayout(false);
            panelInfosGenerales.PerformLayout();
            panelStock.ResumeLayout(false);
            panelStock.PerformLayout();
            panelPrix.ResumeLayout(false);
            panelPrix.PerformLayout();
            panelFournisseur.ResumeLayout(false);
            panelFournisseur.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitre;
        private Panel panelPrincipal;
        private Panel panelGauche;
        private PictureBox pictureBoxMedicament;
        private Label labelReference;
        private Label labelNomMedicament;
        private Panel panelDroite;
        private Panel panelInfosGenerales;
        private Label labelInfosGeneralesTitre;
        private Label labelDescriptionTitre;
        private Label labelDescription;
        private Label labelCategorieTitre;
        private Label labelCategorie;
        private Label labelDateCreationTitre;
        private Label labelDateCreation;
        private Panel panelStock;
        private Label labelStockTitre;
        private Label labelQuantiteStockTitre;
        private Label labelQuantiteStock;
        private Label labelSeuilAlerteTitre;
        private Label labelSeuilAlerte;
        private Label labelDatePeremptionTitre;
        private Label labelDatePeremption;
        private Panel panelPrix;
        private Label labelPrixTitre;
        private Label labelPrixAchatTitre;
        private Label labelPrixAchat;
        private Label labelPrixVenteTitre;
        private Label labelPrixVente;
        private Panel panelFournisseur;
        private Label labelFournisseurTitre;
        private Label labelNomEntrepriseTitre;
        private Label labelNomEntreprise;
        private Label labelNomFournisseurTitre;
        private Label labelNomFournisseur;
        private Label labelTelephoneTitre;
        private Label labelTelephone;
    }
}