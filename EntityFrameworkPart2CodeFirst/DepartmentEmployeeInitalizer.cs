using System.Data.Entity;

namespace EntityFrameworkPart2CodeFirst
{
    class DepartmentEmployeeInitalizer : DropCreateDatabaseAlways<DepartmentEmployeeContext>
    {
        protected override void Seed(DepartmentEmployeeContext context) 
        {
            context.Departments.Add(new Departments { DepartmentName = "IT" });
            context.Departments.Add(new Departments { DepartmentName = "Accounting" });
            context.Departments.Add(new Departments { DepartmentName = "Sales" });

            context.Employees.Add(new Employees { EmpFirstName = "Montgomery", EmpMiddleInital = "C",
                EmpLastName = "Scott", DepartmentID = 1 });

            context.Employees.Add(new Employees {EmpFirstName = "Bob", EmpLastName = "Cratchit",
                DepartmentID = 2});

            context.Employees.Add(new Employees { EmpFirstName = "Michael",  EmpMiddleInital = "G",
                EmpLastName = "Scott", DepartmentID = 3 });

            context.SaveChanges();
        }   
    }
}
