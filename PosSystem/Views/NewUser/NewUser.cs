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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void goBackToPreviousForm(object sender, FormClosedEventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
}
