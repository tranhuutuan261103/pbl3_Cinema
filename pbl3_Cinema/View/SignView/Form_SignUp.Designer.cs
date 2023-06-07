namespace pbl3_Cinema.View
{
    partial class Form_SignUp
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
            this.textBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.textText_PhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_PasswordConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker_DoB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Accept_SignUp = new Guna.UI2.WinForms.Guna2Button();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_OTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderRadius = 10;
            this.textBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Name.DefaultText = "";
            this.textBox_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Name.Location = new System.Drawing.Point(60, 76);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.PasswordChar = '\0';
            this.textBox_Name.PlaceholderText = "Họ tên";
            this.textBox_Name.SelectedText = "";
            this.textBox_Name.Size = new System.Drawing.Size(250, 36);
            this.textBox_Name.TabIndex = 1;
            // 
            // textText_PhoneNumber
            // 
            this.textText_PhoneNumber.BorderRadius = 10;
            this.textText_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textText_PhoneNumber.DefaultText = "";
            this.textText_PhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textText_PhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textText_PhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textText_PhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textText_PhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textText_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textText_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textText_PhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textText_PhoneNumber.Location = new System.Drawing.Point(60, 129);
            this.textText_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textText_PhoneNumber.Name = "textText_PhoneNumber";
            this.textText_PhoneNumber.PasswordChar = '\0';
            this.textText_PhoneNumber.PlaceholderText = "Số điện thoại";
            this.textText_PhoneNumber.SelectedText = "";
            this.textText_PhoneNumber.Size = new System.Drawing.Size(123, 36);
            this.textText_PhoneNumber.TabIndex = 2;
            // 
            // cbb_Gender
            // 
            this.cbb_Gender.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Gender.BorderRadius = 10;
            this.cbb_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Gender.ItemHeight = 30;
            this.cbb_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbb_Gender.Location = new System.Drawing.Point(198, 130);
            this.cbb_Gender.Name = "cbb_Gender";
            this.cbb_Gender.Size = new System.Drawing.Size(112, 36);
            this.cbb_Gender.TabIndex = 3;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BorderRadius = 10;
            this.textBox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Email.DefaultText = "";
            this.textBox_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Email.Location = new System.Drawing.Point(60, 181);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.PasswordChar = '\0';
            this.textBox_Email.PlaceholderText = "Email";
            this.textBox_Email.SelectedText = "";
            this.textBox_Email.Size = new System.Drawing.Size(250, 36);
            this.textBox_Email.TabIndex = 4;
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
            this.textBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Password.Location = new System.Drawing.Point(60, 235);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.PlaceholderText = "Mật khẩu";
            this.textBox_Password.SelectedText = "";
            this.textBox_Password.Size = new System.Drawing.Size(250, 36);
            this.textBox_Password.TabIndex = 5;
            // 
            // textBox_PasswordConfirm
            // 
            this.textBox_PasswordConfirm.BorderRadius = 10;
            this.textBox_PasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PasswordConfirm.DefaultText = "";
            this.textBox_PasswordConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_PasswordConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_PasswordConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PasswordConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PasswordConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_PasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox_PasswordConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PasswordConfirm.Location = new System.Drawing.Point(60, 288);
            this.textBox_PasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_PasswordConfirm.Name = "textBox_PasswordConfirm";
            this.textBox_PasswordConfirm.PasswordChar = '*';
            this.textBox_PasswordConfirm.PlaceholderText = "Xác nhận mật khẩu";
            this.textBox_PasswordConfirm.SelectedText = "";
            this.textBox_PasswordConfirm.Size = new System.Drawing.Size(250, 36);
            this.textBox_PasswordConfirm.TabIndex = 6;
            // 
            // dateTimePicker_DoB
            // 
            this.dateTimePicker_DoB.BorderRadius = 10;
            this.dateTimePicker_DoB.Checked = true;
            this.dateTimePicker_DoB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker_DoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DoB.Location = new System.Drawing.Point(152, 333);
            this.dateTimePicker_DoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_DoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_DoB.Name = "dateTimePicker_DoB";
            this.dateTimePicker_DoB.Size = new System.Drawing.Size(158, 36);
            this.dateTimePicker_DoB.TabIndex = 7;
            this.dateTimePicker_DoB.Value = new System.DateTime(2023, 4, 1, 16, 18, 1, 547);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng ký";
            // 
            // btn_Accept_SignUp
            // 
            this.btn_Accept_SignUp.BorderRadius = 10;
            this.btn_Accept_SignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Accept_SignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Accept_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Accept_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Accept_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Accept_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_Accept_SignUp.Location = new System.Drawing.Point(99, 428);
            this.btn_Accept_SignUp.Name = "btn_Accept_SignUp";
            this.btn_Accept_SignUp.Size = new System.Drawing.Size(180, 45);
            this.btn_Accept_SignUp.TabIndex = 9;
            this.btn_Accept_SignUp.Text = "Xác nhận";
            this.btn_Accept_SignUp.Click += new System.EventHandler(this.btn_Accept_SignUp_Click);
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(164, 484);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(42, 16);
            this.label_Exit.TabIndex = 10;
            this.label_Exit.Text = "Thoát";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSalmon;
            this.label2.Location = new System.Drawing.Point(57, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày sinh";
            // 
            // textBox_OTP
            // 
            this.textBox_OTP.BorderRadius = 10;
            this.textBox_OTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_OTP.DefaultText = "";
            this.textBox_OTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_OTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_OTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_OTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_OTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_OTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_OTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_OTP.Location = new System.Drawing.Point(60, 380);
            this.textBox_OTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_OTP.Name = "textBox_OTP";
            this.textBox_OTP.PasswordChar = '\0';
            this.textBox_OTP.PlaceholderText = "";
            this.textBox_OTP.SelectedText = "";
            this.textBox_OTP.Size = new System.Drawing.Size(117, 36);
            this.textBox_OTP.TabIndex = 12;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(183, 380);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(124, 36);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Gửi OTP";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(358, 514);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.textBox_OTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.btn_Accept_SignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_DoB);
            this.Controls.Add(this.textBox_PasswordConfirm);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.cbb_Gender);
            this.Controls.Add(this.textText_PhoneNumber);
            this.Controls.Add(this.textBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SignUp";
            this.Text = "Form_SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textBox_Name;
        private Guna.UI2.WinForms.Guna2TextBox textText_PhoneNumber;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Gender;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Email;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Password;
        private Guna.UI2.WinForms.Guna2TextBox textBox_PasswordConfirm;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_DoB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Accept_SignUp;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBox_OTP;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}