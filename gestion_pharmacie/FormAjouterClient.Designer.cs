namespace gestion_pharmacie
{
    partial class FormAjouterClient
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
            panelButtons = new Panel();
            buttonAjouter = new Button();
            buttonAnnuler = new Button();
            groupBoxInfos = new GroupBox();
            labelCIN = new Label();
            textCIN = new TextBox();
            labelNom = new Label();
            textNom = new TextBox();
            labelPrenom = new Label();
            textPrenom = new TextBox();
            labelTelephone = new Label();
            textTelephone = new TextBox();
            labelAdresse = new Label();
            textAdresse = new TextBox();
            labelVille = new Label();
            textVille = new TextBox();
            labelCodePostal = new Label();
            textCodePostal = new TextBox();
            labelDateNaissance = new Label();
            dateTimePickerNaissance = new DateTimePicker();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            groupBoxInfos.SuspendLayout();
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
            panelHeader.Size = new Size(920, 100);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint_1;
            // 
            // labelSousTitre
            // 
            labelSousTitre.AutoSize = true;
            labelSousTitre.Font = new Font("Segoe UI", 10F);
            labelSousTitre.ForeColor = Color.FromArgb(233, 244, 238);
            labelSousTitre.Location = new Point(37, 68);
            labelSousTitre.Name = "labelSousTitre";
            labelSousTitre.Size = new Size(330, 28);
            labelSousTitre.TabIndex = 1;
            labelSousTitre.Text = "Enregistrer les informations du client";
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitre.ForeColor = Color.FromArgb(252, 248, 243);
            labelTitre.Location = new Point(29, 20);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(380, 54);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "👤 Nouveau Client";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(252, 248, 243);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(groupBoxInfos);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(920, 680);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Transparent;
            panelButtons.Controls.Add(buttonAjouter);
            panelButtons.Controls.Add(buttonAnnuler);
            panelButtons.Location = new Point(30, 570);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(860, 80);
            panelButtons.TabIndex = 1;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = Color.FromArgb(246, 145, 118);
            buttonAjouter.Cursor = Cursors.Hand;
            buttonAjouter.FlatAppearance.BorderSize = 0;
            buttonAjouter.FlatStyle = FlatStyle.Flat;
            buttonAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAjouter.ForeColor = Color.White;
            buttonAjouter.Location = new Point(220, 15);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(200, 55);
            buttonAjouter.TabIndex = 1;
            buttonAjouter.Text = "✓ Enregistrer";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.FromArgb(233, 244, 238);
            buttonAnnuler.Cursor = Cursors.Hand;
            buttonAnnuler.FlatAppearance.BorderSize = 0;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAnnuler.ForeColor = Color.FromArgb(34, 62, 91);
            buttonAnnuler.Location = new Point(440, 15);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(200, 55);
            buttonAnnuler.TabIndex = 2;
            buttonAnnuler.Text = "✕ Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // groupBoxInfos
            // 
            groupBoxInfos.BackColor = Color.White;
            groupBoxInfos.Controls.Add(labelCIN);
            groupBoxInfos.Controls.Add(textCIN);
            groupBoxInfos.Controls.Add(labelNom);
            groupBoxInfos.Controls.Add(textNom);
            groupBoxInfos.Controls.Add(labelPrenom);
            groupBoxInfos.Controls.Add(textPrenom);
            groupBoxInfos.Controls.Add(labelTelephone);
            groupBoxInfos.Controls.Add(textTelephone);
            groupBoxInfos.Controls.Add(labelAdresse);
            groupBoxInfos.Controls.Add(textAdresse);
            groupBoxInfos.Controls.Add(labelVille);
            groupBoxInfos.Controls.Add(textVille);
            groupBoxInfos.Controls.Add(labelCodePostal);
            groupBoxInfos.Controls.Add(textCodePostal);
            groupBoxInfos.Controls.Add(labelDateNaissance);
            groupBoxInfos.Controls.Add(dateTimePickerNaissance);
            groupBoxInfos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxInfos.ForeColor = Color.FromArgb(34, 62, 91);
            groupBoxInfos.Location = new Point(30, 30);
            groupBoxInfos.Name = "groupBoxInfos";
            groupBoxInfos.Padding = new Padding(25);
            groupBoxInfos.Size = new Size(860, 534);
            groupBoxInfos.TabIndex = 0;
            groupBoxInfos.TabStop = false;
            groupBoxInfos.Text = "📋 Informations Personnelles";
            groupBoxInfos.Enter += groupBoxInfos_Enter;
            // 
            // labelCIN
            // 
            labelCIN.AutoSize = true;
            labelCIN.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelCIN.ForeColor = Color.FromArgb(34, 62, 91);
            labelCIN.Location = new Point(35, 140);
            labelCIN.Name = "labelCIN";
            labelCIN.Size = new Size(45, 28);
            labelCIN.TabIndex = 18;
            labelCIN.Text = "CIN";
            // 
            // textCIN
            // 
            textCIN.BackColor = Color.FromArgb(252, 248, 243);
            textCIN.BorderStyle = BorderStyle.None;
            textCIN.Font = new Font("Segoe UI", 11F);
            textCIN.Location = new Point(35, 175);
            textCIN.Name = "textCIN";
            textCIN.PlaceholderText = "Ex: L123456";
            textCIN.Size = new Size(370, 30);
            textCIN.TabIndex = 19;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelNom.ForeColor = Color.FromArgb(34, 62, 91);
            labelNom.Location = new Point(35, 50);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(57, 28);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // textNom
            // 
            textNom.BackColor = Color.FromArgb(252, 248, 243);
            textNom.BorderStyle = BorderStyle.None;
            textNom.Font = new Font("Segoe UI", 11F);
            textNom.Location = new Point(35, 85);
            textNom.Name = "textNom";
            textNom.PlaceholderText = "Nom du client";
            textNom.Size = new Size(370, 30);
            textNom.TabIndex = 1;
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrenom.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrenom.Location = new Point(445, 50);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(84, 28);
            labelPrenom.TabIndex = 2;
            labelPrenom.Text = "Prénom";
            // 
            // textPrenom
            // 
            textPrenom.BackColor = Color.FromArgb(252, 248, 243);
            textPrenom.BorderStyle = BorderStyle.None;
            textPrenom.Font = new Font("Segoe UI", 11F);
            textPrenom.Location = new Point(445, 85);
            textPrenom.Name = "textPrenom";
            textPrenom.PlaceholderText = "Prénom du client";
            textPrenom.Size = new Size(370, 30);
            textPrenom.TabIndex = 3;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelTelephone.ForeColor = Color.FromArgb(34, 62, 91);
            labelTelephone.Location = new Point(445, 140);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(107, 28);
            labelTelephone.TabIndex = 6;
            labelTelephone.Text = "Téléphone";
            // 
            // textTelephone
            // 
            textTelephone.BackColor = Color.FromArgb(252, 248, 243);
            textTelephone.BorderStyle = BorderStyle.None;
            textTelephone.Font = new Font("Segoe UI", 11F);
            textTelephone.Location = new Point(445, 175);
            textTelephone.Name = "textTelephone";
            textTelephone.PlaceholderText = "06 XX XX XX XX";
            textTelephone.Size = new Size(370, 30);
            textTelephone.TabIndex = 7;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelAdresse.ForeColor = Color.FromArgb(34, 62, 91);
            labelAdresse.Location = new Point(35, 230);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(84, 28);
            labelAdresse.TabIndex = 8;
            labelAdresse.Text = "Adresse";
            // 
            // textAdresse
            // 
            textAdresse.BackColor = Color.FromArgb(252, 248, 243);
            textAdresse.BorderStyle = BorderStyle.None;
            textAdresse.Font = new Font("Segoe UI", 11F);
            textAdresse.Location = new Point(35, 265);
            textAdresse.Multiline = true;
            textAdresse.Name = "textAdresse";
            textAdresse.PlaceholderText = "Adresse complète";
            textAdresse.Size = new Size(780, 70);
            textAdresse.TabIndex = 9;
            // 
            // labelVille
            // 
            labelVille.AutoSize = true;
            labelVille.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelVille.ForeColor = Color.FromArgb(34, 62, 91);
            labelVille.Location = new Point(35, 360);
            labelVille.Name = "labelVille";
            labelVille.Size = new Size(51, 28);
            labelVille.TabIndex = 10;
            labelVille.Text = "Ville";
            // 
            // textVille
            // 
            textVille.BackColor = Color.FromArgb(252, 248, 243);
            textVille.BorderStyle = BorderStyle.None;
            textVille.Font = new Font("Segoe UI", 11F);
            textVille.Location = new Point(35, 395);
            textVille.Name = "textVille";
            textVille.PlaceholderText = "Ville";
            textVille.Size = new Size(370, 30);
            textVille.TabIndex = 11;
            // 
            // labelCodePostal
            // 
            labelCodePostal.AutoSize = true;
            labelCodePostal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelCodePostal.ForeColor = Color.FromArgb(34, 62, 91);
            labelCodePostal.Location = new Point(445, 360);
            labelCodePostal.Name = "labelCodePostal";
            labelCodePostal.Size = new Size(119, 28);
            labelCodePostal.TabIndex = 12;
            labelCodePostal.Text = "Code Postal";
            // 
            // textCodePostal
            // 
            textCodePostal.BackColor = Color.FromArgb(252, 248, 243);
            textCodePostal.BorderStyle = BorderStyle.None;
            textCodePostal.Font = new Font("Segoe UI", 11F);
            textCodePostal.Location = new Point(445, 395);
            textCodePostal.Name = "textCodePostal";
            textCodePostal.PlaceholderText = "Code postal";
            textCodePostal.Size = new Size(370, 30);
            textCodePostal.TabIndex = 13;
            // 
            // labelDateNaissance
            // 
            labelDateNaissance.AutoSize = true;
            labelDateNaissance.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDateNaissance.ForeColor = Color.FromArgb(34, 62, 91);
            labelDateNaissance.Location = new Point(35, 450);
            labelDateNaissance.Name = "labelDateNaissance";
            labelDateNaissance.Size = new Size(176, 28);
            labelDateNaissance.TabIndex = 14;
            labelDateNaissance.Text = "Date de naissance";
            // 
            // dateTimePickerNaissance
            // 
            dateTimePickerNaissance.CalendarMonthBackground = Color.FromArgb(252, 248, 243);
            dateTimePickerNaissance.Font = new Font("Segoe UI", 11F);
            dateTimePickerNaissance.Format = DateTimePickerFormat.Short;
            dateTimePickerNaissance.Location = new Point(35, 485);
            dateTimePickerNaissance.Name = "dateTimePickerNaissance";
            dateTimePickerNaissance.Size = new Size(370, 37);
            dateTimePickerNaissance.TabIndex = 15;
            // 
            // FormAjouterClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 243);
            ClientSize = new Size(920, 780);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAjouterClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Ajouter un Client";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            groupBoxInfos.ResumeLayout(false);
            groupBoxInfos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitre;
        private Label labelSousTitre;
        private Panel panelMain;
        private GroupBox groupBoxInfos;
        private Label labelNom;
        private TextBox textNom;
        private Label labelPrenom;
        private TextBox textPrenom;
        private Label labelTelephone;
        private TextBox textTelephone;
        private Label labelAdresse;
        private TextBox textAdresse;
        private Label labelVille;
        private TextBox textVille;
        private Label labelCodePostal;
        private TextBox textCodePostal;
        private Label labelDateNaissance;
        private DateTimePicker dateTimePickerNaissance;
        private Panel panelButtons;
        private Button buttonAjouter;
        private Button buttonAnnuler;
        private Label labelCIN;
        private TextBox textCIN;
    }
}