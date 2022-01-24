namespace MiniMarket
{
    partial class mdi_frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi_frm_main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPosFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCustomerManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStoreManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDailyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMonthlyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ttsLoginedEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSystem,
            this.mnPosFunction,
            this.mnCustomerManagement,
            this.mnStoreManagement,
            this.mnReport,
            this.tsmnAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnSystem
            // 
            this.mnSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLogin,
            this.mnLogout,
            this.toolStripSeparator3,
            this.toolStripSeparator5,
            this.mnExit});
            this.mnSystem.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnSystem.Name = "mnSystem";
            this.mnSystem.Size = new System.Drawing.Size(57, 20);
            this.mnSystem.Text = "&System";
            // 
            // mnLogin
            // 
            this.mnLogin.Image = global::MiniMarket.Properties.Resources.login;
            this.mnLogin.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnLogin.Name = "mnLogin";
            this.mnLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnLogin.Size = new System.Drawing.Size(180, 22);
            this.mnLogin.Text = "Log&in";
            this.mnLogin.Click += new System.EventHandler(this.MnLogin_Click);
            // 
            // mnLogout
            // 
            this.mnLogout.Image = global::MiniMarket.Properties.Resources.logout;
            this.mnLogout.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnLogout.Size = new System.Drawing.Size(180, 22);
            this.mnLogout.Text = "Log&out";
            this.mnLogout.Click += new System.EventHandler(this.MnLogout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // mnExit
            // 
            this.mnExit.Image = global::MiniMarket.Properties.Resources.exit;
            this.mnExit.Name = "mnExit";
            this.mnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnExit.Size = new System.Drawing.Size(180, 22);
            this.mnExit.Text = "E&xit";
            // 
            // mnPosFunction
            // 
            this.mnPosFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mnPosFunction.Name = "mnPosFunction";
            this.mnPosFunction.Size = new System.Drawing.Size(91, 20);
            this.mnPosFunction.Text = "&POS Function";
            this.mnPosFunction.Click += new System.EventHandler(this.MnPosFunction_Click);
            // 
            // mnCustomerManagement
            // 
            this.mnCustomerManagement.Name = "mnCustomerManagement";
            this.mnCustomerManagement.Size = new System.Drawing.Size(145, 20);
            this.mnCustomerManagement.Text = "&Customer management";
            // 
            // mnStoreManagement
            // 
            this.mnStoreManagement.Enabled = false;
            this.mnStoreManagement.Name = "mnStoreManagement";
            this.mnStoreManagement.Size = new System.Drawing.Size(120, 20);
            this.mnStoreManagement.Text = "Store &management";
            // 
            // mnReport
            // 
            this.mnReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDailyReport,
            this.mnMonthlyReport});
            this.mnReport.Name = "mnReport";
            this.mnReport.Size = new System.Drawing.Size(54, 20);
            this.mnReport.Text = "&Report";
            // 
            // mnDailyReport
            // 
            this.mnDailyReport.Image = global::MiniMarket.Properties.Resources.report_02;
            this.mnDailyReport.Name = "mnDailyReport";
            this.mnDailyReport.Size = new System.Drawing.Size(157, 22);
            this.mnDailyReport.Text = "&Daily Report";
            // 
            // mnMonthlyReport
            // 
            this.mnMonthlyReport.Image = global::MiniMarket.Properties.Resources.report_01;
            this.mnMonthlyReport.Name = "mnMonthlyReport";
            this.mnMonthlyReport.Size = new System.Drawing.Size(157, 22);
            this.mnMonthlyReport.Text = "&Monthly Report";
            // 
            // tsmnAbout
            // 
            this.tsmnAbout.Name = "tsmnAbout";
            this.tsmnAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmnAbout.Text = "&About";
            this.tsmnAbout.Click += new System.EventHandler(this.TsmnAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.ttsLoginedEmployee});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // ttsLoginedEmployee
            // 
            this.ttsLoginedEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ttsLoginedEmployee.ForeColor = System.Drawing.Color.Maroon;
            this.ttsLoginedEmployee.Name = "ttsLoginedEmployee";
            this.ttsLoginedEmployee.Size = new System.Drawing.Size(0, 17);
            this.ttsLoginedEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mdi_frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniMarket.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdi_frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Market - POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mdi_frm_main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnSystem;
        private System.Windows.Forms.ToolStripMenuItem mnLogin;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnStoreManagement;
        private System.Windows.Forms.ToolStripMenuItem mnReport;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmnAbout;
        private System.Windows.Forms.ToolStripMenuItem mnDailyReport;
        private System.Windows.Forms.ToolStripMenuItem mnMonthlyReport;
        private System.Windows.Forms.ToolStripMenuItem mnPosFunction;
        private System.Windows.Forms.ToolStripMenuItem mnCustomerManagement;
        private System.Windows.Forms.ToolStripStatusLabel ttsLoginedEmployee;
    }
}



