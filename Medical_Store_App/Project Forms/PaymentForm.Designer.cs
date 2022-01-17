
namespace Medical_Store_App.Project_Forms
{
    partial class PaymentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.dateTimePickerPayDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.companyInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet4 = new Medical_Store_App.MedicalStoreDataSet4();
            this.lblCompany = new System.Windows.Forms.Label();
            this.companyInfoesTableAdapter = new Medical_Store_App.MedicalStoreDataSet4TableAdapters.CompanyInfoesTableAdapter();
            this.grpBoxPurchaseItem = new System.Windows.Forms.GroupBox();
            this.lblCompanyNameValue = new System.Windows.Forms.Label();
            this.lblCompanyNameTitle = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmountTitle = new System.Windows.Forms.Label();
            this.dGridViewPaymentInfo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Give = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaseedNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtSearchByBillNo = new System.Windows.Forms.TextBox();
            this.lblSearchByBillNo = new System.Windows.Forms.Label();
            this.grpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet4)).BeginInit();
            this.grpBoxPurchaseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPaymentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPaymentInfo
            // 
            this.grpPaymentInfo.Controls.Add(this.txtId);
            this.grpPaymentInfo.Controls.Add(this.btnSavePayment);
            this.grpPaymentInfo.Controls.Add(this.dateTimePickerPayDate);
            this.grpPaymentInfo.Controls.Add(this.lblDate);
            this.grpPaymentInfo.Controls.Add(this.txtAmount);
            this.grpPaymentInfo.Controls.Add(this.lblAmount);
            this.grpPaymentInfo.Controls.Add(this.txtBillNo);
            this.grpPaymentInfo.Controls.Add(this.lblBillNo);
            this.grpPaymentInfo.Controls.Add(this.comboBoxPaymentType);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentType);
            this.grpPaymentInfo.Controls.Add(this.comboBoxCompany);
            this.grpPaymentInfo.Controls.Add(this.lblCompany);
            this.grpPaymentInfo.Location = new System.Drawing.Point(5, 2);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(271, 622);
            this.grpPaymentInfo.TabIndex = 1;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Payment";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(151, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 12;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSavePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayment.ForeColor = System.Drawing.Color.White;
            this.btnSavePayment.Location = new System.Drawing.Point(10, 447);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(255, 33);
            this.btnSavePayment.TabIndex = 6;
            this.btnSavePayment.Text = "Save";
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // dateTimePickerPayDate
            // 
            this.dateTimePickerPayDate.Location = new System.Drawing.Point(10, 410);
            this.dateTimePickerPayDate.Name = "dateTimePickerPayDate";
            this.dateTimePickerPayDate.Size = new System.Drawing.Size(255, 20);
            this.dateTimePickerPayDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDate.Location = new System.Drawing.Point(7, 391);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(10, 365);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(256, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAmount.Location = new System.Drawing.Point(7, 346);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 15);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(9, 322);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(256, 20);
            this.txtBillNo.TabIndex = 3;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBillNo.Location = new System.Drawing.Point(6, 303);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(43, 15);
            this.lblBillNo.TabIndex = 7;
            this.lblBillNo.Text = "Bill No";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Received",
            "Pay"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(9, 233);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(143, 72);
            this.comboBoxPaymentType.TabIndex = 2;
            this.comboBoxPaymentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentType_SelectedIndexChanged);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPaymentType.Location = new System.Drawing.Point(6, 214);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(84, 15);
            this.lblPaymentType.TabIndex = 5;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.DataSource = this.companyInfoesBindingSource;
            this.comboBoxCompany.DisplayMember = "Company_Name";
            this.comboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(9, 37);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(256, 176);
            this.comboBoxCompany.TabIndex = 1;
            this.comboBoxCompany.ValueMember = "Id";
            this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
            // 
            // companyInfoesBindingSource
            // 
            this.companyInfoesBindingSource.DataMember = "CompanyInfoes";
            this.companyInfoesBindingSource.DataSource = this.medicalStoreDataSet4;
            // 
            // medicalStoreDataSet4
            // 
            this.medicalStoreDataSet4.DataSetName = "MedicalStoreDataSet4";
            this.medicalStoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCompany.Location = new System.Drawing.Point(6, 18);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(59, 15);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company";
            // 
            // companyInfoesTableAdapter
            // 
            this.companyInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // grpBoxPurchaseItem
            // 
            this.grpBoxPurchaseItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpBoxPurchaseItem.Controls.Add(this.txtSearchByBillNo);
            this.grpBoxPurchaseItem.Controls.Add(this.lblSearchByBillNo);
            this.grpBoxPurchaseItem.Controls.Add(this.lblCompanyNameValue);
            this.grpBoxPurchaseItem.Controls.Add(this.lblCompanyNameTitle);
            this.grpBoxPurchaseItem.Controls.Add(this.lblTotalAmountValue);
            this.grpBoxPurchaseItem.Controls.Add(this.lblTotalAmountTitle);
            this.grpBoxPurchaseItem.ForeColor = System.Drawing.Color.White;
            this.grpBoxPurchaseItem.Location = new System.Drawing.Point(282, 7);
            this.grpBoxPurchaseItem.Name = "grpBoxPurchaseItem";
            this.grpBoxPurchaseItem.Size = new System.Drawing.Size(1069, 99);
            this.grpBoxPurchaseItem.TabIndex = 12;
            this.grpBoxPurchaseItem.TabStop = false;
            this.grpBoxPurchaseItem.Text = "Item Info";
            // 
            // lblCompanyNameValue
            // 
            this.lblCompanyNameValue.AutoSize = true;
            this.lblCompanyNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCompanyNameValue.Location = new System.Drawing.Point(66, 64);
            this.lblCompanyNameValue.Name = "lblCompanyNameValue";
            this.lblCompanyNameValue.Size = new System.Drawing.Size(0, 18);
            this.lblCompanyNameValue.TabIndex = 42;
            // 
            // lblCompanyNameTitle
            // 
            this.lblCompanyNameTitle.AutoSize = true;
            this.lblCompanyNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyNameTitle.Location = new System.Drawing.Point(5, 31);
            this.lblCompanyNameTitle.Name = "lblCompanyNameTitle";
            this.lblCompanyNameTitle.Size = new System.Drawing.Size(128, 18);
            this.lblCompanyNameTitle.TabIndex = 41;
            this.lblCompanyNameTitle.Text = "Company Name";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(488, 63);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(17, 18);
            this.lblTotalAmountValue.TabIndex = 1;
            this.lblTotalAmountValue.Text = "0";
            // 
            // lblTotalAmountTitle
            // 
            this.lblTotalAmountTitle.AutoSize = true;
            this.lblTotalAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTitle.Location = new System.Drawing.Point(428, 31);
            this.lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            this.lblTotalAmountTitle.Size = new System.Drawing.Size(108, 18);
            this.lblTotalAmountTitle.TabIndex = 0;
            this.lblTotalAmountTitle.Text = "Total Amount";
            // 
            // dGridViewPaymentInfo
            // 
            this.dGridViewPaymentInfo.AllowUserToAddRows = false;
            this.dGridViewPaymentInfo.AllowUserToDeleteRows = false;
            this.dGridViewPaymentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewPaymentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewPaymentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Receive,
            this.BillNo,
            this.Give,
            this.RaseedNo,
            this.Total,
            this.Date,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewPaymentInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridViewPaymentInfo.Location = new System.Drawing.Point(282, 113);
            this.dGridViewPaymentInfo.Name = "dGridViewPaymentInfo";
            this.dGridViewPaymentInfo.ReadOnly = true;
            this.dGridViewPaymentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewPaymentInfo.Size = new System.Drawing.Size(1048, 511);
            this.dGridViewPaymentInfo.TabIndex = 13;
            this.dGridViewPaymentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewPaymentInfo_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Receive
            // 
            this.Receive.DataPropertyName = "Received_Amount";
            this.Receive.HeaderText = "Received";
            this.Receive.Name = "Receive";
            this.Receive.ReadOnly = true;
            // 
            // BillNo
            // 
            this.BillNo.DataPropertyName = "Bill_No";
            this.BillNo.HeaderText = "Bill No";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // Give
            // 
            this.Give.DataPropertyName = "Given_Amout";
            this.Give.HeaderText = "Given";
            this.Give.Name = "Give";
            this.Give.ReadOnly = true;
            // 
            // RaseedNo
            // 
            this.RaseedNo.DataPropertyName = "Raseed_No";
            this.RaseedNo.HeaderText = "Raseed No";
            this.RaseedNo.Name = "RaseedNo";
            this.RaseedNo.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Remaining_Amount";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Pay_Date";
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
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // txtSearchByBillNo
            // 
            this.txtSearchByBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByBillNo.Location = new System.Drawing.Point(921, 32);
            this.txtSearchByBillNo.Name = "txtSearchByBillNo";
            this.txtSearchByBillNo.Size = new System.Drawing.Size(127, 23);
            this.txtSearchByBillNo.TabIndex = 43;
            this.txtSearchByBillNo.TextChanged += new System.EventHandler(this.txtSearchByBillNo_TextChanged);
            // 
            // lblSearchByBillNo
            // 
            this.lblSearchByBillNo.AutoSize = true;
            this.lblSearchByBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByBillNo.Location = new System.Drawing.Point(778, 33);
            this.lblSearchByBillNo.Name = "lblSearchByBillNo";
            this.lblSearchByBillNo.Size = new System.Drawing.Size(117, 17);
            this.lblSearchByBillNo.TabIndex = 44;
            this.lblSearchByBillNo.Text = "Search By Bill No";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 626);
            this.ControlBox = false;
            this.Controls.Add(this.dGridViewPaymentInfo);
            this.Controls.Add(this.grpBoxPurchaseItem);
            this.Controls.Add(this.grpPaymentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet4)).EndInit();
            this.grpBoxPurchaseItem.ResumeLayout(false);
            this.grpBoxPurchaseItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPaymentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentInfo;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Label lblCompany;
        private MedicalStoreDataSet4 medicalStoreDataSet4;
        private System.Windows.Forms.BindingSource companyInfoesBindingSource;
        private MedicalStoreDataSet4TableAdapters.CompanyInfoesTableAdapter companyInfoesTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.DateTimePicker dateTimePickerPayDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.GroupBox grpBoxPurchaseItem;
        private System.Windows.Forms.Label lblCompanyNameValue;
        private System.Windows.Forms.Label lblCompanyNameTitle;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmountTitle;
        private System.Windows.Forms.DataGridView dGridViewPaymentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receive;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Give;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaseedNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSearchByBillNo;
        private System.Windows.Forms.Label lblSearchByBillNo;
    }
}