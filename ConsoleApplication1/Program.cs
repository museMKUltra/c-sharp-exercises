using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            arrayList.Add(1); // boxing happened, it's an object
            arrayList.Add("Mosh");
            arrayList.Add(DateTime.Today);

            var list = new List<int>();
            list.Add(1); // no boxing, it's an integer
        }
    }
}