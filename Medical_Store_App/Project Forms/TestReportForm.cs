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
    public partial class TestReportForm : Form
    {
        MedicalContext db;
        LabPayment payment = new LabPayment();
        long patTestId;
        DateTime testDate;
        public TestReportForm(long patId, DateTime date)
        {
            InitializeComponent();
            db = new MedicalContext();
            patTestId = patId;
            testDate = date;
        }

        private void TestReportForm_Load(object sender, EventArgs e)
        {
           var tests = db.LabPayments.Include("Patient_Info").Include("Test_Info")
                .Where(i => i.Patient_Id == patTestId && i.Visit_Date == testDate).ToList();
            TestReport testRpt = new TestReport();
            testRpt.SetDataSource(tests);
            crystalReportViewerTestReport.ReportSource = testRpt;
        }
    }
}
