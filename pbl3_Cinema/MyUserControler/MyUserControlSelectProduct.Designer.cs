namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlSelectProduct
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_SelectedNumber = new System.Windows.Forms.Label();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.btn_increase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_SelectedNumber);
            this.panel2.Controls.Add(this.btn_decrease);
            this.panel2.Controls.Add(this.btn_increase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(580, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 125);
            this.panel2.TabIndex = 4;
            // 
            // label_SelectedNumber
            // 
            this.label_SelectedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectedNumber.Location = new System.Drawing.Point(0, 45);
            this.label_SelectedNumber.Name = "label_SelectedNumber";
            this.label_SelectedNumber.Size = new System.Drawing.Size(60, 35);
            this.label_SelectedNumber.TabIndex = 2;
            this.label_SelectedNumber.Text = "0";
            this.label_SelectedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_decrease
            // 
            this.btn_decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrease.Location = new System.Drawing.Point(12, 80);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(35, 35);
            this.btn_decrease.TabIndex = 1;
            this.btn_decrease.Text = "-";
            this.btn_decrease.UseVisualStyleBackColor = true;
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // btn_increase
            // 
            this.btn_increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_increase.Location = new System.Drawing.Point(12, 10);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(35, 35);
            this.btn_increase.TabIndex = 0;
            this.btn_increase.Text = "+";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.Location = new System.Drawing.Point(294, 90);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(23, 25);
            this.label_Number.TabIndex = 6;
            this.label_Number.Text = "0";
            // 
            // MyUserControlSelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "MyUserControlSelectProduct";
            this.Size = new System.Drawing.Size(640, 125);
            this.Load += new System.EventHandler(this.MyUserControlSelectProduct_Load);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label_Number, 0);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_decrease;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.Label label_SelectedNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Number;
    }
}
