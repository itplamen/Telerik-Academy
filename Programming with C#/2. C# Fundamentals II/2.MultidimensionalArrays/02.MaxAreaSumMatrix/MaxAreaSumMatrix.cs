//02.Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has 
//maximal sum of its elements.

using System;

    class MaxAreaSumMatrix
    {
        public static int GetSize(string p)
        {
            int n = 0;
            Console.Write("Enter size {0} >= 3: ", p);
            if (int.TryParse(Console.ReadLine(), out n) && n >= 3)
            {
                return n;
            }
            else
            {
                Console.WriteLine("\nError. Please try again.\n");
                return 3;
            }
        }
        public static int[,] GetMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Enter Matrix[{0},{1}]: ", row, col);
                    int.TryParse(Console.ReadLine(), out matrix[row, col]);
                }
            }
            return matrix;
        }
        public static void GetMaxSumMatrix(int[,] matrix, int rows, int cols)
        {
            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = 0;
                    for (int i = row; i <= row + 2; i++)
                    {
                        for (int j = col; j <= col + 2; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            printMatrix(matrix, startRow, startCol);
        }
        public static void printMatrix(int[,] matrix, int row, int col)
        {
            Console.WriteLine("\nThe 3x3 matrix with the maximal sum is:");
            for (int i = row; i <= row + 2; i++)
            {
                for (int j = col; j <= col + 2; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = GetSize("N");
            int m = GetSize("M");
            int[,] matrix = GetMatrix(n, m);
            GetMaxSumMatrix(matrix, n, m);
        }
    }

