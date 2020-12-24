namespace Reg_Log_Form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linklbl_login = new System.Windows.Forms.LinkLabel();
            this.linklbl_Reg = new System.Windows.Forms.LinkLabel();
            this.grbx_login = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.loginlbl_Passw = new System.Windows.Forms.Label();
            this.txbx_loginEmail = new System.Windows.Forms.TextBox();
            this.loginlbl_Email = new System.Windows.Forms.Label();
            this.txbx_loginPassw = new System.Windows.Forms.TextBox();
            this.grbx_register = new System.Windows.Forms.GroupBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txbx_age = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.grbx_login.SuspendLayout();
            this.grbx_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklbl_login
            // 
            this.linklbl_login.ActiveLinkColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.linklbl_login, "linklbl_login");
            this.linklbl_login.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linklbl_login.CausesValidation = false;
            this.linklbl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbl_login.DisabledLinkColor = System.Drawing.Color.Black;
            this.linklbl_login.ForeColor = System.Drawing.Color.Aquamarine;
            this.linklbl_login.Name = "linklbl_login";
            this.linklbl_login.TabStop = true;
            this.linklbl_login.VisitedLinkColor = System.Drawing.Color.LightGreen;
            this.linklbl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_login_LinkClicked);
            // 
            // linklbl_Reg
            // 
            this.linklbl_Reg.ActiveLinkColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.linklbl_Reg, "linklbl_Reg");
            this.linklbl_Reg.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_Reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linklbl_Reg.CausesValidation = false;
            this.linklbl_Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbl_Reg.DisabledLinkColor = System.Drawing.Color.Black;
            this.linklbl_Reg.ForeColor = System.Drawing.Color.Aquamarine;
            this.linklbl_Reg.Name = "linklbl_Reg";
            this.linklbl_Reg.TabStop = true;
            this.linklbl_Reg.VisitedLinkColor = System.Drawing.Color.LightGreen;
            this.linklbl_Reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linllbl_Reg_LinkClicked);
            // 
            // grbx_login
            // 
            this.grbx_login.BackColor = System.Drawing.Color.Transparent;
            this.grbx_login.Controls.Add(this.btn_login);
            this.grbx_login.Controls.Add(this.loginlbl_Passw);
            this.grbx_login.Controls.Add(this.txbx_loginEmail);
            this.grbx_login.Controls.Add(this.loginlbl_Email);
            this.grbx_login.Controls.Add(this.txbx_loginPassw);
            this.grbx_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbx_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.grbx_login, "grbx_login");
            this.grbx_login.ForeColor = System.Drawing.Color.Black;
            this.grbx_login.Name = "grbx_login";
            this.grbx_login.TabStop = false;
            this.grbx_login.Tag = "";
            this.grbx_login.Enter += new System.EventHandler(this.grbx_login_Enter);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_login.FlatAppearance.BorderSize = 3;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_login.Name = "btn_login";
            this.btn_login.Tag = "";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // loginlbl_Passw
            // 
            resources.ApplyResources(this.loginlbl_Passw, "loginlbl_Passw");
            this.loginlbl_Passw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginlbl_Passw.ForeColor = System.Drawing.Color.Purple;
            this.loginlbl_Passw.Name = "loginlbl_Passw";
            this.loginlbl_Passw.UseMnemonic = false;
            // 
            // txbx_loginEmail
            // 
            resources.ApplyResources(this.txbx_loginEmail, "txbx_loginEmail");
            this.txbx_loginEmail.Name = "txbx_loginEmail";
            // 
            // loginlbl_Email
            // 
            resources.ApplyResources(this.loginlbl_Email, "loginlbl_Email");
            this.loginlbl_Email.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginlbl_Email.ForeColor = System.Drawing.Color.Purple;
            this.loginlbl_Email.Name = "loginlbl_Email";
            this.loginlbl_Email.UseMnemonic = false;
            // 
            // txbx_loginPassw
            // 
            resources.ApplyResources(this.txbx_loginPassw, "txbx_loginPassw");
            this.txbx_loginPassw.Name = "txbx_loginPassw";
            // 
            // grbx_register
            // 
            this.grbx_register.BackColor = System.Drawing.Color.Transparent;
            this.grbx_register.Controls.Add(this.btn_register);
            this.grbx_register.Controls.Add(this.lbl_password);
            this.grbx_register.Controls.Add(this.txbx_email);
            this.grbx_register.Controls.Add(this.lbl_email);
            this.grbx_register.Controls.Add(this.txbx_age);
            this.grbx_register.Controls.Add(this.lbl_age);
            this.grbx_register.Controls.Add(this.txbx_surname);
            this.grbx_register.Controls.Add(this.lbl_surname);
            this.grbx_register.Controls.Add(this.txbx_name);
            this.grbx_register.Controls.Add(this.lbl_name);
            this.grbx_register.Controls.Add(this.txbx_password);
            this.grbx_register.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbx_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.grbx_register, "grbx_register");
            this.grbx_register.Name = "grbx_register";
            this.grbx_register.TabStop = false;
            this.grbx_register.Enter += new System.EventHandler(this.grbx_Register_Enter);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_register.FlatAppearance.BorderSize = 3;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.btn_register, "btn_register");
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_register.Name = "btn_register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_password
            // 
            resources.ApplyResources(this.lbl_password, "lbl_password");
            this.lbl_password.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_password.ForeColor = System.Drawing.Color.Purple;
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.UseMnemonic = false;
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // txbx_email
            // 
            resources.ApplyResources(this.txbx_email, "txbx_email");
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.TextChanged += new System.EventHandler(this.txbx_email_TextChanged);
            // 
            // lbl_email
            // 
            resources.ApplyResources(this.lbl_email, "lbl_email");
            this.lbl_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_email.ForeColor = System.Drawing.Color.Purple;
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.UseMnemonic = false;
            // 
            // txbx_age
            // 
            resources.ApplyResources(this.txbx_age, "txbx_age");
            this.txbx_age.Name = "txbx_age";
            this.txbx_age.TabStop = false;
            // 
            // lbl_age
            // 
            resources.ApplyResources(this.lbl_age, "lbl_age");
            this.lbl_age.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_age.ForeColor = System.Drawing.Color.Purple;
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.UseMnemonic = false;
            this.lbl_age.Click += new System.EventHandler(this.lbl_age_Click);
            // 
            // txbx_surname
            // 
            resources.ApplyResources(this.txbx_surname, "txbx_surname");
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.TabStop = false;
            this.txbx_surname.TextChanged += new System.EventHandler(this.txbx_surname_TextChanged);
            // 
            // lbl_surname
            // 
            resources.ApplyResources(this.lbl_surname, "lbl_surname");
            this.lbl_surname.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_surname.ForeColor = System.Drawing.Color.Purple;
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.UseMnemonic = false;
            this.lbl_surname.Click += new System.EventHandler(this.lbl_surname_Click);
            // 
            // txbx_name
            // 
            resources.ApplyResources(this.txbx_name, "txbx_name");
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.TabStop = false;
            this.txbx_name.TextChanged += new System.EventHandler(this.txbx_name_TextChanged);
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.UseMnemonic = false;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // txbx_password
            // 
            resources.ApplyResources(this.txbx_password, "txbx_password");
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.TextChanged += new System.EventHandler(this.txbx_password_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.grbx_login);
            this.Controls.Add(this.grbx_register);
            this.Controls.Add(this.linklbl_login);
            this.Controls.Add(this.linklbl_Reg);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form_Load1);
            this.grbx_login.ResumeLayout(false);
            this.grbx_login.PerformLayout();
            this.grbx_register.ResumeLayout(false);
            this.grbx_register.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txbx_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Label loginlbl_Passw;
        private System.Windows.Forms.Label loginlbl_Email;
        private System.Windows.Forms.GroupBox grbx_register;
        private System.Windows.Forms.GroupBox grbx_login;
        private System.Windows.Forms.TextBox txbx_loginPassw;
        private System.Windows.Forms.TextBox txbx_loginEmail;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linklbl_login;
        private System.Windows.Forms.LinkLabel linklbl_Reg;
    }
}

