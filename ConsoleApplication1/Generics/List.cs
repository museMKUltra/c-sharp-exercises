using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Generics
{
    public class List
    {
        private readonly List<int> _list = new List<int>();

        public int this[string length]
        {
            get
            {
                var index = Convert.ToInt32(length) - 1;
                return _list[index];
            }
        }

        public int this[int index]
        {
            get { return _list[index]; }
        }

        public void Add(int number)
        {
            _list.Add(number);
        }
    }
}