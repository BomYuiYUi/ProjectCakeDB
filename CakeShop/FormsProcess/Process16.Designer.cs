
namespace CakeShop
{
    partial class Process16
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
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label empNameLabel;
            System.Windows.Forms.Label empLastLabel;
            System.Windows.Forms.Label empPositionIDLabel;
            System.Windows.Forms.Label empPositionLabel;
            System.Windows.Forms.Label empBDLabel;
            System.Windows.Forms.Label empSexLabel;
            System.Windows.Forms.Label empTelLabel;
            System.Windows.Forms.Label empAddressLabel;
            System.Windows.Forms.Label empMooLabel;
            System.Windows.Forms.Label empSubDisrictLabel;
            System.Windows.Forms.Label empDisrictLabel;
            System.Windows.Forms.Label empProvinceLabel;
            System.Windows.Forms.Label empPostalLabel;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPositionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empMooDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSubDisrictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empDisrictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetEmployee = new CakeShop.CakeDBDataSetEmployee();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.empLastTextBox = new System.Windows.Forms.TextBox();
            this.empPositionTextBox = new System.Windows.Forms.TextBox();
            this.empBDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empSexTextBox = new System.Windows.Forms.TextBox();
            this.empTelTextBox = new System.Windows.Forms.TextBox();
            this.empAddressTextBox = new System.Windows.Forms.TextBox();
            this.empMooTextBox = new System.Windows.Forms.TextBox();
            this.empSubDisrictTextBox = new System.Windows.Forms.TextBox();
            this.empDisrictTextBox = new System.Windows.Forms.TextBox();
            this.empProvinceTextBox = new System.Windows.Forms.TextBox();
            this.empPostalTextBox = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.PositionIDcomboBox = new System.Windows.Forms.ComboBox();
            this.employeeTableAdapter = new CakeShop.CakeDBDataSetEmployeeTableAdapters.EmployeeTableAdapter();
            this.empPassTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            empIDLabel = new System.Windows.Forms.Label();
            empNameLabel = new System.Windows.Forms.Label();
            empLastLabel = new System.Windows.Forms.Label();
            empPositionIDLabel = new System.Windows.Forms.Label();
            empPositionLabel = new System.Windows.Forms.Label();
            empBDLabel = new System.Windows.Forms.Label();
            empSexLabel = new System.Windows.Forms.Label();
            empTelLabel = new System.Windows.Forms.Label();
            empAddressLabel = new System.Windows.Forms.Label();
            empMooLabel = new System.Windows.Forms.Label();
            empSubDisrictLabel = new System.Windows.Forms.Label();
            empDisrictLabel = new System.Windows.Forms.Label();
            empProvinceLabel = new System.Windows.Forms.Label();
            empPostalLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(12, 269);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(147, 29);
            empIDLabel.TabIndex = 2;
            empIDLabel.Text = "รหัสพนักงาน :";
            // 
            // empNameLabel
            // 
            empNameLabel.AutoSize = true;
            empNameLabel.Location = new System.Drawing.Point(12, 309);
            empNameLabel.Name = "empNameLabel";
            empNameLabel.Size = new System.Drawing.Size(51, 29);
            empNameLabel.TabIndex = 4;
            empNameLabel.Text = "ชื่อ :";
            // 
            // empLastLabel
            // 
            empLastLabel.AutoSize = true;
            empLastLabel.Location = new System.Drawing.Point(12, 349);
            empLastLabel.Name = "empLastLabel";
            empLastLabel.Size = new System.Drawing.Size(103, 29);
            empLastLabel.TabIndex = 6;
            empLastLabel.Text = "นามสกุล :";
            // 
            // empPositionIDLabel
            // 
            empPositionIDLabel.AutoSize = true;
            empPositionIDLabel.Location = new System.Drawing.Point(12, 389);
            empPositionIDLabel.Name = "empPositionIDLabel";
            empPositionIDLabel.Size = new System.Drawing.Size(145, 29);
            empPositionIDLabel.TabIndex = 8;
            empPositionIDLabel.Text = "รหัสตำแหน่ง :";
            // 
            // empPositionLabel
            // 
            empPositionLabel.AutoSize = true;
            empPositionLabel.Location = new System.Drawing.Point(12, 429);
            empPositionLabel.Name = "empPositionLabel";
            empPositionLabel.Size = new System.Drawing.Size(104, 29);
            empPositionLabel.TabIndex = 10;
            empPositionLabel.Text = "ตำแหน่ง :";
            // 
            // empBDLabel
            // 
            empBDLabel.AutoSize = true;
            empBDLabel.Location = new System.Drawing.Point(12, 470);
            empBDLabel.Name = "empBDLabel";
            empBDLabel.Size = new System.Drawing.Size(153, 29);
            empBDLabel.TabIndex = 12;
            empBDLabel.Text = "วันเดือนปีเกิด :";
            // 
            // empSexLabel
            // 
            empSexLabel.AutoSize = true;
            empSexLabel.Location = new System.Drawing.Point(12, 509);
            empSexLabel.Name = "empSexLabel";
            empSexLabel.Size = new System.Drawing.Size(64, 29);
            empSexLabel.TabIndex = 14;
            empSexLabel.Text = "เพศ :";
            // 
            // empTelLabel
            // 
            empTelLabel.AutoSize = true;
            empTelLabel.Location = new System.Drawing.Point(444, 266);
            empTelLabel.Name = "empTelLabel";
            empTelLabel.Size = new System.Drawing.Size(150, 29);
            empTelLabel.TabIndex = 16;
            empTelLabel.Text = "เบอร์โทรศัพท์:";
            // 
            // empAddressLabel
            // 
            empAddressLabel.AutoSize = true;
            empAddressLabel.Location = new System.Drawing.Point(444, 306);
            empAddressLabel.Name = "empAddressLabel";
            empAddressLabel.Size = new System.Drawing.Size(113, 29);
            empAddressLabel.TabIndex = 18;
            empAddressLabel.Text = "บ้านเลขที่ :";
            // 
            // empMooLabel
            // 
            empMooLabel.AutoSize = true;
            empMooLabel.Location = new System.Drawing.Point(444, 346);
            empMooLabel.Name = "empMooLabel";
            empMooLabel.Size = new System.Drawing.Size(54, 29);
            empMooLabel.TabIndex = 20;
            empMooLabel.Text = "หมู่ :";
            // 
            // empSubDisrictLabel
            // 
            empSubDisrictLabel.AutoSize = true;
            empSubDisrictLabel.Location = new System.Drawing.Point(444, 386);
            empSubDisrictLabel.Name = "empSubDisrictLabel";
            empSubDisrictLabel.Size = new System.Drawing.Size(74, 29);
            empSubDisrictLabel.TabIndex = 22;
            empSubDisrictLabel.Text = "ตำบล :";
            // 
            // empDisrictLabel
            // 
            empDisrictLabel.AutoSize = true;
            empDisrictLabel.Location = new System.Drawing.Point(444, 426);
            empDisrictLabel.Name = "empDisrictLabel";
            empDisrictLabel.Size = new System.Drawing.Size(84, 29);
            empDisrictLabel.TabIndex = 24;
            empDisrictLabel.Text = "อำเภอ :";
            // 
            // empProvinceLabel
            // 
            empProvinceLabel.AutoSize = true;
            empProvinceLabel.Location = new System.Drawing.Point(444, 466);
            empProvinceLabel.Name = "empProvinceLabel";
            empProvinceLabel.Size = new System.Drawing.Size(86, 29);
            empProvinceLabel.TabIndex = 26;
            empProvinceLabel.Text = "จังหวัด :";
            // 
            // empPostalLabel
            // 
            empPostalLabel.AutoSize = true;
            empPostalLabel.Location = new System.Drawing.Point(444, 506);
            empPostalLabel.Name = "empPostalLabel";
            empPostalLabel.Size = new System.Drawing.Size(152, 29);
            empPostalLabel.TabIndex = 28;
            empPostalLabel.Text = "รหัสไปรษณีย์ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(444, 546);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 29);
            label1.TabIndex = 28;
            label1.Text = "รหัสผ่าน :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empLastDataGridViewTextBoxColumn,
            this.empPositionIDDataGridViewTextBoxColumn,
            this.empPositionDataGridViewTextBoxColumn,
            this.empBDDataGridViewTextBoxColumn,
            this.empSexDataGridViewTextBoxColumn,
            this.empTelDataGridViewTextBoxColumn,
            this.empAddressDataGridViewTextBoxColumn,
            this.empMooDataGridViewTextBoxColumn,
            this.empSubDisrictDataGridViewTextBoxColumn,
            this.empDisrictDataGridViewTextBoxColumn,
            this.empProvinceDataGridViewTextBoxColumn,
            this.empPostalDataGridViewTextBoxColumn,
            this.empPassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empLastDataGridViewTextBoxColumn
            // 
            this.empLastDataGridViewTextBoxColumn.DataPropertyName = "EmpLast";
            this.empLastDataGridViewTextBoxColumn.HeaderText = "EmpLast";
            this.empLastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empLastDataGridViewTextBoxColumn.Name = "empLastDataGridViewTextBoxColumn";
            this.empLastDataGridViewTextBoxColumn.Width = 125;
            // 
            // empPositionIDDataGridViewTextBoxColumn
            // 
            this.empPositionIDDataGridViewTextBoxColumn.DataPropertyName = "EmpPositionID";
            this.empPositionIDDataGridViewTextBoxColumn.HeaderText = "EmpPositionID";
            this.empPositionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empPositionIDDataGridViewTextBoxColumn.Name = "empPositionIDDataGridViewTextBoxColumn";
            this.empPositionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // empPositionDataGridViewTextBoxColumn
            // 
            this.empPositionDataGridViewTextBoxColumn.DataPropertyName = "EmpPosition";
            this.empPositionDataGridViewTextBoxColumn.HeaderText = "EmpPosition";
            this.empPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empPositionDataGridViewTextBoxColumn.Name = "empPositionDataGridViewTextBoxColumn";
            this.empPositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // empBDDataGridViewTextBoxColumn
            // 
            this.empBDDataGridViewTextBoxColumn.DataPropertyName = "EmpBD";
            this.empBDDataGridViewTextBoxColumn.HeaderText = "EmpBD";
            this.empBDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empBDDataGridViewTextBoxColumn.Name = "empBDDataGridViewTextBoxColumn";
            this.empBDDataGridViewTextBoxColumn.Width = 125;
            // 
            // empSexDataGridViewTextBoxColumn
            // 
            this.empSexDataGridViewTextBoxColumn.DataPropertyName = "EmpSex";
            this.empSexDataGridViewTextBoxColumn.HeaderText = "EmpSex";
            this.empSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empSexDataGridViewTextBoxColumn.Name = "empSexDataGridViewTextBoxColumn";
            this.empSexDataGridViewTextBoxColumn.Width = 125;
            // 
            // empTelDataGridViewTextBoxColumn
            // 
            this.empTelDataGridViewTextBoxColumn.DataPropertyName = "EmpTel";
            this.empTelDataGridViewTextBoxColumn.HeaderText = "EmpTel";
            this.empTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empTelDataGridViewTextBoxColumn.Name = "empTelDataGridViewTextBoxColumn";
            this.empTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // empAddressDataGridViewTextBoxColumn
            // 
            this.empAddressDataGridViewTextBoxColumn.DataPropertyName = "EmpAddress";
            this.empAddressDataGridViewTextBoxColumn.HeaderText = "EmpAddress";
            this.empAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empAddressDataGridViewTextBoxColumn.Name = "empAddressDataGridViewTextBoxColumn";
            this.empAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // empMooDataGridViewTextBoxColumn
            // 
            this.empMooDataGridViewTextBoxColumn.DataPropertyName = "EmpMoo";
            this.empMooDataGridViewTextBoxColumn.HeaderText = "EmpMoo";
            this.empMooDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empMooDataGridViewTextBoxColumn.Name = "empMooDataGridViewTextBoxColumn";
            this.empMooDataGridViewTextBoxColumn.Width = 125;
            // 
            // empSubDisrictDataGridViewTextBoxColumn
            // 
            this.empSubDisrictDataGridViewTextBoxColumn.DataPropertyName = "EmpSubDisrict";
            this.empSubDisrictDataGridViewTextBoxColumn.HeaderText = "EmpSubDisrict";
            this.empSubDisrictDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empSubDisrictDataGridViewTextBoxColumn.Name = "empSubDisrictDataGridViewTextBoxColumn";
            this.empSubDisrictDataGridViewTextBoxColumn.Width = 125;
            // 
            // empDisrictDataGridViewTextBoxColumn
            // 
            this.empDisrictDataGridViewTextBoxColumn.DataPropertyName = "EmpDisrict";
            this.empDisrictDataGridViewTextBoxColumn.HeaderText = "EmpDisrict";
            this.empDisrictDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empDisrictDataGridViewTextBoxColumn.Name = "empDisrictDataGridViewTextBoxColumn";
            this.empDisrictDataGridViewTextBoxColumn.Width = 125;
            // 
            // empProvinceDataGridViewTextBoxColumn
            // 
            this.empProvinceDataGridViewTextBoxColumn.DataPropertyName = "EmpProvince";
            this.empProvinceDataGridViewTextBoxColumn.HeaderText = "EmpProvince";
            this.empProvinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empProvinceDataGridViewTextBoxColumn.Name = "empProvinceDataGridViewTextBoxColumn";
            this.empProvinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // empPostalDataGridViewTextBoxColumn
            // 
            this.empPostalDataGridViewTextBoxColumn.DataPropertyName = "EmpPostal";
            this.empPostalDataGridViewTextBoxColumn.HeaderText = "EmpPostal";
            this.empPostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empPostalDataGridViewTextBoxColumn.Name = "empPostalDataGridViewTextBoxColumn";
            this.empPostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // empPassDataGridViewTextBoxColumn
            // 
            this.empPassDataGridViewTextBoxColumn.DataPropertyName = "EmpPass";
            this.empPassDataGridViewTextBoxColumn.HeaderText = "EmpPass";
            this.empPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empPassDataGridViewTextBoxColumn.Name = "empPassDataGridViewTextBoxColumn";
            this.empPassDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.cakeDBDataSetEmployee;
            // 
            // cakeDBDataSetEmployee
            // 
            this.cakeDBDataSetEmployee.DataSetName = "CakeDBDataSetEmployee";
            this.cakeDBDataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(209, 266);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.empIDTextBox.TabIndex = 3;
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.Location = new System.Drawing.Point(209, 306);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.empNameTextBox.TabIndex = 5;
            // 
            // empLastTextBox
            // 
            this.empLastTextBox.Location = new System.Drawing.Point(209, 346);
            this.empLastTextBox.Name = "empLastTextBox";
            this.empLastTextBox.Size = new System.Drawing.Size(200, 34);
            this.empLastTextBox.TabIndex = 7;
            // 
            // empPositionTextBox
            // 
            this.empPositionTextBox.Location = new System.Drawing.Point(209, 426);
            this.empPositionTextBox.Name = "empPositionTextBox";
            this.empPositionTextBox.ReadOnly = true;
            this.empPositionTextBox.Size = new System.Drawing.Size(200, 34);
            this.empPositionTextBox.TabIndex = 11;
            // 
            // empBDDateTimePicker
            // 
            this.empBDDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.empBDDateTimePicker.Location = new System.Drawing.Point(209, 466);
            this.empBDDateTimePicker.Name = "empBDDateTimePicker";
            this.empBDDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.empBDDateTimePicker.TabIndex = 13;
            // 
            // empSexTextBox
            // 
            this.empSexTextBox.Location = new System.Drawing.Point(209, 506);
            this.empSexTextBox.Name = "empSexTextBox";
            this.empSexTextBox.Size = new System.Drawing.Size(200, 34);
            this.empSexTextBox.TabIndex = 15;
            // 
            // empTelTextBox
            // 
            this.empTelTextBox.Location = new System.Drawing.Point(641, 263);
            this.empTelTextBox.Name = "empTelTextBox";
            this.empTelTextBox.Size = new System.Drawing.Size(200, 34);
            this.empTelTextBox.TabIndex = 17;
            // 
            // empAddressTextBox
            // 
            this.empAddressTextBox.Location = new System.Drawing.Point(641, 303);
            this.empAddressTextBox.Name = "empAddressTextBox";
            this.empAddressTextBox.Size = new System.Drawing.Size(200, 34);
            this.empAddressTextBox.TabIndex = 19;
            // 
            // empMooTextBox
            // 
            this.empMooTextBox.Location = new System.Drawing.Point(641, 343);
            this.empMooTextBox.Name = "empMooTextBox";
            this.empMooTextBox.Size = new System.Drawing.Size(200, 34);
            this.empMooTextBox.TabIndex = 21;
            // 
            // empSubDisrictTextBox
            // 
            this.empSubDisrictTextBox.Location = new System.Drawing.Point(641, 383);
            this.empSubDisrictTextBox.Name = "empSubDisrictTextBox";
            this.empSubDisrictTextBox.Size = new System.Drawing.Size(200, 34);
            this.empSubDisrictTextBox.TabIndex = 23;
            // 
            // empDisrictTextBox
            // 
            this.empDisrictTextBox.Location = new System.Drawing.Point(641, 423);
            this.empDisrictTextBox.Name = "empDisrictTextBox";
            this.empDisrictTextBox.Size = new System.Drawing.Size(200, 34);
            this.empDisrictTextBox.TabIndex = 25;
            // 
            // empProvinceTextBox
            // 
            this.empProvinceTextBox.Location = new System.Drawing.Point(641, 463);
            this.empProvinceTextBox.Name = "empProvinceTextBox";
            this.empProvinceTextBox.Size = new System.Drawing.Size(200, 34);
            this.empProvinceTextBox.TabIndex = 27;
            // 
            // empPostalTextBox
            // 
            this.empPostalTextBox.Location = new System.Drawing.Point(641, 503);
            this.empPostalTextBox.Name = "empPostalTextBox";
            this.empPostalTextBox.Size = new System.Drawing.Size(200, 34);
            this.empPostalTextBox.TabIndex = 29;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(876, 355);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(178, 39);
            this.buttonUpdate.TabIndex = 35;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(876, 309);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(178, 40);
            this.buttonDeL.TabIndex = 34;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(876, 263);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(178, 40);
            this.buttonInsert.TabIndex = 33;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // PositionIDcomboBox
            // 
            this.PositionIDcomboBox.FormattingEnabled = true;
            this.PositionIDcomboBox.Items.AddRange(new object[] {
            "P01",
            "P02",
            "P03",
            "P04",
            "P05",
            "P06"});
            this.PositionIDcomboBox.Location = new System.Drawing.Point(209, 386);
            this.PositionIDcomboBox.Name = "PositionIDcomboBox";
            this.PositionIDcomboBox.Size = new System.Drawing.Size(200, 37);
            this.PositionIDcomboBox.TabIndex = 36;
            this.PositionIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // empPassTextBox
            // 
            this.empPassTextBox.Location = new System.Drawing.Point(641, 543);
            this.empPassTextBox.Name = "empPassTextBox";
            this.empPassTextBox.Size = new System.Drawing.Size(200, 34);
            this.empPassTextBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "ข้อมูลพนักงาน";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสพนักงาน",
            "ชื่อ",
            "นามสกุล",
            "รหัสตำแหน่ง",
            "ตำแหน่ง",
            "วันเดือนปีเกิด",
            "เพศ",
            "โทรศัพท์",
            "บ้านเลขที่",
            "หมู่",
            "ตำบล",
            "อำเภอ",
            "จังหวัด",
            "รหัสไปรษณ์",
            "รหัสผ่าน"});
            this.searchcomboBox.Location = new System.Drawing.Point(591, 7);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 42;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(898, 6);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 41;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(742, 9);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 40;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1053, 6);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 61;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1120, 637);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionIDcomboBox);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(empNameLabel);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(empLastLabel);
            this.Controls.Add(this.empLastTextBox);
            this.Controls.Add(empPositionIDLabel);
            this.Controls.Add(empPositionLabel);
            this.Controls.Add(this.empPositionTextBox);
            this.Controls.Add(empBDLabel);
            this.Controls.Add(this.empBDDateTimePicker);
            this.Controls.Add(empSexLabel);
            this.Controls.Add(this.empSexTextBox);
            this.Controls.Add(empTelLabel);
            this.Controls.Add(this.empTelTextBox);
            this.Controls.Add(empAddressLabel);
            this.Controls.Add(this.empAddressTextBox);
            this.Controls.Add(empMooLabel);
            this.Controls.Add(this.empMooTextBox);
            this.Controls.Add(empSubDisrictLabel);
            this.Controls.Add(this.empSubDisrictTextBox);
            this.Controls.Add(empDisrictLabel);
            this.Controls.Add(this.empDisrictTextBox);
            this.Controls.Add(empProvinceLabel);
            this.Controls.Add(this.empProvinceTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(empPostalLabel);
            this.Controls.Add(this.empPassTextBox);
            this.Controls.Add(this.empPostalTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลพนักงาน";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process16_FormClosing);
            this.Load += new System.EventHandler(this.Process16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.TextBox empLastTextBox;
        private System.Windows.Forms.TextBox empPositionTextBox;
        private System.Windows.Forms.DateTimePicker empBDDateTimePicker;
        private System.Windows.Forms.TextBox empSexTextBox;
        private System.Windows.Forms.TextBox empTelTextBox;
        private System.Windows.Forms.TextBox empAddressTextBox;
        private System.Windows.Forms.TextBox empMooTextBox;
        private System.Windows.Forms.TextBox empSubDisrictTextBox;
        private System.Windows.Forms.TextBox empDisrictTextBox;
        private System.Windows.Forms.TextBox empProvinceTextBox;
        private System.Windows.Forms.TextBox empPostalTextBox;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeL;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox PositionIDcomboBox;
        private CakeDBDataSetEmployee cakeDBDataSetEmployee;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private CakeDBDataSetEmployeeTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPositionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empMooDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSubDisrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empDisrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox empPassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchcomboBox;
        private System.Windows.Forms.Button cakesearchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button buttonR;
    }
}