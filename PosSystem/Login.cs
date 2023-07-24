﻿using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string _username = "";
            string _password = "";

            username = textBox1.Text;
            password = textBox2.Text;


            var dbCon = Database.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "pos";
            dbCon.UserName = "root";
            dbCon.Password = "";
            if (dbCon.IsConnect())
            {
                string query = $"SELECT * FROM test WHERE username='{username}';";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                bool isLoggedIn = false;
                while (reader.Read())
                {
                    _username = reader.GetString(3);
                    _password = reader.GetString(4);
                    if (_password == password)
                    {
                        isLoggedIn = true;
                    }
                }
                reader.Close();
                if (isLoggedIn)
                {
                    if ("Role" == "Admin")
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}