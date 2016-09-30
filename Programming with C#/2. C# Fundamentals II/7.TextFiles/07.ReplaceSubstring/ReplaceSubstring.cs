//07.Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

    class ReplaceSubstring
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
                    line = line.ToLower().Replace("start", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("Done!");
        }
    }

