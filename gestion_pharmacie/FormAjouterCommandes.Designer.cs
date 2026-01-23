namespace gestion_pharmacie
{
    partial class FormAjouterCommande
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            labelSousTitre = new Label();
            label1 = new Label();
            panelMain = new Panel();
            panel1 = new Panel();
            buttonannuler = new Button();
            buttonajouter = new Button();
            textMontantTotal = new TextBox();
            label3 = new Label();
            groupBoxLignes = new GroupBox();
            dataGridViewLignes = new DataGridView();
            groupBoxMedicaments = new GroupBox();
            buttonSupprimerLigne = new Button();
            buttonAjouterLigne = new Button();
            numericPrixUnitaire = new NumericUpDown();
            label9 = new Label();
            numericQuantite = new NumericUpDown();
            label8 = new Label();
            comboBoxMedicament = new ComboBox();
            label7 = new Label();
            groupBoxInfoCommande = new GroupBox();
            comboBoxStatut = new ComboBox();
            label6 = new Label();
            dateLivraison = new DateTimePicker();
            label5 = new Label();
            dateCommande = new DateTimePicker();
            label4 = new Label();
            comboBoxClient = new ComboBox();
            label2 = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxLignes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLignes).BeginInit();
            groupBoxMedicaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrixUnitaire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantite).BeginInit();
            groupBoxInfoCommande.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(34, 62, 91);
            panelHeader.Controls.Add(labelSousTitre);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1414, 125);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelSousTitre
            // 
            labelSousTitre.AutoSize = true;
            labelSousTitre.Font = new Font("Segoe UI", 10F);
            labelSousTitre.ForeColor = Color.FromArgb(233, 244, 238);
            labelSousTitre.Location = new Point(46, 85);
            labelSousTitre.Margin = new Padding(4, 0, 4, 0);
            labelSousTitre.Name = "labelSousTitre";
            labelSousTitre.Size = new Size(425, 28);
            labelSousTitre.TabIndex = 1;
            labelSousTitre.Text = "Créer une nouvelle commande de médicaments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(252, 248, 243);
            label1.Location = new Point(36, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(485, 54);
            label1.TabIndex = 0;
            label1.Text = "📦 Nouvelle Commande";
            label1.Click += label1_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(252, 248, 243);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(groupBoxLignes);
            panelMain.Controls.Add(groupBoxMedicaments);
            panelMain.Controls.Add(groupBoxInfoCommande);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 125);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(38);
            panelMain.Size = new Size(1414, 1034);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonannuler);
            panel1.Controls.Add(buttonajouter);
            panel1.Controls.Add(textMontantTotal);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(38, 900);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25);
            panel1.Size = new Size(1338, 112);
            panel1.TabIndex = 4;
            // 
            // buttonannuler
            // 
            buttonannuler.BackColor = Color.FromArgb(233, 244, 238);
            buttonannuler.Cursor = Cursors.Hand;
            buttonannuler.FlatAppearance.BorderSize = 0;
            buttonannuler.FlatStyle = FlatStyle.Flat;
            buttonannuler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonannuler.ForeColor = Color.FromArgb(34, 62, 91);
            buttonannuler.Location = new Point(938, 25);
            buttonannuler.Margin = new Padding(4);
            buttonannuler.Name = "buttonannuler";
            buttonannuler.Size = new Size(175, 62);
            buttonannuler.TabIndex = 1;
            buttonannuler.Text = "✕ Annuler";
            buttonannuler.UseVisualStyleBackColor = false;
            buttonannuler.Click += buttonannuler_Click;
            // 
            // buttonajouter
            // 
            buttonajouter.BackColor = Color.FromArgb(246, 145, 118);
            buttonajouter.Cursor = Cursors.Hand;
            buttonajouter.FlatAppearance.BorderSize = 0;
            buttonajouter.FlatStyle = FlatStyle.Flat;
            buttonajouter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonajouter.ForeColor = Color.White;
            buttonajouter.Location = new Point(1138, 25);
            buttonajouter.Margin = new Padding(4);
            buttonajouter.Name = "buttonajouter";
            buttonajouter.Size = new Size(175, 62);
            buttonajouter.TabIndex = 0;
            buttonajouter.Text = "✓ Enregistrer";
            buttonajouter.UseVisualStyleBackColor = false;
            buttonajouter.Click += buttonajouter_Click;
            // 
            // textMontantTotal
            // 
            textMontantTotal.BackColor = Color.FromArgb(252, 248, 243);
            textMontantTotal.BorderStyle = BorderStyle.None;
            textMontantTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            textMontantTotal.ForeColor = Color.FromArgb(34, 62, 91);
            textMontantTotal.Location = new Point(262, 35);
            textMontantTotal.Margin = new Padding(4);
            textMontantTotal.Name = "textMontantTotal";
            textMontantTotal.ReadOnly = true;
            textMontantTotal.Size = new Size(250, 43);
            textMontantTotal.TabIndex = 3;
            textMontantTotal.Text = "0.00 DH";
            textMontantTotal.TextAlign = HorizontalAlignment.Right;
            textMontantTotal.TextChanged += textMontantTotal_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(34, 62, 91);
            label3.Location = new Point(25, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 32);
            label3.TabIndex = 2;
            label3.Text = "💰 Montant Total :";
            // 
            // groupBoxLignes
            // 
            groupBoxLignes.BackColor = Color.White;
            groupBoxLignes.Controls.Add(dataGridViewLignes);
            groupBoxLignes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxLignes.ForeColor = Color.FromArgb(34, 62, 91);
            groupBoxLignes.Location = new Point(38, 588);
            groupBoxLignes.Margin = new Padding(4);
            groupBoxLignes.Name = "groupBoxLignes";
            groupBoxLignes.Padding = new Padding(25);
            groupBoxLignes.Size = new Size(1338, 288);
            groupBoxLignes.TabIndex = 3;
            groupBoxLignes.TabStop = false;
            groupBoxLignes.Text = "📋 Lignes de Commande";
            // 
            // dataGridViewLignes
            // 
            dataGridViewLignes.AllowUserToAddRows = false;
            dataGridViewLignes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLignes.BackgroundColor = Color.FromArgb(252, 248, 243);
            dataGridViewLignes.BorderStyle = BorderStyle.None;
            dataGridViewLignes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewLignes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewLignes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLignes.ColumnHeadersHeight = 45;
            dataGridViewLignes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.Padding = new Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(233, 244, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewLignes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLignes.Dock = DockStyle.Fill;
            dataGridViewLignes.EnableHeadersVisualStyles = false;
            dataGridViewLignes.GridColor = Color.FromArgb(233, 244, 238);
            dataGridViewLignes.Location = new Point(25, 55);
            dataGridViewLignes.Margin = new Padding(4);
            dataGridViewLignes.Name = "dataGridViewLignes";
            dataGridViewLignes.ReadOnly = true;
            dataGridViewLignes.RowHeadersVisible = false;
            dataGridViewLignes.RowHeadersWidth = 51;
            dataGridViewLignes.RowTemplate.Height = 40;
            dataGridViewLignes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLignes.Size = new Size(1288, 208);
            dataGridViewLignes.TabIndex = 0;
            // 
            // groupBoxMedicaments
            // 
            groupBoxMedicaments.BackColor = Color.White;
            groupBoxMedicaments.Controls.Add(buttonSupprimerLigne);
            groupBoxMedicaments.Controls.Add(buttonAjouterLigne);
            groupBoxMedicaments.Controls.Add(numericPrixUnitaire);
            groupBoxMedicaments.Controls.Add(label9);
            groupBoxMedicaments.Controls.Add(numericQuantite);
            groupBoxMedicaments.Controls.Add(label8);
            groupBoxMedicaments.Controls.Add(comboBoxMedicament);
            groupBoxMedicaments.Controls.Add(label7);
            groupBoxMedicaments.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxMedicaments.ForeColor = Color.FromArgb(34, 62, 91);
            groupBoxMedicaments.Location = new Point(38, 325);
            groupBoxMedicaments.Margin = new Padding(4);
            groupBoxMedicaments.Name = "groupBoxMedicaments";
            groupBoxMedicaments.Padding = new Padding(31);
            groupBoxMedicaments.Size = new Size(1338, 238);
            groupBoxMedicaments.TabIndex = 2;
            groupBoxMedicaments.TabStop = false;
            groupBoxMedicaments.Text = "💊 Ajouter des Médicaments";
            // 
            // buttonSupprimerLigne
            // 
            buttonSupprimerLigne.BackColor = Color.FromArgb(235, 203, 176);
            buttonSupprimerLigne.Cursor = Cursors.Hand;
            buttonSupprimerLigne.FlatAppearance.BorderSize = 0;
            buttonSupprimerLigne.FlatStyle = FlatStyle.Flat;
            buttonSupprimerLigne.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSupprimerLigne.ForeColor = Color.FromArgb(34, 62, 91);
            buttonSupprimerLigne.Location = new Point(1081, 150);
            buttonSupprimerLigne.Margin = new Padding(4);
            buttonSupprimerLigne.Name = "buttonSupprimerLigne";
            buttonSupprimerLigne.Size = new Size(225, 56);
            buttonSupprimerLigne.TabIndex = 7;
            buttonSupprimerLigne.Text = "🗑️ Supprimer ligne";
            buttonSupprimerLigne.UseVisualStyleBackColor = false;
            buttonSupprimerLigne.Click += buttonSupprimerLigne_Click;
            // 
            // buttonAjouterLigne
            // 
            buttonAjouterLigne.BackColor = Color.FromArgb(246, 145, 118);
            buttonAjouterLigne.Cursor = Cursors.Hand;
            buttonAjouterLigne.FlatAppearance.BorderSize = 0;
            buttonAjouterLigne.FlatStyle = FlatStyle.Flat;
            buttonAjouterLigne.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAjouterLigne.ForeColor = Color.White;
            buttonAjouterLigne.Location = new Point(1081, 75);
            buttonAjouterLigne.Margin = new Padding(4);
            buttonAjouterLigne.Name = "buttonAjouterLigne";
            buttonAjouterLigne.Size = new Size(225, 56);
            buttonAjouterLigne.TabIndex = 6;
            buttonAjouterLigne.Text = "➕ Ajouter à la liste";
            buttonAjouterLigne.UseVisualStyleBackColor = false;
            buttonAjouterLigne.Click += buttonAjouterLigne_Click;
            // 
            // numericPrixUnitaire
            // 
            numericPrixUnitaire.BackColor = Color.FromArgb(252, 248, 243);
            numericPrixUnitaire.BorderStyle = BorderStyle.None;
            numericPrixUnitaire.DecimalPlaces = 2;
            numericPrixUnitaire.Font = new Font("Segoe UI", 11F);
            numericPrixUnitaire.Location = new Point(725, 169);
            numericPrixUnitaire.Margin = new Padding(4);
            numericPrixUnitaire.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPrixUnitaire.Name = "numericPrixUnitaire";
            numericPrixUnitaire.Size = new Size(312, 33);
            numericPrixUnitaire.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(34, 62, 91);
            label9.Location = new Point(725, 125);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(132, 28);
            label9.TabIndex = 4;
            label9.Text = "Prix unitaire :";
            // 
            // numericQuantite
            // 
            numericQuantite.BackColor = Color.FromArgb(252, 248, 243);
            numericQuantite.BorderStyle = BorderStyle.None;
            numericQuantite.Font = new Font("Segoe UI", 11F);
            numericQuantite.Location = new Point(38, 169);
            numericQuantite.Margin = new Padding(4);
            numericQuantite.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericQuantite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantite.Name = "numericQuantite";
            numericQuantite.Size = new Size(650, 33);
            numericQuantite.TabIndex = 3;
            numericQuantite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(34, 62, 91);
            label8.Location = new Point(38, 125);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 2;
            label8.Text = "Quantité :";
            // 
            // comboBoxMedicament
            // 
            comboBoxMedicament.BackColor = Color.FromArgb(252, 248, 243);
            comboBoxMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMedicament.FlatStyle = FlatStyle.Flat;
            comboBoxMedicament.Font = new Font("Segoe UI", 11F);
            comboBoxMedicament.ForeColor = Color.FromArgb(34, 62, 91);
            comboBoxMedicament.FormattingEnabled = true;
            comboBoxMedicament.Location = new Point(38, 75);
            comboBoxMedicament.Margin = new Padding(4);
            comboBoxMedicament.Name = "comboBoxMedicament";
            comboBoxMedicament.Size = new Size(999, 38);
            comboBoxMedicament.TabIndex = 1;
            comboBoxMedicament.SelectedIndexChanged += comboBoxMedicament_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(34, 62, 91);
            label7.Location = new Point(38, 44);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 28);
            label7.TabIndex = 0;
            label7.Text = "Médicament :";
            // 
            // groupBoxInfoCommande
            // 
            groupBoxInfoCommande.BackColor = Color.White;
            groupBoxInfoCommande.Controls.Add(comboBoxStatut);
            groupBoxInfoCommande.Controls.Add(label6);
            groupBoxInfoCommande.Controls.Add(dateLivraison);
            groupBoxInfoCommande.Controls.Add(label5);
            groupBoxInfoCommande.Controls.Add(dateCommande);
            groupBoxInfoCommande.Controls.Add(label4);
            groupBoxInfoCommande.Controls.Add(comboBoxClient);
            groupBoxInfoCommande.Controls.Add(label2);
            groupBoxInfoCommande.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxInfoCommande.ForeColor = Color.FromArgb(34, 62, 91);
            groupBoxInfoCommande.Location = new Point(38, 38);
            groupBoxInfoCommande.Margin = new Padding(4);
            groupBoxInfoCommande.Name = "groupBoxInfoCommande";
            groupBoxInfoCommande.Padding = new Padding(31);
            groupBoxInfoCommande.Size = new Size(1338, 262);
            groupBoxInfoCommande.TabIndex = 1;
            groupBoxInfoCommande.TabStop = false;
            groupBoxInfoCommande.Text = "📋 Informations de la Commande";
            groupBoxInfoCommande.Enter += groupBoxInfoCommande_Enter;
            // 
            // comboBoxStatut
            // 
            comboBoxStatut.BackColor = Color.FromArgb(252, 248, 243);
            comboBoxStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatut.FlatStyle = FlatStyle.Flat;
            comboBoxStatut.Font = new Font("Segoe UI", 11F);
            comboBoxStatut.ForeColor = Color.FromArgb(34, 62, 91);
            comboBoxStatut.FormattingEnabled = true;
            comboBoxStatut.Location = new Point(712, 181);
            comboBoxStatut.Margin = new Padding(4);
            comboBoxStatut.Name = "comboBoxStatut";
            comboBoxStatut.Size = new Size(593, 38);
            comboBoxStatut.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(34, 62, 91);
            label6.Location = new Point(712, 138);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 6;
            label6.Text = "Statut :";
            // 
            // dateLivraison
            // 
            dateLivraison.CalendarMonthBackground = Color.FromArgb(252, 248, 243);
            dateLivraison.Font = new Font("Segoe UI", 11F);
            dateLivraison.Format = DateTimePickerFormat.Short;
            dateLivraison.Location = new Point(712, 75);
            dateLivraison.Margin = new Padding(4);
            dateLivraison.Name = "dateLivraison";
            dateLivraison.Size = new Size(593, 37);
            dateLivraison.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(34, 62, 91);
            label5.Location = new Point(712, 44);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 28);
            label5.TabIndex = 4;
            label5.Text = "Date livraison :";
            // 
            // dateCommande
            // 
            dateCommande.CalendarMonthBackground = Color.FromArgb(252, 248, 243);
            dateCommande.Font = new Font("Segoe UI", 11F);
            dateCommande.Format = DateTimePickerFormat.Short;
            dateCommande.Location = new Point(38, 181);
            dateCommande.Margin = new Padding(4);
            dateCommande.Name = "dateCommande";
            dateCommande.Size = new Size(649, 37);
            dateCommande.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(34, 62, 91);
            label4.Location = new Point(38, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 28);
            label4.TabIndex = 2;
            label4.Text = "Date commande :";
            // 
            // comboBoxClient
            // 
            comboBoxClient.BackColor = Color.FromArgb(252, 248, 243);
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.FlatStyle = FlatStyle.Flat;
            comboBoxClient.Font = new Font("Segoe UI", 11F);
            comboBoxClient.ForeColor = Color.FromArgb(34, 62, 91);
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(38, 75);
            comboBoxClient.Margin = new Padding(4);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(649, 38);
            comboBoxClient.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(34, 62, 91);
            label2.Location = new Point(38, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 0;
            label2.Text = "Client :";
            // 
            // FormAjouterCommande
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 243);
            ClientSize = new Size(1414, 1159);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAjouterCommande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Ajouter une Commande";
            Load += FormAjouterCommande_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxLignes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLignes).EndInit();
            groupBoxMedicaments.ResumeLayout(false);
            groupBoxMedicaments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrixUnitaire).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantite).EndInit();
            groupBoxInfoCommande.ResumeLayout(false);
            groupBoxInfoCommande.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Label labelSousTitre;
        private Panel panelMain;
        private GroupBox groupBoxInfoCommande;
        private ComboBox comboBoxClient;
        private Label label2;
        private DateTimePicker dateCommande;
        private Label label4;
        private DateTimePicker dateLivraison;
        private Label label5;
        private ComboBox comboBoxStatut;
        private Label label6;
        private GroupBox groupBoxMedicaments;
        private ComboBox comboBoxMedicament;
        private Label label7;
        private NumericUpDown numericQuantite;
        private Label label8;
        private NumericUpDown numericPrixUnitaire;
        private Label label9;
        private Button buttonAjouterLigne;
        private Button buttonSupprimerLigne;
        private GroupBox groupBoxLignes;
        private DataGridView dataGridViewLignes;
        private Panel panel1;
        private Button buttonannuler;
        private Button buttonajouter;
        private TextBox textMontantTotal;
        private Label label3;
    }
}