using Weekend2.Domain.Library.Persons;

namespace Weekend2.Domain.Library
{
    public interface IRental
    {
        RentResult RentBook(string title, BookReader reader);

        void ReturnBook(Book book, BookReader reader);
    }
}
