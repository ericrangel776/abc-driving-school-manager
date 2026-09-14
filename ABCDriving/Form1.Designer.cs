namespace ABCDriving
{
    partial class Form1
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
            System.Windows.Forms.Label staffIDLabel;
            System.Windows.Forms.Label staffNameLabel;
            System.Windows.Forms.Label staffTypeLabel;
            System.Windows.Forms.Label phoneNumLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label clientNameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TCDriving = new System.Windows.Forms.TabControl();
            this.TPStaff = new System.Windows.Forms.TabPage();
            this.staffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f25_285BDataSet = new ABCDriving.F25_285BDataSet();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.staffNameComboBox = new System.Windows.Forms.ComboBox();
            this.radBtnMonth = new System.Windows.Forms.RadioButton();
            this.radBtnWeek = new System.Windows.Forms.RadioButton();
            this.radBtnToday = new System.Windows.Forms.RadioButton();
            this.classStaffDataGridView = new System.Windows.Forms.DataGridView();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.staffTypeTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.TPClient = new System.Windows.Forms.TabPage();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cboTimeSlot = new System.Windows.Forms.ComboBox();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.clientNameComboBox = new System.Windows.Forms.ComboBox();
            this.cboNewClassInstructor = new System.Windows.Forms.ComboBox();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblAddClass = new System.Windows.Forms.Label();
            this.classClientDataGridView = new System.Windows.Forms.DataGridView();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.TPAddClient = new System.Windows.Forms.TabPage();
            this.btnSubmitClient = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.TPSchduleReport = new System.Windows.Forms.TabPage();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtpDateReport = new System.Windows.Forms.DateTimePicker();
            this.lblDateReport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new ABCDriving.F25_285BDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new ABCDriving.F25_285BDataSetTableAdapters.TableAdapterManager();
            this.classTableAdapter = new ABCDriving.F25_285BDataSetTableAdapters.ClassTableAdapter();
            this.clientTableAdapter = new ABCDriving.F25_285BDataSetTableAdapters.ClientTableAdapter();
            staffIDLabel = new System.Windows.Forms.Label();
            staffNameLabel = new System.Windows.Forms.Label();
            staffTypeLabel = new System.Windows.Forms.Label();
            phoneNumLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            clientNameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            this.TCDriving.SuspendLayout();
            this.TPStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).BeginInit();
            this.staffBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f25_285BDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classStaffDataGridView)).BeginInit();
            this.TPClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classClientDataGridView)).BeginInit();
            this.TPAddClient.SuspendLayout();
            this.TPSchduleReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(20, 55);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(69, 20);
            staffIDLabel.TabIndex = 0;
            staffIDLabel.Text = "Staff ID:";
            // 
            // staffNameLabel
            // 
            staffNameLabel.AutoSize = true;
            staffNameLabel.Location = new System.Drawing.Point(20, 87);
            staffNameLabel.Name = "staffNameLabel";
            staffNameLabel.Size = new System.Drawing.Size(94, 20);
            staffNameLabel.TabIndex = 2;
            staffNameLabel.Text = "Staff Name:";
            // 
            // staffTypeLabel
            // 
            staffTypeLabel.AutoSize = true;
            staffTypeLabel.Location = new System.Drawing.Point(20, 119);
            staffTypeLabel.Name = "staffTypeLabel";
            staffTypeLabel.Size = new System.Drawing.Size(86, 20);
            staffTypeLabel.TabIndex = 4;
            staffTypeLabel.Text = "Staff Type:";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new System.Drawing.Point(20, 151);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new System.Drawing.Size(96, 20);
            phoneNumLabel.TabIndex = 6;
            phoneNumLabel.Text = "Phone Num:";
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(19, 58);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(74, 20);
            clientIDLabel.TabIndex = 0;
            clientIDLabel.Text = "Client ID:";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new System.Drawing.Point(19, 90);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(99, 20);
            clientNameLabel.TabIndex = 2;
            clientNameLabel.Text = "Client Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(19, 122);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(42, 20);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(19, 154);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            // 
            // TCDriving
            // 
            this.TCDriving.Controls.Add(this.TPStaff);
            this.TCDriving.Controls.Add(this.TPClient);
            this.TCDriving.Controls.Add(this.TPAddClient);
            this.TCDriving.Controls.Add(this.TPSchduleReport);
            this.TCDriving.Location = new System.Drawing.Point(12, 12);
            this.TCDriving.Name = "TCDriving";
            this.TCDriving.SelectedIndex = 0;
            this.TCDriving.Size = new System.Drawing.Size(1075, 617);
            this.TCDriving.TabIndex = 0;
            // 
            // TPStaff
            // 
            this.TPStaff.AutoScroll = true;
            this.TPStaff.Controls.Add(this.staffBindingNavigator);
            this.TPStaff.Controls.Add(this.staffNameComboBox);
            this.TPStaff.Controls.Add(this.radBtnMonth);
            this.TPStaff.Controls.Add(this.radBtnWeek);
            this.TPStaff.Controls.Add(this.radBtnToday);
            this.TPStaff.Controls.Add(this.classStaffDataGridView);
            this.TPStaff.Controls.Add(staffIDLabel);
            this.TPStaff.Controls.Add(this.staffIDTextBox);
            this.TPStaff.Controls.Add(staffNameLabel);
            this.TPStaff.Controls.Add(staffTypeLabel);
            this.TPStaff.Controls.Add(this.staffTypeTextBox);
            this.TPStaff.Controls.Add(phoneNumLabel);
            this.TPStaff.Controls.Add(this.phoneNumTextBox);
            this.TPStaff.Location = new System.Drawing.Point(4, 29);
            this.TPStaff.Name = "TPStaff";
            this.TPStaff.Padding = new System.Windows.Forms.Padding(3);
            this.TPStaff.Size = new System.Drawing.Size(1067, 584);
            this.TPStaff.TabIndex = 0;
            this.TPStaff.Text = "Staff Info";
            this.TPStaff.UseVisualStyleBackColor = true;
            // 
            // staffBindingNavigator
            // 
            this.staffBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.staffBindingNavigator.BindingSource = this.staffBindingSource;
            this.staffBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.staffBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.staffBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.staffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.staffBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.staffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.staffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.staffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.staffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.staffBindingNavigator.Name = "staffBindingNavigator";
            this.staffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.staffBindingNavigator.Size = new System.Drawing.Size(1061, 33);
            this.staffBindingNavigator.TabIndex = 13;
            this.staffBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.f25_285BDataSet;
            // 
            // f25_285BDataSet
            // 
            this.f25_285BDataSet.DataSetName = "F25_285BDataSet";
            this.f25_285BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // staffNameComboBox
            // 
            this.staffNameComboBox.DataSource = this.staffBindingSource;
            this.staffNameComboBox.DisplayMember = "StaffName";
            this.staffNameComboBox.FormattingEnabled = true;
            this.staffNameComboBox.Location = new System.Drawing.Point(122, 82);
            this.staffNameComboBox.Name = "staffNameComboBox";
            this.staffNameComboBox.Size = new System.Drawing.Size(179, 28);
            this.staffNameComboBox.TabIndex = 12;
            this.staffNameComboBox.ValueMember = "StaffID";
            // 
            // radBtnMonth
            // 
            this.radBtnMonth.AutoSize = true;
            this.radBtnMonth.Location = new System.Drawing.Point(408, 147);
            this.radBtnMonth.Name = "radBtnMonth";
            this.radBtnMonth.Size = new System.Drawing.Size(115, 24);
            this.radBtnMonth.TabIndex = 11;
            this.radBtnMonth.Text = "Next Month";
            this.radBtnMonth.UseVisualStyleBackColor = true;
            this.radBtnMonth.CheckedChanged += new System.EventHandler(this.radBtnMonth_CheckedChanged);
            // 
            // radBtnWeek
            // 
            this.radBtnWeek.AutoSize = true;
            this.radBtnWeek.Checked = true;
            this.radBtnWeek.Location = new System.Drawing.Point(408, 115);
            this.radBtnWeek.Name = "radBtnWeek";
            this.radBtnWeek.Size = new System.Drawing.Size(111, 24);
            this.radBtnWeek.TabIndex = 10;
            this.radBtnWeek.TabStop = true;
            this.radBtnWeek.Text = "Next Week";
            this.radBtnWeek.UseVisualStyleBackColor = true;
            this.radBtnWeek.CheckedChanged += new System.EventHandler(this.radBtnWeek_CheckedChanged);
            // 
            // radBtnToday
            // 
            this.radBtnToday.AutoSize = true;
            this.radBtnToday.Location = new System.Drawing.Point(408, 83);
            this.radBtnToday.Name = "radBtnToday";
            this.radBtnToday.Size = new System.Drawing.Size(77, 24);
            this.radBtnToday.TabIndex = 9;
            this.radBtnToday.Text = "Today";
            this.radBtnToday.UseVisualStyleBackColor = true;
            this.radBtnToday.CheckedChanged += new System.EventHandler(this.radBtnToday_CheckedChanged);
            // 
            // classStaffDataGridView
            // 
            this.classStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classStaffDataGridView.Location = new System.Drawing.Point(6, 199);
            this.classStaffDataGridView.Name = "classStaffDataGridView";
            this.classStaffDataGridView.RowHeadersWidth = 62;
            this.classStaffDataGridView.RowTemplate.Height = 28;
            this.classStaffDataGridView.Size = new System.Drawing.Size(1055, 359);
            this.classStaffDataGridView.TabIndex = 8;
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(122, 52);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.ReadOnly = true;
            this.staffIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.staffIDTextBox.TabIndex = 1;
            this.staffIDTextBox.TextChanged += new System.EventHandler(this.staffIDTextBox_TextChanged);
            // 
            // staffTypeTextBox
            // 
            this.staffTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffType", true));
            this.staffTypeTextBox.Location = new System.Drawing.Point(122, 116);
            this.staffTypeTextBox.Name = "staffTypeTextBox";
            this.staffTypeTextBox.ReadOnly = true;
            this.staffTypeTextBox.Size = new System.Drawing.Size(134, 26);
            this.staffTypeTextBox.TabIndex = 5;
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "PhoneNum", true));
            this.phoneNumTextBox.Location = new System.Drawing.Point(122, 148);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.ReadOnly = true;
            this.phoneNumTextBox.Size = new System.Drawing.Size(134, 26);
            this.phoneNumTextBox.TabIndex = 7;
            // 
            // TPClient
            // 
            this.TPClient.Controls.Add(this.btnAddClass);
            this.TPClient.Controls.Add(this.clientBindingNavigator);
            this.TPClient.Controls.Add(this.cboTimeSlot);
            this.TPClient.Controls.Add(this.dtpClassDate);
            this.TPClient.Controls.Add(this.clientNameComboBox);
            this.TPClient.Controls.Add(this.cboNewClassInstructor);
            this.TPClient.Controls.Add(this.lblTimeSlot);
            this.TPClient.Controls.Add(this.lblDate);
            this.TPClient.Controls.Add(this.lblInstructor);
            this.TPClient.Controls.Add(this.lblAddClass);
            this.TPClient.Controls.Add(this.classClientDataGridView);
            this.TPClient.Controls.Add(clientIDLabel);
            this.TPClient.Controls.Add(this.clientIDTextBox);
            this.TPClient.Controls.Add(clientNameLabel);
            this.TPClient.Controls.Add(ageLabel);
            this.TPClient.Controls.Add(this.ageTextBox);
            this.TPClient.Controls.Add(genderLabel);
            this.TPClient.Controls.Add(this.genderTextBox);
            this.TPClient.Location = new System.Drawing.Point(4, 29);
            this.TPClient.Name = "TPClient";
            this.TPClient.Padding = new System.Windows.Forms.Padding(3);
            this.TPClient.Size = new System.Drawing.Size(1067, 584);
            this.TPClient.TabIndex = 1;
            this.TPClient.Text = "Client Info";
            this.TPClient.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(681, 151);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(98, 33);
            this.btnAddClass.TabIndex = 18;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.clientBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(1061, 33);
            this.clientBindingNavigator.TabIndex = 17;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.f25_285BDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // cboTimeSlot
            // 
            this.cboTimeSlot.FormattingEnabled = true;
            this.cboTimeSlot.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cboTimeSlot.Location = new System.Drawing.Point(489, 154);
            this.cboTimeSlot.Name = "cboTimeSlot";
            this.cboTimeSlot.Size = new System.Drawing.Size(155, 28);
            this.cboTimeSlot.TabIndex = 16;
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClassDate.Location = new System.Drawing.Point(489, 122);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(155, 26);
            this.dtpClassDate.TabIndex = 15;
            // 
            // clientNameComboBox
            // 
            this.clientNameComboBox.DataSource = this.clientBindingSource;
            this.clientNameComboBox.DisplayMember = "ClientName";
            this.clientNameComboBox.FormattingEnabled = true;
            this.clientNameComboBox.Location = new System.Drawing.Point(124, 87);
            this.clientNameComboBox.Name = "clientNameComboBox";
            this.clientNameComboBox.Size = new System.Drawing.Size(159, 28);
            this.clientNameComboBox.TabIndex = 14;
            this.clientNameComboBox.ValueMember = "ClientID";
            // 
            // cboNewClassInstructor
            // 
            this.cboNewClassInstructor.DataSource = this.staffBindingSource;
            this.cboNewClassInstructor.DisplayMember = "StaffName";
            this.cboNewClassInstructor.FormattingEnabled = true;
            this.cboNewClassInstructor.Location = new System.Drawing.Point(489, 87);
            this.cboNewClassInstructor.Name = "cboNewClassInstructor";
            this.cboNewClassInstructor.Size = new System.Drawing.Size(155, 28);
            this.cboNewClassInstructor.TabIndex = 13;
            this.cboNewClassInstructor.ValueMember = "StaffID";
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(402, 154);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(79, 20);
            this.lblTimeSlot.TabIndex = 12;
            this.lblTimeSlot.Text = "Time Slot:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(402, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(402, 90);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(81, 20);
            this.lblInstructor.TabIndex = 10;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblAddClass
            // 
            this.lblAddClass.AutoSize = true;
            this.lblAddClass.Location = new System.Drawing.Point(368, 58);
            this.lblAddClass.Name = "lblAddClass";
            this.lblAddClass.Size = new System.Drawing.Size(209, 20);
            this.lblAddClass.TabIndex = 9;
            this.lblAddClass.Text = "Add Class for Current Client:";
            // 
            // classClientDataGridView
            // 
            this.classClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classClientDataGridView.Location = new System.Drawing.Point(6, 203);
            this.classClientDataGridView.Name = "classClientDataGridView";
            this.classClientDataGridView.RowHeadersWidth = 62;
            this.classClientDataGridView.RowTemplate.Height = 28;
            this.classClientDataGridView.Size = new System.Drawing.Size(1055, 365);
            this.classClientDataGridView.TabIndex = 8;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(124, 55);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.ReadOnly = true;
            this.clientIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.clientIDTextBox.TabIndex = 1;
            this.clientIDTextBox.TextChanged += new System.EventHandler(this.clientIDTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(124, 119);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(100, 26);
            this.ageTextBox.TabIndex = 5;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(124, 151);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(100, 26);
            this.genderTextBox.TabIndex = 7;
            // 
            // TPAddClient
            // 
            this.TPAddClient.Controls.Add(this.btnSubmitClient);
            this.TPAddClient.Controls.Add(this.txtGender);
            this.TPAddClient.Controls.Add(this.txtAge);
            this.TPAddClient.Controls.Add(this.txtName);
            this.TPAddClient.Controls.Add(this.lblGender);
            this.TPAddClient.Controls.Add(this.lblAge);
            this.TPAddClient.Controls.Add(this.lblName);
            this.TPAddClient.Controls.Add(this.lblAddClient);
            this.TPAddClient.Location = new System.Drawing.Point(4, 29);
            this.TPAddClient.Name = "TPAddClient";
            this.TPAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.TPAddClient.Size = new System.Drawing.Size(1067, 584);
            this.TPAddClient.TabIndex = 2;
            this.TPAddClient.Text = "Add Client";
            this.TPAddClient.UseVisualStyleBackColor = true;
            // 
            // btnSubmitClient
            // 
            this.btnSubmitClient.Location = new System.Drawing.Point(240, 189);
            this.btnSubmitClient.Name = "btnSubmitClient";
            this.btnSubmitClient.Size = new System.Drawing.Size(78, 33);
            this.btnSubmitClient.TabIndex = 7;
            this.btnSubmitClient.Text = "Submit";
            this.btnSubmitClient.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(192, 142);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(126, 26);
            this.txtGender.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(192, 107);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(126, 26);
            this.txtAge.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 26);
            this.txtName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(71, 142);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(111, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Client Gender:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(71, 107);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(86, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Client Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Client Name:";
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Location = new System.Drawing.Point(33, 36);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(134, 20);
            this.lblAddClient.TabIndex = 0;
            this.lblAddClient.Text = "Add a New Client:";
            // 
            // TPSchduleReport
            // 
            this.TPSchduleReport.Controls.Add(this.btnGenerateReport);
            this.TPSchduleReport.Controls.Add(this.dtpDateReport);
            this.TPSchduleReport.Controls.Add(this.lblDateReport);
            this.TPSchduleReport.Controls.Add(this.label1);
            this.TPSchduleReport.Location = new System.Drawing.Point(4, 29);
            this.TPSchduleReport.Name = "TPSchduleReport";
            this.TPSchduleReport.Padding = new System.Windows.Forms.Padding(3);
            this.TPSchduleReport.Size = new System.Drawing.Size(1067, 584);
            this.TPSchduleReport.TabIndex = 3;
            this.TPSchduleReport.Text = "Class Schdule Report";
            this.TPSchduleReport.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(329, 74);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(152, 28);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dtpDateReport
            // 
            this.dtpDateReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReport.Location = new System.Drawing.Point(125, 73);
            this.dtpDateReport.Name = "dtpDateReport";
            this.dtpDateReport.Size = new System.Drawing.Size(136, 26);
            this.dtpDateReport.TabIndex = 2;
            // 
            // lblDateReport
            // 
            this.lblDateReport.AutoSize = true;
            this.lblDateReport.Location = new System.Drawing.Point(71, 78);
            this.lblDateReport.Name = "lblDateReport";
            this.lblDateReport.Size = new System.Drawing.Size(48, 20);
            this.lblDateReport.TabIndex = 1;
            this.lblDateReport.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate an Excel Report with all the Classes on a given day:";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "FK_Class_Instructor";
            this.classBindingSource.DataSource = this.staffBindingSource;
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataMember = "FK_Class_Client";
            this.classBindingSource1.DataSource = this.clientBindingSource;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = ABCDriving.F25_285BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 641);
            this.Controls.Add(this.TCDriving);
            this.Name = "Form1";
            this.Text = "ABCDriving Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TCDriving.ResumeLayout(false);
            this.TPStaff.ResumeLayout(false);
            this.TPStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).EndInit();
            this.staffBindingNavigator.ResumeLayout(false);
            this.staffBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f25_285BDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classStaffDataGridView)).EndInit();
            this.TPClient.ResumeLayout(false);
            this.TPClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classClientDataGridView)).EndInit();
            this.TPAddClient.ResumeLayout(false);
            this.TPAddClient.PerformLayout();
            this.TPSchduleReport.ResumeLayout(false);
            this.TPSchduleReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCDriving;
        private System.Windows.Forms.TabPage TPStaff;
        private System.Windows.Forms.TabPage TPClient;
        private System.Windows.Forms.TabPage TPAddClient;
        private F25_285BDataSet f25_285BDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private F25_285BDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private F25_285BDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox staffIDTextBox;
        private System.Windows.Forms.TextBox staffTypeTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.BindingSource classBindingSource;
        private F25_285BDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridView classStaffDataGridView;
        private System.Windows.Forms.RadioButton radBtnMonth;
        private System.Windows.Forms.RadioButton radBtnWeek;
        private System.Windows.Forms.RadioButton radBtnToday;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private F25_285BDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.DataGridView classClientDataGridView;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblAddClass;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddClient;
        private System.Windows.Forms.Button btnSubmitClient;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboNewClassInstructor;
        private System.Windows.Forms.ComboBox staffNameComboBox;
        private System.Windows.Forms.ComboBox clientNameComboBox;
        private System.Windows.Forms.ComboBox cboTimeSlot;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.BindingNavigator staffBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TabPage TPSchduleReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateReport;
        private System.Windows.Forms.DateTimePicker dtpDateReport;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}

