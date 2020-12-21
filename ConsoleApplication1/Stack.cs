using System;
using System.Collections;

namespace ConsoleApplication1
{
    public class Stack
    {
        private ArrayList StackList { get; set; }

        public Stack()
        {
            StackList = new ArrayList();
        }

        private void Push(object obj)
        {
            StackList.Add(obj);
        }

        private object Pop()
        {
            if (StackList.Count == 0)
            {
                Console.WriteLine("No element to delete...");
                return null;
            }

            var pop =  StackList[StackList.Count - 1];
            StackList.RemoveAt(StackList.Count - 1);
            return pop;
        }

        private void Clear()
        {
            StackList.Clear();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter 'push', 'pop', 'check', 'clear' or press Enter directly to exit:");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Thanks for your attention...");
                    break;
                }

                switch (input)
                {
                    case "push":
                        PushProcess();
                        break;
                    case "pop":
                        Console.WriteLine(Pop());
                        break;
                    case "check":
                        Check();
                        break;
                    case "clear":
                        Clear();
                        break;
                    default:
                        Console.WriteLine("Please enter wright command...");
                        break;
                }
            }
        }

        private void Check()
        {
            foreach (var stack in StackList) Console.WriteLine(stack);
        }

        private void PushProcess()
        {
            Console.WriteLine("Enter message:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                throw new InvalidOperationException();
            Push((object) input);
        }
    }
}