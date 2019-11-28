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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == "Enter Your Username")
            {
                tb_username.Text = "";
            }
        }

        private void Tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Enter Your Username";
                tb_username.TextAlign = HorizontalAlignment.Center;
                tb_username.ForeColor = Color.Gray;
            }
        }

        private void Tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "********")
            {
                tb_password.Text = "";
            }
        }

        private void Tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "********";
                tb_password.TextAlign = HorizontalAlignment.Center;
                tb_password.ForeColor = Color.Gray;
            }
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            tb_username.Text = "Enter Your Username";
            tb_username.TextAlign = HorizontalAlignment.Center;
            tb_username.ForeColor = Color.Gray;

            tb_password.Text = "********";
            tb_password.TextAlign = HorizontalAlignment.Center;
            tb_password.ForeColor = Color.Gray;

        }

        private void Lb_forgotpass_MouseEnter(object sender, EventArgs e)
        {
            lb_forgotpass.ForeColor = Color.Blue;
            lb_forgotpass.Font = new Font(lb_forgotpass.Font, FontStyle.Underline);

        }

        private void Lb_forgotpass_MouseLeave(object sender, EventArgs e)
        {
            lb_forgotpass.ForeColor = Color.Black;
            lb_forgotpass.Font = new Font(lb_forgotpass.Font, FontStyle.Regular);
        }

        private void Frm_login_Click(object sender, EventArgs e)
        {

            if (tb_password.Text == "")
            {
                tb_password.Text = "********";
                tb_password.TextAlign = HorizontalAlignment.Center;
                tb_password.ForeColor = Color.Gray;
            }
            if (tb_username.Text == "")
            {
                tb_username.Text = "Enter Your Username";
                tb_username.TextAlign = HorizontalAlignment.Center;
                tb_username.ForeColor = Color.Gray;
            }

            ActiveControl = null;
        }

        private void Btn_signup_MouseClick(object sender, MouseEventArgs e)
        {
            Frm_register frm_Register = new Frm_register();

            this.Hide();
            frm_Register.ShowDialog();

        }

        private void Pb_logo_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "********";
                tb_password.TextAlign = HorizontalAlignment.Center;
                tb_password.ForeColor = Color.Gray;
            }
            if (tb_username.Text == "")
            {
                tb_username.Text = "Enter Your Username";
                tb_username.TextAlign = HorizontalAlignment.Center;
                tb_username.ForeColor = Color.Gray;
            }

            ActiveControl = null;
        }

        private void Lb_forgotpass_Click(object sender, EventArgs e)
        {
            Frm_fgpassword frm_fgpassword = new Frm_fgpassword();
            this.Hide();
            frm_fgpassword.ShowDialog();

        }

    }
}
