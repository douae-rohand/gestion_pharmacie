namespace gestion_pharmacie
{
    partial class connexion
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
            labelemail = new Label();
            textemail = new TextBox();
            labelpassword = new Label();
            textpassword = new TextBox();
            buttonvalider = new Button();
            labelmessage = new Label();
            labeltitre = new Label();
            buttonRegister = new Button();
            panelHeader = new Panel();
            labelSubtitle = new Label();
            panelForm = new Panel();
            panelSidebar = new Panel();
            label2 = new Label();
            label1 = new Label();
            labelWelcome = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // labelemail
            // 
            labelemail.AutoSize = true;
            labelemail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelemail.ForeColor = Color.FromArgb(34, 62, 91);
            labelemail.Location = new Point(40, 30);
            labelemail.Margin = new Padding(2, 0, 2, 0);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(64, 28);
            labelemail.TabIndex = 0;
            labelemail.Text = "Email";
            // 
            // textemail
            // 
            textemail.BackColor = Color.FromArgb(252, 248, 243);
            textemail.BorderStyle = BorderStyle.None;
            textemail.Font = new Font("Segoe UI", 11F);
            textemail.ForeColor = Color.FromArgb(34, 62, 91);
            textemail.Location = new Point(40, 65);
            textemail.Margin = new Padding(2);
            textemail.Name = "textemail";
            textemail.PlaceholderText = "votre@email.com";
            textemail.Size = new Size(380, 30);
            textemail.TabIndex = 1;
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelpassword.ForeColor = Color.FromArgb(34, 62, 91);
            labelpassword.Location = new Point(40, 125);
            labelpassword.Margin = new Padding(2, 0, 2, 0);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(138, 28);
            labelpassword.TabIndex = 2;
            labelpassword.Text = "Mot de passe";
            // 
            // textpassword
            // 
            textpassword.BackColor = Color.FromArgb(252, 248, 243);
            textpassword.BorderStyle = BorderStyle.None;
            textpassword.Font = new Font("Segoe UI", 11F);
            textpassword.ForeColor = Color.FromArgb(34, 62, 91);
            textpassword.Location = new Point(40, 160);
            textpassword.Margin = new Padding(2);
            textpassword.Name = "textpassword";
            textpassword.PlaceholderText = "••••••••";
            textpassword.Size = new Size(380, 30);
            textpassword.TabIndex = 3;
            textpassword.UseSystemPasswordChar = true;
            // 
            // buttonvalider
            // 
            buttonvalider.BackColor = Color.FromArgb(246, 145, 118);
            buttonvalider.Cursor = Cursors.Hand;
            buttonvalider.FlatAppearance.BorderSize = 0;
            buttonvalider.FlatStyle = FlatStyle.Flat;
            buttonvalider.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonvalider.ForeColor = Color.White;
            buttonvalider.Location = new Point(40, 225);
            buttonvalider.Margin = new Padding(2);
            buttonvalider.Name = "buttonvalider";
            buttonvalider.Size = new Size(380, 50);
            buttonvalider.TabIndex = 4;
            buttonvalider.Text = "Se connecter";
            buttonvalider.UseVisualStyleBackColor = false;
            buttonvalider.Click += buttonvalider_Click;
            // 
            // labelmessage
            // 
            labelmessage.AutoSize = true;
            labelmessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelmessage.ForeColor = Color.FromArgb(246, 145, 118);
            labelmessage.Location = new Point(53, 376);
            labelmessage.Margin = new Padding(2, 0, 2, 0);
            labelmessage.Name = "labelmessage";
            labelmessage.Size = new Size(0, 25);
            labelmessage.TabIndex = 5;
            labelmessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labeltitre
            // 
            labeltitre.AutoSize = true;
            labeltitre.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            labeltitre.ForeColor = Color.FromArgb(34, 62, 91);
            labeltitre.Location = new Point(22, 25);
            labeltitre.Margin = new Padding(2, 0, 2, 0);
            labeltitre.Name = "labeltitre";
            labeltitre.Size = new Size(291, 70);
            labeltitre.TabIndex = 6;
            labeltitre.Text = "Connexion";
            labeltitre.Click += labeltitre_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(233, 244, 238);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.FromArgb(34, 62, 91);
            buttonRegister.Location = new Point(40, 290);
            buttonRegister.Margin = new Padding(2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(380, 48);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Créer un compte";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(252, 248, 243);
            panelHeader.Controls.Add(labeltitre);
            panelHeader.Controls.Add(labelSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(320, 0);
            panelHeader.Margin = new Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(680, 145);
            panelHeader.TabIndex = 8;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 10F);
            labelSubtitle.ForeColor = Color.FromArgb(34, 62, 91);
            labelSubtitle.Location = new Point(30, 95);
            labelSubtitle.Margin = new Padding(2, 0, 2, 0);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(311, 28);
            labelSubtitle.TabIndex = 8;
            labelSubtitle.Text = "Accédez à votre espace de gestion";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(labelemail);
            panelForm.Controls.Add(textemail);
            panelForm.Controls.Add(labelpassword);
            panelForm.Controls.Add(textpassword);
            panelForm.Controls.Add(buttonvalider);
            panelForm.Controls.Add(buttonRegister);
            panelForm.Controls.Add(labelmessage);
            panelForm.Location = new Point(414, 201);
            panelForm.Margin = new Padding(2);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(480, 431);
            panelForm.TabIndex = 9;
            panelForm.Paint += panelForm_Paint;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(233, 244, 238);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(labelWelcome);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(320, 700);
            panelSidebar.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(34, 62, 91);
            label2.Location = new Point(63, 351);
            label2.Name = "label2";
            label2.Size = new Size(162, 54);
            label2.TabIndex = 2;
            label2.Text = "ESPACE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 62, 91);
            label1.Location = new Point(17, 305);
            label1.Name = "label1";
            label1.Size = new Size(281, 54);
            label1.TabIndex = 1;
            label1.Text = "DANS VOTRE ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.FromArgb(34, 62, 91);
            labelWelcome.Location = new Point(29, 259);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(256, 54);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "BIENVENUE ";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            labelWelcome.Click += labelWelcome_Click;
            // 
            // connexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 211);
            ClientSize = new Size(1000, 700);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Connexion";
            Load += connexion_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelForm;
        private Panel panelSidebar;
        private Label labelemail;
        private TextBox textemail;
        private Label labelpassword;
        private TextBox textpassword;
        private Button buttonvalider;
        private Label labelmessage;
        private Label labeltitre;
        private Label labelSubtitle;
        private Button buttonRegister;
        private Label labelWelcome;
        private Label label2;
        private Label label1;
    }
}