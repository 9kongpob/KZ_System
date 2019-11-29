namespace LoginC01
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.Gb_login = new System.Windows.Forms.GroupBox();
            this.Tb_password = new System.Windows.Forms.TextBox();
            this.Tb_username = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_signup = new System.Windows.Forms.Button();
            this.Lb_forgotpass = new System.Windows.Forms.Label();
            this.Pb_logo = new System.Windows.Forms.PictureBox();
            this.Gb_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_login
            // 
            this.Gb_login.Controls.Add(this.Tb_password);
            this.Gb_login.Controls.Add(this.Tb_username);
            this.Gb_login.Controls.Add(this.Btn_login);
            this.Gb_login.Location = new System.Drawing.Point(34, 101);
            this.Gb_login.Name = "Gb_login";
            this.Gb_login.Size = new System.Drawing.Size(336, 200);
            this.Gb_login.TabIndex = 0;
            this.Gb_login.TabStop = false;
            this.Gb_login.Text = "Login";
            // 
            // Tb_password
            // 
            this.Tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Tb_password.Location = new System.Drawing.Point(36, 89);
            this.Tb_password.Name = "Tb_password";
            this.Tb_password.Size = new System.Drawing.Size(276, 30);
            this.Tb_password.TabIndex = 3;
            this.Tb_password.UseSystemPasswordChar = true;
            this.Tb_password.Enter += new System.EventHandler(this.Tb_password_Enter);
            this.Tb_password.Leave += new System.EventHandler(this.Tb_password_Leave);
            // 
            // Tb_username
            // 
            this.Tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Tb_username.Location = new System.Drawing.Point(36, 38);
            this.Tb_username.Name = "Tb_username";
            this.Tb_username.Size = new System.Drawing.Size(276, 30);
            this.Tb_username.TabIndex = 2;
            this.Tb_username.Enter += new System.EventHandler(this.Tb_username_Enter);
            this.Tb_username.Leave += new System.EventHandler(this.Tb_username_Leave);
            // 
            // Btn_login
            // 
            this.Btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_login.Location = new System.Drawing.Point(93, 135);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(148, 39);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_signup
            // 
            this.Btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_signup.Location = new System.Drawing.Point(48, 318);
            this.Btn_signup.Name = "Btn_signup";
            this.Btn_signup.Size = new System.Drawing.Size(120, 34);
            this.Btn_signup.TabIndex = 6;
            this.Btn_signup.Text = "Sign Up";
            this.Btn_signup.UseVisualStyleBackColor = true;
            this.Btn_signup.Visible = false;
            this.Btn_signup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_signup_MouseClick);
            // 
            // Lb_forgotpass
            // 
            this.Lb_forgotpass.AutoSize = true;
            this.Lb_forgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_forgotpass.Location = new System.Drawing.Point(205, 327);
            this.Lb_forgotpass.Name = "Lb_forgotpass";
            this.Lb_forgotpass.Size = new System.Drawing.Size(156, 17);
            this.Lb_forgotpass.TabIndex = 7;
            this.Lb_forgotpass.Text = "Forgot Your Password?";
            this.Lb_forgotpass.Click += new System.EventHandler(this.Lb_forgotpass_Click);
            this.Lb_forgotpass.MouseEnter += new System.EventHandler(this.Lb_forgotpass_MouseEnter);
            this.Lb_forgotpass.MouseLeave += new System.EventHandler(this.Lb_forgotpass_MouseLeave);
            // 
            // Pb_logo
            // 
            this.Pb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_logo.BackgroundImage")));
            this.Pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb_logo.InitialImage = null;
            this.Pb_logo.Location = new System.Drawing.Point(155, 10);
            this.Pb_logo.Name = "Pb_logo";
            this.Pb_logo.Size = new System.Drawing.Size(85, 85);
            this.Pb_logo.TabIndex = 8;
            this.Pb_logo.TabStop = false;
            this.Pb_logo.Click += new System.EventHandler(this.Pb_logo_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 374);
            this.Controls.Add(this.Pb_logo);
            this.Controls.Add(this.Lb_forgotpass);
            this.Controls.Add(this.Btn_signup);
            this.Controls.Add(this.Gb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.Click += new System.EventHandler(this.Frm_login_Click);
            this.Gb_login.ResumeLayout(false);
            this.Gb_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_login;
        private System.Windows.Forms.TextBox Tb_password;
        private System.Windows.Forms.TextBox Tb_username;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_signup;
        private System.Windows.Forms.Label Lb_forgotpass;
        private System.Windows.Forms.PictureBox Pb_logo;
    }
}

