namespace MatrixRotatingWalk.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CoordinatesTests
    {
        [TestMethod]
        public void Constructor_CorrectCoordinates()
        {
            Coordinates coordinates = new Coordinates(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_XValueSmallerThanMinimalAllowedCoordinateValue()
        {
            Coordinates coordinates = new Coordinates(-5, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_XValueBiggerThanMaximallAllowedCoordinateValue()
        {
            Coordinates coordinates = new Coordinates(3, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_YValueSmallerThanMinimalAllowedCoordinateValue()
        {
            Coordinates coordinates = new Coordinates(0, -4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_YValueBiggerThanMaximalAllowedCoordinateValue()
        {
            Coordinates coordinates = new Coordinates(0, 2);
        }
    }
}
