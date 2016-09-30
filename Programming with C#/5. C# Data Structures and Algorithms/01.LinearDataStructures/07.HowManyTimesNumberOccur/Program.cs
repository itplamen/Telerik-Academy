//07.Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
//Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
//2  2 times
//3  4 times
//4  3 times

namespace _07.HowManyTimesNumberOccur
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private const int MIN_NUMBER_OF_RANGE = 0;
        private const int MAX_NUMBER_OF_RANGE = 1000;

        public static int[] AddNumbers(int[] array, int numbersLength)
        {
            for (int i = 0; i < numbersLength; i++)
            {
                Console.Write("Enter number: ");
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber < MIN_NUMBER_OF_RANGE || inputNumber > MAX_NUMBER_OF_RANGE)
                {
                    throw new ArgumentOutOfRangeException("The number is NOT in the range [" + MIN_NUMBER_OF_RANGE + " ... " + MAX_NUMBER_OF_RANGE + "]");
                }

                array[i] = inputNumber;
            }

            return array;
        }

        public static void TimesOccur(int[] array)
        {
            List<string> result = new List<string>();
            List<int> numersOccur = new List<int>();
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (IsNumberAlreadyOccur(numersOccur, array[i]) == false)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            counter++;
                        }
                    }

                    numersOccur.Add(array[i]);
                    result.Add(array[i].ToString() + " -> " + counter.ToString() + " times. ");
                    counter = 0;
                }
            }

            Print(result);
        }

        public static bool IsNumberAlreadyOccur(List<int> numbersOccur, int number)
        {
            for (int i = 0; i < numbersOccur.Count; i++)
            {
                if (numbersOccur[i] == number)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Print(List<string> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Console.Write("How many number you wish to enter: ");
            int numbersLength = int.Parse(Console.ReadLine());

            if (numbersLength <= 0)
            {
                throw new ArgumentOutOfRangeException("Numbers length cannot be negative or zero! You have to enter atleast one number!");
            }

            int[] array = new int[numbersLength];
            array = AddNumbers(array, numbersLength);
            TimesOccur(array);
        }
    }
}
