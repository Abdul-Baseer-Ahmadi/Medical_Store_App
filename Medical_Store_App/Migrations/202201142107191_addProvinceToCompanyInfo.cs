namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProvinceToCompanyInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyInfoes", "Province", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CompanyInfoes", "Province");
        }
    }
}
