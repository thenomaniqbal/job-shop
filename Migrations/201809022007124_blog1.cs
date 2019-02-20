namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blog1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogContent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogContent");
        }
    }
}
