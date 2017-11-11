using Weekend2.Domain.Machines;
using Weekend2.Domain.Users;

namespace Weekend2.Domain
{
    public class Game
    {
        Machine[] _allMachines = new Machine[]
        {
            new Car("Ferrari"),
            new Bike("Kross"),
            new Motorbike("Suzuki"),
            new Plane("F16"),
            new Car("Lamborgini")
        };

        User _mainUser;

        public void RunGame()
        {
            _mainUser = new User();
            _mainUser.Select(_allMachines[2]);
            _mainUser.Start();

            foreach (Machine machine in _allMachines)
                System.Console.WriteLine(machine.MakeSomeNoise());
        }
    }
}
