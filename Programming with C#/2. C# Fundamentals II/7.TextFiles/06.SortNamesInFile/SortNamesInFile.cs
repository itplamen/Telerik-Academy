//06. Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George		Peter

using System;
using System.Collections.Generic;
using System.IO;

    class SortNamesInFile
    {
        //All files are in directory bin/Debug
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("sample.txt");
            StreamWriter writer = new StreamWriter("result.txt");

            string line = reader.ReadLine();
            List<string> list = new List<string>();

            using (reader)
            using (writer)
            {
                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                }
                list.Sort();

                foreach (string element in list)
                {
                    writer.WriteLine(element);
                }
            }
            Console.WriteLine("Done!");
        }
    }

