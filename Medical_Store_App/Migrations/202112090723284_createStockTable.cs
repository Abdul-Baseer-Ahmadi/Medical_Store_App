namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createStockTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(maxLength: 450),
                        Name = c.String(),
                        Type = c.String(),
                        Purchase_Price = c.Single(nullable: false),
                        Profit = c.Single(nullable: false),
                        Sale_Price = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Mfg_Date = c.DateTime(nullable: false),
                        Exp_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Stocks", new[] { "Code" });
            DropTable("dbo.Stocks");
        }
    }
}
