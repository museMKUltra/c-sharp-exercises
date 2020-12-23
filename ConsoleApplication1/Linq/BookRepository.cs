using System.Collections.Generic;

namespace ConsoleApplication1.Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "booker", Price = 5},
                new Book() {Title = "book", Price = 9.99f},
                new Book() {Title = "book", Price = 12},
            };
        }
    }
}