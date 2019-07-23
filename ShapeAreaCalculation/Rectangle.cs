namespace ShapeAreaCalculation
{
    public class Rectangle:IShape
    {
        double length;
        double breadth;
        public Rectangle(double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {
            return this.length * this.breadth;
        }
    }
}