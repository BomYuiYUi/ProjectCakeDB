
namespace CakeShop
{
    partial class Process03
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
            System.Windows.Forms.Label madeIDLabel;
            System.Windows.Forms.Label madeTypeLabel;
            System.Windows.Forms.Label madeDateLabel;
            System.Windows.Forms.Label madePriceLabel;
            System.Windows.Forms.Label madeStatusLabel;
            System.Windows.Forms.Label madeStyleLabel;
            System.Windows.Forms.Label madeQuantityLabel;
            System.Windows.Forms.Label cusIDLabel;
            System.Windows.Forms.Label empIDLabel;
            this.dataGridCake = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.madeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetMade = new CakeShop.CakeDBDataSetMade();
            this.madeIDTextBox = new System.Windows.Forms.TextBox();
            this.madeTypeTextBox = new System.Windows.Forms.TextBox();
            this.madeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.madePriceTextBox = new System.Windows.Forms.TextBox();
            this.madeStatusTextBox = new System.Windows.Forms.TextBox();
            this.madeStyleTextBox = new System.Windows.Forms.TextBox();
            this.madeQuantityTextBox = new System.Windows.Forms.TextBox();
            this.cusIDTextBox = new System.Windows.Forms.TextBox();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.madeTableAdapter = new CakeShop.CakeDBDataSetMadeTableAdapters.MadeTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonCus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            madeIDLabel = new System.Windows.Forms.Label();
            madeTypeLabel = new System.Windows.Forms.Label();
            madeDateLabel = new System.Windows.Forms.Label();
            madePriceLabel = new System.Windows.Forms.Label();
            madeStatusLabel = new System.Windows.Forms.Label();
            madeStyleLabel = new System.Windows.Forms.Label();
            madeQuantityLabel = new System.Windows.Forms.Label();
            cusIDLabel = new System.Windows.Forms.Label();
            empIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetMade)).BeginInit();
            this.SuspendLayout();
            // 
            // madeIDLabel
            // 
            madeIDLabel.AutoSize = true;
            madeIDLabel.Location = new System.Drawing.Point(17, 483);
            madeIDLabel.Name = "madeIDLabel";
            madeIDLabel.Size = new System.Drawing.Size(142, 29);
            madeIDLabel.TabIndex = 3;
            madeIDLabel.Text = "รหัสสั่งทำเค้ก:";
            // 
            // madeTypeLabel
            // 
            madeTypeLabel.AutoSize = true;
            madeTypeLabel.Location = new System.Drawing.Point(27, 603);
            madeTypeLabel.Name = "madeTypeLabel";
            madeTypeLabel.Size = new System.Drawing.Size(132, 29);
            madeTypeLabel.TabIndex = 5;
            madeTypeLabel.Text = "ชนิดของเค้ก:";
            // 
            // madeDateLabel
            // 
            madeDateLabel.AutoSize = true;
            madeDateLabel.Location = new System.Drawing.Point(51, 525);
            madeDateLabel.Name = "madeDateLabel";
            madeDateLabel.Size = new System.Drawing.Size(108, 29);
            madeDateLabel.TabIndex = 7;
            madeDateLabel.Text = "วันที่สั่งทำ:";
            // 
            // madePriceLabel
            // 
            madePriceLabel.AutoSize = true;
            madePriceLabel.Location = new System.Drawing.Point(94, 683);
            madePriceLabel.Name = "madePriceLabel";
            madePriceLabel.Size = new System.Drawing.Size(65, 29);
            madePriceLabel.TabIndex = 9;
            madePriceLabel.Text = "ราคา:";
            // 
            // madeStatusLabel
            // 
            madeStatusLabel.AutoSize = true;
            madeStatusLabel.Location = new System.Drawing.Point(78, 723);
            madeStatusLabel.Name = "madeStatusLabel";
            madeStatusLabel.Size = new System.Drawing.Size(81, 29);
            madeStatusLabel.TabIndex = 11;
            madeStatusLabel.Text = "สถานะ:";
            // 
            // madeStyleLabel
            // 
            madeStyleLabel.AutoSize = true;
            madeStyleLabel.Location = new System.Drawing.Point(35, 563);
            madeStyleLabel.Name = "madeStyleLabel";
            madeStyleLabel.Size = new System.Drawing.Size(124, 29);
            madeStyleLabel.TabIndex = 13;
            madeStyleLabel.Text = "ลักษณะเค้ก:";
            // 
            // madeQuantityLabel
            // 
            madeQuantityLabel.AutoSize = true;
            madeQuantityLabel.Location = new System.Drawing.Point(75, 643);
            madeQuantityLabel.Name = "madeQuantityLabel";
            madeQuantityLabel.Size = new System.Drawing.Size(84, 29);
            madeQuantityLabel.TabIndex = 15;
            madeQuantityLabel.Text = "จำนวน:";
            // 
            // cusIDLabel
            // 
            cusIDLabel.AutoSize = true;
            cusIDLabel.Location = new System.Drawing.Point(442, 483);
            cusIDLabel.Name = "cusIDLabel";
            cusIDLabel.Size = new System.Drawing.Size(108, 29);
            cusIDLabel.TabIndex = 17;
            cusIDLabel.Text = "รหัสลูกค้า:";
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(409, 523);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(141, 29);
            empIDLabel.TabIndex = 19;
            empIDLabel.Text = "รหัสพนักงาน:";
            // 
            // dataGridCake
            // 
            this.dataGridCake.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCake.Location = new System.Drawing.Point(12, 54);
            this.dataGridCake.Name = "dataGridCake";
            this.dataGridCake.RowHeadersWidth = 51;
            this.dataGridCake.RowTemplate.Height = 24;
            this.dataGridCake.Size = new System.Drawing.Size(890, 178);
            this.dataGridCake.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madeIDDataGridViewTextBoxColumn,
            this.madeTypeDataGridViewTextBoxColumn,
            this.madeDateDataGridViewTextBoxColumn,
            this.madePriceDataGridViewTextBoxColumn,
            this.madeStatusDataGridViewTextBoxColumn,
            this.madeStyleDataGridViewTextBoxColumn,
            this.madeQuantityDataGridViewTextBoxColumn,
            this.cusIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.madeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // madeIDDataGridViewTextBoxColumn
            // 
            this.madeIDDataGridViewTextBoxColumn.DataPropertyName = "MadeID";
            this.madeIDDataGridViewTextBoxColumn.HeaderText = "MadeID";
            this.madeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeIDDataGridViewTextBoxColumn.Name = "madeIDDataGridViewTextBoxColumn";
            this.madeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeTypeDataGridViewTextBoxColumn
            // 
            this.madeTypeDataGridViewTextBoxColumn.DataPropertyName = "MadeType";
            this.madeTypeDataGridViewTextBoxColumn.HeaderText = "MadeType";
            this.madeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeTypeDataGridViewTextBoxColumn.Name = "madeTypeDataGridViewTextBoxColumn";
            this.madeTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeDateDataGridViewTextBoxColumn
            // 
            this.madeDateDataGridViewTextBoxColumn.DataPropertyName = "MadeDate";
            this.madeDateDataGridViewTextBoxColumn.HeaderText = "MadeDate";
            this.madeDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeDateDataGridViewTextBoxColumn.Name = "madeDateDataGridViewTextBoxColumn";
            this.madeDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // madePriceDataGridViewTextBoxColumn
            // 
            this.madePriceDataGridViewTextBoxColumn.DataPropertyName = "MadePrice";
            this.madePriceDataGridViewTextBoxColumn.HeaderText = "MadePrice";
            this.madePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madePriceDataGridViewTextBoxColumn.Name = "madePriceDataGridViewTextBoxColumn";
            this.madePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeStatusDataGridViewTextBoxColumn
            // 
            this.madeStatusDataGridViewTextBoxColumn.DataPropertyName = "MadeStatus";
            this.madeStatusDataGridViewTextBoxColumn.HeaderText = "MadeStatus";
            this.madeStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeStatusDataGridViewTextBoxColumn.Name = "madeStatusDataGridViewTextBoxColumn";
            this.madeStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeStyleDataGridViewTextBoxColumn
            // 
            this.madeStyleDataGridViewTextBoxColumn.DataPropertyName = "MadeStyle";
            this.madeStyleDataGridViewTextBoxColumn.HeaderText = "MadeStyle";
            this.madeStyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeStyleDataGridViewTextBoxColumn.Name = "madeStyleDataGridViewTextBoxColumn";
            this.madeStyleDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeQuantityDataGridViewTextBoxColumn
            // 
            this.madeQuantityDataGridViewTextBoxColumn.DataPropertyName = "MadeQuantity";
            this.madeQuantityDataGridViewTextBoxColumn.HeaderText = "MadeQuantity";
            this.madeQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeQuantityDataGridViewTextBoxColumn.Name = "madeQuantityDataGridViewTextBoxColumn";
            this.madeQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "CusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "CusID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeBindingSource
            // 
            this.madeBindingSource.DataMember = "Made";
            this.madeBindingSource.DataSource = this.cakeDBDataSetMade;
            // 
            // cakeDBDataSetMade
            // 
            this.cakeDBDataSetMade.DataSetName = "CakeDBDataSetMade";
            this.cakeDBDataSetMade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // madeIDTextBox
            // 
            this.madeIDTextBox.Location = new System.Drawing.Point(196, 480);
            this.madeIDTextBox.Name = "madeIDTextBox";
            this.madeIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.madeIDTextBox.TabIndex = 4;
            // 
            // madeTypeTextBox
            // 
            this.madeTypeTextBox.Location = new System.Drawing.Point(196, 600);
            this.madeTypeTextBox.Name = "madeTypeTextBox";
            this.madeTypeTextBox.Size = new System.Drawing.Size(200, 34);
            this.madeTypeTextBox.TabIndex = 6;
            // 
            // madeDateDateTimePicker
            // 
            this.madeDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.madeDateDateTimePicker.Location = new System.Drawing.Point(196, 520);
            this.madeDateDateTimePicker.Name = "madeDateDateTimePicker";
            this.madeDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.madeDateDateTimePicker.TabIndex = 8;
            // 
            // madePriceTextBox
            // 
            this.madePriceTextBox.Location = new System.Drawing.Point(196, 680);
            this.madePriceTextBox.Name = "madePriceTextBox";
            this.madePriceTextBox.Size = new System.Drawing.Size(200, 34);
            this.madePriceTextBox.TabIndex = 10;
            // 
            // madeStatusTextBox
            // 
            this.madeStatusTextBox.Location = new System.Drawing.Point(196, 720);
            this.madeStatusTextBox.Name = "madeStatusTextBox";
            this.madeStatusTextBox.ReadOnly = true;
            this.madeStatusTextBox.Size = new System.Drawing.Size(200, 34);
            this.madeStatusTextBox.TabIndex = 12;
            this.madeStatusTextBox.Text = "ไม่เสร็จ";
            // 
            // madeStyleTextBox
            // 
            this.madeStyleTextBox.Location = new System.Drawing.Point(196, 560);
            this.madeStyleTextBox.Name = "madeStyleTextBox";
            this.madeStyleTextBox.Size = new System.Drawing.Size(200, 34);
            this.madeStyleTextBox.TabIndex = 14;
            // 
            // madeQuantityTextBox
            // 
            this.madeQuantityTextBox.Location = new System.Drawing.Point(196, 640);
            this.madeQuantityTextBox.Name = "madeQuantityTextBox";
            this.madeQuantityTextBox.Size = new System.Drawing.Size(200, 34);
            this.madeQuantityTextBox.TabIndex = 16;
            // 
            // cusIDTextBox
            // 
            this.cusIDTextBox.Location = new System.Drawing.Point(588, 480);
            this.cusIDTextBox.Name = "cusIDTextBox";
            this.cusIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.cusIDTextBox.TabIndex = 18;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(588, 520);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.empIDTextBox.TabIndex = 20;
            // 
            // madeTableAdapter
            // 
            this.madeTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(869, 615);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(244, 39);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(869, 569);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(244, 40);
            this.buttonDeL.TabIndex = 28;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(869, 523);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(244, 40);
            this.buttonInsert.TabIndex = 27;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonCus
            // 
            this.buttonCus.Location = new System.Drawing.Point(869, 477);
            this.buttonCus.Name = "buttonCus";
            this.buttonCus.Size = new System.Drawing.Size(244, 40);
            this.buttonCus.TabIndex = 30;
            this.buttonCus.Text = "ข้อมูลลูกค้า";
            this.buttonCus.UseVisualStyleBackColor = true;
            this.buttonCus.Click += new System.EventHandler(this.buttonCus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "ข้อมูลเค้ก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "ข้อมูลสั่งทำเค้ก";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสเค้ก",
            "หน้าเค้ก",
            "ชนิดของเค้ก",
            "จำนวน",
            "ราคา",
            "วันหมดอายุ",
            "รหัสสั่งทำเค้ก"});
            this.searchcomboBox.Location = new System.Drawing.Point(393, 4);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 39;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(700, 4);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 38;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(544, 7);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 37;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(855, 4);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 40;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1203, 778);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(madeIDLabel);
            this.Controls.Add(this.madeIDTextBox);
            this.Controls.Add(madeTypeLabel);
            this.Controls.Add(this.madeTypeTextBox);
            this.Controls.Add(madeDateLabel);
            this.Controls.Add(this.madeDateDateTimePicker);
            this.Controls.Add(madePriceLabel);
            this.Controls.Add(this.madePriceTextBox);
            this.Controls.Add(madeStatusLabel);
            this.Controls.Add(this.madeStatusTextBox);
            this.Controls.Add(madeStyleLabel);
            this.Controls.Add(this.madeStyleTextBox);
            this.Controls.Add(madeQuantityLabel);
            this.Controls.Add(this.madeQuantityTextBox);
            this.Controls.Add(cusIDLabel);
            this.Controls.Add(this.cusIDTextBox);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridCake);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สั่งทำเค้ก";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process03_FormClosing);
            this.Load += new System.EventHandler(this.Process03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetMade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCake;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox madeIDTextBox;
        private System.Windows.Forms.TextBox madeTypeTextBox;
        private System.Windows.Forms.DateTimePicker madeDateDateTimePicker;
        private System.Windows.Forms.TextBox madePriceTextBox;
        private System.Windows.Forms.TextBox madeStatusTextBox;
        private System.Windows.Forms.TextBox madeStyleTextBox;
        private System.Windows.Forms.TextBox madeQuantityTextBox;
        private System.Windows.Forms.TextBox cusIDTextBox;
        private System.Windows.Forms.TextBox empIDTextBox;
        private CakeDBDataSetMade cakeDBDataSetMade;
        private System.Windows.Forms.BindingSource madeBindingSource;
        private CakeDBDataSetMadeTableAdapters.MadeTableAdapter madeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonCus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}