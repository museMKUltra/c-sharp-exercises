using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal static class Program
    {
        // if don't add async on Main function
        // then it will end up application
        // before the asynchronous process finished
        public static async Task Main(string[] args)
        {
            await MainWindow.Program.RunAsync();
        }

        // public static void Main(string[] args)
        // {
        //     MainWindow.Program.Run();
        // }
    }
}