using System;
using System.Linq;

namespace EntityFrameworkPart2CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //DepartmentEmployeeContext ctx = new DepartmentEmployeeContext();
            //Database.SetInitializer(new DepartmentEmployeeInitalizer());
            //ctx.Database.Initialize(true);
            //Console.WriteLine("Our database has been seeded.");

            //var queryResults =  from emp in ctx.Employees
            //                    join dept in ctx.Departments
            //                    on emp.DepartmentID equals dept.DepartmentID
            //                    select new
            //                    {
            //                        emp.EmpFirstName,
            //                        dept.DepartmentName
            //                    };
                
            //foreach (var queryResult in queryResults)
            //{
            //    Console.WriteLine(queryResult.EmpFirstName + " works in " + queryResult.DepartmentName);
            //}

            Quarks quarkCTX = new Quarks();

            var quarksQuery = from c in quarkCTX.CUSTOMERS
                              join t in quarkCTX.TRANSACTIONS
                              on c.CUSTOMER_ID equals t.CUSTOMER_ID
                              select new
                              {
                                  c.FIRST_NAME,
                                  c.LAST_NAME,
                                  t.TRANSACTION_AMOUNT,
                                  t.TRANSACTION_ID
                              };

            foreach (var result in quarksQuery)
            {
                Console.WriteLine("Customer " + result.FIRST_NAME + " " + result.LAST_NAME + " owes " 
                    + result.TRANSACTION_AMOUNT + " for transaction " + result.TRANSACTION_ID);
            }
        }
    }
}
