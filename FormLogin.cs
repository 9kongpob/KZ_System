using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


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
            if (Tb_username.Text == "Enter Your Username")
            {
                Tb_username.Text = "";
                Tb_username.ForeColor = Color.Black;
            }
        }

        private void Tb_username_Leave(object sender, EventArgs e)
        {
            if (Tb_username.Text == "")
            {
                Tb_username.Text = "Enter Your Username";
                Tb_username.TextAlign = HorizontalAlignment.Center;
                Tb_username.ForeColor = Color.Gray;
            }
        }

        private void Tb_password_Enter(object sender, EventArgs e)
        {
            if (Tb_password.Text == "********")
            {
                Tb_password.Text = "";
                Tb_password.ForeColor = Color.Black;
            }
        }

        private void Tb_password_Leave(object sender, EventArgs e)
        {
            if (Tb_password.Text == "")
            {
                Tb_password.Text = "********";
                Tb_password.TextAlign = HorizontalAlignment.Center;
                Tb_password.ForeColor = Color.Gray;
            }
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            Tb_username.Text = "Enter Your Username";
            Tb_username.TextAlign = HorizontalAlignment.Center;
            Tb_username.ForeColor = Color.Gray;

            Tb_password.Text = "********";
            Tb_password.TextAlign = HorizontalAlignment.Center;
            Tb_password.ForeColor = Color.Gray;

        }

        private void Lb_forgotpass_MouseEnter(object sender, EventArgs e)
        {
            Lb_forgotpass.ForeColor = Color.Blue;
            Lb_forgotpass.Font = new Font(Lb_forgotpass.Font, FontStyle.Underline);

        }

        private void Lb_forgotpass_MouseLeave(object sender, EventArgs e)
        {
            Lb_forgotpass.ForeColor = Color.Black;
            Lb_forgotpass.Font = new Font(Lb_forgotpass.Font, FontStyle.Regular);
        }

        private void Frm_login_Click(object sender, EventArgs e)
        {

            if (Tb_password.Text == "")
            {
                Tb_password.Text = "********";
                Tb_password.TextAlign = HorizontalAlignment.Center;
                Tb_password.ForeColor = Color.Gray;
            }
            if (Tb_username.Text == "")
            {
                Tb_username.Text = "Enter Your Username";
                Tb_username.TextAlign = HorizontalAlignment.Center;
                Tb_username.ForeColor = Color.Gray;
            }

            ActiveControl = null;
        }

        private void Btn_signup_MouseClick(object sender, MouseEventArgs e)
        {
            Frm_register frm_Register = new Frm_register();

            this.Hide();
            frm_Register.ShowDialog();
            frm_Register.Dispose();
        }

        private void Pb_logo_Click(object sender, EventArgs e)
        {
            if (Tb_password.Text == "")
            {
                Tb_password.Text = "********";
                Tb_password.TextAlign = HorizontalAlignment.Center;
                Tb_password.ForeColor = Color.Gray;
            }
            if (Tb_username.Text == "")
            {
                Tb_username.Text = "Enter Your Username";
                Tb_username.TextAlign = HorizontalAlignment.Center;
                Tb_username.ForeColor = Color.Gray;
            }

            ActiveControl = null;
        }

        private void Lb_forgotpass_Click(object sender, EventArgs e)
        {
            Frm_fgpassword frm_fgpassword = new Frm_fgpassword();
            this.Hide();
            frm_fgpassword.ShowDialog();
            frm_fgpassword.Dispose();

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            

            if (Tb_username.Text != "Enter Your Username" && Tb_password.Text != "********")
            {
                MessageBox.Show("Username : " + Tb_username.Text,"You Login With");

                //---------------ConnectDataBase-----------------
                SqlConnection objConn = new SqlConnection();
                SqlCommand objCmd = new SqlCommand();
                string strConnString = null;
                string strSQL = null;

                strConnString = "Server=192.168.2.115;UID=sa;PASSWORD=siwt-2017;Database=test;Max Pool Size = 100;Connect Timeout = 5;";
                objConn.ConnectionString = strConnString;
                objConn.Open();

                int intNumRows = 0;
                strSQL = "SELECT COUNT(*) FROM [dbo].[tbUser] WHERE Username = '" + 
                    this.Tb_username.Text + "' AND Password = '" + 
                    this.Tb_password.Text + "' ";
                objCmd = new SqlCommand(strSQL, objConn);
                intNumRows = Convert.ToInt32(objCmd.ExecuteScalar());

                if (intNumRows > 0)
                {
                    Debug.WriteLine("Connecting.");
                    Debug.WriteLine("Connecting..");
                    Debug.WriteLine("Connecting...");
                    Debug.WriteLine("Connecting Server Database...");
                    Debug.WriteLine("Success. ---> Connected Server Database.");
                    MessageBox.Show("Connected Server Database.","Connect Data");

                    //check access new form FormMain

                }
                else
                {
                    Debug.WriteLine("Sorry, Unable to connect to the server.");
                    MessageBox.Show("Unable to connect to the server.","Connect Data");
                }
                objConn.Close();
                objConn = null;

        //-----------------------------------------------


            }
            else if (Tb_username.Text == "Enter Your Username" && Tb_password.Text != "********")
            {
                MessageBox.Show("No Value in Username.");
            }
            else if (Tb_username.Text != "Enter Your Username" && Tb_password.Text == "********")
            {
                MessageBox.Show("No Value in Password.");
            }
            else
            {
                MessageBox.Show("No Value in Username and Password.");
            }
        }

        private void Tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_login.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Pb_logo_Click(sender, e);
            }
        }

        private void Tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Pb_logo_Click(sender, e);
            }
        }
    }
}
