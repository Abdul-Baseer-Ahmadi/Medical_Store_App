
namespace Medical_Store_App.Project_Forms
{
    partial class SaleForm
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
            this.grpBoxSale = new System.Windows.Forms.GroupBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblDiscountSection = new System.Windows.Forms.Label();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerSale = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.comboMedicine = new System.Windows.Forms.ComboBox();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet1 = new Medical_Store_App.MedicalStoreDataSet1();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.stocksTableAdapter = new Medical_Store_App.MedicalStoreDataSet1TableAdapters.StocksTableAdapter();
            this.grpSaleInfo = new System.Windows.Forms.GroupBox();
            this.lblPayableAmountValue = new System.Windows.Forms.Label();
            this.lblPayableAmountTitle = new System.Windows.Forms.Label();
            this.lblSearchByItemCode = new System.Windows.Forms.Label();
            this.txtSearchByItemCode = new System.Windows.Forms.TextBox();
            this.btnLoadAllPurchase = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblGiveDiscountValue = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmountAllValue = new System.Windows.Forms.Label();
            this.lblTotalAmountTitle = new System.Windows.Forms.Label();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalItemsTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAmountTitle = new System.Windows.Forms.Label();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblItemNameValue = new System.Windows.Forms.Label();
            this.lblItemNameTitle = new System.Windows.Forms.Label();
            this.hr1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnitPriceValue = new System.Windows.Forms.Label();
            this.lblUnitPriceTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentStockQuantity = new System.Windows.Forms.Label();
            this.lblCurrentStockTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExpiryDateValue = new System.Windows.Forms.Label();
            this.lblExpiryDateTitle = new System.Windows.Forms.Label();
            this.grpBoxSaleHistory = new System.Windows.Forms.GroupBox();
            this.dGridViewSaleHistory = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpBoxSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).BeginInit();
            this.grpSaleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxSaleHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewSaleHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxSale
            // 
            this.grpBoxSale.Controls.Add(this.btnDiscount);
            this.grpBoxSale.Controls.Add(this.txtDiscount);
            this.grpBoxSale.Controls.Add(this.lblDiscountAmount);
            this.grpBoxSale.Controls.Add(this.lblDiscountSection);
            this.grpBoxSale.Controls.Add(this.btnNewSale);
            this.grpBoxSale.Controls.Add(this.btnSave);
            this.grpBoxSale.Controls.Add(this.dateTimePickerSale);
            this.grpBoxSale.Controls.Add(this.lblSaleDate);
            this.grpBoxSale.Controls.Add(this.txtBill);
            this.grpBoxSale.Controls.Add(this.lblBillNo);
            this.grpBoxSale.Controls.Add(this.txtQuantity);
            this.grpBoxSale.Controls.Add(this.lblQuantity);
            this.grpBoxSale.Controls.Add(this.txtUnitPrice);
            this.grpBoxSale.Controls.Add(this.lblUnitPrice);
            this.grpBoxSale.Controls.Add(this.comboMedicine);
            this.grpBoxSale.Controls.Add(this.lblName);
            this.grpBoxSale.Controls.Add(this.txtCode);
            this.grpBoxSale.Controls.Add(this.lblCode);
            this.grpBoxSale.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBoxSale.Location = new System.Drawing.Point(4, 1);
            this.grpBoxSale.Name = "grpBoxSale";
            this.grpBoxSale.Size = new System.Drawing.Size(266, 622);
            this.grpBoxSale.TabIndex = 0;
            this.grpBoxSale.TabStop = false;
            this.grpBoxSale.Text = "Sale";
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.Green;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(154, 571);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(104, 27);
            this.btnDiscount.TabIndex = 107;
            this.btnDiscount.Text = "Give Discount";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(6, 573);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(143, 23);
            this.txtDiscount.TabIndex = 105;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscountAmount.Location = new System.Drawing.Point(5, 553);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(95, 15);
            this.lblDiscountAmount.TabIndex = 106;
            this.lblDiscountAmount.Text = "Discount(%age)";
            // 
            // lblDiscountSection
            // 
            this.lblDiscountSection.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscountSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountSection.ForeColor = System.Drawing.Color.White;
            this.lblDiscountSection.Location = new System.Drawing.Point(0, 505);
            this.lblDiscountSection.Name = "lblDiscountSection";
            this.lblDiscountSection.Size = new System.Drawing.Size(266, 33);
            this.lblDiscountSection.TabIndex = 104;
            this.lblDiscountSection.Text = "Discount Section";
            this.lblDiscountSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.Green;
            this.btnNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Location = new System.Drawing.Point(7, 465);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(254, 33);
            this.btnNewSale.TabIndex = 103;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(7, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(254, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePickerSale
            // 
            this.dateTimePickerSale.Location = new System.Drawing.Point(6, 388);
            this.dateTimePickerSale.Name = "dateTimePickerSale";
            this.dateTimePickerSale.Size = new System.Drawing.Size(254, 20);
            this.dateTimePickerSale.TabIndex = 101;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSaleDate.Location = new System.Drawing.Point(5, 369);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(61, 15);
            this.lblSaleDate.TabIndex = 100;
            this.lblSaleDate.Text = "Sale Date";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(6, 342);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(254, 23);
            this.txtBill.TabIndex = 97;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBillNo.Location = new System.Drawing.Point(5, 322);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(43, 15);
            this.lblBillNo.TabIndex = 98;
            this.lblBillNo.Text = "Bill No";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(6, 297);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(254, 23);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuantity.Location = new System.Drawing.Point(5, 277);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 96;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(6, 251);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(254, 23);
            this.txtUnitPrice.TabIndex = 22;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUnitPrice.Location = new System.Drawing.Point(5, 231);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(60, 15);
            this.lblUnitPrice.TabIndex = 94;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // comboMedicine
            // 
            this.comboMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMedicine.DataSource = this.stocksBindingSource;
            this.comboMedicine.DisplayMember = "Name";
            this.comboMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboMedicine.FormattingEnabled = true;
            this.comboMedicine.Location = new System.Drawing.Point(6, 85);
            this.comboMedicine.Name = "comboMedicine";
            this.comboMedicine.Size = new System.Drawing.Size(254, 150);
            this.comboMedicine.TabIndex = 92;
            this.comboMedicine.ValueMember = "Id";
            this.comboMedicine.SelectedIndexChanged += new System.EventHandler(this.comboMedicine_SelectedIndexChanged);
            this.comboMedicine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboMedicine_KeyDown);
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.medicalStoreDataSet1BindingSource;
            // 
            // medicalStoreDataSet1BindingSource
            // 
            this.medicalStoreDataSet1BindingSource.DataSource = this.medicalStoreDataSet1;
            this.medicalStoreDataSet1BindingSource.Position = 0;
            // 
            // medicalStoreDataSet1
            // 
            this.medicalStoreDataSet1.DataSetName = "MedicalStoreDataSet1";
            this.medicalStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(5, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 15);
            this.lblName.TabIndex = 91;
            this.lblName.Text = "Medicine";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(6, 40);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(254, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCode.Location = new System.Drawing.Point(5, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(36, 15);
            this.lblCode.TabIndex = 90;
            this.lblCode.Text = "Code";
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // grpSaleInfo
            // 
            this.grpSaleInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpSaleInfo.Controls.Add(this.btnPrint);
            this.grpSaleInfo.Controls.Add(this.lblPayableAmountValue);
            this.grpSaleInfo.Controls.Add(this.lblPayableAmountTitle);
            this.grpSaleInfo.Controls.Add(this.lblSearchByItemCode);
            this.grpSaleInfo.Controls.Add(this.txtSearchByItemCode);
            this.grpSaleInfo.Controls.Add(this.btnLoadAllPurchase);
            this.grpSaleInfo.Controls.Add(this.lblEndDate);
            this.grpSaleInfo.Controls.Add(this.dateTimePickerEndDate);
            this.grpSaleInfo.Controls.Add(this.lblStartDate);
            this.grpSaleInfo.Controls.Add(this.dateTimePickerStartDate);
            this.grpSaleInfo.Controls.Add(this.lblGiveDiscountValue);
            this.grpSaleInfo.Controls.Add(this.lblDiscountTitle);
            this.grpSaleInfo.Controls.Add(this.label2);
            this.grpSaleInfo.Controls.Add(this.lblTotalAmountAllValue);
            this.grpSaleInfo.Controls.Add(this.lblTotalAmountTitle);
            this.grpSaleInfo.Controls.Add(this.lblTotalItemsValue);
            this.grpSaleInfo.Controls.Add(this.lblTotalItemsTitle);
            this.grpSaleInfo.ForeColor = System.Drawing.Color.White;
            this.grpSaleInfo.Location = new System.Drawing.Point(272, 1);
            this.grpSaleInfo.Name = "grpSaleInfo";
            this.grpSaleInfo.Size = new System.Drawing.Size(1102, 99);
            this.grpSaleInfo.TabIndex = 107;
            this.grpSaleInfo.TabStop = false;
            this.grpSaleInfo.Text = "Sale Info";
            // 
            // lblPayableAmountValue
            // 
            this.lblPayableAmountValue.AutoSize = true;
            this.lblPayableAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableAmountValue.Location = new System.Drawing.Point(1005, 32);
            this.lblPayableAmountValue.Name = "lblPayableAmountValue";
            this.lblPayableAmountValue.Size = new System.Drawing.Size(17, 18);
            this.lblPayableAmountValue.TabIndex = 45;
            this.lblPayableAmountValue.Text = "0";
            // 
            // lblPayableAmountTitle
            // 
            this.lblPayableAmountTitle.AutoSize = true;
            this.lblPayableAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableAmountTitle.Location = new System.Drawing.Point(958, 12);
            this.lblPayableAmountTitle.Name = "lblPayableAmountTitle";
            this.lblPayableAmountTitle.Size = new System.Drawing.Size(129, 18);
            this.lblPayableAmountTitle.TabIndex = 44;
            this.lblPayableAmountTitle.Text = "Payable Amount";
            // 
            // lblSearchByItemCode
            // 
            this.lblSearchByItemCode.AutoSize = true;
            this.lblSearchByItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByItemCode.Location = new System.Drawing.Point(784, 72);
            this.lblSearchByItemCode.Name = "lblSearchByItemCode";
            this.lblSearchByItemCode.Size = new System.Drawing.Size(140, 15);
            this.lblSearchByItemCode.TabIndex = 43;
            this.lblSearchByItemCode.Text = "Search By Item Code";
            // 
            // txtSearchByItemCode
            // 
            this.txtSearchByItemCode.Location = new System.Drawing.Point(928, 72);
            this.txtSearchByItemCode.Name = "txtSearchByItemCode";
            this.txtSearchByItemCode.Size = new System.Drawing.Size(94, 20);
            this.txtSearchByItemCode.TabIndex = 42;
            this.txtSearchByItemCode.TextChanged += new System.EventHandler(this.txtSearchByItemCode_TextChanged);
            // 
            // btnLoadAllPurchase
            // 
            this.btnLoadAllPurchase.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadAllPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAllPurchase.Location = new System.Drawing.Point(677, 70);
            this.btnLoadAllPurchase.Name = "btnLoadAllPurchase";
            this.btnLoadAllPurchase.Size = new System.Drawing.Size(96, 23);
            this.btnLoadAllPurchase.TabIndex = 41;
            this.btnLoadAllPurchase.Text = "Load all Sales";
            this.btnLoadAllPurchase.UseVisualStyleBackColor = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(432, 72);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(85, 17);
            this.lblEndDate.TabIndex = 40;
            this.lblEndDate.Text = "End Date :";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(521, 72);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerEndDate.TabIndex = 39;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(178, 72);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(92, 17);
            this.lblStartDate.TabIndex = 38;
            this.lblStartDate.Text = "Start Date :";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(272, 72);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerStartDate.TabIndex = 37;
            // 
            // lblGiveDiscountValue
            // 
            this.lblGiveDiscountValue.AutoSize = true;
            this.lblGiveDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiveDiscountValue.Location = new System.Drawing.Point(691, 33);
            this.lblGiveDiscountValue.Name = "lblGiveDiscountValue";
            this.lblGiveDiscountValue.Size = new System.Drawing.Size(17, 18);
            this.lblGiveDiscountValue.TabIndex = 36;
            this.lblGiveDiscountValue.Text = "0";
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTitle.Location = new System.Drawing.Point(666, 12);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(75, 18);
            this.lblDiscountTitle.TabIndex = 35;
            this.lblDiscountTitle.Text = "Discount";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1100, 2);
            this.label2.TabIndex = 34;
            // 
            // lblTotalAmountAllValue
            // 
            this.lblTotalAmountAllValue.AutoSize = true;
            this.lblTotalAmountAllValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountAllValue.Location = new System.Drawing.Point(362, 32);
            this.lblTotalAmountAllValue.Name = "lblTotalAmountAllValue";
            this.lblTotalAmountAllValue.Size = new System.Drawing.Size(17, 18);
            this.lblTotalAmountAllValue.TabIndex = 102;
            this.lblTotalAmountAllValue.Text = "0";
            // 
            // lblTotalAmountTitle
            // 
            this.lblTotalAmountTitle.AutoSize = true;
            this.lblTotalAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTitle.Location = new System.Drawing.Point(330, 12);
            this.lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            this.lblTotalAmountTitle.Size = new System.Drawing.Size(108, 18);
            this.lblTotalAmountTitle.TabIndex = 99;
            this.lblTotalAmountTitle.Text = "Total Amount";
            // 
            // lblTotalItemsValue
            // 
            this.lblTotalItemsValue.AutoSize = true;
            this.lblTotalItemsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsValue.Location = new System.Drawing.Point(52, 32);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Size = new System.Drawing.Size(17, 18);
            this.lblTotalItemsValue.TabIndex = 101;
            this.lblTotalItemsValue.Text = "0";
            // 
            // lblTotalItemsTitle
            // 
            this.lblTotalItemsTitle.AutoSize = true;
            this.lblTotalItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsTitle.Location = new System.Drawing.Point(7, 15);
            this.lblTotalItemsTitle.Name = "lblTotalItemsTitle";
            this.lblTotalItemsTitle.Size = new System.Drawing.Size(92, 18);
            this.lblTotalItemsTitle.TabIndex = 100;
            this.lblTotalItemsTitle.Text = "Total Items";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(273, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 523);
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // lblAmountTitle
            // 
            this.lblAmountTitle.AutoSize = true;
            this.lblAmountTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountTitle.ForeColor = System.Drawing.Color.White;
            this.lblAmountTitle.Location = new System.Drawing.Point(324, 103);
            this.lblAmountTitle.Name = "lblAmountTitle";
            this.lblAmountTitle.Size = new System.Drawing.Size(65, 18);
            this.lblAmountTitle.TabIndex = 109;
            this.lblAmountTitle.Text = "Amount";
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblAmountValue.Location = new System.Drawing.Point(353, 128);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(17, 18);
            this.lblAmountValue.TabIndex = 110;
            this.lblAmountValue.Text = "0";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(273, 157);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(178, 33);
            this.lblAmount.TabIndex = 111;
            this.lblAmount.Text = "Item Details";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemNameValue
            // 
            this.lblItemNameValue.AutoSize = true;
            this.lblItemNameValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameValue.ForeColor = System.Drawing.Color.Orange;
            this.lblItemNameValue.Location = new System.Drawing.Point(321, 230);
            this.lblItemNameValue.Name = "lblItemNameValue";
            this.lblItemNameValue.Size = new System.Drawing.Size(38, 17);
            this.lblItemNameValue.TabIndex = 113;
            this.lblItemNameValue.Text = "Item";
            // 
            // lblItemNameTitle
            // 
            this.lblItemNameTitle.AutoSize = true;
            this.lblItemNameTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblItemNameTitle.Location = new System.Drawing.Point(273, 205);
            this.lblItemNameTitle.Name = "lblItemNameTitle";
            this.lblItemNameTitle.Size = new System.Drawing.Size(84, 17);
            this.lblItemNameTitle.TabIndex = 112;
            this.lblItemNameTitle.Text = "Item Name";
            // 
            // hr1
            // 
            this.hr1.Location = new System.Drawing.Point(273, 252);
            this.hr1.Name = "hr1";
            this.hr1.Size = new System.Drawing.Size(178, 2);
            this.hr1.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(273, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 2);
            this.label1.TabIndex = 117;
            // 
            // lblUnitPriceValue
            // 
            this.lblUnitPriceValue.AutoSize = true;
            this.lblUnitPriceValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUnitPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPriceValue.ForeColor = System.Drawing.Color.Orange;
            this.lblUnitPriceValue.Location = new System.Drawing.Point(321, 282);
            this.lblUnitPriceValue.Name = "lblUnitPriceValue";
            this.lblUnitPriceValue.Size = new System.Drawing.Size(17, 17);
            this.lblUnitPriceValue.TabIndex = 116;
            this.lblUnitPriceValue.Text = "0";
            // 
            // lblUnitPriceTitle
            // 
            this.lblUnitPriceTitle.AutoSize = true;
            this.lblUnitPriceTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUnitPriceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPriceTitle.ForeColor = System.Drawing.Color.White;
            this.lblUnitPriceTitle.Location = new System.Drawing.Point(273, 257);
            this.lblUnitPriceTitle.Name = "lblUnitPriceTitle";
            this.lblUnitPriceTitle.Size = new System.Drawing.Size(79, 17);
            this.lblUnitPriceTitle.TabIndex = 115;
            this.lblUnitPriceTitle.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(273, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 2);
            this.label3.TabIndex = 120;
            // 
            // lblCurrentStockQuantity
            // 
            this.lblCurrentStockQuantity.AutoSize = true;
            this.lblCurrentStockQuantity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockQuantity.ForeColor = System.Drawing.Color.Orange;
            this.lblCurrentStockQuantity.Location = new System.Drawing.Point(321, 334);
            this.lblCurrentStockQuantity.Name = "lblCurrentStockQuantity";
            this.lblCurrentStockQuantity.Size = new System.Drawing.Size(17, 17);
            this.lblCurrentStockQuantity.TabIndex = 119;
            this.lblCurrentStockQuantity.Text = "0";
            // 
            // lblCurrentStockTitle
            // 
            this.lblCurrentStockTitle.AutoSize = true;
            this.lblCurrentStockTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockTitle.ForeColor = System.Drawing.Color.White;
            this.lblCurrentStockTitle.Location = new System.Drawing.Point(273, 309);
            this.lblCurrentStockTitle.Name = "lblCurrentStockTitle";
            this.lblCurrentStockTitle.Size = new System.Drawing.Size(107, 17);
            this.lblCurrentStockTitle.TabIndex = 118;
            this.lblCurrentStockTitle.Text = "Current Stock";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(273, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 2);
            this.label4.TabIndex = 123;
            // 
            // lblExpiryDateValue
            // 
            this.lblExpiryDateValue.AutoSize = true;
            this.lblExpiryDateValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExpiryDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDateValue.ForeColor = System.Drawing.Color.Orange;
            this.lblExpiryDateValue.Location = new System.Drawing.Point(321, 388);
            this.lblExpiryDateValue.Name = "lblExpiryDateValue";
            this.lblExpiryDateValue.Size = new System.Drawing.Size(17, 17);
            this.lblExpiryDateValue.TabIndex = 122;
            this.lblExpiryDateValue.Text = "0";
            // 
            // lblExpiryDateTitle
            // 
            this.lblExpiryDateTitle.AutoSize = true;
            this.lblExpiryDateTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExpiryDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDateTitle.ForeColor = System.Drawing.Color.White;
            this.lblExpiryDateTitle.Location = new System.Drawing.Point(273, 363);
            this.lblExpiryDateTitle.Name = "lblExpiryDateTitle";
            this.lblExpiryDateTitle.Size = new System.Drawing.Size(91, 17);
            this.lblExpiryDateTitle.TabIndex = 121;
            this.lblExpiryDateTitle.Text = "Expiry Date";
            // 
            // grpBoxSaleHistory
            // 
            this.grpBoxSaleHistory.Controls.Add(this.dGridViewSaleHistory);
            this.grpBoxSaleHistory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBoxSaleHistory.Location = new System.Drawing.Point(458, 103);
            this.grpBoxSaleHistory.Name = "grpBoxSaleHistory";
            this.grpBoxSaleHistory.Size = new System.Drawing.Size(915, 520);
            this.grpBoxSaleHistory.TabIndex = 124;
            this.grpBoxSaleHistory.TabStop = false;
            this.grpBoxSaleHistory.Text = "Sale History";
            // 
            // dGridViewSaleHistory
            // 
            this.dGridViewSaleHistory.AllowUserToAddRows = false;
            this.dGridViewSaleHistory.AllowUserToDeleteRows = false;
            this.dGridViewSaleHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewSaleHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGridViewSaleHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BillNo,
            this.grdName,
            this.Quantity,
            this.UnitPrice,
            this.TProfit,
            this.TotalAmount,
            this.Date,
            this.Edit,
            this.Delete});
            this.dGridViewSaleHistory.Location = new System.Drawing.Point(0, 20);
            this.dGridViewSaleHistory.Name = "dGridViewSaleHistory";
            this.dGridViewSaleHistory.ReadOnly = true;
            this.dGridViewSaleHistory.Size = new System.Drawing.Size(890, 494);
            this.dGridViewSaleHistory.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 91.37056F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // BillNo
            // 
            this.BillNo.DataPropertyName = "Sale_Id";
            this.BillNo.FillWeight = 91.37056F;
            this.BillNo.HeaderText = "Bill No";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // grdName
            // 
            this.grdName.DataPropertyName = "Name";
            this.grdName.FillWeight = 177.665F;
            this.grdName.HeaderText = "Name";
            this.grdName.Name = "grdName";
            this.grdName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 91.37056F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "Price";
            this.UnitPrice.FillWeight = 91.37056F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // TProfit
            // 
            this.TProfit.DataPropertyName = "Profit";
            this.TProfit.FillWeight = 91.37056F;
            this.TProfit.HeaderText = "Profit";
            this.TProfit.Name = "TProfit";
            this.TProfit.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "Total_Amount";
            this.TotalAmount.FillWeight = 91.37056F;
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Sale_Date";
            this.Date.FillWeight = 91.37056F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 91.37056F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 91.37056F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1026, 70);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 103;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 626);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxSaleHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExpiryDateValue);
            this.Controls.Add(this.lblExpiryDateTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentStockQuantity);
            this.Controls.Add(this.lblCurrentStockTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnitPriceValue);
            this.Controls.Add(this.lblUnitPriceTitle);
            this.Controls.Add(this.hr1);
            this.Controls.Add(this.lblItemNameValue);
            this.Controls.Add(this.lblItemNameTitle);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountValue);
            this.Controls.Add(this.lblAmountTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpSaleInfo);
            this.Controls.Add(this.grpBoxSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Text = "Sale Form";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.grpBoxSale.ResumeLayout(false);
            this.grpBoxSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).EndInit();
            this.grpSaleInfo.ResumeLayout(false);
            this.grpSaleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxSaleHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewSaleHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSale;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox comboMedicine;
        private System.Windows.Forms.BindingSource medicalStoreDataSet1BindingSource;
        private MedicalStoreDataSet1 medicalStoreDataSet1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private MedicalStoreDataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerSale;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDiscountSection;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.GroupBox grpSaleInfo;
        private System.Windows.Forms.Label lblPayableAmountValue;
        private System.Windows.Forms.Label lblPayableAmountTitle;
        private System.Windows.Forms.Label lblSearchByItemCode;
        private System.Windows.Forms.TextBox txtSearchByItemCode;
        private System.Windows.Forms.Button btnLoadAllPurchase;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblGiveDiscountValue;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmountAllValue;
        private System.Windows.Forms.Label lblTotalAmountTitle;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalItemsTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAmountTitle;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblItemNameValue;
        private System.Windows.Forms.Label lblItemNameTitle;
        private System.Windows.Forms.Label hr1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnitPriceValue;
        private System.Windows.Forms.Label lblUnitPriceTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentStockQuantity;
        private System.Windows.Forms.Label lblCurrentStockTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExpiryDateValue;
        private System.Windows.Forms.Label lblExpiryDateTitle;
        private System.Windows.Forms.GroupBox grpBoxSaleHistory;
        private System.Windows.Forms.DataGridView dGridViewSaleHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button btnPrint;
    }
}