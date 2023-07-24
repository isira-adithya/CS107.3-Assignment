using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class LoginForm : Form
    {
        Database dbCon = Database.Instance();

        public LoginForm()
        {
            InitializeComponent();
            dbCon.Connect();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string _username = "";
            string _password = "";
            string _role = "";

            username = usernameTextBox.Text;
            password = passwordTextBox.Text;


            if (dbCon.IsConnected())
            {
                string query = $"SELECT * FROM users WHERE username='{username}';";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                bool isLoggedIn = false;
                while (reader.Read())
                {
                    _username = reader.GetString(3);
                    _password = reader.GetString(4);
                    _role = reader.GetString(6);
                    if (_password == password)
                    {
                        isLoggedIn = true;
                    }
                }
                reader.Close();
                if (isLoggedIn)
                {
                    if (_role == "ADMIN")
                    {
                        HomeAdmin homeAdmin = new HomeAdmin();
                        homeAdmin.Show();
                        this.Hide();
                    } else
                    {
                        HomeUser homeUser = new HomeUser();
                        homeUser.Show();
                        this.Hide();
                    }
                    
                } else
                {
                    MessageBox.Show("Invalid Credentials", "Login");
                }
            }


            if (username == "Admin" && password == "admin123")
            {
                HomeAdmin objAhome = new HomeAdmin();
                objAhome.Show();
                this.Hide();
            }
            else if((username=="Isuru" && password == "Isuru123") || (username=="Isira" && password == "Isira123"))
            {
                
                HomeUser objUhome = new HomeUser();
                objUhome.Show();
                this.Hide();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

    }
}
