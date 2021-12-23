namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPurchaseItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseItems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Purchase_Id = c.Long(nullable: false),
                        Product_Id = c.Long(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Purchase_Price = c.Single(nullable: false),
                        Profit = c.Single(nullable: false),
                        Sale_Price = c.Single(nullable: false),
                        Total_Amount = c.Single(nullable: false),
                        Mfg_Date = c.DateTime(nullable: false),
                        Expiry_Date = c.DateTime(nullable: false),
                        Purchase_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stocks", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseInfoes", t => t.Purchase_Id, cascadeDelete: true)
                .Index(t => t.Purchase_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseItems", "Purchase_Id", "dbo.PurchaseInfoes");
            DropForeignKey("dbo.PurchaseItems", "Product_Id", "dbo.Stocks");
            DropIndex("dbo.PurchaseItems", new[] { "Product_Id" });
            DropIndex("dbo.PurchaseItems", new[] { "Purchase_Id" });
            DropTable("dbo.PurchaseItems");
        }
    }
}
