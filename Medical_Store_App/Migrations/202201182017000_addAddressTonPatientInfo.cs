namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAddressTonPatientInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientInfoes", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientInfoes", "Address");
        }
    }
}
