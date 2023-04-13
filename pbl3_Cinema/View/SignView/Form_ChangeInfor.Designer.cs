namespace pbl3_Cinema.View.SignView
{
    partial class Form_ChangeInfor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Oke = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_NameUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_PhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker_DoB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbb_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh:";
            // 
            // btn_Oke
            // 
            this.btn_Oke.BorderRadius = 10;
            this.btn_Oke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Oke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Oke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Oke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Oke.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Oke.ForeColor = System.Drawing.Color.White;
            this.btn_Oke.Location = new System.Drawing.Point(76, 327);
            this.btn_Oke.Name = "btn_Oke";
            this.btn_Oke.Size = new System.Drawing.Size(120, 40);
            this.btn_Oke.TabIndex = 6;
            this.btn_Oke.Text = "Xác nhận";
            this.btn_Oke.Click += new System.EventHandler(this.btn_Oke_Click);
            // 
            // textBox_NameUser
            // 
            this.textBox_NameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_NameUser.DefaultText = "";
            this.textBox_NameUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_NameUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_NameUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_NameUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_NameUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_NameUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_NameUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_NameUser.Location = new System.Drawing.Point(196, 120);
            this.textBox_NameUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_NameUser.Name = "textBox_NameUser";
            this.textBox_NameUser.PasswordChar = '\0';
            this.textBox_NameUser.PlaceholderText = "";
            this.textBox_NameUser.SelectedText = "";
            this.textBox_NameUser.Size = new System.Drawing.Size(260, 40);
            this.textBox_NameUser.TabIndex = 8;
            // 
            // textBox_PhoneNum
            // 
            this.textBox_PhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PhoneNum.DefaultText = "";
            this.textBox_PhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_PhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_PhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PhoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PhoneNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_PhoneNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PhoneNum.Location = new System.Drawing.Point(196, 224);
            this.textBox_PhoneNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_PhoneNum.Name = "textBox_PhoneNum";
            this.textBox_PhoneNum.PasswordChar = '\0';
            this.textBox_PhoneNum.PlaceholderText = "";
            this.textBox_PhoneNum.SelectedText = "";
            this.textBox_PhoneNum.Size = new System.Drawing.Size(260, 40);
            this.textBox_PhoneNum.TabIndex = 8;
            // 
            // dateTimePicker_DoB
            // 
            this.dateTimePicker_DoB.Checked = true;
            this.dateTimePicker_DoB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker_DoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DoB.Location = new System.Drawing.Point(196, 271);
            this.dateTimePicker_DoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_DoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_DoB.Name = "dateTimePicker_DoB";
            this.dateTimePicker_DoB.Size = new System.Drawing.Size(260, 36);
            this.dateTimePicker_DoB.TabIndex = 9;
            this.dateTimePicker_DoB.Value = new System.DateTime(2023, 4, 9, 14, 25, 24, 805);
            // 
            // cbb_Gender
            // 
            this.cbb_Gender.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Gender.ItemHeight = 34;
            this.cbb_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbb_Gender.Location = new System.Drawing.Point(196, 171);
            this.cbb_Gender.Name = "cbb_Gender";
            this.cbb_Gender.Size = new System.Drawing.Size(260, 40);
            this.cbb_Gender.TabIndex = 10;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderRadius = 10;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(277, 327);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 40);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_ChangeInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 415);
            this.Controls.Add(this.cbb_Gender);
            this.Controls.Add(this.dateTimePicker_DoB);
            this.Controls.Add(this.textBox_PhoneNum);
            this.Controls.Add(this.textBox_NameUser);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Oke);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChangeInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ChangeInfor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_Oke;
        private Guna.UI2.WinForms.Guna2TextBox textBox_NameUser;
        private Guna.UI2.WinForms.Guna2TextBox textBox_PhoneNum;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_DoB;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Gender;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
    }
}