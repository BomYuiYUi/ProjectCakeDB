
namespace CakeShop
{
    partial class Process11
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
            System.Windows.Forms.Label rmaterialIDLabel;
            System.Windows.Forms.Label rmaterialQuantityLabel;
            System.Windows.Forms.Label rmaterialPriceLabel;
            System.Windows.Forms.Label rmaterialExpLabel;
            System.Windows.Forms.Label rmaterialTypeLabel;
            System.Windows.Forms.Label rmaterialNameLabel;
            System.Windows.Forms.Label reqIDLabel;
            System.Windows.Forms.Label orderPayIDLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rmaterialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmaterialQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmaterialPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmaterialExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmaterialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmaterialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetRmaterial = new CakeShop.CakeDBDataSetRmaterial();
            this.rmaterialIDTextBox = new System.Windows.Forms.TextBox();
            this.rmaterialQuantityTextBox = new System.Windows.Forms.TextBox();
            this.rmaterialPriceTextBox = new System.Windows.Forms.TextBox();
            this.rmaterialExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rmaterialTypeTextBox = new System.Windows.Forms.TextBox();
            this.rmaterialNameTextBox = new System.Windows.Forms.TextBox();
            this.reqIDTextBox = new System.Windows.Forms.TextBox();
            this.orderPayIDTextBox = new System.Windows.Forms.TextBox();
            this.rmaterialTableAdapter = new CakeShop.CakeDBDataSetRmaterialTableAdapters.RmaterialTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            rmaterialIDLabel = new System.Windows.Forms.Label();
            rmaterialQuantityLabel = new System.Windows.Forms.Label();
            rmaterialPriceLabel = new System.Windows.Forms.Label();
            rmaterialExpLabel = new System.Windows.Forms.Label();
            rmaterialTypeLabel = new System.Windows.Forms.Label();
            rmaterialNameLabel = new System.Windows.Forms.Label();
            reqIDLabel = new System.Windows.Forms.Label();
            orderPayIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetRmaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // rmaterialIDLabel
            // 
            rmaterialIDLabel.AutoSize = true;
            rmaterialIDLabel.Location = new System.Drawing.Point(22, 427);
            rmaterialIDLabel.Name = "rmaterialIDLabel";
            rmaterialIDLabel.Size = new System.Drawing.Size(131, 29);
            rmaterialIDLabel.TabIndex = 2;
            rmaterialIDLabel.Text = "รหัสวัตถุดิบ :";
            // 
            // rmaterialQuantityLabel
            // 
            rmaterialQuantityLabel.AutoSize = true;
            rmaterialQuantityLabel.Location = new System.Drawing.Point(22, 467);
            rmaterialQuantityLabel.Name = "rmaterialQuantityLabel";
            rmaterialQuantityLabel.Size = new System.Drawing.Size(90, 29);
            rmaterialQuantityLabel.TabIndex = 4;
            rmaterialQuantityLabel.Text = "จำนวน :";
            // 
            // rmaterialPriceLabel
            // 
            rmaterialPriceLabel.AutoSize = true;
            rmaterialPriceLabel.Location = new System.Drawing.Point(22, 507);
            rmaterialPriceLabel.Name = "rmaterialPriceLabel";
            rmaterialPriceLabel.Size = new System.Drawing.Size(71, 29);
            rmaterialPriceLabel.TabIndex = 6;
            rmaterialPriceLabel.Text = "ราคา :";
            // 
            // rmaterialExpLabel
            // 
            rmaterialExpLabel.AutoSize = true;
            rmaterialExpLabel.Location = new System.Drawing.Point(22, 548);
            rmaterialExpLabel.Name = "rmaterialExpLabel";
            rmaterialExpLabel.Size = new System.Drawing.Size(130, 29);
            rmaterialExpLabel.TabIndex = 8;
            rmaterialExpLabel.Text = "วันหมดอายุ :";
            // 
            // rmaterialTypeLabel
            // 
            rmaterialTypeLabel.AutoSize = true;
            rmaterialTypeLabel.Location = new System.Drawing.Point(462, 427);
            rmaterialTypeLabel.Name = "rmaterialTypeLabel";
            rmaterialTypeLabel.Size = new System.Drawing.Size(132, 29);
            rmaterialTypeLabel.TabIndex = 10;
            rmaterialTypeLabel.Text = "ชนิดวัตถุดิบ :";
            // 
            // rmaterialNameLabel
            // 
            rmaterialNameLabel.AutoSize = true;
            rmaterialNameLabel.Location = new System.Drawing.Point(462, 467);
            rmaterialNameLabel.Name = "rmaterialNameLabel";
            rmaterialNameLabel.Size = new System.Drawing.Size(116, 29);
            rmaterialNameLabel.TabIndex = 12;
            rmaterialNameLabel.Text = "ชื่อวัตถุดิบ :";
            // 
            // reqIDLabel
            // 
            reqIDLabel.AutoSize = true;
            reqIDLabel.Location = new System.Drawing.Point(462, 507);
            reqIDLabel.Name = "reqIDLabel";
            reqIDLabel.Size = new System.Drawing.Size(167, 29);
            reqIDLabel.TabIndex = 14;
            reqIDLabel.Text = "รหัสเบิกวัตถุดิบ :";
            // 
            // orderPayIDLabel
            // 
            orderPayIDLabel.AutoSize = true;
            orderPayIDLabel.Location = new System.Drawing.Point(462, 547);
            orderPayIDLabel.Name = "orderPayIDLabel";
            orderPayIDLabel.Size = new System.Drawing.Size(141, 29);
            orderPayIDLabel.TabIndex = 16;
            orderPayIDLabel.Text = "รหัสใบสั่งซื้อ :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rmaterialIDDataGridViewTextBoxColumn,
            this.rmaterialQuantityDataGridViewTextBoxColumn,
            this.rmaterialPriceDataGridViewTextBoxColumn,
            this.rmaterialExpDataGridViewTextBoxColumn,
            this.rmaterialTypeDataGridViewTextBoxColumn,
            this.rmaterialNameDataGridViewTextBoxColumn,
            this.reqIDDataGridViewTextBoxColumn,
            this.orderPayIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rmaterialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // rmaterialIDDataGridViewTextBoxColumn
            // 
            this.rmaterialIDDataGridViewTextBoxColumn.DataPropertyName = "RmaterialID";
            this.rmaterialIDDataGridViewTextBoxColumn.HeaderText = "RmaterialID";
            this.rmaterialIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rmaterialIDDataGridViewTextBoxColumn.Name = "rmaterialIDDataGridViewTextBoxColumn";
            this.rmaterialIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rmaterialQuantityDataGridViewTextBoxColumn
            // 
            this.rmaterialQuantityDataGridViewTextBoxColumn.DataPropertyName = "RmaterialQuantity";
            this.rmaterialQuantityDataGridViewTextBoxColumn.HeaderText = "RmaterialQuantity";
            this.rmaterialQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rmaterialQuantityDataGridViewTextBoxColumn.Name = "rmaterialQuantityDataGridViewTextBoxColumn";
            this.rmaterialQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // rmaterialPriceDataGridViewTextBoxColumn
            // 
            this.rmaterialPriceDataGridViewTextBoxColumn.DataPropertyName = "RmaterialPrice";
            this.rmaterialPriceDataGridViewTextBoxColumn.HeaderText = "RmaterialPrice";
            this.rmaterialPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rmaterialPriceDataGridViewTextBoxColumn.Name = "rmaterialPriceDataGridViewTextBoxColumn";
            this.rmaterialPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // rmaterialExpDataGridViewTextBoxColumn
            // 
            this.rmaterialExpDataGridViewTextBoxColumn.DataPropertyName = "RmaterialExp";
            this.rmaterialExpDataGridViewTextBoxColumn.HeaderText = "RmaterialExp";
            this.rmaterialExpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rmaterialExpDataGridViewTextBoxColumn.Name = "rmaterialExpDataGridViewTextBoxColumn";
            this.rmaterialExpDataGridViewTextBoxColumn.Width = 125;
            // 
            // rmaterialTypeDataGridViewTextBoxColumn
            // 
            this.rmaterialTypeDataGridViewTextBoxColumn.DataPropertyName = "RmaterialType";
            this.rmaterialTypeDataGridViewTextBoxColumn.HeaderText = "RmaterialType";
            this.rmaterialTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rmaterialTypeDataGridViewTextBoxColumn.Name = "rmaterialTypeDataGridViewTextBoxColumn";
            this.rmaterialTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // rmaterialNameDataGridViewTextBoxColumn
            // 
            this.rmaterialNameDataGridViewTextBoxColumn.DataPropertyName = "RmaterialName";
            this.rmaterialNameDataGridViewTextBoxColumn.HeaderText = "RmaterialName";
            this.rmaterialNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rmaterialNameDataGridViewTextBoxColumn.Name = "rmaterialNameDataGridViewTextBoxColumn";
            this.rmaterialNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqIDDataGridViewTextBoxColumn
            // 
            this.reqIDDataGridViewTextBoxColumn.DataPropertyName = "ReqID";
            this.reqIDDataGridViewTextBoxColumn.HeaderText = "ReqID";
            this.reqIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqIDDataGridViewTextBoxColumn.Name = "reqIDDataGridViewTextBoxColumn";
            this.reqIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPayIDDataGridViewTextBoxColumn
            // 
            this.orderPayIDDataGridViewTextBoxColumn.DataPropertyName = "OrderPayID";
            this.orderPayIDDataGridViewTextBoxColumn.HeaderText = "OrderPayID";
            this.orderPayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPayIDDataGridViewTextBoxColumn.Name = "orderPayIDDataGridViewTextBoxColumn";
            this.orderPayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rmaterialBindingSource
            // 
            this.rmaterialBindingSource.DataMember = "Rmaterial";
            this.rmaterialBindingSource.DataSource = this.cakeDBDataSetRmaterial;
            // 
            // cakeDBDataSetRmaterial
            // 
            this.cakeDBDataSetRmaterial.DataSetName = "CakeDBDataSetRmaterial";
            this.cakeDBDataSetRmaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rmaterialIDTextBox
            // 
            this.rmaterialIDTextBox.Location = new System.Drawing.Point(243, 424);
            this.rmaterialIDTextBox.Name = "rmaterialIDTextBox";
            this.rmaterialIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.rmaterialIDTextBox.TabIndex = 3;
            // 
            // rmaterialQuantityTextBox
            // 
            this.rmaterialQuantityTextBox.Location = new System.Drawing.Point(243, 464);
            this.rmaterialQuantityTextBox.Name = "rmaterialQuantityTextBox";
            this.rmaterialQuantityTextBox.Size = new System.Drawing.Size(200, 34);
            this.rmaterialQuantityTextBox.TabIndex = 5;
            // 
            // rmaterialPriceTextBox
            // 
            this.rmaterialPriceTextBox.Location = new System.Drawing.Point(243, 504);
            this.rmaterialPriceTextBox.Name = "rmaterialPriceTextBox";
            this.rmaterialPriceTextBox.Size = new System.Drawing.Size(200, 34);
            this.rmaterialPriceTextBox.TabIndex = 7;
            // 
            // rmaterialExpDateTimePicker
            // 
            this.rmaterialExpDateTimePicker.Location = new System.Drawing.Point(243, 544);
            this.rmaterialExpDateTimePicker.Name = "rmaterialExpDateTimePicker";
            this.rmaterialExpDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.rmaterialExpDateTimePicker.TabIndex = 9;
            // 
            // rmaterialTypeTextBox
            // 
            this.rmaterialTypeTextBox.Location = new System.Drawing.Point(683, 424);
            this.rmaterialTypeTextBox.Name = "rmaterialTypeTextBox";
            this.rmaterialTypeTextBox.Size = new System.Drawing.Size(200, 34);
            this.rmaterialTypeTextBox.TabIndex = 11;
            // 
            // rmaterialNameTextBox
            // 
            this.rmaterialNameTextBox.Location = new System.Drawing.Point(683, 464);
            this.rmaterialNameTextBox.Name = "rmaterialNameTextBox";
            this.rmaterialNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.rmaterialNameTextBox.TabIndex = 13;
            // 
            // reqIDTextBox
            // 
            this.reqIDTextBox.Location = new System.Drawing.Point(683, 504);
            this.reqIDTextBox.Name = "reqIDTextBox";
            this.reqIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.reqIDTextBox.TabIndex = 15;
            // 
            // orderPayIDTextBox
            // 
            this.orderPayIDTextBox.Location = new System.Drawing.Point(683, 544);
            this.orderPayIDTextBox.Name = "orderPayIDTextBox";
            this.orderPayIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.orderPayIDTextBox.TabIndex = 17;
            // 
            // rmaterialTableAdapter
            // 
            this.rmaterialTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(924, 513);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(178, 39);
            this.buttonUpdate.TabIndex = 35;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(924, 467);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(178, 40);
            this.buttonDeL.TabIndex = 34;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(924, 421);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(178, 40);
            this.buttonInsert.TabIndex = 33;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "ข้อมูลวัตถุดิบ";
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
            this.searchcomboBox.Location = new System.Drawing.Point(593, 6);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 42;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(900, 6);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 41;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(744, 9);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 40;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1055, 6);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 49;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1116, 619);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(rmaterialIDLabel);
            this.Controls.Add(this.rmaterialIDTextBox);
            this.Controls.Add(rmaterialQuantityLabel);
            this.Controls.Add(this.rmaterialQuantityTextBox);
            this.Controls.Add(rmaterialPriceLabel);
            this.Controls.Add(this.rmaterialPriceTextBox);
            this.Controls.Add(rmaterialExpLabel);
            this.Controls.Add(this.rmaterialExpDateTimePicker);
            this.Controls.Add(rmaterialTypeLabel);
            this.Controls.Add(this.rmaterialTypeTextBox);
            this.Controls.Add(rmaterialNameLabel);
            this.Controls.Add(this.rmaterialNameTextBox);
            this.Controls.Add(reqIDLabel);
            this.Controls.Add(this.reqIDTextBox);
            this.Controls.Add(orderPayIDLabel);
            this.Controls.Add(this.orderPayIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "บันทึกวัตถุดิบ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process11_FormClosing);
            this.Load += new System.EventHandler(this.Process11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetRmaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox rmaterialIDTextBox;
        private System.Windows.Forms.TextBox rmaterialQuantityTextBox;
        private System.Windows.Forms.TextBox rmaterialPriceTextBox;
        private System.Windows.Forms.DateTimePicker rmaterialExpDateTimePicker;
        private System.Windows.Forms.TextBox rmaterialTypeTextBox;
        private System.Windows.Forms.TextBox rmaterialNameTextBox;
        private System.Windows.Forms.TextBox reqIDTextBox;
        private System.Windows.Forms.TextBox orderPayIDTextBox;
        private CakeDBDataSetRmaterial cakeDBDataSetRmaterial;
        private System.Windows.Forms.BindingSource rmaterialBindingSource;
        private CakeDBDataSetRmaterialTableAdapters.RmaterialTableAdapter rmaterialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaterialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaterialQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaterialPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaterialExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaterialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaterialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}