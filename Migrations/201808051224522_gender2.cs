namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gender2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Gender", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Gender", c => c.Boolean(nullable: false));
        }
    }
}
