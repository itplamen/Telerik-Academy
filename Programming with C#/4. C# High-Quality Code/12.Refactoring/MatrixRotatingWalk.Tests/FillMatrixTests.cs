namespace MatrixRotatingWalk.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Text;

    [TestClass]
    public class FillMatrixTests
    {
        private int dimension;
        private FillMatrix matrix;

        [TestInitialize]
        public void TestInitialize()
        {
            this.dimension = 6;
            this.matrix = new FillMatrix(this.dimension);
            this.matrix.FillMatrixWithNumbers();
        }

        [TestMethod]
        public void Constructor_CorrectDimension()
        {
            int matrixDimension = 43;
            FillMatrix fillMatrix = new FillMatrix(matrixDimension);

            Assert.AreEqual(matrixDimension, fillMatrix.Matrix.GetLength(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_IncorrectDimension()
        {
            int matrixDimension = -1;
            FillMatrix fillMatrix = new FillMatrix(matrixDimension);
        }

        [TestMethod]
        public void PrintMatrix()
        {
            int[,] expectedMatrix = 
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                 {11, 10, 9, 8, 7, 6 }
            };

            StringBuilder expected = new StringBuilder();

            for (int row = 0; row < expectedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < expectedMatrix.GetLength(1); col++)
                {
                    expected.AppendFormat("{0,3}", expectedMatrix[row, col]);
                }

                expected.AppendLine();
            }

            Assert.AreEqual(expected.ToString(), this.matrix.ToString());
        }
    }
}
