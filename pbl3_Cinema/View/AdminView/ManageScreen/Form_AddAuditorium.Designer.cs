namespace pbl3_Cinema.View.AdminView.ManageScreen
{
    partial class Form_AddAuditorium
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
            this.btn_Oke = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_NameAuditorium = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Seat_No_Row = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_Seat_No_Col = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
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
            this.btn_Oke.Location = new System.Drawing.Point(68, 265);
            this.btn_Oke.Name = "btn_Oke";
            this.btn_Oke.Size = new System.Drawing.Size(141, 49);
            this.btn_Oke.TabIndex = 0;
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
            this.btn_Exit.Location = new System.Drawing.Point(272, 265);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(141, 49);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // textBox_NameAuditorium
            // 
            this.textBox_NameAuditorium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_NameAuditorium.DefaultText = "";
            this.textBox_NameAuditorium.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_NameAuditorium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_NameAuditorium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_NameAuditorium.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_NameAuditorium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_NameAuditorium.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_NameAuditorium.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_NameAuditorium.Location = new System.Drawing.Point(213, 68);
            this.textBox_NameAuditorium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_NameAuditorium.Name = "textBox_NameAuditorium";
            this.textBox_NameAuditorium.PasswordChar = '\0';
            this.textBox_NameAuditorium.PlaceholderText = "";
            this.textBox_NameAuditorium.SelectedText = "";
            this.textBox_NameAuditorium.Size = new System.Drawing.Size(229, 48);
            this.textBox_NameAuditorium.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thêm phòng chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số ghế (hàng)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số ghế (cột)";
            // 
            // textBox_Seat_No_Row
            // 
            this.textBox_Seat_No_Row.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Seat_No_Row.DefaultText = "";
            this.textBox_Seat_No_Row.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Seat_No_Row.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Seat_No_Row.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Seat_No_Row.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Seat_No_Row.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Seat_No_Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Seat_No_Row.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Seat_No_Row.Location = new System.Drawing.Point(213, 124);
            this.textBox_Seat_No_Row.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Seat_No_Row.Name = "textBox_Seat_No_Row";
            this.textBox_Seat_No_Row.PasswordChar = '\0';
            this.textBox_Seat_No_Row.PlaceholderText = "";
            this.textBox_Seat_No_Row.SelectedText = "";
            this.textBox_Seat_No_Row.Size = new System.Drawing.Size(229, 48);
            this.textBox_Seat_No_Row.TabIndex = 7;
            // 
            // textBox_Seat_No_Col
            // 
            this.textBox_Seat_No_Col.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Seat_No_Col.DefaultText = "";
            this.textBox_Seat_No_Col.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Seat_No_Col.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Seat_No_Col.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Seat_No_Col.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Seat_No_Col.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Seat_No_Col.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Seat_No_Col.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Seat_No_Col.Location = new System.Drawing.Point(213, 180);
            this.textBox_Seat_No_Col.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Seat_No_Col.Name = "textBox_Seat_No_Col";
            this.textBox_Seat_No_Col.PasswordChar = '\0';
            this.textBox_Seat_No_Col.PlaceholderText = "";
            this.textBox_Seat_No_Col.SelectedText = "";
            this.textBox_Seat_No_Col.Size = new System.Drawing.Size(229, 48);
            this.textBox_Seat_No_Col.TabIndex = 8;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form_AddAuditorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 357);
            this.Controls.Add(this.textBox_Seat_No_Col);
            this.Controls.Add(this.textBox_Seat_No_Row);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NameAuditorium);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Oke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddAuditorium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddAuditorium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Oke;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2TextBox textBox_NameAuditorium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Seat_No_Row;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Seat_No_Col;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}