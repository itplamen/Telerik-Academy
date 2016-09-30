//09.We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:

//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a 
//dynamic language in CLR.

//Words: "PHP, CLR, Microsoft". The expected result:

//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a 
//dynamic language in ***.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

    class ReplaceForbiddenWords
    {
        static List<string> ForbiddenWords()
        {
            StreamReader reader = new StreamReader("words.txt");
            List<string> list = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                List<string> list = ForbiddenWords();

                while (line != null)
                {
                    foreach (string element in list)
                    {
                        line = line.Replace(element, new String('*', element.Length));
                    }
                    Console.WriteLine(line);

                    line = reader.ReadLine();
                } 
            } 
        }
    }

