
namespace Medical_Store_App.Project_Forms
{
    partial class PurchasesForm
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
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.dateTimePickerExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.dateTimePickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.comboMedicine = new System.Windows.Forms.ComboBox();
            this.stocksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet3 = new Medical_Store_App.MedicalStoreDataSet3();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet1 = new Medical_Store_App.MedicalStoreDataSet1();
            this.grpBoxSaleHistory = new System.Windows.Forms.GroupBox();
            this.dGridViewPurchaseHistory = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MfgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.grpBoxPurchaseItem = new System.Windows.Forms.GroupBox();
            this.lblSearchByItemCode = new System.Windows.Forms.Label();
            this.txtSearchByItemCode = new System.Windows.Forms.TextBox();
            this.btnLoadAllPurchase = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmountTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewStockValue = new System.Windows.Forms.Label();
            this.lblNewStockTitle = new System.Windows.Forms.Label();
            this.lblCurrentStockQuantity = new System.Windows.Forms.Label();
            this.lblCurrentStockTitle = new System.Windows.Forms.Label();
            this.stocksTableAdapter = new Medical_Store_App.MedicalStoreDataSet1TableAdapters.StocksTableAdapter();
            this.stocksTableAdapter1 = new Medical_Store_App.MedicalStoreDataSet3TableAdapters.StocksTableAdapter();
            this.grpBoxSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).BeginInit();
            this.grpBoxSaleHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPurchaseHistory)).BeginInit();
            this.grpBoxPurchaseItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSale
            // 
            this.grpBoxSale.Controls.Add(this.lblPurchaseDate);
            this.grpBoxSale.Controls.Add(this.dateTimePickerPurchaseDate);
            this.grpBoxSale.Controls.Add(this.txtPurchaseId);
            this.grpBoxSale.Controls.Add(this.txtSalePrice);
            this.grpBoxSale.Controls.Add(this.lblSalePrice);
            this.grpBoxSale.Controls.Add(this.txtProfit);
            this.grpBoxSale.Controls.Add(this.lblProfit);
            this.grpBoxSale.Controls.Add(this.dateTimePickerExpiryDate);
            this.grpBoxSale.Controls.Add(this.lblExpiryDate);
            this.grpBoxSale.Controls.Add(this.txtPurchasePrice);
            this.grpBoxSale.Controls.Add(this.lblPurchasePrice);
            this.grpBoxSale.Controls.Add(this.dateTimePickerMfgDate);
            this.grpBoxSale.Controls.Add(this.lblMfgDate);
            this.grpBoxSale.Controls.Add(this.btnSave);
            this.grpBoxSale.Controls.Add(this.txtQuantity);
            this.grpBoxSale.Controls.Add(this.lblQuantity);
            this.grpBoxSale.Controls.Add(this.comboMedicine);
            this.grpBoxSale.Controls.Add(this.lblMedicine);
            this.grpBoxSale.Controls.Add(this.txtCode);
            this.grpBoxSale.Controls.Add(this.lblCode);
            this.grpBoxSale.ForeColor = System.Drawing.Color.Black;
            this.grpBoxSale.Location = new System.Drawing.Point(2, 3);
            this.grpBoxSale.Name = "grpBoxSale";
            this.grpBoxSale.Size = new System.Drawing.Size(264, 611);
            this.grpBoxSale.TabIndex = 1;
            this.grpBoxSale.TabStop = false;
            this.grpBoxSale.Text = "Purchase";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPurchaseDate.Location = new System.Drawing.Point(10, 26);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(88, 15);
            this.lblPurchaseDate.TabIndex = 67;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(10, 45);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerPurchaseDate.TabIndex = 66;
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Location = new System.Drawing.Point(146, 13);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseId.TabIndex = 63;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(10, 426);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(252, 23);
            this.txtSalePrice.TabIndex = 65;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSalePrice.Location = new System.Drawing.Point(7, 406);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(63, 15);
            this.lblSalePrice.TabIndex = 61;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // txtProfit
            // 
            this.txtProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(10, 380);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(252, 23);
            this.txtProfit.TabIndex = 5;
            this.txtProfit.TextChanged += new System.EventHandler(this.txtProfit_TextChanged);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProfit.Location = new System.Drawing.Point(7, 360);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(75, 15);
            this.lblProfit.TabIndex = 59;
            this.lblProfit.Text = "Profit(%age)";
            // 
            // dateTimePickerExpiryDate
            // 
            this.dateTimePickerExpiryDate.Location = new System.Drawing.Point(10, 516);
            this.dateTimePickerExpiryDate.Name = "dateTimePickerExpiryDate";
            this.dateTimePickerExpiryDate.Size = new System.Drawing.Size(252, 20);
            this.dateTimePickerExpiryDate.TabIndex = 58;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblExpiryDate.Location = new System.Drawing.Point(7, 497);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(69, 15);
            this.lblExpiryDate.TabIndex = 57;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(10, 334);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(252, 23);
            this.txtPurchasePrice.TabIndex = 4;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPurchasePrice.Location = new System.Drawing.Point(7, 314);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(90, 15);
            this.lblPurchasePrice.TabIndex = 11;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // dateTimePickerMfgDate
            // 
            this.dateTimePickerMfgDate.Location = new System.Drawing.Point(10, 473);
            this.dateTimePickerMfgDate.Name = "dateTimePickerMfgDate";
            this.dateTimePickerMfgDate.Size = new System.Drawing.Size(252, 20);
            this.dateTimePickerMfgDate.TabIndex = 24;
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfgDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMfgDate.Location = new System.Drawing.Point(7, 454);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(57, 15);
            this.lblMfgDate.TabIndex = 23;
            this.lblMfgDate.Text = "Mfg Date";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 33);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(10, 289);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(252, 23);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuantity.Location = new System.Drawing.Point(7, 269);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity";
            // 
            // comboMedicine
            // 
            this.comboMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMedicine.DataSource = this.stocksBindingSource1;
            this.comboMedicine.DisplayMember = "Name";
            this.comboMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboMedicine.FormattingEnabled = true;
            this.comboMedicine.Location = new System.Drawing.Point(10, 132);
            this.comboMedicine.Name = "comboMedicine";
            this.comboMedicine.Size = new System.Drawing.Size(252, 137);
            this.comboMedicine.TabIndex = 34;
            this.comboMedicine.ValueMember = "Id";
            this.comboMedicine.SelectedIndexChanged += new System.EventHandler(this.comboMedicine_SelectedIndexChanged);
            // 
            // stocksBindingSource1
            // 
            this.stocksBindingSource1.DataMember = "Stocks";
            this.stocksBindingSource1.DataSource = this.medicalStoreDataSet3;
            // 
            // medicalStoreDataSet3
            // 
            this.medicalStoreDataSet3.DataSetName = "MedicalStoreDataSet3";
            this.medicalStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMedicine.Location = new System.Drawing.Point(7, 111);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(58, 15);
            this.lblMedicine.TabIndex = 6;
            this.lblMedicine.Text = "Medicine";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(10, 85);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(252, 23);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCode.Location = new System.Drawing.Point(7, 65);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(36, 15);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(70, 70);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(127, 23);
            this.txtBill.TabIndex = 1;
            this.txtBill.TextChanged += new System.EventHandler(this.txtBill_TextChanged);
            this.txtBill.Leave += new System.EventHandler(this.txtBill_Leave);
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.Location = new System.Drawing.Point(4, 73);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(56, 17);
            this.lblBillNo.TabIndex = 21;
            this.lblBillNo.Text = "Bill No :";
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
            // grpBoxSaleHistory
            // 
            this.grpBoxSaleHistory.Controls.Add(this.dGridViewPurchaseHistory);
            this.grpBoxSaleHistory.ForeColor = System.Drawing.Color.Black;
            this.grpBoxSaleHistory.Location = new System.Drawing.Point(272, 104);
            this.grpBoxSaleHistory.Name = "grpBoxSaleHistory";
            this.grpBoxSaleHistory.Size = new System.Drawing.Size(1109, 510);
            this.grpBoxSaleHistory.TabIndex = 4;
            this.grpBoxSaleHistory.TabStop = false;
            this.grpBoxSaleHistory.Text = "Purchase History";
            // 
            // dGridViewPurchaseHistory
            // 
            this.dGridViewPurchaseHistory.AllowUserToAddRows = false;
            this.dGridViewPurchaseHistory.AllowUserToDeleteRows = false;
            this.dGridViewPurchaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewPurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGridViewPurchaseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Quantity,
            this.PurchasePrice,
            this.Profit,
            this.SalePrice,
            this.TotalAmount,
            this.PurchaseDate,
            this.MfgDate,
            this.ExpDate,
            this.Edit,
            this.Delete});
            this.dGridViewPurchaseHistory.Location = new System.Drawing.Point(2, 14);
            this.dGridViewPurchaseHistory.Name = "dGridViewPurchaseHistory";
            this.dGridViewPurchaseHistory.ReadOnly = true;
            this.dGridViewPurchaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewPurchaseHistory.Size = new System.Drawing.Size(1102, 494);
            this.dGridViewPurchaseHistory.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 92.47808F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.FillWeight = 182.7411F;
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 92.47808F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "Purchase_Price";
            this.PurchasePrice.FillWeight = 92.47808F;
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            this.PurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.FillWeight = 92.47808F;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "Sale_Price";
            this.SalePrice.FillWeight = 92.47808F;
            this.SalePrice.HeaderText = "Sale Price";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            this.SalePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "Total_Amount";
            this.TotalAmount.FillWeight = 92.47808F;
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "Purchase_Date";
            this.PurchaseDate.FillWeight = 92.47808F;
            this.PurchaseDate.HeaderText = "Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MfgDate
            // 
            this.MfgDate.DataPropertyName = "Mfg_Date";
            this.MfgDate.FillWeight = 92.47808F;
            this.MfgDate.HeaderText = "Mfg Date";
            this.MfgDate.Name = "MfgDate";
            this.MfgDate.ReadOnly = true;
            this.MfgDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "Expiry_Date";
            this.ExpDate.FillWeight = 92.47808F;
            this.ExpDate.HeaderText = "Expiry Date";
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            this.ExpDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 92.47808F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 92.47808F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // grpBoxPurchaseItem
            // 
            this.grpBoxPurchaseItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpBoxPurchaseItem.Controls.Add(this.lblSearchByItemCode);
            this.grpBoxPurchaseItem.Controls.Add(this.txtSearchByItemCode);
            this.grpBoxPurchaseItem.Controls.Add(this.btnLoadAllPurchase);
            this.grpBoxPurchaseItem.Controls.Add(this.lblEndDate);
            this.grpBoxPurchaseItem.Controls.Add(this.dateTimePickerEndDate);
            this.grpBoxPurchaseItem.Controls.Add(this.lblStartDate);
            this.grpBoxPurchaseItem.Controls.Add(this.dateTimePickerStartDate);
            this.grpBoxPurchaseItem.Controls.Add(this.lblTotalAmountValue);
            this.grpBoxPurchaseItem.Controls.Add(this.lblTotalAmountTitle);
            this.grpBoxPurchaseItem.Controls.Add(this.label2);
            this.grpBoxPurchaseItem.Controls.Add(this.lblNewStockValue);
            this.grpBoxPurchaseItem.Controls.Add(this.lblNewStockTitle);
            this.grpBoxPurchaseItem.Controls.Add(this.lblCurrentStockQuantity);
            this.grpBoxPurchaseItem.Controls.Add(this.lblCurrentStockTitle);
            this.grpBoxPurchaseItem.Controls.Add(this.txtBill);
            this.grpBoxPurchaseItem.Controls.Add(this.lblBillNo);
            this.grpBoxPurchaseItem.ForeColor = System.Drawing.Color.White;
            this.grpBoxPurchaseItem.Location = new System.Drawing.Point(272, 3);
            this.grpBoxPurchaseItem.Name = "grpBoxPurchaseItem";
            this.grpBoxPurchaseItem.Size = new System.Drawing.Size(1102, 99);
            this.grpBoxPurchaseItem.TabIndex = 6;
            this.grpBoxPurchaseItem.TabStop = false;
            this.grpBoxPurchaseItem.Text = "Item Info";
            // 
            // lblSearchByItemCode
            // 
            this.lblSearchByItemCode.AutoSize = true;
            this.lblSearchByItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByItemCode.Location = new System.Drawing.Point(857, 71);
            this.lblSearchByItemCode.Name = "lblSearchByItemCode";
            this.lblSearchByItemCode.Size = new System.Drawing.Size(140, 17);
            this.lblSearchByItemCode.TabIndex = 43;
            this.lblSearchByItemCode.Text = "Search By Item Code";
            // 
            // txtSearchByItemCode
            // 
            this.txtSearchByItemCode.Location = new System.Drawing.Point(1001, 71);
            this.txtSearchByItemCode.Name = "txtSearchByItemCode";
            this.txtSearchByItemCode.Size = new System.Drawing.Size(100, 20);
            this.txtSearchByItemCode.TabIndex = 42;
            // 
            // btnLoadAllPurchase
            // 
            this.btnLoadAllPurchase.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadAllPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAllPurchase.Location = new System.Drawing.Point(720, 70);
            this.btnLoadAllPurchase.Name = "btnLoadAllPurchase";
            this.btnLoadAllPurchase.Size = new System.Drawing.Size(128, 23);
            this.btnLoadAllPurchase.TabIndex = 41;
            this.btnLoadAllPurchase.Text = "Load All Purchases";
            this.btnLoadAllPurchase.UseVisualStyleBackColor = false;
            this.btnLoadAllPurchase.Click += new System.EventHandler(this.btnLoadAllPurchase_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(468, 72);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 17);
            this.lblEndDate.TabIndex = 40;
            this.lblEndDate.Text = "End Date :";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(556, 72);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerEndDate.TabIndex = 39;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(215, 72);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(80, 17);
            this.lblStartDate.TabIndex = 38;
            this.lblStartDate.Text = "Start Date :";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(307, 72);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerStartDate.TabIndex = 37;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(414, 33);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(19, 20);
            this.lblTotalAmountValue.TabIndex = 36;
            this.lblTotalAmountValue.Text = "0";
            // 
            // lblTotalAmountTitle
            // 
            this.lblTotalAmountTitle.AutoSize = true;
            this.lblTotalAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTitle.Location = new System.Drawing.Point(371, 12);
            this.lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            this.lblTotalAmountTitle.Size = new System.Drawing.Size(104, 20);
            this.lblTotalAmountTitle.TabIndex = 35;
            this.lblTotalAmountTitle.Text = "Total Amount";
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
            // lblNewStockValue
            // 
            this.lblNewStockValue.AutoSize = true;
            this.lblNewStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStockValue.Location = new System.Drawing.Point(228, 34);
            this.lblNewStockValue.Name = "lblNewStockValue";
            this.lblNewStockValue.Size = new System.Drawing.Size(19, 20);
            this.lblNewStockValue.TabIndex = 3;
            this.lblNewStockValue.Text = "0";
            // 
            // lblNewStockTitle
            // 
            this.lblNewStockTitle.AutoSize = true;
            this.lblNewStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStockTitle.Location = new System.Drawing.Point(196, 14);
            this.lblNewStockTitle.Name = "lblNewStockTitle";
            this.lblNewStockTitle.Size = new System.Drawing.Size(85, 20);
            this.lblNewStockTitle.TabIndex = 2;
            this.lblNewStockTitle.Text = "New Stock";
            // 
            // lblCurrentStockQuantity
            // 
            this.lblCurrentStockQuantity.AutoSize = true;
            this.lblCurrentStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockQuantity.Location = new System.Drawing.Point(52, 32);
            this.lblCurrentStockQuantity.Name = "lblCurrentStockQuantity";
            this.lblCurrentStockQuantity.Size = new System.Drawing.Size(19, 20);
            this.lblCurrentStockQuantity.TabIndex = 1;
            this.lblCurrentStockQuantity.Text = "0";
            // 
            // lblCurrentStockTitle
            // 
            this.lblCurrentStockTitle.AutoSize = true;
            this.lblCurrentStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockTitle.Location = new System.Drawing.Point(7, 15);
            this.lblCurrentStockTitle.Name = "lblCurrentStockTitle";
            this.lblCurrentStockTitle.Size = new System.Drawing.Size(107, 20);
            this.lblCurrentStockTitle.TabIndex = 0;
            this.lblCurrentStockTitle.Text = "Current Stock";
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // stocksTableAdapter1
            // 
            this.stocksTableAdapter1.ClearBeforeFill = true;
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 616);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxPurchaseItem);
            this.Controls.Add(this.grpBoxSaleHistory);
            this.Controls.Add(this.grpBoxSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasesForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.grpBoxSale.ResumeLayout(false);
            this.grpBoxSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).EndInit();
            this.grpBoxSaleHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPurchaseHistory)).EndInit();
            this.grpBoxPurchaseItem.ResumeLayout(false);
            this.grpBoxPurchaseItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSale;
        private System.Windows.Forms.DateTimePicker dateTimePickerMfgDate;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.ComboBox comboMedicine;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.GroupBox grpBoxSaleHistory;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.DataGridView dGridViewPurchaseHistory;
        private System.Windows.Forms.GroupBox grpBoxPurchaseItem;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.TextBox txtPurchaseId;
        private MedicalStoreDataSet1 medicalStoreDataSet1;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private MedicalStoreDataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
        private MedicalStoreDataSet3 medicalStoreDataSet3;
        private System.Windows.Forms.BindingSource stocksBindingSource1;
        private MedicalStoreDataSet3TableAdapters.StocksTableAdapter stocksTableAdapter1;
        private System.Windows.Forms.Label lblCurrentStockTitle;
        private System.Windows.Forms.Label lblNewStockValue;
        private System.Windows.Forms.Label lblNewStockTitle;
        private System.Windows.Forms.Label lblCurrentStockQuantity;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmountTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MfgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button btnLoadAllPurchase;
        private System.Windows.Forms.Label lblSearchByItemCode;
        private System.Windows.Forms.TextBox txtSearchByItemCode;
    }
}