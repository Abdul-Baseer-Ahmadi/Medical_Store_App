namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createSaleInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleInfoes",
                c => new
                    {
                        Sale_Id = c.Long(nullable: false),
                        Sale_Date = c.DateTime(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sale_Id)
                .ForeignKey("dbo.UserLogins", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleInfoes", "User_Id", "dbo.UserLogins");
            DropIndex("dbo.SaleInfoes", new[] { "User_Id" });
            DropTable("dbo.SaleInfoes");
        }
    }
}
