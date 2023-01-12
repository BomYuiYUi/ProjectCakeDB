
namespace CakeShop
{
    partial class Process08
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
            System.Windows.Forms.Label reqBuyIDLabel;
            System.Windows.Forms.Label reqBuyDateLabel;
            System.Windows.Forms.Label reqBuyNRMLabel;
            System.Windows.Forms.Label reqBuyNameLabel;
            System.Windows.Forms.Label reqBuyQuantityLabel;
            System.Windows.Forms.Label empIDLabel;
            this.dataGridRaw = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reqBuyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqBuyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqBuyNRMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqBuyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqBuyQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetReqBuy = new CakeShop.CakeDBDataSetReqBuy();
            this.reqBuyIDTextBox = new System.Windows.Forms.TextBox();
            this.reqBuyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reqBuyNRMTextBox = new System.Windows.Forms.TextBox();
            this.reqBuyNameTextBox = new System.Windows.Forms.TextBox();
            this.reqBuyQuantityTextBox = new System.Windows.Forms.TextBox();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.reqBuyTableAdapter = new CakeShop.CakeDBDataSetReqBuyTableAdapters.ReqBuyTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            reqBuyIDLabel = new System.Windows.Forms.Label();
            reqBuyDateLabel = new System.Windows.Forms.Label();
            reqBuyNRMLabel = new System.Windows.Forms.Label();
            reqBuyNameLabel = new System.Windows.Forms.Label();
            reqBuyQuantityLabel = new System.Windows.Forms.Label();
            empIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqBuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetReqBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // reqBuyIDLabel
            // 
            reqBuyIDLabel.AutoSize = true;
            reqBuyIDLabel.Location = new System.Drawing.Point(12, 630);
            reqBuyIDLabel.Name = "reqBuyIDLabel";
            reqBuyIDLabel.Size = new System.Drawing.Size(144, 29);
            reqBuyIDLabel.TabIndex = 3;
            reqBuyIDLabel.Text = "รหัสใบขอซื้อ :";
            // 
            // reqBuyDateLabel
            // 
            reqBuyDateLabel.AutoSize = true;
            reqBuyDateLabel.Location = new System.Drawing.Point(12, 671);
            reqBuyDateLabel.Name = "reqBuyDateLabel";
            reqBuyDateLabel.Size = new System.Drawing.Size(115, 29);
            reqBuyDateLabel.TabIndex = 5;
            reqBuyDateLabel.Text = "วันที่ขอซื้อ:";
            // 
            // reqBuyNRMLabel
            // 
            reqBuyNRMLabel.AutoSize = true;
            reqBuyNRMLabel.Location = new System.Drawing.Point(12, 710);
            reqBuyNRMLabel.Name = "reqBuyNRMLabel";
            reqBuyNRMLabel.Size = new System.Drawing.Size(110, 29);
            reqBuyNRMLabel.TabIndex = 7;
            reqBuyNRMLabel.Text = "ชื่อวัตถุดิบ:";
            // 
            // reqBuyNameLabel
            // 
            reqBuyNameLabel.AutoSize = true;
            reqBuyNameLabel.Location = new System.Drawing.Point(12, 750);
            reqBuyNameLabel.Name = "reqBuyNameLabel";
            reqBuyNameLabel.Size = new System.Drawing.Size(112, 29);
            reqBuyNameLabel.TabIndex = 9;
            reqBuyNameLabel.Text = "ชื่อผู้ขอซื้อ:";
            // 
            // reqBuyQuantityLabel
            // 
            reqBuyQuantityLabel.AutoSize = true;
            reqBuyQuantityLabel.Location = new System.Drawing.Point(437, 630);
            reqBuyQuantityLabel.Name = "reqBuyQuantityLabel";
            reqBuyQuantityLabel.Size = new System.Drawing.Size(84, 29);
            reqBuyQuantityLabel.TabIndex = 11;
            reqBuyQuantityLabel.Text = "จำนวน:";
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(437, 670);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(141, 29);
            empIDLabel.TabIndex = 13;
            empIDLabel.Text = "รหัสพนักงาน:";
            // 
            // dataGridRaw
            // 
            this.dataGridRaw.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRaw.Location = new System.Drawing.Point(12, 56);
            this.dataGridRaw.Name = "dataGridRaw";
            this.dataGridRaw.RowHeadersWidth = 51;
            this.dataGridRaw.RowTemplate.Height = 24;
            this.dataGridRaw.Size = new System.Drawing.Size(1068, 311);
            this.dataGridRaw.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqBuyIDDataGridViewTextBoxColumn,
            this.reqBuyDateDataGridViewTextBoxColumn,
            this.reqBuyNRMDataGridViewTextBoxColumn,
            this.reqBuyNameDataGridViewTextBoxColumn,
            this.reqBuyQuantityDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reqBuyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 194);
            this.dataGridView1.TabIndex = 2;
            // 
            // reqBuyIDDataGridViewTextBoxColumn
            // 
            this.reqBuyIDDataGridViewTextBoxColumn.DataPropertyName = "ReqBuyID";
            this.reqBuyIDDataGridViewTextBoxColumn.HeaderText = "ReqBuyID";
            this.reqBuyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqBuyIDDataGridViewTextBoxColumn.Name = "reqBuyIDDataGridViewTextBoxColumn";
            this.reqBuyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqBuyDateDataGridViewTextBoxColumn
            // 
            this.reqBuyDateDataGridViewTextBoxColumn.DataPropertyName = "ReqBuyDate";
            this.reqBuyDateDataGridViewTextBoxColumn.HeaderText = "ReqBuyDate";
            this.reqBuyDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqBuyDateDataGridViewTextBoxColumn.Name = "reqBuyDateDataGridViewTextBoxColumn";
            this.reqBuyDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqBuyNRMDataGridViewTextBoxColumn
            // 
            this.reqBuyNRMDataGridViewTextBoxColumn.DataPropertyName = "ReqBuyNRM";
            this.reqBuyNRMDataGridViewTextBoxColumn.HeaderText = "ReqBuyNRM";
            this.reqBuyNRMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqBuyNRMDataGridViewTextBoxColumn.Name = "reqBuyNRMDataGridViewTextBoxColumn";
            this.reqBuyNRMDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqBuyNameDataGridViewTextBoxColumn
            // 
            this.reqBuyNameDataGridViewTextBoxColumn.DataPropertyName = "ReqBuyName";
            this.reqBuyNameDataGridViewTextBoxColumn.HeaderText = "ReqBuyName";
            this.reqBuyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqBuyNameDataGridViewTextBoxColumn.Name = "reqBuyNameDataGridViewTextBoxColumn";
            this.reqBuyNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqBuyQuantityDataGridViewTextBoxColumn
            // 
            this.reqBuyQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReqBuyQuantity";
            this.reqBuyQuantityDataGridViewTextBoxColumn.HeaderText = "ReqBuyQuantity";
            this.reqBuyQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqBuyQuantityDataGridViewTextBoxColumn.Name = "reqBuyQuantityDataGridViewTextBoxColumn";
            this.reqBuyQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqBuyBindingSource
            // 
            this.reqBuyBindingSource.DataMember = "ReqBuy";
            this.reqBuyBindingSource.DataSource = this.cakeDBDataSetReqBuy;
            // 
            // cakeDBDataSetReqBuy
            // 
            this.cakeDBDataSetReqBuy.DataSetName = "CakeDBDataSetReqBuy";
            this.cakeDBDataSetReqBuy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reqBuyIDTextBox
            // 
            this.reqBuyIDTextBox.Location = new System.Drawing.Point(221, 627);
            this.reqBuyIDTextBox.Name = "reqBuyIDTextBox";
            this.reqBuyIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqBuyIDTextBox.TabIndex = 4;
            // 
            // reqBuyDateDateTimePicker
            // 
            this.reqBuyDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reqBuyDateDateTimePicker.Location = new System.Drawing.Point(221, 667);
            this.reqBuyDateDateTimePicker.Name = "reqBuyDateDateTimePicker";
            this.reqBuyDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.reqBuyDateDateTimePicker.TabIndex = 6;
            // 
            // reqBuyNRMTextBox
            // 
            this.reqBuyNRMTextBox.Location = new System.Drawing.Point(221, 707);
            this.reqBuyNRMTextBox.Name = "reqBuyNRMTextBox";
            this.reqBuyNRMTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqBuyNRMTextBox.TabIndex = 8;
            // 
            // reqBuyNameTextBox
            // 
            this.reqBuyNameTextBox.Location = new System.Drawing.Point(221, 747);
            this.reqBuyNameTextBox.Name = "reqBuyNameTextBox";
            this.reqBuyNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqBuyNameTextBox.TabIndex = 10;
            // 
            // reqBuyQuantityTextBox
            // 
            this.reqBuyQuantityTextBox.Location = new System.Drawing.Point(646, 627);
            this.reqBuyQuantityTextBox.Name = "reqBuyQuantityTextBox";
            this.reqBuyQuantityTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqBuyQuantityTextBox.TabIndex = 12;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(646, 667);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.empIDTextBox.TabIndex = 14;
            // 
            // reqBuyTableAdapter
            // 
            this.reqBuyTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(852, 716);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(244, 39);
            this.buttonUpdate.TabIndex = 35;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(852, 670);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(244, 40);
            this.buttonDeL.TabIndex = 34;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(852, 624);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(244, 40);
            this.buttonInsert.TabIndex = 33;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "ข้อมูลวัตถุดิบ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "ข้อมูลใบขอซื้อ";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสวัตถุดิบ",
            "รายการ",
            "ราคา",
            "วันหมดอายุ",
            "ชนิด",
            "ชื่อวัตถุดิบ",
            "รหัสเบิกวัตถุดิบ",
            "รหัสใบสั่งซื้อ"});
            this.searchcomboBox.Location = new System.Drawing.Point(571, 14);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 42;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(878, 13);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 41;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(722, 16);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 40;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1033, 13);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 47;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1100, 795);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(reqBuyIDLabel);
            this.Controls.Add(this.reqBuyIDTextBox);
            this.Controls.Add(reqBuyDateLabel);
            this.Controls.Add(this.reqBuyDateDateTimePicker);
            this.Controls.Add(reqBuyNRMLabel);
            this.Controls.Add(this.reqBuyNRMTextBox);
            this.Controls.Add(reqBuyNameLabel);
            this.Controls.Add(this.reqBuyNameTextBox);
            this.Controls.Add(reqBuyQuantityLabel);
            this.Controls.Add(this.reqBuyQuantityTextBox);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridRaw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ขอซื้อวัตถุดิบ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process08_FormClosing);
            this.Load += new System.EventHandler(this.Process08_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqBuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetReqBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRaw;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox reqBuyIDTextBox;
        private System.Windows.Forms.DateTimePicker reqBuyDateDateTimePicker;
        private System.Windows.Forms.TextBox reqBuyNRMTextBox;
        private System.Windows.Forms.TextBox reqBuyNameTextBox;
        private System.Windows.Forms.TextBox reqBuyQuantityTextBox;
        private System.Windows.Forms.TextBox empIDTextBox;
        private CakeDBDataSetReqBuy cakeDBDataSetReqBuy;
        private System.Windows.Forms.BindingSource reqBuyBindingSource;
        private CakeDBDataSetReqBuyTableAdapters.ReqBuyTableAdapter reqBuyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqBuyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqBuyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqBuyNRMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqBuyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqBuyQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
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