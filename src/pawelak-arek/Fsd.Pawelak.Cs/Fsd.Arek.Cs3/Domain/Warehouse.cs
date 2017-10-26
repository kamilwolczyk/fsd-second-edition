using Fsd.Arek.Cs3.Domain;
using System.Linq;
using System.Collections.Generic;

public class Warehouse
{
    private List<Product> _stock = new List<Product>();

    private ProductSource _productSource = new ProductSource();

    public List<Product> WarehouseState
    {
        get
        {
            return _stock = _productSource.GetProduct();
        }
        set
        {

        }
    }

    public Product[,] ListWarehouseState()
    {
        return null;
    }

    public int GetUniqecount(int productID, List<Product> list)
    {
        return list.FindAll(x => x.ProductId.Equals(productID)).Count;
    }

    public List<Product> GetUniqeProduct()
    {
        List<Product> tempList = WarehouseState;
        bool bCopy = false;
        List<Product> uniqueList = new List<Product>();

        foreach (Product item1 in WarehouseState)
        {
            foreach (Product item2 in tempList)
            {
                bCopy = false;

                if (item1.ProductId == item2.ProductId)
                {
                    bCopy = true;
                }
                if (bCopy)
                {
                    if (!uniqueList.Exists(x=>x.ProductId.Equals(item1.ProductId)))
                        uniqueList.Add(item1);
                }
            }
        }
        return uniqueList;
    }

    public void AddProductToWareHouse(int count, Product product)
    {
        for (int i = 0; i < count; i++)
            _stock.Add(product);
    }

    public void SellProduct(int count, Product product)
    {
        for (int i = 0; i < count; i++)
            _stock.Remove(product);
    }
}

