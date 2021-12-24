using Medical_Store_App.Project_Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        long returnSaleId;
        public ReturnSaleForm()
        {
            InitializeComponent();
            db = new MedicalContext();
        }

        private void ReturnSaleForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'medicalStoreDataSet1.Stocks' table. You can move, or remove it, as needed.
                this.stocksTableAdapter.Fill(this.medicalStoreDataSet1.Stocks);
                 returnSaleId = db.ReturnInfos.Select(s => s.Return_Id).DefaultIfEmpty().Max();
                
                if(returnSaleId == 0)
                {
                    txtReturnSaleId.Text = (returnSaleId + 1).ToString();
                }
                else
                {
                    var returnRecord = db.ReturnInfos.Where(i => i.Return_Id == returnSaleId).SingleOrDefault();
                    if(returnRecord.Total_Amount == 0)
                    {
                        txtReturnSaleId.Text = (returnRecord.Return_Id).ToString();
                    }
                    else
                    {
                        txtReturnSaleId.Text = (returnRecord.Return_Id + 1).ToString();
                    }
                    //txtReturnSaleId.Text = Convert.ToInt64(returnSaleId)+ 1.ToString();
                }
            }
            catch (Exception) { }
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
    }
}
