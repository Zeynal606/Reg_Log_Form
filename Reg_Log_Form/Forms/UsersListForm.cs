using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Log_Form
{
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            User user = Session.User;
            lbl_welcome.Text = "Welcome " + user.Email;

            dataTable.DataSource = Users.GetUsers();
        }
        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.ListForm = this;
            Session.AdminPanel.Show();
            Hide();
        }
        private void UsersListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();
        }
    }
}
