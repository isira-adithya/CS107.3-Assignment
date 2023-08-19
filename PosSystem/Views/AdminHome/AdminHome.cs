﻿using System;
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
    public partial class AdminHome : Form
    {
        public bool isLoggedInAsAdmin = false;
        public AdminHome()
        {
            InitializeComponent();
            isLoggedInAsAdmin = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewProduct productsForm = new ViewProduct();
            productsForm.SetRole("ADMIN");
            productsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProduct editProductForm = new EditProduct();
            editProductForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProductForm = new DeleteProduct();
            deleteProductForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintBill printBillForm = new PrintBill();
            printBillForm.SetRole("ADMIN");
            printBillForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewUser newUserForm = new NewUser();
            newUserForm.Show();
            this.Hide();
        }
    }
}