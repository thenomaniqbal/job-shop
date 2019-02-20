namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CatTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        BlogTitle = c.String(),
                        BlogerName = c.String(),
                        BlogerEmailId = c.String(),
                        BlogImage = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        blogcategoryId = c.Int(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.BlogCategories", t => t.blogcategoryId, cascadeDelete: true)
                .Index(t => t.blogcategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "blogcategoryId", "dbo.BlogCategories");
            DropIndex("dbo.Blogs", new[] { "blogcategoryId" });
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogCategories");
        }
    }
}
