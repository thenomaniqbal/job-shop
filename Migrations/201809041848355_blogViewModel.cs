namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogViewModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        jobId = c.Int(nullable: false),
                        blog_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Blogs", t => t.blog_id)
                .Index(t => t.blog_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogViewModels", "blog_id", "dbo.Blogs");
            DropIndex("dbo.BlogViewModels", new[] { "blog_id" });
            DropTable("dbo.BlogViewModels");
        }
    }
}
