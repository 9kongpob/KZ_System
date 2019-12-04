using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

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
                Tb_emailReset.ForeColor = Color.Black;
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

        public void EmailSender(string email)
        {
            
            //MessageBox.Show("Check Function Sender show email : " + email);

            String emailFrom = "kongpop@siwt.co.th";
            String strMsg;
            String passwordRecover = "P@ssw0rd";

            var myMail = new MailMessage();
            myMail.From = new MailAddress("IT Engineer<"+emailFrom+">");

            myMail.Subject = "Recover Password System from IT";
            myMail.To.Add(new MailAddress(email));
            myMail.IsBodyHtml = true;
            myMail.BodyEncoding = System.Text.Encoding.UTF8;

            strMsg = "";
            strMsg = strMsg + "<p> Recovery your password,</p>";
            strMsg = strMsg + "<p> &nbsp;</p>";
            strMsg = strMsg + "<p> Your password recovery was successful.</p>";
            strMsg = strMsg + "<p> Date : "+ DateTime.Now.ToString() + "&nbsp;</p>";
            strMsg = strMsg + "<p> As you have requested password recovery to system. <br> The IT has received the recovery request.</p>";
            strMsg = strMsg + "<p> Password : "+ passwordRecover +" </p>";
            strMsg = strMsg + "<p> &nbsp;</p>";
            strMsg = strMsg + "<p> This is an automatic AI system. Please don't reply <br> Should you have any question, please feel free to contact me.</p>";
            strMsg = strMsg + "<p> --------------------------------------------</p>";
            strMsg = strMsg + "<p> Thank you and Best Regards,</p>"; 
            strMsg = strMsg + "<p> Mr.Kongpop Kunchanuan <br> IT Engineer <br> Email : kongpop@siwt.co.th <br> Mobile : +669 8816 7915</p>";

            myMail.Body = strMsg;

            var credential = new NetworkCredential(emailFrom, "Kon@2019");
            var smtpClient = new SmtpClient();
            smtpClient.Port = 25;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = credential;
            smtpClient.Host = "mail.siwt.co.th";
            smtpClient.EnableSsl = false;

            //var smtpClient = new SmtpClient("mail.siwt.co.th", 587);

            smtpClient.Send(myMail);

            smtpClient.Dispose();
            myMail.Dispose();
        }

        private void Btn_RecoverPassword_Click(object sender, EventArgs e)
        {
             //MessageBox.Show("Check Email : " + Tb_emailReset.Text);

            if (Tb_emailReset.Text == "Email")
            {
                MessageBox.Show("Please enter your email address in format:\n " +
                    "yourname@example.com");

            }
            else if (Tb_emailReset.Text != "Email")
            {
                Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch(Tb_emailReset.Text.Trim());
                if (!isValid)
                {
                    MessageBox.Show("Invalid Email.");
                }
                else
                {
                    EmailSender(Tb_emailReset.Text);
                    MessageBox.Show("Recover password to your email.");

                    Application.Exit();

                }
            }
            else
            {
                //MessageBox.Show("Recover password to your email.");
            }

            
        }

        private void Tb_emailReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_RecoverPassword.PerformClick();
            }else if (e.KeyCode == Keys.Escape)
            {
                Tb_emailReset.Text = "";
            }
        }
    }
}
