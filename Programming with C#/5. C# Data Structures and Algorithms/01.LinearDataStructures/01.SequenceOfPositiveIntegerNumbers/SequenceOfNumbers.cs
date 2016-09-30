namespace _01.SequenceOfPositiveIntegerNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class SequenceOfNumbers
    {
        private static List<int> numbers = new List<int>();

        public static int Sum 
        {
            get
            {
                if (numbers.Count == 0)
                {
                    throw new ArgumentException("Cannot calculate sum of numbers! There is NO numbers in the list!");
                }

                int numbersSum = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbersSum += numbers[i];
                }

                return numbersSum;
            }
        }

        public static int Average 
        {
            get
            {
                if (numbers.Count == 0)
                {
                    throw new ArgumentException("Cannot calculate sum of numbers! There is NO numbers in the list!");
                }

                int numbersAverage = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbersAverage += numbers[i];
                }

                return numbersAverage / numbers.Count;
            } 
        }

        public static void AddNumbers()
        {
            while (true)
            {
                Console.Write("Enter positive integer number: ");
                string inputNumber = Console.ReadLine();

                if (inputNumber == string.Empty)
                {
                    break;
                }

                if (int.Parse(inputNumber) < 0)
                {
                    Console.WriteLine("Invalid number! Number must be positive. Try again ... \n");
                }
                else
                {
                    numbers.Add(int.Parse(inputNumber));
                }
            }
        }
    }
}
