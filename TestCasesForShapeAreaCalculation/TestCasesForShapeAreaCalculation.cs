using System;
using Xunit;
using ShapeAreaCalculation;

namespace TestCasesForShapeAreaCalculation
{
    public class TestCasesForShapeAreaCalculation
    {
        [Fact]
        public void TestRectangle()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Assert.Equal(12, rectangle.CalculateArea());
        }
        [Fact]
        public void TestCircle()
        {
            Circle circle = new Circle(2);
            Assert.Equal(12.56, circle.CalculateArea());
        }
        [Fact]
        public void TestSqaure()
        {
            Square square = new Square(5);
            Assert.Equal(25, square.CalculateArea());
        }
        [Fact]
        public void TestTriangleWithBaseAndHeight()
        {
            Triangle triangle = new Triangle(5, 10);
            Assert.Equal(25, triangle.CalculateArea());
        }
        [Fact]
        public void TestTriangleWithSides()
        {
            Triangle triangle = new Triangle(3,4,5);
            Assert.Equal(6, triangle.CalculateArea());
        }
    }
}
