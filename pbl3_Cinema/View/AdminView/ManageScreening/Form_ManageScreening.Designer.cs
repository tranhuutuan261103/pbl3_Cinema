namespace pbl3_Cinema.View.AdminView.ManageScreen
{
    partial class Form_ManageScreening
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Screening = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbb_Auditorium = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_AllScreening = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Del = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Screening)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách suất chiếu";
            // 
            // dataGridView_Screening
            // 
            this.dataGridView_Screening.AllowUserToAddRows = false;
            this.dataGridView_Screening.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_Screening.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Screening.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Screening.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Screening.ColumnHeadersHeight = 30;
            this.dataGridView_Screening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Screening.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Screening.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Screening.Location = new System.Drawing.Point(50, 78);
            this.dataGridView_Screening.Name = "dataGridView_Screening";
            this.dataGridView_Screening.ReadOnly = true;
            this.dataGridView_Screening.RowHeadersVisible = false;
            this.dataGridView_Screening.RowHeadersWidth = 51;
            this.dataGridView_Screening.RowTemplate.Height = 24;
            this.dataGridView_Screening.Size = new System.Drawing.Size(827, 383);
            this.dataGridView_Screening.TabIndex = 1;
            this.dataGridView_Screening.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Screening.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Screening.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Screening.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Screening.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Screening.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Screening.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Screening.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Screening.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Screening.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Screening.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Screening.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Screening.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView_Screening.ThemeStyle.ReadOnly = true;
            this.dataGridView_Screening.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Screening.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Screening.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Screening.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Screening.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_Screening.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Screening.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbb_Auditorium
            // 
            this.cbb_Auditorium.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Auditorium.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Auditorium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Auditorium.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Auditorium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Auditorium.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Auditorium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Auditorium.ItemHeight = 30;
            this.cbb_Auditorium.Location = new System.Drawing.Point(273, 483);
            this.cbb_Auditorium.Name = "cbb_Auditorium";
            this.cbb_Auditorium.Size = new System.Drawing.Size(162, 36);
            this.cbb_Auditorium.TabIndex = 3;
            this.cbb_Auditorium.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(50, 483);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(176, 36);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2023, 4, 14, 15, 10, 0, 710);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // btn_AllScreening
            // 
            this.btn_AllScreening.BorderRadius = 10;
            this.btn_AllScreening.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllScreening.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllScreening.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AllScreening.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AllScreening.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AllScreening.ForeColor = System.Drawing.Color.White;
            this.btn_AllScreening.Location = new System.Drawing.Point(470, 483);
            this.btn_AllScreening.Name = "btn_AllScreening";
            this.btn_AllScreening.Size = new System.Drawing.Size(168, 36);
            this.btn_AllScreening.TabIndex = 5;
            this.btn_AllScreening.Text = "Tất cả suất chiếu";
            this.btn_AllScreening.Click += new System.EventHandler(this.btn_AllScreening_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BorderRadius = 10;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(124, 539);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(180, 45);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Thêm suất chiếu";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderRadius = 10;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(365, 539);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(180, 45);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "Chỉnh sửa suất chiếu";
            // 
            // btn_Del
            // 
            this.btn_Del.BorderRadius = 10;
            this.btn_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Del.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Location = new System.Drawing.Point(604, 539);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(180, 45);
            this.btn_Del.TabIndex = 8;
            this.btn_Del.Text = "Xóa suất chiếu";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // Form_ManageScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 610);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_AllScreening);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbb_Auditorium);
            this.Controls.Add(this.dataGridView_Screening);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ManageScreening";
            this.Text = "Form_ManageScreeningDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Screening)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Screening;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Auditorium;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2Button btn_AllScreening;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_Del;
    }
}