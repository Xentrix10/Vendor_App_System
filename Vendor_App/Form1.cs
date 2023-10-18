using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = login_username.Text;
            password = login_password.Text;

            if(username == "admin" && password == "admin123")
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("FAIL");
            }
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
