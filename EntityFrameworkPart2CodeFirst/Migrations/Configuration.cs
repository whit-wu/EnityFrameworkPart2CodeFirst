namespace EntityFrameworkPart2CodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkPart2CodeFirst.DepartmentEmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFrameworkPart2CodeFirst.DepartmentEmployeeContext";
        }

        protected override void Seed(EntityFrameworkPart2CodeFirst.DepartmentEmployeeContext context)
        {

            context.Employees.AddOrUpdate(new Employees { EmpFirstName = "Samantha", EmpLastName = "Carter",
                DepartmentID = 1, EmpSalary = 100000});
        }
    }
}
