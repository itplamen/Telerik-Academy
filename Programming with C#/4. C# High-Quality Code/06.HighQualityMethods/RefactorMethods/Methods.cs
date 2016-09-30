//Use the provided source code "High-Quality-Methods-Homework.zip".
//Take the VS solution "Methods" and refactor its code to follow the guidelines of high-quality methods. Ensure you handle 
//errors correctly: when the methods cannot do what their name says, throw an exception (do not return wrong result).
//Ensure good cohesion and coupling, good naming, no side effects, etc.

namespace RefactorMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Methods
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Triangle area: " + CalculateTriangleArea(3, 4, 5));

            Console.WriteLine("Digit to string: " + ConvertDigitToString(5));

            Console.WriteLine("Max number is: " + FindMaxNumber(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine();

            PrintNumber(1.3, 2);
            PrintPercent(0.75, 0);
            PrintAligned(2.30, 8);
            Console.WriteLine();

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;

            Console.WriteLine("Distance: " + CalcDistance(x1, y1, x2, y2));
            Console.WriteLine("Horizontal? " + IsHorizontal(y1, y2));
            Console.WriteLine("Vertical? " + IsVertical(x1, x2));
            Console.WriteLine();

            Student peter = new Student("Peter", "Ivanov", new DateTime(1998, 02, 18));
            Student stella = new Student("Stella", "Markova", new DateTime(1988, 10, 28));

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
            Console.WriteLine("{0} older than {1} -> {2}", stella.FirstName, peter.FirstName, stella.IsOlderThan(peter));
        }

        private static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Triangle sides cannot be negative or zero!");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("The inequality of the triangle is violated!");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            
            return area;
        }

        private static string ConvertDigitToString(int digit)
        {
            string digitToString = string.Empty;

            switch (digit)
            {
                case 0:
                    digitToString = "zero";
                    break;
                case 1: 
                    digitToString = "one";
                    break;
                case 2: 
                    digitToString = "two";
                    break;
                case 3: 
                    digitToString = "three";
                    break;
                case 4: 
                    digitToString = "four";
                    break;
                case 5: 
                    digitToString = "five";
                    break;
                case 6: 
                    digitToString = "six";
                    break;
                case 7: 
                    digitToString = "seven";
                    break;
                case 8: 
                    digitToString = "eight";
                    break;
                case 9: 
                    digitToString = "nine";
                    break;
                default: throw new ArgumentOutOfRangeException("Number cannot be negative or bigger than nine!");
            }

            return digitToString;
        }

        private static int FindMaxNumber(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Elements cannot be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Elements length cannot be zero!");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        private static void PrintNumber(object value, int digits)
        {
            string format = "{0:F" + digits + "}";
            Console.WriteLine("Print number: " + format, value);
        }

        private static void PrintPercent(object value, int digits)
        {
            string format = "{0:P" + digits + "}";
            Console.WriteLine("Print percent: " + format, value);
        }

        private static void PrintAligned(object value, int totalWidth)
        {
            string format = "{0," + totalWidth + "}";
            Console.WriteLine("Print aligned: " + format, value);
        }

        private static bool IsHorizontal(double y1, double y2)
        {
            return y1 == y2;
        }

        private static bool IsVertical(double x1, double x2)
        {
            return x1 == x2;
        }

        private static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }
    }
}
