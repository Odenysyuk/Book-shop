namespace BookShop.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddPricing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pricings",
                c => new
                    {
                        PricingId = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PricingId);
            
            AddColumn("dbo.Books", "PricingId", c => c.Int(nullable: false));
            AddColumn("dbo.Magazines", "PricingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "PricingId");
            CreateIndex("dbo.Magazines", "PricingId");
            AddForeignKey("dbo.Books", "PricingId", "dbo.Pricings", "PricingId");
            AddForeignKey("dbo.Magazines", "PricingId", "dbo.Pricings", "PricingId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Magazines", "PricingId", "dbo.Pricings");
            DropForeignKey("dbo.Books", "PricingId", "dbo.Pricings");
            DropIndex("dbo.Magazines", new[] { "PricingId" });
            DropIndex("dbo.Books", new[] { "PricingId" });
            DropColumn("dbo.Magazines", "PricingId");
            DropColumn("dbo.Books", "PricingId");
            DropTable("dbo.Pricings");
        }
    }
}
