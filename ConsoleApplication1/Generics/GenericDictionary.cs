using System.Collections.Generic;

namespace ConsoleApplication1.Generics
{
    public class GenericDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

        public TValue this[TKey key]
        {
            get { return _dictionary[key]; }
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }
    }
}