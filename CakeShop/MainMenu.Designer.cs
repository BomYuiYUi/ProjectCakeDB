
namespace CakeShop
{
    partial class MainMenu
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
            this.buttonCus = new System.Windows.Forms.Button();
            this.buttonEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCus
            // 
            this.buttonCus.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCus.Location = new System.Drawing.Point(97, 160);
            this.buttonCus.Name = "buttonCus";
            this.buttonCus.Size = new System.Drawing.Size(155, 42);
            this.buttonCus.TabIndex = 0;
            this.buttonCus.Text = "ลูกค้า";
            this.buttonCus.UseVisualStyleBackColor = false;
            this.buttonCus.Click += new System.EventHandler(this.buttonCus_Click);
            // 
            // buttonEmp
            // 
            this.buttonEmp.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEmp.ForeColor = System.Drawing.Color.Black;
            this.buttonEmp.Location = new System.Drawing.Point(258, 160);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(155, 42);
            this.buttonEmp.TabIndex = 1;
            this.buttonEmp.Text = "พนักงาน";
            this.buttonEmp.UseVisualStyleBackColor = false;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CakeShop.Properties.Resources.เค้ก;
            this.ClientSize = new System.Drawing.Size(521, 351);
            this.Controls.Add(this.buttonEmp);
            this.Controls.Add(this.buttonCus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าหลัก";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCus;
        private System.Windows.Forms.Button buttonEmp;
    }
}

