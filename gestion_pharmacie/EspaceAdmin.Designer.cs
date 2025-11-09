namespace gestion_pharmacie
{
    partial class EspaceAdmin
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
            label1 = new Label();
            textrecherche = new TextBox();
            buttonrecherche = new Button();
            combocritere = new ComboBox();
            buttonajouter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(421, 41);
            label1.TabIndex = 1;
            label1.Text = "Bienvenu dans espace admin";
            // 
            // textrecherche
            // 
            textrecherche.Location = new Point(290, 92);
            textrecherche.Name = "textrecherche";
            textrecherche.Size = new Size(234, 31);
            textrecherche.TabIndex = 3;
            // 
            // buttonrecherche
            // 
            buttonrecherche.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonrecherche.ForeColor = Color.DarkSalmon;
            buttonrecherche.Location = new Point(565, 90);
            buttonrecherche.Name = "buttonrecherche";
            buttonrecherche.Size = new Size(130, 34);
            buttonrecherche.TabIndex = 4;
            buttonrecherche.Text = "Rechercher";
            buttonrecherche.UseCompatibleTextRendering = true;
            buttonrecherche.UseVisualStyleBackColor = true;
            // 
            // combocritere
            // 
            combocritere.FormattingEnabled = true;
            combocritere.Items.AddRange(new object[] { "Nom médicament", "Fournisseurs", "Référence", "Date de péremption" });
            combocritere.Location = new Point(69, 90);
            combocritere.Name = "combocritere";
            combocritere.Size = new Size(182, 33);
            combocritere.TabIndex = 5;
            combocritere.Text = "Caractéristiques";
            // 
            // buttonajouter
            // 
            buttonajouter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonajouter.ForeColor = Color.DarkSalmon;
            buttonajouter.Location = new Point(290, 139);
            buttonajouter.Name = "buttonajouter";
            buttonajouter.Size = new Size(234, 38);
            buttonajouter.TabIndex = 6;
            buttonajouter.Text = "Ajouter";
            buttonajouter.UseVisualStyleBackColor = true;
            // 
            // EspaceAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonajouter);
            Controls.Add(combocritere);
            Controls.Add(buttonrecherche);
            Controls.Add(textrecherche);
            Controls.Add(label1);
            Name = "EspaceAdmin";
            Text = "EspaceAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textrecherche;
        private Button buttonrecherche;
        private ComboBox combocritere;
        private Button buttonajouter;
    }
}