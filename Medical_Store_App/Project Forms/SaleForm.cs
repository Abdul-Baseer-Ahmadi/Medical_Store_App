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
    public partial class SaleForm : Form
    {
        MedicalContext db;
        SaleInfo sale = new SaleInfo();
        SoldProduct soldProduct = new SoldProduct();
        int userID, totalItems = 0;
        float profit, wholeSaleTotal = 0;
        long saleId;
        public SaleForm(int userId)
        {
            InitializeComponent();
            db = new MedicalContext();
            userID = userId;
        }
        private void SaleForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'medicalStoreDataSet1.Stocks' table. You can move, or remove it, as needed.
                this.stocksTableAdapter.Fill(this.medicalStoreDataSet1.Stocks);
                var bill = db.SaleInfos.Select(s => s.Sale_Id).DefaultIfEmpty().Max();

                if (bill == 0)
                {
                    txtBill.Text = (bill + 1).ToString();
                    SaveSale();
                }
                else
                {
                    var findRecord = db.SaleInfos.SingleOrDefault(i => i.Sale_Id == bill);
                    if (findRecord.Total_Amount == 0)
                    {
                        txtBill.Text = bill.ToString();
                    }
                    else
                    {
                        txtBill.Text = Convert.ToInt32(bill + 1).ToString();
                        SaveSale();
                    }
                }
                saleId = Convert.ToInt64(txtBill.Text);
                this.KeyPreview = true;
            }
            catch (Exception) { }
        }
        //This function is used to Save sale information.
        private void SaveSale()
        {
            try
            {
                sale.Sale_Id = Convert.ToInt64(txtBill.Text);
                sale.Sale_Date = dateTimePickerSale.Value.Date;
                sale.User_Id = userID;

                db.SaleInfos.Add(sale);
                db.SaveChanges();
                MessageBox.Show("Sale Saved.");
            }
            catch (Exception) { }
        }
        //This function is to Update the SaleInfo after adding item to SoldProduct.
        private void UpdateSale()
        {
            try
            {
                wholeSaleTotal += Convert.ToSingle(lblAmountValue.Text);
                lblTotalAmountAllValue.Text = wholeSaleTotal.ToString();
                lblPayableAmountValue.Text = wholeSaleTotal.ToString();
                totalItems += 1;
                lblTotalItemsValue.Text = totalItems.ToString();

                var saleRecord = db.SaleInfos.SingleOrDefault(i => i.Sale_Id == saleId);
                saleRecord.Total_Amount = wholeSaleTotal;
                saleRecord.Total_Items = Convert.ToInt32(lblTotalItemsValue.Text);
                saleRecord.Paid_Amount = wholeSaleTotal;
                db.SaveChanges();
            }
            catch (Exception) { }
        }
        //This function is used to fill Data Grid View.
        private void FillDataGridView(long saleId)
        {
            try
            {
                var soldItemsRecord = (from c in db.SoldProducts
                                       select new
                                       {
                                           c.Id,
                                           c.Sale_Id,
                                           c.Sold_Product.Name,
                                           c.Quantity,
                                           c.Price,
                                           c.Profit,
                                           c.Total_Amount,
                                           c.Sale_Date

                                       }).Where(i => i.Sale_Id == saleId).ToList();
                dGridViewSaleHistory.DataSource = soldItemsRecord;
            }
            catch (Exception) { }
        }

        //This function is used to Save sold items in SoldProduct Table.
        private void SaveSoldItem()
        {
            try
            {
                var itemCurrentStock = Convert.ToInt32(lblCurrentStockQuantity.Text);
                if (itemCurrentStock <= 0)
                {
                    txtQuantity.Text = "0";
                    MessageBox.Show("The Quatity of this item is 0 in Stock.");
                }
                else
                {
                    soldProduct.Sale_Id = Convert.ToInt64(txtBill.Text);
                    soldProduct.Product_Id = Convert.ToInt64(comboMedicine.SelectedValue);
                    soldProduct.Quantity = Convert.ToInt32(txtQuantity.Text);
                    soldProduct.Price = Convert.ToSingle(txtUnitPrice.Text);
                    soldProduct.Total_Amount = Convert.ToSingle(lblAmountValue.Text);
                    soldProduct.Profit = profit * Convert.ToInt32(txtQuantity.Text);
                    soldProduct.Sale_Date = dateTimePickerSale.Value.Date;
                    db.SoldProducts.Add(soldProduct);
                    db.SaveChanges();
                    UpdateSale();
                    FillDataGridView(Convert.ToInt64(txtBill.Text));
                    ReduceQuantity(txtCode.Text);
                    txtQuantity.Text = "1";
                }
            }

            catch (Exception) { }
        }
        //This function is used to update Stock Table Quantity.
        private void ReduceQuantity(string itemCode)
        {
            var quantity = Convert.ToInt32(txtQuantity.Text);
            var totalAmount = Convert.ToSingle(lblAmountValue.Text) - profit;
            var itemToBeReduce = db.Stocks.SingleOrDefault(c => c.Code == itemCode);
            itemToBeReduce.Quantity = itemToBeReduce.Quantity - quantity;
            itemToBeReduce.Total_Amount = itemToBeReduce.Total_Amount - totalAmount;
            db.Entry(itemToBeReduce).State = EntityState.Modified;
            db.SaveChanges();
            lblCurrentStockQuantity.Text = itemToBeReduce.Quantity.ToString();
        }
        //This function is used to Calculate the price and quantity.
        private void AmountCalculation()
        {
            if (txtQuantity.Text != "")
            {
                var quantity = Convert.ToInt32(txtQuantity.Text);
                var price = Convert.ToSingle(txtUnitPrice.Text);
                var amount = quantity * price;
                lblAmountValue.Text = amount.ToString();
            }
        }
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var itemCode = txtCode.Text;
                if (itemCode.Length < 3)
                {

                }
                else
                {
                    var searchRecord = db.Stocks.Where(i => i.Code == itemCode).SingleOrDefault();
                    comboMedicine.SelectedValue = searchRecord.Id;
                    txtUnitPrice.Text = searchRecord.Sale_Price.ToString();
                }
            }
            catch (Exception) { }
        }
        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SaveSoldItem();
                }
            }
            catch (Exception) { }
        }
        private void comboMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt64(comboMedicine.SelectedValue);
                var da = db.Stocks.Where(i => i.Id == id).SingleOrDefault();
                if (da != null)
                {
                    txtCode.Text = da.Code;
                    txtUnitPrice.Text = da.Sale_Price.ToString();
                    lblItemNameTitle.Text = comboMedicine.Text;
                    lblUnitPriceValue.Text = txtUnitPrice.Text;
                    lblCurrentStockQuantity.Text = da.Quantity.ToString();
                    lblExpiryDateValue.Text = da.Exp_Date.ToString("dd/MM/yyyy");
                    profit = da.Profit;
                    AmountCalculation();
                }
            }
            catch (Exception) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSoldItem();
            }
            catch (Exception) { }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            AmountCalculation();
        }
        private void comboMedicine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSoldItem();
            }
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm(userID);
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            sale.MdiParent = this.ParentForm;
            sale.Dock = DockStyle.Fill;
            sale.Show();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            float allTotal = Convert.ToSingle(lblTotalAmountAllValue.Text);
            float givenDiscount;
            float paidAmount;
            if (txtDiscount.Text != "")
            {
                int discount = Convert.ToInt32(txtDiscount.Text);
                if (discount <= 15)
                {
                    givenDiscount = (allTotal * discount) / 100;
                    paidAmount = allTotal - givenDiscount;
                    lblGiveDiscountValue.Text = givenDiscount.ToString();
                    lblPayableAmountValue.Text = paidAmount.ToString();
                }
                else
                {
                    MessageBox.Show("More than 15% is not Allowed.");
                    txtDiscount.Clear();
                }
            }
            else
            {
                givenDiscount = 0;
                paidAmount = allTotal - givenDiscount;
                lblGiveDiscountValue.Text = givenDiscount.ToString();
                lblPayableAmountValue.Text = paidAmount.ToString();
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                var saleRecord = db.SaleInfos.SingleOrDefault(i => i.Sale_Id == saleId);
                saleRecord.Discount = Convert.ToSingle(lblGiveDiscountValue.Text);
                saleRecord.Paid_Amount = Convert.ToSingle(lblPayableAmountValue.Text);
                db.Entry(saleRecord).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show(lblGiveDiscountValue.Text + "has been given.");
            }
            catch (Exception) { }
        }

        private void txtSearchByItemCode_TextChanged(object sender, EventArgs e)
        {
            var searchCode = txtSearchByItemCode.Text;
            if (searchCode.Length < 3)
            {
            }
            else
            {
                var startDate = dateTimePickerStartDate.Value.Date;
                var endDate = dateTimePickerEndDate.Value.Date;
                var soldItemsRecord = (from c in db.SoldProducts.Where(i => i.Sold_Product.Code == searchCode && i.Sale_Date >= startDate && i.Sale_Date <= endDate)
                                       select new
                                       {
                                           c.Id,
                                           c.Sale_Id,
                                           c.Sold_Product.Name,
                                           c.Quantity,
                                           c.Price,
                                           c.Profit,
                                           c.Total_Amount,
                                           c.Sale_Date
                                       }).ToList();
                dGridViewSaleHistory.DataSource = soldItemsRecord;
            }
        }

        private void dGridViewSaleHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var proId = Convert.ToInt64(dGridViewSaleHistory.CurrentRow.Cells[1].Value);
            var billId = Convert.ToUInt32(txtBill.Text);
            var billRecord = db.SaleInfos.SingleOrDefault(s => s.Sale_Id == billId);
            var soldItemToDelete = db.SoldProducts.SingleOrDefault(i => i.Id == proId);
            var remainingSaleAmount = Convert.ToSingle(lblTotalAmountAllValue.Text) - soldItemToDelete.Total_Amount;
            var noItems = Convert.ToInt32(lblTotalItemsValue.Text) - soldItemToDelete.Quantity;
            var totalNetAmount = Convert.ToSingle(lblPayableAmountValue.Text) - soldItemToDelete.Total_Amount;
            if(e.ColumnIndex == 0)
            {
                if(DialogResult.Yes == MessageBox.Show("Do you want to delete?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    db.SoldProducts.Remove(soldItemToDelete);
                    db.SaveChanges();
                    lblTotalItemsValue.Text = noItems.ToString();
                    lblTotalAmountAllValue.Text = remainingSaleAmount.ToString();
                    lblPayableAmountValue.Text = totalNetAmount.ToString();
                    billRecord.Total_Items = noItems;
                    billRecord.Total_Amount = remainingSaleAmount;
                    billRecord.Paid_Amount = totalNetAmount;
                    db.Entry(billRecord).State = EntityState.Modified;
                    db.SaveChanges();
                    FillDataGridView(billId);
                    MessageBox.Show("Deleted Successfully.");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var billId = Convert.ToInt64(txtBill.Text);
            SoldProductReportForm frm = new SoldProductReportForm(billId);
            frm.ShowDialog();
        }
        private void btnLoadAllSales_Click(object sender, EventArgs e)
        {
            try
            {
                var startDate = dateTimePickerStartDate.Value.Date;
                var endDate = dateTimePickerEndDate.Value.Date;
                var allSoldItemsRecord = (from c in db.SoldProducts.Where(i => i.Sale_Date >= startDate && i.Sale_Date <= endDate)
                                          select new
                                          {
                                              c.Id,
                                              c.Sale_Id,
                                              c.Sold_Product.Name,
                                              c.Quantity,
                                              c.Price,
                                              c.Profit,
                                              c.Total_Amount,
                                              c.Sale_Date

                                          }).ToList();
                dGridViewSaleHistory.DataSource = allSoldItemsRecord;
            }
            catch (Exception) { }
        }
    }
}
