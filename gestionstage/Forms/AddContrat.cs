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
using MetroFramework;

namespace gestionstage.Forms
{
    public partial class AddContrat : MetroFramework.Forms.MetroForm
    {
        Entreprise lEntreprise;
        List<string> lsError = new List<string>();

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
           int typeContrat = 0;

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

            CheckErrorSNom();
            CheckErrorSPrenom();
            CheckErrorTNom();
            CheckErrorTPrenom();
            CheckErrorTTelephone();
            CheckErrorTEmail();

            if (lsError.Count == 0)
            {
                DaoContrat.create(new Contrat(typeContrat, Convert.ToInt16(mCbxStagiaireClassroom.SelectedValue.ToString()), mTxBStagiaireName.Text, mTxBStagiaireFirstName.Text, mTxBTuteurName.Text, mTxBTuteurFirstName.Text, mTxBTuteurEmail.Text, mTxBTuteurTelephone.Text, mDTDateBegin.Value, mDTDateEnd.Value, mTxBCommentaire.Text, 0, lEntreprise.Id)); // TODO

                ViewEntreprise FormViewEntreprise = new ViewEntreprise();
                FormViewEntreprise.Show();
                this.Close();
            }
            else
            {
                // TODO : Si trop d'erreurs, elles ne sont pas toutes affiché, trouver un moyen de faire un ascenseur vertical.
                string lesErreurs = "";
                foreach (string erreur in lsError)
                {
                    lesErreurs += erreur + "\n";
                }
                MetroMessageBox.Show(this, lesErreurs, "Erreur");
                lsError.Clear();
            }


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



        // --------------------------------------------------------------------
        // Fonctions de vérification des champs avant l'ajout de l'entreprise :
        // --------------------------------------------------------------------
        private void CheckErrorSNom()
        {
            if (mTxBStagiaireName.Text == "")
            {
                lsError.Add("Champ \"nom du stagiaire\" vide");
            }
        }
        private void CheckErrorSPrenom()
        {
            if (mTxBStagiaireFirstName.Text == "")
            {
                lsError.Add("Champ \"prenom du stagiaire\" vide");
            }
        }
        private void CheckErrorTNom()
        {
            if (mTxBTuteurName.Text == "")
            {
                lsError.Add("Champ \"nom du tuteur\" vide");
            }
        }
        private void CheckErrorTPrenom()
        {
            if (mTxBTuteurFirstName.Text == "")
            {
                lsError.Add("Champ \"prenom du tuteur\" vide");
            }
        }
        private void CheckErrorTTelephone()
        {
            if (!(mTxBTuteurTelephone.Text == "Non renseigné"))
            {
                if (mTxBTuteurTelephone.Text == "")
                {
                    lsError.Add("Champ \"Téléphone du tuteur\" vide");
                }
                else if (!(IsNumeric(mTxBTuteurTelephone.Text)))
                {
                    lsError.Add("Champ \"Téléphone du tuteur\" n'est pas composé de chiffres");
                }
                else if (IsNumeric(mTxBTuteurTelephone.Text) && mTxBTuteurTelephone.Text.Length != 10)
                {
                    lsError.Add("Champ \"Téléphone du tuteur\" doit être composé de 10 chiffres");
                }
            }
        }
        private void CheckErrorTEmail()
        {
            if (!(mTxBTuteurEmail.Text == "Non renseigné"))
            {
                if (mTxBTuteurEmail.Text == "")
                {
                    lsError.Add("Champ \"E-mail du tuteur\" vide");
                }
                if (mTxBTuteurEmail.Text.IndexOf("@") > -1)
                {
                    if (mTxBTuteurEmail.Text.IndexOf(".", mTxBTuteurEmail.Text.IndexOf("@")) > mTxBTuteurEmail.Text.IndexOf("@"))
                    {
                        lsError.Add("Champ \"E-mail du tuteur\" n'est pas un E-mail valide");
                    }
                }
            }
        }

        // --------------------------------------------------------------------
        // Fonctions privé :
        // --------------------------------------------------------------------
        // Renvois true si la chaine passé en paramètre est numérique
        private bool IsNumeric(string someNumber)
        {
            long test;
            if (Int64.TryParse(someNumber, out test))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}