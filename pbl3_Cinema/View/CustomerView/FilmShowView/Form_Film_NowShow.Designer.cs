namespace pbl3_Cinema.View.CustomerView.FilmNowShowView
{
    partial class Form_Film_NowShow
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
            this.panel = new System.Windows.Forms.Panel();
            this.btn_Reservation = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_Reservation);
            this.panel.Controls.Add(this.cbb_Category);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1000, 94);
            this.panel.TabIndex = 0;
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Reservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Reservation.ForeColor = System.Drawing.Color.White;
            this.btn_Reservation.Location = new System.Drawing.Point(36, 27);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Size = new System.Drawing.Size(172, 36);
            this.btn_Reservation.TabIndex = 1;
            this.btn_Reservation.Text = "Đặt vé ngay";
            this.btn_Reservation.Click += new System.EventHandler(this.btn_Reservation_Click);
            // 
            // cbb_Category
            // 
            this.cbb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Category.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Category.ItemHeight = 30;
            this.cbb_Category.Location = new System.Drawing.Point(760, 30);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(200, 36);
            this.cbb_Category.TabIndex = 0;
            this.cbb_Category.SelectedIndexChanged += new System.EventHandler(this.cbb_Category_SelectedIndexChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1000, 506);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // Form_Film_NowShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Film_NowShow";
            this.Text = "Form_Film_NowShow";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Category;
        private Guna.UI2.WinForms.Guna2Button btn_Reservation;
    }
}