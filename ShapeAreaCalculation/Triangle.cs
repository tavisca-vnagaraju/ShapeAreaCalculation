using System;

namespace ShapeAreaCalculation
{
    public class Triangle: IShape
    {
        double triangleBase;
        double triangleHeight;

        public Triangle(double triangleBase, double triangleHeight)
        {
            this.triangleBase = triangleBase;
            this.triangleHeight = triangleHeight;
        }
        public Triangle(double side1,double side2,double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            this.triangleBase = Math.Sqrt(s * (s - side1)) * 2;
            this.triangleHeight = Math.Sqrt((s - side2) * (s - side3));
        }
        public double CalculateArea()
        {
            return 0.5 * this.triangleBase * this.triangleHeight;
        }
    }
}