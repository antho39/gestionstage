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
    public partial class ViewEntreprise : MetroFramework.Forms.MetroForm
    {
        public ViewEntreprise()
        {
            InitializeComponent();
            this.StyleManager = mSMViewEntreprise;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
        }
    }
}
