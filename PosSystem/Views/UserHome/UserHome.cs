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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewProduct productsForm = new ViewProduct();
            productsForm.SetRole("USER");
            productsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOrder printBillForm = new AddOrder();
            printBillForm.SetRole("ADMIN");
            printBillForm.Show();
            this.Hide();
        }

        private void UserHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
