//11.Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

  class DeleteWordsWithGivenPrefix
    {
        //All files are in directory bin/Debug
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("sample.txt");
            StreamWriter writer = new StreamWriter("result.txt");

            using (reader)
            using (writer) 
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\btest\w{1,}", " "));
                    line = reader.ReadLine();
                    //(\b)test((\d|\w|_)*)(\b)
                }
            }
            Console.WriteLine("Done!");
        }
    }

