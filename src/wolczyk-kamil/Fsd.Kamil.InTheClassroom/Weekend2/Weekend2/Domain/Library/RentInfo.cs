using Weekend2.Domain.Library.Persons;

namespace Weekend2.Domain.Library
{
    public class RentInfo
    {
        public Person Person { get; set; }

        public Book Book { get; set; }

        public bool IsEnded { get; set; }

        public RentInfo(Person person, Book book)
        {
            Person = person;
            Book = book;
        }
    }
}
