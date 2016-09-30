//02.Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

namespace _02.ReadIntegerNumbers
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
            Console.Write("Print numbers before reverse them: ");
            SequenceOfNumbers.PrintNumbers();

            SequenceOfNumbers.ReverseNumbers();
            Console.Write("Print numbers after reverse them: ");
            SequenceOfNumbers.PrintNumbers();
        }
    }
}
