namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenderToPatientInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientInfoes", "Gender", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientInfoes", "Gender");
        }
    }
}
