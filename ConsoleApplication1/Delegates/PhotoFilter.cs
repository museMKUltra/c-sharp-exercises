using System;

namespace ConsoleApplication1.Delegates
{
    public class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("ApplyBrightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("ApplyContrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }
}