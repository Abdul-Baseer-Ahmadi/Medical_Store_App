namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createLabPayment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LabPayments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Patient_Id = c.Long(nullable: false),
                        Test_Id = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Discount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PatientInfoes", t => t.Patient_Id, cascadeDelete: true)
                .ForeignKey("dbo.TestInfoes", t => t.Test_Id, cascadeDelete: true)
                .Index(t => t.Patient_Id)
                .Index(t => t.Test_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LabPayments", "Test_Id", "dbo.TestInfoes");
            DropForeignKey("dbo.LabPayments", "Patient_Id", "dbo.PatientInfoes");
            DropIndex("dbo.LabPayments", new[] { "Test_Id" });
            DropIndex("dbo.LabPayments", new[] { "Patient_Id" });
            DropTable("dbo.LabPayments");
        }
    }
}
