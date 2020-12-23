namespace ConsoleApplication1.DynamicBinding
{
    public static class Program
    {
        public static void Run()
        {
            object obj = "Mosh";
            // obj.GetHashCode();

            // how to use reflection to get hash code
            // var methodInfo = obj.GetType().GetMethod("GetHashCode");
            // methodInfo.Invoke(null, null);
            // it's a little difficult and messy

            // dynamic excelObject = "Mosh";
            // excelObject.Optimize();
            // dynamic is easier

            dynamic name = "Mosh";
            name = 10;

            dynamic a = 1;
            dynamic b = 2;
            var c = a + b;

            int i = 5;
            dynamic d = i;
            long l = d;
        }
    }
}