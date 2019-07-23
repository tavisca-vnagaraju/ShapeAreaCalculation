using System;

namespace ShapeAreaCalculation
{
    public class Square:IShape
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }
        public double CalculateArea()
        {
            return this.side * this.side;
        }
    }
}