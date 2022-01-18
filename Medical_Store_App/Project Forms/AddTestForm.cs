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
    public partial class AddTestForm : Form
    {
        MedicalContext db;
        TestInfo test = new TestInfo();
        public AddTestForm()
        {
            InitializeComponent();
            db = new MedicalContext();
        }

        private void FillDataGridView()
        {
            var allTest = db.TestInfos.ToList();
            dGridViewTestInfo.DataSource = allTest;
        }
        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtTestName.Clear();
            txtPrice.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                test.Name = txtTestName.Text;
                test.Price = Convert.ToSingle(txtPrice.Text);
                db.TestInfos.Add(test);
            }
            else
            {
                var testId = Convert.ToInt32(txtId.Text);
                var editTest = db.TestInfos.SingleOrDefault(i => i.Id == testId);
                editTest.Name = txtTestName.Text;
                editTest.Price = Convert.ToSingle(txtPrice.Text);
                db.Entry(editTest).State = EntityState.Modified;
            }
            db.SaveChanges();
            FillDataGridView();
            MessageBox.Show("Record Saved Successfully.");
        }

        private void AddTestForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dGridViewTestInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dGridViewTestInfo.CurrentRow.Cells[2].Value);
            var recordToEdit = db.TestInfos.SingleOrDefault(i => i.Id == id);
            if(e.ColumnIndex == 0)
            {
                txtId.Text = recordToEdit.Id.ToString();
                txtTestName.Text = recordToEdit.Name;
                txtPrice.Text = recordToEdit.Price.ToString();
            }
            else if(e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you to delete?",
                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    db.TestInfos.Remove(recordToEdit);
                    db.SaveChanges();
                    FillDataGridView();
                    MessageBox.Show("Deleted Successfully.");
                }
            }
        }
    }
}
