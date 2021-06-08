
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
            this.components = new System.ComponentModel.Container();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Project.DataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Project.DataSetTableAdapters.AccountsTableAdapter();
            this.tableAdapterManager = new Project.DataSetTableAdapters.TableAdapterManager();
            this.carsTableAdapter = new Project.DataSetTableAdapters.CarsTableAdapter();
            this.rentBtn = new ePOSOne.btnProduct.Button_WOC();
            this.exit = new ePOSOne.btnProduct.Button_WOC();
            this.manage = new ePOSOne.btnProduct.Button_WOC();
            this.LogOut = new ePOSOne.btnProduct.Button_WOC();
            this.purchaseBtn = new ePOSOne.btnProduct.Button_WOC();
            this.confirm = new ePOSOne.btnProduct.Button_WOC();
            this.cancel = new ePOSOne.btnProduct.Button_WOC();
            this.AirBag_check = new System.Windows.Forms.CheckBox();
            this.ABS_check = new System.Windows.Forms.CheckBox();
            this.GPS_check = new System.Windows.Forms.CheckBox();
            this.SunRoof_check = new System.Windows.Forms.CheckBox();
            this.Rear_check = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(70, 18);
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
            this.label1.Location = new System.Drawing.Point(63, 175);
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
            this.label2.Location = new System.Drawing.Point(63, 234);
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
            this.label3.Location = new System.Drawing.Point(63, 113);
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
            this.label4.Location = new System.Drawing.Point(63, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transmission";
            // 
            // brand
            // 
            this.brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brand.BackColor = System.Drawing.Color.DimGray;
            this.brand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(219, 113);
            this.brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(204, 29);
            this.brand.TabIndex = 0;
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // model
            // 
            this.model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.model.BackColor = System.Drawing.Color.DimGray;
            this.model.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(219, 175);
            this.model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(204, 29);
            this.model.TabIndex = 1;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // year
            // 
            this.year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.year.BackColor = System.Drawing.Color.DimGray;
            this.year.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.year.Location = new System.Drawing.Point(219, 235);
            this.year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(204, 29);
            this.year.TabIndex = 2;
            // 
            // transmission
            // 
            this.transmission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.transmission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.transmission.BackColor = System.Drawing.Color.DimGray;
            this.transmission.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmission.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.transmission.FormattingEnabled = true;
            this.transmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.transmission.Location = new System.Drawing.Point(219, 293);
            this.transmission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transmission.Name = "transmission";
            this.transmission.Size = new System.Drawing.Size(204, 29);
            this.transmission.TabIndex = 3;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.SpringGreen;
            this.price.Location = new System.Drawing.Point(357, 53);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(117, 36);
            this.price.TabIndex = 23;
            this.price.Text = "Total Price";
            this.price.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources._138_1388270_transparent_user_png_icon;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dataSet;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = this.accountsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // rentBtn
            // 
            this.rentBtn.BorderColor = System.Drawing.Color.White;
            this.rentBtn.ButtonColor = System.Drawing.Color.DimGray;
            this.rentBtn.FlatAppearance.BorderSize = 0;
            this.rentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBtn.Location = new System.Drawing.Point(582, 175);
            this.rentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.rentBtn.OnHoverButtonColor = System.Drawing.Color.SandyBrown;
            this.rentBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.rentBtn.Size = new System.Drawing.Size(193, 50);
            this.rentBtn.TabIndex = 10;
            this.rentBtn.Text = "Rent";
            this.rentBtn.TextColor = System.Drawing.Color.Snow;
            this.rentBtn.UseVisualStyleBackColor = true;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // exit
            // 
            this.exit.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.exit.ButtonColor = System.Drawing.Color.DimGray;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(763, 390);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.exit.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.exit.OnHoverTextColor = System.Drawing.Color.White;
            this.exit.Size = new System.Drawing.Size(135, 41);
            this.exit.TabIndex = 15;
            this.exit.Text = "Exit";
            this.exit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // manage
            // 
            this.manage.BorderColor = System.Drawing.Color.White;
            this.manage.ButtonColor = System.Drawing.Color.DimGray;
            this.manage.FlatAppearance.BorderSize = 0;
            this.manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage.Location = new System.Drawing.Point(16, 385);
            this.manage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage.Name = "manage";
            this.manage.OnHoverBorderColor = System.Drawing.Color.White;
            this.manage.OnHoverButtonColor = System.Drawing.Color.SteelBlue;
            this.manage.OnHoverTextColor = System.Drawing.Color.White;
            this.manage.Size = new System.Drawing.Size(135, 41);
            this.manage.TabIndex = 13;
            this.manage.Text = "Manage";
            this.manage.TextColor = System.Drawing.Color.White;
            this.manage.UseVisualStyleBackColor = true;
            this.manage.Visible = false;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // LogOut
            // 
            this.LogOut.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.ButtonColor = System.Drawing.Color.DimGray;
            this.LogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(622, 390);
            this.LogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOut.Name = "LogOut";
            this.LogOut.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.OnHoverButtonColor = System.Drawing.Color.Maroon;
            this.LogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.LogOut.Size = new System.Drawing.Size(135, 41);
            this.LogOut.TabIndex = 14;
            this.LogOut.Text = "Log out";
            this.LogOut.TextColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.BorderColor = System.Drawing.Color.White;
            this.purchaseBtn.ButtonColor = System.Drawing.Color.DimGray;
            this.purchaseBtn.FlatAppearance.BorderSize = 0;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseBtn.Location = new System.Drawing.Point(582, 98);
            this.purchaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.purchaseBtn.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.purchaseBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.purchaseBtn.Size = new System.Drawing.Size(193, 50);
            this.purchaseBtn.TabIndex = 9;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.TextColor = System.Drawing.Color.Snow;
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchase_Click);
            // 
            // confirm
            // 
            this.confirm.BorderColor = System.Drawing.Color.White;
            this.confirm.ButtonColor = System.Drawing.Color.DimGray;
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(582, 98);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm.Name = "confirm";
            this.confirm.OnHoverBorderColor = System.Drawing.Color.White;
            this.confirm.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.confirm.OnHoverTextColor = System.Drawing.Color.White;
            this.confirm.Size = new System.Drawing.Size(193, 50);
            this.confirm.TabIndex = 11;
            this.confirm.Text = "Confirm";
            this.confirm.TextColor = System.Drawing.Color.Snow;
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancel.ButtonColor = System.Drawing.Color.DimGray;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(582, 175);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancel.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.Size = new System.Drawing.Size(193, 50);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AirBag_check
            // 
            this.AirBag_check.AutoSize = true;
            this.AirBag_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AirBag_check.Location = new System.Drawing.Point(582, 248);
            this.AirBag_check.Name = "AirBag_check";
            this.AirBag_check.Size = new System.Drawing.Size(83, 21);
            this.AirBag_check.TabIndex = 4;
            this.AirBag_check.Text = "Air Bags";
            this.AirBag_check.UseVisualStyleBackColor = true;
            // 
            // ABS_check
            // 
            this.ABS_check.AutoSize = true;
            this.ABS_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ABS_check.Location = new System.Drawing.Point(719, 248);
            this.ABS_check.Name = "ABS_check";
            this.ABS_check.Size = new System.Drawing.Size(105, 21);
            this.ABS_check.TabIndex = 5;
            this.ABS_check.Text = "ABS Brakes";
            this.ABS_check.UseVisualStyleBackColor = true;
            // 
            // GPS_check
            // 
            this.GPS_check.AutoSize = true;
            this.GPS_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPS_check.Location = new System.Drawing.Point(582, 275);
            this.GPS_check.Name = "GPS_check";
            this.GPS_check.Size = new System.Drawing.Size(109, 21);
            this.GPS_check.TabIndex = 6;
            this.GPS_check.Text = "GPS System";
            this.GPS_check.UseVisualStyleBackColor = true;
            // 
            // SunRoof_check
            // 
            this.SunRoof_check.AutoSize = true;
            this.SunRoof_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SunRoof_check.Location = new System.Drawing.Point(719, 275);
            this.SunRoof_check.Name = "SunRoof_check";
            this.SunRoof_check.Size = new System.Drawing.Size(89, 21);
            this.SunRoof_check.TabIndex = 7;
            this.SunRoof_check.Text = "Sun Roof";
            this.SunRoof_check.UseVisualStyleBackColor = true;
            // 
            // Rear_check
            // 
            this.Rear_check.AutoSize = true;
            this.Rear_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rear_check.Location = new System.Drawing.Point(622, 302);
            this.Rear_check.Name = "Rear_check";
            this.Rear_check.Size = new System.Drawing.Size(143, 21);
            this.Rear_check.TabIndex = 8;
            this.Rear_check.Text = "RearView Camera";
            this.Rear_check.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project.Properties.Resources.paeto;
            this.pictureBox2.Location = new System.Drawing.Point(736, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // carshop
            // 
            this.AcceptButton = this.confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.LogOut;
            this.ClientSize = new System.Drawing.Size(914, 442);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Rear_check);
            this.Controls.Add(this.SunRoof_check);
            this.Controls.Add(this.GPS_check);
            this.Controls.Add(this.ABS_check);
            this.Controls.Add(this.AirBag_check);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.price);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.transmission);
            this.Controls.Add(this.year);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "carshop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carshop";
            this.Load += new System.EventHandler(this.carshop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private ePOSOne.btnProduct.Button_WOC purchaseBtn;
        private ePOSOne.btnProduct.Button_WOC rent;
        private ePOSOne.btnProduct.Button_WOC LogOut;
        private ePOSOne.btnProduct.Button_WOC manage;
        private System.Windows.Forms.Label price;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC exit;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private ePOSOne.btnProduct.Button_WOC rentBtn;
        private ePOSOne.btnProduct.Button_WOC confirm;
        private ePOSOne.btnProduct.Button_WOC cancel;
        private System.Windows.Forms.CheckBox AirBag_check;
        private System.Windows.Forms.CheckBox ABS_check;
        private System.Windows.Forms.CheckBox GPS_check;
        private System.Windows.Forms.CheckBox SunRoof_check;
        private System.Windows.Forms.CheckBox Rear_check;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}