namespace ConsoleApplication1.Math
{
    public class Calculator
    {
        public static int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers) sum += number;
            return sum;
        }

        public static void AddTow(ref int number)
        {
            number += 2;
        }

        public static void MyMethod(out int number)
        {
            number = 1;
        }
    }
}