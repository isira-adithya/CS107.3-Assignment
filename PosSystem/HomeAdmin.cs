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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
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
            AddProduct Aproduct = new AddProduct();
            Aproduct.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProductDetail Eproduct = new EditProductDetail();
            Eproduct.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteProduct Dproduct = new DeleteProduct();
            Dproduct.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintBill invoice = new PrintBill();
            invoice.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser();
            user.Show();
            this.Hide();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
