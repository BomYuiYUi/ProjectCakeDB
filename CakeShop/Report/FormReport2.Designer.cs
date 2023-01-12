
namespace CakeShop.Report
{
    partial class FormReport2
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
            this.cakeDBDataSetReqBuy = new CakeShop.CakeDBDataSetReqBuy();
            this.reqBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reqBuyTableAdapter = new CakeShop.CakeDBDataSetReqBuyTableAdapters.ReqBuyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetReqBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqBuyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.reqBuyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CakeShop.Report1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(985, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // cakeDBDataSetReqBuy
            // 
            this.cakeDBDataSetReqBuy.DataSetName = "CakeDBDataSetReqBuy";
            this.cakeDBDataSetReqBuy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reqBuyBindingSource
            // 
            this.reqBuyBindingSource.DataMember = "ReqBuy";
            this.reqBuyBindingSource.DataSource = this.cakeDBDataSetReqBuy;
            // 
            // reqBuyTableAdapter
            // 
            this.reqBuyTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 461);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormReport2";
            this.Text = "FormReport2";
            this.Load += new System.EventHandler(this.FormReport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetReqBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqBuyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CakeDBDataSetReqBuy cakeDBDataSetReqBuy;
        private System.Windows.Forms.BindingSource reqBuyBindingSource;
        private CakeDBDataSetReqBuyTableAdapters.ReqBuyTableAdapter reqBuyTableAdapter;
    }
}