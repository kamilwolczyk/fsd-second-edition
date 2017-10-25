using Fsd.Arek.Cs3.Domain;
using System.Linq;
using System.Collections.Generic;

public class Warehouse
{
    private List<Product> _stock;

    public List<Product> WarehouseState
    {
        get
        {
            return _stock;
        }
        set
        {
        }
    }

    public void ListWarehouseState()
    {

    }

    public void AddProductToWareHouse(int count, Product product)
    {
        for (int i = 0; i < count; i++)
        {
            _stock.Add(product);
        }
        
    }

    public void SellProduct(int count, Product product)
    {
        for (int i = 0; i < count; i++)
        {
            _stock.Remove(product);
        }
        
    }
}

