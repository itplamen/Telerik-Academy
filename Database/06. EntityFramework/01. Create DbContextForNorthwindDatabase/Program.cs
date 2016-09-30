// 01. Using the Visual Studio Entity Framework designer
// create a DbContext for the Northwind database.

namespace EntityFramework
{
    using System;
    using System.Linq;
    using Northwind.Models;

    public class Program
    {
        public static void Main()
        {
            // Test database connection.
            using (var db = new NorthwindEntities())
            {
                var productNames = db.Products.Select(p => p.ProductName);

                foreach (var name in productNames)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
