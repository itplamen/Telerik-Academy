//06.Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
//the rest of the characters should be filled with '*'. Print the result string into the console.

using System;
using System.Text;

class StringCharacters
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();

        if (text.Length > 20)
        {
            Console.WriteLine("ERROR! Text must be maximum 20 characters. Try again...");
            Main();
        }
        else if (text.Length == 20)
        {
            Console.WriteLine("Text is exactly 20 characters. There will be no changes!");
        }
        else
        {
            Console.WriteLine("Text length is {0} characters. \nThe result is: {1}", text.Length, text.PadRight(20, '*'));
        }
    }
}

