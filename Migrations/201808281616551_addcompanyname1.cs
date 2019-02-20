namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcompanyname1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CompanyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CompanyName", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
