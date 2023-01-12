
namespace CakeShop
{
    partial class Process01
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
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderStyleLabel;
            System.Windows.Forms.Label orderTypeLabel;
            System.Windows.Forms.Label orderQuantityLabel;
            System.Windows.Forms.Label orderExpLabel;
            System.Windows.Forms.Label cakeIDLabel;
            System.Windows.Forms.Label memberIDLabel;
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetOrder = new CakeShop.CakeDBDataSetOrder();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderStyleTextBox = new System.Windows.Forms.TextBox();
            this.orderTypeTextBox = new System.Windows.Forms.TextBox();
            this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.orderExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cakeIDTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewCake = new System.Windows.Forms.DataGridView();
            this.ordersTableAdapter = new CakeShop.CakeDBDataSetOrderTableAdapters.OrdersTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.buttonR = new System.Windows.Forms.Button();
            orderIDLabel = new System.Windows.Forms.Label();
            orderStyleLabel = new System.Windows.Forms.Label();
            orderTypeLabel = new System.Windows.Forms.Label();
            orderQuantityLabel = new System.Windows.Forms.Label();
            orderExpLabel = new System.Windows.Forms.Label();
            cakeIDLabel = new System.Windows.Forms.Label();
            memberIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCake)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(6, 460);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(165, 29);
            orderIDLabel.TabIndex = 2;
            orderIDLabel.Text = "รหัสการซื้อเค้ก :";
            // 
            // orderStyleLabel
            // 
            orderStyleLabel.AutoSize = true;
            orderStyleLabel.Location = new System.Drawing.Point(6, 500);
            orderStyleLabel.Name = "orderStyleLabel";
            orderStyleLabel.Size = new System.Drawing.Size(101, 29);
            orderStyleLabel.TabIndex = 4;
            orderStyleLabel.Text = "หน้าเค้ก :";
            // 
            // orderTypeLabel
            // 
            orderTypeLabel.AutoSize = true;
            orderTypeLabel.Location = new System.Drawing.Point(6, 540);
            orderTypeLabel.Name = "orderTypeLabel";
            orderTypeLabel.Size = new System.Drawing.Size(138, 29);
            orderTypeLabel.TabIndex = 6;
            orderTypeLabel.Text = "ชนิดของเค้ก :";
            // 
            // orderQuantityLabel
            // 
            orderQuantityLabel.AutoSize = true;
            orderQuantityLabel.Location = new System.Drawing.Point(6, 580);
            orderQuantityLabel.Name = "orderQuantityLabel";
            orderQuantityLabel.Size = new System.Drawing.Size(84, 29);
            orderQuantityLabel.TabIndex = 8;
            orderQuantityLabel.Text = "จำนวน:";
            // 
            // orderExpLabel
            // 
            orderExpLabel.AutoSize = true;
            orderExpLabel.Location = new System.Drawing.Point(6, 621);
            orderExpLabel.Name = "orderExpLabel";
            orderExpLabel.Size = new System.Drawing.Size(95, 29);
            orderExpLabel.TabIndex = 12;
            orderExpLabel.Text = "วันที่ซื้อ :";
            // 
            // cakeIDLabel
            // 
            cakeIDLabel.AutoSize = true;
            cakeIDLabel.Location = new System.Drawing.Point(403, 460);
            cakeIDLabel.Name = "cakeIDLabel";
            cakeIDLabel.Size = new System.Drawing.Size(101, 29);
            cakeIDLabel.TabIndex = 14;
            cakeIDLabel.Text = "รหัสเค้ก :";
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(403, 500);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(123, 29);
            memberIDLabel.TabIndex = 16;
            memberIDLabel.Text = "รหัสสมาชิก:";
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderStyleDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.orderQuantityDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn,
            this.orderExpDataGridViewTextBoxColumn,
            this.cakeIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.ordersBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(6, 283);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 24;
            this.orderDataGridView.Size = new System.Drawing.Size(1057, 162);
            this.orderDataGridView.TabIndex = 1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderStyleDataGridViewTextBoxColumn
            // 
            this.orderStyleDataGridViewTextBoxColumn.DataPropertyName = "OrderStyle";
            this.orderStyleDataGridViewTextBoxColumn.HeaderText = "OrderStyle";
            this.orderStyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStyleDataGridViewTextBoxColumn.Name = "orderStyleDataGridViewTextBoxColumn";
            this.orderStyleDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderQuantityDataGridViewTextBoxColumn
            // 
            this.orderQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderQuantity";
            this.orderQuantityDataGridViewTextBoxColumn.HeaderText = "OrderQuantity";
            this.orderQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderQuantityDataGridViewTextBoxColumn.Name = "orderQuantityDataGridViewTextBoxColumn";
            this.orderQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            this.orderPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderExpDataGridViewTextBoxColumn
            // 
            this.orderExpDataGridViewTextBoxColumn.DataPropertyName = "OrderExp";
            this.orderExpDataGridViewTextBoxColumn.HeaderText = "OrderExp";
            this.orderExpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderExpDataGridViewTextBoxColumn.Name = "orderExpDataGridViewTextBoxColumn";
            this.orderExpDataGridViewTextBoxColumn.Width = 125;
            // 
            // cakeIDDataGridViewTextBoxColumn
            // 
            this.cakeIDDataGridViewTextBoxColumn.DataPropertyName = "CakeID";
            this.cakeIDDataGridViewTextBoxColumn.HeaderText = "CakeID";
            this.cakeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cakeIDDataGridViewTextBoxColumn.Name = "cakeIDDataGridViewTextBoxColumn";
            this.cakeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.cakeDBDataSetOrder;
            // 
            // cakeDBDataSetOrder
            // 
            this.cakeDBDataSetOrder.DataSetName = "CakeDBDataSetOrder";
            this.cakeDBDataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(187, 457);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.orderIDTextBox.TabIndex = 3;
            // 
            // orderStyleTextBox
            // 
            this.orderStyleTextBox.Location = new System.Drawing.Point(187, 497);
            this.orderStyleTextBox.Name = "orderStyleTextBox";
            this.orderStyleTextBox.Size = new System.Drawing.Size(200, 34);
            this.orderStyleTextBox.TabIndex = 5;
            // 
            // orderTypeTextBox
            // 
            this.orderTypeTextBox.Location = new System.Drawing.Point(187, 537);
            this.orderTypeTextBox.Name = "orderTypeTextBox";
            this.orderTypeTextBox.Size = new System.Drawing.Size(200, 34);
            this.orderTypeTextBox.TabIndex = 7;
            // 
            // orderQuantityTextBox
            // 
            this.orderQuantityTextBox.Location = new System.Drawing.Point(187, 577);
            this.orderQuantityTextBox.Name = "orderQuantityTextBox";
            this.orderQuantityTextBox.Size = new System.Drawing.Size(200, 34);
            this.orderQuantityTextBox.TabIndex = 9;
            // 
            // orderExpDateTimePicker
            // 
            this.orderExpDateTimePicker.Location = new System.Drawing.Point(187, 617);
            this.orderExpDateTimePicker.Name = "orderExpDateTimePicker";
            this.orderExpDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.orderExpDateTimePicker.TabIndex = 13;
            // 
            // cakeIDTextBox
            // 
            this.cakeIDTextBox.Location = new System.Drawing.Point(584, 457);
            this.cakeIDTextBox.Name = "cakeIDTextBox";
            this.cakeIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.cakeIDTextBox.TabIndex = 15;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(584, 497);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberIDTextBox.TabIndex = 17;
            // 
            // dataGridViewCake
            // 
            this.dataGridViewCake.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCake.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewCake.Name = "dataGridViewCake";
            this.dataGridViewCake.RowHeadersWidth = 51;
            this.dataGridViewCake.RowTemplate.Height = 24;
            this.dataGridViewCake.Size = new System.Drawing.Size(1057, 150);
            this.dataGridViewCake.TabIndex = 18;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(819, 546);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(244, 39);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(819, 500);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(244, 40);
            this.buttonDeL.TabIndex = 31;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(819, 454);
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
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ข้อมูลเค้ก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "ข้อมูลซื้อเค้ก";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(711, 11);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 34;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(867, 8);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 35;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
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
            this.searchcomboBox.Location = new System.Drawing.Point(560, 8);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 36;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1022, 9);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 37;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1085, 671);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewCake);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(orderStyleLabel);
            this.Controls.Add(this.orderStyleTextBox);
            this.Controls.Add(orderTypeLabel);
            this.Controls.Add(this.orderTypeTextBox);
            this.Controls.Add(orderQuantityLabel);
            this.Controls.Add(this.orderQuantityTextBox);
            this.Controls.Add(orderExpLabel);
            this.Controls.Add(this.orderExpDateTimePicker);
            this.Controls.Add(cakeIDLabel);
            this.Controls.Add(this.cakeIDTextBox);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.orderDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "บันทึกซื้อเค้ก";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process01_FormClosing);
            this.Load += new System.EventHandler(this.Process01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox orderStyleTextBox;
        private System.Windows.Forms.TextBox orderTypeTextBox;
        private System.Windows.Forms.TextBox orderQuantityTextBox;
        private System.Windows.Forms.DateTimePicker orderExpDateTimePicker;
        private System.Windows.Forms.TextBox cakeIDTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.DataGridView dataGridViewCake;
        private CakeDBDataSetOrder cakeDBDataSetOrder;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CakeDBDataSetOrderTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button buttonR;
    }
}