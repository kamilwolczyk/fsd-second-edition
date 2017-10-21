using System;

namespace Weekend2.Domain
{
    public class Car
    {
        bool _isRunning;

        public string Producer { get; set; }

        public string Model { get; set; }

        public int DoorCount { get; set; }

        public string Voice { get; private set; }

        public Car(string name)
        {
            string[] parts = name.Split(' ');

            if (parts.Length < 2)
                throw new Exception($"Invalid name parameter: {name}");

            Producer = parts[0];
            Model = parts[1];
            DoorCount = 3;
        }

        public Car(string producer, string model, int doorCount)
        {
            Producer = producer;
            Model = model;
            DoorCount = doorCount;
        }

        ~Car()
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
    }
}
