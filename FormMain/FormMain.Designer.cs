namespace FormMain
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuTab = new System.Windows.Forms.Panel();
            this.lb_developby = new System.Windows.Forms.Label();
            this.lb_version_system = new System.Windows.Forms.Label();
            this.logo_system = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_factory = new System.Windows.Forms.PictureBox();
            this.MenuTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_system)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_factory)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTab
            // 
            this.MenuTab.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuTab.Controls.Add(this.lb_developby);
            this.MenuTab.Controls.Add(this.lb_version_system);
            this.MenuTab.Controls.Add(this.logo_system);
            this.MenuTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuTab.Location = new System.Drawing.Point(0, 0);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Size = new System.Drawing.Size(328, 853);
            this.MenuTab.TabIndex = 0;
            // 
            // lb_developby
            // 
            this.lb_developby.AutoSize = true;
            this.lb_developby.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_developby.Location = new System.Drawing.Point(8, 816);
            this.lb_developby.Name = "lb_developby";
            this.lb_developby.Size = new System.Drawing.Size(213, 17);
            this.lb_developby.TabIndex = 1;
            this.lb_developby.Text = "Since 2019, Develop By IT SIWT";
            this.lb_developby.MouseEnter += new System.EventHandler(this.lb_developby_MouseEnter);
            this.lb_developby.MouseLeave += new System.EventHandler(this.lb_developby_MouseLeave);
            // 
            // lb_version_system
            // 
            this.lb_version_system.AutoSize = true;
            this.lb_version_system.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_version_system.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_version_system.Location = new System.Drawing.Point(8, 792);
            this.lb_version_system.Name = "lb_version_system";
            this.lb_version_system.Size = new System.Drawing.Size(164, 17);
            this.lb_version_system.TabIndex = 1;
            this.lb_version_system.Text = "KZ System Version 0.0.1";
            this.lb_version_system.Click += new System.EventHandler(this.version_system_Click);
            this.lb_version_system.MouseEnter += new System.EventHandler(this.version_system_MouseEnter);
            this.lb_version_system.MouseLeave += new System.EventHandler(this.lb_version_system_MouseLeave);
            // 
            // logo_system
            // 
            this.logo_system.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logo_system.Location = new System.Drawing.Point(8, 8);
            this.logo_system.Name = "logo_system";
            this.logo_system.Size = new System.Drawing.Size(312, 64);
            this.logo_system.TabIndex = 0;
            this.logo_system.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.logo_factory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(328, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 80);
            this.panel1.TabIndex = 1;
            // 
            // logo_factory
            // 
            this.logo_factory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logo_factory.Location = new System.Drawing.Point(8, 8);
            this.logo_factory.Name = "logo_factory";
            this.logo_factory.Size = new System.Drawing.Size(312, 64);
            this.logo_factory.TabIndex = 0;
            this.logo_factory.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KZ System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuTab.ResumeLayout(false);
            this.MenuTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_system)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_factory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo_system;
        private System.Windows.Forms.PictureBox logo_factory;
        private System.Windows.Forms.Label lb_developby;
        private System.Windows.Forms.Label lb_version_system;
    }
}

