//13Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;

    class ReverseWords
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            char[] separators = new char[] {' ', ',', '!', '?', '.' };
            List<string> list = new List<string>(text.Split(separators, StringSplitOptions.RemoveEmptyEntries));

            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + " ");

                if (list[i] == "PHP")
                {
                    Console.Write(",");
                }
            }
            Console.Write("!");
            Console.WriteLine();
        }
    }

