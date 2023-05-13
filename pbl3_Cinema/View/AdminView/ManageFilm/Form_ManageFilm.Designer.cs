namespace pbl3_Cinema.View.AdminView
{
    partial class Form_ManageFilm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_ListFilm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_AddFilm = new Guna.UI2.WinForms.Guna2Button();
            this.btn_UpdateFilm = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddCategory = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListFilm
            // 
            this.dataGridView_ListFilm.AllowUserToAddRows = false;
            this.dataGridView_ListFilm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_ListFilm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ListFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListFilm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ListFilm.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ListFilm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ListFilm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_ListFilm.Location = new System.Drawing.Point(29, 41);
            this.dataGridView_ListFilm.Name = "dataGridView_ListFilm";
            this.dataGridView_ListFilm.ReadOnly = true;
            this.dataGridView_ListFilm.RowHeadersVisible = false;
            this.dataGridView_ListFilm.RowHeadersWidth = 51;
            this.dataGridView_ListFilm.RowTemplate.Height = 24;
            this.dataGridView_ListFilm.Size = new System.Drawing.Size(933, 403);
            this.dataGridView_ListFilm.TabIndex = 0;
            this.dataGridView_ListFilm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_ListFilm.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_ListFilm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_ListFilm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_ListFilm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_ListFilm.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_ListFilm.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_ListFilm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_ListFilm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_ListFilm.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_ListFilm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_ListFilm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_ListFilm.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView_ListFilm.ThemeStyle.ReadOnly = true;
            this.dataGridView_ListFilm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_ListFilm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_ListFilm.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_ListFilm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_ListFilm.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_ListFilm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_ListFilm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_AddFilm
            // 
            this.btn_AddFilm.BorderRadius = 10;
            this.btn_AddFilm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddFilm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddFilm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddFilm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddFilm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddFilm.ForeColor = System.Drawing.Color.White;
            this.btn_AddFilm.Location = new System.Drawing.Point(65, 495);
            this.btn_AddFilm.Name = "btn_AddFilm";
            this.btn_AddFilm.Size = new System.Drawing.Size(180, 45);
            this.btn_AddFilm.TabIndex = 1;
            this.btn_AddFilm.Text = "Thêm phim";
            this.btn_AddFilm.Click += new System.EventHandler(this.btn_AddFilm_Click);
            // 
            // btn_UpdateFilm
            // 
            this.btn_UpdateFilm.BorderRadius = 10;
            this.btn_UpdateFilm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateFilm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateFilm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UpdateFilm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UpdateFilm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_UpdateFilm.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateFilm.Location = new System.Drawing.Point(328, 495);
            this.btn_UpdateFilm.Name = "btn_UpdateFilm";
            this.btn_UpdateFilm.Size = new System.Drawing.Size(180, 45);
            this.btn_UpdateFilm.TabIndex = 1;
            this.btn_UpdateFilm.Text = "Chỉnh sửa";
            this.btn_UpdateFilm.Click += new System.EventHandler(this.btn_UpdateFilm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(686, 501);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thêm thể loại:";
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.BorderRadius = 10;
            this.btn_AddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddCategory.ForeColor = System.Drawing.Color.White;
            this.btn_AddCategory.Location = new System.Drawing.Point(841, 495);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(94, 45);
            this.btn_AddCategory.TabIndex = 4;
            this.btn_AddCategory.Text = "Thêm";
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // Form_ManageFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_UpdateFilm);
            this.Controls.Add(this.btn_AddFilm);
            this.Controls.Add(this.dataGridView_ListFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ManageFilm";
            this.Text = "Form_AddFilm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_ListFilm;
        private Guna.UI2.WinForms.Guna2Button btn_AddFilm;
        private Guna.UI2.WinForms.Guna2Button btn_UpdateFilm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_AddCategory;
    }
}