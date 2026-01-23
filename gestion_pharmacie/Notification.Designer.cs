namespace gestion_pharmacie
{
    partial class Notification
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
            panelStatCritique = new Panel();
            labelStatCritiqueValeur = new Label();
            labelStatCritiqueTitre = new Label();
            panelStatUrgent = new Panel();
            labelStatUrgentValeur = new Label();
            labelStatUrgentTitre = new Label();
            panelStatAttention = new Panel();
            labelStatAttentionValeur = new Label();
            labelStatAttentionTitre = new Label();
            panelFiltre = new Panel();
            labelFiltre = new Label();
            comboNiveau = new ComboBox();
            buttonActualiser = new Button();
            dataGridViewAlertes = new DataGridView();
            panelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            panelStatistiques.SuspendLayout();
            panelStatCritique.SuspendLayout();
            panelStatUrgent.SuspendLayout();
            panelStatAttention.SuspendLayout();
            panelFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlertes).BeginInit();
            SuspendLayout();
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
            panelMenu.Location = new Point(0, 64);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(196, 650);
            panelMenu.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 62, 91);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(233, 244, 238);
            button1.Location = new Point(11, 244);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(183, 40);
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
            labelMenuTitre.ForeColor = Color.FromArgb(252, 248, 243);
            labelMenuTitre.Location = new Point(6, 16);
            labelMenuTitre.Margin = new Padding(2, 0, 2, 0);
            labelMenuTitre.Name = "labelMenuTitre";
            labelMenuTitre.Size = new Size(151, 28);
            labelMenuTitre.TabIndex = 0;
            labelMenuTitre.Text = "🗂️ Navigation";
            // 
            // buttonMedicaments
            // 
            buttonMedicaments.BackColor = Color.FromArgb(34, 62, 91);
            buttonMedicaments.Cursor = Cursors.Hand;
            buttonMedicaments.FlatAppearance.BorderSize = 0;
            buttonMedicaments.FlatStyle = FlatStyle.Flat;
            buttonMedicaments.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonMedicaments.ForeColor = Color.FromArgb(233, 244, 238);
            buttonMedicaments.Location = new Point(11, 56);
            buttonMedicaments.Margin = new Padding(2);
            buttonMedicaments.Name = "buttonMedicaments";
            buttonMedicaments.Padding = new Padding(12, 0, 0, 0);
            buttonMedicaments.Size = new Size(178, 40);
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
            buttonCommande.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonCommande.ForeColor = Color.FromArgb(233, 244, 238);
            buttonCommande.Location = new Point(10, 104);
            buttonCommande.Margin = new Padding(2);
            buttonCommande.Name = "buttonCommande";
            buttonCommande.Padding = new Padding(12, 0, 0, 0);
            buttonCommande.Size = new Size(170, 40);
            buttonCommande.TabIndex = 2;
            buttonCommande.Text = "📦 Commandes";
            buttonCommande.TextAlign = ContentAlignment.MiddleLeft;
            buttonCommande.UseVisualStyleBackColor = false;
            buttonCommande.Click += buttonCommande_Click;
            // 
            // buttonClients
            // 
            buttonClients.BackColor = Color.FromArgb(34, 62, 91);
            buttonClients.Cursor = Cursors.Hand;
            buttonClients.FlatAppearance.BorderSize = 0;
            buttonClients.FlatStyle = FlatStyle.Flat;
            buttonClients.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonClients.ForeColor = Color.FromArgb(233, 244, 238);
            buttonClients.Location = new Point(12, 152);
            buttonClients.Margin = new Padding(2);
            buttonClients.Name = "buttonClients";
            buttonClients.Padding = new Padding(12, 0, 0, 0);
            buttonClients.Size = new Size(169, 40);
            buttonClients.TabIndex = 3;
            buttonClients.Text = "👥 Clients";
            buttonClients.TextAlign = ContentAlignment.MiddleLeft;
            buttonClients.UseVisualStyleBackColor = false;
            buttonClients.Click += buttonClients_Click;
            // 
            // buttonNotification
            // 
            buttonNotification.BackColor = Color.FromArgb(246, 145, 118);
            buttonNotification.Cursor = Cursors.Hand;
            buttonNotification.FlatAppearance.BorderSize = 0;
            buttonNotification.FlatStyle = FlatStyle.Flat;
            buttonNotification.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonNotification.ForeColor = Color.White;
            buttonNotification.Location = new Point(11, 200);
            buttonNotification.Margin = new Padding(2);
            buttonNotification.Name = "buttonNotification";
            buttonNotification.Padding = new Padding(12, 0, 0, 0);
            buttonNotification.Size = new Size(167, 40);
            buttonNotification.TabIndex = 4;
            buttonNotification.Text = "🔔 Alertes";
            buttonNotification.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotification.UseVisualStyleBackColor = false;
            // 
            // buttonDeconnexion
            // 
            buttonDeconnexion.BackColor = Color.FromArgb(235, 203, 176);
            buttonDeconnexion.Cursor = Cursors.Hand;
            buttonDeconnexion.FlatAppearance.BorderSize = 0;
            buttonDeconnexion.FlatStyle = FlatStyle.Flat;
            buttonDeconnexion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonDeconnexion.ForeColor = Color.FromArgb(34, 62, 91);
            buttonDeconnexion.Location = new Point(23, 599);
            buttonDeconnexion.Margin = new Padding(2);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Padding = new Padding(12, 0, 0, 0);
            buttonDeconnexion.Size = new Size(155, 40);
            buttonDeconnexion.TabIndex = 7;
            buttonDeconnexion.Text = "Déconnexion";
            buttonDeconnexion.TextAlign = ContentAlignment.MiddleLeft;
            buttonDeconnexion.UseVisualStyleBackColor = false;
            buttonDeconnexion.Click += buttonDeconnexion_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(34, 62, 91);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1539, 64);
            panelHeader.TabIndex = 17;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(252, 248, 243);
            label1.Location = new Point(192, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 1;
            label1.Text = "🔔 Alertes Stock";
            // 
            // panelStatistiques
            // 
            panelStatistiques.BackColor = Color.FromArgb(252, 248, 243);
            panelStatistiques.Controls.Add(panelStatCritique);
            panelStatistiques.Controls.Add(panelStatUrgent);
            panelStatistiques.Controls.Add(panelStatAttention);
            panelStatistiques.Location = new Point(200, 80);
            panelStatistiques.Margin = new Padding(2);
            panelStatistiques.Name = "panelStatistiques";
            panelStatistiques.Size = new Size(1320, 96);
            panelStatistiques.TabIndex = 20;
            // 
            // panelStatCritique
            // 
            panelStatCritique.BackColor = Color.FromArgb(246, 145, 118);
            panelStatCritique.Controls.Add(labelStatCritiqueValeur);
            panelStatCritique.Controls.Add(labelStatCritiqueTitre);
            panelStatCritique.Location = new Point(16, 12);
            panelStatCritique.Margin = new Padding(2);
            panelStatCritique.Name = "panelStatCritique";
            panelStatCritique.Size = new Size(416, 72);
            panelStatCritique.TabIndex = 0;
            // 
            // labelStatCritiqueValeur
            // 
            labelStatCritiqueValeur.AutoSize = true;
            labelStatCritiqueValeur.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelStatCritiqueValeur.ForeColor = Color.White;
            labelStatCritiqueValeur.Location = new Point(12, 32);
            labelStatCritiqueValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatCritiqueValeur.Name = "labelStatCritiqueValeur";
            labelStatCritiqueValeur.Size = new Size(40, 46);
            labelStatCritiqueValeur.TabIndex = 1;
            labelStatCritiqueValeur.Text = "0";
            // 
            // labelStatCritiqueTitre
            // 
            labelStatCritiqueTitre.AutoSize = true;
            labelStatCritiqueTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatCritiqueTitre.ForeColor = Color.White;
            labelStatCritiqueTitre.Location = new Point(12, 12);
            labelStatCritiqueTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatCritiqueTitre.Name = "labelStatCritiqueTitre";
            labelStatCritiqueTitre.Size = new Size(209, 23);
            labelStatCritiqueTitre.TabIndex = 0;
            labelStatCritiqueTitre.Text = "🚨 CRITIQUE (Stock = 0)";
            // 
            // panelStatUrgent
            // 
            panelStatUrgent.BackColor = Color.FromArgb(235, 203, 176);
            panelStatUrgent.Controls.Add(labelStatUrgentValeur);
            panelStatUrgent.Controls.Add(labelStatUrgentTitre);
            panelStatUrgent.Location = new Point(456, 12);
            panelStatUrgent.Margin = new Padding(2);
            panelStatUrgent.Name = "panelStatUrgent";
            panelStatUrgent.Size = new Size(416, 72);
            panelStatUrgent.TabIndex = 1;
            // 
            // labelStatUrgentValeur
            // 
            labelStatUrgentValeur.AutoSize = true;
            labelStatUrgentValeur.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelStatUrgentValeur.ForeColor = Color.White;
            labelStatUrgentValeur.Location = new Point(12, 32);
            labelStatUrgentValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatUrgentValeur.Name = "labelStatUrgentValeur";
            labelStatUrgentValeur.Size = new Size(40, 46);
            labelStatUrgentValeur.TabIndex = 1;
            labelStatUrgentValeur.Text = "0";
            // 
            // labelStatUrgentTitre
            // 
            labelStatUrgentTitre.AutoSize = true;
            labelStatUrgentTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatUrgentTitre.ForeColor = Color.White;
            labelStatUrgentTitre.Location = new Point(12, 12);
            labelStatUrgentTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatUrgentTitre.Name = "labelStatUrgentTitre";
            labelStatUrgentTitre.Size = new Size(266, 23);
            labelStatUrgentTitre.TabIndex = 0;
            labelStatUrgentTitre.Text = "⚠️ URGENT (Stock ≤ 50% seuil)";
            // 
            // panelStatAttention
            // 
            panelStatAttention.BackColor = Color.FromArgb(242, 231, 211);
            panelStatAttention.Controls.Add(labelStatAttentionValeur);
            panelStatAttention.Controls.Add(labelStatAttentionTitre);
            panelStatAttention.Location = new Point(896, 12);
            panelStatAttention.Margin = new Padding(2);
            panelStatAttention.Name = "panelStatAttention";
            panelStatAttention.Size = new Size(408, 72);
            panelStatAttention.TabIndex = 2;
            // 
            // labelStatAttentionValeur
            // 
            labelStatAttentionValeur.AutoSize = true;
            labelStatAttentionValeur.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelStatAttentionValeur.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatAttentionValeur.Location = new Point(12, 32);
            labelStatAttentionValeur.Margin = new Padding(2, 0, 2, 0);
            labelStatAttentionValeur.Name = "labelStatAttentionValeur";
            labelStatAttentionValeur.Size = new Size(40, 46);
            labelStatAttentionValeur.TabIndex = 1;
            labelStatAttentionValeur.Text = "0";
            // 
            // labelStatAttentionTitre
            // 
            labelStatAttentionTitre.AutoSize = true;
            labelStatAttentionTitre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatAttentionTitre.ForeColor = Color.FromArgb(34, 62, 91);
            labelStatAttentionTitre.Location = new Point(12, 12);
            labelStatAttentionTitre.Margin = new Padding(2, 0, 2, 0);
            labelStatAttentionTitre.Name = "labelStatAttentionTitre";
            labelStatAttentionTitre.Size = new Size(253, 23);
            labelStatAttentionTitre.TabIndex = 0;
            labelStatAttentionTitre.Text = "⚡ ATTENTION (Stock ≤ seuil)";
            // 
            // panelFiltre
            // 
            panelFiltre.BackColor = Color.White;
            panelFiltre.Controls.Add(labelFiltre);
            panelFiltre.Controls.Add(comboNiveau);
            panelFiltre.Controls.Add(buttonActualiser);
            panelFiltre.Location = new Point(200, 192);
            panelFiltre.Margin = new Padding(2);
            panelFiltre.Name = "panelFiltre";
            panelFiltre.Padding = new Padding(16, 16, 16, 16);
            panelFiltre.Size = new Size(1336, 64);
            panelFiltre.TabIndex = 21;
            // 
            // labelFiltre
            // 
            labelFiltre.AutoSize = true;
            labelFiltre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelFiltre.ForeColor = Color.FromArgb(34, 62, 91);
            labelFiltre.Location = new Point(16, 22);
            labelFiltre.Margin = new Padding(2, 0, 2, 0);
            labelFiltre.Name = "labelFiltre";
            labelFiltre.Size = new Size(149, 23);
            labelFiltre.TabIndex = 0;
            labelFiltre.Text = "Filtrer par niveau :";
            // 
            // comboNiveau
            // 
            comboNiveau.BackColor = Color.FromArgb(252, 248, 243);
            comboNiveau.DropDownStyle = ComboBoxStyle.DropDownList;
            comboNiveau.FlatStyle = FlatStyle.Flat;
            comboNiveau.Font = new Font("Segoe UI", 10F);
            comboNiveau.FormattingEnabled = true;
            comboNiveau.Items.AddRange(new object[] { "Tous", "Critique", "Urgent", "Attention" });
            comboNiveau.Location = new Point(176, 20);
            comboNiveau.Margin = new Padding(2);
            comboNiveau.Name = "comboNiveau";
            comboNiveau.Size = new Size(201, 31);
            comboNiveau.TabIndex = 1;
            comboNiveau.SelectedIndexChanged += comboNiveau_SelectedIndexChanged;
            // 
            // buttonActualiser
            // 
            buttonActualiser.BackColor = Color.FromArgb(233, 244, 238);
            buttonActualiser.Cursor = Cursors.Hand;
            buttonActualiser.FlatAppearance.BorderSize = 0;
            buttonActualiser.FlatStyle = FlatStyle.Flat;
            buttonActualiser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonActualiser.ForeColor = Color.FromArgb(34, 62, 91);
            buttonActualiser.Location = new Point(400, 18);
            buttonActualiser.Margin = new Padding(2);
            buttonActualiser.Name = "buttonActualiser";
            buttonActualiser.Size = new Size(120, 34);
            buttonActualiser.TabIndex = 2;
            buttonActualiser.Text = "🔄 Actualiser";
            buttonActualiser.UseVisualStyleBackColor = false;
            buttonActualiser.Click += buttonActualiser_Click;
            // 
            // dataGridViewAlertes
            // 
            dataGridViewAlertes.AllowUserToAddRows = false;
            dataGridViewAlertes.AllowUserToDeleteRows = false;
            dataGridViewAlertes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlertes.BackgroundColor = Color.White;
            dataGridViewAlertes.BorderStyle = BorderStyle.None;
            dataGridViewAlertes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAlertes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(252, 248, 243);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 248, 243);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAlertes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAlertes.ColumnHeadersHeight = 45;
            dataGridViewAlertes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(233, 244, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 62, 91);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAlertes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAlertes.EnableHeadersVisualStyles = false;
            dataGridViewAlertes.GridColor = Color.FromArgb(233, 244, 238);
            dataGridViewAlertes.Location = new Point(202, 264);
            dataGridViewAlertes.Margin = new Padding(2);
            dataGridViewAlertes.Name = "dataGridViewAlertes";
            dataGridViewAlertes.ReadOnly = true;
            dataGridViewAlertes.RowHeadersVisible = false;
            dataGridViewAlertes.RowHeadersWidth = 62;
            dataGridViewAlertes.RowTemplate.Height = 40;
            dataGridViewAlertes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlertes.Size = new Size(1330, 336);
            dataGridViewAlertes.TabIndex = 22;
            dataGridViewAlertes.CellContentClick += dataGridViewAlertes_CellContentClick;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 243);
            ClientSize = new Size(1539, 714);
            Controls.Add(dataGridViewAlertes);
            Controls.Add(panelFiltre);
            Controls.Add(panelStatistiques);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Margin = new Padding(2);
            Name = "Notification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Alertes Stock";
            WindowState = FormWindowState.Maximized;
            Load += Notification_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStatistiques.ResumeLayout(false);
            panelStatCritique.ResumeLayout(false);
            panelStatCritique.PerformLayout();
            panelStatUrgent.ResumeLayout(false);
            panelStatUrgent.PerformLayout();
            panelStatAttention.ResumeLayout(false);
            panelStatAttention.PerformLayout();
            panelFiltre.ResumeLayout(false);
            panelFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlertes).EndInit();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panelStatCritique;
        private Label labelStatCritiqueValeur;
        private Label labelStatCritiqueTitre;
        private Panel panelStatUrgent;
        private Label labelStatUrgentValeur;
        private Label labelStatUrgentTitre;
        private Panel panelStatAttention;
        private Label labelStatAttentionValeur;
        private Label labelStatAttentionTitre;
        private Panel panelFiltre;
        private Label labelFiltre;
        private ComboBox comboNiveau;
        private Button buttonActualiser;
        private DataGridView dataGridViewAlertes;
        private Button button1;
    }
}