using System;

namespace ConsoleApplication1.MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("drawing circle...");
        }
    }
}