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
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            methods.showPasswordCheck(password, showPassword);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn SignIn = new SignIn();
            SignIn.Show();
        }
    }
}
