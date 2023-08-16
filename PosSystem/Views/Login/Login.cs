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
            string _username = "";
            string _password = "";
            string _role = "";

            username = usernameTextBox.Text;
            password = passwordTextBox.Text;


                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE username=@val1", db.Connection);
                    command.Parameters.AddWithValue("@val1", username);

                    var reader = command.ExecuteReader();
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
                            AdminHome homeAdmin = new AdminHome();
                            homeAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            UserHome homeUser = new UserHome();
                            homeUser.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials", "Login");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong:\n" + ex.Message);
                }
            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

    }
}
