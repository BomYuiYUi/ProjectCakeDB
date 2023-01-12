
namespace CakeShop
{
    partial class DataCustomer
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
            System.Windows.Forms.Label cusIDLabel;
            System.Windows.Forms.Label cusNameLabel;
            System.Windows.Forms.Label cusLastLabel;
            System.Windows.Forms.Label cusBDLabel;
            System.Windows.Forms.Label cusSexLabel;
            System.Windows.Forms.Label cusTelLabel;
            this.cusIDTextBox = new System.Windows.Forms.TextBox();
            this.cusNameTextBox = new System.Windows.Forms.TextBox();
            this.cusLastTextBox = new System.Windows.Forms.TextBox();
            this.cusBDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cusSexTextBox = new System.Windows.Forms.TextBox();
            this.cusTelTextBox = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetCustomer = new CakeShop.CakeDBDataSetCustomer();
            this.customerTableAdapter = new CakeShop.CakeDBDataSetCustomerTableAdapters.CustomerTableAdapter();
            cusIDLabel = new System.Windows.Forms.Label();
            cusNameLabel = new System.Windows.Forms.Label();
            cusLastLabel = new System.Windows.Forms.Label();
            cusBDLabel = new System.Windows.Forms.Label();
            cusSexLabel = new System.Windows.Forms.Label();
            cusTelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // cusIDLabel
            // 
            cusIDLabel.AutoSize = true;
            cusIDLabel.Location = new System.Drawing.Point(14, 277);
            cusIDLabel.Name = "cusIDLabel";
            cusIDLabel.Size = new System.Drawing.Size(90, 29);
            cusIDLabel.TabIndex = 65;
            cusIDLabel.Text = "Cus ID:";
            // 
            // cusNameLabel
            // 
            cusNameLabel.AutoSize = true;
            cusNameLabel.Location = new System.Drawing.Point(14, 317);
            cusNameLabel.Name = "cusNameLabel";
            cusNameLabel.Size = new System.Drawing.Size(132, 29);
            cusNameLabel.TabIndex = 67;
            cusNameLabel.Text = "Cus Name:";
            // 
            // cusLastLabel
            // 
            cusLastLabel.AutoSize = true;
            cusLastLabel.Location = new System.Drawing.Point(14, 357);
            cusLastLabel.Name = "cusLastLabel";
            cusLastLabel.Size = new System.Drawing.Size(111, 29);
            cusLastLabel.TabIndex = 69;
            cusLastLabel.Text = "Cus Last:";
            // 
            // cusBDLabel
            // 
            cusBDLabel.AutoSize = true;
            cusBDLabel.Location = new System.Drawing.Point(14, 398);
            cusBDLabel.Name = "cusBDLabel";
            cusBDLabel.Size = new System.Drawing.Size(100, 29);
            cusBDLabel.TabIndex = 71;
            cusBDLabel.Text = "Cus BD:";
            // 
            // cusSexLabel
            // 
            cusSexLabel.AutoSize = true;
            cusSexLabel.Location = new System.Drawing.Point(14, 437);
            cusSexLabel.Name = "cusSexLabel";
            cusSexLabel.Size = new System.Drawing.Size(108, 29);
            cusSexLabel.TabIndex = 73;
            cusSexLabel.Text = "Cus Sex:";
            // 
            // cusTelLabel
            // 
            cusTelLabel.AutoSize = true;
            cusTelLabel.Location = new System.Drawing.Point(14, 477);
            cusTelLabel.Name = "cusTelLabel";
            cusTelLabel.Size = new System.Drawing.Size(103, 29);
            cusTelLabel.TabIndex = 75;
            cusTelLabel.Text = "Cus Tel:";
            // 
            // cusIDTextBox
            // 
            this.cusIDTextBox.Location = new System.Drawing.Point(152, 274);
            this.cusIDTextBox.Name = "cusIDTextBox";
            this.cusIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.cusIDTextBox.TabIndex = 66;
            // 
            // cusNameTextBox
            // 
            this.cusNameTextBox.Location = new System.Drawing.Point(152, 314);
            this.cusNameTextBox.Name = "cusNameTextBox";
            this.cusNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.cusNameTextBox.TabIndex = 68;
            // 
            // cusLastTextBox
            // 
            this.cusLastTextBox.Location = new System.Drawing.Point(152, 354);
            this.cusLastTextBox.Name = "cusLastTextBox";
            this.cusLastTextBox.Size = new System.Drawing.Size(200, 34);
            this.cusLastTextBox.TabIndex = 70;
            // 
            // cusBDDateTimePicker
            // 
            this.cusBDDateTimePicker.Location = new System.Drawing.Point(152, 394);
            this.cusBDDateTimePicker.Name = "cusBDDateTimePicker";
            this.cusBDDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.cusBDDateTimePicker.TabIndex = 72;
            // 
            // cusSexTextBox
            // 
            this.cusSexTextBox.Location = new System.Drawing.Point(152, 434);
            this.cusSexTextBox.Name = "cusSexTextBox";
            this.cusSexTextBox.Size = new System.Drawing.Size(200, 34);
            this.cusSexTextBox.TabIndex = 74;
            // 
            // cusTelTextBox
            // 
            this.cusTelTextBox.Location = new System.Drawing.Point(152, 474);
            this.cusTelTextBox.Name = "cusTelTextBox";
            this.cusTelTextBox.Size = new System.Drawing.Size(200, 34);
            this.cusTelTextBox.TabIndex = 76;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(861, 363);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(244, 39);
            this.buttonUpdate.TabIndex = 64;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(861, 317);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(244, 40);
            this.buttonDeL.TabIndex = 63;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(861, 271);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(244, 40);
            this.buttonInsert.TabIndex = 62;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIDDataGridViewTextBoxColumn,
            this.cusNameDataGridViewTextBoxColumn,
            this.cusLastDataGridViewTextBoxColumn,
            this.cusBDDataGridViewTextBoxColumn,
            this.cusSexDataGridViewTextBoxColumn,
            this.cusTelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 251);
            this.dataGridView1.TabIndex = 61;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "CusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "CusID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusNameDataGridViewTextBoxColumn
            // 
            this.cusNameDataGridViewTextBoxColumn.DataPropertyName = "CusName";
            this.cusNameDataGridViewTextBoxColumn.HeaderText = "CusName";
            this.cusNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusNameDataGridViewTextBoxColumn.Name = "cusNameDataGridViewTextBoxColumn";
            this.cusNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusLastDataGridViewTextBoxColumn
            // 
            this.cusLastDataGridViewTextBoxColumn.DataPropertyName = "CusLast";
            this.cusLastDataGridViewTextBoxColumn.HeaderText = "CusLast";
            this.cusLastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusLastDataGridViewTextBoxColumn.Name = "cusLastDataGridViewTextBoxColumn";
            this.cusLastDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusBDDataGridViewTextBoxColumn
            // 
            this.cusBDDataGridViewTextBoxColumn.DataPropertyName = "CusBD";
            this.cusBDDataGridViewTextBoxColumn.HeaderText = "CusBD";
            this.cusBDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusBDDataGridViewTextBoxColumn.Name = "cusBDDataGridViewTextBoxColumn";
            this.cusBDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusSexDataGridViewTextBoxColumn
            // 
            this.cusSexDataGridViewTextBoxColumn.DataPropertyName = "CusSex";
            this.cusSexDataGridViewTextBoxColumn.HeaderText = "CusSex";
            this.cusSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusSexDataGridViewTextBoxColumn.Name = "cusSexDataGridViewTextBoxColumn";
            this.cusSexDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusTelDataGridViewTextBoxColumn
            // 
            this.cusTelDataGridViewTextBoxColumn.DataPropertyName = "CusTel";
            this.cusTelDataGridViewTextBoxColumn.HeaderText = "CusTel";
            this.cusTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusTelDataGridViewTextBoxColumn.Name = "cusTelDataGridViewTextBoxColumn";
            this.cusTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.cakeDBDataSetCustomer;
            // 
            // cakeDBDataSetCustomer
            // 
            this.cakeDBDataSetCustomer.DataSetName = "CakeDBDataSetCustomer";
            this.cakeDBDataSetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // DataCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1118, 523);
            this.Controls.Add(cusIDLabel);
            this.Controls.Add(this.cusIDTextBox);
            this.Controls.Add(cusNameLabel);
            this.Controls.Add(this.cusNameTextBox);
            this.Controls.Add(cusLastLabel);
            this.Controls.Add(this.cusLastTextBox);
            this.Controls.Add(cusBDLabel);
            this.Controls.Add(this.cusBDDateTimePicker);
            this.Controls.Add(cusSexLabel);
            this.Controls.Add(this.cusSexTextBox);
            this.Controls.Add(cusTelLabel);
            this.Controls.Add(this.cusTelTextBox);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DataCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataCustomer";
            this.Load += new System.EventHandler(this.DataCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cusIDTextBox;
        private System.Windows.Forms.TextBox cusNameTextBox;
        private System.Windows.Forms.TextBox cusLastTextBox;
        private System.Windows.Forms.DateTimePicker cusBDDateTimePicker;
        private System.Windows.Forms.TextBox cusSexTextBox;
        private System.Windows.Forms.TextBox cusTelTextBox;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CakeDBDataSetCustomer cakeDBDataSetCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CakeDBDataSetCustomerTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusTelDataGridViewTextBoxColumn;
    }
}