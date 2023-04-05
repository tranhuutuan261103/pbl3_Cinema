namespace pbl3_Cinema.View
{
    partial class Form_SignIn
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
            this.label_ChangePassword = new System.Windows.Forms.Label();
            this.btn_SignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ChangePassword
            // 
            this.label_ChangePassword.AutoSize = true;
            this.label_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.label_ChangePassword.Location = new System.Drawing.Point(59, 288);
            this.label_ChangePassword.Name = "label_ChangePassword";
            this.label_ChangePassword.Size = new System.Drawing.Size(103, 16);
            this.label_ChangePassword.TabIndex = 17;
            this.label_ChangePassword.Text = "Quên mật khẩu?";
            this.label_ChangePassword.Click += new System.EventHandler(this.label_ChangePassword_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BorderRadius = 10;
            this.btn_SignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(190, 341);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(120, 45);
            this.btn_SignUp.TabIndex = 15;
            this.btn_SignUp.Text = "Đăng ký";
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BorderRadius = 10;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(60, 341);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(120, 45);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // textBox_Account
            // 
            this.textBox_Account.BorderRadius = 10;
            this.textBox_Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Account.DefaultText = "";
            this.textBox_Account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Account.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Account.Location = new System.Drawing.Point(60, 170);
            this.textBox_Account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.PasswordChar = '\0';
            this.textBox_Account.PlaceholderText = "Email";
            this.textBox_Account.SelectedText = "";
            this.textBox_Account.Size = new System.Drawing.Size(250, 40);
            this.textBox_Account.TabIndex = 12;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BorderRadius = 10;
            this.textBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Password.DefaultText = "";
            this.textBox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Password.Location = new System.Drawing.Point(60, 231);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.PlaceholderText = "Mật khẩu";
            this.textBox_Password.SelectedText = "";
            this.textBox_Password.Size = new System.Drawing.Size(250, 40);
            this.textBox_Password.TabIndex = 13;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::pbl3_Cinema.Properties.Resources.cinema_logo;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(126, 36);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(132, 99);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 11;
            this.guna2PictureBox2.TabStop = false;
            // 
            // Form_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(358, 514);
            this.Controls.Add(this.label_ChangePassword);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.guna2PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SignIn";
            this.Text = "Form_SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label_ChangePassword;
        private Guna.UI2.WinForms.Guna2Button btn_SignUp;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Account;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Password;
    }
}