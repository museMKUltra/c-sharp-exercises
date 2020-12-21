using System;
using System.Collections;

namespace ConsoleApplication1
{
    public class Stack
    {
        private readonly ArrayList _stackList;

        public Stack()
        {
            _stackList = new ArrayList();
        }

        private void Push(object obj)
        {
            _stackList.Add(obj);
        }

        private object Pop()
        {
            if (_stackList.Count == 0)
            {
                Console.WriteLine("No element to delete...");
                return null;
            }

            var index = _stackList.Count - 1;
            var pop = _stackList[index];
            _stackList.RemoveAt(index);
            return pop;
        }

        private void Clear()
        {
            _stackList.Clear();
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
            foreach (var stack in _stackList) Console.WriteLine(stack);
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