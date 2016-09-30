// 01.Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
// Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
// -2.5  2 times
// 3  4 times
// 4  3 times

namespace _01.CountOccurrencesOfValue
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
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> dictionary = new Dictionary<double, int>();
            
            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;

                if (dictionary.ContainsKey(array[i]) == true)
                {
                    counter = dictionary[array[i]] + 1;
                }

                dictionary[array[i]] = counter;
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0} -> {1} times.", pair.Key, pair.Value);
            }
        }
    }
}
