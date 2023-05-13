namespace pbl3_Cinema.View.ReservationView
{
    partial class Form_SeatMap
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
            this.panel_MapSeat = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_MapSeat
            // 
            this.panel_MapSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_MapSeat.Location = new System.Drawing.Point(0, 0);
            this.panel_MapSeat.Name = "panel_MapSeat";
            this.panel_MapSeat.Size = new System.Drawing.Size(700, 420);
            this.panel_MapSeat.TabIndex = 0;
            // 
            // Form_SeatMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.panel_MapSeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SeatMap";
            this.Text = "Form_SeatMap";
            this.Load += new System.EventHandler(this.Form_SeatMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MapSeat;
    }
}