using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormMain
{
    public partial class FormMain : Form
    {

        string emailUser;

        public FormMain()
        {
            InitializeComponent();
            
        }

        public void FormMain_Load(object sender, EventArgs e)
        {

            Debug.WriteLine("Login successful.");

            lb_version_system.ForeColor = Color.FromArgb(191, 191, 191);
            lb_version_system.Font = new Font(lb_version_system.Font, FontStyle.Regular);

            lb_developby.ForeColor = Color.FromArgb(191, 191, 191);
            lb_developby.Font = new Font(lb_developby.Font, FontStyle.Regular);
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show(@"Do you really want to close the form?",
                                           /*Application.ProductName*/"KZ System",
                                           MessageBoxButtons.YesNo) == DialogResult.No;
            //Application.Exit();
        }

        private void version_system_MouseEnter(object sender, EventArgs e)
        {
            lb_version_system.ForeColor = Color.White;
            lb_version_system.Font = new Font(lb_version_system.Font, FontStyle.Regular);
        }

        private void lb_version_system_MouseLeave(object sender, EventArgs e)
        {
            lb_version_system.ForeColor = Color.FromArgb(191, 191, 191);
            lb_version_system.Font = new Font(lb_version_system.Font, FontStyle.Regular);
        }

        private void lb_developby_MouseEnter(object sender, EventArgs e)
        {
            lb_developby.ForeColor = Color.White;
            lb_developby.Font = new Font(lb_developby.Font, FontStyle.Regular);
        }

        private void lb_developby_MouseLeave(object sender, EventArgs e)
        {
            lb_developby.ForeColor = Color.FromArgb(191, 191, 191);
            lb_developby.Font = new Font(lb_developby.Font, FontStyle.Regular);
        }

        private void version_system_Click(object sender, EventArgs e)
        {

            Form frmAbout = new FormAbout();
            frmAbout.ShowDialog();
        }

        private void lb_developby_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("check email user : " + emailUser);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check Data Connect : ");
        }

    }
}
