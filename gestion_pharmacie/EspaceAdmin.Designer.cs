namespace gestion_pharmacie
{
    partial class EspaceAdmin
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
            label1 = new Label();
            textrecherche = new TextBox();
            buttonrecherche = new Button();
            combocritere = new ComboBox();
            buttonajouter = new Button();
            dataGridView = new DataGridView();
            Supprimer = new DataGridViewButtonColumn();
            Details = new DataGridViewButtonColumn();
            Modifier = new DataGridViewButtonColumn();
            panelHeader = new Panel();
            panelSearch = new Panel();
            panelMenu = new Panel();
            button1 = new Button();
            labelMenuTitre = new Label();
            buttonMedicaments = new Button();
            buttonFournisseurs = new Button();
            buttonClients = new Button();
            buttonCategories = new Button();
            buttonDeconnexion = new Button();
            panelStatistiques = new Panel();
            panelStatTotal = new Panel();
            labelStatTotalValeur = new Label();
            labelStatTotalTitre = new Label();
            panelStatCategories = new Panel();
            labelStatCategoriesValeur = new Label();
            labelStatCategoriesTitre = new Label();
            panelStatStock = new Panel();
            labelStatStockValeur = new Label();
            labelStatStockTitre = new Label();
            panelStatAlertes = new Panel();
            labelStatAlertesValeur = new Label();
            labelStatAlertesTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            panelMenu.SuspendLayout();
            panelStatistiques.SuspendLayout();
            panelStatTotal.SuspendLayout();
            panelStatCategories.SuspendLayout();
            panelStatStock.SuspendLayout();
            panelStatAlertes.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 62, 91);
            label1.Location = new Point(250, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(511, 54);
            label1.TabIndex = 1;
            label1.Text = "📋 Espace Administration";
            // 
            // textrecherche
            // 
            textrecherche.BackColor = Color.FromArgb(252, 248, 243);
            textrecherche.BorderStyle = BorderStyle.None;
            textrecherche.Font = new Font("Segoe UI", 11F);
            textrecherche.ForeColor = Color.FromArgb(34, 62, 91);
            textrecherche.Location = new Point(295, 25);
            textrecherche.Margin = new Padding(2);
            textrecherche.Name = "textrecherche";
            textrecherche.PlaceholderText = "Rechercher un médicament...";
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
            // combocritere
            // 
            combocritere.BackColor = Color.FromArgb(252, 248, 243);
            combocritere.DropDownStyle = ComboBoxStyle.DropDownList;
            combocritere.FlatStyle = FlatStyle.Flat;
            combocritere.Font = new Font("Segoe UI", 10F);
            combocritere.ForeColor = Color.FromArgb(34, 62, 91);
            combocritere.FormattingEnabled = true;
            combocritere.Items.AddRange(new object[] { "Nom médicament", "Fournisseurs", "Référence", "Près d'expirer", "Date de péremption", "Seuil alerte" });
            combocritere.Location = new Point(25, 25);
            combocritere.Margin = new Padding(2);
            combocritere.Name = "combocritere";
            combocritere.Size = new Size(250, 36);
            combocritere.TabIndex = 5;
            // 
            // buttonajouter
            // 
            buttonajouter.BackColor = Color.FromArgb(246, 145, 118);
            buttonajouter.Cursor = Cursors.Hand;
            buttonajouter.FlatAppearance.BorderSize = 0;
            buttonajouter.FlatStyle = FlatStyle.Flat;
            buttonajouter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonajouter.ForeColor = Color.White;
            buttonajouter.Location = new Point(1380, 22);
            buttonajouter.Margin = new Padding(2);
            buttonajouter.Name = "buttonajouter";
            buttonajouter.Size = new Size(245, 45);
            buttonajouter.TabIndex = 6;
            buttonajouter.Text = "➕ Ajouter médicament";
            buttonajouter.UseVisualStyleBackColor = false;
            buttonajouter.Click += buttonajouter_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Supprimer, Details, Modifier });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.Padding = new Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(233, 244, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(233, 244, 238);
            dataGridView.Location = new Point(248, 417);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 45;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1665, 406);
            dataGridView.TabIndex = 7;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
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
            Supprimer.ToolTipText = "Supprimer ";
            Supprimer.UseColumnTextForButtonValue = true;
            Supprimer.Width = 120;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Details.FlatStyle = FlatStyle.Flat;
            Details.HeaderText = "Details";
            Details.MinimumWidth = 120;
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Text = "Details";
            Details.ToolTipText = "Details";
            Details.UseColumnTextForButtonValue = true;
            Details.Width = 120;
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
            Modifier.ToolTipText = "Modifier";
            Modifier.UseColumnTextForButtonValue = true;
            Modifier.Width = 120;
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
            panelHeader.TabIndex = 8;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(combocritere);
            panelSearch.Controls.Add(textrecherche);
            panelSearch.Controls.Add(buttonrecherche);
            panelSearch.Controls.Add(buttonajouter);
            panelSearch.Location = new Point(250, 290);
            panelSearch.Margin = new Padding(2);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(25, 25, 25, 25);
            panelSearch.Size = new Size(1664, 110);
            panelSearch.TabIndex = 9;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 62, 91);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(labelMenuTitre);
            panelMenu.Controls.Add(buttonMedicaments);
            panelMenu.Controls.Add(buttonFournisseurs);
            panelMenu.Controls.Add(buttonClients);
            panelMenu.Controls.Add(buttonCategories);
            panelMenu.Controls.Add(buttonDeconnexion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 90);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 818);
            panelMenu.TabIndex = 10;
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
            buttonMedicaments.BackColor = Color.FromArgb(246, 145, 118);
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
            // 
            // buttonFournisseurs
            // 
            buttonFournisseurs.BackColor = Color.FromArgb(34, 62, 91);
            buttonFournisseurs.Cursor = Cursors.Hand;
            buttonFournisseurs.FlatAppearance.BorderSize = 0;
            buttonFournisseurs.FlatStyle = FlatStyle.Flat;
            buttonFournisseurs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonFournisseurs.ForeColor = Color.White;
            buttonFournisseurs.Location = new Point(0, 145);
            buttonFournisseurs.Margin = new Padding(2);
            buttonFournisseurs.Name = "buttonFournisseurs";
            buttonFournisseurs.Padding = new Padding(20, 0, 0, 0);
            buttonFournisseurs.Size = new Size(230, 55);
            buttonFournisseurs.TabIndex = 2;
            buttonFournisseurs.Text = "📦 Commandes";
            buttonFournisseurs.TextAlign = ContentAlignment.MiddleLeft;
            buttonFournisseurs.UseVisualStyleBackColor = false;
            buttonFournisseurs.Click += buttonFournisseurs_Click;
            // 
            // buttonClients
            // 
            buttonClients.BackColor = Color.FromArgb(34, 62, 91);
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
            buttonClients.Click += buttonClients_Click;
            // 
            // buttonCategories
            // 
            buttonCategories.BackColor = Color.FromArgb(34, 62, 91);
            buttonCategories.Cursor = Cursors.Hand;
            buttonCategories.FlatAppearance.BorderSize = 0;
            buttonCategories.FlatStyle = FlatStyle.Flat;
            buttonCategories.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCategories.ForeColor = Color.White;
            buttonCategories.Location = new Point(0, 275);
            buttonCategories.Margin = new Padding(2);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Padding = new Padding(20, 0, 0, 0);
            buttonCategories.Size = new Size(230, 55);
            buttonCategories.TabIndex = 4;
            buttonCategories.Text = "🔔 Alertes";
            buttonCategories.TextAlign = ContentAlignment.MiddleLeft;
            buttonCategories.UseVisualStyleBackColor = false;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // buttonDeconnexion
            // 
            buttonDeconnexion.BackColor = Color.FromArgb(235, 203, 176);
            buttonDeconnexion.Cursor = Cursors.Hand;
            buttonDeconnexion.FlatAppearance.BorderSize = 0;
            buttonDeconnexion.FlatStyle = FlatStyle.Flat;
            buttonDeconnexion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDeconnexion.ForeColor = Color.FromArgb(34, 62, 91);
            buttonDeconnexion.Location = new Point(20, 779);
            buttonDeconnexion.Margin = new Padding(2);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Size = new Size(184, 50);
            buttonDeconnexion.TabIndex = 7;
            buttonDeconnexion.Text = "Déconnexion";
            buttonDeconnexion.UseVisualStyleBackColor = false;
            buttonDeconnexion.Click += buttonDeconnexion_Click;
            // 
            // panelStatistiques
            // 
            panelStatistiques.BackColor = Color.FromArgb(242, 231, 211);
            panelStatistiques.Controls.Add(panelStatTotal);
            panelStatistiques.Controls.Add(panelStatCategories);
            panelStatistiques.Controls.Add(panelStatStock);
            panelStatistiques.Controls.Add(panelStatAlertes);
            panelStatistiques.Location = new Point(250, 115);
            panelStatistiques.Margin = new Padding(2);
            panelStatistiques.Name = "panelStatistiques";
            panelStatistiques.Padding = new Padding(20, 20, 20, 20);
            panelStatistiques.Size = new Size(1762, 155);
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
            panelStatTotal.Padding = new Padding(20, 20, 20, 20);
            panelStatTotal.Size = new Size(380, 105);
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
            labelStatTotalTitre.Size = new Size(247, 30);
            labelStatTotalTitre.TabIndex = 0;
            labelStatTotalTitre.Text = "💊 Total Médicaments";
            // 
            // panelStatCategories
            // 
            panelStatCategories.BackColor = Color.FromArgb(233, 244, 238);
            panelStatCategories.Controls.Add(labelStatCategoriesValeur);
            panelStatCategories.Controls.Add(labelStatCategoriesTitre);
            panelStatCategories.Location = new Point(430, 25);
            panelStatCategories.Margin = new Padding(2);
            panelStatCategories.Name = "panelStatCategories";
            panelStatCategories.Padding = new Padding(20, 20, 20, 20);
            panelStatCategories.Size = new Size(406, 105);
            panelStatCategories.TabIndex = 1;
            // 
            // labelStatCategoriesValeur
            // 
            labelStatCategoriesValeur.AutoSize = true;
            labelStatCategoriesValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatCategoriesValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatCategoriesValeur.Location = new Point(20, 45);
            labelStatCategoriesValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatCategoriesValeur.Name = "labelStatCategoriesValeur";
            labelStatCategoriesValeur.Size = new Size(50, 60);
            labelStatCategoriesValeur.TabIndex = 1;
            labelStatCategoriesValeur.Text = "0";
            // 
            // labelStatCategoriesTitre
            // 
            labelStatCategoriesTitre.AutoSize = true;
            labelStatCategoriesTitre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelStatCategoriesTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatCategoriesTitre.Location = new Point(20, 15);
            labelStatCategoriesTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatCategoriesTitre.Name = "labelStatCategoriesTitre";
            labelStatCategoriesTitre.Size = new Size(363, 30);
            labelStatCategoriesTitre.TabIndex = 0;
            labelStatCategoriesTitre.Text = "⚠️ Alertes Peremption (< 3 mois)";
            // 
            // panelStatStock
            // 
            panelStatStock.BackColor = Color.FromArgb(246, 145, 118);
            panelStatStock.Controls.Add(labelStatStockValeur);
            panelStatStock.Controls.Add(labelStatStockTitre);
            panelStatStock.Location = new Point(864, 25);
            panelStatStock.Margin = new Padding(2);
            panelStatStock.Name = "panelStatStock";
            panelStatStock.Padding = new Padding(20, 20, 20, 20);
            panelStatStock.Size = new Size(380, 105);
            panelStatStock.TabIndex = 2;
            // 
            // labelStatStockValeur
            // 
            labelStatStockValeur.AutoSize = true;
            labelStatStockValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatStockValeur.ForeColor = Color.White;
            labelStatStockValeur.Location = new Point(20, 45);
            labelStatStockValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatStockValeur.Name = "labelStatStockValeur";
            labelStatStockValeur.Size = new Size(50, 60);
            labelStatStockValeur.TabIndex = 1;
            labelStatStockValeur.Text = "0";
            // 
            // labelStatStockTitre
            // 
            labelStatStockTitre.AutoSize = true;
            labelStatStockTitre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelStatStockTitre.ForeColor = Color.White;
            labelStatStockTitre.Location = new Point(20, 15);
            labelStatStockTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatStockTitre.Name = "labelStatStockTitre";
            labelStatStockTitre.Size = new Size(163, 30);
            labelStatStockTitre.TabIndex = 0;
            labelStatStockTitre.Text = "📦 Stock Total";
            // 
            // panelStatAlertes
            // 
            panelStatAlertes.BackColor = Color.FromArgb(235, 203, 176);
            panelStatAlertes.Controls.Add(labelStatAlertesValeur);
            panelStatAlertes.Controls.Add(labelStatAlertesTitre);
            panelStatAlertes.Location = new Point(1272, 25);
            panelStatAlertes.Margin = new Padding(2);
            panelStatAlertes.Name = "panelStatAlertes";
            panelStatAlertes.Padding = new Padding(20, 20, 20, 20);
            panelStatAlertes.Size = new Size(380, 105);
            panelStatAlertes.TabIndex = 3;
            // 
            // labelStatAlertesValeur
            // 
            labelStatAlertesValeur.AutoSize = true;
            labelStatAlertesValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatAlertesValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatAlertesValeur.Location = new Point(20, 45);
            labelStatAlertesValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatAlertesValeur.Name = "labelStatAlertesValeur";
            labelStatAlertesValeur.Size = new Size(50, 60);
            labelStatAlertesValeur.TabIndex = 1;
            labelStatAlertesValeur.Text = "0";
            // 
            // labelStatAlertesTitre
            // 
            labelStatAlertesTitre.AutoSize = true;
            labelStatAlertesTitre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelStatAlertesTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatAlertesTitre.Location = new Point(20, 15);
            labelStatAlertesTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatAlertesTitre.Name = "labelStatAlertesTitre";
            labelStatAlertesTitre.Size = new Size(186, 30);
            labelStatAlertesTitre.TabIndex = 0;
            labelStatAlertesTitre.Text = "⚠️ Alertes Stock";
            // 
            // EspaceAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 211);
            ClientSize = new Size(1924, 908);
            Controls.Add(panelStatistiques);
            Controls.Add(dataGridView);
            Controls.Add(panelSearch);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(2);
            Name = "EspaceAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Administration";
            WindowState = FormWindowState.Maximized;
            Load += EspaceAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelStatistiques.ResumeLayout(false);
            panelStatTotal.ResumeLayout(false);
            panelStatTotal.PerformLayout();
            panelStatCategories.ResumeLayout(false);
            panelStatCategories.PerformLayout();
            panelStatStock.ResumeLayout(false);
            panelStatStock.PerformLayout();
            panelStatAlertes.ResumeLayout(false);
            panelStatAlertes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelSearch;
        private Panel panelMenu;
        private Label label1;
        private Label labelMenuTitre;
        private Button buttonMedicaments;
        private Button buttonFournisseurs;
        private Button buttonClients;
        private Button buttonCategories;
        private Button buttonDeconnexion;
        private TextBox textrecherche;
        private Button buttonrecherche;
        private ComboBox combocritere;
        private Button buttonajouter;
        private DataGridView dataGridView;
        private Panel panelStatistiques;
        private Panel panelStatTotal;
        private Label labelStatTotalValeur;
        private Label labelStatTotalTitre;
        private Panel panelStatCategories;
        private Label labelStatCategoriesValeur;
        private Label labelStatCategoriesTitre;
        private Panel panelStatStock;
        private Label labelStatStockValeur;
        private Label labelStatStockTitre;
        private Panel panelStatAlertes;
        private Label labelStatAlertesValeur;
        private Label labelStatAlertesTitre;
        private Button button1;
        private DataGridViewButtonColumn Supprimer;
        private DataGridViewButtonColumn Details;
        private DataGridViewButtonColumn Modifier;
    }
}