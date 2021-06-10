
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brandCombo = new System.Windows.Forms.ComboBox();
            this.modelCombo = new System.Windows.Forms.ComboBox();
            this.yearCombo = new System.Windows.Forms.ComboBox();
            this.transmissionCombo = new System.Windows.Forms.ComboBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Project.DataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Project.DataSetTableAdapters.AccountsTableAdapter();
            this.tableAdapterManager = new Project.DataSetTableAdapters.TableAdapterManager();
            this.carsTableAdapter = new Project.DataSetTableAdapters.CarsTableAdapter();
            this.rentBtn = new ePOSOne.btnProduct.Button_WOC();
            this.ExitBtn = new ePOSOne.btnProduct.Button_WOC();
            this.manageBtn = new ePOSOne.btnProduct.Button_WOC();
            this.LogOutBtn = new ePOSOne.btnProduct.Button_WOC();
            this.purchaseBtn = new ePOSOne.btnProduct.Button_WOC();
            this.confirmBtn = new ePOSOne.btnProduct.Button_WOC();
            this.cancelBtn = new ePOSOne.btnProduct.Button_WOC();
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
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(70, 18);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(64, 24);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "NAME";
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
            // brandCombo
            // 
            this.brandCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandCombo.BackColor = System.Drawing.Color.DimGray;
            this.brandCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.brandCombo.FormattingEnabled = true;
            this.brandCombo.Location = new System.Drawing.Point(219, 113);
            this.brandCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandCombo.Name = "brandCombo";
            this.brandCombo.Size = new System.Drawing.Size(204, 29);
            this.brandCombo.TabIndex = 0;
            this.brandCombo.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // modelCombo
            // 
            this.modelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelCombo.BackColor = System.Drawing.Color.DimGray;
            this.modelCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.modelCombo.FormattingEnabled = true;
            this.modelCombo.Location = new System.Drawing.Point(219, 175);
            this.modelCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelCombo.Name = "modelCombo";
            this.modelCombo.Size = new System.Drawing.Size(204, 29);
            this.modelCombo.TabIndex = 1;
            this.modelCombo.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // yearCombo
            // 
            this.yearCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.yearCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearCombo.BackColor = System.Drawing.Color.DimGray;
            this.yearCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yearCombo.FormattingEnabled = true;
            this.yearCombo.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.yearCombo.Location = new System.Drawing.Point(219, 235);
            this.yearCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearCombo.Name = "yearCombo";
            this.yearCombo.Size = new System.Drawing.Size(204, 29);
            this.yearCombo.TabIndex = 2;
            // 
            // transmissionCombo
            // 
            this.transmissionCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.transmissionCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.transmissionCombo.BackColor = System.Drawing.Color.DimGray;
            this.transmissionCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.transmissionCombo.FormattingEnabled = true;
            this.transmissionCombo.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.transmissionCombo.Location = new System.Drawing.Point(219, 293);
            this.transmissionCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transmissionCombo.Name = "transmissionCombo";
            this.transmissionCombo.Size = new System.Drawing.Size(204, 29);
            this.transmissionCombo.TabIndex = 3;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.SpringGreen;
            this.priceLbl.Location = new System.Drawing.Point(357, 53);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(117, 36);
            this.priceLbl.TabIndex = 23;
            this.priceLbl.Text = "Total Price";
            this.priceLbl.Visible = false;
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
            // ExitBtn
            // 
            this.ExitBtn.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.ButtonColor = System.Drawing.Color.DimGray;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(763, 390);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ExitBtn.Size = new System.Drawing.Size(135, 41);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.exit_Click);
            // 
            // manageBtn
            // 
            this.manageBtn.BorderColor = System.Drawing.Color.White;
            this.manageBtn.ButtonColor = System.Drawing.Color.DimGray;
            this.manageBtn.FlatAppearance.BorderSize = 0;
            this.manageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBtn.Location = new System.Drawing.Point(16, 385);
            this.manageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.manageBtn.OnHoverButtonColor = System.Drawing.Color.SteelBlue;
            this.manageBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.manageBtn.Size = new System.Drawing.Size(135, 41);
            this.manageBtn.TabIndex = 13;
            this.manageBtn.Text = "Manage";
            this.manageBtn.TextColor = System.Drawing.Color.White;
            this.manageBtn.UseVisualStyleBackColor = true;
            this.manageBtn.Visible = false;
            this.manageBtn.Click += new System.EventHandler(this.manage_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutBtn.ButtonColor = System.Drawing.Color.DimGray;
            this.LogOutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.Location = new System.Drawing.Point(622, 390);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutBtn.OnHoverButtonColor = System.Drawing.Color.Maroon;
            this.LogOutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.LogOutBtn.Size = new System.Drawing.Size(135, 41);
            this.LogOutBtn.TabIndex = 14;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.TextColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOut_Click);
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
            // confirmBtn
            // 
            this.confirmBtn.BorderColor = System.Drawing.Color.White;
            this.confirmBtn.ButtonColor = System.Drawing.Color.DimGray;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(582, 98);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.confirmBtn.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.confirmBtn.Size = new System.Drawing.Size(193, 50);
            this.confirmBtn.TabIndex = 11;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.TextColor = System.Drawing.Color.Snow;
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn.ButtonColor = System.Drawing.Color.DimGray;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(582, 175);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.cancelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelBtn.Size = new System.Drawing.Size(193, 50);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextColor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancel_Click);
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
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.LogOutBtn;
            this.ClientSize = new System.Drawing.Size(914, 442);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Rear_check);
            this.Controls.Add(this.SunRoof_check);
            this.Controls.Add(this.GPS_check);
            this.Controls.Add(this.ABS_check);
            this.Controls.Add(this.AirBag_check);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.manageBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.transmissionCombo);
            this.Controls.Add(this.yearCombo);
            this.Controls.Add(this.modelCombo);
            this.Controls.Add(this.brandCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelBtn);
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

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox brandCombo;
        private System.Windows.Forms.ComboBox modelCombo;
        private System.Windows.Forms.ComboBox yearCombo;
        private System.Windows.Forms.ComboBox transmissionCombo;
        private ePOSOne.btnProduct.Button_WOC purchaseBtn;
        private ePOSOne.btnProduct.Button_WOC rent;
        private ePOSOne.btnProduct.Button_WOC LogOutBtn;
        private ePOSOne.btnProduct.Button_WOC manageBtn;
        private System.Windows.Forms.Label priceLbl;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC ExitBtn;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private ePOSOne.btnProduct.Button_WOC rentBtn;
        private ePOSOne.btnProduct.Button_WOC confirmBtn;
        private ePOSOne.btnProduct.Button_WOC cancelBtn;
        private System.Windows.Forms.CheckBox AirBag_check;
        private System.Windows.Forms.CheckBox ABS_check;
        private System.Windows.Forms.CheckBox GPS_check;
        private System.Windows.Forms.CheckBox SunRoof_check;
        private System.Windows.Forms.CheckBox Rear_check;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}