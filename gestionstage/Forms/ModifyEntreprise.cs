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

namespace gestionstage.Forms
{
    public partial class ModifyEntreprise : MetroFramework.Forms.MetroForm
    {
        public ModifyEntreprise()
        {
            InitializeComponent();
            this.StyleManager = mSMModifyEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
        }

        private void mLinkBack_Click(object sender, EventArgs e)
        {
            //TODO : Changer pour la page précédente (ViewEntreprise)
            ListEntreprise formBack = new ListEntreprise();
            formBack.Show();
            this.Close();
        }
    }
}
