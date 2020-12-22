using System.Collections.Generic;

namespace ConsoleApplication1.Generics
{
    public class GenericList<T>
    {
        private readonly List<T> _genericList = new List<T>();

        public T this[int index]
        {
            get { return _genericList[index]; }
        }

        public void Add(T value)
        {
            _genericList.Add(value);
        }
    }
}