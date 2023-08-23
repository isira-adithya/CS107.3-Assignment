using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem.Classes
{
    internal class Order
    {
        private int id;
        private string customer_first_name;
        private string customer_last_name;
        private string customer_phone_number;
        private string customer_address;
        private string customer_email;
        private string datetime;
        private double total_price;
        private string paymentMethod;


        private Database db;

        public Order()
        {
            db = new Database();
            db.Connect();
        }

        public bool findOrderById(int orderId)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM orders WHERE id=@val1", db.Connection);
            cmd.Parameters.AddWithValue("@val1", orderId.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                id = reader.GetInt32(0);
                customer_first_name = reader.GetString(1);
                customer_last_name = reader.GetString(2);
                customer_phone_number = reader.GetString(3);
                customer_address = reader.GetString(4);
                customer_email = reader.GetString(5);
                datetime = reader.GetDateTime(6).ToString();
                total_price = reader.GetInt32(7);
                paymentMethod = reader.GetString(8);
            }

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public bool createNewOrder(string fname, string lname, string pnumber, string address, string emailaddr, double totalprice, string paymentmethod)
        {
            string query = $"INSERT INTO orders(customer_first_name, customer_last_name, customer_phone_number, customer_address, customer_email, date_time, total_price, paymentMethod) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8);";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", fname);
            cmd.Parameters.AddWithValue("@val2", lname);
            cmd.Parameters.AddWithValue("@val3", pnumber);
            cmd.Parameters.AddWithValue("@val4", address);
            cmd.Parameters.AddWithValue("@val5", emailaddr);
            cmd.Parameters.AddWithValue("@val6", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@val7", totalprice);
            cmd.Parameters.AddWithValue("@val8", paymentmethod);
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

        public bool deleteProduct()
        {
            string query = $"DELETE FROM orders WHERE id=@val1;";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", id);
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
        

    }
}
