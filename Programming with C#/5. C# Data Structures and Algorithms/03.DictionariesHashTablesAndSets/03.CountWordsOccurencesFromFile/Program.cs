// 03.Write a program that counts how many times each word from given text file words.txt appears in it. The character casing differences 
// should be ignored. The result words should be ordered by their number of occurrences in the text. 
// Example:
// This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
// is  2
// the  2
// this  3
// text  6

namespace _03.CountWordsOccurencesFromFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //The file words.txt is in directory bin/Debug
            StreamReader reader = new StreamReader("words.txt");
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    char[] separator = { ' ', ',', '!', '?', '-', '.', '\r', '\n', '_' };
                    List<string> list = new List<string>(line.ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries));

                    for (int i = 0; i < list.Count; i++)
                    {
                        int counter = 1;

                        if (dictionary.ContainsKey(list[i]) == true)
                        {
                            counter = dictionary[list[i]] + 1;
                        }

                        dictionary[list[i]] = counter;
                    }

                    line = reader.ReadLine();
                }
            }

            var result = dictionary.OrderBy(item => item.Value);

            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
