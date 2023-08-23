using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageProduct : Form
    {
        private Database db = new Database();
        string EProdName, NProdName;
        string EProdDescrip, NProdDescrip;
        int EQty, EId, NQty;
        double EPrice, NPrice;

        public ManageProduct()
        {
            InitializeComponent();
            db.Connect();
        }

        private void clearForm()
        {
            NProduct_Name.Text = "";
            NDescription.Text = "";
            NQuanty.Value = 1;
            NPrc.Text = "0";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult uResponse = MessageBox.Show("Are you sure?", "POS System", MessageBoxButtons.YesNo);
            if (uResponse == System.Windows.Forms.DialogResult.Yes)
            {
                string query = "DELETE FROM products WHERE id=@val1";

                SqlCommand cmd = new SqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@val1", EId);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Product has been deleted.", "POS");
                    this.clearForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "POS");
                }
            }
        }

        private void UpdateDetailsButton_Click(object sender, EventArgs e)
        {

            // below are the new product details(N)for New Details
            NProdName = NProduct_Name.Text;
            NProdDescrip = NDescription.Text;
            NQty = int.Parse(NQuanty.Value.ToString());
            NPrice = double.Parse(NPrc.Text);

            string query = $"UPDATE products SET name=@val1, stock=@val2, price=@val3, description=@val4 WHERE id=@val5";
            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@val1", NProdName);
            cmd.Parameters.AddWithValue("@val2", NQty.ToString());
            cmd.Parameters.AddWithValue("@val3", NPrice.ToString());
            cmd.Parameters.AddWithValue("@val4", NProdDescrip);
            cmd.Parameters.AddWithValue("@val5", EId.ToString());
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                MessageBox.Show("Product has been updated.", "POS");
                AddProCancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Something went wrong.", "POS");
            }

        }

        private void AddProCancel_Click(object sender, EventArgs e)
        {
            this.clearForm();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (db.IsConnected())
            {
                string query = SearchBoxTextBox.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM products WHERE name LIKE @val1", db.Connection);
                cmd.Parameters.AddWithValue("@val1", "%" + query + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    EId = reader.GetInt32(0);
                    EProdName = reader.GetString(1);
                    EQty = reader.GetInt32(2);
                    EPrice = reader.GetDouble(3);
                    EProdDescrip = reader.GetString(4);
                }

                if (reader.HasRows)
                {
                    NProduct_Name.Text = EProdName;
                    NDescription.Text = EProdDescrip;
                    NQuanty.Value = Decimal.Parse(EQty.ToString());
                    NPrc.Text = EPrice.ToString();
                }

                reader.Close();
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

        private void goBackToPreviousForm(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
}
