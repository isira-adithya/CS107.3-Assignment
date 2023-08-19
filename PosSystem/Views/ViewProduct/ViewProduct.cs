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
    public partial class ViewProduct : Form
    {
        private string role;
        public ViewProduct()
        {
            InitializeComponent();
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
            // TODO: This line of code loads data into the '_pos_dbDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._pos_dbDataSet.products);

        }
    }
}
