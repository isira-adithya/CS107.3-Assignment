using PosSystem.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class LoginForm : Form
    {
        Database db = new Database();

        public LoginForm()
        {
            InitializeComponent();
            db.Connect();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            Account accountObj = new Account();
            bool loginResult = accountObj.checkCredentials(username, password);
            if (loginResult)
            {
                if (accountObj.getRole() == "ADMIN")
                {
                    this.Hide();
                    AdminHome adminHomeObj = new AdminHome();
                    adminHomeObj.Show();
                } else
                {
                    this.Hide();
                    UserHome userHomeObj = new UserHome();
                    userHomeObj.Show();
                }
            } else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

    }
}
