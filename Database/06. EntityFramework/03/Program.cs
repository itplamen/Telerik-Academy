// 03. Write a method that finds all customers who have
// orders made in 1997 and shipped to Canada.

namespace EntityFramework
{
    using System;
    using System.Linq;
   
    public class Program
    {
        public static void Main()
        {
            DataAccessObjectsClass.SpecificCustomer(1997, "Canada");
        }
    }
}
