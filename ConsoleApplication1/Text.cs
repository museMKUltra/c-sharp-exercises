using System;

namespace ConsoleApplication1
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink()
        {
            Console.WriteLine("AddHyperlink");
        }
    }
}