namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cv3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.cvs");
            DropColumn("dbo.cvs", "CvId");
            AddColumn("dbo.cvs", "CId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.cvs", "CId");
         
        }
        
        public override void Down()
        {
            AddColumn("dbo.cvs", "CvId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.cvs");
            DropColumn("dbo.cvs", "CId");
            AddPrimaryKey("dbo.cvs", "CvId");
        }
    }
}
