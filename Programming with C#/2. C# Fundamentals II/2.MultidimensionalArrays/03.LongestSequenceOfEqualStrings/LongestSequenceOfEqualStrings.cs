//03.We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor 
//elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal 
//strings in the matrix.

using System;

    class LongestSequenceOfEqualStrings
    {
        static void Main(string[] args)
        {

            Console.Write("Enter N (numbers of rows): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter M (numbers of colomns: ");
            int m = int.Parse(Console.ReadLine());

            string[,] Matrix = new string[n, m];

            Console.WriteLine("Insert elements...");
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Console.Write("[{0},{1}]-> ", row, col);
                    Matrix[row, col] = Console.ReadLine();
                }
            }

            int maxCount = 0;
            string maxString = "";
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    int countX = 0;
                    int countY = 0;

                    while (row + countX < Matrix.GetLength(0))
                    {
                        if (Matrix[row, col] == Matrix[row + countX, col])
                        {
                            countX++;
                        }
                        else
                            break;
                    }
                    if (countX + 1 > maxCount)
                    {
                        maxCount = countX;
                        maxString = Matrix[row, col];
                    }
                    while (col + countY < Matrix.GetLength(1))
                    {
                        if (Matrix[row, col] == Matrix[row, col + countY])
                        {
                            countY++;
                        }
                        else
                            break;
                    }
                    if (countY + 1 > maxCount)
                    {
                        maxCount = countY;
                        maxString = Matrix[row, col];
                    }
                    countX = 0;
                    while (row + countX < Matrix.GetLength(0) && col + countX < Matrix.GetLength(1))
                    {
                        if (Matrix[row, col] == Matrix[row + countX, col + countX])
                        {
                            countX++;
                        }
                        else
                            break;
                    }
                    if (countX + 1 > maxCount)
                    {
                        maxCount = countX;
                        maxString = Matrix[row, col];
                    }
                }
            }
            Console.Write("The elemets are:  {0}", maxString);
            for (int i = 1; i < maxCount; i++)
            {
                Console.Write(",{0}", maxString);
            }
            Console.WriteLine();
        }
    }

