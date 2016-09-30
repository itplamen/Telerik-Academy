namespace _02.ReadIntegerNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public static class SequenceOfNumbers
    {
        private static Stack<int> currentNumbers = new Stack<int>();
        private static List<int> numbers = new List<int>();

        public static void AddNumbers()
        {
            Console.Write("How many number you wish to enter: ");
            int numbersLength = int.Parse(Console.ReadLine());

            if (numbersLength <= 0)
            {
                throw new ArgumentOutOfRangeException("Numbers length cannot be negative or zero! You have to enter atleast one number!");
            }

            for (int i = 0; i < numbersLength; i++)
            {
                Console.Write("Enter number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
        }

        public static void ReverseNumbers()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                currentNumbers.Push(numbers[i]);
            }

            numbers.Clear();

            while (currentNumbers.Count > 0)
            {
                numbers.Add(currentNumbers.Pop());
            }
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
