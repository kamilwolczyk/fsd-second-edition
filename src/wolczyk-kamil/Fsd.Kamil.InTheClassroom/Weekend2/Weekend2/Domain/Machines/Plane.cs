namespace Weekend2.Domain.Machines
{
    public class Plane : Machine
    {
        public Plane(string model)
            : base(model)
        {

        }

        public override string MakeSomeNoise()
        {
            return "Leceee";
        }
    }
}
