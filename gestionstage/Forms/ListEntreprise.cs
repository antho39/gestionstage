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
            //Chargement de la liste des entreprises
            mGridEntreprises.AutoGenerateColumns = false;
            mGridEntreprises.Columns[0].DataPropertyName = "siret";
            mGridEntreprises.Columns[1].DataPropertyName = "nom";
            mGridEntreprises.DataSource = DaoEntreprise.dtReadAll();


            //Chargement des tuiles de couleurs, pour le changement de thème
            for (int i =1; i < 13; i++)
            {
                if (i == 2)
                { i = 3; } // Cache le blanc
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(185, 100);
                _tile.Tag = i; //Valeur de la couleur
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                ConteneurCouleurs.Controls.Add(_tile);
            }
        }

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
    }
}
