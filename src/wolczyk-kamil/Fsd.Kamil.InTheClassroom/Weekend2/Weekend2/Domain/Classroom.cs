namespace Weekend2.Domain
{
    public class Classroom : IClimatronic
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int WindowCount { get; set; }

        public string ClimatronicOff()
        {
            return string.Empty;
        }

        public string ClimatronicOn()
        {
            return string.Empty;
        }
    }
}
