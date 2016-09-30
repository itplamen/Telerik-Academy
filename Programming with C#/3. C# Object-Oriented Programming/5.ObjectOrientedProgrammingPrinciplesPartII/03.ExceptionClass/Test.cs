//03.Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end]. Write a sample application that demonstrates the 
//InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the 
//range [1.1.1980 … 31.12.2013].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExceptionClass
{
    class Test
    {
        // Test with integer values
        static void IntegerTest(int start, int end, int inputNumber)
        {
            try
            {
                if (inputNumber < start || inputNumber > end)
                {
                    throw new InvalidRangeException<int>("Number is out of range!", start, end);
                }
                else
                {
                    Console.WriteLine("The number is in the range!");
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The range is [{0} - {1}]", ex.Start, ex.End);
            }
        }

        // Test with DateTime values
        static void DateTimeTest(DateTime start, DateTime end, DateTime inputDate)
        {
            try
            {
                if (inputDate < start || inputDate > end)
                {
                    throw new InvalidRangeException<DateTime>("Date is out of range!", start, end);
                }
                else
                {
                    Console.WriteLine("The date is in the range!");
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The range is [{0} - {1}]", ex.Start, ex.End);
            }
        }

        static void Main(string[] args)
        {
            IntegerTest(1, 4, 5);
            DateTimeTest(new DateTime(1991, 8, 7), new DateTime(1991, 8, 18), new DateTime(1991, 8, 20));
        }
    }
}
