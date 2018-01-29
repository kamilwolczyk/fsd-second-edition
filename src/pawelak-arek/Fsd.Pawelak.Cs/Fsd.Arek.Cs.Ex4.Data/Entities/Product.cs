using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }

        public DateTime DateOfProduction { get; set; }

        public Product(int id, string producer, string model, decimal price, string type, DateTime dateOfProduction)
        {
            Id = id;
            Producer = producer;
            Model = model;
            Price = price;
            Type = type;
            DateOfProduction = dateOfProduction;
        }
    }
}
