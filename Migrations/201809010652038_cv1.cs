namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cv1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ProfilePicture", c => c.Binary());
            AlterColumn("dbo.cvs", "Address", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.cvs", "Address", c => c.String(maxLength: 100));
            DropColumn("dbo.AspNetUsers", "ProfilePicture");
        }
    }
}
