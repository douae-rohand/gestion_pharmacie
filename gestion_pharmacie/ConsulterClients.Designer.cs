namespace gestion_pharmacie
{
    partial class ConsulterClients
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            clientGridView = new DataGridView();
            Supprimer = new DataGridViewButtonColumn();
            Modifier = new DataGridViewButtonColumn();
            panelSearch = new Panel();
            button2 = new Button();
            combocritere = new ComboBox();
            textrecherche = new TextBox();
            buttonrecherche = new Button();
            panelMenu = new Panel();
            button1 = new Button();
            labelMenuTitre = new Label();
            buttonMedicaments = new Button();
            buttonCommande = new Button();
            buttonClients = new Button();
            buttonNotification = new Button();
            buttonDeconnexion = new Button();
            panelHeader = new Panel();
            label1 = new Label();
            panelStatistiques = new Panel();
            panelStatTotal = new Panel();
            labelStatTotalValeur = new Label();
            labelStatTotalTitre = new Label();
            panelStatActifs = new Panel();
            labelStatActifsValeur = new Label();
            labelStatActifsTitre = new Label();
            panelStatRevenu = new Panel();
            labelStatRevenuValeur = new Label();
            labelStatRevenuTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)clientGridView).BeginInit();
            panelSearch.SuspendLayout();
            panelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            panelStatistiques.SuspendLayout();
            panelStatTotal.SuspendLayout();
            panelStatActifs.SuspendLayout();
            panelStatRevenu.SuspendLayout();
            SuspendLayout();
            // 
            // clientGridView
            // 
            clientGridView.AllowUserToAddRows = false;
            clientGridView.AllowUserToDeleteRows = false;
            clientGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientGridView.BackgroundColor = Color.White;
            clientGridView.BorderStyle = BorderStyle.None;
            clientGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            clientGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            clientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            clientGridView.ColumnHeadersHeight = 50;
            clientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            clientGridView.Columns.AddRange(new DataGridViewColumn[] { Supprimer, Modifier });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.Padding = new Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(233, 244, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            clientGridView.DefaultCellStyle = dataGridViewCellStyle2;
            clientGridView.EnableHeadersVisualStyles = false;
            clientGridView.GridColor = Color.FromArgb(233, 244, 238);
            clientGridView.Location = new Point(250, 402);
            clientGridView.Margin = new Padding(2);
            clientGridView.Name = "clientGridView";
            clientGridView.ReadOnly = true;
            clientGridView.RowHeadersVisible = false;
            clientGridView.RowHeadersWidth = 62;
            clientGridView.RowTemplate.Height = 45;
            clientGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientGridView.Size = new Size(1663, 379);
            clientGridView.TabIndex = 11;
            clientGridView.CellContentClick += clientGridView_CellContentClick;
            // 
            // Supprimer
            // 
            Supprimer.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Supprimer.FlatStyle = FlatStyle.Flat;
            Supprimer.HeaderText = "Supprimer";
            Supprimer.MinimumWidth = 120;
            Supprimer.Name = "Supprimer";
            Supprimer.ReadOnly = true;
            Supprimer.Text = "🗑️";
            Supprimer.ToolTipText = "Supprimer ce client";
            Supprimer.UseColumnTextForButtonValue = true;
            Supprimer.Width = 120;
            // 
            // Modifier
            // 
            Modifier.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Modifier.FlatStyle = FlatStyle.Flat;
            Modifier.HeaderText = "Modifier";
            Modifier.MinimumWidth = 120;
            Modifier.Name = "Modifier";
            Modifier.ReadOnly = true;
            Modifier.Text = "✏️";
            Modifier.ToolTipText = "Modifier ce client";
            Modifier.UseColumnTextForButtonValue = true;
            Modifier.Width = 120;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(button2);
            panelSearch.Controls.Add(combocritere);
            panelSearch.Controls.Add(textrecherche);
            panelSearch.Controls.Add(buttonrecherche);
            panelSearch.Location = new Point(250, 290);
            panelSearch.Margin = new Padding(2);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(25);
            panelSearch.Size = new Size(1650, 94);
            panelSearch.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(246, 145, 118);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1380, 22);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(245, 45);
            button2.TabIndex = 7;
            button2.Text = "➕ Ajouter Client";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // combocritere
            // 
            combocritere.BackColor = Color.FromArgb(252, 248, 243);
            combocritere.DropDownStyle = ComboBoxStyle.DropDownList;
            combocritere.FlatStyle = FlatStyle.Flat;
            combocritere.Font = new Font("Segoe UI", 10F);
            combocritere.ForeColor = Color.FromArgb(34, 62, 91);
            combocritere.FormattingEnabled = true;
            combocritere.Location = new Point(25, 25);
            combocritere.Margin = new Padding(2);
            combocritere.Name = "combocritere";
            combocritere.Size = new Size(250, 36);
            combocritere.TabIndex = 5;
            combocritere.SelectedIndexChanged += combocritere_SelectedIndexChanged;
            // 
            // textrecherche
            // 
            textrecherche.BackColor = Color.FromArgb(252, 248, 243);
            textrecherche.BorderStyle = BorderStyle.None;
            textrecherche.Font = new Font("Segoe UI", 11F);
            textrecherche.ForeColor = Color.FromArgb(34, 62, 91);
            textrecherche.Location = new Point(295, 28);
            textrecherche.Margin = new Padding(2);
            textrecherche.Name = "textrecherche";
            textrecherche.PlaceholderText = "Rechercher un client...";
            textrecherche.Size = new Size(750, 30);
            textrecherche.TabIndex = 3;
            textrecherche.TextChanged += textrecherche_TextChanged;
            // 
            // buttonrecherche
            // 
            buttonrecherche.BackColor = Color.FromArgb(34, 62, 91);
            buttonrecherche.Cursor = Cursors.Hand;
            buttonrecherche.FlatAppearance.BorderSize = 0;
            buttonrecherche.FlatStyle = FlatStyle.Flat;
            buttonrecherche.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonrecherche.ForeColor = Color.White;
            buttonrecherche.Location = new Point(1065, 22);
            buttonrecherche.Margin = new Padding(2);
            buttonrecherche.Name = "buttonrecherche";
            buttonrecherche.Size = new Size(290, 45);
            buttonrecherche.TabIndex = 4;
            buttonrecherche.Text = "🔍 Rechercher";
            buttonrecherche.UseVisualStyleBackColor = false;
            buttonrecherche.Click += buttonrecherche_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 62, 91);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(labelMenuTitre);
            panelMenu.Controls.Add(buttonMedicaments);
            panelMenu.Controls.Add(buttonCommande);
            panelMenu.Controls.Add(buttonClients);
            panelMenu.Controls.Add(buttonNotification);
            panelMenu.Controls.Add(buttonDeconnexion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 90);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 826);
            panelMenu.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 62, 91);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-2, 335);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(230, 55);
            button1.TabIndex = 8;
            button1.Text = "👥 Fournisseurs";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelMenuTitre
            // 
            labelMenuTitre.AutoSize = true;
            labelMenuTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelMenuTitre.ForeColor = Color.FromArgb(233, 244, 238);
            labelMenuTitre.Location = new Point(15, 25);
            labelMenuTitre.Margin = new Padding(2, 0, 2, 0);
            labelMenuTitre.Name = "labelMenuTitre";
            labelMenuTitre.Size = new Size(181, 32);
            labelMenuTitre.TabIndex = 0;
            labelMenuTitre.Text = "🗂️ Navigation";
            // 
            // buttonMedicaments
            // 
            buttonMedicaments.BackColor = Color.FromArgb(34, 62, 91);
            buttonMedicaments.Cursor = Cursors.Hand;
            buttonMedicaments.FlatAppearance.BorderSize = 0;
            buttonMedicaments.FlatStyle = FlatStyle.Flat;
            buttonMedicaments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonMedicaments.ForeColor = Color.White;
            buttonMedicaments.Location = new Point(0, 80);
            buttonMedicaments.Margin = new Padding(2);
            buttonMedicaments.Name = "buttonMedicaments";
            buttonMedicaments.Padding = new Padding(20, 0, 0, 0);
            buttonMedicaments.Size = new Size(230, 55);
            buttonMedicaments.TabIndex = 1;
            buttonMedicaments.Text = "💊 Médicaments";
            buttonMedicaments.TextAlign = ContentAlignment.MiddleLeft;
            buttonMedicaments.UseVisualStyleBackColor = false;
            buttonMedicaments.Click += buttonMedicaments_Click;
            // 
            // buttonCommande
            // 
            buttonCommande.BackColor = Color.FromArgb(34, 62, 91);
            buttonCommande.Cursor = Cursors.Hand;
            buttonCommande.FlatAppearance.BorderSize = 0;
            buttonCommande.FlatStyle = FlatStyle.Flat;
            buttonCommande.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCommande.ForeColor = Color.White;
            buttonCommande.Location = new Point(0, 145);
            buttonCommande.Margin = new Padding(2);
            buttonCommande.Name = "buttonCommande";
            buttonCommande.Padding = new Padding(20, 0, 0, 0);
            buttonCommande.Size = new Size(230, 55);
            buttonCommande.TabIndex = 2;
            buttonCommande.Text = "📦 Commandes";
            buttonCommande.TextAlign = ContentAlignment.MiddleLeft;
            buttonCommande.UseVisualStyleBackColor = false;
            buttonCommande.Click += buttonCommande_Click;
            // 
            // buttonClients
            // 
            buttonClients.BackColor = Color.FromArgb(246, 145, 118);
            buttonClients.Cursor = Cursors.Hand;
            buttonClients.FlatAppearance.BorderSize = 0;
            buttonClients.FlatStyle = FlatStyle.Flat;
            buttonClients.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonClients.ForeColor = Color.White;
            buttonClients.Location = new Point(0, 210);
            buttonClients.Margin = new Padding(2);
            buttonClients.Name = "buttonClients";
            buttonClients.Padding = new Padding(20, 0, 0, 0);
            buttonClients.Size = new Size(230, 55);
            buttonClients.TabIndex = 3;
            buttonClients.Text = "👥 Clients";
            buttonClients.TextAlign = ContentAlignment.MiddleLeft;
            buttonClients.UseVisualStyleBackColor = false;
            // 
            // buttonNotification
            // 
            buttonNotification.BackColor = Color.FromArgb(34, 62, 91);
            buttonNotification.Cursor = Cursors.Hand;
            buttonNotification.FlatAppearance.BorderSize = 0;
            buttonNotification.FlatStyle = FlatStyle.Flat;
            buttonNotification.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonNotification.ForeColor = Color.White;
            buttonNotification.Location = new Point(0, 275);
            buttonNotification.Margin = new Padding(2);
            buttonNotification.Name = "buttonNotification";
            buttonNotification.Padding = new Padding(20, 0, 0, 0);
            buttonNotification.Size = new Size(230, 55);
            buttonNotification.TabIndex = 4;
            buttonNotification.Text = "🔔 Alertes";
            buttonNotification.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotification.UseVisualStyleBackColor = false;
            buttonNotification.Click += buttonNotification_Click;
            // 
            // buttonDeconnexion
            // 
            buttonDeconnexion.BackColor = Color.FromArgb(235, 203, 176);
            buttonDeconnexion.Cursor = Cursors.Hand;
            buttonDeconnexion.FlatAppearance.BorderSize = 0;
            buttonDeconnexion.FlatStyle = FlatStyle.Flat;
            buttonDeconnexion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDeconnexion.ForeColor = Color.FromArgb(34, 62, 91);
            buttonDeconnexion.Location = new Point(20, 724);
            buttonDeconnexion.Margin = new Padding(2);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Size = new Size(184, 50);
            buttonDeconnexion.TabIndex = 7;
            buttonDeconnexion.Text = "Déconnexion";
            buttonDeconnexion.UseVisualStyleBackColor = false;
            buttonDeconnexion.Click += buttonDeconnexion_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(252, 248, 243);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1924, 90);
            panelHeader.TabIndex = 12;
            panelHeader.Paint += panelHeader_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 62, 91);
            label1.Location = new Point(250, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 54);
            label1.TabIndex = 1;
            label1.Text = "👥 Clients";
            label1.Click += label1_Click;
            // 
            // panelStatistiques
            // 
            panelStatistiques.BackColor = Color.FromArgb(242, 231, 211);
            panelStatistiques.Controls.Add(panelStatTotal);
            panelStatistiques.Controls.Add(panelStatActifs);
            panelStatistiques.Controls.Add(panelStatRevenu);
            panelStatistiques.Location = new Point(250, 115);
            panelStatistiques.Margin = new Padding(2);
            panelStatistiques.Name = "panelStatistiques";
            panelStatistiques.Padding = new Padding(20);
            panelStatistiques.Size = new Size(1650, 155);
            panelStatistiques.TabIndex = 15;
            // 
            // panelStatTotal
            // 
            panelStatTotal.BackColor = Color.FromArgb(34, 62, 91);
            panelStatTotal.Controls.Add(labelStatTotalValeur);
            panelStatTotal.Controls.Add(labelStatTotalTitre);
            panelStatTotal.Location = new Point(25, 25);
            panelStatTotal.Margin = new Padding(2);
            panelStatTotal.Name = "panelStatTotal";
            panelStatTotal.Padding = new Padding(20);
            panelStatTotal.Size = new Size(520, 105);
            panelStatTotal.TabIndex = 0;
            // 
            // labelStatTotalValeur
            // 
            labelStatTotalValeur.AutoSize = true;
            labelStatTotalValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatTotalValeur.ForeColor = Color.White;
            labelStatTotalValeur.Location = new Point(20, 45);
            labelStatTotalValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatTotalValeur.Name = "labelStatTotalValeur";
            labelStatTotalValeur.Size = new Size(50, 60);
            labelStatTotalValeur.TabIndex = 1;
            labelStatTotalValeur.Text = "0";
            // 
            // labelStatTotalTitre
            // 
            labelStatTotalTitre.AutoSize = true;
            labelStatTotalTitre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelStatTotalTitre.ForeColor = Color.FromArgb(233, 244, 238);
            labelStatTotalTitre.Location = new Point(20, 15);
            labelStatTotalTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatTotalTitre.Name = "labelStatTotalTitre";
            labelStatTotalTitre.Size = new Size(177, 30);
            labelStatTotalTitre.TabIndex = 0;
            labelStatTotalTitre.Text = "👥 Total Clients";
            // 
            // panelStatActifs
            // 
            panelStatActifs.BackColor = Color.FromArgb(233, 244, 238);
            panelStatActifs.Controls.Add(labelStatActifsValeur);
            panelStatActifs.Controls.Add(labelStatActifsTitre);
            panelStatActifs.Location = new Point(565, 25);
            panelStatActifs.Margin = new Padding(2);
            panelStatActifs.Name = "panelStatActifs";
            panelStatActifs.Padding = new Padding(20);
            panelStatActifs.Size = new Size(520, 105);
            panelStatActifs.TabIndex = 1;
            // 
            // labelStatActifsValeur
            // 
            labelStatActifsValeur.AutoSize = true;
            labelStatActifsValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatActifsValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatActifsValeur.Location = new Point(20, 45);
            labelStatActifsValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatActifsValeur.Name = "labelStatActifsValeur";
            labelStatActifsValeur.Size = new Size(50, 60);
            labelStatActifsValeur.TabIndex = 1;
            labelStatActifsValeur.Text = "0";
            // 
            // labelStatActifsTitre
            // 
            labelStatActifsTitre.AutoSize = true;
            labelStatActifsTitre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelStatActifsTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatActifsTitre.Location = new Point(20, 15);
            labelStatActifsTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatActifsTitre.Name = "labelStatActifsTitre";
            labelStatActifsTitre.Size = new Size(185, 30);
            labelStatActifsTitre.TabIndex = 0;
            labelStatActifsTitre.Text = "✅ Clients Actifs";
            // 
            // panelStatRevenu
            // 
            panelStatRevenu.BackColor = Color.FromArgb(246, 145, 118);
            panelStatRevenu.Controls.Add(labelStatRevenuValeur);
            panelStatRevenu.Controls.Add(labelStatRevenuTitre);
            panelStatRevenu.Location = new Point(1105, 25);
            panelStatRevenu.Margin = new Padding(2);
            panelStatRevenu.Name = "panelStatRevenu";
            panelStatRevenu.Padding = new Padding(20);
            panelStatRevenu.Size = new Size(520, 105);
            panelStatRevenu.TabIndex = 3;
            // 
            // labelStatRevenuValeur
            // 
            labelStatRevenuValeur.AutoSize = true;
            labelStatRevenuValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatRevenuValeur.ForeColor = Color.White;
            labelStatRevenuValeur.Location = new Point(20, 45);
            labelStatRevenuValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatRevenuValeur.Name = "labelStatRevenuValeur";
            labelStatRevenuValeur.Size = new Size(128, 60);
            labelStatRevenuValeur.TabIndex = 1;
            labelStatRevenuValeur.Text = "0 DH";
            // 
            // labelStatRevenuTitre
            // 
            labelStatRevenuTitre.AutoSize = true;
            labelStatRevenuTitre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelStatRevenuTitre.ForeColor = Color.White;
            labelStatRevenuTitre.Location = new Point(20, 15);
            labelStatRevenuTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatRevenuTitre.Name = "labelStatRevenuTitre";
            labelStatRevenuTitre.Size = new Size(182, 30);
            labelStatRevenuTitre.TabIndex = 0;
            labelStatRevenuTitre.Text = "💰 Revenu Total";
            // 
            // ConsulterClients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 211);
            ClientSize = new Size(1924, 916);
            Controls.Add(panelStatistiques);
            Controls.Add(clientGridView);
            Controls.Add(panelSearch);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Margin = new Padding(2);
            Name = "ConsulterClients";
            Text = "Gestion Pharmacie - Clients";
            WindowState = FormWindowState.Maximized;
            Load += ConsulterClients_Load;
            ((System.ComponentModel.ISupportInitialize)clientGridView).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStatistiques.ResumeLayout(false);
            panelStatTotal.ResumeLayout(false);
            panelStatTotal.PerformLayout();
            panelStatActifs.ResumeLayout(false);
            panelStatActifs.PerformLayout();
            panelStatRevenu.ResumeLayout(false);
            panelStatRevenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientGridView;
        private DataGridViewButtonColumn Supprimer;
        private DataGridViewButtonColumn Modifier;
        private Panel panelSearch;
        private ComboBox combocritere;
        private TextBox textrecherche;
        private Button buttonrecherche;
        private Panel panelMenu;
        private Label labelMenuTitre;
        private Button buttonMedicaments;
        private Button buttonCommande;
        private Button buttonClients;
        private Button buttonNotification;
        private Button buttonDeconnexion;
        private Panel panelHeader;
        private Label label1;
        private Panel panelStatistiques;
        private Panel panelStatTotal;
        private Label labelStatTotalValeur;
        private Label labelStatTotalTitre;
        private Panel panelStatActifs;
        private Label labelStatActifsValeur;
        private Label labelStatActifsTitre;
        private Panel panelStatRevenu;
        private Label labelStatRevenuValeur;
        private Label labelStatRevenuTitre;
        private Button button2;
        private Button button1;
    }
}