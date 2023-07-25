using MySql.Data.MySqlClient;
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
    public partial class EditProduct : Form
    {
        private Database db = new Database();
        string EProdName, NProdName;
        string EProdDescrip, NProdDescrip;
        int EQty, NQty;
        double EPrice, NPrice;
        public EditProduct()
        {
            InitializeComponent();
            db.Connect();
        }

        private void product_add_Click(object sender, EventArgs e)
        {

            // below are the new product details(N)for New Details
            NProdName = NProduct_Name.Text;
            NProdDescrip = NDescription.Text;
            NQty = int.Parse(NQuanty.Value.ToString());
            NPrice = double.Parse(NPrc.Text);


        }

        private void AddProCancel_Click(object sender, EventArgs e)
        { 
             NProduct_Name.Text="";
             NDescription.Text="";
             NQuanty.Value=1;
             NPrc.Text="0";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (db.IsConnected())
            {
                string query = SearchBoxTextBox.Text;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE name LIKE @val1", db.Connection);
                cmd.Parameters.AddWithValue("@val1", "%" + query + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    EProdName = reader.GetString(1);
                    EQty = int.Parse(reader.GetString(2));
                    EPrice = double.Parse(reader.GetString(3));
                    EProdDescrip = reader.GetString(4);
                }

                reader.Close();

                ExistingProductNameLabel.Text = EProdName;
                ExistingProductDescriptionLabel.Text = EProdDescrip;
                ExistingProductPriceLabel.Text = EPrice.ToString();
                ExistingProductQuantityLabel.Text = EQty.ToString();
            }
        }

        private void checkPrice(object sender, EventArgs e)
        {
            try
            {
                double.Parse(NPrc.Text);
                return;
            } catch
            {
                MessageBox.Show("Invalid Input!", "POS");
                NPrc.Text = "0";
                return;
            }
        }
    }
}
