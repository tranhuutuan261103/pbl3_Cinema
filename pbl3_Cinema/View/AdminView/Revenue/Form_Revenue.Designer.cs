namespace pbl3_Cinema.View.AdminView.Statistic
{
    partial class Form_Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_Revenue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_StartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePicker_EndDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbb_Movie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel_Infor = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label_Revenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label_SeatReserved = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Revenue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Infor.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chart.Legends.Add(legend6);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Giá";
            series6.YValuesPerPoint = 2;
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(668, 324);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // dataGridView_Revenue
            // 
            this.dataGridView_Revenue.AllowUserToAddRows = false;
            this.dataGridView_Revenue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataGridView_Revenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Revenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView_Revenue.ColumnHeadersHeight = 20;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Revenue.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView_Revenue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Revenue.Location = new System.Drawing.Point(12, 342);
            this.dataGridView_Revenue.Name = "dataGridView_Revenue";
            this.dataGridView_Revenue.ReadOnly = true;
            this.dataGridView_Revenue.RowHeadersVisible = false;
            this.dataGridView_Revenue.RowHeadersWidth = 51;
            this.dataGridView_Revenue.RowTemplate.Height = 24;
            this.dataGridView_Revenue.Size = new System.Drawing.Size(976, 246);
            this.dataGridView_Revenue.TabIndex = 1;
            this.dataGridView_Revenue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Revenue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Revenue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Revenue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Revenue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Revenue.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Revenue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Revenue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Revenue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Revenue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Revenue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Revenue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Revenue.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridView_Revenue.ThemeStyle.ReadOnly = true;
            this.dataGridView_Revenue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Revenue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Revenue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Revenue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Revenue.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_Revenue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Revenue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 324);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker_StartDay
            // 
            this.dateTimePicker_StartDay.Checked = true;
            this.dateTimePicker_StartDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker_StartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_StartDay.Location = new System.Drawing.Point(686, 12);
            this.dateTimePicker_StartDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_StartDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_StartDay.Name = "dateTimePicker_StartDay";
            this.dateTimePicker_StartDay.Size = new System.Drawing.Size(145, 36);
            this.dateTimePicker_StartDay.TabIndex = 3;
            this.dateTimePicker_StartDay.Value = new System.DateTime(2023, 6, 7, 9, 51, 55, 329);
            this.dateTimePicker_StartDay.ValueChanged += new System.EventHandler(this.cbb_Movie_SelectedIndexChanged);
            // 
            // dateTimePicker_EndDay
            // 
            this.dateTimePicker_EndDay.Checked = true;
            this.dateTimePicker_EndDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker_EndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_EndDay.Location = new System.Drawing.Point(843, 12);
            this.dateTimePicker_EndDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_EndDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_EndDay.Name = "dateTimePicker_EndDay";
            this.dateTimePicker_EndDay.Size = new System.Drawing.Size(145, 36);
            this.dateTimePicker_EndDay.TabIndex = 4;
            this.dateTimePicker_EndDay.Value = new System.DateTime(2023, 6, 7, 9, 50, 46, 130);
            this.dateTimePicker_EndDay.ValueChanged += new System.EventHandler(this.cbb_Movie_SelectedIndexChanged);
            // 
            // cbb_Movie
            // 
            this.cbb_Movie.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Movie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Movie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Movie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Movie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Movie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Movie.ItemHeight = 30;
            this.cbb_Movie.Location = new System.Drawing.Point(686, 69);
            this.cbb_Movie.Name = "cbb_Movie";
            this.cbb_Movie.Size = new System.Drawing.Size(302, 36);
            this.cbb_Movie.TabIndex = 5;
            this.cbb_Movie.SelectedIndexChanged += new System.EventHandler(this.cbb_Movie_SelectedIndexChanged);
            // 
            // panel_Infor
            // 
            this.panel_Infor.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel_Infor.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel_Infor.Location = new System.Drawing.Point(686, 125);
            this.panel_Infor.Name = "panel_Infor";
            this.panel_Infor.Size = new System.Drawing.Size(302, 191);
            this.panel_Infor.TabIndex = 6;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.label_Revenue);
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 109);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(302, 82);
            this.guna2CustomGradientPanel2.TabIndex = 8;
            // 
            // label_Revenue
            // 
            this.label_Revenue.BackColor = System.Drawing.Color.Transparent;
            this.label_Revenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Revenue.Location = new System.Drawing.Point(0, 35);
            this.label_Revenue.Name = "label_Revenue";
            this.label_Revenue.Size = new System.Drawing.Size(302, 47);
            this.label_Revenue.TabIndex = 2;
            this.label_Revenue.Text = "0";
            this.label_Revenue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh thu";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label_SeatReserved);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(302, 85);
            this.guna2CustomGradientPanel1.TabIndex = 9;
            // 
            // label_SeatReserved
            // 
            this.label_SeatReserved.BackColor = System.Drawing.Color.Transparent;
            this.label_SeatReserved.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_SeatReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SeatReserved.Location = new System.Drawing.Point(0, 39);
            this.label_SeatReserved.Name = "label_SeatReserved";
            this.label_SeatReserved.Size = new System.Drawing.Size(302, 46);
            this.label_SeatReserved.TabIndex = 1;
            this.label_SeatReserved.Text = "0";
            this.label_SeatReserved.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số ghế đã đặt";
            // 
            // Form_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel_Infor);
            this.Controls.Add(this.cbb_Movie);
            this.Controls.Add(this.dateTimePicker_EndDay);
            this.Controls.Add(this.dateTimePicker_StartDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Revenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Revenue";
            this.Text = "Form_Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Revenue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_Infor.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Revenue;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_StartDay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_EndDay;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Movie;
        private System.Windows.Forms.Panel panel_Infor;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label_Revenue;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label_SeatReserved;
        private System.Windows.Forms.Label label2;
    }
}