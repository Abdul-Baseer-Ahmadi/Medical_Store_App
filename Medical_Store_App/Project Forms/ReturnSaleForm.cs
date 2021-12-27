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
    public partial class ReturnSaleForm : Form
    {
        MedicalContext db;
        ReturnInfo returnInfo = new ReturnInfo();
        SaleReturn saleItemReturn = new SaleReturn();
        long returnSaleId;
        int userID, totalReturnItems;
        float wholeSaleReturn = 0;
        public ReturnSaleForm(int userId)
        {
            InitializeComponent();
            db = new MedicalContext();
            userID = userId;
        }

        private void ReturnSaleForm_Load(object sender, EventArgs e)
        {
            //try
            {
                // TODO: This line of code loads data into the 'medicalStoreDataSet1.Stocks' table. You can move, or remove it, as needed.
                this.stocksTableAdapter.Fill(this.medicalStoreDataSet1.Stocks);
                 returnSaleId = db.ReturnInfos.Select(s => s.Return_Id).DefaultIfEmpty().Max();
                
                if(returnSaleId == 0)
                {
                    txtReturnSaleId.Text = (returnSaleId + 1).ToString();
                    returnInfo.Return_Id = Convert.ToInt64(txtReturnSaleId.Text);
                    returnInfo.Return_Date = dateTimePickerReturnSale.Value.Date;
                    returnInfo.User_Id = userID;
                    db.ReturnInfos.Add(returnInfo);
                    db.SaveChanges();
                }
                else
                {
                    var returnRecord = db.ReturnInfos.Where(i => i.Return_Id == returnSaleId).SingleOrDefault();
                    if(returnRecord.Return_Amount == 0)
                    {
                        txtReturnSaleId.Text = (returnRecord.Return_Id).ToString();
                    }
                    else
                    {
                        txtReturnSaleId.Text = (returnRecord.Return_Id + 1).ToString();
                        returnInfo.Return_Id = Convert.ToInt64(txtReturnSaleId.Text);
                        returnInfo.Return_Date = dateTimePickerReturnSale.Value.Date;
                        returnInfo.User_Id = userID;
                        db.ReturnInfos.Add(returnInfo);
                        db.SaveChanges();
                        MessageBox.Show("Id Created.");
                    }
                }
            }
            //catch (Exception) { }
        }
        //This function is used to the return items.
        private void SaveReturnItem()
        {
            //try
            {
                saleItemReturn.Return_Id = Convert.ToInt64(txtReturnSaleId.Text);
                saleItemReturn.Product_Id = Convert.ToInt64(comboMedicine.SelectedValue);
                saleItemReturn.Unit_Price = Convert.ToSingle(txtUnitPrice.Text);
                saleItemReturn.Quantity = Convert.ToInt32(txtQuantity.Text);
                saleItemReturn.Total_Amount = Convert.ToSingle(lblTotalAmountValue.Text);
                saleItemReturn.Return_Date = dateTimePickerReturnSale.Value.Date;
                db.SaleReturns.Add(saleItemReturn);
                db.SaveChanges();
                UpdateReturnInfo();
                FillDataGridView(Convert.ToInt64(txtReturnSaleId.Text));
            }
           //catch (Exception) { }
        }
        //This function is used to update the returnInfo.
        private void UpdateReturnInfo()
        {
            try
            {
                wholeSaleReturn += Convert.ToSingle(lblTotalAmountValue.Text);
                totalReturnItems += 1;
                lblReturnAmountValue.Text = wholeSaleReturn.ToString();
                lblTotalItemsValue.Text = totalReturnItems.ToString();

                var updateReturnInfo = db.ReturnInfos.Where(i => i.Return_Id == returnSaleId).SingleOrDefault();
                updateReturnInfo.Total_items = totalReturnItems;
                updateReturnInfo.Return_Amount = wholeSaleReturn;
                updateReturnInfo.Return_Date = dateTimePickerReturnSale.Value.Date;
                db.Entry(updateReturnInfo).State = EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception) { }
        }
        //This function is used to fill the data grid view.
        private void FillDataGridView(long returnId)
        {
            var saleReturn = (from returns in db.SaleReturns.Where(i => i.Return_Id == returnId)
                              select new
                              {
                                  returns.Return_Id,
                                  returns.Stock_Products.Code,
                                  returns.Stock_Products.Name,
                                  returns.Unit_Price,
                                  returns.Quantity,
                                  returns.Total_Amount,
                                  returns.Return_Date,
                              }).ToList();
            dataGridViewSaleReturn.DataSource = saleReturn;
        }
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
                    lblItemName.Text = searchRecord.Name;
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
                    lblItemName.Text = comboMedicine.Text;
                    txtUnitPrice.Text = txtUnitPrice.Text;
                }
            }
            catch (Exception) { }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtQuantity.Text != "")
                {
                    var quantity = Convert.ToInt32(txtQuantity.Text);
                    var unitPrice = Convert.ToSingle(txtUnitPrice.Text);
                    lblTotalAmountValue.Text = (quantity * unitPrice).ToString();
                    lblQuantityValue.Text = quantity.ToString();
                }
            }
            catch (Exception) { }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SaveReturnItem();
        }

    }
}
