namespace pbl3_Cinema.View.ReservationView
{
    partial class Form_SelectProduct
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
            this.flowLayoutPanel_SelectProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_SelectProduct
            // 
            this.flowLayoutPanel_SelectProduct.AutoScroll = true;
            this.flowLayoutPanel_SelectProduct.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel_SelectProduct.Name = "flowLayoutPanel_SelectProduct";
            this.flowLayoutPanel_SelectProduct.Size = new System.Drawing.Size(675, 395);
            this.flowLayoutPanel_SelectProduct.TabIndex = 0;
            // 
            // Form_SelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.flowLayoutPanel_SelectProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SelectProduct";
            this.Text = "Form_SelectProduct";
            this.Load += new System.EventHandler(this.Form_SelectProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SelectProduct;
    }
}