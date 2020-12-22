namespace ConsoleApplication1.Generics
{
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        public bool HasValue
        {
            get { return _value != null; }
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public Nullable()
        {
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T) _value;
            return default;
        }
    }
}