using Medical_Store_App.Project_Db;
using Medical_Store_App.Project_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_App
{
    public partial class Login : Form
    {
        MedicalContext db = new MedicalContext();
        public Login()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginData = db.UserLogins.Where(a => a.Name == txtName.Text && a.Password == txtPassword.Text).SingleOrDefault();
            //var loginData = db.UserLogins.SingleOrDefault(a => a.Name == txtName.Text && a.Password == txtPassword.Text);
            if (loginData != null)
            {
                this.Hide();
                HomeForm home = new HomeForm(txtName.Text, loginData.Id);
                home.ShowDialog(); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password.");
            }

        }
    }
}
