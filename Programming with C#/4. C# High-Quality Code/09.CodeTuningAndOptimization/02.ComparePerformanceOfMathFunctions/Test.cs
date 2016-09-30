//02.Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values

namespace _02.ComparePerformanceOfMathFunctions
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        private static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static void Main(string[] args)
        {
            #region MathSquareRootTest
            Console.WriteLine("---------- MATH SQUARE ROOT ----------");
            
            DisplayExecutionTime(() =>
            {
                Console.Write("Float:\t\t");
                MathSquareRootTester.MathSquareRootFloat();
            });

            DisplayExecutionTime(() =>
            {
                Console.Write("Double:\t\t");
                MathSquareRootTester.MathSquareRootDouble();
            });

            DisplayExecutionTime(() =>
            {
                Console.Write("Decimal:\t");
                MathSquareRootTester.MathSquareRootDecimal();
            });

            Console.WriteLine();
            #endregion

            #region MathNaturalLogarithmTest
            Console.WriteLine("---------- MATH NATURAL LOGARITHM ----------");
            
            DisplayExecutionTime(() =>
            {
                Console.Write("Float:\t\t");
                MathNaturalLogarithmTester.MathNaturalLogarithmFloat();
            });

            DisplayExecutionTime(() =>
            {
                Console.Write("Double:\t\t");
                MathNaturalLogarithmTester.MathNaturalLogarithmDouble();
            });

            DisplayExecutionTime(() =>
            {
                Console.Write("Decimal:\t");
                MathNaturalLogarithmTester.MathNaturalLogarithmDecimal();
            });

            Console.WriteLine();
            #endregion

            #region MathSinusTest
            Console.WriteLine("---------- MATH SINUS ----------");

            DisplayExecutionTime(() =>
            {
                Console.Write("Float:\t\t");
                MathSinusTester.MathSinusFloat();
            });

            DisplayExecutionTime(() =>
            {
                Console.Write("Double:\t\t");
                MathSinusTester.MathSinusDouble();
            });

            DisplayExecutionTime(() =>
            {
                Console.Write("Decimal:\t");
                MathSinusTester.MathSinusDecimal();
            });

            Console.WriteLine();
            #endregion
        }
    }
}
