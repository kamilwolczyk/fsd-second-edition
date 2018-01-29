namespace Weekend2.Domain
{
    public interface IClimatronic
    {
        int WindowCount { get; set; }

        string ClimatronicOn();

        string ClimatronicOff();
    }
}
