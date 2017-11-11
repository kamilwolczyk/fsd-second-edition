using System.Collections.Generic;

namespace Weekend2.Domain.Library
{
    public class BooksSource
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book("Stary człowiek i morze", 420, BookType.Comedy),
                new Book("The Ring", 370, BookType.Horror),
                new Book("O psie który jeździł koleją", 256, BookType.Comedy),
            };
        }
    }
}
