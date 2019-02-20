namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cv2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.cvs");
            DropColumn("dbo.cvs", "CId");
            AddColumn("dbo.cvs", "CvId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EditProfileViewModels", "FullName", c => c.String(nullable: false));
            AddPrimaryKey("dbo.cvs", "CvId");
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.cvs", "CId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.cvs");
            DropColumn("dbo.EditProfileViewModels", "FullName");
            DropColumn("dbo.cvs", "CvId");
            AddPrimaryKey("dbo.cvs", "CId");
        }
    }
}
