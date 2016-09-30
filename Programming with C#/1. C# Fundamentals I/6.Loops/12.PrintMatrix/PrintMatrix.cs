//12.Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//    N = 3			N = 4

//    1 2 3         1 2 3 4
//    2 3 4         2 3 4 5 
//    3 4 5         3 4 5 6
//                  4 5 6 7

using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter positive integer number N (N < 20) : ");
        uint n = uint.Parse(Console.ReadLine());

        if (n >= 20 || n == 0)
        {
            Console.WriteLine("ERROR. N must be (N < 20). Try again...");
            Console.WriteLine();
            Main();
        }
        else
        {
            int firstRowNumber = 1;
            uint secondNumber = n;

            for (int i = 1; i <= n; i++)
            {
                for (int j = firstRowNumber; j <= secondNumber; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
                secondNumber++;
                firstRowNumber++;
            }
        }
    }
}

