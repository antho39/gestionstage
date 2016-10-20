namespace gestionstage.Forms
{
    partial class AddContrat
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
            this.mSMAddContrat = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mLinkBack = new MetroFramework.Controls.MetroLink();
            this.mLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.mButtonAddContrat = new MetroFramework.Controls.MetroTile();
            this.mTxBTuteurEmail = new MetroFramework.Controls.MetroTextBox();
            this.mLabelTuteurEmail = new MetroFramework.Controls.MetroLabel();
            this.mTxBTuteurTelephone = new MetroFramework.Controls.MetroTextBox();
            this.mLabelTuteurTelephone = new MetroFramework.Controls.MetroLabel();
            this.mTxBStagiaireFirstName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelStagiaireFirstName = new MetroFramework.Controls.MetroLabel();
            this.mTxBStagiaireName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelStagiaireName = new MetroFramework.Controls.MetroLabel();
            this.mTxBEntrepriseName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEntrepriseName = new MetroFramework.Controls.MetroLabel();
            this.mLabelStagiaire = new MetroFramework.Controls.MetroLabel();
            this.mCbxStagiaireClassroom = new MetroFramework.Controls.MetroComboBox();
            this.mLabelStagiaireClassroom = new MetroFramework.Controls.MetroLabel();
            this.mLabelTuteur = new MetroFramework.Controls.MetroLabel();
            this.mTxBTuteurFirstName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelTuteurFirstName = new MetroFramework.Controls.MetroLabel();
            this.mTxBTuteurName = new MetroFramework.Controls.MetroTextBox();
            this.mLabelTuteurName = new MetroFramework.Controls.MetroLabel();
            this.mDTDateBegin = new MetroFramework.Controls.MetroDateTime();
            this.mLabelContrat = new MetroFramework.Controls.MetroLabel();
            this.mLabelDateBegin = new MetroFramework.Controls.MetroLabel();
            this.mLabelDateEnd = new MetroFramework.Controls.MetroLabel();
            this.mDTDateEnd = new MetroFramework.Controls.MetroDateTime();
            this.mRadioButtonApprentissage = new MetroFramework.Controls.MetroRadioButton();
            this.mRadioButtonStage = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.mRadioButton6semaines = new MetroFramework.Controls.MetroRadioButton();
            this.mRadioButton1an = new MetroFramework.Controls.MetroRadioButton();
            this.mRadioButton2ans = new MetroFramework.Controls.MetroRadioButton();
            this.panelChoixContrat = new System.Windows.Forms.Panel();
            this.panelChoixDurée = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddContrat)).BeginInit();
            this.panelChoixContrat.SuspendLayout();
            this.panelChoixDurée.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMAddContrat
            // 
            this.mSMAddContrat.Owner = this;
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
            this.mLinkBack.TabIndex = 18;
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
            this.mLabelTitle.Size = new System.Drawing.Size(158, 25);
            this.mLabelTitle.TabIndex = 17;
            this.mLabelTitle.Text = "Ajout d\'un contrat :";
            this.mLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mButtonAddContrat
            // 
            this.mButtonAddContrat.ActiveControl = null;
            this.mButtonAddContrat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonAddContrat.Location = new System.Drawing.Point(25, 595);
            this.mButtonAddContrat.Name = "mButtonAddContrat";
            this.mButtonAddContrat.Size = new System.Drawing.Size(979, 50);
            this.mButtonAddContrat.TabIndex = 31;
            this.mButtonAddContrat.Text = "Ajouter le contrat";
            this.mButtonAddContrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAddContrat.UseSelectable = true;
            // 
            // mTxBTuteurEmail
            // 
            this.mTxBTuteurEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBTuteurEmail.CustomButton.Image = null;
            this.mTxBTuteurEmail.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBTuteurEmail.CustomButton.Name = "";
            this.mTxBTuteurEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBTuteurEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBTuteurEmail.CustomButton.TabIndex = 1;
            this.mTxBTuteurEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBTuteurEmail.CustomButton.UseSelectable = true;
            this.mTxBTuteurEmail.CustomButton.Visible = false;
            this.mTxBTuteurEmail.Lines = new string[0];
            this.mTxBTuteurEmail.Location = new System.Drawing.Point(175, 420);
            this.mTxBTuteurEmail.MaxLength = 32767;
            this.mTxBTuteurEmail.Name = "mTxBTuteurEmail";
            this.mTxBTuteurEmail.PasswordChar = '\0';
            this.mTxBTuteurEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBTuteurEmail.SelectedText = "";
            this.mTxBTuteurEmail.SelectionLength = 0;
            this.mTxBTuteurEmail.SelectionStart = 0;
            this.mTxBTuteurEmail.ShortcutsEnabled = true;
            this.mTxBTuteurEmail.Size = new System.Drawing.Size(829, 25);
            this.mTxBTuteurEmail.TabIndex = 30;
            this.mTxBTuteurEmail.UseSelectable = true;
            this.mTxBTuteurEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBTuteurEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelTuteurEmail
            // 
            this.mLabelTuteurEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelTuteurEmail.AutoSize = true;
            this.mLabelTuteurEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mLabelTuteurEmail.Location = new System.Drawing.Point(25, 420);
            this.mLabelTuteurEmail.Name = "mLabelTuteurEmail";
            this.mLabelTuteurEmail.Size = new System.Drawing.Size(58, 19);
            this.mLabelTuteurEmail.TabIndex = 29;
            this.mLabelTuteurEmail.Text = "E-mail : ";
            // 
            // mTxBTuteurTelephone
            // 
            this.mTxBTuteurTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBTuteurTelephone.CustomButton.Image = null;
            this.mTxBTuteurTelephone.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBTuteurTelephone.CustomButton.Name = "";
            this.mTxBTuteurTelephone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBTuteurTelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBTuteurTelephone.CustomButton.TabIndex = 1;
            this.mTxBTuteurTelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBTuteurTelephone.CustomButton.UseSelectable = true;
            this.mTxBTuteurTelephone.CustomButton.Visible = false;
            this.mTxBTuteurTelephone.Lines = new string[0];
            this.mTxBTuteurTelephone.Location = new System.Drawing.Point(175, 385);
            this.mTxBTuteurTelephone.MaxLength = 32767;
            this.mTxBTuteurTelephone.Name = "mTxBTuteurTelephone";
            this.mTxBTuteurTelephone.PasswordChar = '\0';
            this.mTxBTuteurTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBTuteurTelephone.SelectedText = "";
            this.mTxBTuteurTelephone.SelectionLength = 0;
            this.mTxBTuteurTelephone.SelectionStart = 0;
            this.mTxBTuteurTelephone.ShortcutsEnabled = true;
            this.mTxBTuteurTelephone.Size = new System.Drawing.Size(829, 25);
            this.mTxBTuteurTelephone.TabIndex = 28;
            this.mTxBTuteurTelephone.UseSelectable = true;
            this.mTxBTuteurTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBTuteurTelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelTuteurTelephone
            // 
            this.mLabelTuteurTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelTuteurTelephone.AutoSize = true;
            this.mLabelTuteurTelephone.Location = new System.Drawing.Point(25, 385);
            this.mLabelTuteurTelephone.Name = "mLabelTuteurTelephone";
            this.mLabelTuteurTelephone.Size = new System.Drawing.Size(79, 19);
            this.mLabelTuteurTelephone.TabIndex = 27;
            this.mLabelTuteurTelephone.Text = "Téléphone : ";
            // 
            // mTxBStagiaireFirstName
            // 
            this.mTxBStagiaireFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBStagiaireFirstName.CustomButton.Image = null;
            this.mTxBStagiaireFirstName.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBStagiaireFirstName.CustomButton.Name = "";
            this.mTxBStagiaireFirstName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBStagiaireFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBStagiaireFirstName.CustomButton.TabIndex = 1;
            this.mTxBStagiaireFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBStagiaireFirstName.CustomButton.UseSelectable = true;
            this.mTxBStagiaireFirstName.CustomButton.Visible = false;
            this.mTxBStagiaireFirstName.Lines = new string[0];
            this.mTxBStagiaireFirstName.Location = new System.Drawing.Point(175, 195);
            this.mTxBStagiaireFirstName.MaxLength = 32767;
            this.mTxBStagiaireFirstName.Name = "mTxBStagiaireFirstName";
            this.mTxBStagiaireFirstName.PasswordChar = '\0';
            this.mTxBStagiaireFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBStagiaireFirstName.SelectedText = "";
            this.mTxBStagiaireFirstName.SelectionLength = 0;
            this.mTxBStagiaireFirstName.SelectionStart = 0;
            this.mTxBStagiaireFirstName.ShortcutsEnabled = true;
            this.mTxBStagiaireFirstName.Size = new System.Drawing.Size(829, 25);
            this.mTxBStagiaireFirstName.TabIndex = 24;
            this.mTxBStagiaireFirstName.UseSelectable = true;
            this.mTxBStagiaireFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBStagiaireFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelStagiaireFirstName
            // 
            this.mLabelStagiaireFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelStagiaireFirstName.AutoSize = true;
            this.mLabelStagiaireFirstName.Location = new System.Drawing.Point(25, 195);
            this.mLabelStagiaireFirstName.Name = "mLabelStagiaireFirstName";
            this.mLabelStagiaireFirstName.Size = new System.Drawing.Size(67, 19);
            this.mLabelStagiaireFirstName.TabIndex = 23;
            this.mLabelStagiaireFirstName.Text = "Prénom : ";
            // 
            // mTxBStagiaireName
            // 
            this.mTxBStagiaireName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBStagiaireName.CustomButton.Image = null;
            this.mTxBStagiaireName.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBStagiaireName.CustomButton.Name = "";
            this.mTxBStagiaireName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBStagiaireName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBStagiaireName.CustomButton.TabIndex = 1;
            this.mTxBStagiaireName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBStagiaireName.CustomButton.UseSelectable = true;
            this.mTxBStagiaireName.CustomButton.Visible = false;
            this.mTxBStagiaireName.Lines = new string[0];
            this.mTxBStagiaireName.Location = new System.Drawing.Point(175, 160);
            this.mTxBStagiaireName.MaxLength = 32767;
            this.mTxBStagiaireName.Name = "mTxBStagiaireName";
            this.mTxBStagiaireName.PasswordChar = '\0';
            this.mTxBStagiaireName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBStagiaireName.SelectedText = "";
            this.mTxBStagiaireName.SelectionLength = 0;
            this.mTxBStagiaireName.SelectionStart = 0;
            this.mTxBStagiaireName.ShortcutsEnabled = true;
            this.mTxBStagiaireName.Size = new System.Drawing.Size(829, 25);
            this.mTxBStagiaireName.TabIndex = 22;
            this.mTxBStagiaireName.UseSelectable = true;
            this.mTxBStagiaireName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBStagiaireName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelStagiaireName
            // 
            this.mLabelStagiaireName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelStagiaireName.AutoSize = true;
            this.mLabelStagiaireName.Location = new System.Drawing.Point(25, 160);
            this.mLabelStagiaireName.Name = "mLabelStagiaireName";
            this.mLabelStagiaireName.Size = new System.Drawing.Size(50, 19);
            this.mLabelStagiaireName.TabIndex = 21;
            this.mLabelStagiaireName.Text = "Nom : ";
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
            this.mTxBEntrepriseName.Lines = new string[0];
            this.mTxBEntrepriseName.Location = new System.Drawing.Point(175, 75);
            this.mTxBEntrepriseName.MaxLength = 32767;
            this.mTxBEntrepriseName.Name = "mTxBEntrepriseName";
            this.mTxBEntrepriseName.PasswordChar = '\0';
            this.mTxBEntrepriseName.ReadOnly = true;
            this.mTxBEntrepriseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBEntrepriseName.SelectedText = "";
            this.mTxBEntrepriseName.SelectionLength = 0;
            this.mTxBEntrepriseName.SelectionStart = 0;
            this.mTxBEntrepriseName.ShortcutsEnabled = true;
            this.mTxBEntrepriseName.Size = new System.Drawing.Size(829, 25);
            this.mTxBEntrepriseName.TabIndex = 20;
            this.mTxBEntrepriseName.UseSelectable = true;
            this.mTxBEntrepriseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBEntrepriseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEntrepriseName
            // 
            this.mLabelEntrepriseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelEntrepriseName.AutoSize = true;
            this.mLabelEntrepriseName.Location = new System.Drawing.Point(25, 75);
            this.mLabelEntrepriseName.Name = "mLabelEntrepriseName";
            this.mLabelEntrepriseName.Size = new System.Drawing.Size(78, 19);
            this.mLabelEntrepriseName.TabIndex = 19;
            this.mLabelEntrepriseName.Text = "Entreprise : ";
            // 
            // mLabelStagiaire
            // 
            this.mLabelStagiaire.AutoSize = true;
            this.mLabelStagiaire.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelStagiaire.Location = new System.Drawing.Point(25, 125);
            this.mLabelStagiaire.Name = "mLabelStagiaire";
            this.mLabelStagiaire.Size = new System.Drawing.Size(77, 25);
            this.mLabelStagiaire.TabIndex = 32;
            this.mLabelStagiaire.Text = "Stagiaire";
            // 
            // mCbxStagiaireClassroom
            // 
            this.mCbxStagiaireClassroom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mCbxStagiaireClassroom.FormattingEnabled = true;
            this.mCbxStagiaireClassroom.ItemHeight = 23;
            this.mCbxStagiaireClassroom.Items.AddRange(new object[] {
            "",
            "SIO 1 TP",
            "SIO 1 A",
            "SIO 2 TP",
            "SIO 2 A"});
            this.mCbxStagiaireClassroom.Location = new System.Drawing.Point(175, 230);
            this.mCbxStagiaireClassroom.Name = "mCbxStagiaireClassroom";
            this.mCbxStagiaireClassroom.Size = new System.Drawing.Size(828, 29);
            this.mCbxStagiaireClassroom.TabIndex = 33;
            this.mCbxStagiaireClassroom.UseSelectable = true;
            // 
            // mLabelStagiaireClassroom
            // 
            this.mLabelStagiaireClassroom.AutoSize = true;
            this.mLabelStagiaireClassroom.Location = new System.Drawing.Point(25, 230);
            this.mLabelStagiaireClassroom.Name = "mLabelStagiaireClassroom";
            this.mLabelStagiaireClassroom.Size = new System.Drawing.Size(56, 19);
            this.mLabelStagiaireClassroom.TabIndex = 34;
            this.mLabelStagiaireClassroom.Text = "Classe : ";
            // 
            // mLabelTuteur
            // 
            this.mLabelTuteur.AutoSize = true;
            this.mLabelTuteur.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelTuteur.Location = new System.Drawing.Point(25, 280);
            this.mLabelTuteur.Name = "mLabelTuteur";
            this.mLabelTuteur.Size = new System.Drawing.Size(59, 25);
            this.mLabelTuteur.TabIndex = 35;
            this.mLabelTuteur.Text = "Tuteur";
            // 
            // mTxBTuteurFirstName
            // 
            this.mTxBTuteurFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBTuteurFirstName.CustomButton.Image = null;
            this.mTxBTuteurFirstName.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBTuteurFirstName.CustomButton.Name = "";
            this.mTxBTuteurFirstName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBTuteurFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBTuteurFirstName.CustomButton.TabIndex = 1;
            this.mTxBTuteurFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBTuteurFirstName.CustomButton.UseSelectable = true;
            this.mTxBTuteurFirstName.CustomButton.Visible = false;
            this.mTxBTuteurFirstName.Lines = new string[0];
            this.mTxBTuteurFirstName.Location = new System.Drawing.Point(175, 350);
            this.mTxBTuteurFirstName.MaxLength = 32767;
            this.mTxBTuteurFirstName.Name = "mTxBTuteurFirstName";
            this.mTxBTuteurFirstName.PasswordChar = '\0';
            this.mTxBTuteurFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBTuteurFirstName.SelectedText = "";
            this.mTxBTuteurFirstName.SelectionLength = 0;
            this.mTxBTuteurFirstName.SelectionStart = 0;
            this.mTxBTuteurFirstName.ShortcutsEnabled = true;
            this.mTxBTuteurFirstName.Size = new System.Drawing.Size(829, 25);
            this.mTxBTuteurFirstName.TabIndex = 39;
            this.mTxBTuteurFirstName.UseSelectable = true;
            this.mTxBTuteurFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBTuteurFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelTuteurFirstName
            // 
            this.mLabelTuteurFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelTuteurFirstName.AutoSize = true;
            this.mLabelTuteurFirstName.Location = new System.Drawing.Point(25, 350);
            this.mLabelTuteurFirstName.Name = "mLabelTuteurFirstName";
            this.mLabelTuteurFirstName.Size = new System.Drawing.Size(67, 19);
            this.mLabelTuteurFirstName.TabIndex = 38;
            this.mLabelTuteurFirstName.Text = "Prénom : ";
            // 
            // mTxBTuteurName
            // 
            this.mTxBTuteurName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBTuteurName.CustomButton.Image = null;
            this.mTxBTuteurName.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBTuteurName.CustomButton.Name = "";
            this.mTxBTuteurName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBTuteurName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBTuteurName.CustomButton.TabIndex = 1;
            this.mTxBTuteurName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBTuteurName.CustomButton.UseSelectable = true;
            this.mTxBTuteurName.CustomButton.Visible = false;
            this.mTxBTuteurName.Lines = new string[0];
            this.mTxBTuteurName.Location = new System.Drawing.Point(175, 315);
            this.mTxBTuteurName.MaxLength = 32767;
            this.mTxBTuteurName.Name = "mTxBTuteurName";
            this.mTxBTuteurName.PasswordChar = '\0';
            this.mTxBTuteurName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBTuteurName.SelectedText = "";
            this.mTxBTuteurName.SelectionLength = 0;
            this.mTxBTuteurName.SelectionStart = 0;
            this.mTxBTuteurName.ShortcutsEnabled = true;
            this.mTxBTuteurName.Size = new System.Drawing.Size(829, 25);
            this.mTxBTuteurName.TabIndex = 37;
            this.mTxBTuteurName.UseSelectable = true;
            this.mTxBTuteurName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBTuteurName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelTuteurName
            // 
            this.mLabelTuteurName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelTuteurName.AutoSize = true;
            this.mLabelTuteurName.Location = new System.Drawing.Point(25, 315);
            this.mLabelTuteurName.Name = "mLabelTuteurName";
            this.mLabelTuteurName.Size = new System.Drawing.Size(50, 19);
            this.mLabelTuteurName.TabIndex = 36;
            this.mLabelTuteurName.Text = "Nom : ";
            // 
            // mDTDateBegin
            // 
            this.mDTDateBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mDTDateBegin.Location = new System.Drawing.Point(175, 505);
            this.mDTDateBegin.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mDTDateBegin.MinimumSize = new System.Drawing.Size(0, 29);
            this.mDTDateBegin.Name = "mDTDateBegin";
            this.mDTDateBegin.Size = new System.Drawing.Size(828, 29);
            this.mDTDateBegin.TabIndex = 40;
            this.mDTDateBegin.UseStyleColors = true;
            this.mDTDateBegin.Value = new System.DateTime(2016, 10, 13, 0, 0, 0, 0);
            // 
            // mLabelContrat
            // 
            this.mLabelContrat.AutoSize = true;
            this.mLabelContrat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelContrat.Location = new System.Drawing.Point(25, 470);
            this.mLabelContrat.Name = "mLabelContrat";
            this.mLabelContrat.Size = new System.Drawing.Size(68, 25);
            this.mLabelContrat.TabIndex = 41;
            this.mLabelContrat.Text = "Contrat";
            // 
            // mLabelDateBegin
            // 
            this.mLabelDateBegin.AutoSize = true;
            this.mLabelDateBegin.Location = new System.Drawing.Point(25, 505);
            this.mLabelDateBegin.Name = "mLabelDateBegin";
            this.mLabelDateBegin.Size = new System.Drawing.Size(98, 19);
            this.mLabelDateBegin.TabIndex = 42;
            this.mLabelDateBegin.Text = "Date de Début ";
            // 
            // mLabelDateEnd
            // 
            this.mLabelDateEnd.AutoSize = true;
            this.mLabelDateEnd.Location = new System.Drawing.Point(25, 544);
            this.mLabelDateEnd.Name = "mLabelDateEnd";
            this.mLabelDateEnd.Size = new System.Drawing.Size(76, 19);
            this.mLabelDateEnd.TabIndex = 44;
            this.mLabelDateEnd.Text = "Date de Fin";
            // 
            // mDTDateEnd
            // 
            this.mDTDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mDTDateEnd.Location = new System.Drawing.Point(175, 544);
            this.mDTDateEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mDTDateEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.mDTDateEnd.Name = "mDTDateEnd";
            this.mDTDateEnd.Size = new System.Drawing.Size(828, 29);
            this.mDTDateEnd.TabIndex = 43;
            this.mDTDateEnd.Value = new System.DateTime(2016, 10, 13, 0, 0, 0, 0);
            // 
            // mRadioButtonApprentissage
            // 
            this.mRadioButtonApprentissage.AutoSize = true;
            this.mRadioButtonApprentissage.Location = new System.Drawing.Point(3, 5);
            this.mRadioButtonApprentissage.Name = "mRadioButtonApprentissage";
            this.mRadioButtonApprentissage.Size = new System.Drawing.Size(151, 15);
            this.mRadioButtonApprentissage.TabIndex = 45;
            this.mRadioButtonApprentissage.Text = "Contrat d\'Apprentissage";
            this.mRadioButtonApprentissage.UseSelectable = true;
            // 
            // mRadioButtonStage
            // 
            this.mRadioButtonStage.AutoSize = true;
            this.mRadioButtonStage.Location = new System.Drawing.Point(160, 5);
            this.mRadioButtonStage.Name = "mRadioButtonStage";
            this.mRadioButtonStage.Size = new System.Drawing.Size(133, 15);
            this.mRadioButtonStage.TabIndex = 46;
            this.mRadioButtonStage.Text = "Convention de Stage";
            this.mRadioButtonStage.UseSelectable = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(299, 5);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(188, 15);
            this.metroRadioButton3.TabIndex = 47;
            this.metroRadioButton3.Text = "Contrat de Professionnalisation";
            this.metroRadioButton3.UseSelectable = true;
            // 
            // mRadioButton6semaines
            // 
            this.mRadioButton6semaines.AutoSize = true;
            this.mRadioButton6semaines.Location = new System.Drawing.Point(3, 3);
            this.mRadioButton6semaines.Name = "mRadioButton6semaines";
            this.mRadioButton6semaines.Size = new System.Drawing.Size(81, 15);
            this.mRadioButton6semaines.TabIndex = 48;
            this.mRadioButton6semaines.Text = "6 semaines";
            this.mRadioButton6semaines.UseSelectable = true;
            // 
            // mRadioButton1an
            // 
            this.mRadioButton1an.AutoSize = true;
            this.mRadioButton1an.Location = new System.Drawing.Point(90, 3);
            this.mRadioButton1an.Name = "mRadioButton1an";
            this.mRadioButton1an.Size = new System.Drawing.Size(45, 15);
            this.mRadioButton1an.TabIndex = 49;
            this.mRadioButton1an.Text = "1 an";
            this.mRadioButton1an.UseSelectable = true;
            // 
            // mRadioButton2ans
            // 
            this.mRadioButton2ans.AutoSize = true;
            this.mRadioButton2ans.Location = new System.Drawing.Point(141, 3);
            this.mRadioButton2ans.Name = "mRadioButton2ans";
            this.mRadioButton2ans.Size = new System.Drawing.Size(50, 15);
            this.mRadioButton2ans.TabIndex = 50;
            this.mRadioButton2ans.Text = "2 ans";
            this.mRadioButton2ans.UseSelectable = true;
            // 
            // panelChoixContrat
            // 
            this.panelChoixContrat.Controls.Add(this.mRadioButtonApprentissage);
            this.panelChoixContrat.Controls.Add(this.mRadioButtonStage);
            this.panelChoixContrat.Controls.Add(this.metroRadioButton3);
            this.panelChoixContrat.Location = new System.Drawing.Point(175, 125);
            this.panelChoixContrat.Name = "panelChoixContrat";
            this.panelChoixContrat.Size = new System.Drawing.Size(826, 25);
            this.panelChoixContrat.TabIndex = 51;
            // 
            // panelChoixDurée
            // 
            this.panelChoixDurée.Controls.Add(this.mRadioButton6semaines);
            this.panelChoixDurée.Controls.Add(this.mRadioButton1an);
            this.panelChoixDurée.Controls.Add(this.mRadioButton2ans);
            this.panelChoixDurée.Location = new System.Drawing.Point(175, 470);
            this.panelChoixDurée.Name = "panelChoixDurée";
            this.panelChoixDurée.Size = new System.Drawing.Size(826, 25);
            this.panelChoixDurée.TabIndex = 52;
            // 
            // AddContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 658);
            this.Controls.Add(this.panelChoixDurée);
            this.Controls.Add(this.panelChoixContrat);
            this.Controls.Add(this.mLabelDateEnd);
            this.Controls.Add(this.mDTDateEnd);
            this.Controls.Add(this.mLabelDateBegin);
            this.Controls.Add(this.mLabelContrat);
            this.Controls.Add(this.mDTDateBegin);
            this.Controls.Add(this.mTxBTuteurFirstName);
            this.Controls.Add(this.mLabelTuteurFirstName);
            this.Controls.Add(this.mTxBTuteurName);
            this.Controls.Add(this.mLabelTuteurName);
            this.Controls.Add(this.mLabelTuteur);
            this.Controls.Add(this.mLabelStagiaireClassroom);
            this.Controls.Add(this.mCbxStagiaireClassroom);
            this.Controls.Add(this.mLabelStagiaire);
            this.Controls.Add(this.mButtonAddContrat);
            this.Controls.Add(this.mTxBTuteurEmail);
            this.Controls.Add(this.mLabelTuteurEmail);
            this.Controls.Add(this.mTxBTuteurTelephone);
            this.Controls.Add(this.mLabelTuteurTelephone);
            this.Controls.Add(this.mTxBStagiaireFirstName);
            this.Controls.Add(this.mLabelStagiaireFirstName);
            this.Controls.Add(this.mTxBStagiaireName);
            this.Controls.Add(this.mLabelStagiaireName);
            this.Controls.Add(this.mTxBEntrepriseName);
            this.Controls.Add(this.mLabelEntrepriseName);
            this.Controls.Add(this.mLinkBack);
            this.Controls.Add(this.mLabelTitle);
            this.MinimumSize = new System.Drawing.Size(400, 658);
            this.Name = "AddContrat";
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddContrat)).EndInit();
            this.panelChoixContrat.ResumeLayout(false);
            this.panelChoixContrat.PerformLayout();
            this.panelChoixDurée.ResumeLayout(false);
            this.panelChoixDurée.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager mSMAddContrat;
        private MetroFramework.Controls.MetroLink mLinkBack;
        private MetroFramework.Controls.MetroLabel mLabelTitle;
        private MetroFramework.Controls.MetroTile mButtonAddContrat;
        private MetroFramework.Controls.MetroTextBox mTxBTuteurEmail;
        private MetroFramework.Controls.MetroLabel mLabelTuteurEmail;
        private MetroFramework.Controls.MetroTextBox mTxBTuteurTelephone;
        private MetroFramework.Controls.MetroLabel mLabelTuteurTelephone;
        private MetroFramework.Controls.MetroTextBox mTxBStagiaireFirstName;
        private MetroFramework.Controls.MetroLabel mLabelStagiaireFirstName;
        private MetroFramework.Controls.MetroTextBox mTxBStagiaireName;
        private MetroFramework.Controls.MetroLabel mLabelStagiaireName;
        private MetroFramework.Controls.MetroTextBox mTxBEntrepriseName;
        private MetroFramework.Controls.MetroLabel mLabelEntrepriseName;
        private MetroFramework.Controls.MetroLabel mLabelStagiaire;
        private MetroFramework.Controls.MetroLabel mLabelStagiaireClassroom;
        private MetroFramework.Controls.MetroComboBox mCbxStagiaireClassroom;
        private MetroFramework.Controls.MetroLabel mLabelTuteur;
        private MetroFramework.Controls.MetroTextBox mTxBTuteurFirstName;
        private MetroFramework.Controls.MetroLabel mLabelTuteurFirstName;
        private MetroFramework.Controls.MetroTextBox mTxBTuteurName;
        private MetroFramework.Controls.MetroLabel mLabelTuteurName;
        private MetroFramework.Controls.MetroDateTime mDTDateBegin;
        private MetroFramework.Controls.MetroLabel mLabelDateEnd;
        private MetroFramework.Controls.MetroDateTime mDTDateEnd;
        private MetroFramework.Controls.MetroLabel mLabelDateBegin;
        private MetroFramework.Controls.MetroLabel mLabelContrat;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton mRadioButtonStage;
        private MetroFramework.Controls.MetroRadioButton mRadioButtonApprentissage;
        private MetroFramework.Controls.MetroRadioButton mRadioButton2ans;
        private MetroFramework.Controls.MetroRadioButton mRadioButton1an;
        private MetroFramework.Controls.MetroRadioButton mRadioButton6semaines;
        private System.Windows.Forms.Panel panelChoixContrat;
        private System.Windows.Forms.Panel panelChoixDurée;
    }
}