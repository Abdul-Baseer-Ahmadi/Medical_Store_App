namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSaleInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleInfoes", "Total_Amount", c => c.Single(nullable: false));
            AddColumn("dbo.SaleInfoes", "Discount", c => c.Single(nullable: false));
            AddColumn("dbo.SaleInfoes", "Total_Items", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SaleInfoes", "Total_Items");
            DropColumn("dbo.SaleInfoes", "Discount");
            DropColumn("dbo.SaleInfoes", "Total_Amount");
        }
    }
}
