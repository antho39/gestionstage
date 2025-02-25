﻿using System;
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
            mTxBEntreprisePostalCode.Text = lEntreprise.Cp;
            mTxBEntrepriseCity.Text = lEntreprise.Ville;
            mTxBEntrepriseTelephone.Text = lEntreprise.Telephone;
            if (mTxBEntrepriseTelephone.Text == "") { mTxBEntrepriseTelephone.Text = "Non renseigné"; }
            mTxBEntrepriseEmail.Text = lEntreprise.Email;
            if (mTxBEntrepriseEmail.Text == "") { mTxBEntrepriseEmail.Text = "Non renseigné"; }
        }

        private void refreshGrid()
        {
            //Chargement de la liste des entreprises
            mGridContrat.RowTemplate.MinimumHeight = 35;
            mGridContrat.AutoGenerateColumns = false;
            // Fait le lien entre la colonne et le noms des colonnes du DataTable pour s'auto remplir
            mGridContrat.Columns[0].DataPropertyName = "id"; //Attention Colonne Hide
            mGridContrat.Columns[1].DataPropertyName = "t_nom";
            mGridContrat.Columns[2].DataPropertyName = "t_prenom";
            mGridContrat.Columns[3].DataPropertyName = "c_nom";
            mGridContrat.Columns[4].DataPropertyName = "s_nom";
            mGridContrat.Columns[5].DataPropertyName = "s_prenom";
            mGridContrat.Columns[6].DataPropertyName = "typecontrat_nom";
            mGridContrat.Columns[7].DataPropertyName = "date_debut";
            mGridContrat.Columns[8].DataPropertyName = "date_fin";
            mGridContrat.Columns[9].DataPropertyName = "appreciation";            
            mGridContrat.DataSource = DaoContrat.dtReadById(lEntreprise.Id);
        }

        private void mGridContrat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clique sur la column Modifier (Modifier) et Pas sur le header
            if (e.ColumnIndex == mGridContrat.Columns["Modifier"].Index && e.RowIndex >= 0)
            {
                ModifyContrat formModifyContrat = new ModifyContrat(DaoContrat.readOne(mGridContrat.Rows[e.RowIndex].Cells[0].Value.ToString()), lEntreprise);
                formModifyContrat.Show();
                this.Close();
            }
            else if (e.ColumnIndex == mGridContrat.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer le contrat ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DaoContrat.delete(mGridContrat.Rows[e.RowIndex].Cells[0].Value.ToString());
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
    }
}
