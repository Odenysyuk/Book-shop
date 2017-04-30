namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFKUserInBlog : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Blogs", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.Blogs", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
            DropColumn("dbo.Blogs", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "UserId", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Blogs", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Blogs", name: "User_Id", newName: "ApplicationUser_Id");
        }
    }
}
