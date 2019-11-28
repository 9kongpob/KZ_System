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
            this.lb_fgps_main = new System.Windows.Forms.Label();
            this.lb_fgps_submain = new System.Windows.Forms.Label();
            this.tb_emailReset = new System.Windows.Forms.TextBox();
            this.bn_sendEmailReset = new System.Windows.Forms.Button();
            this.pb_email_ico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_email_ico)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fgps_main
            // 
            this.lb_fgps_main.AutoSize = true;
            this.lb_fgps_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_fgps_main.Location = new System.Drawing.Point(31, 23);
            this.lb_fgps_main.Name = "lb_fgps_main";
            this.lb_fgps_main.Size = new System.Drawing.Size(225, 25);
            this.lb_fgps_main.TabIndex = 0;
            this.lb_fgps_main.Text = "Forgot Your Password";
            // 
            // lb_fgps_submain
            // 
            this.lb_fgps_submain.AutoSize = true;
            this.lb_fgps_submain.Location = new System.Drawing.Point(33, 64);
            this.lb_fgps_submain.Name = "lb_fgps_submain";
            this.lb_fgps_submain.Size = new System.Drawing.Size(326, 34);
            this.lb_fgps_submain.TabIndex = 1;
            this.lb_fgps_submain.Text = "Don\'t worry. Requesting your password is easy,\r\njust tell us the email address yo" +
    "u registered with IT";
            // 
            // tb_emailReset
            // 
            this.tb_emailReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_emailReset.Location = new System.Drawing.Point(36, 117);
            this.tb_emailReset.Name = "tb_emailReset";
            this.tb_emailReset.Size = new System.Drawing.Size(323, 30);
            this.tb_emailReset.TabIndex = 2;
            this.tb_emailReset.Enter += new System.EventHandler(this.Tb_emailReset_Enter);
            this.tb_emailReset.Leave += new System.EventHandler(this.Tb_emailReset_Leave);
            // 
            // bn_sendEmailReset
            // 
            this.bn_sendEmailReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bn_sendEmailReset.Location = new System.Drawing.Point(217, 162);
            this.bn_sendEmailReset.Name = "bn_sendEmailReset";
            this.bn_sendEmailReset.Size = new System.Drawing.Size(142, 46);
            this.bn_sendEmailReset.TabIndex = 3;
            this.bn_sendEmailReset.Text = "Send";
            this.bn_sendEmailReset.UseVisualStyleBackColor = true;
            // 
            // pb_email_ico
            // 
            this.pb_email_ico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_email_ico.BackgroundImage = global::LoginC01.Properties.Resources.email1;
            this.pb_email_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_email_ico.Location = new System.Drawing.Point(246, 175);
            this.pb_email_ico.Name = "pb_email_ico";
            this.pb_email_ico.Size = new System.Drawing.Size(22, 21);
            this.pb_email_ico.TabIndex = 4;
            this.pb_email_ico.TabStop = false;
            // 
            // frm_fgpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 220);
            this.Controls.Add(this.pb_email_ico);
            this.Controls.Add(this.bn_sendEmailReset);
            this.Controls.Add(this.tb_emailReset);
            this.Controls.Add(this.lb_fgps_submain);
            this.Controls.Add(this.lb_fgps_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_fgpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Your Password?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_fgpassword_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_fgpassword_FormClosed);
            this.Load += new System.EventHandler(this.Frm_fgpassword_Load);
            this.Click += new System.EventHandler(this.Frm_fgpassword_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_email_ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fgps_main;
        private System.Windows.Forms.Label lb_fgps_submain;
        private System.Windows.Forms.TextBox tb_emailReset;
        private System.Windows.Forms.Button bn_sendEmailReset;
        private System.Windows.Forms.PictureBox pb_email_ico;
    }
}