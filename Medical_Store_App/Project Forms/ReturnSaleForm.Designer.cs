
namespace Medical_Store_App.Project_Forms
{
    partial class ReturnSaleForm
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
            this.grpBoxSaleReturn = new System.Windows.Forms.GroupBox();
            this.txtReturnSaleId = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dateTimePickerReturnSale = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.comboMedicine = new System.Windows.Forms.ComboBox();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet1 = new Medical_Store_App.MedicalStoreDataSet1();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.groupBoxReturnDetails = new System.Windows.Forms.GroupBox();
            this.lblReturnAmountValue = new System.Windows.Forms.Label();
            this.lblReturnAmountTitle = new System.Windows.Forms.Label();
            this.lblTotalItemsTitle = new System.Windows.Forms.Label();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmountTitle = new System.Windows.Forms.Label();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            this.lblQuantityTitle = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemNameTitle = new System.Windows.Forms.Label();
            this.stocksTableAdapter = new Medical_Store_App.MedicalStoreDataSet1TableAdapters.StocksTableAdapter();
            this.dataGridViewSaleReturn = new System.Windows.Forms.DataGridView();
            this.ReturnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxSaleReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).BeginInit();
            this.groupBoxReturnDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxSaleReturn
            // 
            this.grpBoxSaleReturn.Controls.Add(this.txtReturnSaleId);
            this.grpBoxSaleReturn.Controls.Add(this.btnReturn);
            this.grpBoxSaleReturn.Controls.Add(this.dateTimePickerReturnSale);
            this.grpBoxSaleReturn.Controls.Add(this.lblReturnDate);
            this.grpBoxSaleReturn.Controls.Add(this.txtQuantity);
            this.grpBoxSaleReturn.Controls.Add(this.lblQuantity);
            this.grpBoxSaleReturn.Controls.Add(this.txtUnitPrice);
            this.grpBoxSaleReturn.Controls.Add(this.lblUnitPrice);
            this.grpBoxSaleReturn.Controls.Add(this.comboMedicine);
            this.grpBoxSaleReturn.Controls.Add(this.lblName);
            this.grpBoxSaleReturn.Controls.Add(this.txtCode);
            this.grpBoxSaleReturn.Controls.Add(this.lblCode);
            this.grpBoxSaleReturn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpBoxSaleReturn.Location = new System.Drawing.Point(9, 6);
            this.grpBoxSaleReturn.Name = "grpBoxSaleReturn";
            this.grpBoxSaleReturn.Size = new System.Drawing.Size(266, 608);
            this.grpBoxSaleReturn.TabIndex = 1;
            this.grpBoxSaleReturn.TabStop = false;
            this.grpBoxSaleReturn.Text = "Sale Return";
            // 
            // txtReturnSaleId
            // 
            this.txtReturnSaleId.Location = new System.Drawing.Point(138, 14);
            this.txtReturnSaleId.Name = "txtReturnSaleId";
            this.txtReturnSaleId.Size = new System.Drawing.Size(105, 20);
            this.txtReturnSaleId.TabIndex = 102;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(7, 397);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(254, 33);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dateTimePickerReturnSale
            // 
            this.dateTimePickerReturnSale.Location = new System.Drawing.Point(6, 346);
            this.dateTimePickerReturnSale.Name = "dateTimePickerReturnSale";
            this.dateTimePickerReturnSale.Size = new System.Drawing.Size(254, 20);
            this.dateTimePickerReturnSale.TabIndex = 101;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReturnDate.Location = new System.Drawing.Point(5, 327);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(73, 15);
            this.lblReturnDate.TabIndex = 100;
            this.lblReturnDate.Text = "Return Date";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(6, 297);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(254, 23);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
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
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
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
            this.comboMedicine.TabIndex = 2;
            this.comboMedicine.ValueMember = "Id";
            this.comboMedicine.SelectedIndexChanged += new System.EventHandler(this.comboMedicine_SelectedIndexChanged);
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
            // groupBoxReturnDetails
            // 
            this.groupBoxReturnDetails.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxReturnDetails.Controls.Add(this.lblReturnAmountValue);
            this.groupBoxReturnDetails.Controls.Add(this.lblReturnAmountTitle);
            this.groupBoxReturnDetails.Controls.Add(this.lblTotalItemsTitle);
            this.groupBoxReturnDetails.Controls.Add(this.lblTotalItemsValue);
            this.groupBoxReturnDetails.Controls.Add(this.lblTotalAmountValue);
            this.groupBoxReturnDetails.Controls.Add(this.lblTotalAmountTitle);
            this.groupBoxReturnDetails.Controls.Add(this.lblQuantityValue);
            this.groupBoxReturnDetails.Controls.Add(this.lblQuantityTitle);
            this.groupBoxReturnDetails.Controls.Add(this.lblItemName);
            this.groupBoxReturnDetails.Controls.Add(this.lblItemNameTitle);
            this.groupBoxReturnDetails.Location = new System.Drawing.Point(281, 6);
            this.groupBoxReturnDetails.Name = "groupBoxReturnDetails";
            this.groupBoxReturnDetails.Size = new System.Drawing.Size(1102, 81);
            this.groupBoxReturnDetails.TabIndex = 22;
            this.groupBoxReturnDetails.TabStop = false;
            this.groupBoxReturnDetails.Text = "Return Details";
            // 
            // lblReturnAmountValue
            // 
            this.lblReturnAmountValue.AutoSize = true;
            this.lblReturnAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmountValue.ForeColor = System.Drawing.Color.Orange;
            this.lblReturnAmountValue.Location = new System.Drawing.Point(1004, 47);
            this.lblReturnAmountValue.Name = "lblReturnAmountValue";
            this.lblReturnAmountValue.Size = new System.Drawing.Size(17, 17);
            this.lblReturnAmountValue.TabIndex = 9;
            this.lblReturnAmountValue.Text = "0";
            // 
            // lblReturnAmountTitle
            // 
            this.lblReturnAmountTitle.AutoSize = true;
            this.lblReturnAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmountTitle.ForeColor = System.Drawing.Color.White;
            this.lblReturnAmountTitle.Location = new System.Drawing.Point(960, 20);
            this.lblReturnAmountTitle.Name = "lblReturnAmountTitle";
            this.lblReturnAmountTitle.Size = new System.Drawing.Size(116, 17);
            this.lblReturnAmountTitle.TabIndex = 8;
            this.lblReturnAmountTitle.Text = "Return Amount";
            // 
            // lblTotalItemsTitle
            // 
            this.lblTotalItemsTitle.AutoSize = true;
            this.lblTotalItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalItemsTitle.Location = new System.Drawing.Point(731, 18);
            this.lblTotalItemsTitle.Name = "lblTotalItemsTitle";
            this.lblTotalItemsTitle.Size = new System.Drawing.Size(88, 17);
            this.lblTotalItemsTitle.TabIndex = 2;
            this.lblTotalItemsTitle.Text = "Total Items";
            // 
            // lblTotalItemsValue
            // 
            this.lblTotalItemsValue.AutoSize = true;
            this.lblTotalItemsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsValue.ForeColor = System.Drawing.Color.Orange;
            this.lblTotalItemsValue.Location = new System.Drawing.Point(757, 45);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Size = new System.Drawing.Size(17, 17);
            this.lblTotalItemsValue.TabIndex = 3;
            this.lblTotalItemsValue.Text = "0";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.Orange;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(457, 45);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(17, 17);
            this.lblTotalAmountValue.TabIndex = 7;
            this.lblTotalAmountValue.Text = "0";
            // 
            // lblTotalAmountTitle
            // 
            this.lblTotalAmountTitle.AutoSize = true;
            this.lblTotalAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountTitle.Location = new System.Drawing.Point(437, 18);
            this.lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            this.lblTotalAmountTitle.Size = new System.Drawing.Size(104, 17);
            this.lblTotalAmountTitle.TabIndex = 6;
            this.lblTotalAmountTitle.Text = "Total Amount";
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityValue.ForeColor = System.Drawing.Color.Orange;
            this.lblQuantityValue.Location = new System.Drawing.Point(250, 45);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(17, 17);
            this.lblQuantityValue.TabIndex = 5;
            this.lblQuantityValue.Text = "0";
            // 
            // lblQuantityTitle
            // 
            this.lblQuantityTitle.AutoSize = true;
            this.lblQuantityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityTitle.ForeColor = System.Drawing.Color.White;
            this.lblQuantityTitle.Location = new System.Drawing.Point(230, 18);
            this.lblQuantityTitle.Name = "lblQuantityTitle";
            this.lblQuantityTitle.Size = new System.Drawing.Size(69, 17);
            this.lblQuantityTitle.TabIndex = 4;
            this.lblQuantityTitle.Text = "Quantity";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Orange;
            this.lblItemName.Location = new System.Drawing.Point(27, 45);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(38, 17);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "item";
            // 
            // lblItemNameTitle
            // 
            this.lblItemNameTitle.AutoSize = true;
            this.lblItemNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblItemNameTitle.Location = new System.Drawing.Point(7, 18);
            this.lblItemNameTitle.Name = "lblItemNameTitle";
            this.lblItemNameTitle.Size = new System.Drawing.Size(84, 17);
            this.lblItemNameTitle.TabIndex = 0;
            this.lblItemNameTitle.Text = "Item Name";
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSaleReturn
            // 
            this.dataGridViewSaleReturn.AllowUserToAddRows = false;
            this.dataGridViewSaleReturn.AllowUserToDeleteRows = false;
            this.dataGridViewSaleReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSaleReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReturnId,
            this.ProductCode,
            this.ProductName,
            this.UnitPrice,
            this.Quantity,
            this.TotalAmount,
            this.ReturnDate});
            this.dataGridViewSaleReturn.Location = new System.Drawing.Point(282, 91);
            this.dataGridViewSaleReturn.Name = "dataGridViewSaleReturn";
            this.dataGridViewSaleReturn.ReadOnly = true;
            this.dataGridViewSaleReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSaleReturn.Size = new System.Drawing.Size(1075, 523);
            this.dataGridViewSaleReturn.TabIndex = 23;
            // 
            // ReturnId
            // 
            this.ReturnId.DataPropertyName = "Return_Id";
            this.ReturnId.HeaderText = "Return Id";
            this.ReturnId.Name = "ReturnId";
            this.ReturnId.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "Code";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "Unit_Price";
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "Total_Amount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "Return_Date";
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // ReturnSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 626);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewSaleReturn);
            this.Controls.Add(this.groupBoxReturnDetails);
            this.Controls.Add(this.grpBoxSaleReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnSaleForm";
            this.Text = "Return Sale Form";
            this.Load += new System.EventHandler(this.ReturnSaleForm_Load);
            this.grpBoxSaleReturn.ResumeLayout(false);
            this.grpBoxSaleReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).EndInit();
            this.groupBoxReturnDetails.ResumeLayout(false);
            this.groupBoxReturnDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSaleReturn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnSale;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.ComboBox comboMedicine;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.GroupBox groupBoxReturnDetails;
        private System.Windows.Forms.Label lblReturnAmountValue;
        private System.Windows.Forms.Label lblReturnAmountTitle;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmountTitle;
        private System.Windows.Forms.Label lblQuantityValue;
        private System.Windows.Forms.Label lblQuantityTitle;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalItemsTitle;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemNameTitle;
        private MedicalStoreDataSet1 medicalStoreDataSet1;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private MedicalStoreDataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.TextBox txtReturnSaleId;
        private System.Windows.Forms.DataGridView dataGridViewSaleReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
    }
}