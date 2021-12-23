namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeForeignKeyInPurchaseInfo1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PurchaseInfoes");
            AddColumn("dbo.PurchaseInfoes", "Purchase_Id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.PurchaseInfoes", "Purchase_Id");
            CreateIndex("dbo.PurchaseInfoes", "Invoice", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.PurchaseInfoes", new[] { "Invoice" });
            DropPrimaryKey("dbo.PurchaseInfoes");
            DropColumn("dbo.PurchaseInfoes", "Purchase_Id");
            AddPrimaryKey("dbo.PurchaseInfoes", "Invoice");
        }
    }
}
