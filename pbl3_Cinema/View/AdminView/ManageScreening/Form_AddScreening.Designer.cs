namespace pbl3_Cinema.View.AdminView.ManageScreening
{
    partial class Form_AddScreening
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
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Oke = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_Auditorium = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_Movie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePicker_ShowDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBox_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_TimeEnd = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cbb_Hour = new System.Windows.Forms.ComboBox();
            this.cbb_Minute = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(607, 59);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Thêm suất chiếu";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng chiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày chiếu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giờ chiếu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thời gian kết thúc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giá/ 1 ghế:";
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
            this.btn_Oke.Location = new System.Drawing.Point(81, 384);
            this.btn_Oke.Name = "btn_Oke";
            this.btn_Oke.Size = new System.Drawing.Size(180, 45);
            this.btn_Oke.TabIndex = 2;
            this.btn_Oke.Text = "Xác nhận";
            this.btn_Oke.Click += new System.EventHandler(this.btn_Oke_Click);
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
            this.btn_Exit.Location = new System.Drawing.Point(342, 384);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(180, 45);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cbb_Auditorium
            // 
            this.cbb_Auditorium.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Auditorium.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Auditorium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Auditorium.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Auditorium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Auditorium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Auditorium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Auditorium.ItemHeight = 30;
            this.cbb_Auditorium.Location = new System.Drawing.Point(230, 80);
            this.cbb_Auditorium.Name = "cbb_Auditorium";
            this.cbb_Auditorium.Size = new System.Drawing.Size(180, 36);
            this.cbb_Auditorium.TabIndex = 4;
            // 
            // cbb_Movie
            // 
            this.cbb_Movie.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Movie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Movie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Movie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Movie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Movie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Movie.ItemHeight = 30;
            this.cbb_Movie.Location = new System.Drawing.Point(230, 126);
            this.cbb_Movie.Name = "cbb_Movie";
            this.cbb_Movie.Size = new System.Drawing.Size(314, 36);
            this.cbb_Movie.TabIndex = 5;
            this.cbb_Movie.SelectedIndexChanged += new System.EventHandler(this.cbb_Hour_SelectedIndexChanged);
            // 
            // dateTimePicker_ShowDay
            // 
            this.dateTimePicker_ShowDay.Checked = true;
            this.dateTimePicker_ShowDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker_ShowDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ShowDay.Location = new System.Drawing.Point(231, 175);
            this.dateTimePicker_ShowDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_ShowDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ShowDay.Name = "dateTimePicker_ShowDay";
            this.dateTimePicker_ShowDay.Size = new System.Drawing.Size(179, 36);
            this.dateTimePicker_ShowDay.TabIndex = 8;
            this.dateTimePicker_ShowDay.Value = new System.DateTime(2023, 4, 14, 19, 46, 34, 538);
            this.dateTimePicker_ShowDay.ValueChanged += new System.EventHandler(this.cbb_Hour_SelectedIndexChanged);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Price.DefaultText = "";
            this.textBox_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Price.Location = new System.Drawing.Point(231, 315);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.PasswordChar = '\0';
            this.textBox_Price.PlaceholderText = "";
            this.textBox_Price.SelectedText = "";
            this.textBox_Price.Size = new System.Drawing.Size(131, 35);
            this.textBox_Price.TabIndex = 9;
            // 
            // label_TimeEnd
            // 
            this.label_TimeEnd.AutoSize = true;
            this.label_TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeEnd.Location = new System.Drawing.Point(246, 273);
            this.label_TimeEnd.Name = "label_TimeEnd";
            this.label_TimeEnd.Size = new System.Drawing.Size(25, 22);
            this.label_TimeEnd.TabIndex = 10;
            this.label_TimeEnd.Text = "...";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // cbb_Hour
            // 
            this.cbb_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Hour.FormattingEnabled = true;
            this.cbb_Hour.Location = new System.Drawing.Point(231, 229);
            this.cbb_Hour.Name = "cbb_Hour";
            this.cbb_Hour.Size = new System.Drawing.Size(80, 30);
            this.cbb_Hour.TabIndex = 11;
            this.cbb_Hour.SelectedIndexChanged += new System.EventHandler(this.cbb_Hour_SelectedIndexChanged);
            // 
            // cbb_Minute
            // 
            this.cbb_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Minute.FormattingEnabled = true;
            this.cbb_Minute.Location = new System.Drawing.Point(330, 229);
            this.cbb_Minute.Name = "cbb_Minute";
            this.cbb_Minute.Size = new System.Drawing.Size(80, 30);
            this.cbb_Minute.TabIndex = 12;
            this.cbb_Minute.SelectedIndexChanged += new System.EventHandler(this.cbb_Hour_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
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
            // Form_AddScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 469);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbb_Minute);
            this.Controls.Add(this.cbb_Hour);
            this.Controls.Add(this.label_TimeEnd);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.dateTimePicker_ShowDay);
            this.Controls.Add(this.cbb_Movie);
            this.Controls.Add(this.cbb_Auditorium);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Oke);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddScreening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddScreening";
            this.Load += new System.EventHandler(this.Form_AddScreening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btn_Oke;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Auditorium;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Movie;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_ShowDay;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Price;
        private System.Windows.Forms.Label label_TimeEnd;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_Minute;
        private System.Windows.Forms.ComboBox cbb_Hour;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}