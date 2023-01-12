
namespace CakeShop.Report
{
    partial class FormReport3
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
            this.cakeDBDataSetRequisition = new CakeShop.CakeDBDataSetRequisition();
            this.requisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisitionTableAdapter = new CakeShop.CakeDBDataSetRequisitionTableAdapters.RequisitionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetRequisition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.requisitionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CakeShop.Report1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1112, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // cakeDBDataSetRequisition
            // 
            this.cakeDBDataSetRequisition.DataSetName = "CakeDBDataSetRequisition";
            this.cakeDBDataSetRequisition.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisitionBindingSource
            // 
            this.requisitionBindingSource.DataMember = "Requisition";
            this.requisitionBindingSource.DataSource = this.cakeDBDataSetRequisition;
            // 
            // requisitionTableAdapter
            // 
            this.requisitionTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 521);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormReport3";
            this.Text = "FormReport3";
            this.Load += new System.EventHandler(this.FormReport3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetRequisition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CakeDBDataSetRequisition cakeDBDataSetRequisition;
        private System.Windows.Forms.BindingSource requisitionBindingSource;
        private CakeDBDataSetRequisitionTableAdapters.RequisitionTableAdapter requisitionTableAdapter;
    }
}