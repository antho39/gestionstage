using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using perso
using gestionstage.Properties;
using gestionstage.Classes;
using gestionstage.Dao;

namespace gestionstage.Forms
{
    public partial class AddContrat : MetroFramework.Forms.MetroForm
    {
        Entreprise lEntreprise;

        public AddContrat(string siret = null)
        {
            this.lEntreprise = DaoEntreprise.readOneBySiret(siret);

            InitializeComponent();
            this.StyleManager = mSMAddContrat;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;

            refreshStart();
        }

        // --------------------------------------------------------------------
        // Bouttons et Cliques :
        // --------------------------------------------------------------------
        private void mLinkBack_Click(object sender, EventArgs e)
        {
            ListEntreprise formBack = new ListEntreprise();
            formBack.Show();
            this.Close();
        }

        private void mRadioButtonApprentissage_CheckedChanged(object sender, EventArgs e)
        {
            mRadioButton2ans.Select();
        }

        private void mRadioButtonStage_CheckedChanged(object sender, EventArgs e)
        {
            mRadioButton6semaines.Select();
        }

        private void mRadioButtonContratPro_CheckedChanged(object sender, EventArgs e)
        {
            mRadioButton2ans.Select();
        }

        private void mDTDateBegin_ValueChanged(object sender, EventArgs e)
        {
            if (mRadioButton6semaines.Checked == true)
            {
                mDTDateEnd.Value = mDTDateBegin.Value.AddDays(6*7);
                mDTDateEnd.Value = mDTDateEnd.Value.AddDays(-1);
            }
            else if (mRadioButton1an.Checked == true)
            {
                mDTDateEnd.Value = mDTDateBegin.Value.AddYears(1);
            }
            else if (mRadioButton2ans.Checked == true)
            {
                mDTDateEnd.Value = mDTDateBegin.Value.AddYears(2);
            }
        }

        private void mButtonAddContrat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mCbxStagiaireClassroom.Items.ToString());
            int typeContrat;

            if (mRadioButtonApprentissage.Checked == true)
            {
                typeContrat = 1;
            }
            else if (mRadioButtonStage.Checked == true)
            {
                typeContrat = 2;
            }
            else if (mRadioButtonContratPro.Checked == true)
            {
                typeContrat = 3;
            }
            //DaoContrat.create(new Contrat()); // TODO
        }

        // --------------------------------------------------------------------
        // Fonctions de refresh :
        // --------------------------------------------------------------------
        private void refreshStart()
        {
            mTxBEntrepriseName.Text = lEntreprise.Nom;
            mRadioButtonApprentissage.Select();
            mRadioButton2ans.Select();

            List<Formation> lesFormations = DaoFormation.readAll();
            mCbxStagiaireClassroom.ValueMember = "id";
            mCbxStagiaireClassroom.DisplayMember = "nom";
            mCbxStagiaireClassroom.DataSource = lesFormations;
        }
    }
}