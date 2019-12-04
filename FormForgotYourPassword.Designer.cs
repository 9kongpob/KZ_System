using System;

namespace LoginC01
{
    partial class Frm_fgpassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_fgpassword));
            this.Lb_fgps_main = new System.Windows.Forms.Label();
            this.Lb_fgps_submain = new System.Windows.Forms.Label();
            this.Tb_emailReset = new System.Windows.Forms.TextBox();
            this.Btn_RecoverPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_fgps_main
            // 
            this.Lb_fgps_main.AutoSize = true;
            this.Lb_fgps_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Lb_fgps_main.Location = new System.Drawing.Point(31, 23);
            this.Lb_fgps_main.Name = "Lb_fgps_main";
            this.Lb_fgps_main.Size = new System.Drawing.Size(225, 25);
            this.Lb_fgps_main.TabIndex = 0;
            this.Lb_fgps_main.Text = "Forgot Your Password";
            // 
            // Lb_fgps_submain
            // 
            this.Lb_fgps_submain.AutoSize = true;
            this.Lb_fgps_submain.Location = new System.Drawing.Point(33, 64);
            this.Lb_fgps_submain.Name = "Lb_fgps_submain";
            this.Lb_fgps_submain.Size = new System.Drawing.Size(326, 34);
            this.Lb_fgps_submain.TabIndex = 1;
            this.Lb_fgps_submain.Text = "Don\'t worry. Requesting your password is easy,\r\njust tell us the email address yo" +
    "u registered with IT";
            // 
            // Tb_emailReset
            // 
            this.Tb_emailReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Tb_emailReset.Location = new System.Drawing.Point(36, 117);
            this.Tb_emailReset.Name = "Tb_emailReset";
            this.Tb_emailReset.Size = new System.Drawing.Size(323, 30);
            this.Tb_emailReset.TabIndex = 2;
            this.Tb_emailReset.Enter += new System.EventHandler(this.Tb_emailReset_Enter);
            this.Tb_emailReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_emailReset_KeyDown);
            this.Tb_emailReset.Leave += new System.EventHandler(this.Tb_emailReset_Leave);
            // 
            // Btn_RecoverPassword
            // 
            this.Btn_RecoverPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RecoverPassword.Location = new System.Drawing.Point(36, 162);
            this.Btn_RecoverPassword.Name = "Btn_RecoverPassword";
            this.Btn_RecoverPassword.Size = new System.Drawing.Size(323, 46);
            this.Btn_RecoverPassword.TabIndex = 3;
            this.Btn_RecoverPassword.Text = "Recover Password";
            this.Btn_RecoverPassword.UseVisualStyleBackColor = true;
            this.Btn_RecoverPassword.Click += new System.EventHandler(this.Btn_RecoverPassword_Click);
            // 
            // Frm_fgpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 220);
            this.Controls.Add(this.Btn_RecoverPassword);
            this.Controls.Add(this.Tb_emailReset);
            this.Controls.Add(this.Lb_fgps_submain);
            this.Controls.Add(this.Lb_fgps_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_fgpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Your Password?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_fgpassword_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_fgpassword_FormClosed);
            this.Load += new System.EventHandler(this.Frm_fgpassword_Load);
            this.Click += new System.EventHandler(this.Frm_fgpassword_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label Lb_fgps_main;
        private System.Windows.Forms.Label Lb_fgps_submain;
        private System.Windows.Forms.TextBox Tb_emailReset;
        private System.Windows.Forms.Button Btn_RecoverPassword;

    }
}