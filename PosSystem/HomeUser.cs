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
    public partial class HomeUser : Form
    {
        public HomeUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewProduct product = new ViewProduct();
            product.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintBill invoice = new PrintBill();
            invoice.Show();
            this.Hide();
        }
    }
}