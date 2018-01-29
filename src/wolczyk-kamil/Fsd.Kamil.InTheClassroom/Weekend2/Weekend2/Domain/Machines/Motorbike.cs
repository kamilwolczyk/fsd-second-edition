namespace Weekend2.Domain.Machines
{
    public class Motorbike : Machine
    {
        public Motorbike(string model) 
            : base(model)
        {

        }

        public override string MakeSomeNoise()
        {
            return "Motorrrrr rrr";
        }
    }
}
