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
            this.groupBox_Discount = new System.Windows.Forms.GroupBox();
            this.checkBox_Point = new System.Windows.Forms.CheckBox();
            this.label_Point = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_Button.SuspendLayout();
            this.groupBox_Discount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 26);
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
            // 
            // panel_InforTicket
            // 
            this.panel_InforTicket.Location = new System.Drawing.Point(12, 70);
            this.panel_InforTicket.Name = "panel_InforTicket";
            this.panel_InforTicket.Size = new System.Drawing.Size(350, 100);
            this.panel_InforTicket.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin giao dịch";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 220);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(375, 230);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // groupBox_Discount
            // 
            this.groupBox_Discount.Controls.Add(this.checkBox_Point);
            this.groupBox_Discount.Controls.Add(this.label_Point);
            this.groupBox_Discount.Controls.Add(this.label3);
            this.groupBox_Discount.Location = new System.Drawing.Point(12, 460);
            this.groupBox_Discount.Name = "groupBox_Discount";
            this.groupBox_Discount.Size = new System.Drawing.Size(350, 75);
            this.groupBox_Discount.TabIndex = 5;
            this.groupBox_Discount.TabStop = false;
            this.groupBox_Discount.Text = "Chiết khấu";
            this.groupBox_Discount.Visible = false;
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
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form_BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 600);
            this.Controls.Add(this.groupBox_Discount);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_InforTicket);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BookTicket";
            this.Text = "Form_BookTicket";
            this.panel_Button.ResumeLayout(false);
            this.groupBox_Discount.ResumeLayout(false);
            this.groupBox_Discount.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox_Discount;
        private System.Windows.Forms.Label label_Point;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Point;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}