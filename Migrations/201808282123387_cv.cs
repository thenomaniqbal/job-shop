namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cvs",
                c => new
                    {
                        CId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 200),
                        Address = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 100),
                        position = c.String(maxLength: 100),
                        file = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.CId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cvs");
        }
    }
}
