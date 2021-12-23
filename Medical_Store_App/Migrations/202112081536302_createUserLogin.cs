namespace Medical_Store_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUserLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Confirm_Pass = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("insert into UserLogins values ('Baseer', '12345', '12345', 'Admin')");   
        }
       
        public override void Down()
        {
            DropTable("dbo.UserLogins");
        }
    }
}
