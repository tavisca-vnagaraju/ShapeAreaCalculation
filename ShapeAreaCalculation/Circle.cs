using System;

namespace ShapeAreaCalculation
{
    public class Circle:IShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return (3.14) * this.radius * this.radius;
        }
    }
}