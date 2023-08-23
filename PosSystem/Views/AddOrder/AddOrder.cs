﻿using PosSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PosSystem
{
    public partial class AddOrder : Form
    {
        private string role;
        private Product product;
        private Bitmap ssbitmap;

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

            // Preparing the DataGridView
            billDataGridView.Columns.Add("Name", "Name");
            billDataGridView.Columns.Add("Quantity", "Quantity");
            billDataGridView.Columns.Add("Price (per each)", "Price (per each)");
            billDataGridView.Columns.Add("Total Price", "Total Price");

            // Adding Payment Methods
            List<PaymentMethod> paymentMethods = new List<PaymentMethod>();
            paymentMethods.Add(new PaymentMethod() { Text = "PayPal", Value = "paypal" });
            paymentMethods.Add(new PaymentMethod() { Text = "Credit/Debit Card", Value = "card" });
            paymentMethods.Add(new PaymentMethod() { Text = "Cash", Value = "cash" });
            paymentMethods.Add(new PaymentMethod() { Text = "Other", Value = "other" });

            paymentMethodSelectionComboBox.DataSource = paymentMethods;
            paymentMethodSelectionComboBox.DisplayMember = "Text";
            paymentMethodSelectionComboBox.ValueMember = "Value";

            // Clearing Labels
            clearLabels();
        }
        public void SetRole(string _role)
        {
            this.role = _role;
        }

        private void clearLabels()
        {
            // Removing the 'Test' from labels
            firstnameLabel.Text = "";
            lastnameLabel.Text = "";
            emailLabel.Text = "";
            phoneLabel.Text = "";
            addressLabel.Text = "";
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

                firstnameLabel.Text = customer_first_name;
                lastnameLabel.Text = customer_last_name;
                emailLabel.Text = customer_email;
                phoneLabel.Text = customer_phone;
                addressLabel.Text = customer_address;
            } else
            {
                MessageBox.Show("Customer's First name and Last name is required");
            }
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (productNameInputBox.Text.Length > 0)
            {
                bool searchResult = product.findProduct(productNameInputBox.Text);
                if (searchResult)
                {
                    searchResultsLabel.Text = "Name: " + product.getName() + "\nCurrent Stock: " + product.getStock();
                    AddProductBtn.Enabled = true;
                }
                else
                {
                    searchResultsLabel.Text = "Not Found";
                    AddProductBtn.Enabled = false;
                }
            } else
            {
                MessageBox.Show("Please enter the search query", "POS");
                return;
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
            quantityNumericUpDown.Value = decimal.One;

            // Enabling the bill info groupbox
            billGroupBox.Enabled = true;

            updateBill();
        }

        private void updateBill()
        {
            // Updating the billDataGridView
            Product tmpProduct = new Product();
            double totalPrice = 0;
            billDataGridView.Rows.Clear();

            foreach (KeyValuePair<int, int> product in productQuantity)
            {
                int productId = product.Key;
                int requestedQuantity = product.Value;
                tmpProduct.findProductById(productId);

                double priceOfThis = tmpProduct.getPrice() * requestedQuantity;
                billDataGridView.Rows.Add(tmpProduct.getName(), requestedQuantity, tmpProduct.getPrice(), priceOfThis);

                totalPrice = totalPrice + priceOfThis;

            }

            totalPriceLabel.Text = totalPrice.ToString() + " LKR";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            Product tmpProduct = new Product();
            double totalPrice = 0;

            foreach (KeyValuePair<int, int> product in productQuantity)
            {
                int productId = product.Key;
                int requestedQuantity = product.Value;
                double priceOfThis = tmpProduct.getPrice() * requestedQuantity;
                tmpProduct.findProductById(productId);
                totalPrice = totalPrice + priceOfThis;

            }

            bool result = order.createNewOrder(customer_first_name, customer_last_name, customer_phone, customer_address, customer_email, totalPrice, paymentMethodSelectionComboBox.Text, productQuantity);
            if (result)
            {
                MessageBox.Show("Order has been saved.", "POS");

                // Refreshing the Form
                refreshForm();
            } else
            {
                MessageBox.Show("Something went wrong", "POS");
            }
        }

        private void refreshForm()
        {
            clearLabels();
            totalPriceLabel.Text = "0 LKR";
            billDataGridView.Rows.Clear();

            // Input Boxes
            firstnameInputBox.Text = "";
            lastnameInputBox.Text = "";
            phoneInputBox.Text = "";
            emailInputBox.Text = "";
            addressInputBox.Text = "";
            customerDetailsGroupBox.Enabled = true;
            addProductsGroupBox.Enabled = false;
            billGroupBox.Enabled = false;
            productNameInputBox.Text = "";
        }


        // Following 2 functions were taken from https://www.aspsnippets.com/Articles/Print-contents-of-Form-in-Windows-Forms-WinForms-Application-using-C-and-VBNet.aspx
        private void printBtn_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            ssbitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(ssbitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(ssbitmap, 0, 0);
        }
    }

    public class PaymentMethod
    {
        public PaymentMethod() { }

        public string Value { set; get; }
        public string Text { set; get; }
    }
}
