using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkPart2CodeFirst
{
    public partial class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpMiddleInital { get; set; }
        public string EmpLastName { get; set; }

        public decimal EmpSalary { get; set; }

        [ForeignKey("Departments")]
        public int DepartmentID { get; set; }
        public Departments Departments { get; set; }
    }
}
