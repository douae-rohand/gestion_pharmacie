namespace gestion_pharmacie
{
    partial class FormAjouterMedicament
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
            groupinfo = new GroupBox();
            textpath = new TextBox();
            buttonajouter = new Button();
            picturemedicament = new PictureBox();
            comboBoxcategorie = new ComboBox();
            dateTimePicker = new DateTimePicker();
            comboBoxfornisseur = new ComboBox();
            textdescription = new TextBox();
            textreference = new TextBox();
            textnom = new TextBox();
            labelfournisseur = new Label();
            labelDatePeremption = new Label();
            labeldescription = new Label();
            label3 = new Label();
            labelcategorie = new Label();
            labelreference = new Label();
            groupBox1 = new GroupBox();
            labelPrixAchat = new Label();
            prixachat = new NumericUpDown();
            labelPrixVente = new Label();
            prixvente = new NumericUpDown();
            labelQuantiteStock = new Label();
            quantite = new NumericUpDown();
            labelSeuilAlerte = new Label();
            seuil = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            buttonajoute = new Button();
            buttonannuler = new Button();
            panelHeader = new Panel();
            panelMain = new Panel();
            groupinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturemedicament).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prixachat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prixvente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seuil).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(252, 248, 243);
            label1.Location = new Point(30, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(478, 48);
            label1.TabIndex = 2;
            label1.Text = "💊 Ajouter un médicament";
            // 
            // groupinfo
            // 
            groupinfo.BackColor = Color.White;
            groupinfo.Controls.Add(textpath);
            groupinfo.Controls.Add(buttonajouter);
            groupinfo.Controls.Add(picturemedicament);
            groupinfo.Controls.Add(comboBoxcategorie);
            groupinfo.Controls.Add(dateTimePicker);
            groupinfo.Controls.Add(comboBoxfornisseur);
            groupinfo.Controls.Add(textdescription);
            groupinfo.Controls.Add(textreference);
            groupinfo.Controls.Add(textnom);
            groupinfo.Controls.Add(labelfournisseur);
            groupinfo.Controls.Add(labelDatePeremption);
            groupinfo.Controls.Add(labeldescription);
            groupinfo.Controls.Add(label3);
            groupinfo.Controls.Add(labelcategorie);
            groupinfo.Controls.Add(labelreference);
            groupinfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupinfo.ForeColor = Color.FromArgb(34, 62, 91);
            groupinfo.Location = new Point(20, 20);
            groupinfo.Margin = new Padding(2);
            groupinfo.Name = "groupinfo";
            groupinfo.Padding = new Padding(15, 15, 15, 15);
            groupinfo.Size = new Size(850, 320);
            groupinfo.TabIndex = 3;
            groupinfo.TabStop = false;
            groupinfo.Text = "📋 Informations Générales";
            groupinfo.Enter += groupinfo_Enter;
            // 
            // textpath
            // 
            textpath.BorderStyle = BorderStyle.FixedSingle;
            textpath.Font = new Font("Segoe UI", 9F);
            textpath.Location = new Point(30, 80);
            textpath.Margin = new Padding(2);
            textpath.Name = "textpath";
            textpath.ScrollBars = ScrollBars.Vertical;
            textpath.Size = new Size(200, 31);
            textpath.TabIndex = 16;
            textpath.Visible = false;
            // 
            // buttonajouter
            // 
            buttonajouter.BackColor = Color.FromArgb(233, 244, 238);
            buttonajouter.Cursor = Cursors.Hand;
            buttonajouter.FlatAppearance.BorderSize = 0;
            buttonajouter.FlatStyle = FlatStyle.Flat;
            buttonajouter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonajouter.ForeColor = Color.FromArgb(34, 62, 91);
            buttonajouter.Location = new Point(30, 190);
            buttonajouter.Margin = new Padding(2);
            buttonajouter.Name = "buttonajouter";
            buttonajouter.Size = new Size(200, 35);
            buttonajouter.TabIndex = 15;
            buttonajouter.Text = "Ajouter une photo";
            buttonajouter.UseVisualStyleBackColor = false;
            buttonajouter.Click += button1_Click;
            // 
            // picturemedicament
            // 
            picturemedicament.BackColor = Color.FromArgb(252, 248, 243);
            picturemedicament.BorderStyle = BorderStyle.FixedSingle;
            picturemedicament.Location = new Point(30, 50);
            picturemedicament.Margin = new Padding(2);
            picturemedicament.Name = "picturemedicament";
            picturemedicament.Size = new Size(200, 130);
            picturemedicament.SizeMode = PictureBoxSizeMode.Zoom;
            picturemedicament.TabIndex = 14;
            picturemedicament.TabStop = false;
            // 
            // comboBoxcategorie
            // 
            comboBoxcategorie.BackColor = Color.FromArgb(252, 248, 243);
            comboBoxcategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxcategorie.FlatStyle = FlatStyle.Flat;
            comboBoxcategorie.Font = new Font("Segoe UI", 10F);
            comboBoxcategorie.FormattingEnabled = true;
            comboBoxcategorie.Location = new Point(578, 180);
            comboBoxcategorie.Margin = new Padding(2);
            comboBoxcategorie.Name = "comboBoxcategorie";
            comboBoxcategorie.Size = new Size(250, 36);
            comboBoxcategorie.TabIndex = 13;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Segoe UI", 10F);
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(252, 248, 243);
            dateTimePicker.Font = new Font("Segoe UI", 10F);
            dateTimePicker.Location = new Point(248, 180);
            dateTimePicker.Margin = new Padding(2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(316, 34);
            dateTimePicker.TabIndex = 12;
            // 
            // comboBoxfornisseur
            // 
            comboBoxfornisseur.BackColor = Color.FromArgb(252, 248, 243);
            comboBoxfornisseur.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxfornisseur.FlatStyle = FlatStyle.Flat;
            comboBoxfornisseur.Font = new Font("Segoe UI", 10F);
            comboBoxfornisseur.FormattingEnabled = true;
            comboBoxfornisseur.Location = new Point(575, 266);
            comboBoxfornisseur.Margin = new Padding(2);
            comboBoxfornisseur.Name = "comboBoxfornisseur";
            comboBoxfornisseur.Size = new Size(250, 36);
            comboBoxfornisseur.TabIndex = 11;
            // 
            // textdescription
            // 
            textdescription.BackColor = Color.FromArgb(252, 248, 243);
            textdescription.BorderStyle = BorderStyle.FixedSingle;
            textdescription.Font = new Font("Segoe UI", 10F);
            textdescription.Location = new Point(240, 80);
            textdescription.Margin = new Padding(2);
            textdescription.Multiline = true;
            textdescription.Name = "textdescription";
            textdescription.PlaceholderText = "Description du médicament";
            textdescription.ScrollBars = ScrollBars.Vertical;
            textdescription.Size = new Size(580, 60);
            textdescription.TabIndex = 9;
            // 
            // textreference
            // 
            textreference.BackColor = Color.FromArgb(252, 248, 243);
            textreference.BorderStyle = BorderStyle.FixedSingle;
            textreference.Font = new Font("Segoe UI", 10F);
            textreference.Location = new Point(30, 266);
            textreference.Margin = new Padding(2);
            textreference.Name = "textreference";
            textreference.PlaceholderText = "Ex: MED001";
            textreference.Size = new Size(200, 34);
            textreference.TabIndex = 8;
            // 
            // textnom
            // 
            textnom.BackColor = Color.FromArgb(252, 248, 243);
            textnom.BorderStyle = BorderStyle.FixedSingle;
            textnom.Font = new Font("Segoe UI", 10F);
            textnom.Location = new Point(306, 266);
            textnom.Margin = new Padding(2);
            textnom.Name = "textnom";
            textnom.PlaceholderText = "Nom du médicament";
            textnom.Size = new Size(204, 34);
            textnom.TabIndex = 7;
            // 
            // labelfournisseur
            // 
            labelfournisseur.AutoSize = true;
            labelfournisseur.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelfournisseur.ForeColor = Color.FromArgb(34, 62, 91);
            labelfournisseur.Location = new Point(570, 235);
            labelfournisseur.Margin = new Padding(2, 0, 2, 0);
            labelfournisseur.Name = "labelfournisseur";
            labelfournisseur.Size = new Size(118, 28);
            labelfournisseur.TabIndex = 4;
            labelfournisseur.Text = "Fournisseur";
            // 
            // labelDatePeremption
            // 
            labelDatePeremption.AutoSize = true;
            labelDatePeremption.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDatePeremption.ForeColor = Color.FromArgb(34, 62, 91);
            labelDatePeremption.Location = new Point(240, 150);
            labelDatePeremption.Margin = new Padding(2, 0, 2, 0);
            labelDatePeremption.Name = "labelDatePeremption";
            labelDatePeremption.Size = new Size(196, 28);
            labelDatePeremption.TabIndex = 3;
            labelDatePeremption.Text = "Date de péremption";
            // 
            // labeldescription
            // 
            labeldescription.AutoSize = true;
            labeldescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labeldescription.ForeColor = Color.FromArgb(34, 62, 91);
            labeldescription.Location = new Point(240, 50);
            labeldescription.Margin = new Padding(2, 0, 2, 0);
            labeldescription.Name = "labeldescription";
            labeldescription.Size = new Size(115, 28);
            labeldescription.TabIndex = 3;
            labeldescription.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(34, 62, 91);
            label3.Location = new Point(301, 235);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 2;
            label3.Text = "Nom médicament";
            // 
            // labelcategorie
            // 
            labelcategorie.AutoSize = true;
            labelcategorie.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelcategorie.ForeColor = Color.FromArgb(34, 62, 91);
            labelcategorie.Location = new Point(571, 150);
            labelcategorie.Margin = new Padding(2, 0, 2, 0);
            labelcategorie.Name = "labelcategorie";
            labelcategorie.Size = new Size(99, 28);
            labelcategorie.TabIndex = 1;
            labelcategorie.Text = "Catégorie";
            // 
            // labelreference
            // 
            labelreference.AutoSize = true;
            labelreference.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelreference.ForeColor = Color.FromArgb(34, 62, 91);
            labelreference.Location = new Point(25, 235);
            labelreference.Margin = new Padding(2, 0, 2, 0);
            labelreference.Name = "labelreference";
            labelreference.Size = new Size(102, 28);
            labelreference.TabIndex = 0;
            labelreference.Text = "Référence";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(labelPrixAchat);
            groupBox1.Controls.Add(prixachat);
            groupBox1.Controls.Add(labelPrixVente);
            groupBox1.Controls.Add(prixvente);
            groupBox1.Controls.Add(labelQuantiteStock);
            groupBox1.Controls.Add(quantite);
            groupBox1.Controls.Add(labelSeuilAlerte);
            groupBox1.Controls.Add(seuil);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(34, 62, 91);
            groupBox1.Location = new Point(20, 360);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 15, 15, 15);
            groupBox1.Size = new Size(850, 180);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "💰 Informations Financières et Stock";
            // 
            // labelPrixAchat
            // 
            labelPrixAchat.AutoSize = true;
            labelPrixAchat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrixAchat.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrixAchat.Location = new Point(30, 50);
            labelPrixAchat.Margin = new Padding(2, 0, 2, 0);
            labelPrixAchat.Name = "labelPrixAchat";
            labelPrixAchat.Size = new Size(117, 28);
            labelPrixAchat.TabIndex = 2;
            labelPrixAchat.Text = "Prix d'achat";
            // 
            // prixachat
            // 
            prixachat.BackColor = Color.FromArgb(252, 248, 243);
            prixachat.BorderStyle = BorderStyle.FixedSingle;
            prixachat.DecimalPlaces = 2;
            prixachat.Font = new Font("Segoe UI", 10F);
            prixachat.Location = new Point(30, 85);
            prixachat.Margin = new Padding(2);
            prixachat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            prixachat.Name = "prixachat";
            prixachat.Size = new Size(150, 34);
            prixachat.TabIndex = 9;
            // 
            // labelPrixVente
            // 
            labelPrixVente.AutoSize = true;
            labelPrixVente.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrixVente.ForeColor = Color.FromArgb(34, 62, 91);
            labelPrixVente.Location = new Point(230, 50);
            labelPrixVente.Margin = new Padding(2, 0, 2, 0);
            labelPrixVente.Name = "labelPrixVente";
            labelPrixVente.Size = new Size(132, 28);
            labelPrixVente.TabIndex = 0;
            labelPrixVente.Text = "Prix de vente";
            // 
            // prixvente
            // 
            prixvente.BackColor = Color.FromArgb(252, 248, 243);
            prixvente.BorderStyle = BorderStyle.FixedSingle;
            prixvente.DecimalPlaces = 2;
            prixvente.Font = new Font("Segoe UI", 10F);
            prixvente.Location = new Point(230, 85);
            prixvente.Margin = new Padding(2);
            prixvente.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            prixvente.Name = "prixvente";
            prixvente.Size = new Size(150, 34);
            prixvente.TabIndex = 10;
            // 
            // labelQuantiteStock
            // 
            labelQuantiteStock.AutoSize = true;
            labelQuantiteStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelQuantiteStock.ForeColor = Color.FromArgb(34, 62, 91);
            labelQuantiteStock.Location = new Point(445, 50);
            labelQuantiteStock.Margin = new Padding(2, 0, 2, 0);
            labelQuantiteStock.Name = "labelQuantiteStock";
            labelQuantiteStock.Size = new Size(174, 28);
            labelQuantiteStock.TabIndex = 4;
            labelQuantiteStock.Text = "Quantité en stock";
            // 
            // quantite
            // 
            quantite.BackColor = Color.FromArgb(252, 248, 243);
            quantite.BorderStyle = BorderStyle.FixedSingle;
            quantite.Font = new Font("Segoe UI", 10F);
            quantite.Location = new Point(450, 85);
            quantite.Margin = new Padding(2);
            quantite.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            quantite.Name = "quantite";
            quantite.Size = new Size(150, 34);
            quantite.TabIndex = 11;
            // 
            // labelSeuilAlerte
            // 
            labelSeuilAlerte.AutoSize = true;
            labelSeuilAlerte.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelSeuilAlerte.ForeColor = Color.FromArgb(34, 62, 91);
            labelSeuilAlerte.Location = new Point(650, 50);
            labelSeuilAlerte.Margin = new Padding(2, 0, 2, 0);
            labelSeuilAlerte.Name = "labelSeuilAlerte";
            labelSeuilAlerte.Size = new Size(131, 28);
            labelSeuilAlerte.TabIndex = 1;
            labelSeuilAlerte.Text = "Seuil d'alerte";
            // 
            // seuil
            // 
            seuil.BackColor = Color.FromArgb(252, 248, 243);
            seuil.BorderStyle = BorderStyle.FixedSingle;
            seuil.Font = new Font("Segoe UI", 10F);
            seuil.Location = new Point(650, 85);
            seuil.Margin = new Padding(2);
            seuil.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            seuil.Name = "seuil";
            seuil.Size = new Size(150, 34);
            seuil.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // buttonajoute
            // 
            buttonajoute.BackColor = Color.FromArgb(246, 145, 118);
            buttonajoute.Cursor = Cursors.Hand;
            buttonajoute.FlatAppearance.BorderSize = 0;
            buttonajoute.FlatStyle = FlatStyle.Flat;
            buttonajoute.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonajoute.ForeColor = Color.White;
            buttonajoute.Location = new Point(220, 560);
            buttonajoute.Margin = new Padding(2);
            buttonajoute.Name = "buttonajoute";
            buttonajoute.Size = new Size(200, 50);
            buttonajoute.TabIndex = 6;
            buttonajoute.Text = "✓ Ajouter";
            buttonajoute.UseVisualStyleBackColor = false;
            buttonajoute.Click += buttonajoute_Click;
            // 
            // buttonannuler
            // 
            buttonannuler.BackColor = Color.FromArgb(233, 244, 238);
            buttonannuler.Cursor = Cursors.Hand;
            buttonannuler.FlatAppearance.BorderSize = 0;
            buttonannuler.FlatStyle = FlatStyle.Flat;
            buttonannuler.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonannuler.ForeColor = Color.FromArgb(34, 62, 91);
            buttonannuler.Location = new Point(470, 560);
            buttonannuler.Margin = new Padding(2);
            buttonannuler.Name = "buttonannuler";
            buttonannuler.Size = new Size(200, 50);
            buttonannuler.TabIndex = 7;
            buttonannuler.Text = "✕ Annuler";
            buttonannuler.UseVisualStyleBackColor = false;
            buttonannuler.Click += buttonannuler_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(34, 62, 91);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(950, 80);
            panelHeader.TabIndex = 8;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(252, 248, 243);
            panelMain.Controls.Add(groupinfo);
            panelMain.Controls.Add(groupBox1);
            panelMain.Controls.Add(buttonajoute);
            panelMain.Controls.Add(buttonannuler);
            panelMain.Location = new Point(30, 100);
            panelMain.Margin = new Padding(2);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 20, 20, 20);
            panelMain.Size = new Size(890, 650);
            panelMain.TabIndex = 9;
            // 
            // FormAjouterMedicament
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 243);
            ClientSize = new Size(950, 780);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormAjouterMedicament";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Ajouter un médicament";
            Load += FormAjouterMedicament_Load;
            groupinfo.ResumeLayout(false);
            groupinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturemedicament).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prixachat).EndInit();
            ((System.ComponentModel.ISupportInitialize)prixvente).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)seuil).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelMain;
        private Label label1;
        private GroupBox groupinfo;
        private Label labelfournisseur;
        private Label labeldescription;
        private Label label3;
        private Label labelcategorie;
        private GroupBox groupBox1;
        private Label labelQuantiteStock;
        private Label labelDatePeremption;
        private Label labelPrixAchat;
        private Label labelSeuilAlerte;
        private Label labelPrixVente;
        private ComboBox comboBoxfornisseur;
        private TextBox textdescription;
        private TextBox textreference;
        private TextBox textnom;
        private Label labelreference;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxcategorie;
        private NumericUpDown seuil;
        private NumericUpDown quantite;
        private NumericUpDown prixvente;
        private NumericUpDown prixachat;
        private Button buttonajouter;
        private PictureBox picturemedicament;
        private OpenFileDialog openFileDialog1;
        private TextBox textpath;
        private Button buttonajoute;
        private Button buttonannuler;
    }
}