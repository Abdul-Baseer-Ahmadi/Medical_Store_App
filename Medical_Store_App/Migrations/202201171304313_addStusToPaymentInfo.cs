namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStusToPaymentInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentInfoes", "Staus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PaymentInfoes", "Staus");
        }
    }
}
