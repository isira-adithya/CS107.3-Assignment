using PosSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageAccount : Form
    {
        Account account = new Account();
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void lockFields(bool state)
        {
            emailInput.Enabled = state;
            firstnameInput.Enabled = state;
            lastnameInput.Enabled = state;
            changeRoleBtn.Enabled = state;
            deleteBtn.Enabled = state;
            updateBtn.Enabled = state;
        }

        private void clearFields()
        {
            usernameInput.Text = "";
            emailInput.Text = "";
            firstnameInput.Text = "";
            lastnameInput.Text = "";
            roleLabel.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query = searchQueryInput.Text;
            bool isValid = account.findAccount(query);
            if (isValid) {
                usernameInput.Text = account.getUserName();
                emailInput.Text = account.getEmail();
                firstnameInput.Text = account.getFirstname();
                lastnameInput.Text = account.getLastname();
                roleLabel.Text = account.getRole();
                this.lockFields(true);
            } else
            {
                this.lockFields(false);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (account.deleteAccount())
            {
                MessageBox.Show("Successfully deleted the account.", "POS");
                clearFields();
                return;
            } else
            {
                MessageBox.Show("Something went wrong", "POS");
                return;
            }
        }

        private void changeRoleBtn_Click(object sender, EventArgs e)
        {
            string _role;
            if (account.getRole() == "USER")
            {
                _role = "ADMIN";
            } else
            {
                _role = "USER";
            }
            bool changeRoleResult = account.changeRole(_role);
            if (changeRoleResult)
            {
                MessageBox.Show("Successfully changed the role.", "POS");
                clearFields();
                return;
            }
            else
            {
                MessageBox.Show("Something went wrong", "POS");
                return;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            account.setNewDetails(firstnameInput.Text, lastnameInput.Text, emailInput.Text);
            bool updateResult = account.updateDetails();
            if (updateResult) {
                MessageBox.Show("Successfully updated the account", "POS");
            } else
            {
                MessageBox.Show("Something went wrong", "POS");
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string new_password = newPasswordInput.Text;
            string repeat_password = repeatPasswordInput.Text;

            if (new_password != repeat_password)
            {
                MessageBox.Show("Passwords doesn't match", "POS");
                return;
            }

            bool pChangeResult = account.changePassword(new_password);
            if (pChangeResult)
            {
                MessageBox.Show("Successfully changed the password", "POS");
            }
            else
            {
                MessageBox.Show("Something went wrong", "POS");
            }
        }

        private void ManageAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminHome adminHomeForm = new AdminHome();
            adminHomeForm.Show();
        }
    }
}
