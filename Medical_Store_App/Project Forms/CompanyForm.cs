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
    public partial class CompanyForm : Form
    {
        MedicalContext db;
        CompanyInfo company = new CompanyInfo();
        public CompanyForm()
        {
            InitializeComponent();
            db = new MedicalContext();
        }
        private void FillDataGridView()
        {
            var allCompany = (from comp in db.CompanyInfos select new { 
            comp.Id,
            comp.Company_Name,
            comp.Province,
            comp.Address,
            comp.Phone
            }).ToList();
            dGridViewCompanyInfo.DataSource = allCompany;
        }
        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtCompanyName.Clear();
            txtProvince.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //try
            {
                if(txtId.Text == "")
                {
                    company.Company_Name = txtCompanyName.Text;
                    company.Address = txtAddress.Text;
                    company.Phone = txtPhone.Text;
                    company.Province = txtProvince.Text;
                    db.CompanyInfos.Add(company);
                }
                else
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var updateCompany = db.CompanyInfos.Where(i => i.Id == id).SingleOrDefault();
                    updateCompany.Company_Name = txtCompanyName.Text;
                    updateCompany.Province = txtProvince.Text;
                    updateCompany.Address = txtAddress.Text;
                    updateCompany.Phone = txtPhone.Text;
                    db.Entry(updateCompany).State = EntityState.Modified;
                }
                db.SaveChanges();
                FillDataGridView();
                ClearTextBoxes();
                MessageBox.Show("Saved Successfully.");
            }
            //catch (Exception) { }
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dGridViewCompanyInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dGridViewCompanyInfo.CurrentRow.Cells[2].Value);
            var company = db.CompanyInfos.SingleOrDefault(c => c.Id == id);
            if (e.ColumnIndex == 0)
            {
                txtId.Text = company.Id.ToString();
                txtCompanyName.Text = company.Company_Name;
                txtProvince.Text = company.Province;
                txtAddress.Text = company.Address;
                txtPhone.Text = company.Phone;
                btnCreateAccount.Text = "Update";
            }
            else if(e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete " + company.Company_Name + " record?",
                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    db.CompanyInfos.Remove(company);
                    db.SaveChanges();
                    FillDataGridView();
                    MessageBox.Show("Record Deleted");
                }
            }
        }
    }
}
