
namespace CakeShop
{
    partial class Process12
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
            System.Windows.Forms.Label cakeIDLabel;
            System.Windows.Forms.Label cakeStyleLabel;
            System.Windows.Forms.Label cakeTypeLabel;
            System.Windows.Forms.Label cakeQuantityLabel;
            System.Windows.Forms.Label cakePriceLabel;
            System.Windows.Forms.Label cakeExpLabel;
            System.Windows.Forms.Label madeIDLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cakeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetCake = new CakeShop.CakeDBDataSetCake();
            this.dataGridMade = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.cakeIDTextBox = new System.Windows.Forms.TextBox();
            this.cakeStyleTextBox = new System.Windows.Forms.TextBox();
            this.cakeTypeTextBox = new System.Windows.Forms.TextBox();
            this.cakeQuantityTextBox = new System.Windows.Forms.TextBox();
            this.cakePriceTextBox = new System.Windows.Forms.TextBox();
            this.cakeExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.madeIDTextBox = new System.Windows.Forms.TextBox();
            this.cakeTableAdapter = new CakeShop.CakeDBDataSetCakeTableAdapters.CakeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            cakeIDLabel = new System.Windows.Forms.Label();
            cakeStyleLabel = new System.Windows.Forms.Label();
            cakeTypeLabel = new System.Windows.Forms.Label();
            cakeQuantityLabel = new System.Windows.Forms.Label();
            cakePriceLabel = new System.Windows.Forms.Label();
            cakeExpLabel = new System.Windows.Forms.Label();
            madeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMade)).BeginInit();
            this.SuspendLayout();
            // 
            // cakeIDLabel
            // 
            cakeIDLabel.AutoSize = true;
            cakeIDLabel.Location = new System.Drawing.Point(12, 572);
            cakeIDLabel.Name = "cakeIDLabel";
            cakeIDLabel.Size = new System.Drawing.Size(101, 29);
            cakeIDLabel.TabIndex = 39;
            cakeIDLabel.Text = "รหัสเค้ก :";
            // 
            // cakeStyleLabel
            // 
            cakeStyleLabel.AutoSize = true;
            cakeStyleLabel.Location = new System.Drawing.Point(12, 612);
            cakeStyleLabel.Name = "cakeStyleLabel";
            cakeStyleLabel.Size = new System.Drawing.Size(101, 29);
            cakeStyleLabel.TabIndex = 41;
            cakeStyleLabel.Text = "หน้าเค้ก :";
            // 
            // cakeTypeLabel
            // 
            cakeTypeLabel.AutoSize = true;
            cakeTypeLabel.Location = new System.Drawing.Point(12, 652);
            cakeTypeLabel.Name = "cakeTypeLabel";
            cakeTypeLabel.Size = new System.Drawing.Size(138, 29);
            cakeTypeLabel.TabIndex = 43;
            cakeTypeLabel.Text = "ชนิดของเค้ก :";
            // 
            // cakeQuantityLabel
            // 
            cakeQuantityLabel.AutoSize = true;
            cakeQuantityLabel.Location = new System.Drawing.Point(12, 692);
            cakeQuantityLabel.Name = "cakeQuantityLabel";
            cakeQuantityLabel.Size = new System.Drawing.Size(90, 29);
            cakeQuantityLabel.TabIndex = 45;
            cakeQuantityLabel.Text = "จำนวน :";
            // 
            // cakePriceLabel
            // 
            cakePriceLabel.AutoSize = true;
            cakePriceLabel.Location = new System.Drawing.Point(12, 732);
            cakePriceLabel.Name = "cakePriceLabel";
            cakePriceLabel.Size = new System.Drawing.Size(71, 29);
            cakePriceLabel.TabIndex = 47;
            cakePriceLabel.Text = "ราคา :";
            // 
            // cakeExpLabel
            // 
            cakeExpLabel.AutoSize = true;
            cakeExpLabel.Location = new System.Drawing.Point(399, 571);
            cakeExpLabel.Name = "cakeExpLabel";
            cakeExpLabel.Size = new System.Drawing.Size(130, 29);
            cakeExpLabel.TabIndex = 49;
            cakeExpLabel.Text = "วันหมดอายุ :";
            // 
            // madeIDLabel
            // 
            madeIDLabel.AutoSize = true;
            madeIDLabel.Location = new System.Drawing.Point(399, 610);
            madeIDLabel.Name = "madeIDLabel";
            madeIDLabel.Size = new System.Drawing.Size(148, 29);
            madeIDLabel.TabIndex = 51;
            madeIDLabel.Text = "รหัสสั่งทำเค้ก :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cakeIDDataGridViewTextBoxColumn,
            this.cakeStyleDataGridViewTextBoxColumn,
            this.cakeTypeDataGridViewTextBoxColumn,
            this.cakeQuantityDataGridViewTextBoxColumn,
            this.cakePriceDataGridViewTextBoxColumn,
            this.cakeExpDataGridViewTextBoxColumn,
            this.madeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cakeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // cakeIDDataGridViewTextBoxColumn
            // 
            this.cakeIDDataGridViewTextBoxColumn.DataPropertyName = "CakeID";
            this.cakeIDDataGridViewTextBoxColumn.HeaderText = "CakeID";
            this.cakeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cakeIDDataGridViewTextBoxColumn.Name = "cakeIDDataGridViewTextBoxColumn";
            this.cakeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cakeStyleDataGridViewTextBoxColumn
            // 
            this.cakeStyleDataGridViewTextBoxColumn.DataPropertyName = "CakeStyle";
            this.cakeStyleDataGridViewTextBoxColumn.HeaderText = "CakeStyle";
            this.cakeStyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cakeStyleDataGridViewTextBoxColumn.Name = "cakeStyleDataGridViewTextBoxColumn";
            this.cakeStyleDataGridViewTextBoxColumn.Width = 125;
            // 
            // cakeTypeDataGridViewTextBoxColumn
            // 
            this.cakeTypeDataGridViewTextBoxColumn.DataPropertyName = "CakeType";
            this.cakeTypeDataGridViewTextBoxColumn.HeaderText = "CakeType";
            this.cakeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cakeTypeDataGridViewTextBoxColumn.Name = "cakeTypeDataGridViewTextBoxColumn";
            this.cakeTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cakeQuantityDataGridViewTextBoxColumn
            // 
            this.cakeQuantityDataGridViewTextBoxColumn.DataPropertyName = "CakeQuantity";
            this.cakeQuantityDataGridViewTextBoxColumn.HeaderText = "CakeQuantity";
            this.cakeQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cakeQuantityDataGridViewTextBoxColumn.Name = "cakeQuantityDataGridViewTextBoxColumn";
            this.cakeQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // cakePriceDataGridViewTextBoxColumn
            // 
            this.cakePriceDataGridViewTextBoxColumn.DataPropertyName = "CakePrice";
            this.cakePriceDataGridViewTextBoxColumn.HeaderText = "CakePrice";
            this.cakePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cakePriceDataGridViewTextBoxColumn.Name = "cakePriceDataGridViewTextBoxColumn";
            this.cakePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // cakeExpDataGridViewTextBoxColumn
            // 
            this.cakeExpDataGridViewTextBoxColumn.DataPropertyName = "CakeExp";
            this.cakeExpDataGridViewTextBoxColumn.HeaderText = "CakeExp";
            this.cakeExpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cakeExpDataGridViewTextBoxColumn.Name = "cakeExpDataGridViewTextBoxColumn";
            this.cakeExpDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeIDDataGridViewTextBoxColumn
            // 
            this.madeIDDataGridViewTextBoxColumn.DataPropertyName = "MadeID";
            this.madeIDDataGridViewTextBoxColumn.HeaderText = "MadeID";
            this.madeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeIDDataGridViewTextBoxColumn.Name = "madeIDDataGridViewTextBoxColumn";
            this.madeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cakeBindingSource
            // 
            this.cakeBindingSource.DataMember = "Cake";
            this.cakeBindingSource.DataSource = this.cakeDBDataSetCake;
            // 
            // cakeDBDataSetCake
            // 
            this.cakeDBDataSetCake.DataSetName = "CakeDBDataSetCake";
            this.cakeDBDataSetCake.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridMade
            // 
            this.dataGridMade.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMade.Location = new System.Drawing.Point(12, 47);
            this.dataGridMade.Name = "dataGridMade";
            this.dataGridMade.RowHeadersWidth = 51;
            this.dataGridMade.RowTemplate.Height = 24;
            this.dataGridMade.Size = new System.Drawing.Size(1101, 217);
            this.dataGridMade.TabIndex = 16;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(935, 658);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(178, 39);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(935, 612);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(178, 40);
            this.buttonDeL.TabIndex = 37;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(935, 566);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(178, 40);
            this.buttonInsert.TabIndex = 36;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // cakeIDTextBox
            // 
            this.cakeIDTextBox.Location = new System.Drawing.Point(186, 569);
            this.cakeIDTextBox.Name = "cakeIDTextBox";
            this.cakeIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.cakeIDTextBox.TabIndex = 40;
            // 
            // cakeStyleTextBox
            // 
            this.cakeStyleTextBox.Location = new System.Drawing.Point(186, 609);
            this.cakeStyleTextBox.Name = "cakeStyleTextBox";
            this.cakeStyleTextBox.Size = new System.Drawing.Size(200, 34);
            this.cakeStyleTextBox.TabIndex = 42;
            // 
            // cakeTypeTextBox
            // 
            this.cakeTypeTextBox.Location = new System.Drawing.Point(186, 649);
            this.cakeTypeTextBox.Name = "cakeTypeTextBox";
            this.cakeTypeTextBox.Size = new System.Drawing.Size(200, 34);
            this.cakeTypeTextBox.TabIndex = 44;
            // 
            // cakeQuantityTextBox
            // 
            this.cakeQuantityTextBox.Location = new System.Drawing.Point(186, 689);
            this.cakeQuantityTextBox.Name = "cakeQuantityTextBox";
            this.cakeQuantityTextBox.Size = new System.Drawing.Size(200, 34);
            this.cakeQuantityTextBox.TabIndex = 46;
            // 
            // cakePriceTextBox
            // 
            this.cakePriceTextBox.Location = new System.Drawing.Point(186, 729);
            this.cakePriceTextBox.Name = "cakePriceTextBox";
            this.cakePriceTextBox.Size = new System.Drawing.Size(200, 34);
            this.cakePriceTextBox.TabIndex = 48;
            // 
            // cakeExpDateTimePicker
            // 
            this.cakeExpDateTimePicker.Location = new System.Drawing.Point(573, 567);
            this.cakeExpDateTimePicker.Name = "cakeExpDateTimePicker";
            this.cakeExpDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.cakeExpDateTimePicker.TabIndex = 50;
            // 
            // madeIDTextBox
            // 
            this.madeIDTextBox.Location = new System.Drawing.Point(573, 607);
            this.madeIDTextBox.Name = "madeIDTextBox";
            this.madeIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.madeIDTextBox.TabIndex = 52;
            // 
            // cakeTableAdapter
            // 
            this.cakeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "ข้อมูลสั่งทำเค้ก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "ข้อมูลเค้ก";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสสั่งทำเค้ก",
            "ชนิดของเค้ก",
            "วันที่มารับ",
            "ราคา",
            "สถานะ",
            "ลักษณะเค้ก",
            "จำนวน",
            "รหัสลูกค้า",
            "รหัสพนักงาน"});
            this.searchcomboBox.Location = new System.Drawing.Point(604, 6);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 57;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(911, 7);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 56;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(755, 6);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 55;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1066, 6);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 38);
            this.buttonR.TabIndex = 58;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1133, 775);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(cakeIDLabel);
            this.Controls.Add(this.cakeIDTextBox);
            this.Controls.Add(cakeStyleLabel);
            this.Controls.Add(this.cakeStyleTextBox);
            this.Controls.Add(cakeTypeLabel);
            this.Controls.Add(this.cakeTypeTextBox);
            this.Controls.Add(cakeQuantityLabel);
            this.Controls.Add(this.cakeQuantityTextBox);
            this.Controls.Add(cakePriceLabel);
            this.Controls.Add(this.cakePriceTextBox);
            this.Controls.Add(cakeExpLabel);
            this.Controls.Add(this.cakeExpDateTimePicker);
            this.Controls.Add(madeIDLabel);
            this.Controls.Add(this.madeIDTextBox);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridMade);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "บันทึกเค้ก";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process12_FormClosing);
            this.Load += new System.EventHandler(this.Process12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridMade;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox cakeIDTextBox;
        private System.Windows.Forms.TextBox cakeStyleTextBox;
        private System.Windows.Forms.TextBox cakeTypeTextBox;
        private System.Windows.Forms.TextBox cakeQuantityTextBox;
        private System.Windows.Forms.TextBox cakePriceTextBox;
        private System.Windows.Forms.DateTimePicker cakeExpDateTimePicker;
        private System.Windows.Forms.TextBox madeIDTextBox;
        private CakeDBDataSetCake cakeDBDataSetCake;
        private System.Windows.Forms.BindingSource cakeBindingSource;
        private CakeDBDataSetCakeTableAdapters.CakeTableAdapter cakeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}