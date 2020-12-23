using System;

namespace ConsoleApplication1.Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        // public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            // var filter = new PhotoFilter();
            // filter.ApplyBrightness(photo);
            // filter.ApplyContrast(photo);
            // filter.Resize(photo);
            filterHandler(photo);
            
            photo.Save();
        }
    }
}