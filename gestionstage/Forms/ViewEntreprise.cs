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
using gestionstage.Dao;
using gestionstage.Classes;
using MetroFramework;

namespace gestionstage.Forms
{
    public partial class ViewEntreprise : MetroFramework.Forms.MetroForm
    {
        Entreprise lEntreprise;

        public ViewEntreprise(string siret = null)
        {
            this.lEntreprise = DaoEntreprise.readOneBySiret(siret);

            InitializeComponent();
            this.StyleManager = mSMViewEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;

            refreshLabels();
            refreshGrid();
        }

        // --------------------------------------------------------------------
        // Bouttons et Cliques :
        // --------------------------------------------------------------------
        private void mLinkBack_Click(object sender, EventArgs e)
        {
            //TODO : Changer pour la page précédente (ViewEntreprise)
            ListEntreprise formBack = new ListEntreprise();
            formBack.Show();
            this.Close();
        }

        private void mButtonAddContrat_Click(object sender, EventArgs e)
        {
            AddContrat formAddContrat = new AddContrat(lEntreprise.Siret);
            formAddContrat.Show();
            this.Close();
        }

        private void mButtonModifyEntreprise_Click(object sender, EventArgs e)
        {
            ModifyEntreprise formModifyEntreprise = new ModifyEntreprise(lEntreprise.Siret);
            formModifyEntreprise.Show();
            this.Close();
        }

        private void mButtonDeleteEntreprise_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer l'entreprise ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DaoEntreprise.delete(lEntreprise.Siret);
                ListEntreprise formBack = new ListEntreprise();
                formBack.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                // Ne rien faire
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        // --------------------------------------------------------------------
        // Fonctions de refresh :
        // --------------------------------------------------------------------
        private void refreshLabels()
        {
            //Précharge les labels
            mTxBEntrepriseSiret.Text = lEntreprise.Siret;
            mTxBEntrepriseName.Text = lEntreprise.Nom;
            mTxBEntrepriseAdresse.Text = lEntreprise.Adresse;
            mTxBEntreprisePostalCode.Text = lEntreprise.CodePostale;
            mTxBEntrepriseCity.Text = lEntreprise.Ville;
            mTxBEntrepriseTelephone.Text = lEntreprise.Telephone;
            if (mTxBEntrepriseTelephone.Text == "") { mTxBEntrepriseTelephone.Text = "Non renseigné"; }
            mTxBEntrepriseEmail.Text = lEntreprise.Mail;
            if (mTxBEntrepriseEmail.Text == "") { mTxBEntrepriseEmail.Text = "Non renseigné"; }
        }

        private void refreshGrid()
        {
            //Chargement de la liste des entreprises
            mGridContrat.RowTemplate.MinimumHeight = 35;
            mGridContrat.AutoGenerateColumns = false;
            // Fait le lien entre la colonne et le noms des colonnes du DataTable pour s'auto remplir
            mGridContrat.Columns[0].DataPropertyName = "t_nom";
            mGridContrat.Columns[1].DataPropertyName = "t_prenom";
            mGridContrat.Columns[2].DataPropertyName = "c_nom";
            mGridContrat.Columns[3].DataPropertyName = "s_nom";
            mGridContrat.Columns[4].DataPropertyName = "s_prenom";
            mGridContrat.Columns[5].DataPropertyName = "date_debut";
            mGridContrat.Columns[6].DataPropertyName = "date_fin";
            mGridContrat.Columns[7].DataPropertyName = "appreciation";            
            mGridContrat.DataSource = DaoContrat.dtReadById(lEntreprise.Id);
        }
    }
}
