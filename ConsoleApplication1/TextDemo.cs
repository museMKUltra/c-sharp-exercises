using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public static class TextDemo
    {
        public static bool IsConsecutiveNumbers(List<int> numbers, int diff)
        {
            if (diff != 1 && diff != -1) return false;
            for (var i = 1; i < numbers.Count; i++)
                if ((numbers[i - 1] + diff != numbers[i]))
                    return false;

            return true;
        }

        public static void Exercise1()
        {
            Console.WriteLine("please enter a list of number separated by hyphen");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            var inputs = input.Split('-');
            if (inputs.Length < 2) return;
            var numbers = new List<int>();
            foreach (var str in inputs)
                numbers.Add(Convert.ToInt32(str));
            var msg = IsConsecutiveNumbers(numbers, numbers[1] - numbers[0]) ? "" : "Not Consecutive";
            Console.WriteLine(msg);
        }

        public static List<int> GetUniqList(string[] inputs)
        {
            var uniqs = new List<int>();
            foreach (var i in inputs)
            {
                var number = Convert.ToInt32(i);
                if (!uniqs.Contains(number))
                    uniqs.Add(number);
            }

            return uniqs;
        }

        public static void Exercise2()
        {
            Console.WriteLine("please enter a list of number separated by hyphen or press enter directly");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            var inputs = input.Split('-');
            var uniqs = GetUniqList(inputs);
            if (uniqs.Count != inputs.Length)
                Console.WriteLine("Duplicate");
        }

        public static bool IsTimeValid(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            var inputs = input.Split(':');
            if (inputs.Length != 2) return false;

            try
            {
                var hour = Convert.ToInt32(inputs[0]);
                var minute = Convert.ToInt32(inputs[1]);
                return (hour >= 0 && hour < 24 && minute >= 0 && minute < 60);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("please input time with format 'HH:MM'");
            var input = Console.ReadLine();
            const string invalidMsg = "Invalid Time";
            const string validMsg = "Ok";
            var msg = IsTimeValid(input) ? validMsg : invalidMsg;
            Console.WriteLine(msg);
        }

        public static string GetFormatNames(string[] inputs)
        {
            var words = "";
            foreach (var i in inputs)
                words += i.ToUpper()[0] + i.ToLower().Substring(1);

            return words;
        }

        public static void Exercise4()
        {
            Console.WriteLine("please enter a few words separated by space: ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            var inputs = input.Split(' ');
            Console.WriteLine(GetFormatNames(inputs));
        }

        public static int GetVowelCount(string input)
        {
            var vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            var vowelsCount = 0;
            foreach (var i in input)
                if (vowels.Contains(i))
                    vowelsCount++;
            return vowelsCount;
        }

        public static void Exercise5()
        {
            Console.WriteLine("please enter a word: ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            Console.WriteLine(GetVowelCount(input));
        }
    }
}