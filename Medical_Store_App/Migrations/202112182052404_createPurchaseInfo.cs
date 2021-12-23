namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPurchaseInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseInfoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Invoice = c.Long(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Purchase_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserLogins", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Invoice, unique: true)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseInfoes", "User_Id", "dbo.UserLogins");
            DropIndex("dbo.PurchaseInfoes", new[] { "User_Id" });
            DropIndex("dbo.PurchaseInfoes", new[] { "Invoice" });
            DropTable("dbo.PurchaseInfoes");
        }
    }
}
