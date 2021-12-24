namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createReturnInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReturnInfoes",
                c => new
                    {
                        Return_Id = c.Long(nullable: false),
                        Total_items = c.Int(nullable: false),
                        Total_Amount = c.Single(nullable: false),
                        Return_Date = c.DateTime(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Return_Id)
                .ForeignKey("dbo.UserLogins", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.SaleReturns", "Return_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.SaleReturns", "Return_Id");
            AddForeignKey("dbo.SaleReturns", "Return_Id", "dbo.ReturnInfoes", "Return_Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleReturns", "Return_Id", "dbo.ReturnInfoes");
            DropForeignKey("dbo.ReturnInfoes", "User_Id", "dbo.UserLogins");
            DropIndex("dbo.ReturnInfoes", new[] { "User_Id" });
            DropIndex("dbo.SaleReturns", new[] { "Return_Id" });
            DropColumn("dbo.SaleReturns", "Return_Id");
            DropTable("dbo.ReturnInfoes");
        }
    }
}
