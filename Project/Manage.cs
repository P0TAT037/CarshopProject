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

        private void Manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.dataSet.Cars);
            // TODO: This line of code loads data into the 'dataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dataSet.Accounts);
            name.Text = accountsTableAdapter.getName(SignIn.userName);
            // TODO: This line of code loads data into the 'dataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.dataSet.Cars);
            // TODO: This line of code loads data into the 'dataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dataSet.Accounts);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            carshop carshop = new carshop();
            carshop.Show();
        }

        private void accountsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

    }
}
