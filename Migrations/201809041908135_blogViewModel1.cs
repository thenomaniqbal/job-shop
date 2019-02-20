namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogViewModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BlogViewModels", "blog_id", "dbo.Blogs");
            DropIndex("dbo.BlogViewModels", new[] { "blog_id" });
            RenameColumn(table: "dbo.BlogViewModels", name: "blog_id", newName: "blogId");
            AlterColumn("dbo.BlogViewModels", "blogId", c => c.Int(nullable: false));
            CreateIndex("dbo.BlogViewModels", "blogId");
            AddForeignKey("dbo.BlogViewModels", "blogId", "dbo.Blogs", "id", cascadeDelete: true);
            DropColumn("dbo.BlogViewModels", "jobId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogViewModels", "jobId", c => c.Int(nullable: false));
            DropForeignKey("dbo.BlogViewModels", "blogId", "dbo.Blogs");
            DropIndex("dbo.BlogViewModels", new[] { "blogId" });
            AlterColumn("dbo.BlogViewModels", "blogId", c => c.Int());
            RenameColumn(table: "dbo.BlogViewModels", name: "blogId", newName: "blog_id");
            CreateIndex("dbo.BlogViewModels", "blog_id");
            AddForeignKey("dbo.BlogViewModels", "blog_id", "dbo.Blogs", "id");
        }
    }
}
