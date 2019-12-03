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
    public partial class Frm_fgpassword : Form
    {
        public Frm_fgpassword()
        {
            InitializeComponent();
        }

        private void Frm_fgpassword_FormClosed(object sender, FormClosedEventArgs e)
        {

            Frm_login frm_login = new Frm_login();

            this.Hide();
            frm_login.ShowDialog();
            this.Close();
            frm_login.Dispose();

        }

        private void Frm_fgpassword_Load(object sender, EventArgs e)
        {

            Tb_emailReset.Text = "Email";
            Tb_emailReset.ForeColor = Color.Gray;

        }

        private void Tb_emailReset_Enter(object sender, EventArgs e)
        {
            if (Tb_emailReset.Text == "Email")
            {
                Tb_emailReset.Text = "";
            }
        }

        private void Tb_emailReset_Leave(object sender, EventArgs e)
        {
            if (Tb_emailReset.Text == "")
            {
                Tb_emailReset.Text = "Email";
                Tb_emailReset.ForeColor = Color.Gray;
            }
        }

        private void Frm_fgpassword_Click(object sender, EventArgs e)
        {
            if (Tb_emailReset.Text == "")
            {
                Tb_emailReset.Text = "Email";
                Tb_emailReset.ForeColor = Color.Gray;
            }

            ActiveControl = null;
        }

        private void Frm_fgpassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_sendEmailReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check Email : " + Tb_emailReset.Text);

/*            if (Tb_emailReset.Text == "")
            {
                MessageBox.Show("Please enter your email address in format:\n " +
                    "yourname@example.com");

            }else if (Tb_emailReset.Text != "")
            {
                MessageBox.Show("Incorrect username or password.");
            }
            else
            {
                MessageBox.Show("Sending new password to email.");
            }*/
            
        }
    }
}
