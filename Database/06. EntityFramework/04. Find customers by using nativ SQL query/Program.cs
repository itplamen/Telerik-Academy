// 04. Implement previous by using native SQL query and
// executing it through the DbContext.

namespace EntityFramework
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            DataAccessObjectsClass.SpecificCustomerBySqlQuery(1997, "Canada");
        }
    }
}
