//19.Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

    class ExtractDates
    {
        static void Main(string[] args)
        {
            string dateFormat = "dd.MM.yyyy";
            string text = "17.08.1991 2013.23.12 ";

            foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
            {
                string extractedToString = Convert.ToString(extracted);
                DateTime date = DateTime.ParseExact(extractedToString, dateFormat, CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }

