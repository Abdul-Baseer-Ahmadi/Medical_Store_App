namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeForeignKeyInPurchaseInfo : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PurchaseInfoes", new[] { "Invoice" });
            DropPrimaryKey("dbo.PurchaseInfoes");
            AddPrimaryKey("dbo.PurchaseInfoes", "Invoice");
            DropColumn("dbo.PurchaseInfoes", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseInfoes", "Id", c => c.Long(nullable: false, identity: true));
            DropPrimaryKey("dbo.PurchaseInfoes");
            AddPrimaryKey("dbo.PurchaseInfoes", "Id");
            CreateIndex("dbo.PurchaseInfoes", "Invoice", unique: true);
        }
    }
}
