namespace pbl3_Cinema.MyUserControler
{
    partial class UserControlDisplayMovie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_NameFilm = new System.Windows.Forms.Label();
            this.pictureBox_Film = new System.Windows.Forms.PictureBox();
            this.panel_Opacity = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Film)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_NameFilm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 50);
            this.panel1.TabIndex = 0;
            // 
            // label_NameFilm
            // 
            this.label_NameFilm.AutoSize = true;
            this.label_NameFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameFilm.Location = new System.Drawing.Point(13, 10);
            this.label_NameFilm.Name = "label_NameFilm";
            this.label_NameFilm.Size = new System.Drawing.Size(72, 29);
            this.label_NameFilm.TabIndex = 0;
            this.label_NameFilm.Text = "None";
            // 
            // pictureBox_Film
            // 
            this.pictureBox_Film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Film.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Film.Name = "pictureBox_Film";
            this.pictureBox_Film.Size = new System.Drawing.Size(448, 298);
            this.pictureBox_Film.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Film.TabIndex = 1;
            this.pictureBox_Film.TabStop = false;
            // 
            // panel_Opacity
            // 
            this.panel_Opacity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Opacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Opacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Opacity.Location = new System.Drawing.Point(0, 0);
            this.panel_Opacity.Name = "panel_Opacity";
            this.panel_Opacity.Size = new System.Drawing.Size(448, 298);
            this.panel_Opacity.TabIndex = 2;
            this.panel_Opacity.Click += new System.EventHandler(this.panel_Opacity_Click);
            this.panel_Opacity.MouseEnter += new System.EventHandler(this.panel_Opacity_MouseEnter);
            this.panel_Opacity.MouseLeave += new System.EventHandler(this.panel_Opacity_MouseLeave);
            // 
            // UserControlDisplayMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_Opacity);
            this.Controls.Add(this.pictureBox_Film);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.Name = "UserControlDisplayMovie";
            this.Size = new System.Drawing.Size(448, 348);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Film)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_NameFilm;
        private System.Windows.Forms.PictureBox pictureBox_Film;
        private System.Windows.Forms.Panel panel_Opacity;
    }
}
