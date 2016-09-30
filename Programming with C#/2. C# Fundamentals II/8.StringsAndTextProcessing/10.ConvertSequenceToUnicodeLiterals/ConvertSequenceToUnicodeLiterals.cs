//10.Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
//Sample input:

//Hi!

//Expected output:

//\u0048\u0069\u0021

using System;

    class ConvertSequenceToUnicodeLiterals
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";

            for (int i = 0; i < text.Length; i++)
            {
                int number = text[i];
                Console.Write("\\u{0:x4}", number);
            }
            Console.WriteLine();
        }
    }

