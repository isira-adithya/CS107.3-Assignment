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
    public partial class DeleteProduct : Form
    {
        private Database db = new Database();
        int EId;
        string EProdName = "Program Name: ";
        string EProdDescrip = "Program Description: ";

        public DeleteProduct()
        {
            InitializeComponent();
            db.Connect();
        }

        private void goBackToPreviousForm(object sender, FormClosedEventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (db.IsConnected())
            {
                string query = searchQueryBox.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM products WHERE name LIKE @val1", db.Connection);
                cmd.Parameters.AddWithValue("@val1", "%" + query + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EId = reader.GetInt32(0);
                    EProdName = reader.GetString(1);
                    EProdDescrip = reader.GetString(4);
                }

                if (reader.HasRows)
                {
                    programNameLabel.Text = "Program Name: " + EProdName;
                    programDescriptionLabel.Text = "Program Description: \n" + EProdDescrip;
                    deleteBtn.Enabled = true;
                } else
                {
                    deleteBtn.Enabled = false;
                    programNameLabel.Text = "Program Name: ";
                    programDescriptionLabel.Text = "Program Description: ";
                }

                reader.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (EId >= 0)
            {
                DialogResult uResponse = MessageBox.Show("Are you sure?", "POS System", MessageBoxButtons.YesNo);
                if (uResponse == System.Windows.Forms.DialogResult.Yes)
                {
                    string query = $"DELETE FROM products WHERE id=@val1";
                    
                    SqlCommand cmd = new SqlCommand(query, db.Connection);
                    cmd.Parameters.AddWithValue("@val1", EId);
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Product has been deleted.", "POS");
                        deleteBtn.Enabled = false;
                        programNameLabel.Text = "Program Name: ";
                        programDescriptionLabel.Text = "Program Description: ";
                        searchQueryBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.", "POS");
                    }
                }
            } else
            {
                deleteBtn.Enabled = false;
            }
        }
    }
}
