namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableGende : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GenreBooks",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Book_PublicationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Book_PublicationId })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_PublicationId, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Book_PublicationId);
            
            DropColumn("dbo.Books", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Genre", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.GenreBooks", "Book_PublicationId", "dbo.Books");
            DropForeignKey("dbo.GenreBooks", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.GenreBooks", new[] { "Book_PublicationId" });
            DropIndex("dbo.GenreBooks", new[] { "Genre_Id" });
            DropTable("dbo.GenreBooks");
            DropTable("dbo.Genres");
        }
    }
}
