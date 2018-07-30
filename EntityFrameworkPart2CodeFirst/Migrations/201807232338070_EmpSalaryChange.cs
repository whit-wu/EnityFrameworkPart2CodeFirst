namespace EntityFrameworkPart2CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpSalaryChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmpSalary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmpSalary");
        }
    }
}
