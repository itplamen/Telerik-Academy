namespace Northwind.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        public static IList<Employee> GetEmployees()
        {
            var db = new NorthwindEntities();
            return db.Employees.ToList();
        }
    }
}
