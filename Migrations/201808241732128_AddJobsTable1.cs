namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJobsTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Salary", c => c.String());
            AddColumn("dbo.Jobs", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "City");
            DropColumn("dbo.Jobs", "Salary");
        }
    }
}
