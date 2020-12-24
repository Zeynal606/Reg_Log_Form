using System;
using System.Windows.Forms;
using System.Net;
using Reg_Log_Form.Forms;
using System.Net.Mail;
using Reg_Log_Form.Core;

namespace Reg_Log_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load1(object sender, EventArgs e)
        {

        }
        private void grbx_Register_Enter(object sender, EventArgs e)
        {

        }
        private void lbl_name_Click(object sender, EventArgs e)
        {

        }
        private void txbx_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_surname_Click(object sender, EventArgs e)
        {

        }
        private void txbx_surname_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_age_Click(object sender, EventArgs e)
        {

        } 
        private void txbx_age_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_email_Click(object sender, EventArgs e)
        {

        }
        private void txbx_email_TextChanged(object sender, EventArgs e)
        {

        }
        private void linklbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (grbx_register.Visible, grbx_login.Visible) = (false, true);
            (linklbl_login.Visible, linklbl_Reg.Visible) = (false, true);
        }
        private void grbx_login_Enter(object sender, EventArgs e)
        {
   
        }
        private void lbl_password_Click(object sender, EventArgs e)
        {

        }
        private void txbx_loginEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbx_password_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbx_loginPassw_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {

                string
                    name = txbx_name.Text,
                    surname = txbx_surname.Text,
                    email = txbx_email.Text,
                    password = txbx_password.Text,
                    age = txbx_age.Text;
                if (!Validator.IsEmailValid(email))
                    throw new InvalidEmailException("Email format is not correct!");

                if (!Validator.IsPasswordValid(password))
                    throw new InvalidPasswordExseption("Email format is not correct! Password Length must be more than 4 charecters!");

                Validator.Validate(name, surname, age, password, email);
                sbyte convertedAge = Validator.CheckUserAge(age);

                if (!Users.HasUser(email, password))
                {
                    User user = new User(name, surname, convertedAge, email, password)
                    {
                        UserRole = UserRole.User
                    };

                    Session.User = user;
                    Session.Code = AccountManager.ConfirmationCode;
                    AccountManager.DisplayConfirmationWindow += AccountManager_DisplayConfirmationWindow;
                    AccountManager.SendMail(email);
                    if (user.IsEmailConfirmed)
                    {
                        Users.AddUser(user);
                        MessageBox.Show("You succesfully registered");
                    }
                    else
                    {
                        MessageBox.Show("Email confirmation Failed");
                    }
                }

            }
            catch (OverflowException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (ArgumentNullException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (SmtpException exp)
            {
                string message = "You did not give access to this app!";
                MessageBox.Show(message);
            }
            catch (InvalidEmailException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidPasswordExseption exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                EmptyTextBoxes(txbx_age, txbx_email, txbx_name, txbx_password, txbx_surname);
            }
        }

        private void AccountManager_DisplayConfirmationWindow()
        {
            new ConfirmationForm().ShowDialog();
        }

        private void EmptyTextBoxes(params TextBox[] textBoxes)
        {
            if (textBoxes == null)
                throw new ArgumentNullException();
            foreach(var txbx in textBoxes)
            {
                txbx.Text = string.Empty;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

                if(Users.HasUser(txbx_loginEmail.Text, txbx_loginPassw.Text))
                {
                    MessageBox.Show("You successfully logged in");
                }
                else
                {
                    MessageBox.Show("Try again, please. Email or Password value is givenwrong");
                }
        }

        private void linllbl_Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (grbx_register.Visible, grbx_login.Visible) = (true, false);
            (linklbl_login.Visible, linklbl_Reg.Visible) = (true, false);
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                string
    email = txbx_loginEmail.Text,
    password = txbx_loginPassw.Text;

                Validator.Validate(email, password);

                if (!Validator.IsEmailValid(email))
                    throw new InvalidEmailException("Email format is not correct!");

                if (!Validator.IsPasswordValid(password))
                    throw new InvalidPasswordExseption("Email format is not correct! Password Length must be more than 4 charecters!");

                if (Users.HasUser(email, password))
                {
                    User currentUser = Users.GetUser(email, password);
                    Session.User = currentUser;
                    Session.Form1 = this;
                    Hide();
                    if (currentUser.UserRole == UserRole.Admin)
                    {
                        AdminPanel adminPanel = Session.AdminPanel ?? new AdminPanel();
                        adminPanel.ShowDialog();
                    }
                    else
                    {
                        DashBoard dashBoard = Session.DashBoard ?? new DashBoard();
                        dashBoard.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Try again, please. Email or Password value is givenwrong");
                }
            }
            catch (Exception exp)
            {
               // MessageBox.Show(exp.Message);
                MessageBox.Show("Try again, please. Email or Password value is givenwrong");
            }
            finally
            {
                EmptyTextBoxes(txbx_loginEmail, txbx_loginPassw);
            }
        }
    }
}
