using Fsd.Sebastian.Cs3.Content;
using System.Collections.Generic;
using Fsd.Sebastian.Cs3.WarehouseConsole;

namespace Fsd.Sebastian.Cs3
{
    public class Warehouse
    {
        private List<Product> _products;

        private MainConsole _warehouseConsole;

        public Warehouse()
        {
            _products = new List<Product>();
            _warehouseConsole = new MainConsole(_products);
        }
    }
}
