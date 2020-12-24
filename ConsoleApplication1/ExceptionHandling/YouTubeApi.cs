using System;
using System.Collections.Generic;

namespace ConsoleApplication1.ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of Video objects
                // ...
                // throw new Exception("Oops, some low level YouTube error...");
            }
            catch (Exception e)
            {
                // Log
                // ...
                const string msg = "Could not fetch videos from YouTube.";
                throw new YouTubeException(msg, e);
                // msg for specific description, e for problem shooting
            }

            return new List<Video>();
        }
    }
}