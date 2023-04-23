namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlSelectScreening
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
            this.label_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Screening = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_NullScreening = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Screening.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(17, 13);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(73, 29);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "name";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(18, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 1);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel_Screening
            // 
            this.flowLayoutPanel_Screening.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_Screening.Controls.Add(this.label_NullScreening);
            this.flowLayoutPanel_Screening.Location = new System.Drawing.Point(18, 84);
            this.flowLayoutPanel_Screening.Name = "flowLayoutPanel_Screening";
            this.flowLayoutPanel_Screening.Size = new System.Drawing.Size(735, 120);
            this.flowLayoutPanel_Screening.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(18, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 1);
            this.panel2.TabIndex = 3;
            // 
            // label_NullScreening
            // 
            this.label_NullScreening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NullScreening.Location = new System.Drawing.Point(3, 0);
            this.label_NullScreening.Name = "label_NullScreening";
            this.label_NullScreening.Size = new System.Drawing.Size(480, 69);
            this.label_NullScreening.TabIndex = 0;
            this.label_NullScreening.Text = "Hôm nay không có suất chiếu";
            this.label_NullScreening.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label_NullScreening.Visible = false;
            // 
            // MyUserControlSelectScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel_Screening);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Title);
            this.Name = "MyUserControlSelectScreening";
            this.Size = new System.Drawing.Size(772, 216);
            this.Load += new System.EventHandler(this.MyUserControlSelectScreening_Load);
            this.flowLayoutPanel_Screening.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Screening;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_NullScreening;
    }
}
