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
            name.Text = accountsTableAdapter.getName(SignIn.userName);
            this.carsTableAdapter.Fill(this.dataSet.Cars);
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

        private void carSearchBtn_Click(object sender, EventArgs e)
        {
            if (carSearch.Text == string.Empty)
            {
                carsTableAdapter.Fill(this.dataSet.Cars);
            }
            else
            {
                carsTableAdapter.SearchCars(this.dataSet.Cars, carSearch.Text);
            }
        }

        private void userSearchBtn_Click(object sender, EventArgs e)
        {
            if (userSearch.Text == string.Empty)
            {
                accountsTableAdapter.Fill(this.dataSet.Accounts);
            }
            else
            {
                accountsTableAdapter.SearchUsers(this.dataSet.Accounts, userSearch.Text);
            }
        }

        private void carSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = carSearchBtn;
        }

        private void userSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = userSearchBtn;
        }

        private void InventorynavigatorSaveBtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
        }
    }
}
class CarProperties
{
    private string name;
    private decimal price;


    public CarProperties()
    {
        name = null;
        price = 0;
    }
    public CarProperties(string n, decimal p)
    {
        name = n;
        price = p;
    }

    public decimal Price
    {
        get { return price; }
    }
}
