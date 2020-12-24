using Reg_Log_Form.Forms;
using System;
using System.Windows.Forms;

namespace Reg_Log_Form
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            User user = Session.User;
            lbl_welcome.Text = "Welcome " + user.Email;
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel = Session.AdminPanel ?? this;
            Session.Form1.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel = Session.AdminPanel ?? this;
            UsersListForm usersListForm = Session.ListForm ?? new UsersListForm();
            Hide();
            usersListForm.ShowDialog();
        }

        private void lnl_logList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel = Session.AdminPanel ?? this;
            LogsListForm logsListForm = Session.LogsForm ?? new LogsListForm();
            Hide();
            logsListForm.ShowDialog();
        }
        private void grbx_welcome_Enter(object sender, EventArgs e)
        {

        }
    }
}
