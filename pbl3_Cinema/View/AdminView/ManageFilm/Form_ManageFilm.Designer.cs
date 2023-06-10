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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_ListFilm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_AddFilm = new Guna.UI2.WinForms.Guna2Button();
            this.btn_UpdateFilm = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Del = new Guna.UI2.WinForms.Guna2Button();
            this.text_Search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListFilm
            // 
            this.dataGridView_ListFilm.AllowUserToAddRows = false;
            this.dataGridView_ListFilm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_ListFilm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ListFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListFilm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ListFilm.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ListFilm.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_ListFilm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_ListFilm.Location = new System.Drawing.Point(29, 84);
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
            this.btn_AddFilm.Location = new System.Drawing.Point(29, 521);
            this.btn_AddFilm.Name = "btn_AddFilm";
            this.btn_AddFilm.Size = new System.Drawing.Size(150, 45);
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
            this.btn_UpdateFilm.Location = new System.Drawing.Point(185, 521);
            this.btn_UpdateFilm.Name = "btn_UpdateFilm";
            this.btn_UpdateFilm.Size = new System.Drawing.Size(150, 45);
            this.btn_UpdateFilm.TabIndex = 1;
            this.btn_UpdateFilm.Text = "Chỉnh sửa";
            this.btn_UpdateFilm.Click += new System.EventHandler(this.btn_UpdateFilm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(733, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 521);
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
            this.btn_AddCategory.Location = new System.Drawing.Point(868, 521);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(94, 45);
            this.btn_AddCategory.TabIndex = 4;
            this.btn_AddCategory.Text = "Thêm";
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // cbb_Category
            // 
            this.cbb_Category.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Category.ItemHeight = 30;
            this.cbb_Category.Location = new System.Drawing.Point(774, 21);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(188, 36);
            this.cbb_Category.TabIndex = 5;
            this.cbb_Category.SelectedIndexChanged += new System.EventHandler(this.cbb_Category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách phim";
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
            this.btn_Del.Location = new System.Drawing.Point(341, 521);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(150, 45);
            this.btn_Del.TabIndex = 7;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // text_Search
            // 
            this.text_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_Search.DefaultText = "";
            this.text_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_Search.Location = new System.Drawing.Point(513, 533);
            this.text_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_Search.Name = "text_Search";
            this.text_Search.PasswordChar = '\0';
            this.text_Search.PlaceholderText = "Tìm kiếm";
            this.text_Search.SelectedText = "";
            this.text_Search.Size = new System.Drawing.Size(184, 33);
            this.text_Search.TabIndex = 8;
            this.text_Search.TextChanged += new System.EventHandler(this.text_Search_TextChanged);
            // 
            // Form_ManageFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_Category);
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
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Category;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_Del;
        private Guna.UI2.WinForms.Guna2TextBox text_Search;
    }
}