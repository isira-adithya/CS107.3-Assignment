using PosSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class AddOrder : Form
    {
        private string role;
        private Product product;

        // Variables

        // Customer Related
        private string customer_first_name;
        private string customer_last_name;
        private string customer_phone;
        private string customer_email;
        private string customer_address;

        // Order Related
        private Dictionary<int, int> productQuantity = new Dictionary<int, int>();

        public AddOrder()
        {
            InitializeComponent();
            product = new Product();
        }
        public void SetRole(string _role)
        {
            this.role = _role;
        }

        private void goBackToPreviousForm(object sender, FormClosedEventArgs e)
        {
            if (this.role == "ADMIN")
            {
                AdminHome adminHome = new AdminHome();
                adminHome.Show();
            }
            else
            {
                UserHome userHome = new UserHome();
                userHome.Show();
            }
        }

        private void saveCustomerBtn_Click(object sender, EventArgs e)
        {
            if ((firstnameInputBox.Text.Length > 0) && (lastnameInputBox.Text.Length > 0))
            {
                customer_first_name = firstnameInputBox.Text;
                customer_last_name = lastnameInputBox.Text;
                customer_phone = phoneInputBox.Text;
                customer_email = emailInputBox.Text;
                customer_address = addressInputBox.Text;
                customerDetailsGroupBox.Enabled = false;
                addProductsGroupBox.Enabled = true;
            } else
            {
                MessageBox.Show("Customer's First name and Last name is required");
            }
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool searchResult = product.findProduct(productNameInputBox.Text);
            if (searchResult)
            {
                searchResultsLabel.Text = "Name: " + product.getName() + "\nCurrent Stock: " + product.getStock();
                AddProductBtn.Enabled = true;
            } else
            {
                searchResultsLabel.Text = "Not Found";
                AddProductBtn.Enabled = false;
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            // Checking if there are enough stock available 
            int stockRequested = int.Parse(quantityNumericUpDown.Value.ToString());
            if (stockRequested > product.getStock())
            {
                MessageBox.Show("Not enough stock available", "POS");
                return;
            }

            productQuantity.Add(product.getId(), stockRequested);
            searchResultsLabel.Text = "Not Found";
            AddProductBtn.Enabled = false;
            productNameInputBox.Text = "";
        }
    }
}
