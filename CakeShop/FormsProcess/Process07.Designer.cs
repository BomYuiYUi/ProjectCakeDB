
namespace CakeShop
{
    partial class Process07
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
            System.Windows.Forms.Label reqIDLabel;
            System.Windows.Forms.Label reqDateLabel;
            System.Windows.Forms.Label reqNRMLabel;
            System.Windows.Forms.Label reqNameLabel;
            System.Windows.Forms.Label reqQuantityLabel;
            System.Windows.Forms.Label empIDLabel;
            this.dataGridRaw = new System.Windows.Forms.DataGridView();
            this.reqIDTextBox = new System.Windows.Forms.TextBox();
            this.reqDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reqNRMTextBox = new System.Windows.Forms.TextBox();
            this.reqNameTextBox = new System.Windows.Forms.TextBox();
            this.reqQuantityTextBox = new System.Windows.Forms.TextBox();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reqIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqNRMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetRequisition = new CakeShop.CakeDBDataSetRequisition();
            this.requisitionTableAdapter = new CakeShop.CakeDBDataSetRequisitionTableAdapters.RequisitionTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            reqIDLabel = new System.Windows.Forms.Label();
            reqDateLabel = new System.Windows.Forms.Label();
            reqNRMLabel = new System.Windows.Forms.Label();
            reqNameLabel = new System.Windows.Forms.Label();
            reqQuantityLabel = new System.Windows.Forms.Label();
            empIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetRequisition)).BeginInit();
            this.SuspendLayout();
            // 
            // reqIDLabel
            // 
            reqIDLabel.AutoSize = true;
            reqIDLabel.Location = new System.Drawing.Point(12, 651);
            reqIDLabel.Name = "reqIDLabel";
            reqIDLabel.Size = new System.Drawing.Size(167, 29);
            reqIDLabel.TabIndex = 2;
            reqIDLabel.Text = "รหัสเบิกวัตถุดิบ :";
            // 
            // reqDateLabel
            // 
            reqDateLabel.AutoSize = true;
            reqDateLabel.Location = new System.Drawing.Point(12, 692);
            reqDateLabel.Name = "reqDateLabel";
            reqDateLabel.Size = new System.Drawing.Size(123, 29);
            reqDateLabel.TabIndex = 4;
            reqDateLabel.Text = "วันที่ขอเบิก:";
            // 
            // reqNRMLabel
            // 
            reqNRMLabel.AutoSize = true;
            reqNRMLabel.Location = new System.Drawing.Point(12, 731);
            reqNRMLabel.Name = "reqNRMLabel";
            reqNRMLabel.Size = new System.Drawing.Size(110, 29);
            reqNRMLabel.TabIndex = 6;
            reqNRMLabel.Text = "ชื่อวัตถุดิบ:";
            // 
            // reqNameLabel
            // 
            reqNameLabel.AutoSize = true;
            reqNameLabel.Location = new System.Drawing.Point(12, 771);
            reqNameLabel.Name = "reqNameLabel";
            reqNameLabel.Size = new System.Drawing.Size(100, 29);
            reqNameLabel.TabIndex = 8;
            reqNameLabel.Text = "ชื่อผู้เบิก :";
            // 
            // reqQuantityLabel
            // 
            reqQuantityLabel.AutoSize = true;
            reqQuantityLabel.Location = new System.Drawing.Point(403, 651);
            reqQuantityLabel.Name = "reqQuantityLabel";
            reqQuantityLabel.Size = new System.Drawing.Size(90, 29);
            reqQuantityLabel.TabIndex = 10;
            reqQuantityLabel.Text = "จำนวน :";
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(403, 691);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(141, 29);
            empIDLabel.TabIndex = 12;
            empIDLabel.Text = "รหัสพนักงาน:";
            // 
            // dataGridRaw
            // 
            this.dataGridRaw.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRaw.Location = new System.Drawing.Point(12, 68);
            this.dataGridRaw.Name = "dataGridRaw";
            this.dataGridRaw.RowHeadersWidth = 51;
            this.dataGridRaw.RowTemplate.Height = 24;
            this.dataGridRaw.Size = new System.Drawing.Size(1068, 295);
            this.dataGridRaw.TabIndex = 0;
            // 
            // reqIDTextBox
            // 
            this.reqIDTextBox.Location = new System.Drawing.Point(182, 648);
            this.reqIDTextBox.Name = "reqIDTextBox";
            this.reqIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqIDTextBox.TabIndex = 3;
            // 
            // reqDateDateTimePicker
            // 
            this.reqDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reqDateDateTimePicker.Location = new System.Drawing.Point(182, 688);
            this.reqDateDateTimePicker.Name = "reqDateDateTimePicker";
            this.reqDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.reqDateDateTimePicker.TabIndex = 5;
            // 
            // reqNRMTextBox
            // 
            this.reqNRMTextBox.Location = new System.Drawing.Point(182, 728);
            this.reqNRMTextBox.Name = "reqNRMTextBox";
            this.reqNRMTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqNRMTextBox.TabIndex = 7;
            // 
            // reqNameTextBox
            // 
            this.reqNameTextBox.Location = new System.Drawing.Point(182, 768);
            this.reqNameTextBox.Name = "reqNameTextBox";
            this.reqNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqNameTextBox.TabIndex = 9;
            // 
            // reqQuantityTextBox
            // 
            this.reqQuantityTextBox.Location = new System.Drawing.Point(559, 648);
            this.reqQuantityTextBox.Name = "reqQuantityTextBox";
            this.reqQuantityTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqQuantityTextBox.TabIndex = 11;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(559, 688);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.empIDTextBox.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqIDDataGridViewTextBoxColumn,
            this.reqDateDataGridViewTextBoxColumn,
            this.reqNRMDataGridViewTextBoxColumn,
            this.reqNameDataGridViewTextBoxColumn,
            this.reqQuantityDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requisitionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 230);
            this.dataGridView1.TabIndex = 14;
            // 
            // reqIDDataGridViewTextBoxColumn
            // 
            this.reqIDDataGridViewTextBoxColumn.DataPropertyName = "ReqID";
            this.reqIDDataGridViewTextBoxColumn.HeaderText = "ReqID";
            this.reqIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqIDDataGridViewTextBoxColumn.Name = "reqIDDataGridViewTextBoxColumn";
            this.reqIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqDateDataGridViewTextBoxColumn
            // 
            this.reqDateDataGridViewTextBoxColumn.DataPropertyName = "ReqDate";
            this.reqDateDataGridViewTextBoxColumn.HeaderText = "ReqDate";
            this.reqDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqDateDataGridViewTextBoxColumn.Name = "reqDateDataGridViewTextBoxColumn";
            this.reqDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqNRMDataGridViewTextBoxColumn
            // 
            this.reqNRMDataGridViewTextBoxColumn.DataPropertyName = "ReqNRM";
            this.reqNRMDataGridViewTextBoxColumn.HeaderText = "ReqNRM";
            this.reqNRMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqNRMDataGridViewTextBoxColumn.Name = "reqNRMDataGridViewTextBoxColumn";
            this.reqNRMDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqNameDataGridViewTextBoxColumn
            // 
            this.reqNameDataGridViewTextBoxColumn.DataPropertyName = "ReqName";
            this.reqNameDataGridViewTextBoxColumn.HeaderText = "ReqName";
            this.reqNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqNameDataGridViewTextBoxColumn.Name = "reqNameDataGridViewTextBoxColumn";
            this.reqNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqQuantityDataGridViewTextBoxColumn
            // 
            this.reqQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReqQuantity";
            this.reqQuantityDataGridViewTextBoxColumn.HeaderText = "ReqQuantity";
            this.reqQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqQuantityDataGridViewTextBoxColumn.Name = "reqQuantityDataGridViewTextBoxColumn";
            this.reqQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // requisitionBindingSource
            // 
            this.requisitionBindingSource.DataMember = "Requisition";
            this.requisitionBindingSource.DataSource = this.cakeDBDataSetRequisition;
            // 
            // cakeDBDataSetRequisition
            // 
            this.cakeDBDataSetRequisition.DataSetName = "CakeDBDataSetRequisition";
            this.cakeDBDataSetRequisition.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisitionTableAdapter
            // 
            this.requisitionTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(791, 737);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(244, 39);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(791, 691);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(244, 40);
            this.buttonDeL.TabIndex = 31;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(791, 645);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(244, 40);
            this.buttonInsert.TabIndex = 30;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ข้อมูลวัตถุดิบ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "ข้อมูลเบิกวัตถุดิบ";
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
            this.searchcomboBox.Location = new System.Drawing.Point(571, 19);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 39;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(878, 18);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 38;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(722, 21);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 37;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1033, 18);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 47;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1100, 805);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(reqIDLabel);
            this.Controls.Add(this.reqIDTextBox);
            this.Controls.Add(reqDateLabel);
            this.Controls.Add(this.reqDateDateTimePicker);
            this.Controls.Add(reqNRMLabel);
            this.Controls.Add(this.reqNRMTextBox);
            this.Controls.Add(reqNameLabel);
            this.Controls.Add(this.reqNameTextBox);
            this.Controls.Add(reqQuantityLabel);
            this.Controls.Add(this.reqQuantityTextBox);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.dataGridRaw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เบิกวัตถุดิบ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process07_FormClosing);
            this.Load += new System.EventHandler(this.Process07_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetRequisition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRaw;
        private System.Windows.Forms.TextBox reqIDTextBox;
        private System.Windows.Forms.DateTimePicker reqDateDateTimePicker;
        private System.Windows.Forms.TextBox reqNRMTextBox;
        private System.Windows.Forms.TextBox reqNameTextBox;
        private System.Windows.Forms.TextBox reqQuantityTextBox;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CakeDBDataSetRequisition cakeDBDataSetRequisition;
        private System.Windows.Forms.BindingSource requisitionBindingSource;
        private CakeDBDataSetRequisitionTableAdapters.RequisitionTableAdapter requisitionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqNRMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqQuantityDataGridViewTextBoxColumn;
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