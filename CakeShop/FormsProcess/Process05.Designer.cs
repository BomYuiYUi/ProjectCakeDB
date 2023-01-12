
namespace CakeShop
{
    partial class Process05
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
            System.Windows.Forms.Label payIDLabel;
            System.Windows.Forms.Label payTimeLabel;
            System.Windows.Forms.Label payDateLabel;
            System.Windows.Forms.Label payReceiveLabel;
            System.Windows.Forms.Label orderIDLabel;
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.payIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payReceiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payExchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetPay = new CakeShop.CakeDBDataSetPay();
            this.payIDTextBox = new System.Windows.Forms.TextBox();
            this.payTimeTextBox = new System.Windows.Forms.TextBox();
            this.payDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payReceiveTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.payTableAdapter = new CakeShop.CakeDBDataSetPayTableAdapters.PayTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            payIDLabel = new System.Windows.Forms.Label();
            payTimeLabel = new System.Windows.Forms.Label();
            payDateLabel = new System.Windows.Forms.Label();
            payReceiveLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetPay)).BeginInit();
            this.SuspendLayout();
            // 
            // payIDLabel
            // 
            payIDLabel.AutoSize = true;
            payIDLabel.Location = new System.Drawing.Point(12, 550);
            payIDLabel.Name = "payIDLabel";
            payIDLabel.Size = new System.Drawing.Size(142, 29);
            payIDLabel.TabIndex = 3;
            payIDLabel.Text = "รหัสการชำระ:";
            // 
            // payTimeLabel
            // 
            payTimeLabel.AutoSize = true;
            payTimeLabel.Location = new System.Drawing.Point(12, 590);
            payTimeLabel.Name = "payTimeLabel";
            payTimeLabel.Size = new System.Drawing.Size(122, 29);
            payTimeLabel.TabIndex = 5;
            payTimeLabel.Text = "เวลาที่ชำระ:";
            // 
            // payDateLabel
            // 
            payDateLabel.AutoSize = true;
            payDateLabel.Location = new System.Drawing.Point(12, 631);
            payDateLabel.Name = "payDateLabel";
            payDateLabel.Size = new System.Drawing.Size(107, 29);
            payDateLabel.TabIndex = 7;
            payDateLabel.Text = "วันที่ชำระ:";
            // 
            // payReceiveLabel
            // 
            payReceiveLabel.AutoSize = true;
            payReceiveLabel.Location = new System.Drawing.Point(413, 550);
            payReceiveLabel.Name = "payReceiveLabel";
            payReceiveLabel.Size = new System.Drawing.Size(166, 29);
            payReceiveLabel.TabIndex = 11;
            payReceiveLabel.Text = "จำนวนเงินที่จ่าย:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(413, 590);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(129, 29);
            orderIDLabel.TabIndex = 15;
            orderIDLabel.Text = "รหัสซื้อเค้ก :";
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 52);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowHeadersWidth = 51;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(1101, 206);
            this.dataGridOrders.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payIDDataGridViewTextBoxColumn,
            this.payTimeDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.payPriceDataGridViewTextBoxColumn,
            this.payReceiveDataGridViewTextBoxColumn,
            this.payExchangeDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.payBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 313);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1101, 224);
            this.dataGridView2.TabIndex = 1;
            // 
            // payIDDataGridViewTextBoxColumn
            // 
            this.payIDDataGridViewTextBoxColumn.DataPropertyName = "PayID";
            this.payIDDataGridViewTextBoxColumn.HeaderText = "PayID";
            this.payIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payIDDataGridViewTextBoxColumn.Name = "payIDDataGridViewTextBoxColumn";
            this.payIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // payTimeDataGridViewTextBoxColumn
            // 
            this.payTimeDataGridViewTextBoxColumn.DataPropertyName = "PayTime";
            this.payTimeDataGridViewTextBoxColumn.HeaderText = "PayTime";
            this.payTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payTimeDataGridViewTextBoxColumn.Name = "payTimeDataGridViewTextBoxColumn";
            this.payTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate";
            this.payDateDataGridViewTextBoxColumn.HeaderText = "PayDate";
            this.payDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            this.payDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // payPriceDataGridViewTextBoxColumn
            // 
            this.payPriceDataGridViewTextBoxColumn.DataPropertyName = "PayPrice";
            this.payPriceDataGridViewTextBoxColumn.HeaderText = "PayPrice";
            this.payPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payPriceDataGridViewTextBoxColumn.Name = "payPriceDataGridViewTextBoxColumn";
            this.payPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // payReceiveDataGridViewTextBoxColumn
            // 
            this.payReceiveDataGridViewTextBoxColumn.DataPropertyName = "PayReceive";
            this.payReceiveDataGridViewTextBoxColumn.HeaderText = "PayReceive";
            this.payReceiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payReceiveDataGridViewTextBoxColumn.Name = "payReceiveDataGridViewTextBoxColumn";
            this.payReceiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // payExchangeDataGridViewTextBoxColumn
            // 
            this.payExchangeDataGridViewTextBoxColumn.DataPropertyName = "PayExchange";
            this.payExchangeDataGridViewTextBoxColumn.HeaderText = "PayExchange";
            this.payExchangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payExchangeDataGridViewTextBoxColumn.Name = "payExchangeDataGridViewTextBoxColumn";
            this.payExchangeDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // payBindingSource
            // 
            this.payBindingSource.DataMember = "Pay";
            this.payBindingSource.DataSource = this.cakeDBDataSetPay;
            // 
            // cakeDBDataSetPay
            // 
            this.cakeDBDataSetPay.DataSetName = "CakeDBDataSetPay";
            this.cakeDBDataSetPay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payIDTextBox
            // 
            this.payIDTextBox.Location = new System.Drawing.Point(189, 547);
            this.payIDTextBox.Name = "payIDTextBox";
            this.payIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.payIDTextBox.TabIndex = 4;
            // 
            // payTimeTextBox
            // 
            this.payTimeTextBox.Location = new System.Drawing.Point(189, 587);
            this.payTimeTextBox.Name = "payTimeTextBox";
            this.payTimeTextBox.Size = new System.Drawing.Size(200, 34);
            this.payTimeTextBox.TabIndex = 6;
            // 
            // payDateDateTimePicker
            // 
            this.payDateDateTimePicker.Location = new System.Drawing.Point(189, 627);
            this.payDateDateTimePicker.Name = "payDateDateTimePicker";
            this.payDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.payDateDateTimePicker.TabIndex = 8;
            // 
            // payReceiveTextBox
            // 
            this.payReceiveTextBox.Location = new System.Drawing.Point(590, 547);
            this.payReceiveTextBox.Name = "payReceiveTextBox";
            this.payReceiveTextBox.Size = new System.Drawing.Size(200, 34);
            this.payReceiveTextBox.TabIndex = 12;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(590, 587);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.orderIDTextBox.TabIndex = 16;
            // 
            // payTableAdapter
            // 
            this.payTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(903, 636);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(210, 39);
            this.buttonUpdate.TabIndex = 41;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(903, 590);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(210, 40);
            this.buttonDeL.TabIndex = 40;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(903, 544);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(210, 40);
            this.buttonInsert.TabIndex = 39;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "ข้อมูลซื้อเค้ก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "ข้อมูลการชำระ";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสการซื้อเค้ก",
            "หน้าเค้ก",
            "ชนิดของเค้ก",
            "จำนวน",
            "ราคา",
            "วันหมดอายุ",
            "รหัสเค้ก"});
            this.searchcomboBox.Location = new System.Drawing.Point(604, 4);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 45;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(911, 4);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 44;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(755, 7);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 43;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1066, 4);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 46;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1133, 707);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(payIDLabel);
            this.Controls.Add(this.payIDTextBox);
            this.Controls.Add(payTimeLabel);
            this.Controls.Add(this.payTimeTextBox);
            this.Controls.Add(payDateLabel);
            this.Controls.Add(this.payDateDateTimePicker);
            this.Controls.Add(payReceiveLabel);
            this.Controls.Add(this.payReceiveTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ชำระเงิน";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process05_FormClosing);
            this.Load += new System.EventHandler(this.Process05_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox payIDTextBox;
        private System.Windows.Forms.TextBox payTimeTextBox;
        private System.Windows.Forms.DateTimePicker payDateDateTimePicker;
        private System.Windows.Forms.TextBox payReceiveTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private CakeDBDataSetPay cakeDBDataSetPay;
        private System.Windows.Forms.BindingSource payBindingSource;
        private CakeDBDataSetPayTableAdapters.PayTableAdapter payTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn payIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payReceiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payExchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}