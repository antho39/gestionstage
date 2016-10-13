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
    public partial class AddEntreprise : MetroFramework.Forms.MetroForm
    {
        public AddEntreprise()
        {
            InitializeComponent();
            this.StyleManager = mSMAddEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
        }

        private void mLinkBack_Click(object sender, EventArgs e)
        {
            ListEntreprise MainFormListEntreprise = new ListEntreprise();
            MainFormListEntreprise.Show();
            this.Close();
        }
    }
}
