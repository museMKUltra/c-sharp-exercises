using System;

namespace ConsoleApplication1.MethodOverriding
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing triangle...");
        }
    }
}