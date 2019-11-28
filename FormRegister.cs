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
    public partial class Frm_register : Form
    {
        public Frm_register()
        {
            InitializeComponent();
        }


        private void Frm_register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_register_Load(object sender, EventArgs e)
        {
/*            Frm_login frm_login = new Frm_login();

            this.Hide();
            frm_login.ShowDialog();
            this.Close();*/
        }

        private void Frm_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_login frm_login = new Frm_login();

            this.Hide();
            frm_login.ShowDialog();
            this.Close();
            frm_login.Dispose();
        }
    }
}
