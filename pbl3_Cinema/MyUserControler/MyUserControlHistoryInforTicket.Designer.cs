namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlHistoryInforTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_Poster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.btn_Detail = new Guna.UI2.WinForms.Guna2Button();
            this.label_Auditorium = new System.Windows.Forms.Label();
            this.label_ShowDayTime = new System.Windows.Forms.Label();
            this.label_bookingDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Poster
            // 
            this.pictureBox_Poster.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Poster.ImageRotate = 0F;
            this.pictureBox_Poster.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Poster.Name = "pictureBox_Poster";
            this.pictureBox_Poster.Size = new System.Drawing.Size(150, 100);
            this.pictureBox_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Poster.TabIndex = 0;
            this.pictureBox_Poster.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(163, 4);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(60, 32);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "title";
            // 
            // btn_Detail
            // 
            this.btn_Detail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Detail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Detail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Detail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Detail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Detail.ForeColor = System.Drawing.Color.White;
            this.btn_Detail.Location = new System.Drawing.Point(600, 0);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(150, 100);
            this.btn_Detail.TabIndex = 2;
            this.btn_Detail.Text = "Chi tiết";
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // label_Auditorium
            // 
            this.label_Auditorium.AutoSize = true;
            this.label_Auditorium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Auditorium.Location = new System.Drawing.Point(166, 40);
            this.label_Auditorium.Name = "label_Auditorium";
            this.label_Auditorium.Size = new System.Drawing.Size(87, 20);
            this.label_Auditorium.TabIndex = 3;
            this.label_Auditorium.Text = "auditorium";
            // 
            // label_ShowDayTime
            // 
            this.label_ShowDayTime.AutoSize = true;
            this.label_ShowDayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowDayTime.Location = new System.Drawing.Point(348, 40);
            this.label_ShowDayTime.Name = "label_ShowDayTime";
            this.label_ShowDayTime.Size = new System.Drawing.Size(41, 20);
            this.label_ShowDayTime.TabIndex = 4;
            this.label_ShowDayTime.Text = "time";
            // 
            // label_bookingDay
            // 
            this.label_bookingDay.AutoSize = true;
            this.label_bookingDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookingDay.Location = new System.Drawing.Point(348, 71);
            this.label_bookingDay.Name = "label_bookingDay";
            this.label_bookingDay.Size = new System.Drawing.Size(96, 20);
            this.label_bookingDay.TabIndex = 5;
            this.label_bookingDay.Text = "bookingDay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày đặt vé:";
            // 
            // MyUserControlHistoryInforTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_bookingDay);
            this.Controls.Add(this.label_ShowDayTime);
            this.Controls.Add(this.label_Auditorium);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_Poster);
            this.Name = "MyUserControlHistoryInforTicket";
            this.Size = new System.Drawing.Size(750, 100);
            this.Load += new System.EventHandler(this.MyUserControlHistoryInforTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_Poster;
        private System.Windows.Forms.Label label_Title;
        private Guna.UI2.WinForms.Guna2Button btn_Detail;
        private System.Windows.Forms.Label label_Auditorium;
        private System.Windows.Forms.Label label_ShowDayTime;
        private System.Windows.Forms.Label label_bookingDay;
        private System.Windows.Forms.Label label1;
    }
}
