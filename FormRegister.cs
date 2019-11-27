using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginC01
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        private void frm_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Show status frm_login : "+frm_login.ActiveForm);
        }
    }
}
