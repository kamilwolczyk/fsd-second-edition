using System;

namespace Weekend2.Domain
{
    public class CarOld : IClimatronic, ISecurity
    {
        bool _isRunning;

        public int WindowCount { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public int DoorCount { get; set; }

        public string Voice { get; private set; }

        public bool HasAlarm { get; }

        public CarOld(string name)
        {
            string[] parts = name.Split(' ');

            if (parts.Length < 2)
                throw new Exception($"Invalid name parameter: {name}");

            Producer = parts[0];
            Model = parts[1];
            DoorCount = 3;
            WindowCount = 3;
            HasAlarm = true;
        }

        public CarOld(string producer, string model, int doorCount)
        {
            Producer = producer;
            Model = model;
            DoorCount = doorCount;
        }

        ~CarOld()
        {
            System.Console.WriteLine("Destruktor działa");
        }

        public void Start()
        {
            _isRunning = true;
            Voice = "Brrrr";
        }

        public void Stop()
        {
            _isRunning = false;
            Voice = string.Empty;
        }

        public string ClimatronicOn()
        {
            return "zimnoooo";
        }

        public string ClimatronicOff()
        {
            return "ciepłoo";
        }
    }
}
