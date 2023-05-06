namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlComment
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
            this.btn_Comment = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.ratingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Comment
            // 
            this.btn_Comment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Comment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Comment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Comment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Comment.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Comment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Comment.ForeColor = System.Drawing.Color.White;
            this.btn_Comment.Location = new System.Drawing.Point(700, 0);
            this.btn_Comment.Name = "btn_Comment";
            this.btn_Comment.Size = new System.Drawing.Size(100, 100);
            this.btn_Comment.TabIndex = 1;
            this.btn_Comment.Text = "Bình luận";
            this.btn_Comment.Click += new System.EventHandler(this.btn_Comment_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ratingStar);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 100);
            this.panel1.TabIndex = 3;
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 41);
            this.label.TabIndex = 3;
            this.label.Text = "10";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(146, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(554, 100);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // ratingStar
            // 
            this.ratingStar.Location = new System.Drawing.Point(3, 50);
            this.ratingStar.Name = "ratingStar";
            this.ratingStar.Size = new System.Drawing.Size(143, 32);
            this.ratingStar.TabIndex = 5;
            this.ratingStar.Value = 5F;
            this.ratingStar.ValueChanged += new System.EventHandler(this.ratingStar_ValueChanged);
            // 
            // MyUserControlComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Comment);
            this.Name = "MyUserControlComment";
            this.Size = new System.Drawing.Size(800, 100);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Comment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox richTextBox;
        private Guna.UI2.WinForms.Guna2RatingStar ratingStar;
    }
}
