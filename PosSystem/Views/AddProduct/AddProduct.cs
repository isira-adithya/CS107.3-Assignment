using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using PosSystem.Classes;
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
        Product product;
        public AddProduct()
        {
            InitializeComponent();
            product = new Product();
        }

        private void product_add_Click(object sender, EventArgs e)
        {
            // instead of Product i have used (Prod)
            string productName;
            string productDescription;
            decimal productStock;
            double productPrice;

            productName = ProductNameTextBox.Text;
            productDescription = DescriptionTextBox.Text;
            productStock = QuantityNumericUpDown.Value;

            // This if clause checks whether all the required fields are filled by the user
            if ((productName == "") || (productDescription == "") || (PriceTextBox.Text == ""))
            {
                MessageBox.Show("Please fill all the required fields.");
                return;
            }

            productPrice = double.Parse(PriceTextBox.Text);

            bool result = product.createNewProduct(productName, productDescription, int.Parse(productStock.ToString()), productPrice);

            if (result)
            {
                MessageBox.Show("New product has been added.", "POS");
                AddProCancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Something went wrong.", "POS");
            }

        }

        private void AddProCancel_Click(object sender, EventArgs e)
        {
            ProductNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            QuantityNumericUpDown.Value = 1;
            PriceTextBox.Text = "";
        }

        private void goBackToPreviousForm(object sender, FormClosedEventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
}
