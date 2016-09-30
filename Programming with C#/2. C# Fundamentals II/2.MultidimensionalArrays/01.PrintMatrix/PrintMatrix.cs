//01.Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

    class PrintMatrix
    {
        //A)
        public static void MatrixTypeA(int[,] matrix, int n)
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter++;
                }
            }
            PrintMatrixTypes(matrix, n);
        }

        //B)
        public static void MatrixTypeB(int[,] matrix, int n)
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((col % 2) == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = counter++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0)-1; row >=  0; row--)
                    {
                        matrix[row, col] = counter++;
                    }
                }               
            }
            PrintMatrixTypes(matrix, n);
        }

        //C)
        public static void MatrixTypeC(int[,] matrix, int n)
        {
            int counter = 1;
            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n - row; col++)
                {
                    matrix[row + col, col] = counter++;
                }
            }
            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    matrix[row, col + row] = counter++;
                }
            }
            PrintMatrixTypes(matrix, n);
        }

        //D)
        public static void MatrixTypeD(int[,] matrix, int n)
        {
            int counter = 1;
            for (int index = 0; index <= n / 2; index++)
            {
                for (int row = index; row < n - index; row++)
                {
                    matrix[row, index] = counter++;
                }
                for (int col = index; col < n - index; col++)
                {
                    matrix[n - index, col] = counter++;
                }
                for (int row = n - index; row > index; row--)
                {
                    matrix[row, n - index] = counter++;
                }
                for (int col = n - index; col > index; col--)
                {
                    matrix[index, col] = counter++;
                }
            }
            if ((n & 1) == 0)
            {
                matrix[n / 2, n / 2] = counter;
            }
            PrintMatrixTypes(matrix, n);
        } 

        //Print all types
        public static void PrintMatrixTypes(int[,] matrix, int n)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            Console.WriteLine("A)");
            MatrixTypeA(matrix, n);

            Console.WriteLine("B)");
            MatrixTypeB(matrix, n);

            Console.WriteLine("C)");
            MatrixTypeC(matrix, n);

            Console.WriteLine("D)");
            MatrixTypeD(matrix,n - 1);
        }
    }

