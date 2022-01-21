namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVisitDateToPatientInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientInfoes", "Visit_Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientInfoes", "Visit_Date");
        }
    }
}
