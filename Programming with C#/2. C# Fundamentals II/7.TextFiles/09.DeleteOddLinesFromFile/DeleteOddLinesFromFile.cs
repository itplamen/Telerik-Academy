//09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

    class DeleteOddLinesFromFile
    {
        //The file is in directory bin/Debug
        static void ReadFile(List<string> list)
        {
            StreamReader reader = new StreamReader("sample.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;

                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        list.Add(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }

        static void WriteFile(List<string> list)
        {
            StreamWriter writer = new StreamWriter("sample.txt");

            using (writer)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            ReadFile(list);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            WriteFile(list);
            Console.WriteLine("Done!");
        }
    }

