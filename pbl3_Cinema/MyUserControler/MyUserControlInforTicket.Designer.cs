namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlInforTicket
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
            this.pictureBox_Poster = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Auditorium = new System.Windows.Forms.Label();
            this.label_ShowDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Poster
            // 
            this.pictureBox_Poster.Location = new System.Drawing.Point(5, 5);
            this.pictureBox_Poster.Name = "pictureBox_Poster";
            this.pictureBox_Poster.Size = new System.Drawing.Size(135, 90);
            this.pictureBox_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Poster.TabIndex = 0;
            this.pictureBox_Poster.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(146, 7);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(53, 20);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "label1";
            // 
            // label_Auditorium
            // 
            this.label_Auditorium.AutoSize = true;
            this.label_Auditorium.Location = new System.Drawing.Point(147, 40);
            this.label_Auditorium.Name = "label_Auditorium";
            this.label_Auditorium.Size = new System.Drawing.Size(69, 16);
            this.label_Auditorium.TabIndex = 2;
            this.label_Auditorium.Text = "auditorium";
            // 
            // label_ShowDateTime
            // 
            this.label_ShowDateTime.AutoSize = true;
            this.label_ShowDateTime.Location = new System.Drawing.Point(147, 67);
            this.label_ShowDateTime.Name = "label_ShowDateTime";
            this.label_ShowDateTime.Size = new System.Drawing.Size(38, 16);
            this.label_ShowDateTime.TabIndex = 3;
            this.label_ShowDateTime.Text = "Time";
            // 
            // MyUserControlInforTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_ShowDateTime);
            this.Controls.Add(this.label_Auditorium);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_Poster);
            this.Name = "MyUserControlInforTicket";
            this.Size = new System.Drawing.Size(350, 100);
            this.Load += new System.EventHandler(this.MyUserControlInforTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Poster;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Auditorium;
        private System.Windows.Forms.Label label_ShowDateTime;
    }
}
