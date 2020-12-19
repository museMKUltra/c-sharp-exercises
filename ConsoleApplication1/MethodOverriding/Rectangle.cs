using System;

namespace ConsoleApplication1.MethodOverriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
}