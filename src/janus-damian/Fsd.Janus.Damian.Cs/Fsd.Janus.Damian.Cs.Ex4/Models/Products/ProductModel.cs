using Fsd.Janus.Damian.Data.Enums;

namespace Fsd.Janus.Damian.Cs.Ex4.Models.Products
{
    public class ProductModel
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public string ProductionDate { get; set; }

        public ProductType Type { get; set; }
    }
}