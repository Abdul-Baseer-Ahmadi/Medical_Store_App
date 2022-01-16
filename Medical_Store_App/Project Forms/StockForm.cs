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
    public partial class StockForm : Form
    {
        MedicalContext db;
        Stock stock = new Stock();
        public StockForm()
        {
            InitializeComponent();
            db = new MedicalContext();
        }
        private void FillDataGridView()
        {
            //var records = db.Stocks.ToList();
            var itemRecord = (from c in db.Stocks
                              select new
                              {
                                  c.Id,
                                  c.Code,
                                  c.Name,
                                  c.Type,
                                  c.Purchase_Price,
                                  c.Profit,
                                  c.Sale_Price,
                                  c.Quantity,
                                  c.Total_Amount,
                                  c.Mfg_Date,
                                  c.Exp_Date
                              }).ToList();
            dGridViewStock.DataSource = itemRecord;

        }
        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtCode.Clear();
            txtName.Clear();
            txtType.Clear();
            txtPurchasePrice.Clear();
            txtProfit.Clear();
            txtSalePrice.Clear();
            txtQuantity.Clear();
            dateTimePickerMfgDate.Value = DateTime.Now.Date;
            dateTimePickerExpDate.Value = DateTime.Now.Date;
            btnSave.Text = "Save";
        }
        private void SearchRecord(string searchItem)
        {
            if (txtCode.Text != "")
            {
                var itemRecord = (from c in db.Stocks
                                  select new
                                  {
                                      c.Id,
                                      c.Code,
                                      c.Name,
                                      c.Type,
                                      c.Purchase_Price,
                                      c.Profit,
                                      c.Sale_Price,
                                      c.Quantity,
                                      c.Total_Amount,
                                      c.Mfg_Date,
                                      c.Exp_Date
                                  }).Where(r => r.Code == searchItem).ToList();
                dGridViewStock.DataSource = itemRecord;
            }
            else
            {
                FillDataGridView();
            }

        }
        private void SaveUpdateItem()
        {
            var id = txtId.Text;
            if (id == "")
            {
                var code = txtCode.Text;
                if (db.Stocks.Any(c => c.Code == code))
                {
                    MessageBox.Show("Already Exist");
                }
                else
                {
                    stock.Code = txtCode.Text;
                    stock.Name = txtName.Text;
                    stock.Type = txtType.Text;
                    stock.Purchase_Price = Convert.ToSingle(txtPurchasePrice.Text);
                    stock.Profit = (Convert.ToSingle(txtProfit.Text) * Convert.ToSingle(txtPurchasePrice.Text)) / 100;
                    stock.Sale_Price = Convert.ToSingle(txtSalePrice.Text);
                    stock.Quantity = Convert.ToInt32(txtQuantity.Text);
                    stock.Total_Amount = Convert.ToSingle(lblTotalAmountValue.Text);
                    stock.Mfg_Date = dateTimePickerMfgDate.Value.Date;
                    stock.Exp_Date = dateTimePickerExpDate.Value.Date;
                    db.Stocks.Add(stock);
                }
            }
            else
            {
                var stockId = Convert.ToInt64(id);
                var stockRecord = db.Stocks.SingleOrDefault(s => s.Id == stockId);
                stockRecord.Code = txtCode.Text;
                stockRecord.Name = txtName.Text;
                stockRecord.Type = txtType.Text;
                stockRecord.Purchase_Price = Convert.ToSingle(txtPurchasePrice.Text);
                stockRecord.Profit = (Convert.ToSingle(txtProfit.Text) * Convert.ToSingle(txtPurchasePrice.Text)) / 100;
                stockRecord.Sale_Price = Convert.ToSingle(txtSalePrice.Text);
                stockRecord.Quantity = Convert.ToInt32(txtQuantity.Text);
                stockRecord.Total_Amount = Convert.ToSingle(lblTotalAmountValue.Text);
                stockRecord.Mfg_Date = dateTimePickerMfgDate.Value.Date;
                stockRecord.Exp_Date = dateTimePickerExpDate.Value.Date;
                db.Entry(stockRecord).State = EntityState.Modified;
            }
            db.SaveChanges();
            FillDataGridView();
            ClearTextBoxes();
            MessageBox.Show("Record Saved successfully.");
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        //This function is used to check the the input for number.
        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
              && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUpdateItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            SearchRecord(txtCode.Text);

        }

        private void dGridViewStock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dGridViewStock.Columns["Id"].Index.ToString());
            try
            {
                int id = Convert.ToInt32(dGridViewStock.CurrentRow.Cells[2].Value);
                var data = db.Stocks.Where(i => i.Id == id).SingleOrDefault();
                if (e.ColumnIndex == 0)
                {
                    txtId.Text = data.Id.ToString();
                    txtCode.Text = data.Code;
                    txtName.Text = data.Name;
                    txtType.Text = data.Type;
                    txtPurchasePrice.Text = data.Purchase_Price.ToString();
                    txtProfit.Text = ((data.Profit * 100) / data.Purchase_Price).ToString();
                    //txtSalePrice.Text = data.Sale_Price.ToString();
                    txtQuantity.Text = data.Quantity.ToString();
                    lblTotalAmountValue.Text = data.Total_Amount.ToString();
                    dateTimePickerMfgDate.Value = data.Mfg_Date.Date;
                    dateTimePickerExpDate.Value = data.Exp_Date.Date;
                    btnSave.Text = "Update";
                }
                else if (e.ColumnIndex == 2)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you want to delete " + data.Name + " record?",
                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        db.Stocks.Remove(data);
                        db.SaveChanges();
                        FillDataGridView();
                        MessageBox.Show("Record Deleted");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtProfit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProfit.Text != "")
                {
                    var profit = Convert.ToSingle(txtProfit.Text);
                    var purchasePrice = Convert.ToSingle(txtPurchasePrice.Text);
                    float profitCalculated = (purchasePrice * profit) / 100;
                    var salePrice = purchasePrice + profitCalculated;
                    txtSalePrice.Text = salePrice.ToString();
                }
            }
            catch (Exception) { }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var searchByName = (from proStock in db.Stocks.Where(s => s.Name.StartsWith(txtName.Text))
                                select new
                                {
                                    proStock.Id,
                                    proStock.Code,
                                    proStock.Name,
                                    proStock.Type,
                                    proStock.Purchase_Price,
                                    proStock.Profit,
                                    proStock.Sale_Price,
                                    proStock.Quantity,
                                    proStock.Total_Amount,
                                    proStock.Mfg_Date,
                                    proStock.Exp_Date
                                }).ToList();
            dGridViewStock.DataSource = searchByName;
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var totalAmount = Convert.ToSingle(txtPurchasePrice.Text) * Convert.ToInt32(txtQuantity.Text);
                lblTotalAmountValue.Text = totalAmount.ToString();
            }
            catch (Exception) { }
        }

        private void txtPurchasePrice_Leave(object sender, EventArgs e)
        {
            try
            {
                var totalAmount = Convert.ToSingle(txtPurchasePrice.Text) * Convert.ToInt32(txtQuantity.Text);
                lblTotalAmountValue.Text = totalAmount.ToString();
            }
            catch (Exception) { }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPurchasePrice.Text != "" && txtQuantity.Text != "")
                {
                    var totalAmount = Convert.ToSingle(txtPurchasePrice.Text) * Convert.ToInt32(txtQuantity.Text);
                    lblTotalAmountValue.Text = totalAmount.ToString();
                }
            }
            catch (Exception) { }
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void txtProfit_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void btnPrintStockHistory_Click(object sender, EventArgs e)
        {
            try
            {
                StockReportForm stockReportForm = new StockReportForm();
                stockReportForm.ShowDialog();
            }
            catch (Exception) { }
        }
    }
}
