namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVisitDateToLabPayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LabPayments", "Visit_Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LabPayments", "Visit_Date");
        }
    }
}
