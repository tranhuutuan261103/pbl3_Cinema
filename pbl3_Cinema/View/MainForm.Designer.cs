namespace pbl3_Cinema.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ControlBox_Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ComboxBox_Mini = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_ListSelect = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_SubListSelect = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_Display = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_ListSelect.SuspendLayout();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlBox_Exit
            // 
            this.ControlBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlBox_Exit.IconColor = System.Drawing.Color.White;
            this.ControlBox_Exit.Location = new System.Drawing.Point(957, 12);
            this.ControlBox_Exit.Name = "ControlBox_Exit";
            this.ControlBox_Exit.Size = new System.Drawing.Size(35, 35);
            this.ControlBox_Exit.TabIndex = 0;
            this.ControlBox_Exit.Click += new System.EventHandler(this.ControlBox_Exit_Click);
            // 
            // ComboxBox_Mini
            // 
            this.ComboxBox_Mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboxBox_Mini.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ComboxBox_Mini.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ComboxBox_Mini.IconColor = System.Drawing.Color.White;
            this.ComboxBox_Mini.Location = new System.Drawing.Point(907, 12);
            this.ComboxBox_Mini.Name = "ComboxBox_Mini";
            this.ComboxBox_Mini.Size = new System.Drawing.Size(35, 35);
            this.ComboxBox_Mini.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel_ListSelect
            // 
            this.panel_ListSelect.Controls.Add(this.panel_SubListSelect);
            this.panel_ListSelect.Controls.Add(this.guna2PictureBox1);
            this.panel_ListSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ListSelect.Location = new System.Drawing.Point(0, 0);
            this.panel_ListSelect.Name = "panel_ListSelect";
            this.panel_ListSelect.Size = new System.Drawing.Size(165, 746);
            this.panel_ListSelect.TabIndex = 2;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.guna2PictureBox2);
            this.panel_Title.Controls.Add(this.ComboxBox_Mini);
            this.panel_Title.Controls.Add(this.ControlBox_Exit);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(165, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1005, 139);
            this.panel_Title.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel_SubListSelect
            // 
            this.panel_SubListSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubListSelect.Location = new System.Drawing.Point(0, 139);
            this.panel_SubListSelect.Name = "panel_SubListSelect";
            this.panel_SubListSelect.Size = new System.Drawing.Size(165, 373);
            this.panel_SubListSelect.TabIndex = 1;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::pbl3_Cinema.Properties.Resources.poster_title;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(424, 136);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = global::pbl3_Cinema.Properties.Resources.cinema_logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(165, 139);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel_Display
            // 
            this.panel_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Display.Location = new System.Drawing.Point(165, 139);
            this.panel_Display.Name = "panel_Display";
            this.panel_Display.Size = new System.Drawing.Size(1005, 607);
            this.panel_Display.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 746);
            this.Controls.Add(this.panel_Display);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_ListSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_ListSelect.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox ControlBox_Exit;
        private Guna.UI2.WinForms.Guna2ControlBox ComboxBox_Mini;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private Guna.UI2.WinForms.Guna2Panel panel_ListSelect;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panel_SubListSelect;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel panel_Display;
    }
}