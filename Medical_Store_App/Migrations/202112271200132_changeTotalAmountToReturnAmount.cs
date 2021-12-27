namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTotalAmountToReturnAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReturnInfoes", "Return_Amount", c => c.Single(nullable: false));
            DropColumn("dbo.ReturnInfoes", "Total_Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReturnInfoes", "Total_Amount", c => c.Single(nullable: false));
            DropColumn("dbo.ReturnInfoes", "Return_Amount");
        }
    }
}
