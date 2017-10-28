using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs3.Domain
{
    public class Product
    {
        public int ProductId { get; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Product(Warehouse warehouse, string name, decimal price)
        {
            Name = name;
            Price = price;
            ProductId = CreateProductID(warehouse, name, price);
        }

        public int CreateProductID(Warehouse warehouse, string name, decimal price)
        {
            int id = 0;
            bool state;
            try
            {
                state = warehouse.WarehouseState.Exists(x => x.Name == name) && warehouse.WarehouseState.Exists(x => x.Price == price) ? true : false;
            }
            catch
            {
                state = false;
            }
            List<int> listId = new List<int>();

            if (state)
            {
                foreach (Product product in warehouse.WarehouseState)
                {
                    if (product.Name == name && product.Price == price)
                        return product.ProductId;
                }
            }
            else
            {
                Random random = new Random();

                foreach (var property in warehouse.GetUniqeProduct())
                    listId.Add(property.ProductId);

                do id = random.Next();
                while (listId.Contains(id));
            }
            return id;
        }
    }
}