namespace Reg_Log_Form
{
    partial class UsersListForm
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.grbx_welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_welcome
            // 
            this.grbx_welcome.Controls.Add(this.link_logout);
            this.grbx_welcome.Controls.Add(this.lbl_welcome);
            this.grbx_welcome.Location = new System.Drawing.Point(6, 8);
            this.grbx_welcome.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.grbx_welcome.Name = "grbx_welcome";
            this.grbx_welcome.Padding = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.grbx_welcome.Size = new System.Drawing.Size(844, 76);
            this.grbx_welcome.TabIndex = 2;
            this.grbx_welcome.TabStop = false;
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.Font = new System.Drawing.Font("Impact", 18F);
            this.link_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.link_logout.Location = new System.Drawing.Point(751, 38);
            this.link_logout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.lbl_welcome.Location = new System.Drawing.Point(9, 28);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 29);
            this.lbl_welcome.TabIndex = 0;
            // 
            // dataTable
            // 
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(6, 92);
            this.dataTable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 60;
            this.dataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTable.Size = new System.Drawing.Size(844, 278);
            this.dataTable.TabIndex = 3;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 381);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.grbx_welcome);
            this.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersListForm_FormClosed);
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            this.grbx_welcome.ResumeLayout(false);
            this.grbx_welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_welcome;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.DataGridView dataTable;
    }
}