namespace gestion_pharmacie
{
    partial class FormFacture
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
            labelSousTitre = new Label();
            labelTitre = new Label();
            panelMain = new Panel();
            groupBoxInfosFacture = new GroupBox();
            labelDatePaiementValeur = new Label();
            labelDatePaiement = new Label();
            labelMontantValeur = new Label();
            labelMontant = new Label();
            labelDateFactureValeur = new Label();
            labelDateFacture = new Label();
            labelNumFactureValeur = new Label();
            labelNumFacture = new Label();
            groupBoxInfosCommande = new GroupBox();
            labelStatutCommandeValeur = new Label();
            labelStatutCommande = new Label();
            labelDateCommandeValeur = new Label();
            labelDateCommande = new Label();
            labelTelephoneValeur = new Label();
            labelTelephone = new Label();
            labelClientValeur = new Label();
            labelClient = new Label();
            groupBoxPaiement = new GroupBox();
            panelStatut = new Panel();
            comboStatut = new ComboBox();
            labelStatut = new Label();
            comboMode = new ComboBox();
            labelMode = new Label();
            panelButtons = new Panel();
            buttonFermer = new Button();
            buttonImprimer = new Button();
            buttonEnregistrer = new Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            groupBoxInfosFacture.SuspendLayout();
            groupBoxInfosCommande.SuspendLayout();
            groupBoxPaiement.SuspendLayout();
            panelStatut.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(34, 62, 91);
            panelHeader.Controls.Add(labelSousTitre);
            panelHeader.Controls.Add(labelTitre);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 100);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelSousTitre
            // 
            labelSousTitre.AutoSize = true;
            labelSousTitre.Font = new Font("Segoe UI", 10F);
            labelSousTitre.ForeColor = Color.FromArgb(233, 244, 238);
            labelSousTitre.Location = new Point(37, 68);
            labelSousTitre.Name = "labelSousTitre";
            labelSousTitre.Size = new Size(359, 28);
            labelSousTitre.TabIndex = 1;
            labelSousTitre.Text = "Gérer le paiement et imprimer la facture";
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitre.ForeColor = Color.FromArgb(252, 248, 243);
            labelTitre.Location = new Point(29, 20);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(383, 54);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "\U0001f9fe Gestion Facture";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(252, 248, 243);
            panelMain.Controls.Add(groupBoxInfosFacture);
            panelMain.Controls.Add(groupBoxInfosCommande);
            panelMain.Controls.Add(groupBoxPaiement);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(900, 580);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // groupBoxInfosFacture
            // 
            groupBoxInfosFacture.BackColor = Color.White;
            groupBoxInfosFacture.Controls.Add(labelDatePaiementValeur);
            groupBoxInfosFacture.Controls.Add(labelDatePaiement);
            groupBoxInfosFacture.Controls.Add(labelMontantValeur);
            groupBoxInfosFacture.Controls.Add(labelMontant);
            groupBoxInfosFacture.Controls.Add(labelDateFactureValeur);
            groupBoxInfosFacture.Controls.Add(labelDateFacture);
            groupBoxInfosFacture.Controls.Add(labelNumFactureValeur);
            groupBoxInfosFacture.Controls.Add(labelNumFacture);
            groupBoxInfosFacture.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxInfosFacture.ForeColor = Color.FromArgb(34, 62, 91);
            groupBoxInfosFacture.Location = new Point(30, 20);
            groupBoxInfosFacture.Name = "groupBoxInfosFacture";
            groupBoxInfosFacture.Padding = new Padding(20);
            groupBoxInfosFacture.Size = new Size(840, 150);
            groupBoxInfosFacture.TabIndex = 0;
            groupBoxInfosFacture.TabStop = false;
            groupBoxInfosFacture.Text = "📄 Informations Facture";
            // 
            // labelDatePaiementValeur
            // 
            labelDatePaiementValeur.Font = new Font("Segoe UI", 10F);
            labelDatePaiementValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelDatePaiementValeur.Location = new Point(600, 100);
            labelDatePaiementValeur.Name = "labelDatePaiementValeur";
            labelDatePaiementValeur.Size = new Size(220, 25);
            labelDatePaiementValeur.TabIndex = 7;
            labelDatePaiementValeur.Text = "-";
            // 
            // labelDatePaiement
            // 
            labelDatePaiement.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDatePaiement.ForeColor = Color.FromArgb(34, 62, 91);
            labelDatePaiement.Location = new Point(430, 100);
            labelDatePaiement.Name = "labelDatePaiement";
            labelDatePaiement.Size = new Size(160, 25);
            labelDatePaiement.TabIndex = 6;
            labelDatePaiement.Text = "Date Paiement:";
            // 
            // labelMontantValeur
            // 
            labelMontantValeur.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelMontantValeur.ForeColor = Color.FromArgb(246, 145, 118);
            labelMontantValeur.Location = new Point(600, 50);
            labelMontantValeur.Name = "labelMontantValeur";
            labelMontantValeur.Size = new Size(220, 30);
            labelMontantValeur.TabIndex = 5;
            labelMontantValeur.Text = "0.00 DH";
            // 
            // labelMontant
            // 
            labelMontant.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelMontant.ForeColor = Color.FromArgb(34, 62, 91);
            labelMontant.Location = new Point(430, 50);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(160, 25);
            labelMontant.TabIndex = 4;
            labelMontant.Text = "💰 Montant:";
            // 
            // labelDateFactureValeur
            // 
            labelDateFactureValeur.Font = new Font("Segoe UI", 10F);
            labelDateFactureValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelDateFactureValeur.Location = new Point(220, 100);
            labelDateFactureValeur.Name = "labelDateFactureValeur";
            labelDateFactureValeur.Size = new Size(200, 25);
            labelDateFactureValeur.TabIndex = 3;
            labelDateFactureValeur.Text = "-";
            // 
            // labelDateFacture
            // 
            labelDateFacture.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDateFacture.ForeColor = Color.FromArgb(34, 62, 91);
            labelDateFacture.Location = new Point(20, 100);
            labelDateFacture.Name = "labelDateFacture";
            labelDateFacture.Size = new Size(190, 25);
            labelDateFacture.TabIndex = 2;
            labelDateFacture.Text = "📅 Date Facture:";
            // 
            // labelNumFactureValeur
            // 
            labelNumFactureValeur.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNumFactureValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelNumFactureValeur.Location = new Point(220, 50);
            labelNumFactureValeur.Name = "labelNumFactureValeur";
            labelNumFactureValeur.Size = new Size(200, 30);
            labelNumFactureValeur.TabIndex = 1;
            labelNumFactureValeur.Text = "-";
            // 
            // labelNumFacture
            // 
            labelNumFacture.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelNumFacture.ForeColor = Color.FromArgb(34, 62, 91);
            labelNumFacture.Location = new Point(20, 50);
            labelNumFacture.Name = "labelNumFacture";
            labelNumFacture.Size = new Size(190, 25);
            labelNumFacture.TabIndex = 0;
            labelNumFacture.Text = "🔢 N° Facture:";
            // 
            // groupBoxInfosCommande
            // 
            groupBoxInfosCommande.BackColor = Color.White;
            groupBoxInfosCommande.Controls.Add(labelStatutCommandeValeur);
            groupBoxInfosCommande.Controls.Add(labelStatutCommande);
            groupBoxInfosCommande.Controls.Add(labelDateCommandeValeur);
            groupBoxInfosCommande.Controls.Add(labelDateCommande);
            groupBoxInfosCommande.Controls.Add(labelTelephoneValeur);
            groupBoxInfosCommande.Controls.Add(labelTelephone);
            groupBoxInfosCommande.Controls.Add(labelClientValeur);
            groupBoxInfosCommande.Controls.Add(labelClient);
            groupBoxInfosCommande.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxInfosCommande.ForeColor = Color.FromArgb(34, 62, 91);
            groupBoxInfosCommande.Location = new Point(30, 185);
            groupBoxInfosCommande.Name = "groupBoxInfosCommande";
            groupBoxInfosCommande.Padding = new Padding(20);
            groupBoxInfosCommande.Size = new Size(840, 140);
            groupBoxInfosCommande.TabIndex = 1;
            groupBoxInfosCommande.TabStop = false;
            groupBoxInfosCommande.Text = "📦 Informations Commande";
            // 
            // labelStatutCommandeValeur
            // 
            labelStatutCommandeValeur.Font = new Font("Segoe UI", 10F);
            labelStatutCommandeValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatutCommandeValeur.Location = new Point(600, 90);
            labelStatutCommandeValeur.Name = "labelStatutCommandeValeur";
            labelStatutCommandeValeur.Size = new Size(220, 25);
            labelStatutCommandeValeur.TabIndex = 7;
            labelStatutCommandeValeur.Text = "-";
            // 
            // labelStatutCommande
            // 
            labelStatutCommande.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelStatutCommande.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatutCommande.Location = new Point(430, 90);
            labelStatutCommande.Name = "labelStatutCommande";
            labelStatutCommande.Size = new Size(160, 25);
            labelStatutCommande.TabIndex = 6;
            labelStatutCommande.Text = "📊 Statut:";
            // 
            // labelDateCommandeValeur
            // 
            labelDateCommandeValeur.Font = new Font("Segoe UI", 10F);
            labelDateCommandeValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelDateCommandeValeur.Location = new Point(600, 45);
            labelDateCommandeValeur.Name = "labelDateCommandeValeur";
            labelDateCommandeValeur.Size = new Size(220, 25);
            labelDateCommandeValeur.TabIndex = 5;
            labelDateCommandeValeur.Text = "-";
            // 
            // labelDateCommande
            // 
            labelDateCommande.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDateCommande.ForeColor = Color.FromArgb(34, 62, 91);
            labelDateCommande.Location = new Point(430, 45);
            labelDateCommande.Name = "labelDateCommande";
            labelDateCommande.Size = new Size(160, 25);
            labelDateCommande.TabIndex = 4;
            labelDateCommande.Text = "📅 Date:";
            // 
            // labelTelephoneValeur
            // 
            labelTelephoneValeur.Font = new Font("Segoe UI", 10F);
            labelTelephoneValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelTelephoneValeur.Location = new Point(190, 90);
            labelTelephoneValeur.Name = "labelTelephoneValeur";
            labelTelephoneValeur.Size = new Size(230, 25);
            labelTelephoneValeur.TabIndex = 3;
            labelTelephoneValeur.Text = "-";
            // 
            // labelTelephone
            // 
            labelTelephone.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelTelephone.ForeColor = Color.FromArgb(34, 62, 91);
            labelTelephone.Location = new Point(20, 90);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(160, 25);
            labelTelephone.TabIndex = 2;
            labelTelephone.Text = "📞 Téléphone:";
            // 
            // labelClientValeur
            // 
            labelClientValeur.Font = new Font("Segoe UI", 10F);
            labelClientValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelClientValeur.Location = new Point(190, 45);
            labelClientValeur.Name = "labelClientValeur";
            labelClientValeur.Size = new Size(230, 25);
            labelClientValeur.TabIndex = 1;
            labelClientValeur.Text = "-";
            // 
            // labelClient
            // 
            labelClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelClient.ForeColor = Color.FromArgb(34, 62, 91);
            labelClient.Location = new Point(20, 45);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(160, 25);
            labelClient.TabIndex = 0;
            labelClient.Text = "👤 Client:";
            // 
            // groupBoxPaiement
            // 
            groupBoxPaiement.BackColor = Color.White;
            groupBoxPaiement.Controls.Add(panelStatut);
            groupBoxPaiement.Controls.Add(comboMode);
            groupBoxPaiement.Controls.Add(labelMode);
            groupBoxPaiement.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxPaiement.ForeColor = Color.FromArgb(34, 62, 91);
            groupBoxPaiement.Location = new Point(30, 340);
            groupBoxPaiement.Name = "groupBoxPaiement";
            groupBoxPaiement.Padding = new Padding(20);
            groupBoxPaiement.Size = new Size(840, 120);
            groupBoxPaiement.TabIndex = 2;
            groupBoxPaiement.TabStop = false;
            groupBoxPaiement.Text = "💳 Gestion du Paiement";
            // 
            // panelStatut
            // 
            panelStatut.BackColor = Color.FromArgb(231, 76, 60);
            panelStatut.Controls.Add(comboStatut);
            panelStatut.Controls.Add(labelStatut);
            panelStatut.Location = new Point(20, 45);
            panelStatut.Name = "panelStatut";
            panelStatut.Size = new Size(380, 55);
            panelStatut.TabIndex = 4;
            // 
            // comboStatut
            // 
            comboStatut.BackColor = Color.White;
            comboStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatut.Font = new Font("Segoe UI", 10F);
            comboStatut.ForeColor = Color.FromArgb(34, 62, 91);
            comboStatut.FormattingEnabled = true;
            comboStatut.Items.AddRange(new object[] { "Non payée", "Payée", "Partiellement payée" });
            comboStatut.Location = new Point(160, 12);
            comboStatut.Name = "comboStatut";
            comboStatut.Size = new Size(210, 36);
            comboStatut.TabIndex = 1;
            comboStatut.SelectedIndexChanged += comboStatut_SelectedIndexChanged;
            // 
            // labelStatut
            // 
            labelStatut.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelStatut.ForeColor = Color.White;
            labelStatut.Location = new Point(10, 15);
            labelStatut.Name = "labelStatut";
            labelStatut.Size = new Size(140, 25);
            labelStatut.TabIndex = 0;
            labelStatut.Text = "📊 Statut:";
            // 
            // comboMode
            // 
            comboMode.BackColor = Color.FromArgb(252, 248, 243);
            comboMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMode.Font = new Font("Segoe UI", 10F);
            comboMode.ForeColor = Color.FromArgb(34, 62, 91);
            comboMode.FormattingEnabled = true;
            comboMode.Items.AddRange(new object[] { "Espèces", "Carte bancaire", "Chèque", "Virement" });
            comboMode.Location = new Point(600, 57);
            comboMode.Name = "comboMode";
            comboMode.Size = new Size(220, 36);
            comboMode.TabIndex = 3;
            // 
            // labelMode
            // 
            labelMode.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelMode.ForeColor = Color.FromArgb(34, 62, 91);
            labelMode.Location = new Point(430, 60);
            labelMode.Name = "labelMode";
            labelMode.Size = new Size(160, 25);
            labelMode.TabIndex = 2;
            labelMode.Text = "💵 Mode:";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(233, 244, 238);
            panelButtons.Controls.Add(buttonFermer);
            panelButtons.Controls.Add(buttonImprimer);
            panelButtons.Controls.Add(buttonEnregistrer);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 680);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(900, 100);
            panelButtons.TabIndex = 2;
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.FromArgb(149, 165, 166);
            buttonFermer.Cursor = Cursors.Hand;
            buttonFermer.FlatAppearance.BorderSize = 0;
            buttonFermer.FlatStyle = FlatStyle.Flat;
            buttonFermer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonFermer.ForeColor = Color.White;
            buttonFermer.Location = new Point(630, 25);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(220, 55);
            buttonFermer.TabIndex = 2;
            buttonFermer.Text = "❌ Fermer";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // buttonImprimer
            // 
            buttonImprimer.BackColor = Color.FromArgb(34, 62, 91);
            buttonImprimer.Cursor = Cursors.Hand;
            buttonImprimer.FlatAppearance.BorderSize = 0;
            buttonImprimer.FlatStyle = FlatStyle.Flat;
            buttonImprimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonImprimer.ForeColor = Color.White;
            buttonImprimer.Location = new Point(340, 25);
            buttonImprimer.Name = "buttonImprimer";
            buttonImprimer.Size = new Size(220, 55);
            buttonImprimer.TabIndex = 1;
            buttonImprimer.Text = "🖨️ Imprimer";
            buttonImprimer.UseVisualStyleBackColor = false;
            buttonImprimer.Click += buttonImprimer_Click;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.BackColor = Color.FromArgb(246, 145, 118);
            buttonEnregistrer.Cursor = Cursors.Hand;
            buttonEnregistrer.FlatAppearance.BorderSize = 0;
            buttonEnregistrer.FlatStyle = FlatStyle.Flat;
            buttonEnregistrer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEnregistrer.ForeColor = Color.White;
            buttonEnregistrer.Location = new Point(50, 25);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(220, 55);
            buttonEnregistrer.TabIndex = 0;
            buttonEnregistrer.Text = "💾 Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = false;
            buttonEnregistrer.Click += buttonEnregistrer_Click;
            // 
            // FormFacture
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 243);
            ClientSize = new Size(900, 780);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFacture";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion Pharmacie - Facture";
            Load += FormFacture_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            groupBoxInfosFacture.ResumeLayout(false);
            groupBoxInfosCommande.ResumeLayout(false);
            groupBoxPaiement.ResumeLayout(false);
            panelStatut.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitre;
        private Label labelSousTitre;
        private Panel panelMain;
        private GroupBox groupBoxInfosFacture;
        private Label labelNumFacture;
        private Label labelNumFactureValeur;
        private Label labelDateFacture;
        private Label labelDateFactureValeur;
        private Label labelMontant;
        private Label labelMontantValeur;
        private Label labelDatePaiement;
        private Label labelDatePaiementValeur;
        private GroupBox groupBoxInfosCommande;
        private Label labelClient;
        private Label labelClientValeur;
        private Label labelTelephone;
        private Label labelTelephoneValeur;
        private Label labelDateCommande;
        private Label labelDateCommandeValeur;
        private Label labelStatutCommande;
        private Label labelStatutCommandeValeur;
        private GroupBox groupBoxPaiement;
        private Label labelStatut;
        private ComboBox comboStatut;
        private Label labelMode;
        private ComboBox comboMode;
        private Panel panelStatut;
        private Panel panelButtons;
        private Button buttonEnregistrer;
        private Button buttonImprimer;
        private Button buttonFermer;
    }
}