using System;
using NUnit.Framework;

namespace Shapes.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Circle_NegativeOrZeroRadius_ArgumentExcepion()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Test]
        public void Circle_CalculateAreaFromRadius()
        {
            // Arrange
            Circle circle = new Circle(4);

            // Act
            double area = circle.Area;

            // Assert
            Assert.AreEqual(50.26548245743669, area);
        }
    }
}