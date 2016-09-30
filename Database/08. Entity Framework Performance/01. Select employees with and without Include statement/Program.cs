// 01. Using Entity Framework write a SQL query to select all employees from the Telerik Academy database and 
// later print their name, department and town. Try the both variants: with and without .Include(…). Compare the 
// number of executed SQL statements and the performance.

using System;
using System.Linq;

using TelerikAcademy.Model;

namespace _01.Select_employees_with_and_without_Include_statement
{
    public class Program
    {
        public static void SelectEmployeesWithIncludeStatement()
        {
            using (var db = new TelerikAcademyDb())
            {
                foreach (var employee in db.Employees.Include("Address.Town").Include("Department"))
                {
                    Console.WriteLine("Name: {0}, Department: {1}, Town: {2}", employee.FirstName + " " + employee.LastName,
                        employee.Department.Name, employee.Address.Town.Name);
                }
            }

            Console.WriteLine();
        }

        public static void SelectEmployeesWithoutIncludeStatement()
        {
            using (var db = new TelerikAcademyDb())
            {
                foreach (var employee in db.Employees)
                {
                    Console.WriteLine("Name: {0}, Department: {1}, Town: {2}", employee.FirstName + " " + employee.LastName,
                        employee.Department.Name, employee.Address.Town.Name);
                }
            }
        }

        public static void Main()
        {
            SelectEmployeesWithIncludeStatement();
            SelectEmployeesWithoutIncludeStatement();
        }
    }
}
