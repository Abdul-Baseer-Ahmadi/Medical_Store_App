﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class MedicalContext : DbContext
    {
        public DbSet<UserLogin> UserLogins { get; set; }
        public IDbSet<Stock> Stocks { get; set; }
        public DbSet<SaleInfo> SaleInfos { get; set; }
        public DbSet<SoldProduct> SoldProducts { get; set; }
        public DbSet<PurchaseInfo> PurchaseInfos { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<SaleReturn> SaleReturns { get; set; }
        public DbSet<ReturnInfo> ReturnInfos { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
        public DbSet<TestInfo> TestInfos { get; set; }
        public DbSet<PatientInfo> PatientInfos { get; set; }
        public DbSet<LabPayment> LabPayments { get; set; }
    }
}
