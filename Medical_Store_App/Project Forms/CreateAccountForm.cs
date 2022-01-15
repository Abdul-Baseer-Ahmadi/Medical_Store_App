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
    public partial class CreateAccountForm : Form
    {
        MedicalContext db = new MedicalContext();
        UserLogin user = new UserLogin();
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalStoreDataSet.UserLogins' table. You can move, or remove it, as needed.
            this.userLoginsTableAdapter.Fill(this.medicalStoreDataSet.UserLogins);
        }

        private void FillDataGridView()
        {
            this.userLoginsTableAdapter.Fill(this.medicalStoreDataSet.UserLogins);
        }
        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            comboRole.Text = "--Select Role--";
            btnCreateAccount.Text = "Create Account";
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtId.Text == "")
                {
                    user.Name = txtUserName.Text;
                    user.Password = txtPassword.Text;
                    user.Confirm_Pass = txtConfirmPass.Text;
                    user.Role = comboRole.Text;
                    db.UserLogins.Add(user);
                }
                else
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var userToUpdate = db.UserLogins.SingleOrDefault(i => i.Id == id);
                    userToUpdate.Name = txtUserName.Text;
                    userToUpdate.Password = txtPassword.Text;
                    userToUpdate.Confirm_Pass = txtConfirmPass.Text;
                    userToUpdate.Role = comboRole.Text;
                    db.Entry(userToUpdate).State = EntityState.Modified;
                }
                db.SaveChanges();
                FillDataGridView();
                MessageBox.Show("Record Saved Successfully.");
                ClearTextBoxes();
            }
            catch (Exception) { }
        }
        private void dGrdViewUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 5)
                {
                    var id = Convert.ToInt32(dGrdViewUserList.CurrentRow.Cells[0].Value);
                    var user = db.UserLogins.SingleOrDefault(r => r.Id == id);
                    txtId.Text = user.Id.ToString();
                    txtUserName.Text = user.Name.ToString();
                    txtPassword.Text = user.Password.ToString();
                    txtConfirmPass.Text = user.Confirm_Pass.ToString();
                    comboRole.Text = user.Role.ToString();
                    btnCreateAccount.Text = "Update";
                }
                else if(e.ColumnIndex == 6)
                {
                    int id = Convert.ToInt32(dGrdViewUserList.CurrentRow.Cells[0].Value);
                    var deleteUser = db.UserLogins.SingleOrDefault(c => c.Id == id);
                    if (DialogResult.Yes == MessageBox.Show("Do you want to delete " + deleteUser.Name +" record?",
                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        db.UserLogins.Remove(deleteUser);
                        db.SaveChanges();
                        FillDataGridView();
                        MessageBox.Show("Record Deleted");
                    }
                }
            }
            catch(Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
