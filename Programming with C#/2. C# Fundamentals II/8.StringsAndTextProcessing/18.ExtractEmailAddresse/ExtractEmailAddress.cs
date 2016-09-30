//18.Write a program for extracting all email addresses from given text. All substrings that match the format 
//<identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

    class ExtractEmailAddress
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entere e-mail address: ");
            string address = Console.ReadLine();

            foreach (var item in Regex.Matches(address, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine("This E-mail address is VALID!: {0}", item);
            }
        }
    }

