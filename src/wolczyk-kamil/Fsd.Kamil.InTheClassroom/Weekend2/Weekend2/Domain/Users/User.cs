using Weekend2.Domain.Machines;

namespace Weekend2.Domain.Users
{
    public class User
    {
        public Machine SelectedMachine { get; set; }

        public void Start()
        {
            if (SelectedMachine == null)
                return;

            SelectedMachine.Start();
        }

        public void Stop()
        {
            if (SelectedMachine == null)
                return;

            SelectedMachine.Stop();
        }

        public void Select(Machine machine)
        {
            SelectedMachine = machine;
        }

        public void Out()
        {
            SelectedMachine = null;
        }
    }
}
