
namespace Project
{
    partial class SignIn
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Label();
            this.exit = new ePOSOne.btnProduct.Button_WOC();
            this.signInBtn = new ePOSOne.btnProduct.Button_WOC();
            this.dataSet = new Project.DataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Project.DataSetTableAdapters.AccountsTableAdapter();
            this.tableAdapterManager = new Project.DataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(48, 222);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(327, 32);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(48, 293);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(327, 32);
            this.password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(42, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(49, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassword.Location = new System.Drawing.Point(234, 331);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(126, 21);
            this.showPassword.TabIndex = 6;
            this.showPassword.Text = "show password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(69, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Don\'t have an acoount?";
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.signUp.Location = new System.Drawing.Point(272, 369);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(64, 21);
            this.signUp.TabIndex = 8;
            this.signUp.Text = "Sign up";
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            this.signUp.MouseLeave += new System.EventHandler(this.signUp_MouseLeave);
            this.signUp.MouseHover += new System.EventHandler(this.signUp_MouseHover);
            // 
            // exit
            // 
            this.exit.BorderColor = System.Drawing.Color.Transparent;
            this.exit.ButtonColor = System.Drawing.Color.Red;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(142, 491);
            this.exit.Name = "exit";
            this.exit.OnHoverBorderColor = System.Drawing.Color.Red;
            this.exit.OnHoverButtonColor = System.Drawing.Color.MintCream;
            this.exit.OnHoverTextColor = System.Drawing.Color.Red;
            this.exit.Size = new System.Drawing.Size(127, 50);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.TextColor = System.Drawing.Color.White;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.BorderColor = System.Drawing.Color.Transparent;
            this.signInBtn.ButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Location = new System.Drawing.Point(104, 413);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.signInBtn.OnHoverButtonColor = System.Drawing.Color.MintCream;
            this.signInBtn.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.signInBtn.Size = new System.Drawing.Size(213, 72);
            this.signInBtn.TabIndex = 9;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.TextColor = System.Drawing.Color.White;
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.paeto;
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AcceptButton = this.signInBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(432, 551);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label signUp;
        private ePOSOne.btnProduct.Button_WOC signInBtn;
        private ePOSOne.btnProduct.Button_WOC exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox username;
    }
}

