namespace EducationalPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeCopies",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        Position = c.String(),
                        FullName = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        LastLogin = c.String(),
                        Services = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeCopies");
        }
    }
}
