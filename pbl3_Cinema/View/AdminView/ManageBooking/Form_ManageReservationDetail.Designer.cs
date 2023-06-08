namespace pbl3_Cinema.View.AdminView.ManageBooking
{
    partial class Form_ManageReservationDetail
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
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label_SeatReserved = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label_Revenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BorderRadius = 10;
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(820, 530);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(168, 40);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Xác nhận";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lịch sử giao dịch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(5, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.Controls.Add(this.label_SeatReserved);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(823, 90);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(165, 180);
            this.guna2CustomGradientPanel1.TabIndex = 6;
            // 
            // label_SeatReserved
            // 
            this.label_SeatReserved.BackColor = System.Drawing.Color.Transparent;
            this.label_SeatReserved.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_SeatReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SeatReserved.Location = new System.Drawing.Point(0, 55);
            this.label_SeatReserved.Name = "label_SeatReserved";
            this.label_SeatReserved.Size = new System.Drawing.Size(165, 125);
            this.label_SeatReserved.TabIndex = 1;
            this.label_SeatReserved.Text = "0";
            this.label_SeatReserved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đã đặt";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel2.Controls.Add(this.label_Revenue);
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(823, 311);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(165, 180);
            this.guna2CustomGradientPanel2.TabIndex = 7;
            // 
            // label_Revenue
            // 
            this.label_Revenue.BackColor = System.Drawing.Color.Transparent;
            this.label_Revenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Revenue.Location = new System.Drawing.Point(0, 55);
            this.label_Revenue.Name = "label_Revenue";
            this.label_Revenue.Size = new System.Drawing.Size(165, 125);
            this.label_Revenue.TabIndex = 2;
            this.label_Revenue.Text = "0";
            this.label_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh thu";
            // 
            // Form_ManageReservationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ManageReservationDetail";
            this.Text = "Form_ManageReservationDetail";
            this.Load += new System.EventHandler(this.Form_ManageReservationDetail_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label_SeatReserved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Revenue;
        private System.Windows.Forms.Label label3;
    }
}