namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFKUserInTableOrderSubscription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Subscriptions", "Users_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "User_Id");
            CreateIndex("dbo.Subscriptions", "Users_Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Subscriptions", "Users_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Orders", "UserId");
            DropColumn("dbo.Subscriptions", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subscriptions", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Subscriptions", "Users_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Subscriptions", new[] { "Users_Id" });
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropColumn("dbo.Subscriptions", "Users_Id");
            DropColumn("dbo.Orders", "User_Id");
        }
    }
}
