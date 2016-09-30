// 05. Write a method that finds all the sales by specified
// region and period (start / end dates).

namespace EntityFramework
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            DataAccessObjectsClass.SalesByRegionAndPeriod("SP", new DateTime(1996, 7, 17), new DateTime(1996, 11, 8));
        }
    }
}
