using System;

namespace ConsoleApplication1.Delegates
{
    public static class Program
    {
        public static void Run()
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilter();
            // PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            processor.Process("url", filterHandler);
        }

        private static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("RemoveRedEyeFilter");
        }
    }
}