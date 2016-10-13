﻿namespace gestionstage.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mSMListEntreprise = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mMenuSettings = new MetroFramework.Controls.MetroTabPage();
            this.mButtonConfirmColor = new MetroFramework.Controls.MetroTile();
            this.ConteneurCouleurs = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mMenuEntreprise = new MetroFramework.Controls.MetroTabPage();
            this.mGridEntreprises = new MetroFramework.Controls.MetroGrid();
            this.mButtonAddEntreprise = new MetroFramework.Controls.MetroTile();
            this.mTBSearch = new MetroFramework.Controls.MetroTextBox();
            this.mMenu = new MetroFramework.Controls.MetroTabControl();
            this.mMenuTEST = new MetroFramework.Controls.MetroTabPage();
            this.mTESTModifyEntreprise = new MetroFramework.Controls.MetroTile();
            this.mTESTAddEntreprise = new MetroFramework.Controls.MetroTile();
            this.mTestAddContrat = new MetroFramework.Controls.MetroTile();
            this.mTESTViewEntreprise = new MetroFramework.Controls.MetroTile();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mSMListEntreprise)).BeginInit();
            this.mMenuSettings.SuspendLayout();
            this.mMenuEntreprise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridEntreprises)).BeginInit();
            this.mMenu.SuspendLayout();
            this.mMenuTEST.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMListEntreprise
            // 
            this.mSMListEntreprise.Owner = this;
            this.mSMListEntreprise.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // mMenuSettings
            // 
            this.mMenuSettings.Controls.Add(this.mButtonConfirmColor);
            this.mMenuSettings.Controls.Add(this.ConteneurCouleurs);
            this.mMenuSettings.Controls.Add(this.metroLabel1);
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
            // mButtonConfirmColor
            // 
            this.mButtonConfirmColor.ActiveControl = null;
            this.mButtonConfirmColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonConfirmColor.Location = new System.Drawing.Point(229, 3);
            this.mButtonConfirmColor.Name = "mButtonConfirmColor";
            this.mButtonConfirmColor.Size = new System.Drawing.Size(736, 40);
            this.mButtonConfirmColor.TabIndex = 4;
            this.mButtonConfirmColor.Text = "Confirmer la couleur";
            this.mButtonConfirmColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonConfirmColor.UseSelectable = true;
            this.mButtonConfirmColor.Click += new System.EventHandler(this.mButtonConfirmColor_Click);
            // 
            // ConteneurCouleurs
            // 
            this.ConteneurCouleurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConteneurCouleurs.AutoScroll = true;
            this.ConteneurCouleurs.Location = new System.Drawing.Point(4, 49);
            this.ConteneurCouleurs.Name = "ConteneurCouleurs";
            this.ConteneurCouleurs.Size = new System.Drawing.Size(961, 625);
            this.ConteneurCouleurs.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(218, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Choisissez la couleur de l\'interface : ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.mGridEntreprises.AllowUserToResizeRows = false;
            this.mGridEntreprises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGridEntreprises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridEntreprises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridEntreprises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridEntreprises.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridEntreprises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridEntreprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridEntreprises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridEntreprises.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridEntreprises.EnableHeadersVisualStyles = false;
            this.mGridEntreprises.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridEntreprises.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridEntreprises.Location = new System.Drawing.Point(-2, 110);
            this.mGridEntreprises.Name = "mGridEntreprises";
            this.mGridEntreprises.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridEntreprises.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridEntreprises.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridEntreprises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridEntreprises.Size = new System.Drawing.Size(967, 564);
            this.mGridEntreprises.TabIndex = 8;
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
        "Rechercher . . . TODO"};
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
            this.mTBSearch.Text = "Rechercher . . . TODO";
            this.mTBSearch.UseSelectable = true;
            this.mTBSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mMenu
            // 
            this.mMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mMenu.Controls.Add(this.mMenuEntreprise);
            this.mMenu.Controls.Add(this.mMenuSettings);
            this.mMenu.Controls.Add(this.mMenuTEST);
            this.mMenu.Location = new System.Drawing.Point(23, 26);
            this.mMenu.Name = "mMenu";
            this.mMenu.SelectedIndex = 0;
            this.mMenu.Size = new System.Drawing.Size(976, 719);
            this.mMenu.TabIndex = 5;
            this.mMenu.UseSelectable = true;
            this.mMenu.UseStyleColors = true;
            // 
            // mMenuTEST
            // 
            this.mMenuTEST.Controls.Add(this.mTESTViewEntreprise);
            this.mMenuTEST.Controls.Add(this.mTESTModifyEntreprise);
            this.mMenuTEST.Controls.Add(this.mTESTAddEntreprise);
            this.mMenuTEST.Controls.Add(this.mTestAddContrat);
            this.mMenuTEST.HorizontalScrollbarBarColor = true;
            this.mMenuTEST.HorizontalScrollbarHighlightOnWheel = false;
            this.mMenuTEST.HorizontalScrollbarSize = 10;
            this.mMenuTEST.Location = new System.Drawing.Point(4, 38);
            this.mMenuTEST.Name = "mMenuTEST";
            this.mMenuTEST.Size = new System.Drawing.Size(968, 677);
            this.mMenuTEST.TabIndex = 2;
            this.mMenuTEST.Text = "TEST";
            this.mMenuTEST.VerticalScrollbarBarColor = true;
            this.mMenuTEST.VerticalScrollbarHighlightOnWheel = false;
            this.mMenuTEST.VerticalScrollbarSize = 10;
            // 
            // mTESTModifyEntreprise
            // 
            this.mTESTModifyEntreprise.ActiveControl = null;
            this.mTESTModifyEntreprise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTESTModifyEntreprise.Location = new System.Drawing.Point(3, 173);
            this.mTESTModifyEntreprise.Name = "mTESTModifyEntreprise";
            this.mTESTModifyEntreprise.Size = new System.Drawing.Size(962, 50);
            this.mTESTModifyEntreprise.TabIndex = 4;
            this.mTESTModifyEntreprise.Text = "ModifyEntreprise";
            this.mTESTModifyEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTESTModifyEntreprise.UseSelectable = true;
            this.mTESTModifyEntreprise.Click += new System.EventHandler(this.mTESTModifyEntreprise_Click);
            // 
            // mTESTAddEntreprise
            // 
            this.mTESTAddEntreprise.ActiveControl = null;
            this.mTESTAddEntreprise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTESTAddEntreprise.Location = new System.Drawing.Point(3, 88);
            this.mTESTAddEntreprise.Name = "mTESTAddEntreprise";
            this.mTESTAddEntreprise.Size = new System.Drawing.Size(962, 50);
            this.mTESTAddEntreprise.TabIndex = 3;
            this.mTESTAddEntreprise.Text = "AddEntreprise";
            this.mTESTAddEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTESTAddEntreprise.UseSelectable = true;
            this.mTESTAddEntreprise.Click += new System.EventHandler(this.mTESTAddEntreprise_Click);
            // 
            // mTestAddContrat
            // 
            this.mTestAddContrat.ActiveControl = null;
            this.mTestAddContrat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTestAddContrat.Location = new System.Drawing.Point(3, 3);
            this.mTestAddContrat.Name = "mTestAddContrat";
            this.mTestAddContrat.Size = new System.Drawing.Size(962, 50);
            this.mTestAddContrat.TabIndex = 2;
            this.mTestAddContrat.Text = "AddContrat";
            this.mTestAddContrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTestAddContrat.UseSelectable = true;
            this.mTestAddContrat.Click += new System.EventHandler(this.mTestAddContrat_Click);
            // 
            // mTESTViewEntreprise
            // 
            this.mTESTViewEntreprise.ActiveControl = null;
            this.mTESTViewEntreprise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTESTViewEntreprise.Location = new System.Drawing.Point(3, 258);
            this.mTESTViewEntreprise.Name = "mTESTViewEntreprise";
            this.mTESTViewEntreprise.Size = new System.Drawing.Size(962, 50);
            this.mTESTViewEntreprise.TabIndex = 5;
            this.mTESTViewEntreprise.Text = "ViewEntreprise";
            this.mTESTViewEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTESTViewEntreprise.UseSelectable = true;
            this.mTESTViewEntreprise.Click += new System.EventHandler(this.mTESTViewEntreprise_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Siret";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Noms de l\'entreprise";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Afficher";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Modifier";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Supprimer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mMenu);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ListEntreprise";
            this.Load += new System.EventHandler(this.ListEntreprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mSMListEntreprise)).EndInit();
            this.mMenuSettings.ResumeLayout(false);
            this.mMenuSettings.PerformLayout();
            this.mMenuEntreprise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridEntreprises)).EndInit();
            this.mMenu.ResumeLayout(false);
            this.mMenuTEST.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager mSMListEntreprise;
        private MetroFramework.Controls.MetroTabControl mMenu;
        private MetroFramework.Controls.MetroTabPage mMenuEntreprise;
        private MetroFramework.Controls.MetroGrid mGridEntreprises;
        private MetroFramework.Controls.MetroTile mButtonAddEntreprise;
        private MetroFramework.Controls.MetroTextBox mTBSearch;
        private MetroFramework.Controls.MetroTabPage mMenuSettings;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel ConteneurCouleurs;
        private MetroFramework.Controls.MetroTile mButtonConfirmColor;
        private MetroFramework.Controls.MetroTabPage mMenuTEST;
        private MetroFramework.Controls.MetroTile mTestAddContrat;
        private MetroFramework.Controls.MetroTile mTESTAddEntreprise;
        private MetroFramework.Controls.MetroTile mTESTModifyEntreprise;
        private MetroFramework.Controls.MetroTile mTESTViewEntreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}