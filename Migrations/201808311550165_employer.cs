namespace JobShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employers",
                c => new
                    {
                        EmployerId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 100),
                        EmailAdress = c.String(nullable: false, maxLength: 200),
                        Gender = c.String(maxLength: 1),
                        Age = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 20),
                        HireDate = c.DateTime(),
                        Title = c.String(nullable: false, maxLength: 100),
                        Designation = c.String(maxLength: 200),
                        Salary = c.String(maxLength: 100),
                        PersonalWebsite = c.String(maxLength: 100),
                        Company = c.String(),
                        Department = c.String(),
                        Photo = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.EmployerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.employers");
        }
    }
}
