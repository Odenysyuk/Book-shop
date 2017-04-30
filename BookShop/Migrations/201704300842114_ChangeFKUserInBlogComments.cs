namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFKUserInBlogComments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogComments", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.BlogComments", "User_Id");
            AddForeignKey("dbo.BlogComments", "User_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.BlogComments", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogComments", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.BlogComments", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.BlogComments", new[] { "User_Id" });
            DropColumn("dbo.BlogComments", "User_Id");
        }
    }
}
