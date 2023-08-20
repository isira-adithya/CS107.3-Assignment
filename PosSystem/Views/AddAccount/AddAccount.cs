using PosSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class AddAccount : Form
    {
        Account account = new Account();
        public AddAccount()
        {
            InitializeComponent();
        }

        private void clearForm()
        {
            usernameInputBox.Text = string.Empty;
            passwordInputBox.Text = string.Empty;
            rpasswordInputBox.Text = string.Empty;
            adminRoleRadioBtn.Checked = false;
            userRoleRadioBtn.Checked = false;
        }

        private void goBackToPreviousForm(object sender, FormClosedEventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void adminRoleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (adminRoleRadioBtn.Checked)
            {
                userRoleRadioBtn.Checked = false;
            }
        }

        private void userRoleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (userRoleRadioBtn.Checked)
            {
                adminRoleRadioBtn.Checked = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInputBox.Text;
            string password = passwordInputBox.Text;
            string repeatPassword =  rpasswordInputBox.Text;
            string email = emailInputBox.Text;
            string first_name = firstnameInputBox.Text;
            string last_name = lastnameInputBox.Text;
            string role = "";

            if ((username == "") || (password == "") || (repeatPassword == "") || (email == "") || (first_name == "") || (last_name == ""))
            {
                MessageBox.Show("Please fill in the all required values", "POS");
                return;
            }

            if (!account.isUsernameValid(username))
            {
                MessageBox.Show("There is an exisiting account with the same username", "POS");
                return;
            }

            if (adminRoleRadioBtn.Checked || userRoleRadioBtn.Checked )
            {
                if ( adminRoleRadioBtn.Checked )
                {
                    role = "ADMIN";
                } else
                {
                    role = "USER";
                }
            } else
            {
                MessageBox.Show("Please select the role of the account", "POS");
                return;
            }

            if (password != repeatPassword)
            {
                MessageBox.Show("Passwords doesn't match! Please recheck", "POS");
                return;
            }


            bool accountCreationResult = account.createNewAccount(first_name, last_name, username, password, email, role);
            if (accountCreationResult)
            {
                MessageBox.Show("Successfully created the new account.", "POS");
                clearForm();
            } else
            {
                MessageBox.Show("Something went wrong.", "POS");
            }

        }
    }
}
