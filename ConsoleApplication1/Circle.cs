using System;

namespace ConsoleApplication1
{
    interface IDraggable
    {
        void Drag();
    }

    interface IDroppable
    {
        void Drop();
    }

    public class Circle : Shape, IDraggable, IDroppable
    {
        public int Radius { get; set; }

        public sealed override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }

        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
}