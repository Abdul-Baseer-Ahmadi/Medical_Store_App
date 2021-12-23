
namespace Medical_Store_App.Project_Forms
{
    partial class StockForm
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
            this.grpBoxItem = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dateTimePickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.pictureBoxStock = new System.Windows.Forms.PictureBox();
            this.grpBoxStockHistory = new System.Windows.Forms.GroupBox();
            this.dGridViewStock = new System.Windows.Forms.DataGridView();
            this.medicalStoreDataSet2 = new Medical_Store_App.MedicalStoreDataSet2();
            this.userLoginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLoginsTableAdapter = new Medical_Store_App.MedicalStoreDataSet2TableAdapters.UserLoginsTableAdapter();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MfgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnPrintStockHistory = new System.Windows.Forms.Button();
            this.grpBoxItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStock)).BeginInit();
            this.grpBoxStockHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxItem
            // 
            this.grpBoxItem.Controls.Add(this.txtName);
            this.grpBoxItem.Controls.Add(this.txtQuantity);
            this.grpBoxItem.Controls.Add(this.lblQuantity);
            this.grpBoxItem.Controls.Add(this.txtId);
            this.grpBoxItem.Controls.Add(this.btnCancel);
            this.grpBoxItem.Controls.Add(this.btnSave);
            this.grpBoxItem.Controls.Add(this.dateTimePickerExpDate);
            this.grpBoxItem.Controls.Add(this.lblExpDate);
            this.grpBoxItem.Controls.Add(this.dateTimePickerMfgDate);
            this.grpBoxItem.Controls.Add(this.lblMfgDate);
            this.grpBoxItem.Controls.Add(this.txtSalePrice);
            this.grpBoxItem.Controls.Add(this.lblSalePrice);
            this.grpBoxItem.Controls.Add(this.txtProfit);
            this.grpBoxItem.Controls.Add(this.lblProfit);
            this.grpBoxItem.Controls.Add(this.txtPurchasePrice);
            this.grpBoxItem.Controls.Add(this.lblPurchasePrice);
            this.grpBoxItem.Controls.Add(this.txtType);
            this.grpBoxItem.Controls.Add(this.lblType);
            this.grpBoxItem.Controls.Add(this.lblName);
            this.grpBoxItem.Controls.Add(this.txtCode);
            this.grpBoxItem.Controls.Add(this.lblCode);
            this.grpBoxItem.Location = new System.Drawing.Point(4, 1);
            this.grpBoxItem.Name = "grpBoxItem";
            this.grpBoxItem.Size = new System.Drawing.Size(284, 622);
            this.grpBoxItem.TabIndex = 0;
            this.grpBoxItem.TabStop = false;
            this.grpBoxItem.Text = "Add Item";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 22;
            this.txtId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(11, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePickerExpDate
            // 
            this.dateTimePickerExpDate.Location = new System.Drawing.Point(8, 430);
            this.dateTimePickerExpDate.Name = "dateTimePickerExpDate";
            this.dateTimePickerExpDate.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerExpDate.TabIndex = 8;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblExpDate.Location = new System.Drawing.Point(4, 408);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(57, 15);
            this.lblExpDate.TabIndex = 18;
            this.lblExpDate.Text = "Exp Date";
            // 
            // dateTimePickerMfgDate
            // 
            this.dateTimePickerMfgDate.Location = new System.Drawing.Point(7, 384);
            this.dateTimePickerMfgDate.Name = "dateTimePickerMfgDate";
            this.dateTimePickerMfgDate.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerMfgDate.TabIndex = 7;
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfgDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMfgDate.Location = new System.Drawing.Point(3, 363);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(57, 15);
            this.lblMfgDate.TabIndex = 16;
            this.lblMfgDate.Text = "Mfg Date";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(6, 335);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(254, 23);
            this.txtSalePrice.TabIndex = 45;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSalePrice.Location = new System.Drawing.Point(3, 315);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(63, 15);
            this.lblSalePrice.TabIndex = 12;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // txtProfit
            // 
            this.txtProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(7, 284);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(252, 23);
            this.txtProfit.TabIndex = 6;
            this.txtProfit.TextChanged += new System.EventHandler(this.txtProfit_TextChanged);
            this.txtProfit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfit_KeyPress);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProfit.Location = new System.Drawing.Point(3, 264);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(75, 15);
            this.lblProfit.TabIndex = 10;
            this.lblProfit.Text = "Profit(%age)";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(7, 237);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(252, 23);
            this.txtPurchasePrice.TabIndex = 5;
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
            this.txtPurchasePrice.Leave += new System.EventHandler(this.txtPurchasePrice_Leave);
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPurchasePrice.Location = new System.Drawing.Point(3, 215);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(90, 15);
            this.lblPurchasePrice.TabIndex = 8;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(6, 143);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(254, 23);
            this.txtType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblType.Location = new System.Drawing.Point(3, 122);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 15);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(5, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(6, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(254, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCode.Location = new System.Drawing.Point(5, 29);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(36, 15);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // pictureBoxStock
            // 
            this.pictureBoxStock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxStock.Location = new System.Drawing.Point(294, 1);
            this.pictureBoxStock.Name = "pictureBoxStock";
            this.pictureBoxStock.Size = new System.Drawing.Size(1077, 62);
            this.pictureBoxStock.TabIndex = 1;
            this.pictureBoxStock.TabStop = false;
            // 
            // grpBoxStockHistory
            // 
            this.grpBoxStockHistory.Controls.Add(this.dGridViewStock);
            this.grpBoxStockHistory.Location = new System.Drawing.Point(294, 69);
            this.grpBoxStockHistory.Name = "grpBoxStockHistory";
            this.grpBoxStockHistory.Size = new System.Drawing.Size(1077, 554);
            this.grpBoxStockHistory.TabIndex = 2;
            this.grpBoxStockHistory.TabStop = false;
            this.grpBoxStockHistory.Text = "Stock History";
            // 
            // dGridViewStock
            // 
            this.dGridViewStock.AllowUserToAddRows = false;
            this.dGridViewStock.AllowUserToDeleteRows = false;
            this.dGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.itemName,
            this.Type,
            this.PurchasePrice,
            this.Profit,
            this.SalePrice,
            this.Quantity,
            this.TotalAmount,
            this.MfgDate,
            this.ExpDate,
            this.Edit,
            this.Delete});
            this.dGridViewStock.Location = new System.Drawing.Point(1, 17);
            this.dGridViewStock.Name = "dGridViewStock";
            this.dGridViewStock.ReadOnly = true;
            this.dGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewStock.Size = new System.Drawing.Size(1068, 506);
            this.dGridViewStock.TabIndex = 0;
            this.dGridViewStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewStock_CellContentClick_1);
            // 
            // medicalStoreDataSet2
            // 
            this.medicalStoreDataSet2.DataSetName = "MedicalStoreDataSet2";
            this.medicalStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userLoginsBindingSource
            // 
            this.userLoginsBindingSource.DataMember = "UserLogins";
            this.userLoginsBindingSource.DataSource = this.medicalStoreDataSet2;
            // 
            // userLoginsTableAdapter
            // 
            this.userLoginsTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(298, 22);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(112, 20);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(435, 23);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalAmountValue.TabIndex = 4;
            this.lblTotalAmountValue.Text = "0";
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(6, 189);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(254, 23);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuantity.Location = new System.Drawing.Point(5, 168);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.FillWeight = 16.59014F;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "Name";
            this.itemName.FillWeight = 29.80265F;
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 16.59014F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "Purchase_Price";
            this.PurchasePrice.FillWeight = 16.59014F;
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.FillWeight = 16.59014F;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "Sale_Price";
            this.SalePrice.FillWeight = 16.59014F;
            this.SalePrice.HeaderText = "Sale Price";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 16.59014F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "Total_Amount";
            this.TotalAmount.FillWeight = 22.11346F;
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // MfgDate
            // 
            this.MfgDate.DataPropertyName = "Mfg_Date";
            this.MfgDate.FillWeight = 16.59014F;
            this.MfgDate.HeaderText = "Mfg Date";
            this.MfgDate.Name = "MfgDate";
            this.MfgDate.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "Exp_Date";
            this.ExpDate.FillWeight = 16.59014F;
            this.ExpDate.HeaderText = "Exp Date";
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 16.59014F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 16.59014F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // btnPrintStockHistory
            // 
            this.btnPrintStockHistory.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintStockHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStockHistory.ForeColor = System.Drawing.Color.White;
            this.btnPrintStockHistory.Location = new System.Drawing.Point(1214, 27);
            this.btnPrintStockHistory.Name = "btnPrintStockHistory";
            this.btnPrintStockHistory.Size = new System.Drawing.Size(155, 34);
            this.btnPrintStockHistory.TabIndex = 5;
            this.btnPrintStockHistory.Text = "Print Stock History";
            this.btnPrintStockHistory.UseVisualStyleBackColor = false;
            this.btnPrintStockHistory.Click += new System.EventHandler(this.btnPrintStockHistory_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 626);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrintStockHistory);
            this.Controls.Add(this.lblTotalAmountValue);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.grpBoxStockHistory);
            this.Controls.Add(this.pictureBoxStock);
            this.Controls.Add(this.grpBoxItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            this.grpBoxItem.ResumeLayout(false);
            this.grpBoxItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStock)).EndInit();
            this.grpBoxStockHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxItem;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMfgDate;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBoxStock;
        private System.Windows.Forms.GroupBox grpBoxStockHistory;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private System.Windows.Forms.TextBox txtId;
        private MedicalStoreDataSet2 medicalStoreDataSet2;
        private System.Windows.Forms.BindingSource userLoginsBindingSource;
        private MedicalStoreDataSet2TableAdapters.UserLoginsTableAdapter userLoginsTableAdapter;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.DataGridView dGridViewStock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MfgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button btnPrintStockHistory;
    }
}