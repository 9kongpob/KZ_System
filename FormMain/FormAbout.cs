using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Activated(object sender, EventArgs e)
        {
            this.Text = "About KZ System : Activated";
        }

        private void FormAbout_Deactivate(object sender, EventArgs e)
        {
            this.Text = "About KZ System : Deactivated";
        }
    }
}
