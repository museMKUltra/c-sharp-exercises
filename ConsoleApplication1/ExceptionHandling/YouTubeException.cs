using System;

namespace ConsoleApplication1.ExceptionHandling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}