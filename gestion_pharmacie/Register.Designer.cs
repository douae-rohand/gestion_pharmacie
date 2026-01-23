namespace gestion_pharmacie
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonconn = new Button();
            labeltitre = new Label();
            labelmessage = new Label();
            buttonvalider = new Button();
            textprenom = new TextBox();
            labelprenom = new Label();
            textnom = new TextBox();
            labelnom = new Label();
            textpassword = new TextBox();
            label1 = new Label();
            textemail = new TextBox();
            label2 = new Label();
            texttele = new TextBox();
            labeltele = new Label();
            textcofirmer = new TextBox();
            labelconfermer = new Label();
            textadresse = new TextBox();
            labeladress = new Label();
            panelHeader = new Panel();
            labelSubtitle = new Label();
            panelForm = new Panel();
            panelLeft = new Panel();
            panelRight = new Panel();
            panelSidebar = new Panel();
            labelPharmacyName = new Label();
            labelWelcome = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // buttonconn
            // 
            buttonconn.BackColor = Color.FromArgb(233, 244, 238);
            buttonconn.Cursor = Cursors.Hand;
            buttonconn.FlatAppearance.BorderSize = 0;
            buttonconn.FlatStyle = FlatStyle.Flat;
            buttonconn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonconn.ForeColor = Color.FromArgb(34, 62, 91);
            buttonconn.Location = new Point(32, 225);
            buttonconn.Margin = new Padding(2, 2, 2, 2);
            buttonconn.Name = "buttonconn";
            buttonconn.Size = new Size(246, 38);
            buttonconn.TabIndex = 15;
            buttonconn.Text = "Déjà inscrit ? Connexion";
            buttonconn.UseVisualStyleBackColor = false;
            buttonconn.Click += buttonconn_Click;
            // 
            // labeltitre
            // 
            labeltitre.AutoSize = true;
            labeltitre.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            labeltitre.ForeColor = Color.FromArgb(34, 62, 91);
            labeltitre.Location = new Point(21, 20);
            labeltitre.Margin = new Padding(2, 0, 2, 0);
            labeltitre.Name = "labeltitre";
            labeltitre.Size = new Size(248, 60);
            labeltitre.TabIndex = 14;
            labeltitre.Text = "Inscription";
            // 
            // labelmessage
            // 
            labelmessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelmessage.ForeColor = Color.FromArgb(246, 145, 118);
            labelmessage.Location = new Point(14, 401);
            labelmessage.Margin = new Padding(2, 0, 2, 0);
            labelmessage.Name = "labelmessage";
            labelmessage.Size = new Size(640, 24);
            labelmessage.TabIndex = 13;
            labelmessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonvalider
            // 
            buttonvalider.BackColor = Color.FromArgb(246, 145, 118);
            buttonvalider.Cursor = Cursors.Hand;
            buttonvalider.FlatAppearance.BorderSize = 0;
            buttonvalider.FlatStyle = FlatStyle.Flat;
            buttonvalider.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonvalider.ForeColor = Color.White;
            buttonvalider.Location = new Point(32, 177);
            buttonvalider.Margin = new Padding(2, 2, 2, 2);
            buttonvalider.Name = "buttonvalider";
            buttonvalider.Size = new Size(246, 40);
            buttonvalider.TabIndex = 12;
            buttonvalider.Text = "S'inscrire";
            buttonvalider.UseVisualStyleBackColor = false;
            buttonvalider.Click += buttonvalider_Click;
            // 
            // textprenom
            // 
            textprenom.BackColor = Color.FromArgb(252, 248, 243);
            textprenom.BorderStyle = BorderStyle.None;
            textprenom.Font = new Font("Segoe UI", 10F);
            textprenom.ForeColor = Color.FromArgb(34, 62, 91);
            textprenom.Location = new Point(2, 89);
            textprenom.Margin = new Padding(2, 2, 2, 2);
            textprenom.Name = "textprenom";
            textprenom.PlaceholderText = "Votre prénom";
            textprenom.Size = new Size(299, 23);
            textprenom.TabIndex = 11;
            // 
            // labelprenom
            // 
            labelprenom.AutoSize = true;
            labelprenom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelprenom.ForeColor = Color.FromArgb(34, 62, 91);
            labelprenom.Location = new Point(1, 65);
            labelprenom.Margin = new Padding(2, 0, 2, 0);
            labelprenom.Name = "labelprenom";
            labelprenom.Size = new Size(72, 23);
            labelprenom.TabIndex = 10;
            labelprenom.Text = "Prénom";
            // 
            // textnom
            // 
            textnom.BackColor = Color.FromArgb(252, 248, 243);
            textnom.BorderStyle = BorderStyle.None;
            textnom.Font = new Font("Segoe UI", 10F);
            textnom.ForeColor = Color.FromArgb(34, 62, 91);
            textnom.Location = new Point(2, 25);
            textnom.Margin = new Padding(2, 2, 2, 2);
            textnom.Name = "textnom";
            textnom.PlaceholderText = "Votre nom";
            textnom.Size = new Size(299, 23);
            textnom.TabIndex = 9;
            // 
            // labelnom
            // 
            labelnom.AutoSize = true;
            labelnom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelnom.ForeColor = Color.FromArgb(34, 62, 91);
            labelnom.Location = new Point(1, 1);
            labelnom.Margin = new Padding(2, 0, 2, 0);
            labelnom.Name = "labelnom";
            labelnom.Size = new Size(49, 23);
            labelnom.TabIndex = 8;
            labelnom.Text = "Nom";
            // 
            // textpassword
            // 
            textpassword.BackColor = Color.FromArgb(252, 248, 243);
            textpassword.BorderStyle = BorderStyle.None;
            textpassword.Font = new Font("Segoe UI", 10F);
            textpassword.ForeColor = Color.FromArgb(34, 62, 91);
            textpassword.Location = new Point(2, 25);
            textpassword.Margin = new Padding(2, 2, 2, 2);
            textpassword.Name = "textpassword";
            textpassword.PlaceholderText = "••••••••";
            textpassword.Size = new Size(302, 23);
            textpassword.TabIndex = 19;
            textpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 62, 91);
            label1.Location = new Point(1, 1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 18;
            label1.Text = "Mot de passe";
            label1.Click += label1_Click;
            // 
            // textemail
            // 
            textemail.BackColor = Color.FromArgb(252, 248, 243);
            textemail.BorderStyle = BorderStyle.None;
            textemail.Font = new Font("Segoe UI", 10F);
            textemail.ForeColor = Color.FromArgb(34, 62, 91);
            textemail.Location = new Point(2, 153);
            textemail.Margin = new Padding(2, 2, 2, 2);
            textemail.Name = "textemail";
            textemail.PlaceholderText = "exemple@email.com";
            textemail.Size = new Size(299, 23);
            textemail.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(34, 62, 91);
            label2.Location = new Point(1, 129);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 16;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // texttele
            // 
            texttele.BackColor = Color.FromArgb(252, 248, 243);
            texttele.BorderStyle = BorderStyle.None;
            texttele.Font = new Font("Segoe UI", 10F);
            texttele.ForeColor = Color.FromArgb(34, 62, 91);
            texttele.Location = new Point(2, 217);
            texttele.Margin = new Padding(2, 2, 2, 2);
            texttele.Name = "texttele";
            texttele.PlaceholderText = "06XXXXXXXX";
            texttele.Size = new Size(299, 23);
            texttele.TabIndex = 21;
            // 
            // labeltele
            // 
            labeltele.AutoSize = true;
            labeltele.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labeltele.ForeColor = Color.FromArgb(34, 62, 91);
            labeltele.Location = new Point(1, 193);
            labeltele.Margin = new Padding(2, 0, 2, 0);
            labeltele.Name = "labeltele";
            labeltele.Size = new Size(91, 23);
            labeltele.TabIndex = 20;
            labeltele.Text = "Téléphone";
            // 
            // textcofirmer
            // 
            textcofirmer.BackColor = Color.FromArgb(252, 248, 243);
            textcofirmer.BorderStyle = BorderStyle.None;
            textcofirmer.Font = new Font("Segoe UI", 10F);
            textcofirmer.ForeColor = Color.FromArgb(34, 62, 91);
            textcofirmer.Location = new Point(2, 89);
            textcofirmer.Margin = new Padding(2, 2, 2, 2);
            textcofirmer.Name = "textcofirmer";
            textcofirmer.PlaceholderText = "••••••••";
            textcofirmer.Size = new Size(302, 23);
            textcofirmer.TabIndex = 23;
            textcofirmer.UseSystemPasswordChar = true;
            // 
            // labelconfermer
            // 
            labelconfermer.AutoSize = true;
            labelconfermer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelconfermer.ForeColor = Color.FromArgb(34, 62, 91);
            labelconfermer.Location = new Point(1, 65);
            labelconfermer.Margin = new Padding(2, 0, 2, 0);
            labelconfermer.Name = "labelconfermer";
            labelconfermer.Size = new Size(222, 23);
            labelconfermer.TabIndex = 22;
            labelconfermer.Text = "Confirmer le mot de passe";
            // 
            // textadresse
            // 
            textadresse.BackColor = Color.FromArgb(252, 248, 243);
            textadresse.BorderStyle = BorderStyle.None;
            textadresse.Font = new Font("Segoe UI", 10F);
            textadresse.ForeColor = Color.FromArgb(34, 62, 91);
            textadresse.Location = new Point(2, 278);
            textadresse.Margin = new Padding(2, 2, 2, 2);
            textadresse.Multiline = true;
            textadresse.Name = "textadresse";
            textadresse.PlaceholderText = "Votre adresse complète";
            textadresse.Size = new Size(299, 56);
            textadresse.TabIndex = 25;
            // 
            // labeladress
            // 
            labeladress.AutoSize = true;
            labeladress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labeladress.ForeColor = Color.FromArgb(34, 62, 91);
            labeladress.Location = new Point(1, 254);
            labeladress.Margin = new Padding(2, 0, 2, 0);
            labeladress.Name = "labeladress";
            labeladress.Size = new Size(72, 23);
            labeladress.TabIndex = 24;
            labeladress.Text = "Adresse";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(252, 248, 243);
            panelHeader.Controls.Add(labeltitre);
            panelHeader.Controls.Add(labelSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(256, 0);
            panelHeader.Margin = new Padding(2, 2, 2, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(704, 116);
            panelHeader.TabIndex = 30;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 10F);
            labelSubtitle.ForeColor = Color.FromArgb(34, 62, 91);
            labelSubtitle.Location = new Point(24, 76);
            labelSubtitle.Margin = new Padding(2, 0, 2, 0);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(294, 23);
            labelSubtitle.TabIndex = 15;
            labelSubtitle.Text = "Créez votre compte en quelques clics";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(panelLeft);
            panelForm.Controls.Add(panelRight);
            panelForm.Controls.Add(labelmessage);
            panelForm.Location = new Point(288, 140);
            panelForm.Margin = new Padding(2, 2, 2, 2);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(24, 24, 24, 24);
            panelForm.Size = new Size(662, 444);
            panelForm.TabIndex = 31;
            panelForm.Paint += panelForm_Paint;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(labelnom);
            panelLeft.Controls.Add(textnom);
            panelLeft.Controls.Add(labelprenom);
            panelLeft.Controls.Add(textprenom);
            panelLeft.Controls.Add(labeladress);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(textadresse);
            panelLeft.Controls.Add(textemail);
            panelLeft.Controls.Add(labeltele);
            panelLeft.Controls.Add(texttele);
            panelLeft.Location = new Point(24, 24);
            panelLeft.Margin = new Padding(2, 2, 2, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(304, 360);
            panelLeft.TabIndex = 32;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(label1);
            panelRight.Controls.Add(textpassword);
            panelRight.Controls.Add(buttonconn);
            panelRight.Controls.Add(buttonvalider);
            panelRight.Controls.Add(labelconfermer);
            panelRight.Controls.Add(textcofirmer);
            panelRight.Location = new Point(333, 24);
            panelRight.Margin = new Padding(2, 2, 2, 2);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(304, 360);
            panelRight.TabIndex = 33;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(233, 244, 238);
            panelSidebar.Controls.Add(labelPharmacyName);
            panelSidebar.Controls.Add(labelWelcome);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(2, 2, 2, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(256, 624);
            panelSidebar.TabIndex = 32;
            // 
            // labelPharmacyName
            // 
            labelPharmacyName.AutoSize = true;
            labelPharmacyName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelPharmacyName.ForeColor = Color.FromArgb(246, 145, 118);
            labelPharmacyName.Location = new Point(14, 279);
            labelPharmacyName.Margin = new Padding(2, 0, 2, 0);
            labelPharmacyName.Name = "labelPharmacyName";
            labelPharmacyName.Size = new Size(247, 41);
            labelPharmacyName.TabIndex = 1;
            labelPharmacyName.Text = "Rejoignier-Nous";
            labelPharmacyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.FromArgb(34, 62, 91);
            labelWelcome.Location = new Point(20, 239);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(233, 41);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "NOUVEAU ICI ?";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 231, 211);
            ClientSize = new Size(960, 624);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Inscription";
            Load += Register_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelForm;
        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelSidebar;
        private Button buttonconn;
        private Label labeltitre;
        private Label labelSubtitle;
        private Label labelmessage;
        private Button buttonvalider;
        private TextBox textprenom;
        private Label labelprenom;
        private TextBox textnom;
        private Label labelnom;
        private TextBox textpassword;
        private Label label1;
        private TextBox textemail;
        private Label label2;
        private TextBox texttele;
        private Label labeltele;
        private TextBox textcofirmer;
        private Label labelconfermer;
        private TextBox textadresse;
        private Label labeladress;
        private Label labelWelcome;
        private Label labelPharmacyName;
    }
}