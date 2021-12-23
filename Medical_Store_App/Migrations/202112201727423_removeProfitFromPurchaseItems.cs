namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeProfitFromPurchaseItems : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PurchaseItems", "Profit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseItems", "Profit", c => c.Single(nullable: false));
        }
    }
}
