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

namespace PosSystem.Views.ViewAccount
{
    public partial class ViewAccount : Form
    {
        Database db;
        public ViewAccount()
        {
            InitializeComponent();
            db = new Database();
            db.Connect();
        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {
            string qu = "SELECT username as Username, first_name as 'First Name', last_name as 'Last Name', email as 'Email Address', role as 'Role' FROM users;";
            SqlDataAdapter dt = new SqlDataAdapter(qu, db.Connection);
            DataSet ds = new DataSet();
            dt.Fill(ds, "UsersTable");

            accountsDataGrid.DataSource = ds;
            accountsDataGrid.DataMember = "UsersTable";
        }

        private void ViewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminHome adminHomeForm = new AdminHome();
            adminHomeForm.Show();
        }
    }
}
