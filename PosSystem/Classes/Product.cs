using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem.Classes
{
    internal class Product
    {
        private int id;
        private string name;
        private string description;
        private double price;
        private int stock;


        private Database db;

        public Product()
        {
            db = new Database();
            db.Connect();
        }

        public bool findProduct(string query)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM products WHERE name LIKE @val1", db.Connection);
            cmd.Parameters.AddWithValue("@val1", "%" + query + "%");

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = reader.GetInt32(0);
                name = reader.GetString(1);
                stock = reader.GetInt32(2);
                price = reader.GetDouble(3);
                description = reader.GetString(4);
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

        public bool createNewProduct(string _name, string _description, int _stock, double _price)
        {
            string query = $"INSERT INTO products(name, description, stock, price) VALUES (@val1, @val2, @val3, @val4);";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", _name);
            cmd.Parameters.AddWithValue("@val2", _description);
            cmd.Parameters.AddWithValue("@val3", _stock);
            cmd.Parameters.AddWithValue("@val4", _price);
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
            string query = $"DELETE FROM products WHERE id=@val1;";
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

        public bool updateDetails()
        {
            string query = $"UPDATE products SET name=@val1,description=@val2,stock=@val3,price=@val4 WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", name);
            cmd.Parameters.AddWithValue("@val2", description);
            cmd.Parameters.AddWithValue("@val3", stock);
            cmd.Parameters.AddWithValue("@val4s", price);
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
        public string getName()
        {
            return this.name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public int getStock()
        {
            return this.stock;
        }

        public double getPrice()
        {
            return this.price;
        }

        public int getId()
        {
            return this.id;
        }

        // Setters
        public void setNewDetails(string _name, string _description, int _stock, double _price)
        {
            this.name = _name;
            this.description = _description;
            this.stock = _stock;
            this.price = _price;
        }
    }
}
