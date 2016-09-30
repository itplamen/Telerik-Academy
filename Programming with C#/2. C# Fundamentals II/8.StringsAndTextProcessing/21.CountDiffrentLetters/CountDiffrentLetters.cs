//21.Write a program that reads a string from the console and prints all different letters in the string along with information 
//how many times each letter is found. 

using System;

    class CountDiffrentLetters
    {
        static void Main(string[] args)
        {
            string text = "blaaa computer string letters";

            char[] letters = new char[65536];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters[text[i]]++;
                }
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 0 && char.IsLetter((char)i))
                {
                    Console.WriteLine("{0} -> {1} times", (char)i, (int)letters[i]);
                }
            }
            Console.WriteLine();
        }
    }

