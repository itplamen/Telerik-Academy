//05. Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an 
//area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. 
//Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2

using System;
using System.IO;

    class MaximalAreaSumFromMatrix
    {
        //The file is in directory bin/Debug
        static void FindMaximalSum(int [,] matrix)
        {
            int currentSum = 0;
            int maximalSum = 0;
            int firstRow = 0;
            int firstCol = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            { 
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int row = i; row < i + 2; row++)
                    {
                        for (int col = j; col < j + 2; col++)
                        {
                            currentSum += matrix[row, col];
                        }

                    }
                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        firstRow = i;
                        firstCol = j;
                    }
                    currentSum = 0;
                }
            }
            Console.WriteLine(maximalSum);
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("sample.txt");

            string line = reader.ReadLine();
            int matrixSize = Convert.ToInt32(line);

            int[,] matrix = new int[matrixSize, matrixSize];
            int row = 0;

            using (reader)
            {
                while (line != null)
                {
                    line = reader.ReadLine();
                    
                    if (line != null)
                    {
                        string[] numbers = line.Split(' ');
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = Convert.ToInt32(numbers[col]);
                        }
                        row++; 
                    } 
                }
            }
            FindMaximalSum(matrix);
        }
    }

