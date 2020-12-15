using System;
using System.IO;

namespace ConsoleApplication1
{
    public static class DirectoryDemo
    {
        public static void Demonstration()
        {
            const string source = @"/Users/roller/RiderProjects/ConsoleApplication1";
            const string folder = @"/Users/roller/Desktop/folder";

            // Directory
            var files = Directory.GetFiles(source, "*.sln", SearchOption.AllDirectories);
            foreach (var file in files) 
                Console.WriteLine(file);
            var directories = Directory.GetDirectories(source, ".idea", SearchOption.AllDirectories);
            foreach (var dir in directories) 
                Console.WriteLine(dir);

            Directory.CreateDirectory(folder);
            if (Directory.Exists(folder)) 
                Directory.Delete(folder);

            // DirectoryInfo
            var directoryInfo = new DirectoryInfo(source);
            foreach (var file in directoryInfo.GetFiles("*.sln", SearchOption.AllDirectories)) 
                Console.WriteLine(file);
            foreach (var dir in directoryInfo.GetDirectories(".idea", SearchOption.AllDirectories))
                Console.WriteLine(dir);

            var folderInfo = new DirectoryInfo(folder);
            folderInfo.Create();
            if (folderInfo.Exists)
                folderInfo.Delete();
        }
    }
}