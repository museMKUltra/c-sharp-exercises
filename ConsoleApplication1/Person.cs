using System;

namespace ConsoleApplication1
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime Birthday { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public Person(DateTime dateTime)
        {
            Birthday = dateTime;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is {1} {2}.", to, FirstName, LastName);
        }

        public static Person Parse(string firstName, string lastName)
        {
            var person = new Person(new DateTime(2000, 12, 12));
            person.FirstName = firstName;
            person.LastName = lastName;
            return person;
        }
    }
}