namespace _14.Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Matrix
    {
        private class Cell
        {
            public int Row { get; set; }

            public int Col { get; set; }

            public string Value { get; set; }

            public Cell(int row, int col, string value)
            {
                this.Row = row;
                this.Col = col;
                this.Value = value;
            }
        }

        private const string START_POSITION = "*";
        private const string FULL_CELL = "x";
        private const string UNREACHABLE_CELL = "u";
        private const string EMPTY_CELL = "0";
        private Cell[,] matrix;

        public Matrix(int numberOfRows, int numberOfColumns)
        {
            this.matrix = new Cell[numberOfRows, numberOfColumns];
        }

        public void Add(string[,] otherMatrix)
        {
            for (int row = 0; row < otherMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < otherMatrix.GetLength(1); col++)
                {
                    Cell cell = new Cell(row, col, otherMatrix[row, col]);
                    this.matrix[row, col] = cell;
                }
            }
        }

        public void FindStartPosition()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    if (this.matrix[row, col].Value == START_POSITION)
                    {
                        this.BFS(row, col);
                        break;
                    }
                }
            }
        }

        public void Print()
        {
            for (int r = 0; r < this.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < this.matrix.GetLength(1); c++)
                {
                    Console.Write("{0,4}", this.matrix[r, c].Value);
                }

                Console.WriteLine();
            }
        }

        private void BFS(int startRow, int startCol)
        {
            Queue<Cell> queue = new Queue<Cell>();
            int number = 0;
            this.matrix[startRow, startCol].Value = number.ToString();
            queue.Enqueue(this.matrix[startRow, startCol]);

            while (queue.Count > 0)
            {
                Cell cell = queue.Dequeue();
                number = int.Parse(cell.Value);

                // Up
                if (cell.Row - 1 >= 0 && this.matrix[cell.Row - 1, cell.Col].Value == EMPTY_CELL)
                {
                    this.matrix[cell.Row - 1, cell.Col].Value = (number + 1).ToString();
                    queue.Enqueue(this.matrix[cell.Row - 1, cell.Col]);
                }

                // Down
                if (cell.Row + 1 <= this.matrix.GetLength(0) - 1 && this.matrix[cell.Row + 1, cell.Col].Value == EMPTY_CELL)
                {
                    this.matrix[cell.Row + 1, cell.Col].Value = (number + 1).ToString();
                    queue.Enqueue(this.matrix[cell.Row + 1, cell.Col]);
                }

                // Left
                if (cell.Col - 1 >= 0 && this.matrix[cell.Row, cell.Col - 1].Value == EMPTY_CELL)
                {
                    this.matrix[cell.Row, cell.Col - 1].Value = (number + 1).ToString();
                    queue.Enqueue(this.matrix[cell.Row, cell.Col - 1]);
                }

                // Right
                if (cell.Col + 1 <= this.matrix.GetLength(1) - 1 && this.matrix[cell.Row, cell.Col + 1].Value == EMPTY_CELL)
                {
                    this.matrix[cell.Row, cell.Col + 1].Value = (number + 1).ToString();
                    queue.Enqueue(this.matrix[cell.Row, cell.Col + 1]);
                }
            }

            this.matrix[startRow, startCol].Value = "*";

            // Finds all unreachable cells
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    if (this.matrix[row, col].Value == EMPTY_CELL)
                    {
                        this.matrix[row, col].Value = UNREACHABLE_CELL;
                    }
                }
            }
        }
    }
}
