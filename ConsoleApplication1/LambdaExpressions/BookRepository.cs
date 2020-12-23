using System.Collections.Generic;

namespace ConsoleApplication1.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "book1", Price = 1f},
                new Book() {Title = "book2", Price = 7f},
                new Book() {Title = "book3", Price = 17f}
            };
        }
    }
}