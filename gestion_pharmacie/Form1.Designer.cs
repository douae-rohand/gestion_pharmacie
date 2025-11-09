namespace gestion_pharmacie
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.NumericUpDown numPrix;
        private System.Windows.Forms.Label lblQuantiteStock;
        private System.Windows.Forms.NumericUpDown numQuantiteStock;
        private System.Windows.Forms.Label lblSeuilAlerte;
        private System.Windows.Forms.NumericUpDown numSeuilAlerte;
        private System.Windows.Forms.Label lblDatePeremption;
        private System.Windows.Forms.DateTimePicker dtpDatePeremption;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.TextBox txtFournisseur;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblAvertissement;
        private System.Windows.Forms.Label lblAvertissementStock;
        private System.Windows.Forms.GroupBox grpInformations;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Panel panelBoutons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpInformations = new System.Windows.Forms.GroupBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.txtFournisseur = new System.Windows.Forms.TextBox();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.numPrix = new System.Windows.Forms.NumericUpDown();
            this.lblQuantiteStock = new System.Windows.Forms.Label();
            this.numQuantiteStock = new System.Windows.Forms.NumericUpDown();
            this.lblSeuilAlerte = new System.Windows.Forms.Label();
            this.numSeuilAlerte = new System.Windows.Forms.NumericUpDown();
            this.lblDatePeremption = new System.Windows.Forms.Label();
            this.dtpDatePeremption = new System.Windows.Forms.DateTimePicker();
            this.lblAvertissement = new System.Windows.Forms.Label();
            this.lblAvertissementStock = new System.Windows.Forms.Label();
            this.panelBoutons = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpInformations.SuspendLayout();
            this.grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantiteStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeuilAlerte)).BeginInit();
            this.panelBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            //this.SuspendLayout();

            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitre.Location = new System.Drawing.Point(20, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(240, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Nouveau Médicament";

            // 
            // grpInformations
            // 
            this.grpInformations.Controls.Add(this.lblReference);
            this.grpInformations.Controls.Add(this.txtReference);
            this.grpInformations.Controls.Add(this.lblNom);
            this.grpInformations.Controls.Add(this.txtNom);
            this.grpInformations.Controls.Add(this.lblDescription);
            this.grpInformations.Controls.Add(this.txtDescription);
            this.grpInformations.Controls.Add(this.lblCategorie);
            this.grpInformations.Controls.Add(this.txtCategorie);
            this.grpInformations.Controls.Add(this.lblFournisseur);
            this.grpInformations.Controls.Add(this.txtFournisseur);
            this.grpInformations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInformations.Location = new System.Drawing.Point(20, 70);
            this.grpInformations.Name = "grpInformations";
            this.grpInformations.Size = new System.Drawing.Size(560, 280);
            this.grpInformations.TabIndex = 1;
            this.grpInformations.TabStop = false;
            this.grpInformations.Text = "Informations Générales";

            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReference.Location = new System.Drawing.Point(20, 35);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(87, 19);
            this.lblReference.TabIndex = 0;
            this.lblReference.Text = "Référence *:";

            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReference.Location = new System.Drawing.Point(150, 32);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(380, 25);
            this.txtReference.TabIndex = 1;
            this.txtReference.PlaceholderText = "Ex: MED001";

            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNom.Location = new System.Drawing.Point(20, 75);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(52, 19);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom *:";

            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.Location = new System.Drawing.Point(150, 72);
            this.txtNom.MaxLength = 100;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(380, 25);
            this.txtNom.TabIndex = 3;
            this.txtNom.PlaceholderText = "Ex: Paracétamol 500mg";

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(20, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 19);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";

            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(150, 112);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(380, 60);
            this.txtDescription.TabIndex = 5;

            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategorie.Location = new System.Drawing.Point(20, 185);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(73, 19);
            this.lblCategorie.TabIndex = 6;
            this.lblCategorie.Text = "Catégorie:";

            // 
            // txtCategorie
            // 
            this.txtCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategorie.Location = new System.Drawing.Point(150, 182);
            this.txtCategorie.MaxLength = 50;
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(380, 25);
            this.txtCategorie.TabIndex = 7;
            this.txtCategorie.PlaceholderText = "Ex: Antalgique";

            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFournisseur.Location = new System.Drawing.Point(20, 225);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(83, 19);
            this.lblFournisseur.TabIndex = 8;
            this.lblFournisseur.Text = "Fournisseur:";

            // 
            // txtFournisseur
            // 
            this.txtFournisseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFournisseur.Location = new System.Drawing.Point(150, 222);
            this.txtFournisseur.MaxLength = 100;
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(380, 25);
            this.txtFournisseur.TabIndex = 9;
            this.txtFournisseur.PlaceholderText = "Ex: PharmaCorp";

            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.lblPrix);
            this.grpStock.Controls.Add(this.numPrix);
            this.grpStock.Controls.Add(this.lblQuantiteStock);
            this.grpStock.Controls.Add(this.numQuantiteStock);
            this.grpStock.Controls.Add(this.lblSeuilAlerte);
            this.grpStock.Controls.Add(this.numSeuilAlerte);
            this.grpStock.Controls.Add(this.lblDatePeremption);
            this.grpStock.Controls.Add(this.dtpDatePeremption);
            this.grpStock.Controls.Add(this.lblAvertissement);
            this.grpStock.Controls.Add(this.lblAvertissementStock);
            this.grpStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStock.Location = new System.Drawing.Point(20, 360);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(560, 240);
            this.grpStock.TabIndex = 2;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Stock et Prix";

            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrix.Location = new System.Drawing.Point(20, 35);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(72, 19);
            this.lblPrix.TabIndex = 0;
            this.lblPrix.Text = "Prix (DH) *:";

            // 
            // numPrix
            // 
            this.numPrix.DecimalPlaces = 2;
            this.numPrix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPrix.Location = new System.Drawing.Point(200, 33);
            this.numPrix.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numPrix.Name = "numPrix";
            this.numPrix.Size = new System.Drawing.Size(150, 25);
            this.numPrix.TabIndex = 1;

            // 
            // lblQuantiteStock
            // 
            this.lblQuantiteStock.AutoSize = true;
            this.lblQuantiteStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantiteStock.Location = new System.Drawing.Point(20, 75);
            this.lblQuantiteStock.Name = "lblQuantiteStock";
            this.lblQuantiteStock.Size = new System.Drawing.Size(126, 19);
            this.lblQuantiteStock.TabIndex = 2;
            this.lblQuantiteStock.Text = "Quantité en stock:";

            // 
            // numQuantiteStock
            // 
            this.numQuantiteStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numQuantiteStock.Location = new System.Drawing.Point(200, 73);
            this.numQuantiteStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numQuantiteStock.Name = "numQuantiteStock";
            this.numQuantiteStock.Size = new System.Drawing.Size(150, 25);
            this.numQuantiteStock.TabIndex = 3;

            // 
            // lblSeuilAlerte
            // 
            this.lblSeuilAlerte.AutoSize = true;
            this.lblSeuilAlerte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSeuilAlerte.Location = new System.Drawing.Point(20, 115);
            this.lblSeuilAlerte.Name = "lblSeuilAlerte";
            this.lblSeuilAlerte.Size = new System.Drawing.Size(98, 19);
            this.lblSeuilAlerte.TabIndex = 4;
            this.lblSeuilAlerte.Text = "Seuil d'alerte:";

            // 
            // numSeuilAlerte
            // 
            this.numSeuilAlerte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSeuilAlerte.Location = new System.Drawing.Point(200, 113);
            this.numSeuilAlerte.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numSeuilAlerte.Name = "numSeuilAlerte";
            this.numSeuilAlerte.Size = new System.Drawing.Size(150, 25);
            this.numSeuilAlerte.TabIndex = 5;
            this.numSeuilAlerte.Value = new decimal(new int[] { 10, 0, 0, 0 });

            // 
            // lblDatePeremption
            // 
            this.lblDatePeremption.AutoSize = true;
            this.lblDatePeremption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDatePeremption.Location = new System.Drawing.Point(20, 155);
            this.lblDatePeremption.Name = "lblDatePeremption";
            this.lblDatePeremption.Size = new System.Drawing.Size(146, 19);
            this.lblDatePeremption.TabIndex = 6;
            this.lblDatePeremption.Text = "Date de péremption *:";

            // 
            // dtpDatePeremption
            // 
            this.dtpDatePeremption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDatePeremption.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePeremption.Location = new System.Drawing.Point(200, 153);
            this.dtpDatePeremption.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpDatePeremption.Name = "dtpDatePeremption";
            this.dtpDatePeremption.Size = new System.Drawing.Size(150, 25);
            this.dtpDatePeremption.TabIndex = 7;

            // 
            // lblAvertissement
            // 
            this.lblAvertissement.AutoSize = true;
            this.lblAvertissement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvertissement.ForeColor = System.Drawing.Color.Orange;
            this.lblAvertissement.Location = new System.Drawing.Point(20, 190);
            this.lblAvertissement.Name = "lblAvertissement";
            this.lblAvertissement.Size = new System.Drawing.Size(300, 15);
            this.lblAvertissement.TabIndex = 8;
            this.lblAvertissement.Text = "⚠️ Date de péremption proche (moins de 3 mois)";
            this.lblAvertissement.Visible = false;

            // 
            // lblAvertissementStock
            // 
            this.lblAvertissementStock.AutoSize = true;
            this.lblAvertissementStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvertissementStock.ForeColor = System.Drawing.Color.Red;
            this.lblAvertissementStock.Location = new System.Drawing.Point(20, 210);
            this.lblAvertissementStock.Name = "lblAvertissementStock";
            this.lblAvertissementStock.Size = new System.Drawing.Size(350, 15);
            this.lblAvertissementStock.TabIndex = 9;
            this.lblAvertissementStock.Text = "⚠️ Quantité en stock inférieure ou égale au seuil d'alerte";
            this.lblAvertissementStock.Visible = false;

            // 
            // panelBoutons
            // 
            this.panelBoutons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBoutons.Controls.Add(this.btnEnregistrer);
            this.panelBoutons.Controls.Add(this.btnAnnuler);
            this.panelBoutons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoutons.Location = new System.Drawing.Point(0, 620);
            this.panelBoutons.Name = "panelBoutons";
            this.panelBoutons.Size = new System.Drawing.Size(600, 80);
            this.panelBoutons.TabIndex = 3;

            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(320, 20);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(130, 40);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "✓ Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;

            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(460, 20);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 40);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "✕ Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;

            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            // 
            // FormAjouterModifierMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.panelBoutons);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.grpInformations);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjouterModifierMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un Médicament";

            this.grpInformations.ResumeLayout(false);
            this.grpInformations.PerformLayout();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantiteStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeuilAlerte)).EndInit();
            this.panelBoutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
