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
    public partial class ViewProduct : Form
    {
        private string role;
        private Database db;
        public ViewProduct()
        {
            InitializeComponent();
            db = new Database();
            db.Connect();
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

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            string qu = "SELECT name as Name,stock as 'Current Stock',price as Price  FROM products;";
            SqlDataAdapter dt = new SqlDataAdapter(qu, db.Connection);
            DataSet ds = new DataSet();
            dt.Fill(ds, "ProductsTable");

            productsDataGrid.DataSource = ds;
            productsDataGrid.DataMember = "ProductsTable";

        }
    }
}
