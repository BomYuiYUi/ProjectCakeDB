
namespace CakeShop.Report
{
    partial class FormReport5
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
            this.cakeDBDataSetPay = new CakeShop.CakeDBDataSetPay();
            this.payBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payTableAdapter = new CakeShop.CakeDBDataSetPayTableAdapters.PayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.payBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CakeShop.Report1.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1112, 515);
            this.reportViewer1.TabIndex = 0;
            // 
            // cakeDBDataSetPay
            // 
            this.cakeDBDataSetPay.DataSetName = "CakeDBDataSetPay";
            this.cakeDBDataSetPay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payBindingSource
            // 
            this.payBindingSource.DataMember = "Pay";
            this.payBindingSource.DataSource = this.cakeDBDataSetPay;
            // 
            // payTableAdapter
            // 
            this.payTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 515);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormReport5";
            this.Text = "FormReport5";
            this.Load += new System.EventHandler(this.FormReport5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CakeDBDataSetPay cakeDBDataSetPay;
        private System.Windows.Forms.BindingSource payBindingSource;
        private CakeDBDataSetPayTableAdapters.PayTableAdapter payTableAdapter;
    }
}