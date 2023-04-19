namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlSelectDay
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
            this.label_Day = new System.Windows.Forms.Label();
            this.panel_Color = new System.Windows.Forms.Panel();
            this.label_TextDay = new System.Windows.Forms.Label();
            this.panel_Color.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Day
            // 
            this.label_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Day.Location = new System.Drawing.Point(3, 3);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(90, 29);
            this.label_Day.TabIndex = 0;
            this.label_Day.Text = "0";
            this.label_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Day.Click += new System.EventHandler(this.button_Click);
            this.label_Day.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.label_Day.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // panel_Color
            // 
            this.panel_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Color.Controls.Add(this.label_Day);
            this.panel_Color.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Color.Location = new System.Drawing.Point(0, 0);
            this.panel_Color.Name = "panel_Color";
            this.panel_Color.Size = new System.Drawing.Size(98, 40);
            this.panel_Color.TabIndex = 1;
            this.panel_Color.Click += new System.EventHandler(this.button_Click);
            this.panel_Color.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.panel_Color.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // label_TextDay
            // 
            this.label_TextDay.Location = new System.Drawing.Point(3, 43);
            this.label_TextDay.Name = "label_TextDay";
            this.label_TextDay.Size = new System.Drawing.Size(91, 22);
            this.label_TextDay.TabIndex = 2;
            this.label_TextDay.Text = "Hôm nay";
            this.label_TextDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_TextDay.Click += new System.EventHandler(this.button_Click);
            this.label_TextDay.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.label_TextDay.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // MyUserControlSelectDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_TextDay);
            this.Controls.Add(this.panel_Color);
            this.Name = "MyUserControlSelectDay";
            this.Size = new System.Drawing.Size(98, 73);
            this.Click += new System.EventHandler(this.button_Click);
            this.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.panel_Color.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Day;
        private System.Windows.Forms.Panel panel_Color;
        private System.Windows.Forms.Label label_TextDay;
    }
}
