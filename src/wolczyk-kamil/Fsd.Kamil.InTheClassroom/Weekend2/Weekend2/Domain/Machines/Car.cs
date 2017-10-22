namespace Weekend2.Domain.Machines
{
    public class Car : Machine
    {
        public Car(string model) 
            : base(model)
        {

        }

        public override string MakeSomeNoise()
        {
            return "Carrrr";
        }
    }
}
