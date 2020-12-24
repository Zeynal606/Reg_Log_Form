namespace Reg_Log_Form
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.grbx_welcome = new System.Windows.Forms.GroupBox();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.link_setPicture = new System.Windows.Forms.LinkLabel();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grbx_welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_welcome
            // 
            this.grbx_welcome.Controls.Add(this.link_logout);
            this.grbx_welcome.Controls.Add(this.lbl_welcome);
            resources.ApplyResources(this.grbx_welcome, "grbx_welcome");
            this.grbx_welcome.Name = "grbx_welcome";
            this.grbx_welcome.TabStop = false;
            // 
            // link_logout
            // 
            resources.ApplyResources(this.link_logout, "link_logout");
            this.link_logout.Name = "link_logout";
            this.link_logout.TabStop = true;
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // lbl_welcome
            // 
            resources.ApplyResources(this.lbl_welcome, "lbl_welcome");
            this.lbl_welcome.Name = "lbl_welcome";
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.Name = "lbl_name";
            // 
            // lbl_surname
            // 
            resources.ApplyResources(this.lbl_surname, "lbl_surname");
            this.lbl_surname.Name = "lbl_surname";
            // 
            // lbl_age
            // 
            resources.ApplyResources(this.lbl_age, "lbl_age");
            this.lbl_age.Name = "lbl_age";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // link_setPicture
            // 
            resources.ApplyResources(this.link_setPicture, "link_setPicture");
            this.link_setPicture.Name = "link_setPicture";
            this.link_setPicture.TabStop = true;
            this.link_setPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_setPicture_LinkClicked);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // DashBoard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.link_setPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.grbx_welcome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoard_FormClosed);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.grbx_welcome.ResumeLayout(false);
            this.grbx_welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_welcome;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link_setPicture;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}