using Weekend2.Domain.Library.Persons;

namespace Weekend2.Domain.Library
{
    public interface ICloseable
    {
        bool IsOpen { get; }

        void Open(LibraryWorker worker);

        void Close(LibraryWorker worker);
    }
}
