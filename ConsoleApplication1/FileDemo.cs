using System;
using System.IO;

namespace ConsoleApplication1
{
    public static class FileDemo
    {
        public static void Demonstration()
        {
            const string source = @"/Users/roller/RiderProjects/ConsoleApplication1/README.md";
            const string dest = @"/Users/roller/Desktop/README.md";

            File.Copy(source, dest, true);
            if (File.Exists(dest))
            {
                var content = File.ReadAllText(dest);
                Console.WriteLine(content); // # c-sharp-exercises
            }

            File.Delete(dest);

            new FileInfo(source).CopyTo(dest);
            var fileInfo = new FileInfo(dest);

            if (fileInfo.Exists)
            {
                var content = fileInfo.OpenRead();
                Console.WriteLine(content); // System.IO.FileStream
            }

            fileInfo.Delete();
        }

        public static void Exercise1()
        {
            const string source = @"/Users/roller/RiderProjects/ConsoleApplication1/README.md";
            var content = File.ReadAllText(source);
            Console.WriteLine(content.Length);
        }
        
        public static void Exercise2()
        {
            const string source = @"/Users/roller/RiderProjects/ConsoleApplication1/README.md";
            var words = File.ReadAllText(source).Split(' ');
            var longestWord = "";
            foreach (var word in words)
                if (word.Length > longestWord.Length)
                    longestWord = word;
            Console.WriteLine(longestWord);
        }
    }
}