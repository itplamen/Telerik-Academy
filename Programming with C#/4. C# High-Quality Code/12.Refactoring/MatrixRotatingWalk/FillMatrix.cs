namespace MatrixRotatingWalk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FillMatrix
    {
        private const int LAST_POSITION_INDEX = 7;
        private const int MIN_DIMENSION_SIZE = 1;
        private const int MAX_DIMENSION_SIZE = 100;
        private Dictionary<Directions, Coordinates> availablePositions = new Dictionary<Directions, Coordinates>();

        public FillMatrix(int dimension)
        {
            if (dimension < MIN_DIMENSION_SIZE || dimension > MAX_DIMENSION_SIZE)
            {
                throw new ArgumentOutOfRangeException("Matrix dimension is NOT in the corect range {" + MIN_DIMENSION_SIZE + " .. " + MAX_DIMENSION_SIZE + "}");
            }

            this.Matrix = new int[dimension, dimension];
            this.Row = 0;
            this.Column = 0;
            this.CurrentRow = 1;
            this.CurrentColumn = 1;
            this.Number = 1;
        }

        public int[,] Matrix { get; private set; }

        public int Row { get; private set; }

        public int Column { get; private set; }

        public int CurrentRow { get; private set; }

        public int CurrentColumn { get; private set; }

        public int Number { get; private set; }

        public void FillMatrixWithNumbers()
        {
            while (true)
            {
                this.Matrix[this.Row, this.Column] = this.Number;

                if (this.IsAvailableDirection() == false)
                {
                    break;
                }

                while (this.Row + this.CurrentRow >= this.Matrix.GetLength(0) || this.Row + this.CurrentRow < 0 ||
                    this.Column + this.CurrentColumn >= this.Matrix.GetLength(1) || this.Column + this.CurrentColumn < 0 ||
                    this.Matrix[this.Row + this.CurrentRow, this.Column + this.CurrentColumn] != 0)
                {
                    this.ChangeDirection();
                }

                this.Row += this.CurrentRow;
                this.Column += this.CurrentColumn;
                this.Number++;
            }

            this.FindEmptyCell();

            if (this.Row != 0 && this.Column != 0)
            {
                this.CurrentRow = 1;
                this.CurrentColumn = 1;
                this.Number++;
                this.FillMatrixWithNumbers();
            }
        }

        private bool IsAvailableDirection()
        {
            this.Position();

            foreach (var position in this.availablePositions)
            {
                if (this.Row + position.Value.X >= this.Matrix.GetLength(0) || this.Row + position.Value.X < 0)
                {
                    position.Value.X = 0;
                }

                if (this.Column + position.Value.Y >= this.Matrix.GetLength(0) || this.Column + position.Value.Y < 0)
                {
                    position.Value.Y = 0;
                }
            }

            foreach (var position in this.availablePositions)
            {
                if (this.Matrix[this.Row + position.Value.X, this.Column + position.Value.Y] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void ChangeDirection()
        {
            this.Position();

            int positionIndex = 0;

            foreach (var position in this.availablePositions)
            {
                if (position.Value.X == this.CurrentRow && position.Value.Y == this.CurrentColumn)
                {
                    if (positionIndex == LAST_POSITION_INDEX)
                    {
                        this.CurrentRow = 1;
                        this.CurrentColumn = 1;
                        return;
                    }

                    break;
                }

                positionIndex++;
            }

            int nextPositionIndex = 0;

            foreach (var position in this.availablePositions)
            {
                if (nextPositionIndex == (positionIndex + 1))
                {
                    this.CurrentRow = position.Value.X;
                    this.CurrentColumn = position.Value.Y;
                    break;
                }

                nextPositionIndex++;
            }
        }

        public void FindEmptyCell()
        {
            this.Row = 0;
            this.Column = 0;

            for (int row = 0; row < this.Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.Matrix.GetLength(1); col++)
                {
                    if (this.Matrix[row, col] == 0)
                    {
                        this.Row = row;
                        this.Column = col;
                        return;
                    }
                }
            }
        }

        private void Position()
        {
            this.availablePositions[Directions.SouthEast] = new Coordinates(1, 1);
            this.availablePositions[Directions.South] = new Coordinates(1, 0);
            this.availablePositions[Directions.SouthWest] = new Coordinates(1, -1);
            this.availablePositions[Directions.West] = new Coordinates(0, -1);
            this.availablePositions[Directions.NorthWest] = new Coordinates(-1, -1);
            this.availablePositions[Directions.North] = new Coordinates(-1, 0);
            this.availablePositions[Directions.NorthEast] = new Coordinates(-1, 1);
            this.availablePositions[Directions.East] = new Coordinates(0, 1);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < this.Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.Matrix.GetLength(1); col++)
                {
                    builder.AppendFormat("{0,3}", this.Matrix[row, col]);
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
