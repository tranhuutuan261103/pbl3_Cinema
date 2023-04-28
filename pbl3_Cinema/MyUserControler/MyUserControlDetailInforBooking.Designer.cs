namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlDetailInforBooking
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
            this.label_NameProduct = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_NameProduct
            // 
            this.label_NameProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_NameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameProduct.Location = new System.Drawing.Point(0, 0);
            this.label_NameProduct.Name = "label_NameProduct";
            this.label_NameProduct.Size = new System.Drawing.Size(198, 40);
            this.label_NameProduct.TabIndex = 0;
            this.label_NameProduct.Text = "Tên sp";
            this.label_NameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Price
            // 
            this.label_Price.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(243, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(97, 40);
            this.label_Price.TabIndex = 1;
            this.label_Price.Text = "0";
            this.label_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(10, 38);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(320, 1);
            this.panel.TabIndex = 2;
            // 
            // MyUserControlDetailInforBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_NameProduct);
            this.Name = "MyUserControlDetailInforBooking";
            this.Size = new System.Drawing.Size(340, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_NameProduct;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Panel panel;
    }
}
