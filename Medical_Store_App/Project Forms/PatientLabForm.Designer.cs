
namespace Medical_Store_App.Project_Forms
{
    partial class PatientLabForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBoxPatientInfo = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dGridViewPatientInfo = new System.Windows.Forms.DataGridView();
            this.patId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.addTest = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnSavePatient = new System.Windows.Forms.Button();
            this.dateTimePickerVisitDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPatAddress = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTestId = new System.Windows.Forms.TextBox();
            this.grpBoxDetails = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPayableAmountValue = new System.Windows.Forms.Label();
            this.lblPayableAmountTitle = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblGivenDiscountTitle = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmountTitle = new System.Windows.Forms.Label();
            this.lblPatientNameValue = new System.Windows.Forms.Label();
            this.lblPatientNameInDetail = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.comboBoxPatientTest = new System.Windows.Forms.ComboBox();
            this.testInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet5 = new Medical_Store_App.MedicalStoreDataSet5();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblPatId = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.dGridViewPatTestInfo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.testDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.dateTimePickerTestDate = new System.Windows.Forms.DateTimePicker();
            this.lblTestDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPatName = new System.Windows.Forms.Label();
            this.txtTestPatName = new System.Windows.Forms.TextBox();
            this.lblPatientTestInfo = new System.Windows.Forms.Label();
            this.testInfoesTableAdapter = new Medical_Store_App.MedicalStoreDataSet5TableAdapters.TestInfoesTableAdapter();
            this.grpBoxPatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPatientInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPatTestInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxPatientInfo
            // 
            this.grpBoxPatientInfo.Controls.Add(this.txtGender);
            this.grpBoxPatientInfo.Controls.Add(this.txtId);
            this.grpBoxPatientInfo.Controls.Add(this.lblGender);
            this.grpBoxPatientInfo.Controls.Add(this.dGridViewPatientInfo);
            this.grpBoxPatientInfo.Controls.Add(this.btnSavePatient);
            this.grpBoxPatientInfo.Controls.Add(this.dateTimePickerVisitDate);
            this.grpBoxPatientInfo.Controls.Add(this.lblDate);
            this.grpBoxPatientInfo.Controls.Add(this.lblAddress);
            this.grpBoxPatientInfo.Controls.Add(this.txtPatAddress);
            this.grpBoxPatientInfo.Controls.Add(this.lblPatientName);
            this.grpBoxPatientInfo.Controls.Add(this.txtPatientName);
            this.grpBoxPatientInfo.Controls.Add(this.lblPatientInfo);
            this.grpBoxPatientInfo.Location = new System.Drawing.Point(7, 3);
            this.grpBoxPatientInfo.Name = "grpBoxPatientInfo";
            this.grpBoxPatientInfo.Size = new System.Drawing.Size(1353, 245);
            this.grpBoxPatientInfo.TabIndex = 0;
            this.grpBoxPatientInfo.TabStop = false;
            this.grpBoxPatientInfo.Text = "Patient Info";
            // 
            // txtGender
            // 
            this.txtGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.txtGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGender.Location = new System.Drawing.Point(6, 97);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(221, 20);
            this.txtGender.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(160, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(73, 20);
            this.txtId.TabIndex = 12;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGender.Location = new System.Drawing.Point(6, 78);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // dGridViewPatientInfo
            // 
            this.dGridViewPatientInfo.AllowUserToAddRows = false;
            this.dGridViewPatientInfo.AllowUserToDeleteRows = false;
            this.dGridViewPatientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewPatientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewPatientInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patId,
            this.patName,
            this.Gender,
            this.Address,
            this.Date,
            this.Edit,
            this.addTest,
            this.Delete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewPatientInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGridViewPatientInfo.Location = new System.Drawing.Point(239, 9);
            this.dGridViewPatientInfo.Name = "dGridViewPatientInfo";
            this.dGridViewPatientInfo.ReadOnly = true;
            this.dGridViewPatientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewPatientInfo.Size = new System.Drawing.Size(1094, 219);
            this.dGridViewPatientInfo.TabIndex = 9;
            this.dGridViewPatientInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewPatientInfo_CellContentClick);
            // 
            // patId
            // 
            this.patId.DataPropertyName = "Id";
            this.patId.HeaderText = "Patient Id";
            this.patId.Name = "patId";
            this.patId.ReadOnly = true;
            // 
            // patName
            // 
            this.patName.DataPropertyName = "Name";
            this.patName.HeaderText = "Patient Name";
            this.patName.Name = "patName";
            this.patName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Visit_Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // addTest
            // 
            this.addTest.HeaderText = "Add Test";
            this.addTest.Name = "addTest";
            this.addTest.ReadOnly = true;
            this.addTest.Text = "Add Test";
            this.addTest.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // btnSavePatient
            // 
            this.btnSavePatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSavePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePatient.ForeColor = System.Drawing.Color.White;
            this.btnSavePatient.Location = new System.Drawing.Point(6, 205);
            this.btnSavePatient.Name = "btnSavePatient";
            this.btnSavePatient.Size = new System.Drawing.Size(221, 31);
            this.btnSavePatient.TabIndex = 5;
            this.btnSavePatient.Text = "Save";
            this.btnSavePatient.UseVisualStyleBackColor = false;
            this.btnSavePatient.Click += new System.EventHandler(this.btnSavePatient_Click);
            // 
            // dateTimePickerVisitDate
            // 
            this.dateTimePickerVisitDate.Location = new System.Drawing.Point(6, 178);
            this.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            this.dateTimePickerVisitDate.Size = new System.Drawing.Size(221, 20);
            this.dateTimePickerVisitDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDate.Location = new System.Drawing.Point(6, 159);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAddress.Location = new System.Drawing.Point(4, 117);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtPatAddress
            // 
            this.txtPatAddress.Location = new System.Drawing.Point(6, 136);
            this.txtPatAddress.Name = "txtPatAddress";
            this.txtPatAddress.Size = new System.Drawing.Size(221, 20);
            this.txtPatAddress.TabIndex = 3;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPatientName.Location = new System.Drawing.Point(6, 37);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(41, 15);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(6, 56);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(221, 20);
            this.txtPatientName.TabIndex = 1;
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.AutoSize = true;
            this.lblPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPatientInfo.Location = new System.Drawing.Point(34, 16);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Size = new System.Drawing.Size(163, 20);
            this.lblPatientInfo.TabIndex = 0;
            this.lblPatientInfo.Text = "Patient Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTestId);
            this.groupBox1.Controls.Add(this.grpBoxDetails);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.comboBoxPatientTest);
            this.groupBox1.Controls.Add(this.lblTest);
            this.groupBox1.Controls.Add(this.lblPatId);
            this.groupBox1.Controls.Add(this.txtPatientId);
            this.groupBox1.Controls.Add(this.dGridViewPatTestInfo);
            this.groupBox1.Controls.Add(this.btnSaveTest);
            this.groupBox1.Controls.Add(this.dateTimePickerTestDate);
            this.groupBox1.Controls.Add(this.lblTestDate);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblPatName);
            this.groupBox1.Controls.Add(this.txtTestPatName);
            this.groupBox1.Controls.Add(this.lblPatientTestInfo);
            this.groupBox1.Location = new System.Drawing.Point(7, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1353, 363);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // txtTestId
            // 
            this.txtTestId.Location = new System.Drawing.Point(129, 38);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.Size = new System.Drawing.Size(100, 20);
            this.txtTestId.TabIndex = 18;
            // 
            // grpBoxDetails
            // 
            this.grpBoxDetails.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpBoxDetails.Controls.Add(this.button2);
            this.grpBoxDetails.Controls.Add(this.lblPayableAmountValue);
            this.grpBoxDetails.Controls.Add(this.lblPayableAmountTitle);
            this.grpBoxDetails.Controls.Add(this.lblDiscountValue);
            this.grpBoxDetails.Controls.Add(this.lblGivenDiscountTitle);
            this.grpBoxDetails.Controls.Add(this.lblTotalAmountValue);
            this.grpBoxDetails.Controls.Add(this.lblTotalAmountTitle);
            this.grpBoxDetails.Controls.Add(this.lblPatientNameValue);
            this.grpBoxDetails.Controls.Add(this.lblPatientNameInDetail);
            this.grpBoxDetails.ForeColor = System.Drawing.Color.White;
            this.grpBoxDetails.Location = new System.Drawing.Point(233, 10);
            this.grpBoxDetails.Name = "grpBoxDetails";
            this.grpBoxDetails.Size = new System.Drawing.Size(1120, 46);
            this.grpBoxDetails.TabIndex = 17;
            this.grpBoxDetails.TabStop = false;
            this.grpBoxDetails.Text = "Details";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Medical_Store_App.Properties.Resources.printImg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1043, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 35);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblPayableAmountValue
            // 
            this.lblPayableAmountValue.AutoSize = true;
            this.lblPayableAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableAmountValue.Location = new System.Drawing.Point(932, 17);
            this.lblPayableAmountValue.Name = "lblPayableAmountValue";
            this.lblPayableAmountValue.Size = new System.Drawing.Size(17, 17);
            this.lblPayableAmountValue.TabIndex = 7;
            this.lblPayableAmountValue.Text = "0";
            // 
            // lblPayableAmountTitle
            // 
            this.lblPayableAmountTitle.AutoSize = true;
            this.lblPayableAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableAmountTitle.Location = new System.Drawing.Point(789, 17);
            this.lblPayableAmountTitle.Name = "lblPayableAmountTitle";
            this.lblPayableAmountTitle.Size = new System.Drawing.Size(140, 17);
            this.lblPayableAmountTitle.TabIndex = 6;
            this.lblPayableAmountTitle.Text = "Payable Amount : ";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountValue.Location = new System.Drawing.Point(649, 17);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(17, 17);
            this.lblDiscountValue.TabIndex = 5;
            this.lblDiscountValue.Text = "0";
            // 
            // lblGivenDiscountTitle
            // 
            this.lblGivenDiscountTitle.AutoSize = true;
            this.lblGivenDiscountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGivenDiscountTitle.Location = new System.Drawing.Point(522, 17);
            this.lblGivenDiscountTitle.Name = "lblGivenDiscountTitle";
            this.lblGivenDiscountTitle.Size = new System.Drawing.Size(86, 17);
            this.lblGivenDiscountTitle.TabIndex = 4;
            this.lblGivenDiscountTitle.Text = "Discount : ";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(379, 17);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(17, 17);
            this.lblTotalAmountValue.TabIndex = 3;
            this.lblTotalAmountValue.Text = "0";
            // 
            // lblTotalAmountTitle
            // 
            this.lblTotalAmountTitle.AutoSize = true;
            this.lblTotalAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTitle.Location = new System.Drawing.Point(252, 17);
            this.lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            this.lblTotalAmountTitle.Size = new System.Drawing.Size(119, 17);
            this.lblTotalAmountTitle.TabIndex = 2;
            this.lblTotalAmountTitle.Text = "Total Amount : ";
            // 
            // lblPatientNameValue
            // 
            this.lblPatientNameValue.AutoSize = true;
            this.lblPatientNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNameValue.Location = new System.Drawing.Point(134, 17);
            this.lblPatientNameValue.Name = "lblPatientNameValue";
            this.lblPatientNameValue.Size = new System.Drawing.Size(47, 17);
            this.lblPatientNameValue.TabIndex = 1;
            this.lblPatientNameValue.Text = "name";
            // 
            // lblPatientNameInDetail
            // 
            this.lblPatientNameInDetail.AutoSize = true;
            this.lblPatientNameInDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNameInDetail.Location = new System.Drawing.Point(7, 17);
            this.lblPatientNameInDetail.Name = "lblPatientNameInDetail";
            this.lblPatientNameInDetail.Size = new System.Drawing.Size(120, 17);
            this.lblPatientNameInDetail.TabIndex = 0;
            this.lblPatientNameInDetail.Text = "Patient Name : ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscount.Location = new System.Drawing.Point(9, 208);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 15);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(9, 227);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(221, 20);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.Text = "0";
            // 
            // comboBoxPatientTest
            // 
            this.comboBoxPatientTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxPatientTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPatientTest.DataSource = this.testInfoesBindingSource;
            this.comboBoxPatientTest.DisplayMember = "Name";
            this.comboBoxPatientTest.FormattingEnabled = true;
            this.comboBoxPatientTest.Location = new System.Drawing.Point(9, 144);
            this.comboBoxPatientTest.Name = "comboBoxPatientTest";
            this.comboBoxPatientTest.Size = new System.Drawing.Size(221, 21);
            this.comboBoxPatientTest.TabIndex = 14;
            this.comboBoxPatientTest.ValueMember = "Id";
            this.comboBoxPatientTest.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatientTest_SelectedIndexChanged);
            // 
            // testInfoesBindingSource
            // 
            this.testInfoesBindingSource.DataMember = "TestInfoes";
            this.testInfoesBindingSource.DataSource = this.medicalStoreDataSet5;
            // 
            // medicalStoreDataSet5
            // 
            this.medicalStoreDataSet5.DataSetName = "MedicalStoreDataSet5";
            this.medicalStoreDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTest.Location = new System.Drawing.Point(9, 125);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(30, 15);
            this.lblTest.TabIndex = 13;
            this.lblTest.Text = "Test";
            // 
            // lblPatId
            // 
            this.lblPatId.AutoSize = true;
            this.lblPatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPatId.Location = new System.Drawing.Point(9, 41);
            this.lblPatId.Name = "lblPatId";
            this.lblPatId.Size = new System.Drawing.Size(58, 15);
            this.lblPatId.TabIndex = 11;
            this.lblPatId.Text = "Patient Id";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(9, 60);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(221, 20);
            this.txtPatientId.TabIndex = 10;
            // 
            // dGridViewPatTestInfo
            // 
            this.dGridViewPatTestInfo.AllowUserToAddRows = false;
            this.dGridViewPatTestInfo.AllowUserToDeleteRows = false;
            this.dGridViewPatTestInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewPatTestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewPatTestInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Test,
            this.Price,
            this.grdDiscount,
            this.Total,
            this.testDate,
            this.testEdit,
            this.testDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewPatTestInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridViewPatTestInfo.Location = new System.Drawing.Point(233, 60);
            this.dGridViewPatTestInfo.Name = "dGridViewPatTestInfo";
            this.dGridViewPatTestInfo.ReadOnly = true;
            this.dGridViewPatTestInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewPatTestInfo.Size = new System.Drawing.Size(1100, 308);
            this.dGridViewPatTestInfo.TabIndex = 9;
            this.dGridViewPatTestInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewPatTestInfo_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Test
            // 
            this.Test.DataPropertyName = "Name";
            this.Test.HeaderText = "Test";
            this.Test.Name = "Test";
            this.Test.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // grdDiscount
            // 
            this.grdDiscount.DataPropertyName = "Discount";
            this.grdDiscount.HeaderText = "Discount";
            this.grdDiscount.Name = "grdDiscount";
            this.grdDiscount.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total_Amount";
            this.Total.HeaderText = "Total Amount";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // testDate
            // 
            this.testDate.DataPropertyName = "Visit_Date";
            this.testDate.HeaderText = "Date";
            this.testDate.Name = "testDate";
            this.testDate.ReadOnly = true;
            // 
            // testEdit
            // 
            this.testEdit.HeaderText = "Edit";
            this.testEdit.Name = "testEdit";
            this.testEdit.ReadOnly = true;
            this.testEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.testEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.testEdit.Text = "Edit";
            this.testEdit.UseColumnTextForLinkValue = true;
            // 
            // testDelete
            // 
            this.testDelete.HeaderText = "Delete";
            this.testDelete.Name = "testDelete";
            this.testDelete.ReadOnly = true;
            this.testDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.testDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.testDelete.Text = "Delete";
            this.testDelete.UseColumnTextForLinkValue = true;
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTest.ForeColor = System.Drawing.Color.White;
            this.btnSaveTest.Location = new System.Drawing.Point(9, 311);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(221, 31);
            this.btnSaveTest.TabIndex = 8;
            this.btnSaveTest.Text = "Save";
            this.btnSaveTest.UseVisualStyleBackColor = false;
            this.btnSaveTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerTestDate
            // 
            this.dateTimePickerTestDate.Location = new System.Drawing.Point(9, 270);
            this.dateTimePickerTestDate.Name = "dateTimePickerTestDate";
            this.dateTimePickerTestDate.Size = new System.Drawing.Size(221, 20);
            this.dateTimePickerTestDate.TabIndex = 7;
            // 
            // lblTestDate
            // 
            this.lblTestDate.AutoSize = true;
            this.lblTestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTestDate.Location = new System.Drawing.Point(9, 252);
            this.lblTestDate.Name = "lblTestDate";
            this.lblTestDate.Size = new System.Drawing.Size(33, 15);
            this.lblTestDate.TabIndex = 6;
            this.lblTestDate.Text = "Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrice.Location = new System.Drawing.Point(7, 168);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(9, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(221, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPatName.Location = new System.Drawing.Point(9, 83);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(82, 15);
            this.lblPatName.TabIndex = 2;
            this.lblPatName.Text = "Patient Name";
            // 
            // txtTestPatName
            // 
            this.txtTestPatName.Location = new System.Drawing.Point(9, 102);
            this.txtTestPatName.Name = "txtTestPatName";
            this.txtTestPatName.Size = new System.Drawing.Size(221, 20);
            this.txtTestPatName.TabIndex = 1;
            // 
            // lblPatientTestInfo
            // 
            this.lblPatientTestInfo.AutoSize = true;
            this.lblPatientTestInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientTestInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPatientTestInfo.Location = new System.Drawing.Point(2, 16);
            this.lblPatientTestInfo.Name = "lblPatientTestInfo";
            this.lblPatientTestInfo.Size = new System.Drawing.Size(212, 20);
            this.lblPatientTestInfo.TabIndex = 0;
            this.lblPatientTestInfo.Text = "Patient Tests Information";
            // 
            // testInfoesTableAdapter
            // 
            this.testInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // PatientLabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 620);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxPatientInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientLabForm";
            this.Text = "Patient Lab Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PatientLabForm_Load);
            this.grpBoxPatientInfo.ResumeLayout(false);
            this.grpBoxPatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPatientInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxDetails.ResumeLayout(false);
            this.grpBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPatTestInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPatientInfo;
        private System.Windows.Forms.Button btnSavePatient;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisitDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPatAddress;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.DateTimePicker dateTimePickerTestDate;
        private System.Windows.Forms.Label lblTestDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPatName;
        private System.Windows.Forms.TextBox txtTestPatName;
        private System.Windows.Forms.Label lblPatientTestInfo;
        private System.Windows.Forms.DataGridView dGridViewPatTestInfo;
        private System.Windows.Forms.DataGridView dGridViewPatientInfo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn addTest;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblPatId;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.ComboBox comboBoxPatientTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.GroupBox grpBoxDetails;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPayableAmountValue;
        private System.Windows.Forms.Label lblPayableAmountTitle;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblGivenDiscountTitle;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmountTitle;
        private System.Windows.Forms.Label lblPatientNameValue;
        private System.Windows.Forms.Label lblPatientNameInDetail;
        private MedicalStoreDataSet5 medicalStoreDataSet5;
        private System.Windows.Forms.BindingSource testInfoesBindingSource;
        private MedicalStoreDataSet5TableAdapters.TestInfoesTableAdapter testInfoesTableAdapter;
        private System.Windows.Forms.TextBox txtTestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDate;
        private System.Windows.Forms.DataGridViewLinkColumn testEdit;
        private System.Windows.Forms.DataGridViewLinkColumn testDelete;
    }
}