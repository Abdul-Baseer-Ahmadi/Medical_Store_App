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
            var allSoldProducts = db.SoldProducts.Include("Sold_Product").Where(i => i.Sale_Date >= startDate && i.Sale_Date <= endDate).ToList();
        
            SaleReport saleRpt = new SaleReport();
            saleRpt.SetDataSource(allSoldProducts);
            crystalReportViewerSaleDayByDay.ReportSource = saleRpt;
        }
    }
}