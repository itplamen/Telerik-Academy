//01.Write a program that reads from the console a sequence of positive integer numbers. The sequence ends when empty 
//line is entered. Calculate and print the sum and average of the elements of the sequence. Keep the sequence in List<int>.

namespace _01.SequenceOfPositiveIntegerNumbers
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
            Console.WriteLine("Sum: " + SequenceOfNumbers.Sum);
            Console.WriteLine("Average: " + SequenceOfNumbers.Average);
        }
    }
}
