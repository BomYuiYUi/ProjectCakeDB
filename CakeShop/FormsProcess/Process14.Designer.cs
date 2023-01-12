
namespace CakeShop
{
    partial class Process14
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
            System.Windows.Forms.Label incomeIDLabel;
            System.Windows.Forms.Label incomeApproverLabel;
            System.Windows.Forms.Label incomeDateLabel;
            System.Windows.Forms.Label incomePriceLabel;
            System.Windows.Forms.Label incomeNameLabel;
            System.Windows.Forms.Label payIDLabel;
            this.dataGridPay = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.incomeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeApproverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetIncome = new CakeShop.CakeDBDataSetIncome();
            this.incomeIDTextBox = new System.Windows.Forms.TextBox();
            this.incomeApproverTextBox = new System.Windows.Forms.TextBox();
            this.incomeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.incomePriceTextBox = new System.Windows.Forms.TextBox();
            this.incomeNameTextBox = new System.Windows.Forms.TextBox();
            this.payIDTextBox = new System.Windows.Forms.TextBox();
            this.incomeTableAdapter = new CakeShop.CakeDBDataSetIncomeTableAdapters.IncomeTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            incomeIDLabel = new System.Windows.Forms.Label();
            incomeApproverLabel = new System.Windows.Forms.Label();
            incomeDateLabel = new System.Windows.Forms.Label();
            incomePriceLabel = new System.Windows.Forms.Label();
            incomeNameLabel = new System.Windows.Forms.Label();
            payIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeIDLabel
            // 
            incomeIDLabel.AutoSize = true;
            incomeIDLabel.Location = new System.Drawing.Point(12, 468);
            incomeIDLabel.Name = "incomeIDLabel";
            incomeIDLabel.Size = new System.Drawing.Size(128, 29);
            incomeIDLabel.TabIndex = 3;
            incomeIDLabel.Text = "รหัสรายรับ :";
            // 
            // incomeApproverLabel
            // 
            incomeApproverLabel.AutoSize = true;
            incomeApproverLabel.Location = new System.Drawing.Point(12, 508);
            incomeApproverLabel.Name = "incomeApproverLabel";
            incomeApproverLabel.Size = new System.Drawing.Size(94, 29);
            incomeApproverLabel.TabIndex = 5;
            incomeApproverLabel.Text = "ผู้อนุมัติ :";
            // 
            // incomeDateLabel
            // 
            incomeDateLabel.AutoSize = true;
            incomeDateLabel.Location = new System.Drawing.Point(12, 549);
            incomeDateLabel.Name = "incomeDateLabel";
            incomeDateLabel.Size = new System.Drawing.Size(129, 29);
            incomeDateLabel.TabIndex = 7;
            incomeDateLabel.Text = "วันที่รับเงิน :";
            // 
            // incomePriceLabel
            // 
            incomePriceLabel.AutoSize = true;
            incomePriceLabel.Location = new System.Drawing.Point(12, 588);
            incomePriceLabel.Name = "incomePriceLabel";
            incomePriceLabel.Size = new System.Drawing.Size(164, 29);
            incomePriceLabel.TabIndex = 9;
            incomePriceLabel.Text = "จำนวนเงินที่ได้ :";
            // 
            // incomeNameLabel
            // 
            incomeNameLabel.AutoSize = true;
            incomeNameLabel.Location = new System.Drawing.Point(12, 628);
            incomeNameLabel.Name = "incomeNameLabel";
            incomeNameLabel.Size = new System.Drawing.Size(107, 29);
            incomeNameLabel.TabIndex = 11;
            incomeNameLabel.Text = "ชื่อคนรับ :";
            // 
            // payIDLabel
            // 
            payIDLabel.AutoSize = true;
            payIDLabel.Location = new System.Drawing.Point(12, 668);
            payIDLabel.Name = "payIDLabel";
            payIDLabel.Size = new System.Drawing.Size(148, 29);
            payIDLabel.TabIndex = 13;
            payIDLabel.Text = "รหัสการชำระ :";
            // 
            // dataGridPay
            // 
            this.dataGridPay.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPay.Location = new System.Drawing.Point(12, 47);
            this.dataGridPay.Name = "dataGridPay";
            this.dataGridPay.RowHeadersWidth = 51;
            this.dataGridPay.RowTemplate.Height = 24;
            this.dataGridPay.Size = new System.Drawing.Size(1121, 186);
            this.dataGridPay.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomeIDDataGridViewTextBoxColumn,
            this.incomeApproverDataGridViewTextBoxColumn,
            this.incomeDateDataGridViewTextBoxColumn,
            this.incomePriceDataGridViewTextBoxColumn,
            this.incomeNameDataGridViewTextBoxColumn,
            this.payIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.incomeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 273);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1121, 186);
            this.dataGridView2.TabIndex = 0;
            // 
            // incomeIDDataGridViewTextBoxColumn
            // 
            this.incomeIDDataGridViewTextBoxColumn.DataPropertyName = "IncomeID";
            this.incomeIDDataGridViewTextBoxColumn.HeaderText = "IncomeID";
            this.incomeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeIDDataGridViewTextBoxColumn.Name = "incomeIDDataGridViewTextBoxColumn";
            this.incomeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomeApproverDataGridViewTextBoxColumn
            // 
            this.incomeApproverDataGridViewTextBoxColumn.DataPropertyName = "IncomeApprover";
            this.incomeApproverDataGridViewTextBoxColumn.HeaderText = "IncomeApprover";
            this.incomeApproverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeApproverDataGridViewTextBoxColumn.Name = "incomeApproverDataGridViewTextBoxColumn";
            this.incomeApproverDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomeDateDataGridViewTextBoxColumn
            // 
            this.incomeDateDataGridViewTextBoxColumn.DataPropertyName = "IncomeDate";
            this.incomeDateDataGridViewTextBoxColumn.HeaderText = "IncomeDate";
            this.incomeDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeDateDataGridViewTextBoxColumn.Name = "incomeDateDataGridViewTextBoxColumn";
            this.incomeDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomePriceDataGridViewTextBoxColumn
            // 
            this.incomePriceDataGridViewTextBoxColumn.DataPropertyName = "IncomePrice";
            this.incomePriceDataGridViewTextBoxColumn.HeaderText = "IncomePrice";
            this.incomePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomePriceDataGridViewTextBoxColumn.Name = "incomePriceDataGridViewTextBoxColumn";
            this.incomePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomeNameDataGridViewTextBoxColumn
            // 
            this.incomeNameDataGridViewTextBoxColumn.DataPropertyName = "IncomeName";
            this.incomeNameDataGridViewTextBoxColumn.HeaderText = "IncomeName";
            this.incomeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeNameDataGridViewTextBoxColumn.Name = "incomeNameDataGridViewTextBoxColumn";
            this.incomeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // payIDDataGridViewTextBoxColumn
            // 
            this.payIDDataGridViewTextBoxColumn.DataPropertyName = "PayID";
            this.payIDDataGridViewTextBoxColumn.HeaderText = "PayID";
            this.payIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payIDDataGridViewTextBoxColumn.Name = "payIDDataGridViewTextBoxColumn";
            this.payIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            this.incomeBindingSource.DataSource = this.cakeDBDataSetIncome;
            // 
            // cakeDBDataSetIncome
            // 
            this.cakeDBDataSetIncome.DataSetName = "CakeDBDataSetIncome";
            this.cakeDBDataSetIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeIDTextBox
            // 
            this.incomeIDTextBox.Location = new System.Drawing.Point(220, 465);
            this.incomeIDTextBox.Name = "incomeIDTextBox";
            this.incomeIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.incomeIDTextBox.TabIndex = 4;
            // 
            // incomeApproverTextBox
            // 
            this.incomeApproverTextBox.Location = new System.Drawing.Point(220, 505);
            this.incomeApproverTextBox.Name = "incomeApproverTextBox";
            this.incomeApproverTextBox.Size = new System.Drawing.Size(200, 34);
            this.incomeApproverTextBox.TabIndex = 6;
            // 
            // incomeDateDateTimePicker
            // 
            this.incomeDateDateTimePicker.Location = new System.Drawing.Point(220, 545);
            this.incomeDateDateTimePicker.Name = "incomeDateDateTimePicker";
            this.incomeDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.incomeDateDateTimePicker.TabIndex = 8;
            // 
            // incomePriceTextBox
            // 
            this.incomePriceTextBox.Location = new System.Drawing.Point(220, 585);
            this.incomePriceTextBox.Name = "incomePriceTextBox";
            this.incomePriceTextBox.Size = new System.Drawing.Size(200, 34);
            this.incomePriceTextBox.TabIndex = 10;
            // 
            // incomeNameTextBox
            // 
            this.incomeNameTextBox.Location = new System.Drawing.Point(220, 625);
            this.incomeNameTextBox.Name = "incomeNameTextBox";
            this.incomeNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.incomeNameTextBox.TabIndex = 12;
            // 
            // payIDTextBox
            // 
            this.payIDTextBox.Location = new System.Drawing.Point(220, 665);
            this.payIDTextBox.Name = "payIDTextBox";
            this.payIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.payIDTextBox.TabIndex = 14;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(454, 557);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(178, 39);
            this.buttonUpdate.TabIndex = 41;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(454, 511);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(178, 40);
            this.buttonDeL.TabIndex = 40;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(454, 465);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(178, 40);
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
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "ข้อมูลการชำระ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "ข้อมูลรายรับ";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสการชำระ",
            "เวลาที่ชำระ",
            "วัน/เดือน/ปี",
            "จำนวนเงิน",
            "เงินที่ได้",
            "เงินทอน",
            "รหัสการซื้อเค้ก"});
            this.searchcomboBox.Location = new System.Drawing.Point(624, 3);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 45;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(931, 5);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 44;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(775, 6);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 43;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1086, 5);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 59;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1153, 710);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(incomeIDLabel);
            this.Controls.Add(this.incomeIDTextBox);
            this.Controls.Add(incomeApproverLabel);
            this.Controls.Add(this.incomeApproverTextBox);
            this.Controls.Add(incomeDateLabel);
            this.Controls.Add(this.incomeDateDateTimePicker);
            this.Controls.Add(incomePriceLabel);
            this.Controls.Add(this.incomePriceTextBox);
            this.Controls.Add(incomeNameLabel);
            this.Controls.Add(this.incomeNameTextBox);
            this.Controls.Add(payIDLabel);
            this.Controls.Add(this.payIDTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridPay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายรับ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process14_FormClosing);
            this.Load += new System.EventHandler(this.Process14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox incomeIDTextBox;
        private System.Windows.Forms.TextBox incomeApproverTextBox;
        private System.Windows.Forms.DateTimePicker incomeDateDateTimePicker;
        private System.Windows.Forms.TextBox incomePriceTextBox;
        private System.Windows.Forms.TextBox incomeNameTextBox;
        private System.Windows.Forms.TextBox payIDTextBox;
        private CakeDBDataSetIncome cakeDBDataSetIncome;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private CakeDBDataSetIncomeTableAdapters.IncomeTableAdapter incomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeApproverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payIDDataGridViewTextBoxColumn;
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