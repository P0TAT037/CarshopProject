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
            
                Manage Manage = new Manage();
                Manage.Show();
                this.Close();

            
        }

        private void carshop_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.dataSet.Cars);

            // TODO: This line of code loads data into the 'dataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dataSet.Accounts);
            name.Text = accountsTableAdapter.getName(SignIn.userName);
            bool admin = (bool)accountsTableAdapter.checkAdmin(SignIn.userName);
            if(admin)
            {
                manage.Visible = true;
            }
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            for (int i = 0; i < carsTableAdapter.GetModel(brand.Text).Count; i++)
            {
                model.Items.Add(carsTableAdapter.GetModel(brand.Text)[i][2]);
            }
            price.Text = "Total Price: " + Price.ToString("c");
            rentPrice.Text = "Rent Price: " + Rent.ToString("c") + "/month";
        }

        int id;
        decimal Price, Rent;

        private void transmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price = (decimal)carsTableAdapter.GetPrice(id) - (1000 * (2020 - int.Parse(year.Text)));
            if (transmission.SelectedIndex == 1)
            {
                Price -= 1000;
            }

            Rent = (decimal)carsTableAdapter.getRent(id) - (200 * (2020 - int.Parse(year.Text)));
            if (transmission.SelectedIndex == 1)
            {
                Rent -= 500;
            }
            price.Text = "Total Price: " + Price.ToString("c");
            rentPrice.Text = "Rent Price: " + Rent.ToString("c") + "/month";

        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price -= (1000 * (2020 - int.Parse(year.Text)));
            Rent -= (200 * (2020 - int.Parse(year.Text)));
            price.Text = "Total Price: " + Price.ToString("c");
            rentPrice.Text = "Rent Price: " + Rent.ToString("c") + "/month";
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = (int)carsTableAdapter.getId(brand.Text, model.Text);
            Price = (decimal)carsTableAdapter.GetPrice(id);
            Rent = (decimal)carsTableAdapter.getRent(id);
            price.Text = "Total Price: " + Price.ToString("c");
            rentPrice.Text = "Rent Price: " + Rent.ToString("c") + "/month";

        }
    }
}
