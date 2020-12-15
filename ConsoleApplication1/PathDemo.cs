using System;
using System.IO;

namespace ConsoleApplication1
{
    public static class PathDemo
    {
        public static void Demonstration()
        {
            const string path = @"/Users/roller/RiderProjects/ConsoleApplication1/README.md";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine(extension); // .md

            Console.WriteLine(Path.GetExtension(path)); // .md
            Console.WriteLine(Path.GetFileName(path)); // README.md
            Console.WriteLine(Path.GetFileNameWithoutExtension(path)); // README
            Console.WriteLine(Path.GetDirectoryName(path)); // /Users/roller/RiderProjects/ConsoleApplication1
        }
    }
}