using Medical_Store_App.Project_Db;
using Medical_Store_App.Reports;
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
    public partial class SoldProductReportForm : Form
    {
        MedicalContext db = new MedicalContext();
        SaleInfo sale = new SaleInfo();
        long saleId;
        public SoldProductReportForm(long id)
        {
            InitializeComponent();
            saleId = id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           var data = db.SoldProducts.Include("Sale_History").Include("Sold_Product").Where(i => i.Sale_Id == saleId).ToList();
            var data1 = (from c in db.SoldProducts.Where(i => i.Sale_Id== saleId) select new
             {
                c.Sale_Id,
                c.Sold_Product.Name,
                c.Sale_History.Total_Amount
                
            });
            SoldProductReport rpt = new SoldProductReport();
            
            rpt.SetDataSource(data);
            crystalReportViewerSoldProduct.ReportSource = rpt;
        }
    }
}
