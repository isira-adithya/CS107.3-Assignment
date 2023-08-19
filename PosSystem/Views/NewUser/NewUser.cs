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
    public partial class NewUser : Form
    {
        Database db = new Database();
        public NewUser()
        {
            InitializeComponent();
            db.Connect();
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
            usernameInputBox.Text = string.Empty;
            passwordInputBox.Text = string.Empty;
            rpasswordInputBox.Text = string.Empty;
            adminRoleRadioBtn.Checked = false;
            userRoleRadioBtn.Checked = false;
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


            string query = $"INSERT INTO users(first_name, last_name, username, password, email, role) VALUES (@val1, @val2, @val3, @val4, @val5, @val6);";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", first_name);
            cmd.Parameters.AddWithValue("@val2", last_name);
            cmd.Parameters.AddWithValue("@val3", username);
            cmd.Parameters.AddWithValue("@val4", password);
            cmd.Parameters.AddWithValue("@val5", email);
            cmd.Parameters.AddWithValue("@val6", role);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                MessageBox.Show($"New {role} account has been added.", "POS");
                this.cancelBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Something went wrong.", "POS");
            }

        }
    }
}
