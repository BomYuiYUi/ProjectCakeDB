
namespace CakeShop
{
    partial class Customer
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
            this.buttonP2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonP2
            // 
            this.buttonP2.BackColor = System.Drawing.SystemColors.Info;
            this.buttonP2.Location = new System.Drawing.Point(12, 12);
            this.buttonP2.Name = "buttonP2";
            this.buttonP2.Size = new System.Drawing.Size(211, 51);
            this.buttonP2.TabIndex = 1;
            this.buttonP2.Text = "แสดงข้อมูลสั่งซื้อเค้ก";
            this.buttonP2.UseVisualStyleBackColor = false;
            this.buttonP2.Click += new System.EventHandler(this.buttonP2_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CakeShop.Properties.Resources._13445;
            this.ClientSize = new System.Drawing.Size(818, 383);
            this.Controls.Add(this.buttonP2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonP2;
    }
}