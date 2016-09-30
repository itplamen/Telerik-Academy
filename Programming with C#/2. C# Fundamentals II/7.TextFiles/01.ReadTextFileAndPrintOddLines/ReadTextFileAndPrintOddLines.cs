//01.Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

    class ReadTextFileAndPrintOddLines
    {
        //The file sample.txt is in directory bin/Debug
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("sample.txt");
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
            Console.WriteLine("Done!");
        }
    }

