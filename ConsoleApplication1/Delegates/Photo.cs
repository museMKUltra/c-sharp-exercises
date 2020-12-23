using System;

namespace ConsoleApplication1.Delegates
{
    public class Photo
    {
        private object _path;

        private Photo(string path)
        {
            _path = path;
        }

        public static Photo Load(string path)
        {
            return new Photo(path);
        }

        public void Save()
        {
            Console.WriteLine("Save");
        }
    }
}