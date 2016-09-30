//16.Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days

using System;
using System.Globalization;

    class CalculateDaysBetweenDates
    {
        static void Main(string[] args)
        {
            string format = "d.MM.yyyy";

            Console.Write("Enter first date in format - d.MM.yyyy : ");
            string firstDate = Console.ReadLine();

            DateTime dateOne = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);

            Console.Write("Enter second date in format - d.MM.yyyy : ");
            string secondDate = Console.ReadLine();

            DateTime dateTwo = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);

            Console.WriteLine("Number of days between {0} and {1} are {2}",firstDate, secondDate, (dateTwo - dateOne).TotalDays);
        }
    }

