namespace Fsd.Sebastian.Cs3.Content
{
    public class Product
    {
        public string Name { get; }

        public int Price { get; }

        public int Count { get; set; }

        public Product(string producer, string model, int price, int count)
        {
            Name = $"{producer} {model}";
            Price = price;
            Count = count;
        }
    }
}
