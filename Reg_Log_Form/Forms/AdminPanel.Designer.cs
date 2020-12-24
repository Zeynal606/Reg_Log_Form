namespace Reg_Log_Form
{
    partial class AdminPanel
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
            this.grbx_welcome = new System.Windows.Forms.GroupBox();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lnk_usersList = new System.Windows.Forms.LinkLabel();
            this.lnl_logList = new System.Windows.Forms.LinkLabel();
            this.grbx_stats = new System.Windows.Forms.GroupBox();
            this.grbx_welcome.SuspendLayout();
            this.grbx_stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_welcome
            // 
            this.grbx_welcome.Controls.Add(this.link_logout);
            this.grbx_welcome.Controls.Add(this.lbl_welcome);
            this.grbx_welcome.Location = new System.Drawing.Point(17, 11);
            this.grbx_welcome.Margin = new System.Windows.Forms.Padding(8, 13, 8, 13);
            this.grbx_welcome.Name = "grbx_welcome";
            this.grbx_welcome.Padding = new System.Windows.Forms.Padding(8, 13, 8, 13);
            this.grbx_welcome.Size = new System.Drawing.Size(709, 107);
            this.grbx_welcome.TabIndex = 1;
            this.grbx_welcome.TabStop = false;
            this.grbx_welcome.Enter += new System.EventHandler(this.grbx_welcome_Enter);
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.Font = new System.Drawing.Font("Impact", 18F);
            this.link_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.link_logout.Location = new System.Drawing.Point(610, 55);
            this.link_logout.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link_logout.Name = "link_logout";
            this.link_logout.Size = new System.Drawing.Size(83, 29);
            this.link_logout.TabIndex = 1;
            this.link_logout.TabStop = true;
            this.link_logout.Text = "Log Out";
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Impact", 18F);
            this.lbl_welcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_welcome.Location = new System.Drawing.Point(16, 30);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 29);
            this.lbl_welcome.TabIndex = 0;
            // 
            // lnk_usersList
            // 
            this.lnk_usersList.AutoSize = true;
            this.lnk_usersList.Font = new System.Drawing.Font("Impact", 18F);
            this.lnk_usersList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnk_usersList.Location = new System.Drawing.Point(25, 66);
            this.lnk_usersList.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lnk_usersList.Name = "lnk_usersList";
            this.lnk_usersList.Size = new System.Drawing.Size(106, 29);
            this.lnk_usersList.TabIndex = 2;
            this.lnk_usersList.TabStop = true;
            this.lnk_usersList.Text = "Users List";
            this.lnk_usersList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnl_logList
            // 
            this.lnl_logList.AutoSize = true;
            this.lnl_logList.Font = new System.Drawing.Font("Impact", 18F);
            this.lnl_logList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnl_logList.Location = new System.Drawing.Point(25, 129);
            this.lnl_logList.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lnl_logList.Name = "lnl_logList";
            this.lnl_logList.Size = new System.Drawing.Size(94, 29);
            this.lnl_logList.TabIndex = 3;
            this.lnl_logList.TabStop = true;
            this.lnl_logList.Text = "Logs List";
            this.lnl_logList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnl_logList_LinkClicked);
            // 
            // grbx_stats
            // 
            this.grbx_stats.Controls.Add(this.lnk_usersList);
            this.grbx_stats.Controls.Add(this.lnl_logList);
            this.grbx_stats.Location = new System.Drawing.Point(17, 134);
            this.grbx_stats.Name = "grbx_stats";
            this.grbx_stats.Size = new System.Drawing.Size(209, 311);
            this.grbx_stats.TabIndex = 4;
            this.grbx_stats.TabStop = false;
            this.grbx_stats.Text = "Statistic";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 453);
            this.Controls.Add(this.grbx_stats);
            this.Controls.Add(this.grbx_welcome);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.grbx_welcome.ResumeLayout(false);
            this.grbx_welcome.PerformLayout();
            this.grbx_stats.ResumeLayout(false);
            this.grbx_stats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_welcome;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.LinkLabel lnk_usersList;
        private System.Windows.Forms.LinkLabel lnl_logList;
        private System.Windows.Forms.GroupBox grbx_stats;
    }
}