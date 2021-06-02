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
        public static string userName;
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
            userName = username.Text;
            if(accountsTableAdapter.getPassword(userName) == password.Text)
            {
                carshop carshop = new carshop();
                carshop.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dataSet.Accounts);

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
