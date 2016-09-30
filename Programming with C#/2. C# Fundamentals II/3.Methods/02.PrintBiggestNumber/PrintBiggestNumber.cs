//02.Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

    class PrintBiggestNumber
    {
        static void GetMax(int temp, int thirdNumber)
        {
            int biggerNumber = Math.Max(temp, thirdNumber);
            Console.WriteLine("The biggest number is: " + biggerNumber);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int temp = Math.Max(firstNumber, secondNumber);

            GetMax(temp, thirdNumber);
        }
    }

