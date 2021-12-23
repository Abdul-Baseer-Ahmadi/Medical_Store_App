namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPaidAmountToSaleInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleInfoes", "Paid_Amount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SaleInfoes", "Paid_Amount");
        }
    }
}
