//03.Refactor the following loop

namespace _03.RefactorLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 3, 6, 2, 9, 5, 10, 100, 20, 35, 64 };
            int expectedValue = 9;
            int devider = 10;

            for (int i = 0; i < array.Length; i++)
            {
                if ((i % devider == 0) && (array[i] == expectedValue))
                {
                    Console.WriteLine("Value find: " + array[i]);
                    break;
                }
            }
        }
    }
}
