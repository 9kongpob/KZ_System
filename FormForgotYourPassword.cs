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
    public partial class frm_fgpassword : Form
    {
        public frm_fgpassword()
        {
            InitializeComponent();
        }

        private void frm_fgpassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Form 1 : " + this.ShowDialog()) ;

            //Application.Exit();
            frm_login frm_login = new frm_login();
            this.Hide();
            frm_login.ShowDialog();
        }

        private void frm_fgpassword_Load(object sender, EventArgs e)
        {
            tb_emailReset.Text = "Email";
            tb_emailReset.ForeColor = Color.Gray;

        }

        private void tb_emailReset_Enter(object sender, EventArgs e)
        {
            if (tb_emailReset.Text == "Email")
            {
                tb_emailReset.Text = "";
            }
        }

        private void tb_emailReset_Leave(object sender, EventArgs e)
        {
            if (tb_emailReset.Text == "")
            {
                tb_emailReset.Text = "Email";
                tb_emailReset.ForeColor = Color.Gray;
            }
        }

        private void frm_fgpassword_Click(object sender, EventArgs e)
        {
            if (tb_emailReset.Text == "")
            {
                tb_emailReset.Text = "Email";
                tb_emailReset.ForeColor = Color.Gray;
            }

            ActiveControl = null;
        }
    }
}
