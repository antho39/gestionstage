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
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using gestionstage.Dao;

namespace gestionstage.Forms
{
    public partial class ListEntreprise : MetroFramework.Forms.MetroForm
    {
        private BindingSource bindingSListEntreprise = new BindingSource();

        public ListEntreprise()
        {
            InitializeComponent();
            this.StyleManager = mSMListEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
            
        }

        private void ListEntreprise_Load(object sender, EventArgs e)
        {
            refreshGrid();      //Affichage des entreprises dans le tableau
            refreshColor();     //Affichage des tuiles de couleurs, pour la selection du thème
        }

        // --------------------------------------------------------------------
        // Button et Clics :
        // --------------------------------------------------------------------
        private void mButtonAddEntreprise_Click(object sender, EventArgs e)
        {
            AddEntreprise formAddEntreprise = new AddEntreprise();
            formAddEntreprise.Show();
            this.Close();
        }

        void _tile_Click(object sender, EventArgs e)
        {
            StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        private void mButtonConfirmColor_Click(object sender, EventArgs e)
        {
            Settings.Default.Style = StyleManager.Style;
            Settings.Default.Save();
        }

        private void mGridEntreprises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clique sur la column dataGridViewTextBoxColumn3 (Afficher) et Pas sur le header
            if (e.ColumnIndex == mGridEntreprises.Columns["dataGridViewTextBoxColumn3"].Index && e.RowIndex >= 0)
            {
                ViewEntreprise formViewEntreprise = new ViewEntreprise(mGridEntreprises.Rows[e.RowIndex].Cells[0].Value.ToString());
                formViewEntreprise.Show();
                this.Close();
            }
            // Si clique sur la column dataGridViewTextBoxColumn4 (Modifier) et Pas sur le header
            else if (e.ColumnIndex == mGridEntreprises.Columns["dataGridViewTextBoxColumn4"].Index && e.RowIndex >= 0)
            {
                ModifyEntreprise formModifyEntreprise = new ModifyEntreprise(mGridEntreprises.Rows[e.RowIndex].Cells[0].Value.ToString());
                formModifyEntreprise.Show();
                this.Close();
            }
            // Si clique sur la column dataGridViewTextBoxColumn5 (Supprimer) et Pas sur le header
            else if (e.ColumnIndex == mGridEntreprises.Columns["dataGridViewTextBoxColumn5"].Index && e.RowIndex >= 0)
            {

                DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer l'entreprise ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DaoEntreprise.delete(mGridEntreprises.Rows[e.RowIndex].Cells[0].Value.ToString());
                    refreshGrid();
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
        }


        // --------------------------------------------------------------------
        // Chargements de forms rapide TODO a delete
        // --------------------------------------------------------------------
        private void mTestAddContrat_Click(object sender, EventArgs e)
        {
            AddContrat formAddContrat = new AddContrat();
            formAddContrat.Show();
            this.Close();
        }

        private void mTESTAddEntreprise_Click(object sender, EventArgs e)
        {
            AddEntreprise formAddEntreprise = new AddEntreprise();
            formAddEntreprise.Show();
            this.Close();
        }

        private void mTESTModifyEntreprise_Click(object sender, EventArgs e)
        {
            ModifyEntreprise formModifyEntreprise = new ModifyEntreprise();
            formModifyEntreprise.Show();
            this.Close();
        }

        private void mTESTViewEntreprise_Click(object sender, EventArgs e)
        {
            ViewEntreprise formViewEntreprise = new ViewEntreprise();
            formViewEntreprise.Show();
            this.Close();
        }


        // --------------------------------------------------------------------
        // Fonctions de refresh :
        // --------------------------------------------------------------------
        private void refreshGrid()
        {
            //Chargement de la liste des entreprises
            mGridEntreprises.RowTemplate.MinimumHeight = 35;
            mGridEntreprises.AutoGenerateColumns = false;
            mGridEntreprises.Columns[0].DataPropertyName = "siret";
            mGridEntreprises.Columns[1].DataPropertyName = "nom";
            mGridEntreprises.DataSource = DaoEntreprise.dtReadAll();
        }

        private void refreshColor()
        {
            //Chargement des tuiles de couleurs, pour le changement de thème
            for (int i = 3; i < 13; i++) // i = 3 pour cacher Blanc et Noir.
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(185, 100);
                _tile.Tag = i; //Valeur de la couleur
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                ConteneurCouleurs.Controls.Add(_tile);
            }
        }
    }
}
