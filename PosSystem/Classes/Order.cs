using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PosSystem.Classes
{
    internal class Order
    {
        // Properties
        private int id;
        private string customer_first_name;
        private string customer_last_name;
        private string customer_phone_number;
        private string customer_address;
        private string customer_email;
        private string datetime;
        private double total_price;
        private string paymentMethod;


        // DB
        private Database db;

        public Order()
        {
            db = new Database();
            db.Connect();
        }

        // Finding an order using the OrderID
        public bool findOrderById(int orderId)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM orders WHERE id=@val1", db.Connection);
            cmd.Parameters.AddWithValue("@val1", orderId.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Assigns the values to the class variables
                id = reader.GetInt32(0);
                customer_first_name = reader.GetString(1);
                customer_last_name = reader.GetString(2);
                customer_phone_number = reader.GetString(3);
                customer_address = reader.GetString(4);
                customer_email = reader.GetString(5);
                datetime = reader.GetDateTime(6).ToString();
                total_price = reader.GetDouble(7);
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

        // Gets the product Ids and quantities of a specific order from orderproducts
        public Dictionary<int, int> findOrderProductQuantities(int orderId)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM orderproducts WHERE order_id=@val1", db.Connection);
            cmd.Parameters.AddWithValue("@val1", orderId.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            // Creates a new dictionary with both key and value as Integer variables (pid, quantity)
            Dictionary<int, int> result = new Dictionary<int, int>();
            int productId;
            int quantity;

            while (reader.Read())
            {

                productId = reader.GetInt32(0);
                quantity = reader.GetInt32(2);
                result.Add(productId, quantity);
            }

            reader.Close();

            // Returning an empty dictionary
            return result;
        }

        public bool createNewOrder(string fname, string lname, string pnumber, string address, string emailaddr, double totalprice, string paymentmethod, Dictionary<int, int> productQuantity)
        {
            int result = 0;
            string query = $"INSERT INTO orders(customer_first_name, customer_last_name, customer_phone_number, customer_address, customer_email, date_time, total_price, paymentMethod) OUTPUT INSERTED.ID VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8);";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", fname);
            cmd.Parameters.AddWithValue("@val2", lname);
            cmd.Parameters.AddWithValue("@val3", pnumber);
            cmd.Parameters.AddWithValue("@val4", address);
            cmd.Parameters.AddWithValue("@val5", emailaddr);
            cmd.Parameters.AddWithValue("@val6", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            cmd.Parameters.AddWithValue("@val7", totalprice);
            cmd.Parameters.AddWithValue("@val8", paymentmethod);
            int currentSqlRecordId = (int)cmd.ExecuteScalar();

            foreach (KeyValuePair<int, int> product in productQuantity)
            {
                int productId = product.Key;
                int requestedQuantity = product.Value;

                query = "INSERT INTO orderproducts(product_id, order_id, quantity) VALUES (@val1, @val2, @val3);";
                cmd = new SqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@val1", productId);
                cmd.Parameters.AddWithValue("@val2", currentSqlRecordId);
                cmd.Parameters.AddWithValue("@val3", requestedQuantity);
                result = cmd.ExecuteNonQuery();

                if (result != 1)
                {
                    return false;
                }

                // Deducting the stock
                query = $"UPDATE products SET stock=((SELECT stock FROM products WHERE id=@pid) - @val1) WHERE id=@pid;";
                cmd = new SqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@val1", requestedQuantity);
                cmd.Parameters.AddWithValue("@pid", productId);
                result = cmd.ExecuteNonQuery();

                if (result != 1)
                {
                    return false;
                }
            }

            this.findOrderById(currentSqlRecordId);

            return true;
        }

        // Getters

        public int getId()
        {
            return id;
        }
        public string getCustomerName()
        {
            return customer_first_name + " " +  customer_last_name;
        }

        public string getCustomerPhone()
        {
            return customer_phone_number;
        }

        public string getCustomerEmail()
        {
            return customer_email;
        }

        public string getCustomerAddress()
        {
            return customer_address;
        }

        public string getPaymentMethod()
        {
            return paymentMethod;
        }

        public double getTotalPrice()
        {
            return total_price;
        }

        public string getDateTime()
        {
            return datetime;
        }



    }
}
