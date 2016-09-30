//05.Write a program that removes from given sequence all negative numbers.

namespace _05.RemoveNegativeNumbersFromSequence
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
            Console.Write("How many number you wish to enter: ");
            int numbersLength = int.Parse(Console.ReadLine());

            if (numbersLength <= 0)
            {
                throw new ArgumentOutOfRangeException("Numbers length cannot be negative or zero! You have to enter atleast one number!");
            }

            List<int> positiveNumbers = new List<int>();

            for (int i = 0; i < numbersLength; i++)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            Console.WriteLine("Print positive numbers: ");
            for (int i = 0; i < positiveNumbers.Count; i++)
            {
                Console.Write(positiveNumbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
