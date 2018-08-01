namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRequiredAttribute : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "Customer_Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Rentals", "Customer_Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
