//02.Write a program that concatenates two text files into another text file.

using System;
using System.IO;

    class ConcatenateTwoTextFilesIntoAnother
    {
        //All files are in directory bin/Debug
        static void Main(string[] args)
        {
            StreamReader firstFileReader = new StreamReader("firstFile.txt");
            StreamReader secondFileReader = new StreamReader("secondFile.txt");
            StreamWriter concatenatedWriter = new StreamWriter("concatenatedFile.txt");

            using (firstFileReader)
            using (secondFileReader)
            using (concatenatedWriter)
            {
                string firstLine = firstFileReader.ReadLine();
                string secondLine = secondFileReader.ReadLine();

                while (firstLine != null && secondLine != null)
                {
                    concatenatedWriter.WriteLine(firstLine);
                    firstLine = firstFileReader.ReadLine();
                }
                
                while (secondLine != null)
                {
                    concatenatedWriter.WriteLine(secondLine);
                    secondLine = secondFileReader.ReadLine();
                }
            }
            Console.WriteLine("Done!");
        }
    }


