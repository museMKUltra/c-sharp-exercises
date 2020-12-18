using System;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle();
            Shape shape = circle;
            
            circle.Width = 100;
            shape.Width = 200;
            Console.WriteLine(circle.Width);
            
            Circle directCircle = (Circle) shape;
            
            Circle asCircle = shape as Circle;
            if (asCircle != null)
            {
                Console.WriteLine("down casting successfully");
            }
            
            if (shape is Circle)
            {
                Circle isCircle = (Circle) shape;
            }
        }
    }
}