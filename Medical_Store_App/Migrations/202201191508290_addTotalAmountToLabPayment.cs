namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTotalAmountToLabPayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LabPayments", "Total_Amount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LabPayments", "Total_Amount");
        }
    }
}
