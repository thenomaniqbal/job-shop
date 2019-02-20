namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myviewmodel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FileUploadDBModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        File = c.Binary(),
                        FullName = c.String(),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FileUploadDBModels");
        }
    }
}
