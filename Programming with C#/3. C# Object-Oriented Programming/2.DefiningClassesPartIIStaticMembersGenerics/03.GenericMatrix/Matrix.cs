using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericMatrix
{
    public class Matrix<T>
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        // Fields
        private int row;
        private int col;
        private T[,] matrix;

        // Properties
        public int Row 
        {
            get { return this.row; }
            set { this.row = value; } 
        }

        public int Col 
        {
            get { return this.col; }
            set { this.col = value; } 
        }

        // Constructor
        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentOutOfRangeException("Negative row or negative col value!");
            }
            else
            {
                this.row = row;
                this.col = col;
                this.matrix = new T[row, col];
            }
        }

        // Declare indexer
        public T this[int inputRow, int inputCol]
        {
            get 
            {
                if ((inputRow < 0 || inputCol < 0) || (inputRow > Row || inputCol > Col))
                {
                    throw new ArgumentOutOfRangeException("Index out of range!"); 
                }
                else
                {
                    return matrix[inputRow, inputCol];
                }
            }
            set 
            {
                if (inputRow < 0 || inputCol < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range!");
                }
                else
                {
                    matrix[inputRow, inputCol] = value;
                }
            }
        }

        // Overload operator + (plus)
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Row == secondMatrix.Row && firstMatrix.Col == secondMatrix.Col)
            {
                Matrix<T> currentMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

                for (int row = 0; row < firstMatrix.Row; row++)
                {
                    for (int col = 0; col < firstMatrix.Col; col++)
                    {
                        currentMatrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                    }
                }

                return currentMatrix;
            }
            else
            {
                throw new IndexOutOfRangeException("The matrix's are not with the same row and col length!");
            }
        }

        // Overload operator - (minus)
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Row == secondMatrix.Row && firstMatrix.Col == secondMatrix.Col)
            {
                Matrix<T> currentMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

                for (int row = 0; row < firstMatrix.Row; row++)
                {
                    for (int col = 0; col < firstMatrix.Col; col++)
                    {
                        currentMatrix[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                    }
                }

                return currentMatrix;
            }
            else
            {
                throw new IndexOutOfRangeException("The matrix's are not with the same row and col length!");
            }
        }

        // Overload operator * (multiplication)
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Row == secondMatrix.Row && firstMatrix.Col == secondMatrix.Col)
            {
                Matrix<T> currentMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

                for (int row = 0; row < firstMatrix.Row; row++)
                {
                    for (int col = 0; col < firstMatrix.Col; col++)
                    {
                        currentMatrix[row, col] = (dynamic)firstMatrix[row, col] * secondMatrix[row, col];
                    }
                }

                return currentMatrix;
            }
            else
            {
                throw new IndexOutOfRangeException("The matrix's are not with the same row and col length!");
            }
        }

        // Overload operator true
        public static Boolean operator true(Matrix<T> currentMatrix)
        {
            bool check = false;

            for (int row = 0; row < currentMatrix.Row; row++)
            {
                for (int col = 0; col < currentMatrix.Col; col++)
                {
                    if ((dynamic)currentMatrix[row, col] == 0)
                    {
                        check = true;
                        break;
                    }
                }
            }

            return check;
        }

        // Overload operator false
        public static Boolean operator false(Matrix<T> currentMatrix)
        {
            bool check = false;

            for (int row = 0; row < currentMatrix.Row; row++)
            {
                for (int col = 0; col < currentMatrix.Col; col++)
                {
                    if ((dynamic)currentMatrix[row, col] == 0)
                    {
                        check = true;
                        break;
                    }
                }
            }

            return check;
        }

        // Print the given matrix
        public void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,6}", matrix[row,col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}
