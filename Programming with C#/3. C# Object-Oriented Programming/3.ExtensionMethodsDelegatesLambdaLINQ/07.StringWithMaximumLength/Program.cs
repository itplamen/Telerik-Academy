//17.Write a program to return the string with maximum length from an array of strings. Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.StringWithMaximumLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string []{ "Telerik", "Academy", "LINQ", "System", "Collections", "Threading" };
            string maxLength = array.OrderByDescending(x => x.Length).First();

            Console.WriteLine("The string with max length is: " + maxLength);     
        }
    }
}
