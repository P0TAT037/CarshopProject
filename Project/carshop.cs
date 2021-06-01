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
    public partial class carshop : Form
    {
        public carshop()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Manage Manage = new Manage();
                Manage.Show();
                this.Visible = false;

            }
        }
    }
}
