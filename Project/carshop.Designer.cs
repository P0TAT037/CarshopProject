
namespace Project
{
    partial class carshop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.transmission = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.Label();
            this.rentPrice = new System.Windows.Forms.Label();
            this.manage = new ePOSOne.btnProduct.Button_WOC();
            this.LogOut = new ePOSOne.btnProduct.Button_WOC();
            this.rent = new ePOSOne.btnProduct.Button_WOC();
            this.purchase = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(0, 11);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 24);
            this.name.TabIndex = 0;
            this.name.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transmission";
            // 
            // brand
            // 
            this.brand.BackColor = System.Drawing.Color.DimGray;
            this.brand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(229, 130);
            this.brand.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(204, 29);
            this.brand.TabIndex = 5;
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.DimGray;
            this.model.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(229, 192);
            this.model.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(204, 29);
            this.model.TabIndex = 6;
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.DimGray;
            this.year.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(229, 251);
            this.year.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(204, 29);
            this.year.TabIndex = 7;
            // 
            // transmission
            // 
            this.transmission.BackColor = System.Drawing.Color.DimGray;
            this.transmission.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmission.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.transmission.FormattingEnabled = true;
            this.transmission.Location = new System.Drawing.Point(229, 311);
            this.transmission.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.transmission.Name = "transmission";
            this.transmission.Size = new System.Drawing.Size(204, 29);
            this.transmission.TabIndex = 8;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.SpringGreen;
            this.price.Location = new System.Drawing.Point(309, 44);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(117, 36);
            this.price.TabIndex = 23;
            this.price.Text = "Total Price";
            // 
            // rentPrice
            // 
            this.rentPrice.AutoSize = true;
            this.rentPrice.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentPrice.ForeColor = System.Drawing.Color.SandyBrown;
            this.rentPrice.Location = new System.Drawing.Point(585, 44);
            this.rentPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentPrice.Name = "rentPrice";
            this.rentPrice.Size = new System.Drawing.Size(112, 36);
            this.rentPrice.TabIndex = 24;
            this.rentPrice.Text = "Rent Price";
            // 
            // manage
            // 
            this.manage.BorderColor = System.Drawing.Color.White;
            this.manage.ButtonColor = System.Drawing.Color.DimGray;
            this.manage.FlatAppearance.BorderSize = 0;
            this.manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage.Location = new System.Drawing.Point(16, 385);
            this.manage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.manage.Name = "manage";
            this.manage.OnHoverBorderColor = System.Drawing.Color.White;
            this.manage.OnHoverButtonColor = System.Drawing.Color.SteelBlue;
            this.manage.OnHoverTextColor = System.Drawing.Color.White;
            this.manage.Size = new System.Drawing.Size(135, 41);
            this.manage.TabIndex = 22;
            this.manage.Text = "Manage";
            this.manage.TextColor = System.Drawing.Color.White;
            this.manage.UseVisualStyleBackColor = true;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // LogOut
            // 
            this.LogOut.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.ButtonColor = System.Drawing.Color.DimGray;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(761, 385);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LogOut.Name = "LogOut";
            this.LogOut.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.OnHoverButtonColor = System.Drawing.Color.Maroon;
            this.LogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.LogOut.Size = new System.Drawing.Size(135, 41);
            this.LogOut.TabIndex = 21;
            this.LogOut.Text = "Log out";
            this.LogOut.TextColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // rent
            // 
            this.rent.BorderColor = System.Drawing.Color.White;
            this.rent.ButtonColor = System.Drawing.Color.DimGray;
            this.rent.FlatAppearance.BorderSize = 0;
            this.rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent.Location = new System.Drawing.Point(548, 238);
            this.rent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rent.Name = "rent";
            this.rent.OnHoverBorderColor = System.Drawing.Color.White;
            this.rent.OnHoverButtonColor = System.Drawing.Color.Peru;
            this.rent.OnHoverTextColor = System.Drawing.Color.White;
            this.rent.Size = new System.Drawing.Size(193, 50);
            this.rent.TabIndex = 20;
            this.rent.Text = "Rent";
            this.rent.TextColor = System.Drawing.Color.White;
            this.rent.UseVisualStyleBackColor = true;
            // 
            // purchase
            // 
            this.purchase.BorderColor = System.Drawing.Color.White;
            this.purchase.ButtonColor = System.Drawing.Color.DimGray;
            this.purchase.FlatAppearance.BorderSize = 0;
            this.purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchase.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase.Location = new System.Drawing.Point(548, 146);
            this.purchase.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.purchase.Name = "purchase";
            this.purchase.OnHoverBorderColor = System.Drawing.Color.White;
            this.purchase.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.purchase.OnHoverTextColor = System.Drawing.Color.White;
            this.purchase.Size = new System.Drawing.Size(193, 50);
            this.purchase.TabIndex = 19;
            this.purchase.Text = "Purchase";
            this.purchase.TextColor = System.Drawing.Color.Snow;
            this.purchase.UseVisualStyleBackColor = true;
            // 
            // carshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(909, 439);
            this.Controls.Add(this.rentPrice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.transmission);
            this.Controls.Add(this.year);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "carshop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.ComboBox transmission;
        private ePOSOne.btnProduct.Button_WOC purchase;
        private ePOSOne.btnProduct.Button_WOC rent;
        private ePOSOne.btnProduct.Button_WOC LogOut;
        private ePOSOne.btnProduct.Button_WOC manage;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label rentPrice;
    }
}