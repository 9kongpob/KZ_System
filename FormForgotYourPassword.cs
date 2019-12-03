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

        private void Btn_sendEmailReset_Click(object sender, EventArgs e)
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

        private void Pb_email_ico_Click(object sender, EventArgs e)
        {
            Btn_sendEmailReset_Click(sender, e);
        }

        public void EmailSender(string email)
        {
            
            MessageBox.Show("Check Function Sender show email : " + email);
            string emailFrom = "kongpop@siwt.co.th";

            var myMail = new MailMessage();
            myMail.From = new MailAddress("IT Engineer<"+emailFrom+">");

            myMail.Subject = "Recover Password System from IT";
            myMail.To.Add(new MailAddress(email));
            myMail.IsBodyHtml = true;
            myMail.BodyEncoding = System.Text.Encoding.UTF8;
            myMail.Body = "Recover password System from IT\n" +
                "Test Send mail\n\n\n" +
                "Thank You and Best Regards,\n" +
                "Mr.Kongpob Kunchanuan\n" +
                "IT Engineer\n" +
                "Shinba Iron Works (Thailand) Co.,Ltd. (SIWT)\n" +
                "Amata City Chonburi Industrial Estate\n" +
                "700/746 Moo 1 T.Phanthong, A.Phanthong, Chonburi 20160,Thailand\n" +
                "Tel : 038-185566 to 70\n" +
                "Mobile: 098-8167915  E-mail : kongpop@siwt.co.th";

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
    }
}
