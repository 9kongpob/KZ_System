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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lb_forgotpass = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.gb_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.tb_username);
            this.gb_login.Controls.Add(this.btn_login);
            this.gb_login.Location = new System.Drawing.Point(34, 101);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(336, 200);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Login";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_password.Location = new System.Drawing.Point(36, 89);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(276, 30);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.Enter += new System.EventHandler(this.Tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.Tb_password_Leave);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_username.Location = new System.Drawing.Point(36, 38);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(276, 30);
            this.tb_username.TabIndex = 2;
            this.tb_username.Enter += new System.EventHandler(this.Tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.Tb_username_Leave);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(93, 135);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(148, 39);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_signup
            // 
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.Location = new System.Drawing.Point(48, 318);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(120, 34);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_signup_MouseClick);
            // 
            // lb_forgotpass
            // 
            this.lb_forgotpass.AutoSize = true;
            this.lb_forgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_forgotpass.Location = new System.Drawing.Point(205, 327);
            this.lb_forgotpass.Name = "lb_forgotpass";
            this.lb_forgotpass.Size = new System.Drawing.Size(156, 17);
            this.lb_forgotpass.TabIndex = 7;
            this.lb_forgotpass.Text = "Forgot Your Password?";
            this.lb_forgotpass.Click += new System.EventHandler(this.Lb_forgotpass_Click);
            this.lb_forgotpass.MouseEnter += new System.EventHandler(this.Lb_forgotpass_MouseEnter);
            this.lb_forgotpass.MouseLeave += new System.EventHandler(this.Lb_forgotpass_MouseLeave);
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_logo.BackgroundImage")));
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.InitialImage = null;
            this.pb_logo.Location = new System.Drawing.Point(155, 10);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(85, 85);
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.Pb_logo_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 374);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lb_forgotpass);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.gb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.Click += new System.EventHandler(this.Frm_login_Click);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lb_forgotpass;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}

