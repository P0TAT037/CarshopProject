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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            this.Close();
            carshop carshop = new carshop();
            carshop.Show();
        }
    }
}
