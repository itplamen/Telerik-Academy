//03.Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

namespace _03.SortIntegersInIncreasingOrder
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
            SequenceOfNumbers.AddNumbers();
            Console.Write("Print numbers before sort them: ");
            SequenceOfNumbers.PrintNumbers();

            SequenceOfNumbers.SortNumbers();
            Console.Write("Print numbers after sort them: ");
            SequenceOfNumbers.PrintNumbers();
        }
    }
}
