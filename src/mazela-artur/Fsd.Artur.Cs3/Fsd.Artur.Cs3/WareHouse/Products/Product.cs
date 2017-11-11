namespace Fsd.Artur.Cs3.WareHouse.Products
{
    public class Product
    {
        public string NameOfItem { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public Product(string name, double price, int count)
        {
            NameOfItem = name;
            Price = price;
            Count = count;
        }
    }
}
