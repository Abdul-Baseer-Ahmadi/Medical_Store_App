﻿using Medical_Store_App.Project_Db;
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
    public partial class SaleDayByDayReport : Form
    {
        MedicalContext db;
        DateTime startDate, endDate;
        public SaleDayByDayReport(DateTime sDate, DateTime eDate)
        {
            InitializeComponent();
            db = new MedicalContext();
            startDate = sDate;
            endDate = eDate;
        }

        private void SaleDayByDayReport_Load(object sender, EventArgs e)
        {
            try
            {
                var allSoldProducts = db.SoldProducts.Where(i => i.Sale_Date >= startDate && i.Sale_Date <= endDate).ToList();
                var discount = db.SaleInfos.Where(i => i.Sale_Date >= startDate && i.Sale_Date <= endDate).Select(i => i.Discount).DefaultIfEmpty(0).Sum();
                var saleReturn = db.ReturnInfos.Where(i => i.Return_Date >= startDate && i.Return_Date <= endDate).Select(r => r.Return_Amount).DefaultIfEmpty(0).Sum();


                SaleReport saleRpt = new SaleReport();
                saleRpt.SetDataSource(allSoldProducts);
                saleRpt.SetParameterValue("Discount", discount);
                saleRpt.SetParameterValue("SaleReturn", saleReturn);

                crystalReportViewerSaleDayByDay.ReportSource = saleRpt;
            }
            catch (Exception) { }
        }
    }
}
