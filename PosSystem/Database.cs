using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace PosSystem
{
    internal class Database
    {
        private string Server = "localhost";
        private string DatabaseName = "pos";
        private string UserName = "root";
        private string Password = "";
        private static Database _instance = null;

        public MySqlConnection Connection { get; set; }

        public Database()
        {
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
            Connection = new MySqlConnection(connstring);
        }

        public static Database Instance()
        {
            if (_instance == null)
                _instance = new Database();
            return _instance;
        }

        public bool IsConnected()
        {
            if (Connection.State.ToString() == "Closed")
            {
                MessageBox.Show("Database is not connected!", "MySQL Client");
                return false;
            } else
            {
                return true;
            }
        }

        public bool Connect()
        {
            try
            {
                if (Connection.State.ToString() == "Closed")
                {
                    Connection.Open();
                } 
            } catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while connecting to the database. \n " + ex.ToString(), "MySQL Client");
                return false;
            }
            return true;
        }

        public void Disconnect()
        {
            Connection.Close();
        }
    }
}
