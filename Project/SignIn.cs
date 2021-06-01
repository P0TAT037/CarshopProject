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
    public partial class SignIn : Form
    {
        SignUp SignUp = new SignUp();
        public SignIn()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            methods.showPasswordCheck(password, showPassword);
            
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            
            SignUp.Show();
            this.Close();
        }

        private void signUp_MouseHover(object sender, EventArgs e)
        {
            signUp.ForeColor = Color.DeepSkyBlue;
        }

        private void signUp_MouseLeave(object sender, EventArgs e)
        {
            signUp.ForeColor = Color.DodgerBlue;
        }
        
        private void signInBtn_Click(object sender, EventArgs e)
        {
            if(true)
            {
                carshop carshop = new carshop();
                carshop.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        
        private void button_WOC1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        
    }

    class methods
    {
        public static void showPasswordCheck(TextBox t, CheckBox c)
        {
            if (c.Checked)
            {
                t.UseSystemPasswordChar = false;
            }
            else
            {
                t.UseSystemPasswordChar = true;
            }
        }
    }
}
