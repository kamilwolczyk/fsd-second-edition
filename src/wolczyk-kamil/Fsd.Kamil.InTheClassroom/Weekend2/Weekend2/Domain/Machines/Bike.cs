namespace Weekend2.Domain.Machines
{
    public class Bike : Machine
    {
        public Bike(string model) 
            : base(model)
        {
        }

        public override string MakeSomeNoise()
        {
            return "Rowerrrr";
        }
    }
}
