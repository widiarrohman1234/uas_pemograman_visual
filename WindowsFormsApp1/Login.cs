using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username =   textBox_username.Text;
            string password = textBox_password.Text;
            if(username == "root" && password == "12341234")
            {
                Home homeForm = new Home(); 
                this.Hide();
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah, silahkan coba lagi.");
            }
            
        }
    }
}
