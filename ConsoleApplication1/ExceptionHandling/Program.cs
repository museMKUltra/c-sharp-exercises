using System;
using System.IO;

namespace ConsoleApplication1.ExceptionHandling
{
    public static class Program
    {
        public static void Run()
        {
            try
            {
                var calculator = new Calculator();
                calculator.Divide(5, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by 0...");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Something wrong with arithmetic...");
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an exception error occured...");
            }

            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"/Users/roller/Desktop/ideavimrc/README.md");
                var content = streamReader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an exception error occured...");
            }
            finally
            {
                streamReader?.Dispose(); // make sure streaming be closed even catch an exception
                // If anything goes wrong in the try block, make sure the stream to be closed, 
                // because managing situation properly is important, otherwise it might end up with keeping files open on the disk, network connection or get rid of resources.
            }

            // using keyword is another simpler way
            try
            {
                using (var reader = new StreamReader(@"/Users/roller/Desktop/ideavimrc/README.md"))
                {
                    var content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an exception error occured...");
            }

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Mosh");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // Could not fetch videos from YouTube.
                Console.WriteLine(e.InnerException?.Message); // Oops, some low level YouTube error...
            }
        }
    }
}