using System;

namespace Fsd.Jacek.Cs.Ex4.Data
{
    public abstract class ProductFrame
    {
        public int Id { get;  set; }

        public ProductType Type { get; set; }

        public string Model { get; set; }

        public string Manufacterer { get; set; }

        public DateTime DateOfProduction { get; set; }

        public decimal Price { get; set; }

        public ProductFrame(int id, ProductType type, string model, string manufacter, DateTime dateOfProducktion, decimal price)
        {
            Id = id;
            Type = type;
            Model = model;
            Manufacterer = manufacter;
            DateOfProduction = dateOfProducktion;
            Price = price;
        }



    }
}