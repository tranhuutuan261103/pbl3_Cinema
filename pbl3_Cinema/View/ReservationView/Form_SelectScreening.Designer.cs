namespace pbl3_Cinema.View.ReservationView
{
    partial class Form_SelectScreening
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel_Body = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel_SelectDayShow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_DisplayScreening = new System.Windows.Forms.FlowLayoutPanel();
            this.cbb_SelectMovie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(856, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(809, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel_Body
            // 
            this.guna2Panel_Body.AutoScroll = true;
            this.guna2Panel_Body.Controls.Add(this.flowLayoutPanel_SelectDayShow);
            this.guna2Panel_Body.Controls.Add(this.flowLayoutPanel_DisplayScreening);
            this.guna2Panel_Body.Controls.Add(this.cbb_SelectMovie);
            this.guna2Panel_Body.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel_Body.Location = new System.Drawing.Point(0, 65);
            this.guna2Panel_Body.Name = "guna2Panel_Body";
            this.guna2Panel_Body.Size = new System.Drawing.Size(898, 565);
            this.guna2Panel_Body.TabIndex = 2;
            // 
            // flowLayoutPanel_SelectDayShow
            // 
            this.flowLayoutPanel_SelectDayShow.Location = new System.Drawing.Point(39, 76);
            this.flowLayoutPanel_SelectDayShow.Name = "flowLayoutPanel_SelectDayShow";
            this.flowLayoutPanel_SelectDayShow.Size = new System.Drawing.Size(822, 77);
            this.flowLayoutPanel_SelectDayShow.TabIndex = 3;
            // 
            // flowLayoutPanel_DisplayScreening
            // 
            this.flowLayoutPanel_DisplayScreening.AutoScroll = true;
            this.flowLayoutPanel_DisplayScreening.Location = new System.Drawing.Point(39, 168);
            this.flowLayoutPanel_DisplayScreening.Name = "flowLayoutPanel_DisplayScreening";
            this.flowLayoutPanel_DisplayScreening.Size = new System.Drawing.Size(822, 373);
            this.flowLayoutPanel_DisplayScreening.TabIndex = 2;
            // 
            // cbb_SelectMovie
            // 
            this.cbb_SelectMovie.BackColor = System.Drawing.Color.Transparent;
            this.cbb_SelectMovie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_SelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_SelectMovie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_SelectMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_SelectMovie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_SelectMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_SelectMovie.ItemHeight = 30;
            this.cbb_SelectMovie.Location = new System.Drawing.Point(519, 14);
            this.cbb_SelectMovie.Name = "cbb_SelectMovie";
            this.cbb_SelectMovie.Size = new System.Drawing.Size(342, 36);
            this.cbb_SelectMovie.TabIndex = 1;
            this.cbb_SelectMovie.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectMovie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn suất chiếu";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form_SelectScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel_Body);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SelectScreening";
            this.Text = "Form_SelectScreening";
            this.guna2Panel_Body.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Body;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_DisplayScreening;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_SelectMovie;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SelectDayShow;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}