namespace pbl3_Cinema.MyUserControler
{
    partial class MyUserControlInforComment
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
            this.label_NameUser = new System.Windows.Forms.Label();
            this.guna2RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // label_NameUser
            // 
            this.label_NameUser.AutoSize = true;
            this.label_NameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameUser.Location = new System.Drawing.Point(36, 12);
            this.label_NameUser.Name = "label_NameUser";
            this.label_NameUser.Size = new System.Drawing.Size(86, 20);
            this.label_NameUser.TabIndex = 0;
            this.label_NameUser.Text = "nameUser";
            // 
            // guna2RatingStar
            // 
            this.guna2RatingStar.Location = new System.Drawing.Point(248, 4);
            this.guna2RatingStar.Name = "guna2RatingStar";
            this.guna2RatingStar.ReadOnly = true;
            this.guna2RatingStar.Size = new System.Drawing.Size(120, 28);
            this.guna2RatingStar.TabIndex = 1;
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Location = new System.Drawing.Point(40, 40);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(720, 90);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 130);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(800, 20);
            this.guna2Separator1.TabIndex = 3;
            // 
            // MyUserControlInforComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.guna2RatingStar);
            this.Controls.Add(this.label_NameUser);
            this.Name = "MyUserControlInforComment";
            this.Size = new System.Drawing.Size(800, 150);
            this.Load += new System.EventHandler(this.MyUserControlInforComment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NameUser;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar;
        private System.Windows.Forms.RichTextBox richTextBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
