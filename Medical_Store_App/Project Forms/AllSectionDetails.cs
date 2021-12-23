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
    public partial class AllSectionDetails : Form
    {
        public AllSectionDetails()
        {
            InitializeComponent();
        }

        private void btnPrintAnyReport_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerStartDate.Value.Date;
            var endDate = dateTimePickerEndDate.Value.Date;
            if(comboBoxReportType.SelectedIndex == 1)
            {
                StockReportForm stockReport = new StockReportForm();
                stockReport.ShowDialog();
            }
            else if(comboBoxReportType.SelectedIndex == 2)
            {
                
                SaleDayByDayReport daySaleReport = new SaleDayByDayReport(startDate, endDate);
                daySaleReport.ShowDialog();
            }
            else if(comboBoxReportType.SelectedIndex == 3)
            {
                MessageBox.Show("Purchase");
            }
        }
    }
}
