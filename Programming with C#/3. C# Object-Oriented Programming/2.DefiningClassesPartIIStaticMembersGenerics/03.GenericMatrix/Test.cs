//08.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

//09.Implement an indexer this[row, col] to access the inner matrix cells.

//10.Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
//Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericMatrix
{
    class Test
    {
        static void Main(string[] args)
        {
            // ---------- Matrices with integer numbers ----------
            Matrix<int> firstIntegerMatrix = new Matrix<int>(3, 3);

            Console.WriteLine(" ---------- Matrices with integer numbers ----------\n");

            firstIntegerMatrix[0, 0] = 0;
            firstIntegerMatrix[0, 1] = 2;
            firstIntegerMatrix[0, 2] = 3;

            firstIntegerMatrix[1, 0] = 4;
            firstIntegerMatrix[1, 1] = 5;
            firstIntegerMatrix[1, 2] = 6;

            firstIntegerMatrix[2, 0] = 7;
            firstIntegerMatrix[2, 1] = 8;
            firstIntegerMatrix[2, 2] = 9;

            // Check if the given matrix contain zero number, with overload true operator in Matrix class, 
            // return true if there is a zero, return false - if not
            if (firstIntegerMatrix)
            {
                Console.WriteLine("There IS a zero number in the first matrix!");
            }
            else
            {
                Console.WriteLine("There is NOT a zero number in the first matrix!");
            }

            Matrix<int> secondIntegerMatrix = new Matrix<int>(3, 3);

            secondIntegerMatrix[0, 0] = 1;
            secondIntegerMatrix[0, 1] = 2;
            secondIntegerMatrix[0, 2] = 3;

            secondIntegerMatrix[1, 0] = 4;
            secondIntegerMatrix[1, 1] = 5;
            secondIntegerMatrix[1, 2] = 6;

            secondIntegerMatrix[2, 0] = 7;
            secondIntegerMatrix[2, 1] = 8;
            secondIntegerMatrix[2, 2] = 9;

            // Check if the given matrix contain zero number, with overload true operator in Matrix class, 
            // return true if there is a zero, return false - if not
            if (secondIntegerMatrix)
            {
                Console.WriteLine("There IS a zero number in the second matrix!\n");
            }
            else
            {
                Console.WriteLine("There is NOT a zero number in the second matrix!\n");
            }

            // Declare current matrix
            Matrix<int> currentIntegerMatrix = new Matrix<int>(3, 3);

            // Sum of the two matrices
            currentIntegerMatrix = firstIntegerMatrix + secondIntegerMatrix;
            Console.WriteLine("The sum of the two matrices is: ");
            currentIntegerMatrix.PrintMatrix();

            // Substraction of the two matrices
            currentIntegerMatrix = firstIntegerMatrix - secondIntegerMatrix;
            Console.WriteLine("The substraction of the two matrices is: ");
            currentIntegerMatrix.PrintMatrix();

            // Multiplication of the two matrices
            currentIntegerMatrix = firstIntegerMatrix * secondIntegerMatrix;
            Console.WriteLine("The multiplication of the two matrices is: ");
            currentIntegerMatrix.PrintMatrix();


            // ---------- Matrices with double numbers ----------
            Matrix<double> firstDoubleMatrix = new Matrix<double>(4, 4);

            Console.WriteLine(" ---------- Matrices with double numbers ----------\n");

            firstDoubleMatrix[0, 0] = 1.1;
            firstDoubleMatrix[0, 1] = 1.1;
            firstDoubleMatrix[0, 2] = 1.1;
            firstDoubleMatrix[0, 3] = 1.1;

            firstDoubleMatrix[1, 0] = 1.1;
            firstDoubleMatrix[1, 1] = 1.1;
            firstDoubleMatrix[1, 2] = 1.1;
            firstDoubleMatrix[1, 3] = 1.1;

            firstDoubleMatrix[2, 0] = 1.1;
            firstDoubleMatrix[2, 1] = 1.1;
            firstDoubleMatrix[2, 2] = 1.1;
            firstDoubleMatrix[2, 3] = 1.1;

            firstDoubleMatrix[3, 0] = 1.1;
            firstDoubleMatrix[3, 1] = 1.1;
            firstDoubleMatrix[3, 2] = 1.1;
            firstDoubleMatrix[3, 3] = 1.1;

            // Check if the given matrix contain zero number, with overload true operator in Matrix class, 
            // return true if there is a zero, return false - if not
            if (firstDoubleMatrix)
            {
                Console.WriteLine("There IS a zero number in the first matrix!");
            }
            else
            {
                Console.WriteLine("There is NOT a zero number in the first matrix!");
            }

            Matrix<double> secondDoubleMatrix = new Matrix<double>(4, 4);

            secondDoubleMatrix[0, 0] = 1.1;
            secondDoubleMatrix[0, 1] = 1.1;
            secondDoubleMatrix[0, 2] = 1.1;
            secondDoubleMatrix[0, 3] = 1.1;

            secondDoubleMatrix[1, 0] = 1.1;
            secondDoubleMatrix[1, 1] = 1.1;
            secondDoubleMatrix[1, 2] = 0;
            secondDoubleMatrix[1, 3] = 1.1;

            secondDoubleMatrix[2, 0] = 1.1;
            secondDoubleMatrix[2, 1] = 1.1;
            secondDoubleMatrix[2, 2] = 1.1;
            secondDoubleMatrix[2, 3] = 1.1;

            secondDoubleMatrix[3, 0] = 1.1;
            secondDoubleMatrix[3, 1] = 1.1;
            secondDoubleMatrix[3, 2] = 1.1;
            secondDoubleMatrix[3, 3] = 1.1;

            // Check if the given matrix contain zero number, with overload true operator in Matrix class, 
            // return true if there is a zero, return false - if not
            if (secondDoubleMatrix)
            {
                Console.WriteLine("There IS a zero number in the second matrix!\n");
            }
            else
            {
                Console.WriteLine("There is NOT a zero number in the second matrix!\n");
            }

            // Declare current matrix
            Matrix<double> currentDoubleMatrix = new Matrix<double>(4, 4);

            // Sum of the two matrices
            currentDoubleMatrix = firstDoubleMatrix + secondDoubleMatrix;
            Console.WriteLine("The sum of the two matrices is: ");
            currentDoubleMatrix.PrintMatrix();

            // Substraction of the two matrices
            currentDoubleMatrix = firstDoubleMatrix - secondDoubleMatrix;
            Console.WriteLine("The substraction of the two matrices is: ");
            currentDoubleMatrix.PrintMatrix();

            // Multiplication of the two matrices
            currentDoubleMatrix = firstDoubleMatrix * secondDoubleMatrix;
            Console.WriteLine("The multiplication of the two matrices is: ");
            currentDoubleMatrix.PrintMatrix();
        }
    }
}
