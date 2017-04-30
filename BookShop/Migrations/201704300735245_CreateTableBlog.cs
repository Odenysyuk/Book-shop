namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableBlog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        SubscriptionsId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MagazineId = c.Int(nullable: false),
                        SubscriptionTypesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubscriptionsId)
                .ForeignKey("dbo.Magazines", t => t.MagazineId, cascadeDelete: true)
                .ForeignKey("dbo.SubscriptionTypes", t => t.SubscriptionTypesId, cascadeDelete: true)
                .Index(t => t.MagazineId)
                .Index(t => t.SubscriptionTypesId);
            
            CreateTable(
                "dbo.SubscriptionTypes",
                c => new
                    {
                        SubscriptionTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubscriptionTypeId);
            
            CreateTable(
                "dbo.BlogComments",
                c => new
                    {
                        BlogCommentId = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Comment = c.String(maxLength: 150),
                        UserId = c.Int(nullable: false),
                        OwnBlogId = c.Int(nullable: false),
                        Blog_BlogId = c.Int(),
                    })
                .PrimaryKey(t => t.BlogCommentId)
                .ForeignKey("dbo.BlogComments", t => t.OwnBlogId)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogId)
                .Index(t => t.OwnBlogId)
                .Index(t => t.Blog_BlogId);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Topic = c.String(nullable: false, maxLength: 50),
                        Body = c.String(nullable: false, maxLength: 50),
                        UserId = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BlogId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.BlogComments", "Blog_BlogId", "dbo.Blogs");
            DropForeignKey("dbo.BlogComments", "OwnBlogId", "dbo.BlogComments");
            DropForeignKey("dbo.Subscriptions", "SubscriptionTypesId", "dbo.SubscriptionTypes");
            DropForeignKey("dbo.Subscriptions", "MagazineId", "dbo.Magazines");
            DropIndex("dbo.Blogs", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.BlogComments", new[] { "Blog_BlogId" });
            DropIndex("dbo.BlogComments", new[] { "OwnBlogId" });
            DropIndex("dbo.Subscriptions", new[] { "SubscriptionTypesId" });
            DropIndex("dbo.Subscriptions", new[] { "MagazineId" });
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogComments");
            DropTable("dbo.SubscriptionTypes");
            DropTable("dbo.Subscriptions");
        }
    }
}
