namespace pbl3_Cinema.View.ReservationView
{
    partial class Form_BookTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Booking = new Guna.UI2.WinForms.Guna2Button();
            this.panel_InforTicket = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Point = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Point = new System.Windows.Forms.CheckBox();
            this.panel_Button.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao dịch";
            // 
            // panel_Button
            // 
            this.panel_Button.Controls.Add(this.btn_Exit);
            this.panel_Button.Controls.Add(this.btn_Booking);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Button.Location = new System.Drawing.Point(0, 550);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(375, 50);
            this.panel_Button.TabIndex = 1;
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
            this.btn_Exit.Location = new System.Drawing.Point(12, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 40);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Booking
            // 
            this.btn_Booking.BorderRadius = 10;
            this.btn_Booking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Booking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Booking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Booking.ForeColor = System.Drawing.Color.White;
            this.btn_Booking.Location = new System.Drawing.Point(233, 7);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(130, 40);
            this.btn_Booking.TabIndex = 0;
            this.btn_Booking.Text = "Thanh toán";
            this.btn_Booking.Click += new System.EventHandler(this.btn_Booking_Click);
            // 
            // panel_InforTicket
            // 
            this.panel_InforTicket.Location = new System.Drawing.Point(12, 100);
            this.panel_InforTicket.Name = "panel_InforTicket";
            this.panel_InforTicket.Size = new System.Drawing.Size(350, 100);
            this.panel_InforTicket.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin giao dịch";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 250);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(375, 200);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Point);
            this.groupBox1.Controls.Add(this.label_Point);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chiết khấu";
            // 
            // label_Point
            // 
            this.label_Point.Location = new System.Drawing.Point(233, 21);
            this.label_Point.Name = "label_Point";
            this.label_Point.Size = new System.Drawing.Size(100, 23);
            this.label_Point.TabIndex = 2;
            this.label_Point.Text = "0";
            this.label_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm tích lũy của bạn là:";
            // 
            // checkBox_Point
            // 
            this.checkBox_Point.AutoSize = true;
            this.checkBox_Point.Location = new System.Drawing.Point(198, 46);
            this.checkBox_Point.Name = "checkBox_Point";
            this.checkBox_Point.Size = new System.Drawing.Size(137, 20);
            this.checkBox_Point.TabIndex = 3;
            this.checkBox_Point.Text = "Dùng điểm tích lũy";
            this.checkBox_Point.UseVisualStyleBackColor = true;
            this.checkBox_Point.CheckedChanged += new System.EventHandler(this.checkBox_Point_CheckedChanged);
            // 
            // Form_BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_InforTicket);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BookTicket";
            this.Text = "Form_BookTicket";
            this.panel_Button.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Button;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2Button btn_Booking;
        private Guna.UI2.WinForms.Guna2Panel panel_InforTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Point;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Point;
    }
}