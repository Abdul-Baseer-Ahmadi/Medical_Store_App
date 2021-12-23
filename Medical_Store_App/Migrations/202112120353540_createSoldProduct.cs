namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createSoldProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SoldProducts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Sale_Id = c.Long(nullable: false),
                        Product_Id = c.Long(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Total_Amount = c.Single(nullable: false),
                        Profit = c.Single(nullable: false),
                        Sale_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SaleInfoes", t => t.Sale_Id, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Sale_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoldProducts", "Product_Id", "dbo.Stocks");
            DropForeignKey("dbo.SoldProducts", "Sale_Id", "dbo.SaleInfoes");
            DropIndex("dbo.SoldProducts", new[] { "Product_Id" });
            DropIndex("dbo.SoldProducts", new[] { "Sale_Id" });
            DropTable("dbo.SoldProducts");
        }
    }
}
