//14.A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. 

//Sample dictionary:

//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

using System;

    class TranslateWordByDictionary
    {
        static void Main()
        {
            string dictionary = ".Net - platform for applications from Microsoft\n"
                                 + "CLR - managed execution environment for .NET\n"
                                  + "namespace - hierarchical organization of classes\n";

            string[] words = dictionary.Split('\n', '-');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < words.Length - 1; i += 2)
            {
                if (word == words[i])
                {
                    Console.WriteLine("{0} -> {1}",word, words[i + 1]);
                    break;
                }
                else if (i == words.Length - 3)
                {
                    Console.WriteLine("ERROR! There is no such word! Try again...");
                    Console.WriteLine();
                    Main();
                }
            }
            Console.WriteLine();
        }
    }

