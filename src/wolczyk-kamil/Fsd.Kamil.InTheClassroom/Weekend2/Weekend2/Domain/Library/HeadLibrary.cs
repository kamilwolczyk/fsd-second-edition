using System;
using System.Collections.Generic;
using System.Linq;
using Weekend2.Domain.Library.Persons;

namespace Weekend2.Domain.Library
{
    public class HeadLibrary : ICloseable, IRental
    {
        public bool IsOpen { get; private set; }

        private IEnumerable<Book> _allBooks;

        private IList<RentInfo> _rents;

        public HeadLibrary(IEnumerable<Book> books)
        {
            _allBooks = books;
            _rents = new List<RentInfo>();
        }

        public void Open(LibraryWorker worker)
        {
            IsOpen = true;
        }

        public void Close(LibraryWorker worker)
        {
            IsOpen = false;
        }

        public RentResult RentBook(string title, BookReader reader)
        {
            if (!IsOpen)
                return new RentResult { Message = "Library is closed" };

            var book = _allBooks.FirstOrDefault(item => item.Title == title);

            if (book == null)
                return new RentResult { Message = $"Book with title {title} has not been found" };

            if (!IsBookAvailable(title))
                return new RentResult { Message = $"Book {title} is not available" };

            if (book.Type == BookType.Horror && reader.Age < 18)
                return new RentResult { Message = $"Reader with age {reader.Age} cannot read this book" };

            _rents.Add(new RentInfo(reader, book));

            return new RentResult { Book = book };
        }

        public void ReturnBook(Book book, BookReader reader)
        {
            RentInfo rentInfo = _rents.FirstOrDefault(rent => rent.Book == book && rent.Person == reader);

            if (rentInfo == null)
                throw new InvalidOperationException($"Reader {reader.LastName} don't rent book {book.Title}");

            rentInfo.IsEnded = true;
        }

        private bool IsBookAvailable(string title)
        {
            return !_rents.Any(rent => rent.Book.Title == title && !rent.IsEnded);
        }
    }
}
