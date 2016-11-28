namespace gestionstage.Forms
{
    partial class ListEntreprise
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mSMListEntreprise = new MetroFramework.Components.MetroStyleManager(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.mMenuSettings = new MetroFramework.Controls.MetroTabPage();
            this.mButtonConfirmPull = new MetroFramework.Controls.MetroTile();
            this.mLabelPull = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mButtonConfirmColor = new MetroFramework.Controls.MetroTile();
            this.mLabelChooseColor = new MetroFramework.Controls.MetroLabel();
            this.mButtonConfirmPush = new MetroFramework.Controls.MetroTile();
            this.ConteneurCouleurs = new System.Windows.Forms.FlowLayoutPanel();
            this.mLabelPush = new MetroFramework.Controls.MetroLabel();
            this.mMenuEntreprise = new MetroFramework.Controls.MetroTabPage();
            this.mGridEntreprises = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.mButtonAddEntreprise = new MetroFramework.Controls.MetroTile();
            this.mTBSearch = new MetroFramework.Controls.MetroTextBox();
            this.mMenu = new MetroFramework.Controls.MetroTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.mSMListEntreprise)).BeginInit();
            this.mMenuSettings.SuspendLayout();
            this.mMenuEntreprise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridEntreprises)).BeginInit();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMListEntreprise
            // 
            this.mSMListEntreprise.Owner = this;
            this.mSMListEntreprise.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewImageColumn1.HeaderText = "Modifier";
            this.dataGridViewImageColumn1.Image = global::gestionstage.Properties.Resources.tab_modifier;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 55;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Modifier";
            this.dataGridViewImageColumn2.Image = global::gestionstage.Properties.Resources.tab_modifier;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 55;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Supprimer";
            this.dataGridViewImageColumn3.Image = global::gestionstage.Properties.Resources.tab_supprimer;
            this.dataGridViewImageColumn3.MinimumWidth = 50;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 55;
            // 
            // mMenuSettings
            // 
            this.mMenuSettings.Controls.Add(this.mButtonConfirmPull);
            this.mMenuSettings.Controls.Add(this.mLabelPull);
            this.mMenuSettings.Controls.Add(this.metroTile1);
            this.mMenuSettings.Controls.Add(this.mButtonConfirmColor);
            this.mMenuSettings.Controls.Add(this.mLabelChooseColor);
            this.mMenuSettings.Controls.Add(this.mButtonConfirmPush);
            this.mMenuSettings.Controls.Add(this.ConteneurCouleurs);
            this.mMenuSettings.Controls.Add(this.mLabelPush);
            this.mMenuSettings.HorizontalScrollbarBarColor = true;
            this.mMenuSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mMenuSettings.HorizontalScrollbarSize = 10;
            this.mMenuSettings.Location = new System.Drawing.Point(4, 38);
            this.mMenuSettings.Name = "mMenuSettings";
            this.mMenuSettings.Size = new System.Drawing.Size(968, 677);
            this.mMenuSettings.TabIndex = 1;
            this.mMenuSettings.Text = "&Paramètres";
            this.mMenuSettings.VerticalScrollbarBarColor = true;
            this.mMenuSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mMenuSettings.VerticalScrollbarSize = 10;
            // 
            // mButtonConfirmPull
            // 
            this.mButtonConfirmPull.ActiveControl = null;
            this.mButtonConfirmPull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonConfirmPull.Location = new System.Drawing.Point(230, 70);
            this.mButtonConfirmPull.Name = "mButtonConfirmPull";
            this.mButtonConfirmPull.Size = new System.Drawing.Size(736, 50);
            this.mButtonConfirmPull.TabIndex = 9;
            this.mButtonConfirmPull.Text = "Récupérer les Modifications";
            this.mButtonConfirmPull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonConfirmPull.UseSelectable = true;
            // 
            // mLabelPull
            // 
            this.mLabelPull.AutoSize = true;
            this.mLabelPull.Location = new System.Drawing.Point(5, 80);
            this.mLabelPull.Name = "mLabelPull";
            this.mLabelPull.Size = new System.Drawing.Size(116, 19);
            this.mLabelPull.TabIndex = 8;
            this.mLabelPull.Text = "Mise à jours BDD :";
            this.mLabelPull.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(4, 135);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(961, 10);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // mButtonConfirmColor
            // 
            this.mButtonConfirmColor.ActiveControl = null;
            this.mButtonConfirmColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonConfirmColor.Location = new System.Drawing.Point(230, 160);
            this.mButtonConfirmColor.Name = "mButtonConfirmColor";
            this.mButtonConfirmColor.Size = new System.Drawing.Size(736, 50);
            this.mButtonConfirmColor.TabIndex = 6;
            this.mButtonConfirmColor.Text = "Confirmer la couleur";
            this.mButtonConfirmColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonConfirmColor.UseSelectable = true;
            // 
            // mLabelChooseColor
            // 
            this.mLabelChooseColor.AutoSize = true;
            this.mLabelChooseColor.Location = new System.Drawing.Point(5, 170);
            this.mLabelChooseColor.Name = "mLabelChooseColor";
            this.mLabelChooseColor.Size = new System.Drawing.Size(218, 19);
            this.mLabelChooseColor.TabIndex = 5;
            this.mLabelChooseColor.Text = "Choisissez la couleur de l\'interface : ";
            this.mLabelChooseColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mButtonConfirmPush
            // 
            this.mButtonConfirmPush.ActiveControl = null;
            this.mButtonConfirmPush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonConfirmPush.Location = new System.Drawing.Point(230, 5);
            this.mButtonConfirmPush.Name = "mButtonConfirmPush";
            this.mButtonConfirmPush.Size = new System.Drawing.Size(736, 50);
            this.mButtonConfirmPush.TabIndex = 4;
            this.mButtonConfirmPush.Text = "Envoyer les Modifications";
            this.mButtonConfirmPush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonConfirmPush.UseSelectable = true;
            this.mButtonConfirmPush.Click += new System.EventHandler(this.mButtonConfirmColor_Click);
            // 
            // ConteneurCouleurs
            // 
            this.ConteneurCouleurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConteneurCouleurs.AutoScroll = true;
            this.ConteneurCouleurs.Location = new System.Drawing.Point(4, 224);
            this.ConteneurCouleurs.Name = "ConteneurCouleurs";
            this.ConteneurCouleurs.Size = new System.Drawing.Size(961, 453);
            this.ConteneurCouleurs.TabIndex = 3;
            // 
            // mLabelPush
            // 
            this.mLabelPush.AutoSize = true;
            this.mLabelPush.Location = new System.Drawing.Point(5, 20);
            this.mLabelPush.Name = "mLabelPush";
            this.mLabelPush.Size = new System.Drawing.Size(196, 19);
            this.mLabelPush.TabIndex = 2;
            this.mLabelPush.Text = "Fin de période de recrutement :";
            this.mLabelPush.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mMenuEntreprise
            // 
            this.mMenuEntreprise.Controls.Add(this.mGridEntreprises);
            this.mMenuEntreprise.Controls.Add(this.mButtonAddEntreprise);
            this.mMenuEntreprise.Controls.Add(this.mTBSearch);
            this.mMenuEntreprise.HorizontalScrollbarBarColor = true;
            this.mMenuEntreprise.HorizontalScrollbarHighlightOnWheel = false;
            this.mMenuEntreprise.HorizontalScrollbarSize = 10;
            this.mMenuEntreprise.Location = new System.Drawing.Point(4, 38);
            this.mMenuEntreprise.Name = "mMenuEntreprise";
            this.mMenuEntreprise.Size = new System.Drawing.Size(968, 677);
            this.mMenuEntreprise.TabIndex = 0;
            this.mMenuEntreprise.Text = "Affichage des entreprises";
            this.mMenuEntreprise.UseStyleColors = true;
            this.mMenuEntreprise.VerticalScrollbarBarColor = true;
            this.mMenuEntreprise.VerticalScrollbarHighlightOnWheel = false;
            this.mMenuEntreprise.VerticalScrollbarSize = 10;
            // 
            // mGridEntreprises
            // 
            this.mGridEntreprises.AllowUserToAddRows = false;
            this.mGridEntreprises.AllowUserToDeleteRows = false;
            this.mGridEntreprises.AllowUserToResizeRows = false;
            this.mGridEntreprises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGridEntreprises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridEntreprises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridEntreprises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridEntreprises.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridEntreprises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.mGridEntreprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridEntreprises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridEntreprises.DefaultCellStyle = dataGridViewCellStyle16;
            this.mGridEntreprises.EnableHeadersVisualStyles = false;
            this.mGridEntreprises.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridEntreprises.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridEntreprises.Location = new System.Drawing.Point(-2, 110);
            this.mGridEntreprises.Name = "mGridEntreprises";
            this.mGridEntreprises.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridEntreprises.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.mGridEntreprises.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridEntreprises.RowTemplate.Height = 25;
            this.mGridEntreprises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridEntreprises.Size = new System.Drawing.Size(967, 564);
            this.mGridEntreprises.TabIndex = 8;
            this.mGridEntreprises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mGridEntreprises_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Siret";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn2.HeaderText = "Noms de l\'entreprise";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Afficher";
            this.dataGridViewTextBoxColumn3.Image = global::gestionstage.Properties.Resources.tab_afficher;
            this.dataGridViewTextBoxColumn3.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 55;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Modifier";
            this.dataGridViewTextBoxColumn4.Image = global::gestionstage.Properties.Resources.tab_modifier;
            this.dataGridViewTextBoxColumn4.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Supprimer";
            this.dataGridViewTextBoxColumn5.Image = global::gestionstage.Properties.Resources.tab_supprimer;
            this.dataGridViewTextBoxColumn5.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // mButtonAddEntreprise
            // 
            this.mButtonAddEntreprise.ActiveControl = null;
            this.mButtonAddEntreprise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonAddEntreprise.Location = new System.Drawing.Point(0, 54);
            this.mButtonAddEntreprise.Name = "mButtonAddEntreprise";
            this.mButtonAddEntreprise.Size = new System.Drawing.Size(965, 50);
            this.mButtonAddEntreprise.TabIndex = 7;
            this.mButtonAddEntreprise.Text = "Ajouter une entreprise";
            this.mButtonAddEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAddEntreprise.UseSelectable = true;
            this.mButtonAddEntreprise.Click += new System.EventHandler(this.mButtonAddEntreprise_Click);
            // 
            // mTBSearch
            // 
            this.mTBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBSearch.CausesValidation = false;
            // 
            // 
            // 
            this.mTBSearch.CustomButton.Image = null;
            this.mTBSearch.CustomButton.Location = new System.Drawing.Point(937, 2);
            this.mTBSearch.CustomButton.Name = "";
            this.mTBSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTBSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBSearch.CustomButton.TabIndex = 1;
            this.mTBSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBSearch.CustomButton.UseSelectable = true;
            this.mTBSearch.CustomButton.Visible = false;
            this.mTBSearch.DisplayIcon = true;
            this.mTBSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTBSearch.Icon = global::gestionstage.Properties.Resources.appbar_magnify;
            this.mTBSearch.IconRight = true;
            this.mTBSearch.Lines = new string[] {
        "Rechercher . . ."};
            this.mTBSearch.Location = new System.Drawing.Point(0, 16);
            this.mTBSearch.Margin = new System.Windows.Forms.Padding(5);
            this.mTBSearch.MaxLength = 32767;
            this.mTBSearch.Name = "mTBSearch";
            this.mTBSearch.PasswordChar = '\0';
            this.mTBSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBSearch.SelectedText = "";
            this.mTBSearch.SelectionLength = 0;
            this.mTBSearch.SelectionStart = 0;
            this.mTBSearch.ShortcutsEnabled = true;
            this.mTBSearch.Size = new System.Drawing.Size(965, 30);
            this.mTBSearch.TabIndex = 5;
            this.mTBSearch.Text = "Rechercher . . .";
            this.mTBSearch.UseSelectable = true;
            this.mTBSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTBSearch.Enter += new System.EventHandler(this.mTBSearch_Enter);
            this.mTBSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTBSearch_KeyUp);
            this.mTBSearch.Leave += new System.EventHandler(this.mTBSearch_Leave);
            // 
            // mMenu
            // 
            this.mMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mMenu.Controls.Add(this.mMenuEntreprise);
            this.mMenu.Controls.Add(this.mMenuSettings);
            this.mMenu.Location = new System.Drawing.Point(23, 26);
            this.mMenu.Name = "mMenu";
            this.mMenu.SelectedIndex = 0;
            this.mMenu.Size = new System.Drawing.Size(976, 719);
            this.mMenu.TabIndex = 5;
            this.mMenu.UseSelectable = true;
            this.mMenu.UseStyleColors = true;
            // 
            // ListEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mMenu);
            this.MinimumSize = new System.Drawing.Size(645, 680);
            this.Name = "ListEntreprise";
            this.Load += new System.EventHandler(this.ListEntreprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mSMListEntreprise)).EndInit();
            this.mMenuSettings.ResumeLayout(false);
            this.mMenuSettings.PerformLayout();
            this.mMenuEntreprise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridEntreprises)).EndInit();
            this.mMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager mSMListEntreprise;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private MetroFramework.Controls.MetroTabControl mMenu;
        private MetroFramework.Controls.MetroTabPage mMenuEntreprise;
        private MetroFramework.Controls.MetroGrid mGridEntreprises;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroTile mButtonAddEntreprise;
        private MetroFramework.Controls.MetroTextBox mTBSearch;
        private MetroFramework.Controls.MetroTabPage mMenuSettings;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mButtonConfirmColor;
        private MetroFramework.Controls.MetroLabel mLabelChooseColor;
        private MetroFramework.Controls.MetroTile mButtonConfirmPush;
        private System.Windows.Forms.FlowLayoutPanel ConteneurCouleurs;
        private MetroFramework.Controls.MetroLabel mLabelPush;
        private MetroFramework.Controls.MetroTile mButtonConfirmPull;
        private MetroFramework.Controls.MetroLabel mLabelPull;
    }
}