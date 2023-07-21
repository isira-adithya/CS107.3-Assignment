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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = textBox1.Text;
            password = textBox2.Text;

            if (username == "Admin" && password == "admin123")
            {
                HomeAdmin objAhome = new HomeAdmin();
                objAhome.Show();
                this.Hide();
            }
            else if((username=="Isuru" && password == "Isuru123") || (username=="Isira" && password == "Isira123"))
            {
               HomeUser objUhome = new HomeUser();
                objUhome.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
