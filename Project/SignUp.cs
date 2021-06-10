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
            TxtPassword.UseSystemPasswordChar = true;
            TxtConfirm.UseSystemPasswordChar = true;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked) //Hides the password 
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                TxtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn SignIn = new SignIn();
            SignIn.Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == TxtConfirm.Text)
            {
                string Name = null;
                if(TxtName.Text != string.Empty)
                {
                    Name = TxtName.Text;
                    try
                    {
                        accountsTableAdapter.addUser(TxtUsername.Text, TxtPassword.Text, Name);
                        SignIn signIn = new SignIn();
                        MessageBox.Show("Success! You can now sign in.");
                        signIn.Show();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("This username is taken. Please, choose another one.");
                    }
                }
                else
                {
                    MessageBox.Show("Please, enter your name");
                }
                
            }
            else
            {
                MessageBox.Show("Passwords don't match.");
            }
        }

        
    }
}
