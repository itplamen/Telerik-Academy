//01. Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally.

using System;

    class PrintSquareRootOfIntegerNumber
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine("The number square root is: " + Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }

