namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlScreening
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
            this.panel_NameAuditorium = new System.Windows.Forms.Panel();
            this.label_NameAuditorium = new System.Windows.Forms.Label();
            this.panel_NoSeat = new System.Windows.Forms.Panel();
            this.label_NoSeat = new System.Windows.Forms.Label();
            this.label_ShowTime = new System.Windows.Forms.Label();
            this.panel_NameAuditorium.SuspendLayout();
            this.panel_NoSeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_NameAuditorium
            // 
            this.panel_NameAuditorium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_NameAuditorium.Controls.Add(this.label_NameAuditorium);
            this.panel_NameAuditorium.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NameAuditorium.Location = new System.Drawing.Point(0, 0);
            this.panel_NameAuditorium.Name = "panel_NameAuditorium";
            this.panel_NameAuditorium.Size = new System.Drawing.Size(160, 31);
            this.panel_NameAuditorium.TabIndex = 0;
            // 
            // label_NameAuditorium
            // 
            this.label_NameAuditorium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_NameAuditorium.Location = new System.Drawing.Point(0, 0);
            this.label_NameAuditorium.Name = "label_NameAuditorium";
            this.label_NameAuditorium.Size = new System.Drawing.Size(158, 29);
            this.label_NameAuditorium.TabIndex = 0;
            this.label_NameAuditorium.Text = "Phòng ?";
            this.label_NameAuditorium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_NoSeat
            // 
            this.panel_NoSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_NoSeat.Controls.Add(this.label_NoSeat);
            this.panel_NoSeat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_NoSeat.Location = new System.Drawing.Point(0, 81);
            this.panel_NoSeat.Name = "panel_NoSeat";
            this.panel_NoSeat.Size = new System.Drawing.Size(160, 34);
            this.panel_NoSeat.TabIndex = 1;
            // 
            // label_NoSeat
            // 
            this.label_NoSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_NoSeat.Location = new System.Drawing.Point(0, 0);
            this.label_NoSeat.Name = "label_NoSeat";
            this.label_NoSeat.Size = new System.Drawing.Size(158, 32);
            this.label_NoSeat.TabIndex = 0;
            this.label_NoSeat.Text = "/ Chổ ngồi";
            this.label_NoSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ShowTime
            // 
            this.label_ShowTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ShowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowTime.Location = new System.Drawing.Point(0, 31);
            this.label_ShowTime.Name = "label_ShowTime";
            this.label_ShowTime.Size = new System.Drawing.Size(160, 50);
            this.label_ShowTime.TabIndex = 2;
            this.label_ShowTime.Text = "00:00";
            this.label_ShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyUserControlScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_ShowTime);
            this.Controls.Add(this.panel_NoSeat);
            this.Controls.Add(this.panel_NameAuditorium);
            this.Name = "MyUserControlScreening";
            this.Size = new System.Drawing.Size(160, 115);
            this.Load += new System.EventHandler(this.MyUserControlScreening_Load);
            this.panel_NameAuditorium.ResumeLayout(false);
            this.panel_NoSeat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_NameAuditorium;
        private System.Windows.Forms.Label label_NameAuditorium;
        private System.Windows.Forms.Panel panel_NoSeat;
        private System.Windows.Forms.Label label_NoSeat;
        private System.Windows.Forms.Label label_ShowTime;
    }
}
