
namespace CakeShop
{
    partial class Process06
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
            System.Windows.Forms.Label madeStatusLabel;
            this.dataGridMade = new System.Windows.Forms.DataGridView();
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
            this.madeTableAdapter = new CakeShop.CakeDBDataSetMadeTableAdapters.MadeTableAdapter();
            this.madeStatuscomboBox = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            madeIDLabel = new System.Windows.Forms.Label();
            madeStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetMade)).BeginInit();
            this.SuspendLayout();
            // 
            // madeIDLabel
            // 
            madeIDLabel.AutoSize = true;
            madeIDLabel.Location = new System.Drawing.Point(12, 351);
            madeIDLabel.Name = "madeIDLabel";
            madeIDLabel.Size = new System.Drawing.Size(148, 29);
            madeIDLabel.TabIndex = 2;
            madeIDLabel.Text = "รหัสสั่งทำเค้ก :";
            // 
            // madeStatusLabel
            // 
            madeStatusLabel.AutoSize = true;
            madeStatusLabel.Location = new System.Drawing.Point(12, 391);
            madeStatusLabel.Name = "madeStatusLabel";
            madeStatusLabel.Size = new System.Drawing.Size(81, 29);
            madeStatusLabel.TabIndex = 10;
            madeStatusLabel.Text = "สถานะ:";
            // 
            // dataGridMade
            // 
            this.dataGridMade.AutoGenerateColumns = false;
            this.dataGridMade.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madeIDDataGridViewTextBoxColumn,
            this.madeTypeDataGridViewTextBoxColumn,
            this.madeDateDataGridViewTextBoxColumn,
            this.madePriceDataGridViewTextBoxColumn,
            this.madeStatusDataGridViewTextBoxColumn,
            this.madeStyleDataGridViewTextBoxColumn,
            this.madeQuantityDataGridViewTextBoxColumn,
            this.cusIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn});
            this.dataGridMade.DataSource = this.madeBindingSource;
            this.dataGridMade.Location = new System.Drawing.Point(12, 51);
            this.dataGridMade.Name = "dataGridMade";
            this.dataGridMade.RowHeadersWidth = 51;
            this.dataGridMade.RowTemplate.Height = 24;
            this.dataGridMade.Size = new System.Drawing.Size(1180, 287);
            this.dataGridMade.TabIndex = 0;
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
            this.madeIDTextBox.Location = new System.Drawing.Point(191, 348);
            this.madeIDTextBox.Name = "madeIDTextBox";
            this.madeIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.madeIDTextBox.TabIndex = 3;
            // 
            // madeTableAdapter
            // 
            this.madeTableAdapter.ClearBeforeFill = true;
            // 
            // madeStatuscomboBox
            // 
            this.madeStatuscomboBox.FormattingEnabled = true;
            this.madeStatuscomboBox.Items.AddRange(new object[] {
            "ไม่เสร็จ",
            "เสร็จแล้ว"});
            this.madeStatuscomboBox.Location = new System.Drawing.Point(191, 388);
            this.madeStatuscomboBox.Name = "madeStatuscomboBox";
            this.madeStatuscomboBox.Size = new System.Drawing.Size(200, 37);
            this.madeStatuscomboBox.TabIndex = 12;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(477, 346);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(244, 39);
            this.buttonUpdate.TabIndex = 30;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "ข้อมูลสั่งทำเค้ก";
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
            this.searchcomboBox.Location = new System.Drawing.Point(683, 11);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 39;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(990, 11);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 38;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(834, 14);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 37;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1145, 11);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 47;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1211, 460);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.madeStatuscomboBox);
            this.Controls.Add(madeIDLabel);
            this.Controls.Add(this.madeIDTextBox);
            this.Controls.Add(madeStatusLabel);
            this.Controls.Add(this.dataGridMade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ผลการสั่งทำเค้ก";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process06_FormClosing);
            this.Load += new System.EventHandler(this.Process06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetMade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMade;
        private System.Windows.Forms.TextBox madeIDTextBox;
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
        private System.Windows.Forms.ComboBox madeStatuscomboBox;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}