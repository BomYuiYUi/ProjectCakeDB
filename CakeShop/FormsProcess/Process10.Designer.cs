
namespace CakeShop
{
    partial class Process10
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
            System.Windows.Forms.Label orderPayIDLabel;
            System.Windows.Forms.Label orderPayNameLabel;
            System.Windows.Forms.Label orderPayPriceLabel;
            System.Windows.Forms.Label orderPayQuantityLabel;
            System.Windows.Forms.Label reqBuyIDLabel;
            this.dataGridVReqBuy = new System.Windows.Forms.DataGridView();
            this.dataGridOrderPay = new System.Windows.Forms.DataGridView();
            this.orderPayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqBuyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetOrderPay = new CakeShop.CakeDBDataSetOrderPay();
            this.orderPayIDTextBox = new System.Windows.Forms.TextBox();
            this.orderPayNameTextBox = new System.Windows.Forms.TextBox();
            this.orderPayPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderPayQuantityTextBox = new System.Windows.Forms.TextBox();
            this.reqBuyIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.orderPayTableAdapter = new CakeShop.CakeDBDataSetOrderPayTableAdapters.OrderPayTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            orderPayIDLabel = new System.Windows.Forms.Label();
            orderPayNameLabel = new System.Windows.Forms.Label();
            orderPayPriceLabel = new System.Windows.Forms.Label();
            orderPayQuantityLabel = new System.Windows.Forms.Label();
            reqBuyIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVReqBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetOrderPay)).BeginInit();
            this.SuspendLayout();
            // 
            // orderPayIDLabel
            // 
            orderPayIDLabel.AutoSize = true;
            orderPayIDLabel.Location = new System.Drawing.Point(12, 522);
            orderPayIDLabel.Name = "orderPayIDLabel";
            orderPayIDLabel.Size = new System.Drawing.Size(141, 29);
            orderPayIDLabel.TabIndex = 3;
            orderPayIDLabel.Text = "รหัสใบสั่งซื้อ :";
            // 
            // orderPayNameLabel
            // 
            orderPayNameLabel.AutoSize = true;
            orderPayNameLabel.Location = new System.Drawing.Point(12, 562);
            orderPayNameLabel.Name = "orderPayNameLabel";
            orderPayNameLabel.Size = new System.Drawing.Size(116, 29);
            orderPayNameLabel.TabIndex = 5;
            orderPayNameLabel.Text = "ชื่อวัตถุดิบ :";
            // 
            // orderPayPriceLabel
            // 
            orderPayPriceLabel.AutoSize = true;
            orderPayPriceLabel.Location = new System.Drawing.Point(12, 602);
            orderPayPriceLabel.Name = "orderPayPriceLabel";
            orderPayPriceLabel.Size = new System.Drawing.Size(71, 29);
            orderPayPriceLabel.TabIndex = 7;
            orderPayPriceLabel.Text = "ราคา :";
            // 
            // orderPayQuantityLabel
            // 
            orderPayQuantityLabel.AutoSize = true;
            orderPayQuantityLabel.Location = new System.Drawing.Point(12, 642);
            orderPayQuantityLabel.Name = "orderPayQuantityLabel";
            orderPayQuantityLabel.Size = new System.Drawing.Size(90, 29);
            orderPayQuantityLabel.TabIndex = 9;
            orderPayQuantityLabel.Text = "จำนวน :";
            // 
            // reqBuyIDLabel
            // 
            reqBuyIDLabel.AutoSize = true;
            reqBuyIDLabel.Location = new System.Drawing.Point(439, 522);
            reqBuyIDLabel.Name = "reqBuyIDLabel";
            reqBuyIDLabel.Size = new System.Drawing.Size(144, 29);
            reqBuyIDLabel.TabIndex = 11;
            reqBuyIDLabel.Text = "รหัสใบขอซื้อ :";
            // 
            // dataGridVReqBuy
            // 
            this.dataGridVReqBuy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVReqBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVReqBuy.Location = new System.Drawing.Point(12, 45);
            this.dataGridVReqBuy.Name = "dataGridVReqBuy";
            this.dataGridVReqBuy.RowHeadersWidth = 51;
            this.dataGridVReqBuy.RowTemplate.Height = 24;
            this.dataGridVReqBuy.Size = new System.Drawing.Size(1090, 230);
            this.dataGridVReqBuy.TabIndex = 0;
            // 
            // dataGridOrderPay
            // 
            this.dataGridOrderPay.AutoGenerateColumns = false;
            this.dataGridOrderPay.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrderPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderPayIDDataGridViewTextBoxColumn,
            this.orderPayNameDataGridViewTextBoxColumn,
            this.orderPayPriceDataGridViewTextBoxColumn,
            this.orderPayQuantityDataGridViewTextBoxColumn,
            this.reqBuyIDDataGridViewTextBoxColumn});
            this.dataGridOrderPay.DataSource = this.orderPayBindingSource;
            this.dataGridOrderPay.Location = new System.Drawing.Point(12, 323);
            this.dataGridOrderPay.Name = "dataGridOrderPay";
            this.dataGridOrderPay.RowHeadersWidth = 51;
            this.dataGridOrderPay.RowTemplate.Height = 24;
            this.dataGridOrderPay.Size = new System.Drawing.Size(1090, 181);
            this.dataGridOrderPay.TabIndex = 1;
            // 
            // orderPayIDDataGridViewTextBoxColumn
            // 
            this.orderPayIDDataGridViewTextBoxColumn.DataPropertyName = "OrderPayID";
            this.orderPayIDDataGridViewTextBoxColumn.HeaderText = "OrderPayID";
            this.orderPayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPayIDDataGridViewTextBoxColumn.Name = "orderPayIDDataGridViewTextBoxColumn";
            this.orderPayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPayNameDataGridViewTextBoxColumn
            // 
            this.orderPayNameDataGridViewTextBoxColumn.DataPropertyName = "OrderPayName";
            this.orderPayNameDataGridViewTextBoxColumn.HeaderText = "OrderPayName";
            this.orderPayNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPayNameDataGridViewTextBoxColumn.Name = "orderPayNameDataGridViewTextBoxColumn";
            this.orderPayNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPayPriceDataGridViewTextBoxColumn
            // 
            this.orderPayPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderPayPrice";
            this.orderPayPriceDataGridViewTextBoxColumn.HeaderText = "OrderPayPrice";
            this.orderPayPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPayPriceDataGridViewTextBoxColumn.Name = "orderPayPriceDataGridViewTextBoxColumn";
            this.orderPayPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPayQuantityDataGridViewTextBoxColumn
            // 
            this.orderPayQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderPayQuantity";
            this.orderPayQuantityDataGridViewTextBoxColumn.HeaderText = "OrderPayQuantity";
            this.orderPayQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPayQuantityDataGridViewTextBoxColumn.Name = "orderPayQuantityDataGridViewTextBoxColumn";
            this.orderPayQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqBuyIDDataGridViewTextBoxColumn
            // 
            this.reqBuyIDDataGridViewTextBoxColumn.DataPropertyName = "ReqBuyID";
            this.reqBuyIDDataGridViewTextBoxColumn.HeaderText = "ReqBuyID";
            this.reqBuyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqBuyIDDataGridViewTextBoxColumn.Name = "reqBuyIDDataGridViewTextBoxColumn";
            this.reqBuyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPayBindingSource
            // 
            this.orderPayBindingSource.DataMember = "OrderPay";
            this.orderPayBindingSource.DataSource = this.cakeDBDataSetOrderPay;
            // 
            // cakeDBDataSetOrderPay
            // 
            this.cakeDBDataSetOrderPay.DataSetName = "CakeDBDataSetOrderPay";
            this.cakeDBDataSetOrderPay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderPayIDTextBox
            // 
            this.orderPayIDTextBox.Location = new System.Drawing.Point(239, 519);
            this.orderPayIDTextBox.Name = "orderPayIDTextBox";
            this.orderPayIDTextBox.Size = new System.Drawing.Size(186, 34);
            this.orderPayIDTextBox.TabIndex = 4;
            // 
            // orderPayNameTextBox
            // 
            this.orderPayNameTextBox.Location = new System.Drawing.Point(239, 559);
            this.orderPayNameTextBox.Name = "orderPayNameTextBox";
            this.orderPayNameTextBox.Size = new System.Drawing.Size(186, 34);
            this.orderPayNameTextBox.TabIndex = 6;
            // 
            // orderPayPriceTextBox
            // 
            this.orderPayPriceTextBox.Location = new System.Drawing.Point(239, 599);
            this.orderPayPriceTextBox.Name = "orderPayPriceTextBox";
            this.orderPayPriceTextBox.Size = new System.Drawing.Size(186, 34);
            this.orderPayPriceTextBox.TabIndex = 8;
            // 
            // orderPayQuantityTextBox
            // 
            this.orderPayQuantityTextBox.Location = new System.Drawing.Point(239, 639);
            this.orderPayQuantityTextBox.Name = "orderPayQuantityTextBox";
            this.orderPayQuantityTextBox.Size = new System.Drawing.Size(186, 34);
            this.orderPayQuantityTextBox.TabIndex = 10;
            // 
            // reqBuyIDTextBox
            // 
            this.reqBuyIDTextBox.Location = new System.Drawing.Point(666, 519);
            this.reqBuyIDTextBox.Name = "reqBuyIDTextBox";
            this.reqBuyIDTextBox.Size = new System.Drawing.Size(186, 34);
            this.reqBuyIDTextBox.TabIndex = 12;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(858, 608);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(244, 39);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(858, 562);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(244, 40);
            this.buttonDeL.TabIndex = 31;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(858, 516);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(244, 40);
            this.buttonInsert.TabIndex = 30;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // orderPayTableAdapter
            // 
            this.orderPayTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ข้อมูลใบขอซื้อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "ข้อมูลใบสั่งซื้อ";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสใบขอซื้อ",
            "วันที่ขอซื้อ",
            "ชื่อวัตถุดิบ",
            "ชื่อผู้ขอซื้อ",
            "จำนวน",
            "รหัสพนักงาน"});
            this.searchcomboBox.Location = new System.Drawing.Point(593, 4);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 42;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(900, 4);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 41;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(744, 7);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 40;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1055, 4);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 49;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(orderPayIDLabel);
            this.Controls.Add(this.orderPayIDTextBox);
            this.Controls.Add(orderPayNameLabel);
            this.Controls.Add(this.orderPayNameTextBox);
            this.Controls.Add(orderPayPriceLabel);
            this.Controls.Add(this.orderPayPriceTextBox);
            this.Controls.Add(orderPayQuantityLabel);
            this.Controls.Add(this.orderPayQuantityTextBox);
            this.Controls.Add(reqBuyIDLabel);
            this.Controls.Add(this.reqBuyIDTextBox);
            this.Controls.Add(this.dataGridOrderPay);
            this.Controls.Add(this.dataGridVReqBuy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ใบสั่งซื้อวัตถุดิบ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process10_FormClosing);
            this.Load += new System.EventHandler(this.Process10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVReqBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetOrderPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVReqBuy;
        private System.Windows.Forms.DataGridView dataGridOrderPay;
        private System.Windows.Forms.TextBox orderPayIDTextBox;
        private System.Windows.Forms.TextBox orderPayNameTextBox;
        private System.Windows.Forms.TextBox orderPayPriceTextBox;
        private System.Windows.Forms.TextBox orderPayQuantityTextBox;
        private System.Windows.Forms.TextBox reqBuyIDTextBox;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private CakeDBDataSetOrderPay cakeDBDataSetOrderPay;
        private System.Windows.Forms.BindingSource orderPayBindingSource;
        private CakeDBDataSetOrderPayTableAdapters.OrderPayTableAdapter orderPayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqBuyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}