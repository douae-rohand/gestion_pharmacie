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
            SuspendLayout();
            // 
            // labelemail
            // 
            labelemail.AutoSize = true;
            labelemail.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelemail.ForeColor = Color.SaddleBrown;
            labelemail.Location = new Point(138, 126);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(95, 41);
            labelemail.TabIndex = 0;
            labelemail.Text = "Email";
            // 
            // textemail
            // 
            textemail.Location = new Point(433, 126);
            textemail.Name = "textemail";
            textemail.Size = new Size(249, 31);
            textemail.TabIndex = 1;
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelpassword.ForeColor = Color.SaddleBrown;
            labelpassword.Location = new Point(138, 191);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(205, 41);
            labelpassword.TabIndex = 2;
            labelpassword.Text = "Mot de passe";
            // 
            // textpassword
            // 
            textpassword.Location = new Point(433, 201);
            textpassword.Name = "textpassword";
            textpassword.Size = new Size(249, 31);
            textpassword.TabIndex = 3;
            textpassword.UseSystemPasswordChar = true;
            // 
            // buttonvalider
            // 
            buttonvalider.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonvalider.ForeColor = Color.SaddleBrown;
            buttonvalider.Location = new Point(320, 279);
            buttonvalider.Name = "buttonvalider";
            buttonvalider.Size = new Size(112, 38);
            buttonvalider.TabIndex = 4;
            buttonvalider.Text = "Valider";
            buttonvalider.UseVisualStyleBackColor = true;
            buttonvalider.Click += buttonvalider_Click;
            // 
            // labelmessage
            // 
            labelmessage.AutoSize = true;
            labelmessage.Location = new Point(256, 352);
            labelmessage.Name = "labelmessage";
            labelmessage.Size = new Size(0, 25);
            labelmessage.TabIndex = 5;
            // 
            // connexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelmessage);
            Controls.Add(buttonvalider);
            Controls.Add(textpassword);
            Controls.Add(labelpassword);
            Controls.Add(textemail);
            Controls.Add(labelemail);
            Name = "connexion";
            Text = "connexion";
            Load += connexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelemail;
        private TextBox textemail;
        private Label labelpassword;
        private TextBox textpassword;
        private Button buttonvalider;
        private Label labelmessage;
    }
}