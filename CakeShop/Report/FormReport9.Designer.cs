
namespace CakeShop.Report
{
    partial class FormReport9
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cakeDBDataSetCake = new CakeShop.CakeDBDataSetCake();
            this.cakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeTableAdapter = new CakeShop.CakeDBDataSetCakeTableAdapters.CakeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cakeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CakeShop.Report1.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1113, 528);
            this.reportViewer1.TabIndex = 0;
            // 
            // cakeDBDataSetCake
            // 
            this.cakeDBDataSetCake.DataSetName = "CakeDBDataSetCake";
            this.cakeDBDataSetCake.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cakeBindingSource
            // 
            this.cakeBindingSource.DataMember = "Cake";
            this.cakeBindingSource.DataSource = this.cakeDBDataSetCake;
            // 
            // cakeTableAdapter
            // 
            this.cakeTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 528);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormReport9";
            this.Text = "FormReport9";
            this.Load += new System.EventHandler(this.FormReport9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CakeDBDataSetCake cakeDBDataSetCake;
        private System.Windows.Forms.BindingSource cakeBindingSource;
        private CakeDBDataSetCakeTableAdapters.CakeTableAdapter cakeTableAdapter;
    }
}