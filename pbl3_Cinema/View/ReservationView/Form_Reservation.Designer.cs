namespace pbl3_Cinema.View.ReservationView
{
    partial class Form_Reservation
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
            this.btn_Continute = new System.Windows.Forms.Button();
            this.panelBtn = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel_Head = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelBtn.SuspendLayout();
            this.panel_Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Continute
            // 
            this.btn_Continute.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Continute.Location = new System.Drawing.Point(580, 0);
            this.btn_Continute.Name = "btn_Continute";
            this.btn_Continute.Size = new System.Drawing.Size(120, 50);
            this.btn_Continute.TabIndex = 0;
            this.btn_Continute.Text = "Tiếp tục";
            this.btn_Continute.UseVisualStyleBackColor = true;
            this.btn_Continute.Click += new System.EventHandler(this.btn_Continute_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btn_Cancel);
            this.panelBtn.Controls.Add(this.btn_Continute);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtn.Location = new System.Drawing.Point(0, 500);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(700, 50);
            this.panelBtn.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Cancel.Location = new System.Drawing.Point(0, 0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 50);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel_Head
            // 
            this.panel_Head.Controls.Add(this.label_Title);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Head.Location = new System.Drawing.Point(0, 0);
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(700, 80);
            this.panel_Head.TabIndex = 2;
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(700, 80);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "label1";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 80);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(700, 420);
            this.panel_Body.TabIndex = 3;
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
            // Form_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Head);
            this.Controls.Add(this.panelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Reservation";
            this.Text = "Form_Reservation";
            this.Load += new System.EventHandler(this.Form_Reservation_Load);
            this.panelBtn.ResumeLayout(false);
            this.panel_Head.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Continute;
        private Guna.UI2.WinForms.Guna2Panel panelBtn;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel_Head;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Body;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}