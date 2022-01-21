namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeGenderTypeInPatientInfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatientInfoes", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatientInfoes", "Gender", c => c.Byte(nullable: false));
        }
    }
}
