using System;

namespace ConsoleApplication1
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public sealed override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}