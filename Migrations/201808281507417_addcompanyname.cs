namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcompanyname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CompanyName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CompanyName");
        }
    }
}
