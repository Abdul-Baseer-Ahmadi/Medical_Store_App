using Medical_Store_App.Project_Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_App.Project_Forms
{
    public partial class PurchasesForm : Form
    {
        MedicalContext db;
        PurchaseInfo purchaseInfo;
        PurchaseItem purchaseItems;
        int userID;
        long purchaseId;
        float caculatedProfit;
        public PurchasesForm(int userId)
        {
            InitializeComponent();
            db = new MedicalContext();
            purchaseInfo = new PurchaseInfo();
            purchaseItems = new PurchaseItem();
            userID = userId;
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet3.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter1.Fill(this.medicalStoreDataSet3.Stocks);
            // TODO: This line of code loads data into the 'medicalStoreDataSet1.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.medicalStoreDataSet1.Stocks);
            try
            {
                purchaseId = db.PurchaseInfos.Select(s => s.Purchase_Id).DefaultIfEmpty().Max();
                txtPurchaseId.Text = (purchaseId + 1).ToString();
                MessageBox.Show(purchaseId.ToString());
            }
            catch (Exception) { }
        }
        //This function is used to save or update the purchase item.
        private void SaveOrUpdatePurchaseItem()
        {
            if(txtBill.Text != "")
            {
                purchaseItems.Purchase_Id = Convert.ToInt64(txtPurchaseId.Text);
                purchaseItems.Invoice_No = Convert.ToInt64(txtBill.Text);
                purchaseItems.Product_Id = Convert.ToInt64(comboMedicine.SelectedValue);
                purchaseItems.Quantity = Convert.ToInt32(txtQuantity.Text);
                purchaseItems.Purchase_Price = Convert.ToSingle(txtPurchasePrice.Text);
                purchaseItems.Sale_Price = Convert.ToSingle(txtSalePrice.Text);
                purchaseItems.Total_Amount = Convert.ToSingle(lblTotalAmountValue.Text);
                purchaseItems.Purchase_Date = dateTimePickerPurchaseDate.Value.Date;
                purchaseItems.Mfg_Date = dateTimePickerMfgDate.Value.Date;
                purchaseItems.Expiry_Date = dateTimePickerExpiryDate.Value.Date;

                db.PurchaseItems.Add(purchaseItems);
                db.SaveChanges();
                FillDataGridView();
                UpdateStockAfterPurchase(txtCode.Text);
                MessageBox.Show("Record Inserted Successfully.");
            }
            else
            {
                MessageBox.Show("Enter the Bill No");
            }
        }
        //This function is used to Fill Data Grid View.
        private void FillDataGridView()
        {
            var invoiceNo = Convert.ToInt64(txtBill.Text);
            var purchaseItems = (from item in db.PurchaseItems.Where(i => i.Invoice_No == invoiceNo)
                                 select new
                                 {
                                     item.Id,
                                     item.Item_Stock.Name,
                                     item.Quantity,
                                     item.Purchase_Price,
                                     item.Item_Stock.Profit,
                                     item.Sale_Price,
                                     item.Total_Amount,
                                     item.Purchase_Date,
                                     item.Mfg_Date,
                                     item.Expiry_Date
                                 }).ToList();
            dGridViewPurchaseHistory.DataSource = purchaseItems;
        }
        //This function is used to update the stock after purchase.
        private void UpdateStockAfterPurchase(string itemCode)
        {
            var purchaseItem = db.Stocks.Where(c => c.Code == itemCode).SingleOrDefault();
            purchaseItem.Quantity = Convert.ToInt32(lblNewStockValue.Text);
            purchaseItem.Purchase_Price = Convert.ToSingle(txtPurchasePrice.Text);
            purchaseItem.Sale_Price = Convert.ToSingle(txtSalePrice.Text);
            purchaseItem.Total_Amount = Convert.ToSingle(txtPurchasePrice.Text) * Convert.ToInt32(lblNewStockValue.Text);
            if(txtProfit.Text != "")
            {
                purchaseItem.Profit = (Convert.ToSingle(txtProfit.Text) * Convert.ToSingle(txtPurchasePrice.Text)) / 100;
                
            }
            else
            {
                purchaseItem.Profit = purchaseItem.Profit;
            }
            db.Entry(purchaseItem).State = EntityState.Modified;
            db.SaveChanges();
        }
        private void comboMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            long itemId = Convert.ToInt64(comboMedicine.SelectedValue);
            if (itemId > 0)
            {
                var stockHistory = db.Stocks.Where(i => i.Id == itemId).SingleOrDefault();
                txtCode.Text = stockHistory.Code;
                txtPurchasePrice.Text = stockHistory.Purchase_Price.ToString();
                txtSalePrice.Text = stockHistory.Sale_Price.ToString();
                lblCurrentStockQuantity.Text = stockHistory.Quantity.ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                var newQuantity = Convert.ToInt32(txtQuantity.Text);
                var currentStock = Convert.ToInt32(lblCurrentStockQuantity.Text);
                var purchasePrice = Convert.ToSingle(txtPurchasePrice.Text);
                lblNewStockValue.Text = (newQuantity + currentStock).ToString();
                lblTotalAmountValue.Text = (newQuantity * purchasePrice).ToString();
               
            }
        }

        private void txtBill_Leave(object sender, EventArgs e)
        {
            if(txtBill.Text != "")
            {
                var invoice = Convert.ToInt64(txtBill.Text);
                var purchaseInvoice = db.PurchaseInfos.Where(i => i.Invoice == invoice).SingleOrDefault();
                if (purchaseInvoice != null)
                {
                    txtPurchaseId.Text = purchaseInvoice.Purchase_Id.ToString();
                }
                else
                {
                    txtPurchaseId.Text = Convert.ToInt64(purchaseId + 1).ToString();
                    purchaseInfo.Purchase_Id = Convert.ToInt64(txtPurchaseId.Text);
                    purchaseInfo.Invoice = Convert.ToInt64(txtBill.Text);
                    purchaseInfo.Purchase_Date = DateTime.Now.Date;
                    purchaseInfo.User_Id = userID;
                    db.PurchaseInfos.Add(purchaseInfo);
                    db.SaveChanges();
                    MessageBox.Show("Invoice Inserted.");
                }
            }
            
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if(txtCode.Text.Length < 3)
            {

            }
            else
            {
                var stockHistory = db.Stocks.Where(i => i.Code == txtCode.Text).SingleOrDefault();
                comboMedicine.SelectedValue = stockHistory.Id;
                txtPurchasePrice.Text = stockHistory.Purchase_Price.ToString();
                txtSalePrice.Text = stockHistory.Sale_Price.ToString();
                lblCurrentStockQuantity.Text = stockHistory.Quantity.ToString();
                
            }
        }

        private void txtProfit_TextChanged(object sender, EventArgs e)
        {
            if (txtProfit.Text != "")
            {
                int profitPercentage = Convert.ToInt32(txtProfit.Text);
                float purchasePrice = Convert.ToSingle(txtPurchasePrice.Text);

                if (profitPercentage <= 0)
                {

                }
                else
                {
                    caculatedProfit = (purchasePrice * profitPercentage) / 100;
                    txtSalePrice.Text = (purchasePrice + caculatedProfit).ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var itemCode = txtCode.Text;
            var stockDetails = db.Stocks.Where(i => i.Code == itemCode).SingleOrDefault();
            stockDetails.Quantity = Convert.ToInt32(lblNewStockValue.Text);
            stockDetails.Purchase_Price = Convert.ToSingle(txtPurchasePrice.Text);
            stockDetails.Mfg_Date = dateTimePickerMfgDate.Value.Date;
            stockDetails.Exp_Date = dateTimePickerExpiryDate.Value.Date;
            if(txtProfit.Text == "")
            {
                stockDetails.Profit = stockDetails.Profit;
            }
            else
            {
                stockDetails.Profit = caculatedProfit;
            }
            db.Entry(stockDetails).State = EntityState.Modified;
            db.SaveChanges();
            SaveOrUpdatePurchaseItem();
        }

        private void btnLoadAllPurchase_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerStartDate.Value.Date;
            var endDate = dateTimePickerEndDate.Value.Date;
            var allPurchases = (from allPurchase in db.PurchaseItems.Where(i => i.Purchase_Date >= startDate && i.Purchase_Date <= endDate)
                                select new {
                                    allPurchase.Id,
                                    allPurchase.Item_Stock.Name,
                                    allPurchase.Quantity,
                                    allPurchase.Purchase_Price,
                                    allPurchase.Item_Stock.Profit,
                                    allPurchase.Sale_Price,
                                    allPurchase.Total_Amount,
                                    allPurchase.Purchase_Date,
                                    allPurchase.Mfg_Date,
                                    allPurchase.Expiry_Date
                                }).ToList();
            dGridViewPurchaseHistory.DataSource = allPurchases;
        }

        private void txtBill_TextChanged(object sender, EventArgs e)
        {
            if(txtBill.Text != "")
            {
                FillDataGridView();
            }
        }

        private void txtSearchByItemCode_TextChanged(object sender, EventArgs e)
       {
            var purchaseItemSearch = (from item in db.PurchaseItems.Where(i => i.Item_Stock.Code == txtSearchByItemCode.Text)
                                      select new
                                      {
                                          item.Id,
                                          item.Item_Stock.Name,
                                          item.Quantity,
                                          item.Purchase_Price,
                                          item.Item_Stock.Profit,
                                          item.Sale_Price,
                                          item.Total_Amount,
                                          item.Purchase_Date,
                                          item.Mfg_Date,
                                          item.Expiry_Date
                                      }).ToList();
            dGridViewPurchaseHistory.DataSource = purchaseItemSearch;
        }
    }
}
