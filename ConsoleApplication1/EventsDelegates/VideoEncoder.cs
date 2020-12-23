using System;
using System.Threading;

namespace ConsoleApplication1.EventsDelegates
{
    public class VideoEncoder
    {
        /*
         * 1. define a delegate
         * 2. define an event based on that delegate
         * 3. raise the event
         */

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // public event VideoEncodedEventHandler VideoEncoded;
        // or using EventHandler to combine above two lines
        public event EventHandler<VideoEventArgs> VideoEncoded;
        // EventHandler -> default args
        // EventHandler<TEventArgs> -> custom args

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() {Video = video});
            // if (VideoEncoded != null) VideoEncoded(this, new VideoEventArgs() {Video = video});
            // above two lines are the same 
        }
    }
}