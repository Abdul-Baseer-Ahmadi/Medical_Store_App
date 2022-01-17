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
    public partial class PaymentForm : Form
    {
        MedicalContext db;
        PaymentInfo payment = new PaymentInfo();
        readonly ToolTip tip = new ToolTip();
        float received, given;
        public PaymentForm()
        {
            InitializeComponent();
            db = new MedicalContext();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet4.CompanyInfoes' table. You can move, or remove it, as needed.
            this.companyInfoesTableAdapter.Fill(this.medicalStoreDataSet4.CompanyInfoes);

        }

        //This function is used to Fill Payment Data Grid View.
        private void FillDataGridView(int comId)
        {
            var allPayments = (from pay in db.PaymentInfos.Where(i => i.Company_Id == comId)
                               select new
                               {
                                   pay.Id,
                                   pay.Received_Amount,
                                   pay.Bill_No,
                                   pay.Given_Amout,
                                   pay.Raseed_No,
                                   pay.Remaining_Amount,
                                   pay.Pay_Date
                               }).ToList();
            dGridViewPaymentInfo.DataSource = allPayments;
            foreach (DataGridViewRow row in dGridViewPaymentInfo.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        private void ClearTextBoxes()
        {
            txtId.Clear();
            comboBoxCompany.SelectedIndex = -1;
            comboBoxPaymentType.SelectedIndex = -1;
            txtBillNo.Clear();
            txtAmount.Clear();
            dateTimePickerPayDate.Value = DateTime.Now.Date;
        }
        private void comboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        { 
            try
            {
                var companyId = Convert.ToInt32(comboBoxCompany.SelectedValue);
                var companyData = db.CompanyInfos.SingleOrDefault(i => i.Id == companyId);
                received = db.PaymentInfos.Where(i => i.Company_Id == companyId).Sum(s => s.Received_Amount);
                given = db.PaymentInfos.Where(i => i.Company_Id == companyId).Sum(s => s.Given_Amout);
                lblTotalAmountValue.Text = (received - given).ToString();
                lblCompanyNameValue.Text = companyData.Company_Name;
                FillDataGridView(companyId);
            }
            catch (Exception) { }
        }

        private void dGridViewPaymentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dGridViewPaymentInfo.CurrentRow.Cells[2].Value);
            var paymentToEdit = db.PaymentInfos.SingleOrDefault(p => p.Id == id);
            if (e.ColumnIndex == 0)
            {
                txtId.Text = paymentToEdit.Id.ToString();
                comboBoxCompany.SelectedValue = paymentToEdit.Company_Id;
                comboBoxPaymentType.SelectedIndex = paymentToEdit.Staus;
                
                if(paymentToEdit.Staus == 0)
                {
                    txtAmount.Text = paymentToEdit.Received_Amount.ToString();
                    txtBillNo.Text = paymentToEdit.Bill_No;
                }
                else
                {
                    txtAmount.Text = paymentToEdit.Given_Amout.ToString();
                    txtBillNo.Text = paymentToEdit.Raseed_No;
                }
                dateTimePickerPayDate.Value = paymentToEdit.Pay_Date;
            }
            else if(e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete record?",
                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    db.PaymentInfos.Remove(paymentToEdit);
                    db.SaveChanges();
                    FillDataGridView(paymentToEdit.Company_Id);
                    MessageBox.Show("Record Deleted");
                }
            }
        }

        private void txtSearchByBillNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var searchId = txtSearchByBillNo.Text;
                var allPayments = (from pay in db.PaymentInfos.Where(i => i.Bill_No == searchId || i.Raseed_No == searchId)
                                   select new
                                   {
                                       pay.Id,
                                       pay.Received_Amount,
                                       pay.Bill_No,
                                       pay.Given_Amout,
                                       pay.Raseed_No,
                                       pay.Remaining_Amount,
                                       pay.Pay_Date
                                   }).ToList();
                dGridViewPaymentInfo.DataSource = allPayments;
            }
            catch (Exception) { }
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            var compId = Convert.ToInt32(comboBoxCompany.SelectedValue);
            var totalAmount = received - given;
           if(txtBillNo.Text == "")
            {
                MessageBox.Show("Enter the Bill No.");
            }
            else
            {
                if (txtId.Text == "")
                {
                    if (comboBoxPaymentType.SelectedIndex == 0)
                    {
                        payment.Company_Id = Convert.ToInt32(comboBoxCompany.SelectedValue);
                        payment.Received_Amount = Convert.ToSingle(txtAmount.Text);
                        payment.Bill_No = txtBillNo.Text;
                        payment.Given_Amout = 0;
                        payment.Raseed_No = "0";
                        payment.Remaining_Amount = totalAmount + Convert.ToSingle(txtAmount.Text);
                        payment.Staus = comboBoxPaymentType.SelectedIndex;
                        payment.Pay_Date = dateTimePickerPayDate.Value.Date;
                    }
                    else
                    {
                        payment.Company_Id = Convert.ToInt32(comboBoxCompany.SelectedValue);
                        payment.Received_Amount = 0;
                        payment.Bill_No = "0";
                        payment.Given_Amout = Convert.ToSingle(txtAmount.Text);
                        payment.Raseed_No = txtBillNo.Text;
                        payment.Remaining_Amount = totalAmount - Convert.ToSingle(txtAmount.Text);
                        payment.Staus = comboBoxPaymentType.SelectedIndex;
                        payment.Pay_Date = dateTimePickerPayDate.Value.Date;
                    }
                    db.PaymentInfos.Add(payment);
                    db.SaveChanges();
                    FillDataGridView(compId);
                    MessageBox.Show("Saved Successfully.");
                }
                else
                {
                    var cId = Convert.ToInt64(txtId.Text);
                    var payRecord = db.PaymentInfos.Where(i => i.Id == cId).SingleOrDefault();
                    var payToDelete = payRecord.Received_Amount;
                    var payToAdd = payRecord.Given_Amout;
                    if (comboBoxPaymentType.SelectedIndex == 0)
                    {
                        payRecord.Company_Id = Convert.ToInt32(comboBoxCompany.SelectedValue);
                        payRecord.Received_Amount = Convert.ToSingle(txtAmount.Text);
                        payRecord.Bill_No = txtBillNo.Text;
                        payRecord.Given_Amout = 0;
                        payRecord.Raseed_No = "0";
                        payRecord.Remaining_Amount = totalAmount + Convert.ToSingle(txtAmount.Text) - payToDelete;
                        payRecord.Staus = comboBoxPaymentType.SelectedIndex;
                        payRecord.Pay_Date = dateTimePickerPayDate.Value.Date;
                    }
                    else
                    {
                        payRecord.Company_Id = Convert.ToInt32(comboBoxCompany.SelectedValue);
                        payRecord.Received_Amount = 0;
                        payRecord.Bill_No = "0";
                        payRecord.Given_Amout = Convert.ToSingle(txtAmount.Text);
                        payRecord.Raseed_No = txtBillNo.Text;
                        payRecord.Remaining_Amount = totalAmount - Convert.ToSingle(txtAmount.Text) + payToAdd;
                        payRecord.Staus = comboBoxPaymentType.SelectedIndex;
                        payRecord.Pay_Date = dateTimePickerPayDate.Value.Date;
                    }
                    db.Entry(payRecord).State = EntityState.Modified;
                    db.SaveChanges();
                    FillDataGridView(compId);
                    MessageBox.Show("Updated");
                }
                ClearTextBoxes();
            }
        }
    }
}
