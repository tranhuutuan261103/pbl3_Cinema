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
            this.flowLayoutPanel_Screening.Location = new System.Drawing.Point(18, 84);
            this.flowLayoutPanel_Screening.Name = "flowLayoutPanel_Screening";
            this.flowLayoutPanel_Screening.Size = new System.Drawing.Size(735, 160);
            this.flowLayoutPanel_Screening.TabIndex = 2;
            // 
            // MyUserControlSelectScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_Screening);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Title);
            this.Name = "MyUserControlSelectScreening";
            this.Size = new System.Drawing.Size(772, 256);
            this.Load += new System.EventHandler(this.MyUserControlSelectScreening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Screening;
    }
}
