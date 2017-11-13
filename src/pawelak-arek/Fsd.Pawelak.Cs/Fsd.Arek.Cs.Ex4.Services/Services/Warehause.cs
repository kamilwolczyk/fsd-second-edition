using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Services.Services
{
    public class Warehause : IWarehause
    {
        private List<Product> _productList = new List<Product>
        {
            new Car("Mazda","626",12000,"Sedan", new DateTime(2000,1,25)),
            new Car("Mazda","5",200,"Sedan", new DateTime(2002,1,25)),
            new Car("Mazda","CX3",14000,"Combi", new DateTime(2005,1,25)),
            new Car("Audi","A3",20000,"Hatchback", new DateTime(2007,12,25)),
            new Car("Audi","A4",25000,"Sedan", new DateTime(2010,1,25)),
            new Car("Audi","A6",20000,"Kombi", new DateTime(1998,1,25)),
            new Car("Mercedes","GLK",40000,"Kombi", new DateTime(2015,1,25)),
            new Car("Mercedes","GLA",1000,"Sedan", new DateTime(2012,1,25)),
            new Car("Mercedes","CL",10000,"Kombi", new DateTime(2002,1,25)),
            new Car("Mercedes","Citan",52000,"Sedan", new DateTime(2005,1,25)),
            new Car("Alfa Romeo","156",32000,"Sedan", new DateTime(2005,1,25)),
            new Car("Alfa Romeo","159",22000,"Kombi", new DateTime(2012,1,25)),
            new Car("Alfa Romeo","Giulia",12000,"Coupe", new DateTime(2010,1,25)),
            new Car("Nissan","Cube",52000,"Sedan", new DateTime(2015,1,25)),
            new Car("Nissan","Almera",22000,"Kombi", new DateTime(1992,1,25)),
            new Car("Nissan","Corsa",40000,"Kombi", new DateTime(2015,10,11)),
            new Car("Opel","Insignia",1000,"Sedan", new DateTime(2012,5,12)),
            new Car("Opel","Astra",10000,"Kombi", new DateTime(2002,3,15)),
            new Car("Opel","Meriva",52000,"Sedan", new DateTime(2007,2,5)),
            new Car("Opel","Zafira",22000,"Sedan", new DateTime(2010,2,5)),
        };

        public int GetProductCount()
        {
            return _productList.Count();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }
    }
}
