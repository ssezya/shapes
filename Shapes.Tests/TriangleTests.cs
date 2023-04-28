using System;
using NUnit.Framework;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Triangle_NegativeLengthSides_ArgumentExcepion()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-5, 5, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(5, -5, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(5, 5, -5));
        }

        [Test]
        public void Triangle_ZeroLengthSides_ArgumentExcepion()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 5, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(5, 0, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(5, 5, 0));
        }

        [Test]
        public void Triangle_SumOfTwoSidesIsLessThanThird_ArgumentExcepion()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(2, 2, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(5, 3, 2));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 5, 3));
        }

        [Test]
        public void Triangle_PerimeterFromSides()
        {
            // Arrange
            Triangle triangle = new Triangle(4, 5, 7);

            // Act
            double perimeter = triangle.Perimeter;

            // Assert
            Assert.AreEqual(16, perimeter);
        }

        [Test]
        public void Triangle_CalculateAreaFromSides()
        {
            // Arrange
            Triangle triangle = new Triangle(4, 5, 7);

            // Act
            double area = triangle.Area;

            // Assert
            Assert.AreEqual(9.797958971132712, area);
        }

        [Test]
        public void Triangle_IsRectangular_True()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRectangular = triangle.IsRectangular;

            // Assert
            Assert.AreEqual(true, isRectangular);
        }

        [Test]
        public void Triangle_IsRectangular_False()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 4);

            // Act
            bool isRectangular = triangle.IsRectangular;

            // Assert
            Assert.AreEqual(false, isRectangular);
        }
    }
}
