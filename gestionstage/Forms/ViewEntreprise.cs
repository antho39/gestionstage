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

namespace gestionstage.Forms
{
    public partial class ViewEntreprise : MetroFramework.Forms.MetroForm
    {
        public ViewEntreprise()
        {
            InitializeComponent();
            this.StyleManager = mSMViewEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;

            refreshGrid();
        }

        private void mLinkBack_Click(object sender, EventArgs e)
        {
            //TODO : Changer pour la page précédente (ViewEntreprise)
            ListEntreprise formBack = new ListEntreprise();
            formBack.Show();
            this.Close();
        }

        private void refreshGrid()
        {
            //Chargement de la liste des entreprises
            mGridContrat.AutoGenerateColumns = false;
            mGridContrat.Columns[0].DataPropertyName = "t_nom";
            mGridContrat.Columns[1].DataPropertyName = "t_prenom";
            mGridContrat.Columns[2].DataPropertyName = "c_nom";
            mGridContrat.Columns[3].DataPropertyName = "s_nom";
            mGridContrat.Columns[4].DataPropertyName = "s_prenom";
            mGridContrat.Columns[5].DataPropertyName = "date_debut";
            mGridContrat.Columns[6].DataPropertyName = "date_fin";
            mGridContrat.Columns[7].DataPropertyName = "appreciation";
            mGridContrat.DataSource = DaoContrat.dtReadAll();
        }
    }
}
