//22.Write a program that reads a string from the console and lists all different words in the string along with information how 
//many times each word is found.

using System;
using System.Collections.Generic;
using System.Diagnostics;

class CountDifferentWords
{
    static void Main()
    {
        string text = "will will try to explain, what is dictionary and how to use dictionary.";
        
        char[] separators = new char[] { '.', ' ', ',' };

        string[] allWordsArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

    }
}


