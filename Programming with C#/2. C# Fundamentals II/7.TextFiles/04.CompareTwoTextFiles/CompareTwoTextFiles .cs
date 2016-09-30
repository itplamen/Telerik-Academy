//04. Write a program that compares two text files line by line and prints the number of lines that are the same and 
//the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;

    class CompareTwoTextFiles 
    {
        //All files are in directory bin/Debug
        static void Main(string[] args)
        {
            StreamReader firstFileReader = new StreamReader("firstFile.txt");
            StreamReader secondFileReader = new StreamReader("secondFile.txt");

            string sameLines = "";
            string differentLines = "";
            int matchingLines = 0;
            int mismatchingLines = 0;

            using (firstFileReader)
            using (secondFileReader)
            {
                string firstFileLine = firstFileReader.ReadLine();
                string secondFileLine = secondFileReader.ReadLine();

                while (firstFileLine != null && secondFileLine != null)
                {
                    matchingLines++;
                    mismatchingLines++;
                    
                    if (firstFileLine == secondFileLine)
                    {
                        sameLines += " " + matchingLines;
                    }
                    else
                    {
                        differentLines += " " + mismatchingLines;
                    }

                    firstFileLine = firstFileReader.ReadLine();
                    secondFileLine = secondFileReader.ReadLine();
                }
            }
            Console.WriteLine("The same lines are:" + sameLines);
            Console.WriteLine("The differents lines are:" + differentLines);
        }
    }

