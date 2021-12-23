namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTotalAmountToStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stocks", "Total_Amount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stocks", "Total_Amount");
        }
    }
}
