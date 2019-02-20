namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcompanyname2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CompanyName", c => c.String(maxLength: 100));
            AlterColumn("dbo.AspNetUsers", "CompanyId", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CompanyId", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.AspNetUsers", "CompanyName");
        }
    }
}
