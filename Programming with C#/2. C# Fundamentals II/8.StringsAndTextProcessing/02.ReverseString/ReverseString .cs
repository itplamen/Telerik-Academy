//02.Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".
 
using System;
using System.Text;

    class ReverseString 
    {
        static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string text = Console.ReadLine();

            string result = ReverseText(text);
            Console.WriteLine("The result is: " + result);
        }
    }

