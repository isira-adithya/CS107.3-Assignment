using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PosSystem.Classes
{
    internal class Account
    {
        private int id;
        private string first_name;
        private string last_name;
        private string email;
        private string username;
        private string password;
        private string role;


        private Database db;

        public Account()
        {
            db = new Database();
            db.Connect();
        }

        public bool checkCredentials(string username, string password)
        {
            string _username;
            string _password;
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
                    role = reader.GetString(6);
                    if (_password == password)
                    {
                        isLoggedIn = true;
                    }
                }
                reader.Close();

                return isLoggedIn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\n" + ex.Message);
            }
            return false;
        }

        public bool isUsernameValid(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username=@val1", db.Connection);
            cmd.Parameters.AddWithValue("@val1", username);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                return true;
            }
        }

        public bool findAccount(string query)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username LIKE @val1", db.Connection);
            cmd.Parameters.AddWithValue("@val1", "%" + query + "%");

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = reader.GetInt32(0);
                first_name = reader.GetString(1);
                last_name = reader.GetString(2);
                username = reader.GetString(3);
                password = reader.GetString(4);
                email = reader.GetString(5);
                role = reader.GetString(6);
            }

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            } else
            {
                reader.Close();
                return false;
            }
        }

        public bool createNewAccount(string _firstname, string _lastname, string _username, string _password, string _email, string _role)
        {
            string query = $"INSERT INTO users(first_name, last_name, username, password, email, role) VALUES (@val1, @val2, @val3, @val4, @val5, @val6);";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", _firstname);
            cmd.Parameters.AddWithValue("@val2", _lastname);
            cmd.Parameters.AddWithValue("@val3", _username);
            cmd.Parameters.AddWithValue("@val4", _password);
            cmd.Parameters.AddWithValue("@val5", _email);
            cmd.Parameters.AddWithValue("@val6", _role);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteAccount()
        {
            // Default account 'admin' should not be deleted from the application
            if (this.username == "admin")
            {
                return false;
            }

            string query = $"DELETE FROM users WHERE username=@val1;";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", username);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool changeRole(string _role)
        {
            string query = $"UPDATE users SET role=@val1 WHERE username=@val2;";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", _role);
            cmd.Parameters.AddWithValue("@val2", username);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateDetails()
        {
            string query = $"UPDATE users SET first_name=@val1,last_name=@val2,email=@val3 WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", first_name);
            cmd.Parameters.AddWithValue("@val2", last_name);
            cmd.Parameters.AddWithValue("@val3", email);
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool changePassword(string newpassword)
        {
            string query = $"UPDATE users SET password=@val1 WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", newpassword);
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Getters
        public string getRole()
        {
            return this.role;
        }

        public string getUserName()
        {
            return this.username;
        }

        public string getFirstname()
        {
            return this.first_name;
        }

        public string getLastname()
        {
            return this.last_name;
        }

        public string getEmail()
        {
            return this.email;
        }

        // Setters

        public void setNewDetails(string firstname, string lastname, string email)
        {
            this.first_name = firstname;
            this.last_name = lastname;
            this.email = email;
        }



    }
}
