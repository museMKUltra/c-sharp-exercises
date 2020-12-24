using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApplication1.MainWindow
{
    public static class Program
    {
        public static async Task RunAsync()
        {
            const string url = @"https://www.microsoft.com/zh-tw/";
            const string path = @"/Users/roller/Desktop/result.html";
            try
            {
                Console.WriteLine("start to download...");
                await DownloadHtmlAsync(url, path);
                Console.WriteLine("end up writing...");
                DeleteHtml(path);
                Console.WriteLine();

                Console.WriteLine("start to download...");
                var getHtmlTask = GetHtmlAsync(url);
                Console.WriteLine("html is downloading..."); // some works not depend on async
                var html = await getHtmlTask;
                Console.WriteLine(html.Substring(0, 100));
                Console.WriteLine("end up printing...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Run()
        {
            const string url = @"https://www.microsoft.com/zh-tw/";
            const string path = @"/Users/roller/Desktop/result.html";
            try
            {
                Console.WriteLine("start to download...");
                DownloadHtml(url, path);
                Console.WriteLine("end up writing...");
                DeleteHtml(path);
                Console.WriteLine();

                Console.WriteLine("start to download...");
                var html = GetHtml(url);
                Console.WriteLine(html.Substring(0, 100));
                Console.WriteLine("end up printing...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // use Generic form by string -> Task<string>
        private static async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        private static string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        // use Non-Generic form by void -> Task
        private static async Task DownloadHtmlAsync(string url, string path)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(path))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        private static void DownloadHtml(string url, string path)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(html);
            }
        }

        private static void DeleteHtml(string path)
        {
            var fileInfo = new FileInfo(path);
            fileInfo.Delete();
        }
    }
}