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
    public partial class StockReportForm : Form
    {
        MedicalContext db;
        public StockReportForm()
        {
            InitializeComponent();
            db = new MedicalContext();
        }

        private void StockReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                var allStockItems = db.Stocks.ToList();
                StockHistoryReport stockRpt = new StockHistoryReport();
                stockRpt.SetDataSource(allStockItems);
                crystalReportViewerStockHistory.ReportSource = stockRpt;
            }
            catch (Exception) { }
                
        }
    }
}
