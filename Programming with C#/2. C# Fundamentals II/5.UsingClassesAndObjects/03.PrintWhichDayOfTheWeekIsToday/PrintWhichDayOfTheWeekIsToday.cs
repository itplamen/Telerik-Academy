//03.Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

    class PrintWhichDayOfTheWeekIsToday
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.DayOfWeek);
        }
    }

