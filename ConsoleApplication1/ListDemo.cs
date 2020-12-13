using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class ListDemo
    {
        public void Demonstration()
        {
            var list = new List<int>() {1, 2, 3, 4};

            list.Add(1);
            foreach (var l in list)
                Console.WriteLine(l);

            list.AddRange(new int[3] {5, 6, 7});
            foreach (var l in list)
                Console.WriteLine(l);

            Console.WriteLine(list.IndexOf(1));
            Console.WriteLine(list.LastIndexOf(1));

            for (var i = 0; i < list.Count; i++)
                if (list[i] == 1)
                    list.Remove(1);

            foreach (var l in list)
                Console.WriteLine(l);

            list.Clear();
            Console.WriteLine(list.Count);
        }
    }
}