
namespace Project
{
    partial class SignUp
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
            this.cancel = new ePOSOne.btnProduct.Button_WOC();
            this.signUnBtn = new ePOSOne.btnProduct.Button_WOC();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.BorderColor = System.Drawing.Color.Transparent;
            this.cancel.ButtonColor = System.Drawing.Color.Red;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(141, 512);
            this.cancel.Name = "cancel";
            this.cancel.OnHoverBorderColor = System.Drawing.Color.Red;
            this.cancel.OnHoverButtonColor = System.Drawing.Color.MintCream;
            this.cancel.OnHoverTextColor = System.Drawing.Color.Red;
            this.cancel.Size = new System.Drawing.Size(117, 41);
            this.cancel.TabIndex = 19;
            this.cancel.Text = "Cancel";
            this.cancel.TextColor = System.Drawing.Color.White;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // signUnBtn
            // 
            this.signUnBtn.BorderColor = System.Drawing.Color.Transparent;
            this.signUnBtn.ButtonColor = System.Drawing.Color.LimeGreen;
            this.signUnBtn.FlatAppearance.BorderSize = 0;
            this.signUnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUnBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUnBtn.Location = new System.Drawing.Point(101, 444);
            this.signUnBtn.Name = "signUnBtn";
            this.signUnBtn.OnHoverBorderColor = System.Drawing.Color.LimeGreen;
            this.signUnBtn.OnHoverButtonColor = System.Drawing.Color.MintCream;
            this.signUnBtn.OnHoverTextColor = System.Drawing.Color.LimeGreen;
            this.signUnBtn.Size = new System.Drawing.Size(193, 62);
            this.signUnBtn.TabIndex = 18;
            this.signUnBtn.Text = "Sign up";
            this.signUnBtn.TextColor = System.Drawing.Color.White;
            this.signUnBtn.UseVisualStyleBackColor = true;
            this.signUnBtn.Click += new System.EventHandler(this.signUnBtn_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassword.Location = new System.Drawing.Point(231, 409);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(113, 18);
            this.showPassword.TabIndex = 15;
            this.showPassword.Text = "show password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(34, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(34, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(39, 314);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(327, 26);
            this.password.TabIndex = 12;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(38, 250);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(327, 26);
            this.username.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(38, 187);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(327, 26);
            this.name.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.paeto;
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(34, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Confirm Password";
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(39, 377);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(327, 26);
            this.confirm.TabIndex = 23;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(430, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.signUnBtn);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC cancel;
        private ePOSOne.btnProduct.Button_WOC signUnBtn;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirm;
    }
}