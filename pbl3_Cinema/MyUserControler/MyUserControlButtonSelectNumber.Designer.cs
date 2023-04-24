namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlButtonSelectNumber
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
            this.label_Number = new System.Windows.Forms.Label();
            this.btn_incease = new System.Windows.Forms.Button();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Number
            // 
            this.label_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.Location = new System.Drawing.Point(0, 43);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(80, 37);
            this.label_Number.TabIndex = 1;
            this.label_Number.Text = "0";
            this.label_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_incease
            // 
            this.btn_incease.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incease.Location = new System.Drawing.Point(20, 3);
            this.btn_incease.Name = "btn_incease";
            this.btn_incease.Size = new System.Drawing.Size(40, 40);
            this.btn_incease.TabIndex = 2;
            this.btn_incease.Text = "+";
            this.btn_incease.UseVisualStyleBackColor = true;
            this.btn_incease.Click += new System.EventHandler(this.clicked_Button);
            // 
            // btn_decrease
            // 
            this.btn_decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrease.Location = new System.Drawing.Point(20, 82);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(40, 40);
            this.btn_decrease.TabIndex = 2;
            this.btn_decrease.Text = "-";
            this.btn_decrease.UseVisualStyleBackColor = true;
            this.btn_decrease.Click += new System.EventHandler(this.clicked_Button);
            // 
            // MyUserControlButtonSelectNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_decrease);
            this.Controls.Add(this.btn_incease);
            this.Controls.Add(this.label_Number);
            this.Name = "MyUserControlButtonSelectNumber";
            this.Size = new System.Drawing.Size(80, 125);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Button btn_incease;
        private System.Windows.Forms.Button btn_decrease;
    }
}
