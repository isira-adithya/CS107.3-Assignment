using MySql.Data.MySqlClient;
using PosSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageProduct : Form
    {
        private Product product = new Product();
        string NProdName;
        string NProdDescrip;
        int NQty;
        double NPrice;

        public ManageProduct()
        {
            InitializeComponent();
        }

        private void clearForm()
        {
            productName.Text = "";
            productDescription.Text = "";
            productQuantity.Value = 1;
            productPrice.Text = "0";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult uResponse = MessageBox.Show("Are you sure?", "POS System", MessageBoxButtons.YesNo);
            if (uResponse == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = product.deleteProduct();

                if (result)
                {
                    MessageBox.Show("Product has been deleted.", "POS");
                    this.clearForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "POS");
                }
            }
        }

        private void UpdateDetailsButton_Click(object sender, EventArgs e)
        {

            // below are the new product details(N)for New Details
            NProdName = productName.Text;
            NProdDescrip = productDescription.Text;
            NQty = int.Parse(productQuantity.Value.ToString());
            NPrice = double.Parse(productPrice.Text);

            product.setNewDetails(NProdName, NProdDescrip, NQty, NPrice);
            bool result = product.updateDetails();

            if (result)
            {
                MessageBox.Show("Product has been updated.", "POS");
                AddProCancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Something went wrong.", "POS");
            }

        }

        private void AddProCancel_Click(object sender, EventArgs e)
        {
            this.clearForm();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = searchQueryTextBox.Text;
            bool result = product.findProduct(query);

            if (result)
            {
                productName.Text = product.getName();
                productDescription.Text = product.getDescription();
                productQuantity.Value = Decimal.Parse(product.getStock().ToString());
                productPrice.Text = product.getPrice().ToString();
            }
        }

        private void checkPrice(object sender, EventArgs e)
        {
            try
            {
                double.Parse(productPrice.Text);
                return;
            } catch
            {
                MessageBox.Show("Invalid Input!", "POS");
                productPrice.Text = "0";
                return;
            }
        }

        private void goBackToPreviousForm(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
}
