using System.Collections;

namespace ConsoleApplication1.Generics
{
    public class ObjectList
    {
        private readonly ArrayList _arrayList = new ArrayList();

        public object this[int index]
        {
            get { return _arrayList[index]; }
        }

        public void Add(object value)
        {
            _arrayList.Add(value);
        }
    }
}