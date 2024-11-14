namespace EducationalPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EmployeeCopies");
            AlterColumn("dbo.EmployeeCopies", "EmployeeID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EmployeeCopies", "EmployeeID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EmployeeCopies");
            AlterColumn("dbo.EmployeeCopies", "EmployeeID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.EmployeeCopies", "EmployeeID");
        }
    }
}
