namespace WebApplication56.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterAllViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountType = c.String(nullable: false),
                        FName = c.String(nullable: false, maxLength: 35),
                        MName = c.String(maxLength: 35),
                        LName = c.String(nullable: false, maxLength: 35),
                        IdentityNumber = c.String(nullable: false, maxLength: 13),
                        Gender = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisterAllViewModels");
        }
    }
}
