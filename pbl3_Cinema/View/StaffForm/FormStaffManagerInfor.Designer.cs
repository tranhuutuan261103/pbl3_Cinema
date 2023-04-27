namespace pbl3_Cinema.View.StaffForm
{
    partial class FormStaffManagerInfor
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
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.UserControlStaff = new pbl3_Cinema.MyUserControler.MyUserControlInforStaff();
            this.SuspendLayout();
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(129, 431);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(180, 45);
            this.btnDoiMatKhau.TabIndex = 1;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // UserControlStaff
            // 
            this.UserControlStaff.DoB = new System.DateTime(((long)(0)));
            this.UserControlStaff.email = null;
            this.UserControlStaff.Gender = null;
            this.UserControlStaff.Location = new System.Drawing.Point(129, 12);
            this.UserControlStaff.Luong = null;
            this.UserControlStaff.Name = "UserControlStaff";
            this.UserControlStaff.PhoneNum = null;
            this.UserControlStaff.Position = null;
            this.UserControlStaff.Size = new System.Drawing.Size(518, 376);
            this.UserControlStaff.TabIndex = 2;
            this.UserControlStaff.UserName = null;
            // 
            // FormStaffManagerInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.UserControlStaff);
            this.Controls.Add(this.btnDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStaffManagerInfor";
            this.Text = "FormStaffManagerInfor";
            this.Load += new System.EventHandler(this.FormStaffManagerInfor_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDoiMatKhau;
        private MyUserControler.MyUserControlInforStaff UserControlStaff;
    }
}