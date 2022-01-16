namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPaymentInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentInfoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Company_Id = c.Int(nullable: false),
                        Received_Amount = c.Single(nullable: false),
                        Bill_No = c.String(),
                        Given_Amout = c.Single(nullable: false),
                        Raseed_No = c.String(),
                        Remaining_Amount = c.Single(nullable: false),
                        Pay_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompanyInfoes", t => t.Company_Id, cascadeDelete: true)
                .Index(t => t.Company_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentInfoes", "Company_Id", "dbo.CompanyInfoes");
            DropIndex("dbo.PaymentInfoes", new[] { "Company_Id" });
            DropTable("dbo.PaymentInfoes");
        }
    }
}
