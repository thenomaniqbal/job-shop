namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplyForJobs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        ApplyDate = c.DateTime(nullable: false),
                        jobId = c.Int(nullable: false),
                        userId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Jobs", t => t.jobId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.userId)
                .Index(t => t.jobId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        jobTitle = c.String(),
                        jobContent = c.String(),
                        jobImage = c.String(),
                        categoryId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.categoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.categoryId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        categoryName = c.String(nullable: false),
                        categoryDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.EditProfileViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        CurrentPassword = c.String(nullable: false, maxLength: 100),
                        NewPassword = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplyForJobs", "userId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplyForJobs", "jobId", "dbo.Jobs");
            DropForeignKey("dbo.Jobs", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Jobs", "categoryId", "dbo.Categories");
            DropIndex("dbo.Jobs", new[] { "UserId" });
            DropIndex("dbo.Jobs", new[] { "categoryId" });
            DropIndex("dbo.ApplyForJobs", new[] { "userId" });
            DropIndex("dbo.ApplyForJobs", new[] { "jobId" });
            DropTable("dbo.EditProfileViewModels");
            DropTable("dbo.Categories");
            DropTable("dbo.Jobs");
            DropTable("dbo.ApplyForJobs");
        }
    }
}
