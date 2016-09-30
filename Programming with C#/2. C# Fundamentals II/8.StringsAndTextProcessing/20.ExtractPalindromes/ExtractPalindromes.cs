//20.Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;
using System.Text;

    class ExtractPalindromes
    {
        static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string text = "ABBA lamal blaaa telerik exe computer ama";
            List<string> list = new List<string>(text.Split(' '));
            string result = "";

            for (int i = 0; i < list.Count; i++)
            {
                string word = ReverseText(list[i]);

                if (list[i] == word)
                {
                    result = result + " " + word;
                }
            }
            Console.WriteLine("Palindromes are: " + result);
        }
    }

