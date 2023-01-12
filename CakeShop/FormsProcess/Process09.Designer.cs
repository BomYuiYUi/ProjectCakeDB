
namespace CakeShop
{
    partial class Process09
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
            System.Windows.Forms.Label memberIDLabel;
            System.Windows.Forms.Label memberNameLabel;
            System.Windows.Forms.Label memberLastLabel;
            System.Windows.Forms.Label memberBDLabel;
            System.Windows.Forms.Label memberSexLabel;
            System.Windows.Forms.Label memberTelLabel;
            System.Windows.Forms.Label memberAddressLabel;
            System.Windows.Forms.Label memberMooLabel;
            System.Windows.Forms.Label memberSubDisrictLabel;
            System.Windows.Forms.Label memberDisrictLabel;
            System.Windows.Forms.Label memberProvinceLabel;
            System.Windows.Forms.Label memberPostalLabel;
            this.dataGridMember = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberMooDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberSubDisrictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDisrictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeDBDataSetMember = new CakeShop.CakeDBDataSetMember();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.memberLastTextBox = new System.Windows.Forms.TextBox();
            this.memberBDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.memberSexTextBox = new System.Windows.Forms.TextBox();
            this.memberTelTextBox = new System.Windows.Forms.TextBox();
            this.memberAddressTextBox = new System.Windows.Forms.TextBox();
            this.memberMooTextBox = new System.Windows.Forms.TextBox();
            this.memberSubDisrictTextBox = new System.Windows.Forms.TextBox();
            this.memberDisrictTextBox = new System.Windows.Forms.TextBox();
            this.memberProvinceTextBox = new System.Windows.Forms.TextBox();
            this.memberPostalTextBox = new System.Windows.Forms.TextBox();
            this.memberTableAdapter = new CakeShop.CakeDBDataSetMemberTableAdapters.MemberTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeL = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchcomboBox = new System.Windows.Forms.ComboBox();
            this.cakesearchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            memberIDLabel = new System.Windows.Forms.Label();
            memberNameLabel = new System.Windows.Forms.Label();
            memberLastLabel = new System.Windows.Forms.Label();
            memberBDLabel = new System.Windows.Forms.Label();
            memberSexLabel = new System.Windows.Forms.Label();
            memberTelLabel = new System.Windows.Forms.Label();
            memberAddressLabel = new System.Windows.Forms.Label();
            memberMooLabel = new System.Windows.Forms.Label();
            memberSubDisrictLabel = new System.Windows.Forms.Label();
            memberDisrictLabel = new System.Windows.Forms.Label();
            memberProvinceLabel = new System.Windows.Forms.Label();
            memberPostalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetMember)).BeginInit();
            this.SuspendLayout();
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(16, 266);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(129, 29);
            memberIDLabel.TabIndex = 2;
            memberIDLabel.Text = "รหัสสมาชิก :";
            // 
            // memberNameLabel
            // 
            memberNameLabel.AutoSize = true;
            memberNameLabel.Location = new System.Drawing.Point(16, 306);
            memberNameLabel.Name = "memberNameLabel";
            memberNameLabel.Size = new System.Drawing.Size(51, 29);
            memberNameLabel.TabIndex = 4;
            memberNameLabel.Text = "ชื่อ :";
            // 
            // memberLastLabel
            // 
            memberLastLabel.AutoSize = true;
            memberLastLabel.Location = new System.Drawing.Point(16, 346);
            memberLastLabel.Name = "memberLastLabel";
            memberLastLabel.Size = new System.Drawing.Size(103, 29);
            memberLastLabel.TabIndex = 6;
            memberLastLabel.Text = "นามสกุล :";
            // 
            // memberBDLabel
            // 
            memberBDLabel.AutoSize = true;
            memberBDLabel.Location = new System.Drawing.Point(16, 387);
            memberBDLabel.Name = "memberBDLabel";
            memberBDLabel.Size = new System.Drawing.Size(147, 29);
            memberBDLabel.TabIndex = 8;
            memberBDLabel.Text = "วันเดือนปีเกิด:";
            // 
            // memberSexLabel
            // 
            memberSexLabel.AutoSize = true;
            memberSexLabel.Location = new System.Drawing.Point(16, 426);
            memberSexLabel.Name = "memberSexLabel";
            memberSexLabel.Size = new System.Drawing.Size(64, 29);
            memberSexLabel.TabIndex = 10;
            memberSexLabel.Text = "เพศ :";
            // 
            // memberTelLabel
            // 
            memberTelLabel.AutoSize = true;
            memberTelLabel.Location = new System.Drawing.Point(16, 466);
            memberTelLabel.Name = "memberTelLabel";
            memberTelLabel.Size = new System.Drawing.Size(112, 29);
            memberTelLabel.TabIndex = 12;
            memberTelLabel.Text = "เบอร์โทร :";
            // 
            // memberAddressLabel
            // 
            memberAddressLabel.AutoSize = true;
            memberAddressLabel.Location = new System.Drawing.Point(501, 266);
            memberAddressLabel.Name = "memberAddressLabel";
            memberAddressLabel.Size = new System.Drawing.Size(127, 29);
            memberAddressLabel.TabIndex = 14;
            memberAddressLabel.Text = "ที่บ้านเลขที่ :";
            // 
            // memberMooLabel
            // 
            memberMooLabel.AutoSize = true;
            memberMooLabel.Location = new System.Drawing.Point(501, 306);
            memberMooLabel.Name = "memberMooLabel";
            memberMooLabel.Size = new System.Drawing.Size(48, 29);
            memberMooLabel.TabIndex = 16;
            memberMooLabel.Text = "หมู่:";
            // 
            // memberSubDisrictLabel
            // 
            memberSubDisrictLabel.AutoSize = true;
            memberSubDisrictLabel.Location = new System.Drawing.Point(501, 346);
            memberSubDisrictLabel.Name = "memberSubDisrictLabel";
            memberSubDisrictLabel.Size = new System.Drawing.Size(74, 29);
            memberSubDisrictLabel.TabIndex = 18;
            memberSubDisrictLabel.Text = "ตำบล :";
            // 
            // memberDisrictLabel
            // 
            memberDisrictLabel.AutoSize = true;
            memberDisrictLabel.Location = new System.Drawing.Point(501, 386);
            memberDisrictLabel.Name = "memberDisrictLabel";
            memberDisrictLabel.Size = new System.Drawing.Size(84, 29);
            memberDisrictLabel.TabIndex = 20;
            memberDisrictLabel.Text = "อำเภอ :";
            // 
            // memberProvinceLabel
            // 
            memberProvinceLabel.AutoSize = true;
            memberProvinceLabel.Location = new System.Drawing.Point(501, 426);
            memberProvinceLabel.Name = "memberProvinceLabel";
            memberProvinceLabel.Size = new System.Drawing.Size(86, 29);
            memberProvinceLabel.TabIndex = 22;
            memberProvinceLabel.Text = "จังหวัด :";
            // 
            // memberPostalLabel
            // 
            memberPostalLabel.AutoSize = true;
            memberPostalLabel.Location = new System.Drawing.Point(501, 466);
            memberPostalLabel.Name = "memberPostalLabel";
            memberPostalLabel.Size = new System.Drawing.Size(140, 29);
            memberPostalLabel.TabIndex = 24;
            memberPostalLabel.Text = "รหัสไปรษณ์ :";
            // 
            // dataGridMember
            // 
            this.dataGridMember.AutoGenerateColumns = false;
            this.dataGridMember.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.memberLastDataGridViewTextBoxColumn,
            this.memberBDDataGridViewTextBoxColumn,
            this.memberSexDataGridViewTextBoxColumn,
            this.memberTelDataGridViewTextBoxColumn,
            this.memberAddressDataGridViewTextBoxColumn,
            this.memberMooDataGridViewTextBoxColumn,
            this.memberSubDisrictDataGridViewTextBoxColumn,
            this.memberDisrictDataGridViewTextBoxColumn,
            this.memberProvinceDataGridViewTextBoxColumn,
            this.memberPostalDataGridViewTextBoxColumn});
            this.dataGridMember.DataSource = this.memberBindingSource;
            this.dataGridMember.Location = new System.Drawing.Point(21, 47);
            this.dataGridMember.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridMember.Name = "dataGridMember";
            this.dataGridMember.RowHeadersWidth = 51;
            this.dataGridMember.RowTemplate.Height = 24;
            this.dataGridMember.Size = new System.Drawing.Size(1126, 201);
            this.dataGridMember.TabIndex = 0;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberLastDataGridViewTextBoxColumn
            // 
            this.memberLastDataGridViewTextBoxColumn.DataPropertyName = "MemberLast";
            this.memberLastDataGridViewTextBoxColumn.HeaderText = "MemberLast";
            this.memberLastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberLastDataGridViewTextBoxColumn.Name = "memberLastDataGridViewTextBoxColumn";
            this.memberLastDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberBDDataGridViewTextBoxColumn
            // 
            this.memberBDDataGridViewTextBoxColumn.DataPropertyName = "MemberBD";
            this.memberBDDataGridViewTextBoxColumn.HeaderText = "MemberBD";
            this.memberBDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberBDDataGridViewTextBoxColumn.Name = "memberBDDataGridViewTextBoxColumn";
            this.memberBDDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberSexDataGridViewTextBoxColumn
            // 
            this.memberSexDataGridViewTextBoxColumn.DataPropertyName = "MemberSex";
            this.memberSexDataGridViewTextBoxColumn.HeaderText = "MemberSex";
            this.memberSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberSexDataGridViewTextBoxColumn.Name = "memberSexDataGridViewTextBoxColumn";
            this.memberSexDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberTelDataGridViewTextBoxColumn
            // 
            this.memberTelDataGridViewTextBoxColumn.DataPropertyName = "MemberTel";
            this.memberTelDataGridViewTextBoxColumn.HeaderText = "MemberTel";
            this.memberTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberTelDataGridViewTextBoxColumn.Name = "memberTelDataGridViewTextBoxColumn";
            this.memberTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberAddressDataGridViewTextBoxColumn
            // 
            this.memberAddressDataGridViewTextBoxColumn.DataPropertyName = "MemberAddress";
            this.memberAddressDataGridViewTextBoxColumn.HeaderText = "MemberAddress";
            this.memberAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberAddressDataGridViewTextBoxColumn.Name = "memberAddressDataGridViewTextBoxColumn";
            this.memberAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberMooDataGridViewTextBoxColumn
            // 
            this.memberMooDataGridViewTextBoxColumn.DataPropertyName = "MemberMoo";
            this.memberMooDataGridViewTextBoxColumn.HeaderText = "MemberMoo";
            this.memberMooDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberMooDataGridViewTextBoxColumn.Name = "memberMooDataGridViewTextBoxColumn";
            this.memberMooDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberSubDisrictDataGridViewTextBoxColumn
            // 
            this.memberSubDisrictDataGridViewTextBoxColumn.DataPropertyName = "MemberSubDisrict";
            this.memberSubDisrictDataGridViewTextBoxColumn.HeaderText = "MemberSubDisrict";
            this.memberSubDisrictDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberSubDisrictDataGridViewTextBoxColumn.Name = "memberSubDisrictDataGridViewTextBoxColumn";
            this.memberSubDisrictDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberDisrictDataGridViewTextBoxColumn
            // 
            this.memberDisrictDataGridViewTextBoxColumn.DataPropertyName = "MemberDisrict";
            this.memberDisrictDataGridViewTextBoxColumn.HeaderText = "MemberDisrict";
            this.memberDisrictDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberDisrictDataGridViewTextBoxColumn.Name = "memberDisrictDataGridViewTextBoxColumn";
            this.memberDisrictDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberProvinceDataGridViewTextBoxColumn
            // 
            this.memberProvinceDataGridViewTextBoxColumn.DataPropertyName = "MemberProvince";
            this.memberProvinceDataGridViewTextBoxColumn.HeaderText = "MemberProvince";
            this.memberProvinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberProvinceDataGridViewTextBoxColumn.Name = "memberProvinceDataGridViewTextBoxColumn";
            this.memberProvinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberPostalDataGridViewTextBoxColumn
            // 
            this.memberPostalDataGridViewTextBoxColumn.DataPropertyName = "MemberPostal";
            this.memberPostalDataGridViewTextBoxColumn.HeaderText = "MemberPostal";
            this.memberPostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberPostalDataGridViewTextBoxColumn.Name = "memberPostalDataGridViewTextBoxColumn";
            this.memberPostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.cakeDBDataSetMember;
            // 
            // cakeDBDataSetMember
            // 
            this.cakeDBDataSetMember.DataSetName = "CakeDBDataSetMember";
            this.cakeDBDataSetMember.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(253, 263);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberIDTextBox.TabIndex = 3;
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.Location = new System.Drawing.Point(253, 303);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberNameTextBox.TabIndex = 5;
            // 
            // memberLastTextBox
            // 
            this.memberLastTextBox.Location = new System.Drawing.Point(253, 343);
            this.memberLastTextBox.Name = "memberLastTextBox";
            this.memberLastTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberLastTextBox.TabIndex = 7;
            // 
            // memberBDDateTimePicker
            // 
            this.memberBDDateTimePicker.Location = new System.Drawing.Point(253, 383);
            this.memberBDDateTimePicker.Name = "memberBDDateTimePicker";
            this.memberBDDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.memberBDDateTimePicker.TabIndex = 9;
            // 
            // memberSexTextBox
            // 
            this.memberSexTextBox.Location = new System.Drawing.Point(253, 423);
            this.memberSexTextBox.Name = "memberSexTextBox";
            this.memberSexTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberSexTextBox.TabIndex = 11;
            // 
            // memberTelTextBox
            // 
            this.memberTelTextBox.Location = new System.Drawing.Point(253, 463);
            this.memberTelTextBox.Name = "memberTelTextBox";
            this.memberTelTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberTelTextBox.TabIndex = 13;
            // 
            // memberAddressTextBox
            // 
            this.memberAddressTextBox.Location = new System.Drawing.Point(738, 263);
            this.memberAddressTextBox.Name = "memberAddressTextBox";
            this.memberAddressTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberAddressTextBox.TabIndex = 15;
            // 
            // memberMooTextBox
            // 
            this.memberMooTextBox.Location = new System.Drawing.Point(738, 303);
            this.memberMooTextBox.Name = "memberMooTextBox";
            this.memberMooTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberMooTextBox.TabIndex = 17;
            // 
            // memberSubDisrictTextBox
            // 
            this.memberSubDisrictTextBox.Location = new System.Drawing.Point(738, 343);
            this.memberSubDisrictTextBox.Name = "memberSubDisrictTextBox";
            this.memberSubDisrictTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberSubDisrictTextBox.TabIndex = 19;
            // 
            // memberDisrictTextBox
            // 
            this.memberDisrictTextBox.Location = new System.Drawing.Point(738, 383);
            this.memberDisrictTextBox.Name = "memberDisrictTextBox";
            this.memberDisrictTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberDisrictTextBox.TabIndex = 21;
            // 
            // memberProvinceTextBox
            // 
            this.memberProvinceTextBox.Location = new System.Drawing.Point(738, 423);
            this.memberProvinceTextBox.Name = "memberProvinceTextBox";
            this.memberProvinceTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberProvinceTextBox.TabIndex = 23;
            // 
            // memberPostalTextBox
            // 
            this.memberPostalTextBox.Location = new System.Drawing.Point(738, 463);
            this.memberPostalTextBox.Name = "memberPostalTextBox";
            this.memberPostalTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberPostalTextBox.TabIndex = 25;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(969, 352);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(178, 39);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeL
            // 
            this.buttonDeL.Location = new System.Drawing.Point(969, 306);
            this.buttonDeL.Name = "buttonDeL";
            this.buttonDeL.Size = new System.Drawing.Size(178, 40);
            this.buttonDeL.TabIndex = 31;
            this.buttonDeL.Text = "Del";
            this.buttonDeL.UseVisualStyleBackColor = true;
            this.buttonDeL.Click += new System.EventHandler(this.buttonDeL_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(969, 260);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(178, 40);
            this.buttonInsert.TabIndex = 30;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ข้อมูลสมาชิก";
            // 
            // searchcomboBox
            // 
            this.searchcomboBox.FormattingEnabled = true;
            this.searchcomboBox.Items.AddRange(new object[] {
            "รหัสสมาชิก",
            "ชื่อ",
            "นามสกุล",
            "วันเดือนปีเกิด",
            "เพศ",
            "โทรศัพท์",
            "บ้านเลขที่",
            "หมู่",
            "ตำบล",
            "อำเภอ",
            "จังหวัด",
            "รหัสไปรษณ์"});
            this.searchcomboBox.Location = new System.Drawing.Point(636, 4);
            this.searchcomboBox.Name = "searchcomboBox";
            this.searchcomboBox.Size = new System.Drawing.Size(145, 37);
            this.searchcomboBox.TabIndex = 42;
            // 
            // cakesearchbutton
            // 
            this.cakesearchbutton.Location = new System.Drawing.Point(945, 4);
            this.cakesearchbutton.Name = "cakesearchbutton";
            this.cakesearchbutton.Size = new System.Drawing.Size(149, 37);
            this.cakesearchbutton.TabIndex = 41;
            this.cakesearchbutton.Text = "ค้นหา";
            this.cakesearchbutton.UseVisualStyleBackColor = true;
            this.cakesearchbutton.Click += new System.EventHandler(this.cakesearchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(787, 7);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(150, 34);
            this.searchtextBox.TabIndex = 40;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1100, 4);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(47, 37);
            this.buttonR.TabIndex = 48;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // Process09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1172, 517);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.searchcomboBox);
            this.Controls.Add(this.cakesearchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDeL);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(memberNameLabel);
            this.Controls.Add(this.memberNameTextBox);
            this.Controls.Add(memberLastLabel);
            this.Controls.Add(this.memberLastTextBox);
            this.Controls.Add(memberBDLabel);
            this.Controls.Add(this.memberBDDateTimePicker);
            this.Controls.Add(memberSexLabel);
            this.Controls.Add(this.memberSexTextBox);
            this.Controls.Add(memberTelLabel);
            this.Controls.Add(this.memberTelTextBox);
            this.Controls.Add(memberAddressLabel);
            this.Controls.Add(this.memberAddressTextBox);
            this.Controls.Add(memberMooLabel);
            this.Controls.Add(this.memberMooTextBox);
            this.Controls.Add(memberSubDisrictLabel);
            this.Controls.Add(this.memberSubDisrictTextBox);
            this.Controls.Add(memberDisrictLabel);
            this.Controls.Add(this.memberDisrictTextBox);
            this.Controls.Add(memberProvinceLabel);
            this.Controls.Add(this.memberProvinceTextBox);
            this.Controls.Add(memberPostalLabel);
            this.Controls.Add(this.memberPostalTextBox);
            this.Controls.Add(this.dataGridMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Process09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สมัครสมาชิก";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process09_FormClosing);
            this.Load += new System.EventHandler(this.Process09_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDBDataSetMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMember;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.TextBox memberLastTextBox;
        private System.Windows.Forms.DateTimePicker memberBDDateTimePicker;
        private System.Windows.Forms.TextBox memberSexTextBox;
        private System.Windows.Forms.TextBox memberTelTextBox;
        private System.Windows.Forms.TextBox memberAddressTextBox;
        private System.Windows.Forms.TextBox memberMooTextBox;
        private System.Windows.Forms.TextBox memberSubDisrictTextBox;
        private System.Windows.Forms.TextBox memberDisrictTextBox;
        private System.Windows.Forms.TextBox memberProvinceTextBox;
        private System.Windows.Forms.TextBox memberPostalTextBox;
        private CakeDBDataSetMember cakeDBDataSetMember;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private CakeDBDataSetMemberTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberMooDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberSubDisrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberDisrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberPostalDataGridViewTextBoxColumn;
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