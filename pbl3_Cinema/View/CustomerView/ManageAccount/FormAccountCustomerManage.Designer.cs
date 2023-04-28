namespace pbl3_Cinema.View.CustomerView.ManageAccount
{
    partial class FormAccountCustomerManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DelAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btn_UpdateInfor = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.myUserControlInforUser = new pbl3_Cinema.MyUserControler.MyUserControlInforUser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ChangePass);
            this.panel1.Controls.Add(this.btn_DelAccount);
            this.panel1.Controls.Add(this.btn_UpdateInfor);
            this.panel1.Location = new System.Drawing.Point(250, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 70);
            this.panel1.TabIndex = 1;
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BorderColor = System.Drawing.Color.Blue;
            this.btn_ChangePass.BorderThickness = 2;
            this.btn_ChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChangePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ChangePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ChangePass.ForeColor = System.Drawing.Color.White;
            this.btn_ChangePass.Location = new System.Drawing.Point(164, 0);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(171, 70);
            this.btn_ChangePass.TabIndex = 2;
            this.btn_ChangePass.Text = "Đổi mật khẩu";
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // btn_DelAccount
            // 
            this.btn_DelAccount.BorderColor = System.Drawing.Color.Blue;
            this.btn_DelAccount.BorderThickness = 2;
            this.btn_DelAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DelAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DelAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DelAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DelAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DelAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DelAccount.ForeColor = System.Drawing.Color.White;
            this.btn_DelAccount.Location = new System.Drawing.Point(335, 0);
            this.btn_DelAccount.Name = "btn_DelAccount";
            this.btn_DelAccount.Size = new System.Drawing.Size(165, 70);
            this.btn_DelAccount.TabIndex = 1;
            this.btn_DelAccount.Text = "Xóa tài khoản";
            this.btn_DelAccount.Click += new System.EventHandler(this.btn_DelAccount_Click);
            // 
            // btn_UpdateInfor
            // 
            this.btn_UpdateInfor.BorderColor = System.Drawing.Color.Blue;
            this.btn_UpdateInfor.BorderThickness = 2;
            this.btn_UpdateInfor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateInfor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateInfor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UpdateInfor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UpdateInfor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_UpdateInfor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_UpdateInfor.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateInfor.Location = new System.Drawing.Point(0, 0);
            this.btn_UpdateInfor.Name = "btn_UpdateInfor";
            this.btn_UpdateInfor.Size = new System.Drawing.Size(164, 70);
            this.btn_UpdateInfor.TabIndex = 0;
            this.btn_UpdateInfor.Text = "Chỉnh sửa thông tin";
            this.btn_UpdateInfor.Click += new System.EventHandler(this.btn_UpdateInfor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // myUserControlInforUser
            // 
            this.myUserControlInforUser.DoB = new System.DateTime(((long)(0)));
            this.myUserControlInforUser.email = null;
            this.myUserControlInforUser.Gender = null;
            this.myUserControlInforUser.Location = new System.Drawing.Point(226, 86);
            this.myUserControlInforUser.Name = "myUserControlInforUser";
            this.myUserControlInforUser.PhoneNum = null;
            this.myUserControlInforUser.Point = 0;
            this.myUserControlInforUser.Size = new System.Drawing.Size(544, 330);
            this.myUserControlInforUser.TabIndex = 0;
            this.myUserControlInforUser.UserName = null;
            // 
            // FormAccountCustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myUserControlInforUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccountCustomerManage";
            this.Text = "AccountCustomerManage";
            this.Load += new System.EventHandler(this.FormAccountCustomerManage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyUserControler.MyUserControlInforUser myUserControlInforUser;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_ChangePass;
        private Guna.UI2.WinForms.Guna2Button btn_DelAccount;
        private Guna.UI2.WinForms.Guna2Button btn_UpdateInfor;
        private System.Windows.Forms.Label label1;
    }
}