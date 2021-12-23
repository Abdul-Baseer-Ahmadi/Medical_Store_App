namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInvoiceNoToPurchaseItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseItems", "Invoice_No", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseItems", "Invoice_No");
        }
    }
}
