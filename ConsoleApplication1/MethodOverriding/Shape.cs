using System;

namespace ConsoleApplication1.MethodOverriding
{
    public class Shape
    {
        public ShapeType Type { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("drawing shape...");
        }
    }
}