﻿using PosSystem.Classes;
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

namespace PosSystem.Views.ViewOrder
{
    public partial class ViewOrder : Form
    {
        Database db = new Database();
        Order order = new Order();
        public ViewOrder()
        {
            InitializeComponent();
            db = new Database();
            db.Connect();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            string qu = "SELECT id as 'Order ID', customer_first_name as 'First Name', customer_last_name as 'Last Name', date_time as 'Date/Time', total_price as 'Total Price', paymentMethod as 'Payment Method' FROM orders;";
            SqlDataAdapter dt = new SqlDataAdapter(qu, db.Connection);
            DataSet ds = new DataSet();
            dt.Fill(ds, "OrdersTable");

            ordersDataGrid.DataSource = ds;
            ordersDataGrid.DataMember = "OrdersTable";
            clearUserInputs();
        }

        private void clearUserInputs()
        {
            cAddressLabel.Text = "";
            cEmailLabel.Text = "";
            cnameLabel.Text = "";
            cPhoneLabel.Text = "";
            dateTimeLabel.Text = "";
            totalPriceLabel.Text = "";
            paymentMethodLabel.Text = "";
            orderDataGrid.Columns.Clear();
            orderDataGrid.Rows.Clear();
            orderDataGrid.Visible = false;
        }

        private void ViewOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminHome adminHomeForm = new AdminHome();
            adminHomeForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string oid = searchQueryTextBox.Text;
            bool result = order.findOrderById(int.Parse(oid));

            if (!result)
            {
                clearUserInputs();
                return;
            }

            cnameLabel.Text = order.getCustomerName();
            cEmailLabel.Text = order.getCustomerEmail();
            cAddressLabel.Text = order.getCustomerAddress();
            cPhoneLabel.Text = order.getCustomerPhone();
            totalPriceLabel.Text = order.getDateTime();
            paymentMethodLabel.Text = order.getPaymentMethod();
            dateTimeLabel.Text = order.getDateTime();

            // Rendering the product quantities
            orderDataGrid.Columns.Clear();
            orderDataGrid.Rows.Clear();

            orderDataGrid.Columns.Add("product_name", "Name");
            orderDataGrid.Columns.Add("product_quantity", "Quantity");
            orderDataGrid.Columns.Add("product_price", "Price (for each)");
            orderDataGrid.Columns.Add("product_total_price", "Total Price");

            orderDataGrid.Visible = true;

            // Getting info
            Dictionary<int, int> productQuantity = order.findOrderProductQuantities(order.getId());
            Product tmpProduct = new Product();

            foreach (KeyValuePair<int, int> product in productQuantity)
            {
                int productId = product.Key;
                int requestedQuantity = product.Value;
                tmpProduct.findProductById(productId);


                double priceOfThis = tmpProduct.getPrice() * requestedQuantity;
                orderDataGrid.Rows.Add(tmpProduct.getName(), requestedQuantity, tmpProduct.getPrice(), priceOfThis);

            }

        }
    }
}
