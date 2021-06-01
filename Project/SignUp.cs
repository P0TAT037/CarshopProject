using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
            confirm.UseSystemPasswordChar = true;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            methods.showPasswordCheck(password, showPassword);
            methods.showPasswordCheck(confirm, showPassword);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn SignIn = new SignIn();
            SignIn.Show();
        }

        private void signUnBtn_Click(object sender, EventArgs e)
        {
            if (password.Text == confirm.Text)
            {
                carshop carshop = new carshop();
                carshop.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Passwords don't match.");
            }
        }
    }
}
