using System;
using System.Collections.Generic;

namespace ConsoleApplication1.MethodOverriding
{
    public static class Program
    {
        public static void Run()
        {
            var canvas = new Canvas();

            var shapeList = new List<Shape>();
            var circleShape = new Shape(); // ShapeType default use first element
            var rectangleShape = new Shape() {Type = ShapeType.Rectangle};
            var triangleShape = new Shape() {Type = ShapeType.Triangle};
            shapeList.Add(circleShape);
            shapeList.Add(rectangleShape);
            shapeList.Add(triangleShape);
            canvas.DrawShapes(shapeList);
            Console.WriteLine();

            var shapes = new List<Shape>();
            var circle = new Circle();
            var rectangle = new Rectangle();
            var triangle = new Triangle();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            canvas.Draw(shapes);
        }
    }
}