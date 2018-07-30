namespace EntityFrameworkPart2CodeFirst
{
    using System.Data.Entity;
    using EntityFrameworkPart2CodeFirst.Migrations;

    public partial class DepartmentEmployeeContext : DbContext
    {
        public DepartmentEmployeeContext()
            : base("name=DepartmentEmployeeContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DepartmentEmployeeContext, Configuration>());
        }


        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
