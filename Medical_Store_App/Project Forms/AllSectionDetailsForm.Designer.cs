
namespace Medical_Store_App.Project_Forms
{
    partial class AllSectionDetailsForm
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
            this.btnNewSale = new System.Windows.Forms.Button();
            this.dateTimePickerSale = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.btnGiveDiscount = new System.Windows.Forms.Button();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.picDiscountSec = new System.Windows.Forms.PictureBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.comboMedicine = new System.Windows.Forms.ComboBox();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet1 = new Medical_Store_App.MedicalStoreDataSet1();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.pictureBoxSale = new System.Windows.Forms.PictureBox();
            this.grpBoxSaleHistory = new System.Windows.Forms.GroupBox();
            this.dGridViewSaleHistory = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.stocksTableAdapter = new Medical_Store_App.MedicalStoreDataSet1TableAdapters.StocksTableAdapter();
            this.medicalStoreDataSet = new Medical_Store_App.MedicalStoreDataSet();
            this.medicalStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hrLine = new System.Windows.Forms.Label();
            this.lblTotalAmountAll = new System.Windows.Forms.Label();
            this.lblTotalAmountAllValue = new System.Windows.Forms.Label();
            this.lblGiveDiscountValue = new System.Windows.Forms.Label();
            this.lblGivenDiscount = new System.Windows.Forms.Label();
            this.lblPayableAmountValue = new System.Windows.Forms.Label();
            this.lblPayableAmount = new System.Windows.Forms.Label();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchSale = new System.Windows.Forms.TextBox();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.btnPrintSale = new System.Windows.Forms.Button();
            this.grpBoxDetails = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExpiryDateValue = new System.Windows.Forms.Label();
            this.lblExpDateTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxDetails = new System.Windows.Forms.PictureBox();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblAmountItem = new System.Windows.Forms.Label();
            this.lblCurrentStockQuantity = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblUnitPriceName = new System.Windows.Forms.Label();
            this.lblUnitPriceTitle = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemNameTitle = new System.Windows.Forms.Label();
            this.grpBoxSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscountSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSale)).BeginInit();
            this.grpBoxSaleHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewSaleHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSetBindingSource)).BeginInit();
            this.grpBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxSale
            // 
            this.grpBoxSale.Controls.Add(this.btnNewSale);
            this.grpBoxSale.Controls.Add(this.dateTimePickerSale);
            this.grpBoxSale.Controls.Add(this.lblSaleDate);
            this.grpBoxSale.Controls.Add(this.txtBill);
            this.grpBoxSale.Controls.Add(this.lblBillNo);
            this.grpBoxSale.Controls.Add(this.btnGiveDiscount);
            this.grpBoxSale.Controls.Add(this.lblDiscountTitle);
            this.grpBoxSale.Controls.Add(this.picDiscountSec);
            this.grpBoxSale.Controls.Add(this.txtDiscount);
            this.grpBoxSale.Controls.Add(this.lblDiscount);
            this.grpBoxSale.Controls.Add(this.btnSave);
            this.grpBoxSale.Controls.Add(this.txtQuantity);
            this.grpBoxSale.Controls.Add(this.lblQuantity);
            this.grpBoxSale.Controls.Add(this.txtUnitPrice);
            this.grpBoxSale.Controls.Add(this.lblUnitPrice);
            this.grpBoxSale.Controls.Add(this.comboMedicine);
            this.grpBoxSale.Controls.Add(this.lblMedicine);
            this.grpBoxSale.Controls.Add(this.txtCode);
            this.grpBoxSale.Controls.Add(this.lblCode);
            this.grpBoxSale.Location = new System.Drawing.Point(3, 2);
            this.grpBoxSale.Name = "grpBoxSale";
            this.grpBoxSale.Size = new System.Drawing.Size(268, 622);
            this.grpBoxSale.TabIndex = 0;
            this.grpBoxSale.TabStop = false;
            this.grpBoxSale.Text = "Sale";
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.Green;
            this.btnNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Location = new System.Drawing.Point(6, 452);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(252, 33);
            this.btnNewSale.TabIndex = 4;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // dateTimePickerSale
            // 
            this.dateTimePickerSale.Location = new System.Drawing.Point(6, 379);
            this.dateTimePickerSale.Name = "dateTimePickerSale";
            this.dateTimePickerSale.Size = new System.Drawing.Size(252, 20);
            this.dateTimePickerSale.TabIndex = 24;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDate.Location = new System.Drawing.Point(3, 360);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(79, 17);
            this.lblSaleDate.TabIndex = 23;
            this.lblSaleDate.Text = "Sale Date";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(6, 334);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(252, 23);
            this.txtBill.TabIndex = 20;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.Location = new System.Drawing.Point(3, 314);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(55, 17);
            this.lblBillNo.TabIndex = 21;
            this.lblBillNo.Text = "Bill No";
            // 
            // btnGiveDiscount
            // 
            this.btnGiveDiscount.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGiveDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveDiscount.ForeColor = System.Drawing.Color.White;
            this.btnGiveDiscount.Location = new System.Drawing.Point(151, 572);
            this.btnGiveDiscount.Name = "btnGiveDiscount";
            this.btnGiveDiscount.Size = new System.Drawing.Size(127, 28);
            this.btnGiveDiscount.TabIndex = 19;
            this.btnGiveDiscount.Text = "Give Discount";
            this.btnGiveDiscount.UseVisualStyleBackColor = false;
            this.btnGiveDiscount.Click += new System.EventHandler(this.btnGiveDiscount_Click);
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.BackColor = System.Drawing.Color.Maroon;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTitle.ForeColor = System.Drawing.Color.White;
            this.lblDiscountTitle.Location = new System.Drawing.Point(62, 523);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(161, 22);
            this.lblDiscountTitle.TabIndex = 18;
            this.lblDiscountTitle.Text = "Discount Section";
            // 
            // picDiscountSec
            // 
            this.picDiscountSec.BackColor = System.Drawing.Color.Maroon;
            this.picDiscountSec.Location = new System.Drawing.Point(0, 518);
            this.picDiscountSec.Name = "picDiscountSec";
            this.picDiscountSec.Size = new System.Drawing.Size(284, 31);
            this.picDiscountSec.TabIndex = 17;
            this.picDiscountSec.TabStop = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(6, 575);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(138, 23);
            this.txtDiscount.TabIndex = 45;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(3, 555);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 17);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "Discount";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(6, 288);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(252, 23);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(3, 268);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(6, 242);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(252, 23);
            this.txtUnitPrice.TabIndex = 56;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(3, 222);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(79, 17);
            this.lblUnitPrice.TabIndex = 11;
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
            this.comboMedicine.Location = new System.Drawing.Point(6, 88);
            this.comboMedicine.Name = "comboMedicine";
            this.comboMedicine.Size = new System.Drawing.Size(252, 137);
            this.comboMedicine.TabIndex = 7;
            this.comboMedicine.ValueMember = "Id";
            this.comboMedicine.SelectedIndexChanged += new System.EventHandler(this.comboMedicine_SelectedIndexChanged);
            this.comboMedicine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboMedicine_KeyDown);
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.medicalStoreDataSet1;
            // 
            // medicalStoreDataSet1
            // 
            this.medicalStoreDataSet1.DataSetName = "MedicalStoreDataSet1";
            this.medicalStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(3, 67);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(72, 17);
            this.lblMedicine.TabIndex = 6;
            this.lblMedicine.Text = "Medicine";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(6, 41);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(252, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(3, 21);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // pictureBoxSale
            // 
            this.pictureBoxSale.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxSale.Location = new System.Drawing.Point(273, 1);
            this.pictureBoxSale.Name = "pictureBoxSale";
            this.pictureBoxSale.Size = new System.Drawing.Size(1093, 99);
            this.pictureBoxSale.TabIndex = 2;
            this.pictureBoxSale.TabStop = false;
            // 
            // grpBoxSaleHistory
            // 
            this.grpBoxSaleHistory.Controls.Add(this.dGridViewSaleHistory);
            this.grpBoxSaleHistory.Location = new System.Drawing.Point(488, 101);
            this.grpBoxSaleHistory.Name = "grpBoxSaleHistory";
            this.grpBoxSaleHistory.Size = new System.Drawing.Size(892, 526);
            this.grpBoxSaleHistory.TabIndex = 3;
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
            this.BillId,
            this.ProductName,
            this.Quantity,
            this.UnitPrice,
            this.TotalAmount,
            this.saleProfit,
            this.SaleDate,
            this.Edit,
            this.Delete});
            this.dGridViewSaleHistory.Location = new System.Drawing.Point(6, 14);
            this.dGridViewSaleHistory.MultiSelect = false;
            this.dGridViewSaleHistory.Name = "dGridViewSaleHistory";
            this.dGridViewSaleHistory.ReadOnly = true;
            this.dGridViewSaleHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dGridViewSaleHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewSaleHistory.Size = new System.Drawing.Size(870, 506);
            this.dGridViewSaleHistory.TabIndex = 0;
            this.dGridViewSaleHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewSaleHistory_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // BillId
            // 
            this.BillId.DataPropertyName = "Sale_Id";
            this.BillId.HeaderText = "Bill No";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "Price";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "Total_Amount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // saleProfit
            // 
            this.saleProfit.DataPropertyName = "Profit";
            this.saleProfit.HeaderText = "Profit";
            this.saleProfit.Name = "saleProfit";
            this.saleProfit.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "Sale_Date";
            this.SaleDate.HeaderText = "Date";
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Visible = false;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // medicalStoreDataSet
            // 
            this.medicalStoreDataSet.DataSetName = "MedicalStoreDataSet";
            this.medicalStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalStoreDataSetBindingSource
            // 
            this.medicalStoreDataSetBindingSource.DataSource = this.medicalStoreDataSet;
            this.medicalStoreDataSetBindingSource.Position = 0;
            // 
            // hrLine
            // 
            this.hrLine.BackColor = System.Drawing.SystemColors.Control;
            this.hrLine.Location = new System.Drawing.Point(276, 56);
            this.hrLine.Name = "hrLine";
            this.hrLine.Size = new System.Drawing.Size(1092, 2);
            this.hrLine.TabIndex = 18;
            // 
            // lblTotalAmountAll
            // 
            this.lblTotalAmountAll.AutoSize = true;
            this.lblTotalAmountAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAmountAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountAll.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountAll.Location = new System.Drawing.Point(670, 3);
            this.lblTotalAmountAll.Name = "lblTotalAmountAll";
            this.lblTotalAmountAll.Size = new System.Drawing.Size(129, 22);
            this.lblTotalAmountAll.TabIndex = 23;
            this.lblTotalAmountAll.Text = "Total Amount";
            // 
            // lblTotalAmountAllValue
            // 
            this.lblTotalAmountAllValue.AutoSize = true;
            this.lblTotalAmountAllValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAmountAllValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountAllValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountAllValue.Location = new System.Drawing.Point(706, 30);
            this.lblTotalAmountAllValue.Name = "lblTotalAmountAllValue";
            this.lblTotalAmountAllValue.Size = new System.Drawing.Size(21, 22);
            this.lblTotalAmountAllValue.TabIndex = 24;
            this.lblTotalAmountAllValue.Text = "0";
            // 
            // lblGiveDiscountValue
            // 
            this.lblGiveDiscountValue.AutoSize = true;
            this.lblGiveDiscountValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGiveDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiveDiscountValue.ForeColor = System.Drawing.Color.White;
            this.lblGiveDiscountValue.Location = new System.Drawing.Point(993, 30);
            this.lblGiveDiscountValue.Name = "lblGiveDiscountValue";
            this.lblGiveDiscountValue.Size = new System.Drawing.Size(21, 22);
            this.lblGiveDiscountValue.TabIndex = 26;
            this.lblGiveDiscountValue.Text = "0";
            // 
            // lblGivenDiscount
            // 
            this.lblGivenDiscount.AutoSize = true;
            this.lblGivenDiscount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGivenDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGivenDiscount.ForeColor = System.Drawing.Color.White;
            this.lblGivenDiscount.Location = new System.Drawing.Point(960, 3);
            this.lblGivenDiscount.Name = "lblGivenDiscount";
            this.lblGivenDiscount.Size = new System.Drawing.Size(88, 22);
            this.lblGivenDiscount.TabIndex = 25;
            this.lblGivenDiscount.Text = "Discount";
            // 
            // lblPayableAmountValue
            // 
            this.lblPayableAmountValue.AutoSize = true;
            this.lblPayableAmountValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPayableAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblPayableAmountValue.Location = new System.Drawing.Point(1262, 30);
            this.lblPayableAmountValue.Name = "lblPayableAmountValue";
            this.lblPayableAmountValue.Size = new System.Drawing.Size(21, 22);
            this.lblPayableAmountValue.TabIndex = 28;
            this.lblPayableAmountValue.Text = "0";
            // 
            // lblPayableAmount
            // 
            this.lblPayableAmount.AutoSize = true;
            this.lblPayableAmount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPayableAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableAmount.ForeColor = System.Drawing.Color.White;
            this.lblPayableAmount.Location = new System.Drawing.Point(1211, 3);
            this.lblPayableAmount.Name = "lblPayableAmount";
            this.lblPayableAmount.Size = new System.Drawing.Size(155, 22);
            this.lblPayableAmount.TabIndex = 27;
            this.lblPayableAmount.Text = "Payable Amount";
            // 
            // lblTotalItemsValue
            // 
            this.lblTotalItemsValue.AutoSize = true;
            this.lblTotalItemsValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalItemsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalItemsValue.Location = new System.Drawing.Point(329, 30);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Size = new System.Drawing.Size(21, 22);
            this.lblTotalItemsValue.TabIndex = 30;
            this.lblTotalItemsValue.Text = "0";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.White;
            this.lblTotalItems.Location = new System.Drawing.Point(293, 3);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(109, 22);
            this.lblTotalItems.TabIndex = 29;
            this.lblTotalItems.Text = "Total Items";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(586, 72);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerStartDate.TabIndex = 31;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(491, 72);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 17);
            this.lblStartDate.TabIndex = 32;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(757, 72);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 17);
            this.lblEndDate.TabIndex = 34;
            this.lblEndDate.Text = "End Date";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(848, 72);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerEndDate.TabIndex = 33;
            // 
            // txtSearchSale
            // 
            this.txtSearchSale.Location = new System.Drawing.Point(1080, 72);
            this.txtSearchSale.Name = "txtSearchSale";
            this.txtSearchSale.Size = new System.Drawing.Size(165, 20);
            this.txtSearchSale.TabIndex = 35;
            this.txtSearchSale.TextChanged += new System.EventHandler(this.txtSearchSale_TextChanged);
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCode.ForeColor = System.Drawing.Color.White;
            this.lblSearchCode.Location = new System.Drawing.Point(1014, 72);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(45, 17);
            this.lblSearchCode.TabIndex = 36;
            this.lblSearchCode.Text = "Code";
            // 
            // btnPrintSale
            // 
            this.btnPrintSale.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSale.ForeColor = System.Drawing.Color.White;
            this.btnPrintSale.Location = new System.Drawing.Point(1279, 69);
            this.btnPrintSale.Name = "btnPrintSale";
            this.btnPrintSale.Size = new System.Drawing.Size(86, 26);
            this.btnPrintSale.TabIndex = 37;
            this.btnPrintSale.Text = "Print";
            this.btnPrintSale.UseVisualStyleBackColor = false;
            this.btnPrintSale.Click += new System.EventHandler(this.btnPrintSale_Click);
            // 
            // grpBoxDetails
            // 
            this.grpBoxDetails.Controls.Add(this.label5);
            this.grpBoxDetails.Controls.Add(this.label4);
            this.grpBoxDetails.Controls.Add(this.label3);
            this.grpBoxDetails.Controls.Add(this.label2);
            this.grpBoxDetails.Controls.Add(this.lblExpiryDateValue);
            this.grpBoxDetails.Controls.Add(this.lblExpDateTitle);
            this.grpBoxDetails.Controls.Add(this.label1);
            this.grpBoxDetails.Controls.Add(this.picBoxDetails);
            this.grpBoxDetails.Controls.Add(this.lblAmountValue);
            this.grpBoxDetails.Controls.Add(this.lblAmountItem);
            this.grpBoxDetails.Controls.Add(this.lblCurrentStockQuantity);
            this.grpBoxDetails.Controls.Add(this.lblCurrentStock);
            this.grpBoxDetails.Controls.Add(this.lblUnitPriceName);
            this.grpBoxDetails.Controls.Add(this.lblUnitPriceTitle);
            this.grpBoxDetails.Controls.Add(this.lblItemName);
            this.grpBoxDetails.Controls.Add(this.lblItemNameTitle);
            this.grpBoxDetails.Location = new System.Drawing.Point(273, 101);
            this.grpBoxDetails.Name = "grpBoxDetails";
            this.grpBoxDetails.Size = new System.Drawing.Size(215, 522);
            this.grpBoxDetails.TabIndex = 38;
            this.grpBoxDetails.TabStop = false;
            this.grpBoxDetails.Text = "Details";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 2);
            this.label5.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 2);
            this.label4.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 2);
            this.label3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 2);
            this.label2.TabIndex = 35;
            // 
            // lblExpiryDateValue
            // 
            this.lblExpiryDateValue.AutoSize = true;
            this.lblExpiryDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiryDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblExpiryDateValue.Location = new System.Drawing.Point(74, 327);
            this.lblExpiryDateValue.Name = "lblExpiryDateValue";
            this.lblExpiryDateValue.Size = new System.Drawing.Size(16, 16);
            this.lblExpiryDateValue.TabIndex = 34;
            this.lblExpiryDateValue.Text = "0";
            // 
            // lblExpDateTitle
            // 
            this.lblExpDateTitle.AutoSize = true;
            this.lblExpDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExpDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblExpDateTitle.Location = new System.Drawing.Point(5, 297);
            this.lblExpDateTitle.Name = "lblExpDateTitle";
            this.lblExpDateTitle.Size = new System.Drawing.Size(99, 18);
            this.lblExpDateTitle.TabIndex = 33;
            this.lblExpDateTitle.Text = "Expiry Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Item Details";
            // 
            // picBoxDetails
            // 
            this.picBoxDetails.BackColor = System.Drawing.Color.Maroon;
            this.picBoxDetails.Location = new System.Drawing.Point(2, 88);
            this.picBoxDetails.Name = "picBoxDetails";
            this.picBoxDetails.Size = new System.Drawing.Size(213, 31);
            this.picBoxDetails.TabIndex = 31;
            this.picBoxDetails.TabStop = false;
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountValue.ForeColor = System.Drawing.Color.Black;
            this.lblAmountValue.Location = new System.Drawing.Point(90, 56);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(19, 20);
            this.lblAmountValue.TabIndex = 30;
            this.lblAmountValue.Text = "0";
            // 
            // lblAmountItem
            // 
            this.lblAmountItem.AutoSize = true;
            this.lblAmountItem.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountItem.ForeColor = System.Drawing.Color.Black;
            this.lblAmountItem.Location = new System.Drawing.Point(67, 27);
            this.lblAmountItem.Name = "lblAmountItem";
            this.lblAmountItem.Size = new System.Drawing.Size(71, 20);
            this.lblAmountItem.TabIndex = 29;
            this.lblAmountItem.Text = "Amount";
            // 
            // lblCurrentStockQuantity
            // 
            this.lblCurrentStockQuantity.AutoSize = true;
            this.lblCurrentStockQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCurrentStockQuantity.Location = new System.Drawing.Point(74, 269);
            this.lblCurrentStockQuantity.Name = "lblCurrentStockQuantity";
            this.lblCurrentStockQuantity.Size = new System.Drawing.Size(16, 16);
            this.lblCurrentStockQuantity.TabIndex = 28;
            this.lblCurrentStockQuantity.Text = "0";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentStock.Location = new System.Drawing.Point(5, 239);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(118, 18);
            this.lblCurrentStock.TabIndex = 27;
            this.lblCurrentStock.Text = "Current Stock ";
            // 
            // lblUnitPriceName
            // 
            this.lblUnitPriceName.AutoSize = true;
            this.lblUnitPriceName.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPriceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPriceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUnitPriceName.Location = new System.Drawing.Point(74, 213);
            this.lblUnitPriceName.Name = "lblUnitPriceName";
            this.lblUnitPriceName.Size = new System.Drawing.Size(16, 16);
            this.lblUnitPriceName.TabIndex = 26;
            this.lblUnitPriceName.Text = "0";
            // 
            // lblUnitPriceTitle
            // 
            this.lblUnitPriceTitle.AutoSize = true;
            this.lblUnitPriceTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPriceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPriceTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUnitPriceTitle.Location = new System.Drawing.Point(5, 183);
            this.lblUnitPriceTitle.Name = "lblUnitPriceTitle";
            this.lblUnitPriceTitle.Size = new System.Drawing.Size(87, 18);
            this.lblUnitPriceTitle.TabIndex = 25;
            this.lblUnitPriceTitle.Text = "Unit Price ";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblItemName.Location = new System.Drawing.Point(74, 156);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(41, 16);
            this.lblItemName.TabIndex = 24;
            this.lblItemName.Text = "Item ";
            // 
            // lblItemNameTitle
            // 
            this.lblItemNameTitle.AutoSize = true;
            this.lblItemNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblItemNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameTitle.ForeColor = System.Drawing.Color.Black;
            this.lblItemNameTitle.Location = new System.Drawing.Point(5, 128);
            this.lblItemNameTitle.Name = "lblItemNameTitle";
            this.lblItemNameTitle.Size = new System.Drawing.Size(89, 18);
            this.lblItemNameTitle.TabIndex = 23;
            this.lblItemNameTitle.Text = "Item Name";
            // 
            // AllSectionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 616);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxDetails);
            this.Controls.Add(this.btnPrintSale);
            this.Controls.Add(this.lblSearchCode);
            this.Controls.Add(this.txtSearchSale);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.lblTotalItemsValue);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.lblPayableAmountValue);
            this.Controls.Add(this.lblPayableAmount);
            this.Controls.Add(this.lblGiveDiscountValue);
            this.Controls.Add(this.lblGivenDiscount);
            this.Controls.Add(this.lblTotalAmountAllValue);
            this.Controls.Add(this.lblTotalAmountAll);
            this.Controls.Add(this.hrLine);
            this.Controls.Add(this.grpBoxSaleHistory);
            this.Controls.Add(this.pictureBoxSale);
            this.Controls.Add(this.grpBoxSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllSectionDetailsForm";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sales_KeyDown);
            this.grpBoxSale.ResumeLayout(false);
            this.grpBoxSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscountSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSale)).EndInit();
            this.grpBoxSaleHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewSaleHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSetBindingSource)).EndInit();
            this.grpBoxDetails.ResumeLayout(false);
            this.grpBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSale;
        private System.Windows.Forms.PictureBox pictureBoxSale;
        private System.Windows.Forms.GroupBox grpBoxSaleHistory;
        private System.Windows.Forms.DataGridView dGridViewSaleHistory;
        private System.Windows.Forms.ComboBox comboMedicine;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private MedicalStoreDataSet1 medicalStoreDataSet1;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private MedicalStoreDataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
        private MedicalStoreDataSet medicalStoreDataSet;
        private System.Windows.Forms.BindingSource medicalStoreDataSetBindingSource;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.PictureBox picDiscountSec;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Button btnGiveDiscount;
        private System.Windows.Forms.DateTimePicker dateTimePickerSale;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Label hrLine;
        private System.Windows.Forms.Label lblTotalAmountAll;
        private System.Windows.Forms.Label lblTotalAmountAllValue;
        private System.Windows.Forms.Label lblGiveDiscountValue;
        private System.Windows.Forms.Label lblGivenDiscount;
        private System.Windows.Forms.Label lblPayableAmountValue;
        private System.Windows.Forms.Label lblPayableAmount;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.TextBox txtSearchSale;
        private System.Windows.Forms.Label lblSearchCode;
        private System.Windows.Forms.Button btnPrintSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.GroupBox grpBoxDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExpiryDateValue;
        private System.Windows.Forms.Label lblExpDateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxDetails;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblAmountItem;
        private System.Windows.Forms.Label lblCurrentStockQuantity;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblUnitPriceName;
        private System.Windows.Forms.Label lblUnitPriceTitle;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemNameTitle;
    }
}