//10.Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;

    class ExtractTextFromGivenXMLFile 
    {
        //The file is in directory bin/Debug
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("sample.xml");
            using (reader)
            {
                string line = reader.ReadLine();
                char letter = ' ';
                char nextLetter = ' ';
                string word = "";

                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        letter = line[i];
                        if (letter == '>')
                        {
                            for (int j = i + 1; j < line.Length; j++)
                            {
                                nextLetter = line[j];
                                if (nextLetter == '<')
                                {
                                    break;
                                }
                                else
                                {
                                    word += nextLetter;
                                }
                            }
                        }
                    }
                    word = word + ' ';
                    line = reader.ReadLine();
                }
                Console.WriteLine(word);
            }
        }
    }

