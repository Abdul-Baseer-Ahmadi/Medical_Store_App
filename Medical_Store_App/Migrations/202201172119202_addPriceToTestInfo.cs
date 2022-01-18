namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPriceToTestInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestInfoes", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TestInfoes", "Price");
        }
    }
}
