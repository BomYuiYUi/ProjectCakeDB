
namespace CakeShop
{
    partial class Process15
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
            System.Windows.Forms.Label expenIDLabel;
            System.Windows.Forms.Label expenNameLabel;
            System.Windows.Forms.Label expenReqLabel;
            System.Windows.Forms.Label expenPriceLabel;
            System.Windows.Forms.Label expenDateLabel;
            System.Windows.Forms.Label expenApproverLabel;
            System.Windows.Forms.Label orderPayIDLabel;
            this.dataGridOrderPay = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.expenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenApproverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetExpenses = new CakeShop.CakeDBDataSetExpenses();
            this.expenIDTextBox = new System.Windows.Forms.TextBox();
            this.expenNameTextBox = new System.Windows.Forms.TextBox();
            this.expenReqTextBox = new System.Windows.Forms.TextBox();
            this.expenPriceTextBox = new System.Windows.Forms.TextBox();
            this.expenDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expenApproverTextBox = new System.Windows.Forms.TextBox();
            this.orderPayIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.expensesTableAdapter = new CakeShop.CakeDBDataSetExpensesTableAdapters.ExpensesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            expenIDLabel = new System.Windows.Forms.Label();
            expenNameLabel = new System.Windows.Forms.Label();
            expenReqLabel = new System.Windows.Forms.Label();
            expenPriceLabel = new System.Windows.Forms.Label();
            expenDateLabel = new System.Windows.Forms.Label();
            expenApproverLabel = new System.Windows.Forms.Label();
            orderPayIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // expenIDLabel
            // 
            expenIDLabel.AutoSize = true;
            expenIDLabel.Location = new System.Drawing.Point(11, 524);
            expenIDLabel.Name = "expenIDLabel";
            expenIDLabel.Size = new System.Drawing.Size(134, 29);
            expenIDLabel.TabIndex = 3;
            expenIDLabel.Text = "รหัสรายจ่าย :";
            // 
            // expenNameLabel
            // 
            expenNameLabel.AutoSize = true;
            expenNameLabel.Location = new System.Drawing.Point(11, 564);
            expenNameLabel.Name = "expenNameLabel";
            expenNameLabel.Size = new System.Drawing.Size(113, 29);
            expenNameLabel.TabIndex = 5;
            expenNameLabel.Text = "ชื่อคนจ่าย :";
            // 
            // expenReqLabel
            // 
            expenReqLabel.AutoSize = true;
            expenReqLabel.Location = new System.Drawing.Point(11, 604);
            expenReqLabel.Name = "expenReqLabel";
            expenReqLabel.Size = new System.Drawing.Size(104, 29);
            expenReqLabel.TabIndex = 7;
            expenReqLabel.Text = "คนที่เบิก :";
            // 
            // expenPriceLabel
            // 
            expenPriceLabel.AutoSize = true;
            expenPriceLabel.Location = new System.Drawing.Point(11, 644);
            expenPriceLabel.Name = "expenPriceLabel";
            expenPriceLabel.Size = new System.Drawing.Size(125, 29);
            expenPriceLabel.TabIndex = 9;
            expenPriceLabel.Text = "จำนวนเงิน :";
            // 
            // expenDateLabel
            // 
            expenDateLabel.AutoSize = true;
            expenDateLabel.Location = new System.Drawing.Point(435, 523);
            expenDateLabel.Name = "expenDateLabel";
            expenDateLabel.Size = new System.Drawing.Size(100, 29);
            expenDateLabel.TabIndex = 11;
            expenDateLabel.Text = "วันที่จ่าย :";
            // 
            // expenApproverLabel
            // 
            expenApproverLabel.AutoSize = true;
            expenApproverLabel.Location = new System.Drawing.Point(435, 562);
            expenApproverLabel.Name = "expenApproverLabel";
            expenApproverLabel.Size = new System.Drawing.Size(94, 29);
            expenApproverLabel.TabIndex = 13;
            expenApproverLabel.Text = "ผู้อนุมัติ :";
            // 
            // orderPayIDLabel
            // 
            orderPayIDLabel.AutoSize = true;
            orderPayIDLabel.Location = new System.Drawing.Point(435, 602);
            orderPayIDLabel.Name = "orderPayIDLabel";
            orderPayIDLabel.Size = new System.Drawing.Size(141, 29);
            orderPayIDLabel.TabIndex = 15;
            orderPayIDLabel.Text = "รหัสใบสั่งซื้อ :";
            // 
            // dataGridOrderPay
            // 
            this.dataGridOrderPay.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrderPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderPay.Location = new System.Drawing.Point(12, 54);
            this.dataGridOrderPay.Name = "dataGridOrderPay";
            this.dataGridOrderPay.RowHeadersWidth = 51;
            this.dataGridOrderPay.RowTemplate.Height = 24;
            this.dataGridOrderPay.Size = new System.Drawing.Size(1089, 197);
            this.dataGridOrderPay.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expenIDDataGridViewTextBoxColumn,
            this.expenNameDataGridViewTextBoxColumn,
            this.expenReqDataGridViewTextBoxColumn,
            this.expenPriceDataGridViewTextBoxColumn,
            this.expenDateDataGridViewTextBoxColumn,
            this.expenApproverDataGridViewTextBoxColumn,
            this.orderPayIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.expensesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1089, 197);
            this.dataGridView2.TabIndex = 0;
            // 
            // expenIDDataGridViewTextBoxColumn
            // 
            this.expenIDDataGridViewTextBoxColumn.DataPropertyName = "ExpenID";
            this.expenIDDataGridViewTextBoxColumn.HeaderText = "ExpenID";
            this.expenIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenIDDataGridViewTextBoxColumn.Name = "expenIDDataGridViewTextBoxColumn";
            this.expenIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenNameDataGridViewTextBoxColumn
            // 
            this.expenNameDataGridViewTextBoxColumn.DataPropertyName = "ExpenName";
            this.expenNameDataGridViewTextBoxColumn.HeaderText = "ExpenName";
            this.expenNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenNameDataGridViewTextBoxColumn.Name = "expenNameDataGridViewTextBoxColumn";
            this.expenNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenReqDataGridViewTextBoxColumn
            // 
            this.expenReqDataGridViewTextBoxColumn.DataPropertyName = "ExpenReq";
            this.expenReqDataGridViewTextBoxColumn.HeaderText = "ExpenReq";
            this.expenReqDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenReqDataGridViewTextBoxColumn.Name = "expenReqDataGridViewTextBoxColumn";
            this.expenReqDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenPriceDataGridViewTextBoxColumn
            // 
            this.expenPriceDataGridViewTextBoxColumn.DataPropertyName = "ExpenPrice";
            this.expenPriceDataGridViewTextBoxColumn.HeaderText = "ExpenPrice";
            this.expenPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenPriceDataGridViewTextBoxColumn.Name = "expenPriceDataGridViewTextBoxColumn";
            this.expenPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenDateDataGridViewTextBoxColumn
            // 
            this.expenDateDataGridViewTextBoxColumn.DataPropertyName = "ExpenDate";
            this.expenDateDataGridViewTextBoxColumn.HeaderText = "ExpenDate";
            this.expenDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenDateDataGridViewTextBoxColumn.Name = "expenDateDataGridViewTextBoxColumn";
            this.expenDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenApproverDataGridViewTextBoxColumn
            // 
            this.expenApproverDataGridViewTextBoxColumn.DataPropertyName = "ExpenApprover";
            this.expenApproverDataGridViewTextBoxColumn.HeaderText = "ExpenApprover";
            this.expenApproverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenApproverDataGridViewTextBoxColumn.Name = "expenApproverDataGridViewTextBoxColumn";
            this.expenApproverDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPayIDDataGridViewTextBoxColumn
            // 
            this.orderPayIDDataGridViewTextBoxColumn.DataPropertyName = "OrderPayID";
            this.orderPayIDDataGridViewTextBoxColumn.HeaderText = "OrderPayID";
            this.orderPayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPayIDDataGridViewTextBoxColumn.Name = "orderPayIDDataGridViewTextBoxColumn";
            this.orderPayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.cakeDBDataSetExpenses;
            // 
            // cakeDBDataSetExpenses
            // 
            this.cakeDBDataSetExpenses.DataSetName = "CakeDBDataSetExpenses";
            this.cakeDBDataSetExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenIDTextBox
            // 
            this.expenIDTextBox.Location = new System.Drawing.Point(208, 521);
            this.expenIDTextBox.Name = "expenIDTextBox";
            this.expenIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.expenIDTextBox.TabIndex = 4;
            // 
            // expenNameTextBox
            // 
            this.expenNameTextBox.Location = new System.Drawing.Point(208, 561);
            this.expenNameTextBox.Name = "expenNameTextBox";
            this.expenNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.expenNameTextBox.TabIndex = 6;
            // 
            // expenReqTextBox
            // 
            this.expenReqTextBox.Location = new System.Drawing.Point(208, 601);
            this.expenReqTextBox.Name = "expenReqTextBox";
            this.expenReqTextBox.Size = new System.Drawing.Size(200, 34);
            this.expenReqTextBox.TabIndex = 8;
            // 
            // expenPriceTextBox
            // 
            this.expenPriceTextBox.Location = new System.Drawing.Point(208, 641);
            this.expenPriceTextBox.Name = "expenPriceTextBox";
            this.expenPriceTextBox.Size = new System.Drawing.Size(200, 34);
            this.expenPriceTextBox.TabIndex = 10;
            // 
            // expenDateDateTimePicker
            // 
            this.expenDateDateTimePicker.Location = new System.Drawing.Point(632, 519);
            this.expenDateDateTimePicker.Name = "expenDateDateTimePicker";
            this.expenDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.expenDateDateTimePicker.TabIndex = 12;
            // 
            // expenApproverTextBox
            // 
            this.expenApproverTextBox.Location = new System.Drawing.Point(632, 559);
            this.expenApproverTextBox.Name = "expenApproverTextBox";
            this.expenApproverTextBox.Size = new System.Drawing.Size(200, 34);
            this.expenApproverTextBox.TabIndex = 14;
            // 
            // orderPayIDTextBox
            // 
            this.orderPayIDTextBox.Location = new System.Drawing.Point(632, 599);
            this.orderPayIDTextBox.Name = "orderPayIDTextBox";
            this.orderPayIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.orderPayIDTextBox.TabIndex = 16;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(923, 605);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(178, 39);
            this.buttonUpdate.TabIndex = 41;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(923, 559);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(178, 40);
            this.buttonDeL.TabIndex = 40;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(923, 513);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(178, 40);
            this.buttonInsert.TabIndex = 39;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "ข้อมูลใบสั่งซื้อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "ข้อมูลจ่าย";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสใบสั่งซื้อ",
            "ชื่อวัตถุดิบ",
            "ราคา",
            "จำนวน",
            "รหัสใบขอซื้อ"});
            this.searchcomboBox.Location = new System.Drawing.Point(595, 6);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 46;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(902, 9);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 45;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(746, 9);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 44;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1057, 9);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 60;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1122, 700);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(expenIDLabel);
            this.Controls.Add(this.expenIDTextBox);
            this.Controls.Add(expenNameLabel);
            this.Controls.Add(this.expenNameTextBox);
            this.Controls.Add(expenReqLabel);
            this.Controls.Add(this.expenReqTextBox);
            this.Controls.Add(expenPriceLabel);
            this.Controls.Add(this.expenPriceTextBox);
            this.Controls.Add(expenDateLabel);
            this.Controls.Add(this.expenDateDateTimePicker);
            this.Controls.Add(expenApproverLabel);
            this.Controls.Add(this.expenApproverTextBox);
            this.Controls.Add(orderPayIDLabel);
            this.Controls.Add(this.orderPayIDTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridOrderPay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายจ่าย";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process15_FormClosing);
            this.Load += new System.EventHandler(this.Process15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrderPay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox expenIDTextBox;
        private System.Windows.Forms.TextBox expenNameTextBox;
        private System.Windows.Forms.TextBox expenReqTextBox;
        private System.Windows.Forms.TextBox expenPriceTextBox;
        private System.Windows.Forms.DateTimePicker expenDateDateTimePicker;
        private System.Windows.Forms.TextBox expenApproverTextBox;
        private System.Windows.Forms.TextBox orderPayIDTextBox;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private CakeDBDataSetExpenses cakeDBDataSetExpenses;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private CakeDBDataSetExpensesTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenReqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenApproverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}