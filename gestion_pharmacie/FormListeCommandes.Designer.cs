namespace gestion_pharmacie
{
    partial class FormListeCommandes
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
            labelTitre = new Label();
            panelMenu = new Panel();
            buttonFournisseurs = new Button();
            labelMenuTitre = new Label();
            buttonMedicaments = new Button();
            buttonCommandes = new Button();
            buttonClients = new Button();
            buttonAlertes = new Button();
            buttonDeconnexion = new Button();
            panelStatistiques = new Panel();
            panelStatTotal = new Panel();
            labelStatTotalValeur = new Label();
            labelStatTotalTitre = new Label();
            panelStatEnCours = new Panel();
            labelStatEnCoursValeur = new Label();
            labelStatEnCoursTitre = new Label();
            panelStatValidees = new Panel();
            labelStatValideesValeur = new Label();
            labelStatValideesTitre = new Label();
            panelStatLivrees = new Panel();
            labelStatLivreesValeur = new Label();
            labelStatLivreesTitre = new Label();
            panelSearch = new Panel();
            comboCritere = new ComboBox();
            textRecherche = new TextBox();
            buttonRecherche = new Button();
            buttonAjouter = new Button();
            buttonRafraichir = new Button();
            dataGridViewCommandes = new DataGridView();
            Details = new DataGridViewButtonColumn();
            Modifier = new DataGridViewButtonColumn();
            Supprimer = new DataGridViewButtonColumn();
            Facture = new DataGridViewButtonColumn();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelStatistiques.SuspendLayout();
            panelStatTotal.SuspendLayout();
            panelStatEnCours.SuspendLayout();
            panelStatValidees.SuspendLayout();
            panelStatLivrees.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(252, 248, 243);
            panelHeader.Controls.Add(labelTitre);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 4, 4, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1924, 80);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelTitre.Location = new Point(250, 25);
            labelTitre.Margin = new Padding(4, 0, 4, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(498, 54);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "📦 Liste des Commandes";
            labelTitre.Click += labelTitre_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 62, 91);
            panelMenu.Controls.Add(buttonFournisseurs);
            panelMenu.Controls.Add(labelMenuTitre);
            panelMenu.Controls.Add(buttonMedicaments);
            panelMenu.Controls.Add(buttonCommandes);
            panelMenu.Controls.Add(buttonClients);
            panelMenu.Controls.Add(buttonAlertes);
            panelMenu.Controls.Add(buttonDeconnexion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 80);
            panelMenu.Margin = new Padding(4, 4, 4, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 920);
            panelMenu.TabIndex = 1;
            // 
            // buttonFournisseurs
            // 
            buttonFournisseurs.BackColor = Color.FromArgb(34, 62, 91);
            buttonFournisseurs.Cursor = Cursors.Hand;
            buttonFournisseurs.FlatAppearance.BorderSize = 0;
            buttonFournisseurs.FlatStyle = FlatStyle.Flat;
            buttonFournisseurs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonFournisseurs.ForeColor = Color.White;
            buttonFournisseurs.Location = new Point(0, 340);
            buttonFournisseurs.Margin = new Padding(4, 4, 4, 4);
            buttonFournisseurs.Name = "buttonFournisseurs";
            buttonFournisseurs.Padding = new Padding(20, 0, 0, 0);
            buttonFournisseurs.Size = new Size(230, 55);
            buttonFournisseurs.TabIndex = 8;
            buttonFournisseurs.Text = "👥 Fournisseurs";
            buttonFournisseurs.TextAlign = ContentAlignment.MiddleLeft;
            buttonFournisseurs.UseVisualStyleBackColor = false;
            buttonFournisseurs.Click += buttonFournisseurs_Click;
            // 
            // labelMenuTitre
            // 
            labelMenuTitre.AutoSize = true;
            labelMenuTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelMenuTitre.ForeColor = Color.FromArgb(233, 244, 238);
            labelMenuTitre.Location = new Point(15, 25);
            labelMenuTitre.Margin = new Padding(4, 0, 4, 0);
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
            buttonMedicaments.Margin = new Padding(4, 4, 4, 4);
            buttonMedicaments.Name = "buttonMedicaments";
            buttonMedicaments.Padding = new Padding(20, 0, 0, 0);
            buttonMedicaments.Size = new Size(230, 55);
            buttonMedicaments.TabIndex = 1;
            buttonMedicaments.Text = "💊 Médicaments";
            buttonMedicaments.TextAlign = ContentAlignment.MiddleLeft;
            buttonMedicaments.UseVisualStyleBackColor = false;
            buttonMedicaments.Click += buttonMedicaments_Click;
            // 
            // buttonCommandes
            // 
            buttonCommandes.BackColor = Color.FromArgb(246, 145, 118);
            buttonCommandes.Cursor = Cursors.Hand;
            buttonCommandes.FlatAppearance.BorderSize = 0;
            buttonCommandes.FlatStyle = FlatStyle.Flat;
            buttonCommandes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCommandes.ForeColor = Color.White;
            buttonCommandes.Location = new Point(0, 145);
            buttonCommandes.Margin = new Padding(4, 4, 4, 4);
            buttonCommandes.Name = "buttonCommandes";
            buttonCommandes.Padding = new Padding(20, 0, 0, 0);
            buttonCommandes.Size = new Size(230, 55);
            buttonCommandes.TabIndex = 2;
            buttonCommandes.Text = "📦 Commandes";
            buttonCommandes.TextAlign = ContentAlignment.MiddleLeft;
            buttonCommandes.UseVisualStyleBackColor = false;
            buttonCommandes.Click += buttonCommandes_Click;
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
            buttonClients.Margin = new Padding(4, 4, 4, 4);
            buttonClients.Name = "buttonClients";
            buttonClients.Padding = new Padding(20, 0, 0, 0);
            buttonClients.Size = new Size(230, 55);
            buttonClients.TabIndex = 3;
            buttonClients.Text = "👥 Clients";
            buttonClients.TextAlign = ContentAlignment.MiddleLeft;
            buttonClients.UseVisualStyleBackColor = false;
            buttonClients.Click += buttonClients_Click;
            // 
            // buttonAlertes
            // 
            buttonAlertes.BackColor = Color.FromArgb(34, 62, 91);
            buttonAlertes.Cursor = Cursors.Hand;
            buttonAlertes.FlatAppearance.BorderSize = 0;
            buttonAlertes.FlatStyle = FlatStyle.Flat;
            buttonAlertes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAlertes.ForeColor = Color.White;
            buttonAlertes.Location = new Point(0, 275);
            buttonAlertes.Margin = new Padding(4, 4, 4, 4);
            buttonAlertes.Name = "buttonAlertes";
            buttonAlertes.Padding = new Padding(20, 0, 0, 0);
            buttonAlertes.Size = new Size(230, 55);
            buttonAlertes.TabIndex = 4;
            buttonAlertes.Text = "🔔 Alertes";
            buttonAlertes.TextAlign = ContentAlignment.MiddleLeft;
            buttonAlertes.UseVisualStyleBackColor = false;
            buttonAlertes.Click += buttonAlertes_Click;
            // 
            // buttonDeconnexion
            // 
            buttonDeconnexion.BackColor = Color.FromArgb(235, 203, 176);
            buttonDeconnexion.Cursor = Cursors.Hand;
            buttonDeconnexion.FlatAppearance.BorderSize = 0;
            buttonDeconnexion.FlatStyle = FlatStyle.Flat;
            buttonDeconnexion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDeconnexion.ForeColor = Color.FromArgb(34, 62, 91);
            buttonDeconnexion.Location = new Point(20, 846);
            buttonDeconnexion.Margin = new Padding(4, 4, 4, 4);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Padding = new Padding(15, 0, 0, 0);
            buttonDeconnexion.Size = new Size(184, 50);
            buttonDeconnexion.TabIndex = 7;
            buttonDeconnexion.Text = "Déconnexion";
            buttonDeconnexion.TextAlign = ContentAlignment.MiddleLeft;
            buttonDeconnexion.UseVisualStyleBackColor = false;
            // 
            // panelStatistiques
            // 
            panelStatistiques.BackColor = Color.FromArgb(242, 231, 211);
            panelStatistiques.Controls.Add(panelStatTotal);
            panelStatistiques.Controls.Add(panelStatEnCours);
            panelStatistiques.Controls.Add(panelStatValidees);
            panelStatistiques.Controls.Add(panelStatLivrees);
            panelStatistiques.Location = new Point(250, 115);
            panelStatistiques.Margin = new Padding(4, 4, 4, 4);
            panelStatistiques.Name = "panelStatistiques";
            panelStatistiques.Padding = new Padding(20, 20, 20, 20);
            panelStatistiques.Size = new Size(1700, 155);
            panelStatistiques.TabIndex = 2;
            // 
            // panelStatTotal
            // 
            panelStatTotal.BackColor = Color.FromArgb(34, 62, 91);
            panelStatTotal.Controls.Add(labelStatTotalValeur);
            panelStatTotal.Controls.Add(labelStatTotalTitre);
            panelStatTotal.Location = new Point(25, 25);
            panelStatTotal.Margin = new Padding(4, 4, 4, 4);
            panelStatTotal.Name = "panelStatTotal";
            panelStatTotal.Size = new Size(388, 105);
            panelStatTotal.TabIndex = 0;
            panelStatTotal.Paint += panelStatTotal_Paint;
            // 
            // labelStatTotalValeur
            // 
            labelStatTotalValeur.AutoSize = true;
            labelStatTotalValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatTotalValeur.ForeColor = Color.White;
            labelStatTotalValeur.Location = new Point(20, 45);
            labelStatTotalValeur.Margin = new Padding(4, 0, 4, 0);
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
            labelStatTotalTitre.Margin = new Padding(4, 0, 4, 0);
            labelStatTotalTitre.Name = "labelStatTotalTitre";
            labelStatTotalTitre.Size = new Size(235, 30);
            labelStatTotalTitre.TabIndex = 0;
            labelStatTotalTitre.Text = "📊 Total Commandes";
            // 
            // panelStatEnCours
            // 
            panelStatEnCours.BackColor = Color.FromArgb(246, 145, 118);
            panelStatEnCours.Controls.Add(labelStatEnCoursValeur);
            panelStatEnCours.Controls.Add(labelStatEnCoursTitre);
            panelStatEnCours.Location = new Point(438, 25);
            panelStatEnCours.Margin = new Padding(4, 4, 4, 4);
            panelStatEnCours.Name = "panelStatEnCours";
            panelStatEnCours.Padding = new Padding(20, 20, 20, 20);
            panelStatEnCours.Size = new Size(388, 105);
            panelStatEnCours.TabIndex = 1;
            // 
            // labelStatEnCoursValeur
            // 
            labelStatEnCoursValeur.AutoSize = true;
            labelStatEnCoursValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatEnCoursValeur.ForeColor = Color.White;
            labelStatEnCoursValeur.Location = new Point(20, 45);
            labelStatEnCoursValeur.Margin = new Padding(4, 0, 4, 0);
            labelStatEnCoursValeur.Name = "labelStatEnCoursValeur";
            labelStatEnCoursValeur.Size = new Size(50, 60);
            labelStatEnCoursValeur.TabIndex = 1;
            labelStatEnCoursValeur.Text = "0";
            // 
            // labelStatEnCoursTitre
            // 
            labelStatEnCoursTitre.AutoSize = true;
            labelStatEnCoursTitre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelStatEnCoursTitre.ForeColor = Color.White;
            labelStatEnCoursTitre.Location = new Point(20, 15);
            labelStatEnCoursTitre.Margin = new Padding(4, 0, 4, 0);
            labelStatEnCoursTitre.Name = "labelStatEnCoursTitre";
            labelStatEnCoursTitre.Size = new Size(137, 30);
            labelStatEnCoursTitre.TabIndex = 0;
            labelStatEnCoursTitre.Text = "⏳ En cours";
            // 
            // panelStatValidees
            // 
            panelStatValidees.BackColor = Color.FromArgb(233, 244, 238);
            panelStatValidees.Controls.Add(labelStatValideesValeur);
            panelStatValidees.Controls.Add(labelStatValideesTitre);
            panelStatValidees.Location = new Point(850, 25);
            panelStatValidees.Margin = new Padding(4, 4, 4, 4);
            panelStatValidees.Name = "panelStatValidees";
            panelStatValidees.Padding = new Padding(20, 20, 20, 20);
            panelStatValidees.Size = new Size(388, 105);
            panelStatValidees.TabIndex = 2;
            // 
            // labelStatValideesValeur
            // 
            labelStatValideesValeur.AutoSize = true;
            labelStatValideesValeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelStatValideesValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatValideesValeur.Location = new Point(20, 45);
            labelStatValideesValeur.Margin = new Padding(4, 0, 4, 0);
            labelStatValideesValeur.Name = "labelStatValideesValeur";
            labelStatValideesValeur.Size = new Size(50, 60);
            labelStatValideesValeur.TabIndex = 1;
            labelStatValideesValeur.Text = "0";
            // 
            // labelStatValideesTitre
            // 
            labelStatValideesTitre.AutoSize = true;
            labelStatValideesTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatValideesTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatValideesTitre.Location = new Point(20, 15);
            labelStatValideesTitre.Margin = new Padding(4, 0, 4, 0);
            labelStatValideesTitre.Name = "labelStatValideesTitre";
            labelStatValideesTitre.Size = new Size(123, 28);
            labelStatValideesTitre.TabIndex = 0;
            labelStatValideesTitre.Text = "✅ Validées";
            // 
            // panelStatLivrees
            // 
            panelStatLivrees.BackColor = Color.FromArgb(235, 203, 176);
            panelStatLivrees.Controls.Add(labelStatLivreesValeur);
            panelStatLivrees.Controls.Add(labelStatLivreesTitre);
            panelStatLivrees.Location = new Point(1262, 25);
            panelStatLivrees.Margin = new Padding(4, 4, 4, 4);
            panelStatLivrees.Name = "panelStatLivrees";
            panelStatLivrees.Padding = new Padding(20, 20, 20, 20);
            panelStatLivrees.Size = new Size(388, 105);
            panelStatLivrees.TabIndex = 3;
            // 
            // labelStatLivreesValeur
            // 
            labelStatLivreesValeur.AutoSize = true;
            labelStatLivreesValeur.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelStatLivreesValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatLivreesValeur.Location = new Point(20, 45);
            labelStatLivreesValeur.Margin = new Padding(4, 0, 4, 0);
            labelStatLivreesValeur.Name = "labelStatLivreesValeur";
            labelStatLivreesValeur.Size = new Size(46, 54);
            labelStatLivreesValeur.TabIndex = 1;
            labelStatLivreesValeur.Text = "0";
            // 
            // labelStatLivreesTitre
            // 
            labelStatLivreesTitre.AutoSize = true;
            labelStatLivreesTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatLivreesTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatLivreesTitre.Location = new Point(20, 15);
            labelStatLivreesTitre.Margin = new Padding(4, 0, 4, 0);
            labelStatLivreesTitre.Name = "labelStatLivreesTitre";
            labelStatLivreesTitre.Size = new Size(112, 28);
            labelStatLivreesTitre.TabIndex = 0;
            labelStatLivreesTitre.Text = "🚚 Livrées";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(comboCritere);
            panelSearch.Controls.Add(textRecherche);
            panelSearch.Controls.Add(buttonRecherche);
            panelSearch.Controls.Add(buttonAjouter);
            panelSearch.Controls.Add(buttonRafraichir);
            panelSearch.Location = new Point(250, 290);
            panelSearch.Margin = new Padding(4, 4, 4, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(25, 25, 25, 25);
            panelSearch.Size = new Size(1661, 110);
            panelSearch.TabIndex = 3;
            // 
            // comboCritere
            // 
            comboCritere.BackColor = Color.FromArgb(252, 248, 243);
            comboCritere.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCritere.FlatStyle = FlatStyle.Flat;
            comboCritere.Font = new Font("Segoe UI", 10F);
            comboCritere.ForeColor = Color.FromArgb(34, 62, 91);
            comboCritere.FormattingEnabled = true;
            comboCritere.Items.AddRange(new object[] { "Client", "CIN", "Statut", "Date" });
            comboCritere.Location = new Point(25, 25);
            comboCritere.Margin = new Padding(4, 4, 4, 4);
            comboCritere.Name = "comboCritere";
            comboCritere.Size = new Size(250, 36);
            comboCritere.TabIndex = 0;
            // 
            // textRecherche
            // 
            textRecherche.BackColor = Color.FromArgb(252, 248, 243);
            textRecherche.BorderStyle = BorderStyle.None;
            textRecherche.Font = new Font("Segoe UI", 11F);
            textRecherche.ForeColor = Color.FromArgb(34, 62, 91);
            textRecherche.Location = new Point(295, 25);
            textRecherche.Margin = new Padding(4, 4, 4, 4);
            textRecherche.Name = "textRecherche";
            textRecherche.PlaceholderText = "Rechercher...";
            textRecherche.Size = new Size(500, 30);
            textRecherche.TabIndex = 1;
            textRecherche.TextChanged += textRecherche_TextChanged;
            // 
            // buttonRecherche
            // 
            buttonRecherche.BackColor = Color.FromArgb(34, 62, 91);
            buttonRecherche.Cursor = Cursors.Hand;
            buttonRecherche.FlatAppearance.BorderSize = 0;
            buttonRecherche.FlatStyle = FlatStyle.Flat;
            buttonRecherche.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRecherche.ForeColor = Color.White;
            buttonRecherche.Location = new Point(815, 22);
            buttonRecherche.Margin = new Padding(4, 4, 4, 4);
            buttonRecherche.Name = "buttonRecherche";
            buttonRecherche.Size = new Size(200, 45);
            buttonRecherche.TabIndex = 2;
            buttonRecherche.Text = "🔍 Rechercher";
            buttonRecherche.UseVisualStyleBackColor = false;
            buttonRecherche.Click += buttonRecherche_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = Color.FromArgb(246, 145, 118);
            buttonAjouter.Cursor = Cursors.Hand;
            buttonAjouter.FlatAppearance.BorderSize = 0;
            buttonAjouter.FlatStyle = FlatStyle.Flat;
            buttonAjouter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAjouter.ForeColor = Color.White;
            buttonAjouter.Location = new Point(1179, 22);
            buttonAjouter.Margin = new Padding(4, 4, 4, 4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(238, 45);
            buttonAjouter.TabIndex = 3;
            buttonAjouter.Text = "➕ Nouvelle Commande";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonRafraichir
            // 
            buttonRafraichir.BackColor = Color.FromArgb(233, 244, 238);
            buttonRafraichir.Cursor = Cursors.Hand;
            buttonRafraichir.FlatAppearance.BorderSize = 0;
            buttonRafraichir.FlatStyle = FlatStyle.Flat;
            buttonRafraichir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRafraichir.ForeColor = Color.FromArgb(34, 62, 91);
            buttonRafraichir.Location = new Point(1450, 22);
            buttonRafraichir.Margin = new Padding(4, 4, 4, 4);
            buttonRafraichir.Name = "buttonRafraichir";
            buttonRafraichir.Size = new Size(194, 45);
            buttonRafraichir.TabIndex = 4;
            buttonRafraichir.Text = "🔄 Rafraîchir";
            buttonRafraichir.UseVisualStyleBackColor = false;
            buttonRafraichir.Click += ButtonRafraichir_Click;
            // 
            // dataGridViewCommandes
            // 
            dataGridViewCommandes.AllowUserToAddRows = false;
            dataGridViewCommandes.AllowUserToDeleteRows = false;
            dataGridViewCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCommandes.BackgroundColor = Color.White;
            dataGridViewCommandes.BorderStyle = BorderStyle.None;
            dataGridViewCommandes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCommandes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCommandes.ColumnHeadersHeight = 50;
            dataGridViewCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCommandes.Columns.AddRange(new DataGridViewColumn[] { Details, Modifier, Supprimer, Facture });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.Padding = new Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(233, 244, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCommandes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCommandes.EnableHeadersVisualStyles = false;
            dataGridViewCommandes.GridColor = Color.FromArgb(233, 244, 238);
            dataGridViewCommandes.Location = new Point(250, 414);
            dataGridViewCommandes.Margin = new Padding(4, 4, 4, 4);
            dataGridViewCommandes.Name = "dataGridViewCommandes";
            dataGridViewCommandes.ReadOnly = true;
            dataGridViewCommandes.RowHeadersVisible = false;
            dataGridViewCommandes.RowHeadersWidth = 51;
            dataGridViewCommandes.RowTemplate.Height = 45;
            dataGridViewCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCommandes.Size = new Size(1661, 562);
            dataGridViewCommandes.TabIndex = 4;
            dataGridViewCommandes.CellContentClick += dataGridViewCommandes_CellContentClick;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Details.FlatStyle = FlatStyle.Flat;
            Details.HeaderText = "Détails";
            Details.MinimumWidth = 120;
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Text = "👁️";
            Details.ToolTipText = "Voir détails";
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
            // Supprimer
            // 
            Supprimer.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Supprimer.FlatStyle = FlatStyle.Flat;
            Supprimer.HeaderText = "Supprimer";
            Supprimer.MinimumWidth = 120;
            Supprimer.Name = "Supprimer";
            Supprimer.ReadOnly = true;
            Supprimer.Text = "🗑️";
            Supprimer.ToolTipText = "Supprimer";
            Supprimer.UseColumnTextForButtonValue = true;
            Supprimer.Width = 120;
            // 
            // Facture
            // 
            Facture.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Facture.FlatStyle = FlatStyle.Flat;
            Facture.HeaderText = "Facture";
            Facture.MinimumWidth = 120;
            Facture.Name = "Facture";
            Facture.ReadOnly = true;
            Facture.Text = "Facture";
            Facture.UseColumnTextForButtonValue = true;
            Facture.Width = 140;
            // 
            // FormListeCommandes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 231, 211);
            ClientSize = new Size(1924, 1000);
            Controls.Add(dataGridViewCommandes);
            Controls.Add(panelSearch);
            Controls.Add(panelStatistiques);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormListeCommandes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Liste des Commandes";
            WindowState = FormWindowState.Maximized;
            Load += FormListeCommandes_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelStatistiques.ResumeLayout(false);
            panelStatTotal.ResumeLayout(false);
            panelStatTotal.PerformLayout();
            panelStatEnCours.ResumeLayout(false);
            panelStatEnCours.PerformLayout();
            panelStatValidees.ResumeLayout(false);
            panelStatValidees.PerformLayout();
            panelStatLivrees.ResumeLayout(false);
            panelStatLivrees.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).EndInit();
            ResumeLayout(false);

        }

        private void ButtonRafraichir_Click(object sender, EventArgs e)
        {
            ChargerCommandes();
            ChargerStatistiques();
            textRecherche.Clear();
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitre;
        private Panel panelMenu;
        private Label labelMenuTitre;
        private Button buttonMedicaments;
        private Button buttonCommandes;
        private Button buttonClients;
        private Button buttonAlertes;
        private Button buttonDeconnexion;
        private Panel panelStatistiques;
        private Panel panelStatTotal;
        private Label labelStatTotalValeur;
        private Label labelStatTotalTitre;
        private Panel panelStatEnCours;
        private Label labelStatEnCoursValeur;
        private Label labelStatEnCoursTitre;
        private Panel panelStatValidees;
        private Label labelStatValideesValeur;
        private Label labelStatValideesTitre;
        private Panel panelStatLivrees;
        private Label labelStatLivreesValeur;
        private Label labelStatLivreesTitre;
        private Panel panelSearch;
        private ComboBox comboCritere;
        private TextBox textRecherche;
        private Button buttonRecherche;
        private Button buttonAjouter;
        private Button buttonRafraichir;
        private DataGridView dataGridViewCommandes;
        private DataGridViewButtonColumn Details;
        private DataGridViewButtonColumn Modifier;
        private DataGridViewButtonColumn Supprimer;
        private DataGridViewButtonColumn Facture;
        private Button buttonFournisseurs;
    }
}