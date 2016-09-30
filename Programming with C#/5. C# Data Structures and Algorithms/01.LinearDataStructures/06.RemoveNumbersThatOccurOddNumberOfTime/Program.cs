//06.Write a program that removes from given sequence all numbers that occur odd number of times. Example:
//{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}

namespace _06.RemoveNumbersThatOccurOddNumberOfTime
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void FindNumbers(List<int> sequence)
        {
            List<int> result = new List<int>();
            int counter = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                for (int j = 0; j < sequence.Count; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        counter++;
                    }
                }

                if (counter % 2 == 0)
                {
                    result.Add(sequence[i]);
                }

                counter = 0;
            }

            PrinNumbers(result);
        }

        public static void PrinNumbers(List<int> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            FindNumbers(sequence);
        }
    }
}
