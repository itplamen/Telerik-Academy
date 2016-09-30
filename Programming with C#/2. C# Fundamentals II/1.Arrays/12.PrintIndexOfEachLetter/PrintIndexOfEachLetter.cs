//12. Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfEachLetter
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine().ToLower();

        char[] englishAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 
                                     'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        foreach (char letter in word)
        {
            for (int i = 0; i < englishAlphabet.Length; i++)
            {
                if (letter == englishAlphabet[i])
                {
                    Console.WriteLine("Letter \"{0}\" index in array -> {1}", letter, i);
                }
            }
        }
    }
}