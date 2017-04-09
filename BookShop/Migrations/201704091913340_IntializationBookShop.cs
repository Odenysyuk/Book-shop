namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntializationBookShop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        PenName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.PricingOfPublication",
                c => new
                    {
                        Price = c.Double(nullable: false),
                        PublicationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PublicationId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        PublicationId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Pages = c.Int(nullable: false),
                        PublicationDate = c.DateTime(),
                        Genre = c.String(nullable: false, maxLength: 50),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PublicationId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Magazines",
                c => new
                    {
                        PublicationId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Pages = c.Int(nullable: false),
                        PublicationDate = c.DateTime(),
                        Categories = c.String(maxLength: 50),
                        Frequency = c.Int(nullable: false),
                        Company = c.String(maxLength: 20),
                        Printing = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PublicationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Magazines");
            DropTable("dbo.Books");
            DropTable("dbo.PricingOfPublication");
            DropTable("dbo.Authors");
        }
    }
}
