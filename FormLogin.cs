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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == "Enter Your Username")
            {
                tb_username.Text = "";
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Enter Your Username";
                tb_username.TextAlign = HorizontalAlignment.Center;
                tb_username.ForeColor = Color.Gray;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "********")
            {
                tb_password.Text = "";
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "********";
                tb_password.TextAlign = HorizontalAlignment.Center;
                tb_password.ForeColor = Color.Gray;
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            tb_username.Text = "Enter Your Username";
            tb_username.TextAlign = HorizontalAlignment.Center;
            tb_username.ForeColor = Color.Gray;

            tb_password.Text = "********";
            tb_password.TextAlign = HorizontalAlignment.Center;
            tb_password.ForeColor = Color.Gray;

        }

        private void lb_forgotpass_MouseEnter(object sender, EventArgs e)
        {
            lb_forgotpass.ForeColor = Color.Blue;
            lb_forgotpass.Font = new Font(lb_forgotpass.Font, FontStyle.Underline);

        }

        private void lb_forgotpass_MouseLeave(object sender, EventArgs e)
        {
            lb_forgotpass.ForeColor = Color.Black;
            lb_forgotpass.Font = new Font(lb_forgotpass.Font, FontStyle.Regular);
        }

        private void frm_login_Click(object sender, EventArgs e)
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

        private void btn_signup_MouseClick(object sender, MouseEventArgs e)
        {
            frm_register frm_Register = new frm_register();
            frm_Register.Show();

            this.Visible = false;
        }

        private void pb_logo_Click(object sender, EventArgs e)
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

        private void lb_forgotpass_Click(object sender, EventArgs e)
        {
            //frm_fgpassword frm_Fgpassword = new frm_fgpassword();
            //frm_Fgpassword.Show();

            //this.Visible = false;

            frm_fgpassword frm_fgpassword = new frm_fgpassword();
            

            this.Hide();

            frm_fgpassword.ShowDialog();
            

        }
    }
}
