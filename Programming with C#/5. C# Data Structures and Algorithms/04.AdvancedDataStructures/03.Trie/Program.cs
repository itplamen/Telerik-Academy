//03.Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file). 
//Print how many times each word occurs in the text.
//Hint: you may find a C# trie in Internet. 

namespace _03.Trie
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using rmandvikar.Trie;

    public class Program
    {
        // I'm using trie implementation from:
        // https://code.google.com/p/csharptrie/source/browse/rmandvikar.Trie/?r=ee66737c1b06770fa936e004423986b828a0c49b

        public static ICollection<string> GetWords()
        {
            StreamReader reader = new StreamReader("input.txt");

            using (reader)
            {
                List<string> words = new List<string>();
                string line = reader.ReadLine();

                while (line != null)
                {
                    var currentWords = Regex.Matches(line, @"[a-zA-Z]+").Cast<Match>().Select(match => match.Value).ToArray();
                    words.AddRange(currentWords.Select(word => word.ToLower()));
                    line = reader.ReadLine();
                }

                return words;
            }
        }

        public static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            ICollection<string> words = GetWords();
            Console.WriteLine(DateTime.Now - date);

            var trie = TrieFactory.GetTrie();

            foreach (var word in words)
            {
                trie.AddWord(word);
            }

            var searched = new[] { "trie", "array", "the", "of", "static" };

            Console.WriteLine(string.Join(" | ", searched.Select(word => string.Format("{0} {1}", word, trie.WordCount(word.ToLower())))));
        }
    }
}
