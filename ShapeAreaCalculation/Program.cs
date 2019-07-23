using System;

namespace ShapeAreaCalculation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(2);
            Rectangle rectangle = new Rectangle(3,4);
            Square square = new Square(5);
            Triangle triangle = new Triangle(5,10);
            Triangle triangle2 = new Triangle(3,4,5);



            Console.WriteLine("Area of circle : "+circle.CalculateArea());
            Console.WriteLine("Area of Rectangle :"+rectangle.CalculateArea());
            Console.WriteLine("Area of Square :" + square.CalculateArea());
            Console.WriteLine("Area of Triangle :" + triangle2.CalculateArea());

            Console.ReadKey();
        }
    }
}
