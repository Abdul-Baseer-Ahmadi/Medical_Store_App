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
            try
            {
                company.Company_Name = txtCompanyName.Text;
                company.Address = txtAddress.Text;
                company.Phone = txtPhone.Text;
                company.Province = txtProvince.Text;
                if(txtId.Text == "")
                {
                    db.CompanyInfos.Add(company);
                }
                else
                {
                    var updateCompany = new CompanyInfo()
                    {
                        Id = Convert.ToInt32(txtId.Text),
                        Company_Name = txtCompanyName.Text,
                        Address = txtAddress.Text,
                        Phone = txtPhone.Text,
                        Province = txtProvince.Text
                    };
                    db.Entry(updateCompany).State = EntityState.Modified;
                }
                db.SaveChanges();
                FillDataGridView();
                ClearTextBoxes();
                MessageBox.Show("Saved Successfully.");
            }
            catch (Exception) { }
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
