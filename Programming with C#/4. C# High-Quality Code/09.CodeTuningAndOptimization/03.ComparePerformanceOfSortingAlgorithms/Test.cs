//03. * Write a program to compare the performance of insertion sort, selection sort, quicksort for int, 
//double and string values. 

namespace _03.ComparePerformanceOfSortingAlgorithms
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
            #region InsertionSortAlgorithmTest
            Console.WriteLine("---------- INSERTION SORT ALGORITHM ----------");

            DisplayExecutionTime(() =>
            {
                int[] integerArray = { 7, 3, 110, -200000, 1, 0, 1, 0, 999, 91231, 13333, -700, 1, -123, 3333, 111, 222, 13, 1, 7 };

                Console.Write("Int:\t\t");
                InsertionSortAlgorithmTester.InsertionSortAlgorithm(integerArray);
            });

            DisplayExecutionTime(() =>
            {
                double[] doubleArray = { 7.13, 3.11, 110.2, -200000.991, 1.0, 0, 1.0, 0, 999.0, 91231.6, 13333.1, -700.0, 1.0, -123.1, 3333.333, 111.1, 222.2, 13.3, 1.0, 7.1 };

                Console.Write("Double:\t\t");
                InsertionSortAlgorithmTester.InsertionSortAlgorithm(doubleArray);
            });

            DisplayExecutionTime(() =>
            {
                string[] stringArray = { "c", "test", "off", "a", "g", "debug", "int", "a", "c", "help", "off", "common", "sql", "git", "float", "char", "team", "file", "start", "int" };

                Console.Write("String:\t\t");
                InsertionSortAlgorithmTester.InsertionSortAlgorithm(stringArray);
            });

            Console.WriteLine();
            #endregion

            #region SelectionSortAlgorithmTest
            Console.WriteLine("---------- SELECTION SORT ALGORITHM ----------");

            DisplayExecutionTime(() =>
            {
                int[] integerArray = { 7, 3, 110, -200000, 1, 0, 1, 0, 999, 91231, 13333, -700, 1, -123, 3333, 111, 222, 13, 1, 7 };

                Console.Write("Int:\t\t");
                SelectionSortAlgorithmTester.SelectionSortAlgorithm(integerArray);
            });

            DisplayExecutionTime(() =>
            {
                double[] doubleArray = { 7.13, 3.11, 110.2, -200000.991, 1.0, 0, 1.0, 0, 999.0, 91231.6, 13333.1, -700.0, 1.0, -123.1, 3333.333, 111.1, 222.2, 13.3, 1.0, 7.1 };

                Console.Write("Double:\t\t");
                SelectionSortAlgorithmTester.SelectionSortAlgorithm(doubleArray);
            });

            DisplayExecutionTime(() =>
            {
                string[] stringArray = { "c", "test", "off", "a", "g", "debug", "int", "a", "c", "help", "off", "common", "sql", "git", "float", "char", "team", "file", "start", "int" };

                Console.Write("String:\t\t");
                SelectionSortAlgorithmTester.SelectionSortAlgorithm(stringArray);
            });

            Console.WriteLine();
            #endregion

            #region QuicksortAlgorithmTest
            Console.WriteLine("---------- QUICKSORT ALGORITHM ----------");

            DisplayExecutionTime(() =>
            {
                int[] integerArray = { 7, 3, 110, -200000, 1, 0, 1, 0, 999, 91231, 13333, -700, 1, -123, 3333, 111, 222, 13, 1, 7 };
                int leftIntegerElementIndex = 0;
                int rightIntegerElementIndex = integerArray.Length - 1;

                Console.Write("Int:\t\t");
                QuicksortAlgorithmTester.QuicksortAlgorithm(integerArray, leftIntegerElementIndex, rightIntegerElementIndex);
            });

            DisplayExecutionTime(() =>
            {
                double[] doubleArray = { 7.13, 3.11, 110.2, -200000.991, 1.0, 0, 1.0, 0, 999.0, 91231.6, 13333.1, -700.0, 1.0, -123.1, 3333.333, 111.1, 222.2, 13.3, 1.0, 7.1 };
                int leftDoubleElementIndex = 0;
                int rightDoubleElementIndex = doubleArray.Length - 1;

                Console.Write("Double:\t\t");
                QuicksortAlgorithmTester.QuicksortAlgorithm(doubleArray, leftDoubleElementIndex, rightDoubleElementIndex);
            });

            DisplayExecutionTime(() =>
            {
                string[] stringArray = { "c", "test", "off", "a", "g", "debug", "int", "a", "c", "help", "off", "common", "sql", "git", "float", "char", "team", "file", "start", "int" };
                int leftStringElementIndex = 0;
                int rightStringElementIndex = stringArray.Length - 1;

                Console.Write("String:\t\t");
                QuicksortAlgorithmTester.QuicksortAlgorithm(stringArray, leftStringElementIndex, rightStringElementIndex);
            });

            Console.WriteLine();
            #endregion
        }
    }
}
