namespace Weekend2.Domain.Library.Persons
{
    public class LibraryWorker : BookReader
    {
        public LibraryWorker(string fullName, int age)
            : base(fullName, age)
        {
        }
    }
}
