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

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (password.Text == confirm.Text)
            {
                string Name = null;
                if(name.Text != string.Empty)
                {
                    Name = name.Text;
                    try
                    {
                        accountsTableAdapter.addUser(username.Text, password.Text, Name);
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

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dataSet.Accounts);

        }
    }
}
