using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Log_Form.Forms
{
    public partial class LogsListForm : Form
    {
        public LogsListForm()
        {
            InitializeComponent();
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.LogsForm = this;
            Session.AdminPanel.Show();
            Hide();
        }

        private void LogListForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = Session.User.Email;

            rtxbx_logs.Text = FileManager.ReadLogs(FileManager.GetPath("logs", "logs.txt"));
        }

        private void LogListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();
        }
    }
}
