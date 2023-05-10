namespace pbl3_Cinema.View.CustomerView
{
    partial class Form_Customer_ListSelect
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
            this.btn_1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_4 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(0, 0);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(165, 57);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Phim đang chiếu";
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2
            // 
            this.btn_2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(0, 57);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(165, 57);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Phim sắp chiếu";
            this.btn_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3
            // 
            this.btn_3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(0, 114);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(165, 57);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "Lịch sử đặt vé";
            this.btn_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4
            // 
            this.btn_4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(0, 171);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(165, 57);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "Quản lý tài khoản";
            this.btn_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form_Customer_ListSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 328);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Customer_ListSelect";
            this.Text = "Form_Customer_ListSelect";
            this.Load += new System.EventHandler(this.Form_Customer_ListSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_1;
        private Guna.UI2.WinForms.Guna2Button btn_2;
        private Guna.UI2.WinForms.Guna2Button btn_3;
        private Guna.UI2.WinForms.Guna2Button btn_4;
    }
}