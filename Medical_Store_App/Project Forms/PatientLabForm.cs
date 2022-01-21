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
    public partial class PatientLabForm : Form
    {
        MedicalContext db;
        PatientInfo patient = new PatientInfo();
        LabPayment labPayment = new LabPayment();
        float totalAmount = 0;
        int discount = 0;
        public PatientLabForm()
        {
            InitializeComponent();
            db = new MedicalContext();
        }
        private void FillPatientDataGridView()
        {
            var allPatients = (from patients in db.PatientInfos
                               select new
                               {
                                   patients.Id,
                                   patients.Name,
                                   patients.Gender,
                                   patients.Address,
                                   patients.Visit_Date
                               }).ToList();
            dGridViewPatientInfo.DataSource = allPatients;
        }
        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                patient.Name = txtPatientName.Text;
                patient.Gender = txtGender.Text;
                patient.Address = txtPatAddress.Text;
                patient.Visit_Date = dateTimePickerVisitDate.Value.Date;
                db.PatientInfos.Add(patient);
                db.SaveChanges();
                txtTestPatName.Text = patient.Name;
                txtPatientId.Text = patient.Id.ToString();
                lblPatientNameValue.Text = patient.Name;
            }
            else
            {
                var id = Convert.ToInt64(txtId.Text);
                var recordToEdit = db.PatientInfos.SingleOrDefault(p => p.Id == id);
                recordToEdit.Name = txtPatientName.Text;
                recordToEdit.Gender = txtGender.Text;
                recordToEdit.Address = txtPatAddress.Text;
                recordToEdit.Visit_Date = dateTimePickerVisitDate.Value.Date;
                db.Entry(recordToEdit).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                txtTestPatName.Text = recordToEdit.Name;
                txtPatientId.Text = recordToEdit.Id.ToString();
                lblPatientNameValue.Text = recordToEdit.Name;
            }
            comboBoxPatientTest.Focus();
            FillPatientDataGridView();
            ClearPatientTextBoxes();
            MessageBox.Show("Saved Successfully.");
        }

        private void PatientLabForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet5.TestInfoes' table. You can move, or remove it, as needed.
            this.testInfoesTableAdapter.Fill(this.medicalStoreDataSet5.TestInfoes);
            FillPatientDataGridView();
            
        }
        private void ClearPatientTextBoxes()
        {
            txtId.Clear();
            txtPatientName.Clear();
            txtGender.Clear();
            txtPatAddress.Clear();
        }
        private void ClearPateintTestTextBoxes()
        {
            txtTestId.Clear();
            comboBoxPatientTest.SelectedIndex = 0;
            txtPrice.Clear();
            txtDiscount.Text = "0";
            dateTimePickerTestDate.Value = DateTime.Now.Date;
        }
        private void FillPatientTestDataGridView(long id, DateTime date)
        {
            var allTestOfPatient = (from patTest in db.LabPayments.Where(l => l.Patient_Id == id && l.Visit_Date == date)
                                    select new
                                    {
                                        patTest.Id,
                                        patTest.Test_Info.Name,
                                        patTest.Price,
                                        patTest.Discount,
                                        patTest.Total_Amount,
                                        patTest.Visit_Date
                                    }).ToList();
            dGridViewPatTestInfo.DataSource = allTestOfPatient;
        }
        private void TestPaymentCalculation(long patId, DateTime date)
        {
            totalAmount = db.LabPayments.Where(i => i.Patient_Id == patId && i.Visit_Date == date)
               .Select(t => t.Price).DefaultIfEmpty(0).Sum();
            discount = db.LabPayments.Where(i => i.Patient_Id == patId && i.Visit_Date == date)
                .Select(t => t.Discount).DefaultIfEmpty(0).Sum();
            lblTotalAmountValue.Text = totalAmount.ToString();
            lblDiscountValue.Text = discount.ToString();
            lblPayableAmountValue.Text = (totalAmount - discount).ToString();
        }
        private void dGridViewPatientInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var patientId = Convert.ToInt64(dGridViewPatientInfo.CurrentRow.Cells[3].Value);
            var patientRecord = db.PatientInfos.SingleOrDefault(p => p.Id == patientId);
            if (e.ColumnIndex == 0)
            {
                txtId.Text = patientRecord.Id.ToString();
                txtPatientName.Text = patientRecord.Name;
                txtGender.Text = patientRecord.Gender;
                txtPatAddress.Text = patientRecord.Address;
                dateTimePickerVisitDate.Value = patientRecord.Visit_Date;
            }
            else if (e.ColumnIndex == 1)
            {
                txtPatientId.Text = patientRecord.Id.ToString();
                txtTestPatName.Text = patientRecord.Name;
                comboBoxPatientTest.Focus();
                FillPatientTestDataGridView(patientId, dateTimePickerTestDate.Value.Date);
                TestPaymentCalculation(patientId, dateTimePickerTestDate.Value.Date);
            }
            else if (e.ColumnIndex == 2)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to Delete" + patientRecord.Name + " ?",
                    "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    db.PatientInfos.Remove(patientRecord);
                    db.SaveChanges();
                    MessageBox.Show("Deleted Successfull.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patId = Convert.ToInt64(txtPatientId.Text);
            var date = dateTimePickerTestDate.Value.Date;
            if (txtTestId.Text == "")
            {
                labPayment.Patient_Id = Convert.ToInt64(txtPatientId.Text);
                labPayment.Test_Id = Convert.ToInt32(comboBoxPatientTest.SelectedValue);
                labPayment.Price = Convert.ToSingle(txtPrice.Text);
                labPayment.Discount = Convert.ToInt32(txtDiscount.Text);
                labPayment.Total_Amount = Convert.ToSingle(txtPrice.Text) - Convert.ToInt32(txtDiscount.Text);
                labPayment.Visit_Date = dateTimePickerTestDate.Value.Date;
                db.LabPayments.Add(labPayment);
            }
            else
            {
                var testEditId = Convert.ToInt64(txtTestId.Text);
                var testToEdit = db.LabPayments.SingleOrDefault(l => l.Id == testEditId);
                testToEdit.Patient_Id = Convert.ToInt64(txtPatientId.Text);
                testToEdit.Test_Id = Convert.ToInt32(comboBoxPatientTest.SelectedValue);
                testToEdit.Price = Convert.ToSingle(txtPrice.Text);
                testToEdit.Discount = Convert.ToInt32(txtDiscount.Text);
                testToEdit.Total_Amount = Convert.ToSingle(txtPrice.Text) - Convert.ToInt32(txtDiscount.Text);
                testToEdit.Visit_Date = dateTimePickerTestDate.Value.Date;
                db.Entry(testToEdit).State = EntityState.Modified;
            }
            db.SaveChanges();
            FillPatientTestDataGridView(patId,date);
            MessageBox.Show("Saved Successfully.");
            TestPaymentCalculation(patId, date);
            ClearPateintTestTextBoxes();
        }

        private void comboBoxPatientTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var testId = Convert.ToInt32(comboBoxPatientTest.SelectedValue);
                var testInfo = db.TestInfos.Where(t => t.Id == testId).SingleOrDefault();
                if (testInfo != null)
                {
                    txtPrice.Text = testInfo.Price.ToString();
                }

            }
            catch (Exception) { }
        }

        private void dGridViewPatTestInfo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var date = dateTimePickerTestDate.Value.Date;
            var testId = Convert.ToInt64(dGridViewPatTestInfo.CurrentRow.Cells[2].Value);
            var testInfo = db.LabPayments.SingleOrDefault(t => t.Id == testId);
            if (e.ColumnIndex == 0)
            {
                txtTestId.Text = testInfo.Id.ToString();
                txtPatientId.Text = testInfo.Patient_Id.ToString();
                txtTestPatName.Text = testInfo.Patient_Info.Name;
                comboBoxPatientTest.SelectedValue = testInfo.Test_Id;
                txtPrice.Text = testInfo.Price.ToString();
                txtDiscount.Text = testInfo.Discount.ToString();
                dateTimePickerTestDate.Value = testInfo.Visit_Date;
            }
            if (e.ColumnIndex == 1)
            {
               if(DialogResult.Yes == MessageBox.Show("Do you want to delete?",
                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    db.LabPayments.Remove(testInfo);
                    db.SaveChanges();
                    MessageBox.Show("Deleted Successfully.");
                }
            }
            FillPatientTestDataGridView(testInfo.Patient_Id, date);
            TestPaymentCalculation(testInfo.Patient_Id, date);
        }
    }
}
