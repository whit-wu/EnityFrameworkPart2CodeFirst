using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkPart2CodeFirst
{

    public partial class Departments
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public List<Employees> Employees { get; set; }
    }
}
