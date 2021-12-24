namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createSaleReturn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleReturns",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Product_Id = c.Long(nullable: false),
                        Unit_Price = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Total_Amount = c.Single(nullable: false),
                        Return_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stocks", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleReturns", "Product_Id", "dbo.Stocks");
            DropIndex("dbo.SaleReturns", new[] { "Product_Id" });
            DropTable("dbo.SaleReturns");
        }
    }
}
