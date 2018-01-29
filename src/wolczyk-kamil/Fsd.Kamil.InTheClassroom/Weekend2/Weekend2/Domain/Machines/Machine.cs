namespace Weekend2.Domain.Machines
{
    public abstract class Machine
    {
        public string Model { get; }

        public bool IsRunning { get; private set; }

        public Machine(string model)
        {
            Model = model;
        }

        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public abstract string MakeSomeNoise();
    }
}
