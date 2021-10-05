namespace WebApplication56.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PayPalModels",
                c => new
                    {
                        Pay = c.Int(nullable: false, identity: true),
                        cmd = c.String(),
                        business = c.String(),
                        no_shipping = c.String(),
                        _return = c.String(name: "return"),
                        cancel_return = c.String(),
                        notify_url = c.String(),
                        currency_code = c.String(),
                        item_name = c.String(),
                        item_quantity = c.String(),
                        amount = c.String(),
                        actionURL = c.String(),
                    })
                .PrimaryKey(t => t.Pay);
            
            DropTable("dbo.Transactions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TRANSACTION_ID = c.Guid(nullable: false, identity: true),
                        DATE = c.DateTime(),
                        PAY_REQUEST_ID = c.String(),
                        AMOUNT = c.Int(nullable: false),
                        REFERENCE = c.String(),
                        TRANSACTION_STATUS = c.String(),
                        RESULT_CODE = c.Int(nullable: false),
                        RESULT_DESC = c.String(),
                        CUSTOMER_EMAIL_ADDRESS = c.String(),
                    })
                .PrimaryKey(t => t.TRANSACTION_ID);
            
            DropTable("dbo.PayPalModels");
        }
    }
}
