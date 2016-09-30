// 02. Using Entity Framework write a query that selects all employees from the Telerik Academy database, 
// then invokes ToList(), then selects their addresses, then invokes ToList(), then selects their towns, 
// then invokes ToList() and finally checks whether the town is "Sofia". Rewrite the same in more optimized 
// way and compare the performance.

using System;
using System.Linq;

using TelerikAcademy.Model;

namespace _02.Select_employees_and_invoke_ToList
{
    public class Program
    {
        public static void UsingToListEveryTime()
        {
            using (var db = new TelerikAcademyDb())
            {
                var employees = db.Employees
                    .ToList()
                    .Select(e => e.Address)
                    .ToList()
                    .Select(a => a.Town)
                    .ToList()
                    .Where(t => t.Name == "Sofia")
                    .ToList();
            }
        }

        public static void UsingToListAtTheEnd()
        {
            using (var db = new TelerikAcademyDb())
            {
                var employees = db.Employees
                    .Where(t => t.Address.Town.Name == "Sofia")
                    .Select(e => new 
                    {
                        Address = e.Address,
                        Town = e.Address.Town.Name
                    })
                    .ToList();
            }
        }

        public static void Main()
        {
            UsingToListEveryTime();
            UsingToListAtTheEnd();
        }
    }
}
