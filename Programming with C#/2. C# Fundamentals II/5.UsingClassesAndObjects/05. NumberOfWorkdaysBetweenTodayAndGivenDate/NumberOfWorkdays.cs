//05. Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

    class NumberOfWorkdays
    {
        private static DateTime today;
        private static DateTime lastDay;
        private static int allDays;

        static void CalculateWokrdays(DateTime lastDay)
        {
            DateTime[] holidays =
          {
              new DateTime(2013, 1, 1),
              new DateTime(2013, 3, 3),
              new DateTime(2013, 5, 1),
              new DateTime(2013, 5, 2),
              new DateTime(2013, 5, 3),
              new DateTime(2013, 5, 4),
              new DateTime(2013, 5, 5),
              new DateTime(2013, 5, 6),
              new DateTime(2013, 5, 24),
              new DateTime(2013, 9, 6),
              new DateTime(2013, 9, 22),
              new DateTime(2013, 12, 24),
              new DateTime(2013, 12, 25),
              new DateTime(2013, 12, 26),
              new DateTime(2013, 12, 31)
          };

            DateTime[] workdayseOfWeek =
          {
              new DateTime(2013, 5, 11),
              new DateTime(2013, 5, 18),
              new DateTime(2013, 12, 14)
          };

            today = DateTime.Today;
            allDays = (lastDay - today).Days;

            while (lastDay >= today)
            {
                if ((today.DayOfWeek == DayOfWeek.Saturday) || (today.DayOfWeek == DayOfWeek.Sunday))
                {
                    for (int m = 0; m < workdayseOfWeek.Length; m++)
                    {
                        if (today == workdayseOfWeek[m])
                        {
                            allDays++;   
                        }
                    }
                    allDays--;
                }
                else
                {
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (today == holidays[i])
                        {
                            allDays--;
                        }
                    }

                    for (int j = 0; j < workdayseOfWeek.Length; j++)
                    {
                        if (today == workdayseOfWeek[j])
                        {
                            allDays++;
                        }
                    }
                }
                today = today.AddDays(1);
            }
            Console.WriteLine("All days are: " + allDays);
        }

        static void Main(string[] args)
          {
            Console.Write("Enter last day (Year.Month.Day) : ");
            lastDay = DateTime.Parse(Console.ReadLine());

            CalculateWokrdays(lastDay);
        }
    }

