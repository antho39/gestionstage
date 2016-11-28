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
using gestionstage.Classes;
using gestionstage.Dao;

namespace gestionstage.Forms
{
    public partial class ListEntreprise : MetroFramework.Forms.MetroForm
    {
        DataTable dtListeEntreprise = DaoEntreprise.dtReadAll();

        public ListEntreprise()
        {         
            InitializeComponent();
            this.StyleManager = mSMListEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
            
        }

        private void ListEntreprise_Load(object sender, EventArgs e)
        {
            refreshDTListeEntreprise();
            refreshGrid(dtListeEntreprise);      //Affichage des entreprises dans le tableau
            refreshColor();                     //Affichage des tuiles de couleurs, pour la selection du thème
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
            if (!(mGridEntreprises.Rows[e.RowIndex].Cells[1].Value.ToString() == "Aucun Résultat")) // Si le nom est = à Aucun Résultat (ligne de recherche)
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
                        refreshDTListeEntreprise();
                        refreshGrid(dtListeEntreprise);
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
        }

        private void mTBSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                refreshGrid(dtListeEntreprise.Select("nom LIKE '%" + mTBSearch.Text + "%'").CopyToDataTable());
            }
            catch
            {
                // Création d'une DataTable avec une seul ligne "Aucun Résultat"
                DataTable dtVide = new DataTable();
                dtVide.Columns.Add("nom", typeof(string));
                dtVide.Rows.Add("Aucun Résultat");

                refreshGrid(dtVide);
            }
        }

        private void mTBSearch_Enter(object sender, EventArgs e)
        {
            mTBSearch.Text = "";
        }

        private void mTBSearch_Leave(object sender, EventArgs e)
        {
            if (mTBSearch.Text == "")
            {
                mTBSearch.Text = "Rechercher . . .";
            }
        }

        // --------------------------------------------------------------------
        // Fonctions de refresh :
        // --------------------------------------------------------------------
        private void refreshGrid(DataTable DataTableForFill)
        {
            //Chargement de la liste des entreprises
            mGridEntreprises.RowTemplate.MinimumHeight = 35;
            mGridEntreprises.AutoGenerateColumns = false;
            mGridEntreprises.Columns[0].DataPropertyName = "siret";
            mGridEntreprises.Columns[1].DataPropertyName = "nom";
            mGridEntreprises.DataSource = DataTableForFill;
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

        private void refreshDTListeEntreprise()
        {
            dtListeEntreprise = DaoEntreprise.dtReadAll();
        }
    }
}
