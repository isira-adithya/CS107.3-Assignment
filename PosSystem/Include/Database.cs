using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PosSystem
{
    internal class Database
    {
        public SqlConnection Connection { get; set; }
        

        public Database()
        {
            string connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NSBM\\1st year\\C# Programming\\C-Sharp-Assignment\\posdb.mdf\";Integrated Security=True;Connect Timeout=30";
            Connection = new SqlConnection(connstring);
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
                Connection.Open();
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
