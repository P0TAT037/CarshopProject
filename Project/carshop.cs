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
        int id;
        decimal Price, Rent;
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
            this.AcceptButton = purchaseBtn;
            this.CancelButton = LogOutBtn;
            for (int i = 0; i < carsTableAdapter.GetData().Count; i++)
            {
                if (!brandCombo.Items.Contains(carsTableAdapter.GetData()[i][1]))
                {
                    brandCombo.Items.Add(carsTableAdapter.GetData()[i][1]);
                }
            }
            
            

            nameLbl.Text = accountsTableAdapter.getName(SignIn.userName);
            bool admin = (bool)accountsTableAdapter.checkAdmin(SignIn.userName);
            if(admin) //Checks if the user is an admin or not
            {
                manageBtn.Visible = true; //Show the button manage to Admin
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

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations! Your car has been booked.");

            this.AcceptButton = purchaseBtn;
            this.CancelButton = LogOutBtn;
            purchaseBtn.Visible = true;
            rentBtn.Visible = true;
            confirmBtn.Visible = false;
            priceLbl.Visible = false;
            carsTableAdapter.UpdateStock(id);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.AcceptButton = purchaseBtn;
            this.CancelButton = LogOutBtn;
            purchaseBtn.Visible = true;
            rentBtn.Visible = true;
            confirmBtn.Visible = false;
            cancelBtn.Visible = false;
            priceLbl.Visible = false;
        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e) 
        {
            modelCombo.Items.Clear();
            //Fills models combobox items based on selected brand
            for (int i = 0; i < carsTableAdapter.GetByBrand(brandCombo.Text).Count; i++)

            {
                modelCombo.Items.Add(carsTableAdapter.GetByBrand(brandCombo.Text)[i][2]);
            }
            
        }

        private void purchase_Click(object sender, EventArgs e) //Shows total price and changes the quantity
        {
            CarProperties AirBag = new CarProperties("Air Bag", 800);
            CarProperties Rear = new CarProperties("Rear View Camera", 200);
            CarProperties Gps = new CarProperties("GPS", 500);
            CarProperties ABS = new CarProperties("ABS", 400);
            CarProperties Sun = new CarProperties("Sun Roof", 300);
            
            try //Changes the price in some of cases
            {
                Price = (decimal)carsTableAdapter.GetPrice(id);
                Price -= ((decimal)0.01 * Price) * (2021 - decimal.Parse(yearCombo.Text));
                if (transmissionCombo.SelectedIndex == 1)
                {
                    Price -= ((decimal)0.02 * Price);
                }
                if (GPS_check.Checked)
                {
                    Price += Gps.Price;
                }
                if (Rear_check.Checked)
                {
                    Price += Rear.Price;
                }
                if (ABS_check.Checked)
                {
                    Price += ABS.Price;
                }
                if (SunRoof_check.Checked)
                {
                    Price += Sun.Price;
                }
                if (AirBag_check.Checked)
                {
                    Price += AirBag.Price;
                }
                priceLbl.Text = "Total Price: " + Price.ToString("c");
                priceLbl.ForeColor = Color.SpringGreen;
                this.AcceptButton = confirmBtn;
                this.CancelButton = cancelBtn;
                purchaseBtn.Visible = false;
                rentBtn.Visible = false;
                confirmBtn.Visible = true;
                cancelBtn.Visible = true;
                priceLbl.Visible = true;
            }
            catch { }
        }

        private void rentBtn_Click(object sender, EventArgs e) //Shows rent price and changes the quantity
        {
            try
            {
                Rent = (decimal)carsTableAdapter.getRent(id);
                Rent -= ((decimal)0.01 * Rent) * (2021 - decimal.Parse(yearCombo.Text));
                if (transmissionCombo.SelectedIndex == 1)
                {
                    Rent -= ((decimal)0.01 * Rent);
                }
                priceLbl.Text = "Rent Price: " + Rent.ToString("c") + "/day";
                priceLbl.ForeColor = Color.SandyBrown;
                this.AcceptButton = confirmBtn;
                this.CancelButton = cancelBtn;
                purchaseBtn.Visible = false;
                rentBtn.Visible = false;
                confirmBtn.Visible = true;
                cancelBtn.Visible = true;
                priceLbl.Visible = true;
            }
            catch { }
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = (int)carsTableAdapter.getId(brandCombo.Text, modelCombo.Text);
            Price = (decimal)carsTableAdapter.GetPrice(id);
            Rent = (decimal)carsTableAdapter.getRent(id);
        }
    }
    
}
