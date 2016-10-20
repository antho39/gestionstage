namespace gestionstage.Forms
{
    partial class ViewEntreprise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mSMViewEntreprise = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mLinkBack = new MetroFramework.Controls.MetroLink();
            this.mLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.mButtonAddContrat = new MetroFramework.Controls.MetroTile();
            this.mButtonModifyEntreprise = new MetroFramework.Controls.MetroTile();
            this.mButtonDeleteEntreprise = new MetroFramework.Controls.MetroTile();
            this.mTxBEntrepriseSiret = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEntrepriseSiret = new MetroFramework.Controls.MetroLabel();
            this.mTxBEntrepriseEmail = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEntrepriseEmail = new MetroFramework.Controls.MetroLabel();
            this.mTxBEntrepriseTelephone = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEntrepriseTelephone = new MetroFramework.Controls.MetroLabel();
            this.mTxBEntrepriseCity = new MetroFramework.Controls.MetroTextBox();
            this.mLabelCity = new MetroFramework.Controls.MetroLabel();
            this.mTxBEntreprisePostalCode = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEntreprisePostalCode = new MetroFramework.Controls.MetroLabel();
            this.mTxBEntrepriseAdresse = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEntrepriseAdresse = new MetroFramework.Controls.MetroLabel();
            this.mTxBEntrepriseName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEntrepriseName = new MetroFramework.Controls.MetroLabel();
            this.mGridContrat = new MetroFramework.Controls.MetroGrid();
            this.TuteurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuteurFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EleveNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EleveFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appreciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mSMViewEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // mSMViewEntreprise
            // 
            this.mSMViewEntreprise.Owner = this;
            // 
            // mLinkBack
            // 
            this.mLinkBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mLinkBack.Image = global::gestionstage.Properties.Resources.appbar_arrow_left_left;
            this.mLinkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mLinkBack.ImageSize = 35;
            this.mLinkBack.Location = new System.Drawing.Point(25, 35);
            this.mLinkBack.Name = "mLinkBack";
            this.mLinkBack.Size = new System.Drawing.Size(81, 23);
            this.mLinkBack.TabIndex = 35;
            this.mLinkBack.Text = "Retour";
            this.mLinkBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mLinkBack.UseSelectable = true;
            this.mLinkBack.Click += new System.EventHandler(this.mLinkBack_Click);
            // 
            // mLabelTitle
            // 
            this.mLabelTitle.AutoSize = true;
            this.mLabelTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelTitle.Location = new System.Drawing.Point(175, 35);
            this.mLabelTitle.Name = "mLabelTitle";
            this.mLabelTitle.Size = new System.Drawing.Size(227, 25);
            this.mLabelTitle.TabIndex = 34;
            this.mLabelTitle.Text = "Visualisation de l\'entreprise :";
            this.mLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mButtonAddContrat
            // 
            this.mButtonAddContrat.ActiveControl = null;
            this.mButtonAddContrat.Location = new System.Drawing.Point(25, 75);
            this.mButtonAddContrat.Name = "mButtonAddContrat";
            this.mButtonAddContrat.Size = new System.Drawing.Size(200, 50);
            this.mButtonAddContrat.TabIndex = 36;
            this.mButtonAddContrat.Text = "Ajouter un contrat";
            this.mButtonAddContrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAddContrat.UseSelectable = true;
            this.mButtonAddContrat.Click += new System.EventHandler(this.mButtonAddContrat_Click);
            // 
            // mButtonModifyEntreprise
            // 
            this.mButtonModifyEntreprise.ActiveControl = null;
            this.mButtonModifyEntreprise.Location = new System.Drawing.Point(275, 75);
            this.mButtonModifyEntreprise.Name = "mButtonModifyEntreprise";
            this.mButtonModifyEntreprise.Size = new System.Drawing.Size(200, 50);
            this.mButtonModifyEntreprise.TabIndex = 37;
            this.mButtonModifyEntreprise.Text = "Modifier l\'entreprise";
            this.mButtonModifyEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonModifyEntreprise.UseSelectable = true;
            this.mButtonModifyEntreprise.Click += new System.EventHandler(this.mButtonModifyEntreprise_Click);
            // 
            // mButtonDeleteEntreprise
            // 
            this.mButtonDeleteEntreprise.ActiveControl = null;
            this.mButtonDeleteEntreprise.Location = new System.Drawing.Point(525, 75);
            this.mButtonDeleteEntreprise.Name = "mButtonDeleteEntreprise";
            this.mButtonDeleteEntreprise.Size = new System.Drawing.Size(200, 50);
            this.mButtonDeleteEntreprise.TabIndex = 38;
            this.mButtonDeleteEntreprise.Text = "Supprimer l\'entreprise";
            this.mButtonDeleteEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonDeleteEntreprise.UseSelectable = true;
            this.mButtonDeleteEntreprise.Click += new System.EventHandler(this.mButtonDeleteEntreprise_Click);
            // 
            // mTxBEntrepriseSiret
            // 
            this.mTxBEntrepriseSiret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBEntrepriseSiret.CustomButton.Image = null;
            this.mTxBEntrepriseSiret.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBEntrepriseSiret.CustomButton.Name = "";
            this.mTxBEntrepriseSiret.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBEntrepriseSiret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBEntrepriseSiret.CustomButton.TabIndex = 1;
            this.mTxBEntrepriseSiret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBEntrepriseSiret.CustomButton.UseSelectable = true;
            this.mTxBEntrepriseSiret.CustomButton.Visible = false;
            this.mTxBEntrepriseSiret.Enabled = false;
            this.mTxBEntrepriseSiret.Lines = new string[0];
            this.mTxBEntrepriseSiret.Location = new System.Drawing.Point(175, 150);
            this.mTxBEntrepriseSiret.MaxLength = 32767;
            this.mTxBEntrepriseSiret.Name = "mTxBEntrepriseSiret";
            this.mTxBEntrepriseSiret.PasswordChar = '\0';
            this.mTxBEntrepriseSiret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntrepriseSiret.SelectedText = "";
            this.mTxBEntrepriseSiret.SelectionLength = 0;
            this.mTxBEntrepriseSiret.SelectionStart = 0;
            this.mTxBEntrepriseSiret.ShortcutsEnabled = true;
            this.mTxBEntrepriseSiret.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntrepriseSiret.TabIndex = 52;
            this.mTxBEntrepriseSiret.UseSelectable = true;
            this.mTxBEntrepriseSiret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntrepriseSiret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEntrepriseSiret
            // 
            this.mLabelEntrepriseSiret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelEntrepriseSiret.AutoSize = true;
            this.mLabelEntrepriseSiret.Location = new System.Drawing.Point(25, 150);
            this.mLabelEntrepriseSiret.Name = "mLabelEntrepriseSiret";
            this.mLabelEntrepriseSiret.Size = new System.Drawing.Size(65, 19);
            this.mLabelEntrepriseSiret.TabIndex = 51;
            this.mLabelEntrepriseSiret.Text = "N° Siret : ";
            // 
            // mTxBEntrepriseEmail
            // 
            this.mTxBEntrepriseEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBEntrepriseEmail.CustomButton.Image = null;
            this.mTxBEntrepriseEmail.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBEntrepriseEmail.CustomButton.Name = "";
            this.mTxBEntrepriseEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBEntrepriseEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBEntrepriseEmail.CustomButton.TabIndex = 1;
            this.mTxBEntrepriseEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBEntrepriseEmail.CustomButton.UseSelectable = true;
            this.mTxBEntrepriseEmail.CustomButton.Visible = false;
            this.mTxBEntrepriseEmail.Enabled = false;
            this.mTxBEntrepriseEmail.Lines = new string[0];
            this.mTxBEntrepriseEmail.Location = new System.Drawing.Point(175, 360);
            this.mTxBEntrepriseEmail.MaxLength = 32767;
            this.mTxBEntrepriseEmail.Name = "mTxBEntrepriseEmail";
            this.mTxBEntrepriseEmail.PasswordChar = '\0';
            this.mTxBEntrepriseEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntrepriseEmail.SelectedText = "";
            this.mTxBEntrepriseEmail.SelectionLength = 0;
            this.mTxBEntrepriseEmail.SelectionStart = 0;
            this.mTxBEntrepriseEmail.ShortcutsEnabled = true;
            this.mTxBEntrepriseEmail.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntrepriseEmail.TabIndex = 50;
            this.mTxBEntrepriseEmail.UseSelectable = true;
            this.mTxBEntrepriseEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntrepriseEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEntrepriseEmail
            // 
            this.mLabelEntrepriseEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelEntrepriseEmail.AutoSize = true;
            this.mLabelEntrepriseEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mLabelEntrepriseEmail.Location = new System.Drawing.Point(25, 360);
            this.mLabelEntrepriseEmail.Name = "mLabelEntrepriseEmail";
            this.mLabelEntrepriseEmail.Size = new System.Drawing.Size(58, 19);
            this.mLabelEntrepriseEmail.TabIndex = 49;
            this.mLabelEntrepriseEmail.Text = "E-mail : ";
            // 
            // mTxBEntrepriseTelephone
            // 
            this.mTxBEntrepriseTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBEntrepriseTelephone.CustomButton.Image = null;
            this.mTxBEntrepriseTelephone.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBEntrepriseTelephone.CustomButton.Name = "";
            this.mTxBEntrepriseTelephone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBEntrepriseTelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBEntrepriseTelephone.CustomButton.TabIndex = 1;
            this.mTxBEntrepriseTelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBEntrepriseTelephone.CustomButton.UseSelectable = true;
            this.mTxBEntrepriseTelephone.CustomButton.Visible = false;
            this.mTxBEntrepriseTelephone.Enabled = false;
            this.mTxBEntrepriseTelephone.Lines = new string[0];
            this.mTxBEntrepriseTelephone.Location = new System.Drawing.Point(175, 325);
            this.mTxBEntrepriseTelephone.MaxLength = 32767;
            this.mTxBEntrepriseTelephone.Name = "mTxBEntrepriseTelephone";
            this.mTxBEntrepriseTelephone.PasswordChar = '\0';
            this.mTxBEntrepriseTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntrepriseTelephone.SelectedText = "";
            this.mTxBEntrepriseTelephone.SelectionLength = 0;
            this.mTxBEntrepriseTelephone.SelectionStart = 0;
            this.mTxBEntrepriseTelephone.ShortcutsEnabled = true;
            this.mTxBEntrepriseTelephone.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntrepriseTelephone.TabIndex = 48;
            this.mTxBEntrepriseTelephone.UseSelectable = true;
            this.mTxBEntrepriseTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntrepriseTelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEntrepriseTelephone
            // 
            this.mLabelEntrepriseTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelEntrepriseTelephone.AutoSize = true;
            this.mLabelEntrepriseTelephone.Location = new System.Drawing.Point(25, 325);
            this.mLabelEntrepriseTelephone.Name = "mLabelEntrepriseTelephone";
            this.mLabelEntrepriseTelephone.Size = new System.Drawing.Size(79, 19);
            this.mLabelEntrepriseTelephone.TabIndex = 47;
            this.mLabelEntrepriseTelephone.Text = "Téléphone : ";
            // 
            // mTxBEntrepriseCity
            // 
            this.mTxBEntrepriseCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBEntrepriseCity.CustomButton.Image = null;
            this.mTxBEntrepriseCity.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBEntrepriseCity.CustomButton.Name = "";
            this.mTxBEntrepriseCity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBEntrepriseCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBEntrepriseCity.CustomButton.TabIndex = 1;
            this.mTxBEntrepriseCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBEntrepriseCity.CustomButton.UseSelectable = true;
            this.mTxBEntrepriseCity.CustomButton.Visible = false;
            this.mTxBEntrepriseCity.Enabled = false;
            this.mTxBEntrepriseCity.Lines = new string[0];
            this.mTxBEntrepriseCity.Location = new System.Drawing.Point(175, 290);
            this.mTxBEntrepriseCity.MaxLength = 32767;
            this.mTxBEntrepriseCity.Name = "mTxBEntrepriseCity";
            this.mTxBEntrepriseCity.PasswordChar = '\0';
            this.mTxBEntrepriseCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntrepriseCity.SelectedText = "";
            this.mTxBEntrepriseCity.SelectionLength = 0;
            this.mTxBEntrepriseCity.SelectionStart = 0;
            this.mTxBEntrepriseCity.ShortcutsEnabled = true;
            this.mTxBEntrepriseCity.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntrepriseCity.TabIndex = 46;
            this.mTxBEntrepriseCity.UseSelectable = true;
            this.mTxBEntrepriseCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntrepriseCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelCity
            // 
            this.mLabelCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelCity.AutoSize = true;
            this.mLabelCity.Location = new System.Drawing.Point(25, 290);
            this.mLabelCity.Name = "mLabelCity";
            this.mLabelCity.Size = new System.Drawing.Size(44, 19);
            this.mLabelCity.TabIndex = 45;
            this.mLabelCity.Text = "Ville : ";
            // 
            // mTxBEntreprisePostalCode
            // 
            this.mTxBEntreprisePostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBEntreprisePostalCode.CustomButton.Image = null;
            this.mTxBEntreprisePostalCode.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBEntreprisePostalCode.CustomButton.Name = "";
            this.mTxBEntreprisePostalCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBEntreprisePostalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBEntreprisePostalCode.CustomButton.TabIndex = 1;
            this.mTxBEntreprisePostalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBEntreprisePostalCode.CustomButton.UseSelectable = true;
            this.mTxBEntreprisePostalCode.CustomButton.Visible = false;
            this.mTxBEntreprisePostalCode.Enabled = false;
            this.mTxBEntreprisePostalCode.Lines = new string[0];
            this.mTxBEntreprisePostalCode.Location = new System.Drawing.Point(175, 255);
            this.mTxBEntreprisePostalCode.MaxLength = 32767;
            this.mTxBEntreprisePostalCode.Name = "mTxBEntreprisePostalCode";
            this.mTxBEntreprisePostalCode.PasswordChar = '\0';
            this.mTxBEntreprisePostalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntreprisePostalCode.SelectedText = "";
            this.mTxBEntreprisePostalCode.SelectionLength = 0;
            this.mTxBEntreprisePostalCode.SelectionStart = 0;
            this.mTxBEntreprisePostalCode.ShortcutsEnabled = true;
            this.mTxBEntreprisePostalCode.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntreprisePostalCode.TabIndex = 44;
            this.mTxBEntreprisePostalCode.UseSelectable = true;
            this.mTxBEntreprisePostalCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntreprisePostalCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEntreprisePostalCode
            // 
            this.mLabelEntreprisePostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelEntreprisePostalCode.AutoSize = true;
            this.mLabelEntreprisePostalCode.Location = new System.Drawing.Point(25, 255);
            this.mLabelEntreprisePostalCode.Name = "mLabelEntreprisePostalCode";
            this.mLabelEntreprisePostalCode.Size = new System.Drawing.Size(97, 19);
            this.mLabelEntreprisePostalCode.TabIndex = 43;
            this.mLabelEntreprisePostalCode.Text = "Code Postale : ";
            // 
            // mTxBEntrepriseAdresse
            // 
            this.mTxBEntrepriseAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBEntrepriseAdresse.CustomButton.Image = null;
            this.mTxBEntrepriseAdresse.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBEntrepriseAdresse.CustomButton.Name = "";
            this.mTxBEntrepriseAdresse.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBEntrepriseAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBEntrepriseAdresse.CustomButton.TabIndex = 1;
            this.mTxBEntrepriseAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBEntrepriseAdresse.CustomButton.UseSelectable = true;
            this.mTxBEntrepriseAdresse.CustomButton.Visible = false;
            this.mTxBEntrepriseAdresse.Enabled = false;
            this.mTxBEntrepriseAdresse.Lines = new string[0];
            this.mTxBEntrepriseAdresse.Location = new System.Drawing.Point(175, 220);
            this.mTxBEntrepriseAdresse.MaxLength = 32767;
            this.mTxBEntrepriseAdresse.Name = "mTxBEntrepriseAdresse";
            this.mTxBEntrepriseAdresse.PasswordChar = '\0';
            this.mTxBEntrepriseAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntrepriseAdresse.SelectedText = "";
            this.mTxBEntrepriseAdresse.SelectionLength = 0;
            this.mTxBEntrepriseAdresse.SelectionStart = 0;
            this.mTxBEntrepriseAdresse.ShortcutsEnabled = true;
            this.mTxBEntrepriseAdresse.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntrepriseAdresse.TabIndex = 42;
            this.mTxBEntrepriseAdresse.UseSelectable = true;
            this.mTxBEntrepriseAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntrepriseAdresse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEntrepriseAdresse
            // 
            this.mLabelEntrepriseAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelEntrepriseAdresse.AutoSize = true;
            this.mLabelEntrepriseAdresse.Location = new System.Drawing.Point(25, 220);
            this.mLabelEntrepriseAdresse.Name = "mLabelEntrepriseAdresse";
            this.mLabelEntrepriseAdresse.Size = new System.Drawing.Size(66, 19);
            this.mLabelEntrepriseAdresse.TabIndex = 41;
            this.mLabelEntrepriseAdresse.Text = "Adresse : ";
            // 
            // mTxBEntrepriseName
            // 
            this.mTxBEntrepriseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBEntrepriseName.CustomButton.Image = null;
            this.mTxBEntrepriseName.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBEntrepriseName.CustomButton.Name = "";
            this.mTxBEntrepriseName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBEntrepriseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBEntrepriseName.CustomButton.TabIndex = 1;
            this.mTxBEntrepriseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBEntrepriseName.CustomButton.UseSelectable = true;
            this.mTxBEntrepriseName.CustomButton.Visible = false;
            this.mTxBEntrepriseName.Enabled = false;
            this.mTxBEntrepriseName.Lines = new string[0];
            this.mTxBEntrepriseName.Location = new System.Drawing.Point(175, 185);
            this.mTxBEntrepriseName.MaxLength = 32767;
            this.mTxBEntrepriseName.Name = "mTxBEntrepriseName";
            this.mTxBEntrepriseName.PasswordChar = '\0';
            this.mTxBEntrepriseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntrepriseName.SelectedText = "";
            this.mTxBEntrepriseName.SelectionLength = 0;
            this.mTxBEntrepriseName.SelectionStart = 0;
            this.mTxBEntrepriseName.ShortcutsEnabled = true;
            this.mTxBEntrepriseName.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntrepriseName.TabIndex = 40;
            this.mTxBEntrepriseName.UseSelectable = true;
            this.mTxBEntrepriseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntrepriseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEntrepriseName
            // 
            this.mLabelEntrepriseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelEntrepriseName.AutoSize = true;
            this.mLabelEntrepriseName.Location = new System.Drawing.Point(25, 185);
            this.mLabelEntrepriseName.Name = "mLabelEntrepriseName";
            this.mLabelEntrepriseName.Size = new System.Drawing.Size(50, 19);
            this.mLabelEntrepriseName.TabIndex = 39;
            this.mLabelEntrepriseName.Text = "Nom : ";
            // 
            // mGridContrat
            // 
            this.mGridContrat.AllowUserToAddRows = false;
            this.mGridContrat.AllowUserToDeleteRows = false;
            this.mGridContrat.AllowUserToResizeRows = false;
            this.mGridContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGridContrat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridContrat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridContrat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridContrat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridContrat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.mGridContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridContrat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TuteurName,
            this.TuteurFirstName,
            this.Classe,
            this.EleveNom,
            this.EleveFirstName,
            this.DateDebut,
            this.DateFin,
            this.Appreciation});
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridContrat.DefaultCellStyle = dataGridViewCellStyle43;
            this.mGridContrat.EnableHeadersVisualStyles = false;
            this.mGridContrat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridContrat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridContrat.Location = new System.Drawing.Point(25, 403);
            this.mGridContrat.Name = "mGridContrat";
            this.mGridContrat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridContrat.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.mGridContrat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridContrat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridContrat.Size = new System.Drawing.Size(979, 342);
            this.mGridContrat.TabIndex = 53;
            // 
            // TuteurName
            // 
            this.TuteurName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White;
            this.TuteurName.DefaultCellStyle = dataGridViewCellStyle35;
            this.TuteurName.HeaderText = "Nom Tuteur";
            this.TuteurName.Name = "TuteurName";
            // 
            // TuteurFirstName
            // 
            this.TuteurFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            this.TuteurFirstName.DefaultCellStyle = dataGridViewCellStyle36;
            this.TuteurFirstName.HeaderText = "Prenom Tuteur";
            this.TuteurFirstName.Name = "TuteurFirstName";
            // 
            // Classe
            // 
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White;
            this.Classe.DefaultCellStyle = dataGridViewCellStyle37;
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            // 
            // EleveNom
            // 
            this.EleveNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White;
            this.EleveNom.DefaultCellStyle = dataGridViewCellStyle38;
            this.EleveNom.HeaderText = "Nom élève";
            this.EleveNom.Name = "EleveNom";
            // 
            // EleveFirstName
            // 
            this.EleveFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White;
            this.EleveFirstName.DefaultCellStyle = dataGridViewCellStyle39;
            this.EleveFirstName.HeaderText = "Prénom élève";
            this.EleveFirstName.Name = "EleveFirstName";
            // 
            // DateDebut
            // 
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            this.DateDebut.DefaultCellStyle = dataGridViewCellStyle40;
            this.DateDebut.HeaderText = "Date de début";
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Width = 115;
            // 
            // DateFin
            // 
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White;
            this.DateFin.DefaultCellStyle = dataGridViewCellStyle41;
            this.DateFin.HeaderText = "Date de fin";
            this.DateFin.Name = "DateFin";
            // 
            // Appreciation
            // 
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            this.Appreciation.DefaultCellStyle = dataGridViewCellStyle42;
            this.Appreciation.HeaderText = "Appréciation";
            this.Appreciation.Name = "Appreciation";
            this.Appreciation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ViewEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mGridContrat);
            this.Controls.Add(this.mTxBEntrepriseSiret);
            this.Controls.Add(this.mLabelEntrepriseSiret);
            this.Controls.Add(this.mTxBEntrepriseEmail);
            this.Controls.Add(this.mLabelEntrepriseEmail);
            this.Controls.Add(this.mTxBEntrepriseTelephone);
            this.Controls.Add(this.mLabelEntrepriseTelephone);
            this.Controls.Add(this.mTxBEntrepriseCity);
            this.Controls.Add(this.mLabelCity);
            this.Controls.Add(this.mTxBEntreprisePostalCode);
            this.Controls.Add(this.mLabelEntreprisePostalCode);
            this.Controls.Add(this.mTxBEntrepriseAdresse);
            this.Controls.Add(this.mLabelEntrepriseAdresse);
            this.Controls.Add(this.mTxBEntrepriseName);
            this.Controls.Add(this.mLabelEntrepriseName);
            this.Controls.Add(this.mButtonDeleteEntreprise);
            this.Controls.Add(this.mButtonModifyEntreprise);
            this.Controls.Add(this.mButtonAddContrat);
            this.Controls.Add(this.mLinkBack);
            this.Controls.Add(this.mLabelTitle);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "ViewEntreprise";
            ((System.ComponentModel.ISupportInitialize)(this.mSMViewEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager mSMViewEntreprise;
        private MetroFramework.Controls.MetroLink mLinkBack;
        private MetroFramework.Controls.MetroLabel mLabelTitle;
        private MetroFramework.Controls.MetroTile mButtonAddContrat;
        private MetroFramework.Controls.MetroTile mButtonDeleteEntreprise;
        private MetroFramework.Controls.MetroTile mButtonModifyEntreprise;
        private MetroFramework.Controls.MetroTextBox mTxBEntrepriseSiret;
        private MetroFramework.Controls.MetroLabel mLabelEntrepriseSiret;
        private MetroFramework.Controls.MetroTextBox mTxBEntrepriseEmail;
        private MetroFramework.Controls.MetroLabel mLabelEntrepriseEmail;
        private MetroFramework.Controls.MetroTextBox mTxBEntrepriseTelephone;
        private MetroFramework.Controls.MetroLabel mLabelEntrepriseTelephone;
        private MetroFramework.Controls.MetroTextBox mTxBEntrepriseCity;
        private MetroFramework.Controls.MetroLabel mLabelCity;
        private MetroFramework.Controls.MetroTextBox mTxBEntreprisePostalCode;
        private MetroFramework.Controls.MetroLabel mLabelEntreprisePostalCode;
        private MetroFramework.Controls.MetroTextBox mTxBEntrepriseAdresse;
        private MetroFramework.Controls.MetroLabel mLabelEntrepriseAdresse;
        private MetroFramework.Controls.MetroTextBox mTxBEntrepriseName;
        private MetroFramework.Controls.MetroLabel mLabelEntrepriseName;
        private MetroFramework.Controls.MetroGrid mGridContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuteurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuteurFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn EleveNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn EleveFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appreciation;
    }
}