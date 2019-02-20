namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cv4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cvs", "FileName", c => c.String(maxLength: 100));
            DropColumn("dbo.cvs", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.cvs", "FullName", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.cvs", "FileName");
        }
    }
}
