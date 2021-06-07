﻿using System;
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
            this.AcceptButton = purchase;
            this.CancelButton = LogOut;
            for (int i = 0; i < carsTableAdapter.GetData().Count; i++)
            {
                if (!brand.Items.Contains(carsTableAdapter.GetData()[i][1]))
                {
                    brand.Items.Add(carsTableAdapter.GetData()[i][1]);
                }
            }
            
            this.carsTableAdapter.Fill(this.dataSet.Cars);
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

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful!");
            this.AcceptButton = purchase;
            this.CancelButton = LogOut;
            purchase.Visible = true;
            rentBtn.Visible = true;
            confirm.Visible = false;
            price.Visible = false;
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.AcceptButton = purchase;
            this.CancelButton = LogOut;
            purchase.Visible = true;
            rentBtn.Visible = true;
            confirm.Visible = false;
            cancel.Visible = false;
            price.Visible = false;
        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            for (int i = 0; i < carsTableAdapter.GetByBrand(brand.Text).Count; i++)
            {
                model.Items.Add(carsTableAdapter.GetByBrand(brand.Text)[i][2]);
            }
            
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            try
            {
                Price = (decimal)carsTableAdapter.GetPrice(id);
                Price -= ((decimal)0.18 * Price) * (2021 - decimal.Parse(year.Text));
                if (transmission.SelectedIndex == 1)
                {
                    Price -= ((decimal)0.02 * Price);
                }
                price.Text = "Total Price: " + Price.ToString("c");
                price.ForeColor = Color.SpringGreen;
                this.AcceptButton = confirm;
                this.CancelButton = cancel;
                purchase.Visible = false;
                rentBtn.Visible = false;
                confirm.Visible = true;
                cancel.Visible = true;
                price.Visible = true;
            }
            catch { }
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Rent = (decimal)carsTableAdapter.getRent(id);
                Rent -= ((decimal)0.01 * Rent) * (2021 - decimal.Parse(year.Text));
                if (transmission.SelectedIndex == 1)
                {
                    Rent -= ((decimal)0.01 * Rent);
                }
                price.Text = "Rent Price: " + Rent.ToString("c") + "/day";
                price.ForeColor = Color.SandyBrown;
                this.AcceptButton = confirm;
                this.CancelButton = cancel;
                purchase.Visible = false;
                rentBtn.Visible = false;
                confirm.Visible = true;
                cancel.Visible = true;
                price.Visible = true;
            }
            catch { }
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = (int)carsTableAdapter.getId(brand.Text, model.Text);
            Price = (decimal)carsTableAdapter.GetPrice(id);
            Rent = (decimal)carsTableAdapter.getRent(id);
        }
    }
    
}
