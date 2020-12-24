using Reg_Log_Form.Visulizers;
using System;
using System.Windows.Forms;

namespace Reg_Log_Form
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private readonly Form1 mainForm = Session.Form1;
        private readonly string path_toLogs = FileManager.GetPath("logs", "logs.txt");
        private User user = null;

        private void DisplayUserInfo(User user)
        {
            lbl_welcome.Text = "Welcome " + user.Email;
            lbl_name.Text = "Name: " + user.Name;
            lbl_surname.Text = "Surname: " + user.Surname;
            lbl_age.Text = "Age: " + user.Age;

        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            user = Session.User;
            DisplayUserInfo(user);

            if (!string.IsNullOrEmpty(user.ProfilePicturePath))
            {
                FileManager.ShowMyImage(user.ProfilePicturePath, pictureBox1, 225, 225);
            }
            else
            {
                FileManager.ShowMyImage(FileManager.GetPath("pics", "user_pic_007.png"), pictureBox1, 225, 225);
            }

            //
            FileManager.WriteLog(path_toLogs, FileManager.GetLogMessage(new JSONVisualizer(user.Email, Roles.LogStatus.LogIn)));
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //
            FileManager.WriteLog(path_toLogs, FileManager.GetLogMessage(new JSONVisualizer(user.Email, Roles.LogStatus.LogOut)));

            Session.DashBoard = this;
            mainForm.Show();
            Hide();
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();
        }

        private void link_setPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                user.ProfilePicturePath = FileManager.CopyPicture(fileName);
                FileManager.ShowMyImage(user.ProfilePicturePath, pictureBox1, 225, 225);
            }
        }
    }
}
