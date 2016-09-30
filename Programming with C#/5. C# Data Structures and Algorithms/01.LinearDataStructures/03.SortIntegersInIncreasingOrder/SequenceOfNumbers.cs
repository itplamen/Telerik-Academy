namespace _03.SortIntegersInIncreasingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class SequenceOfNumbers
    {
        private static List<int> numbers = new List<int>();

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
                else
                {
                    numbers.Add(int.Parse(inputNumber));
                }
            }
        }

        public static void SortNumbers()
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("Cannot sort numbers! There is NO numbers in the list!");
            }

            numbers.Sort();
        }

        public static void PrintNumbers()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
