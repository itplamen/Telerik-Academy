// 02.Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
// {C#, SQL, PHP, PHP, SQL, SQL }  {C#, SQL}

namespace _02.ExtractElementsWithOddOcurrence
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
            string[] array = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> sortedDictionary = new Dictionary<string, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;

                if (sortedDictionary.ContainsKey(array[i]) == true)
                {
                    counter = sortedDictionary[array[i]] + 1;
                }

                sortedDictionary[array[i]] = counter;
            }

            var result = sortedDictionary.Where(item => (item.Value % 2 == 1)).Select(item => item.Key);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }
    }
}
