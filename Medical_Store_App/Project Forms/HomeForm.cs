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
    public partial class HomeForm : Form
    {
        int userID;
        public HomeForm(string userName, int userId)
        {
            InitializeComponent();
            timer1.Start();
            lblUserName.Text = "User Name : " + userName;
            userID = userId;
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm stock = new StockForm();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            stock.MdiParent = this;
            stock.Dock = DockStyle.Fill;
            stock.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasesForm purchase= new PurchasesForm(userID);
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            purchase.MdiParent = this;
            purchase.Dock = DockStyle.Fill;
            purchase.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            payment.MdiParent = this;
            payment.Dock = DockStyle.Fill;
            payment.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.lblDate.Text = "Date : "+ date.Date.ToString("dd/MM/yyyy");
            lblTime.Text = "Time : " + date.ToLongTimeString();
        }

        private void Home_Load(object sender, EventArgs e)
        {
          
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm(userID);
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            sale.MdiParent = this;
            sale.Dock = DockStyle.Fill;
            sale.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSectionDetails allSectionDetails = new AllSectionDetails(); ;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            allSectionDetails.MdiParent = this;
            allSectionDetails.Dock = DockStyle.Fill;
            allSectionDetails.Show();
        }

        private void saleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnSaleForm returnSaleForm = new ReturnSaleForm(userID); ;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            returnSaleForm.MdiParent = this;
            returnSaleForm.Dock = DockStyle.Fill;
            returnSaleForm.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccountForm accountForm = new CreateAccountForm();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            accountForm.MdiParent = this;
            accountForm.Dock = DockStyle.Fill;
            accountForm.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            companyForm.MdiParent = this;
            companyForm.Dock = DockStyle.Fill;
            companyForm.Show();
        }

        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTestForm testForm = new AddTestForm();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            testForm.MdiParent = this;
            testForm.Dock = DockStyle.Fill;
            testForm.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PatientLabForm labForm = new PatientLabForm();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            labForm.MdiParent = this;
            labForm.Dock = DockStyle.Fill;
            labForm.Show();
        }
    }
}
