using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void product_add_Click(object sender, EventArgs e)
        {
            // instead of Product i have used (Prod)
            string ProdName;
            string ProdDescrip;
            decimal Qty;
            double Price;

            ProdName = ProductNameTextBox.Text;
            ProdDescrip = DescriptionTextBox.Text;
            Qty = QuantityNumericUpDown.Value;
            Price = double.Parse(PriceTextBox.Text);
            Database db = new Database();
            db.Connect();

            if (db.IsConnected())
            {
                string query = $"INSERT INTO products(name, quantity, price, description) VALUES (@val1, @val2, @val3, @val4);";
                SqlCommand cmd = new SqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@val1", ProdName);
                cmd.Parameters.AddWithValue("@val2", Qty);
                cmd.Parameters.AddWithValue("@val3", Price);
                cmd.Parameters.AddWithValue("@val4", ProdDescrip);
                int result = cmd.ExecuteNonQuery();
                
                if (result == 1)
                {
                    MessageBox.Show("New product has been added.", "POS");
                    AddProCancel_Click(sender, e);
                } else
                {
                    MessageBox.Show("Something went wrong.", "POS");
                }
            }


        }

        private void AddProCancel_Click(object sender, EventArgs e)
        {
            ProductNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            QuantityNumericUpDown.Value = 1;
            PriceTextBox.Text = "";
        }

    }
}
