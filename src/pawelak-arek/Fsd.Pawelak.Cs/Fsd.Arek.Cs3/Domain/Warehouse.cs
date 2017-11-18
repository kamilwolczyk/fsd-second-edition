using Fsd.Arek.Cs3.Domain;
using System.Linq;
using System.Collections.Generic;
using System;

public class Warehouse
{
    public List<Product> WarehouseState { get; set; } = new List<Product>();

    public int GetUniqecount(int productID, List<Product> list)
    {
        return list.FindAll(x => x.ProductId.Equals(productID)).Count;
    }

    public List<Product> GetUniqeProduct()
    {
        List<Product> productList = WarehouseState;
        bool bCopy = false;
        List<Product> uniqueList = new List<Product>();

        foreach (Product item1 in WarehouseState)
        {
            foreach (Product item2 in productList)
            {
                bCopy = false;

                if (item1.ProductId == item2.ProductId)
                {
                    bCopy = true;
                }
                if (bCopy)
                {
                    if (!uniqueList.Exists(x => x.ProductId.Equals(item1.ProductId)))
                        uniqueList.Add(item1);
                }
            }
        }
        return uniqueList;
    }

    public void AddProductToWareHouse(int count, Product product)
    {
        for (int i = 0; i < count; i++)
            WarehouseState.Add(product);
    }

    public void SellProduct(int count, Product product)
    {
        int uniqeCount = GetUniqecount(product.ProductId, WarehouseState);

        if (uniqeCount >= count)
            for (int i = 0; i < count; i++)
                WarehouseState.Remove(product);
    }

    public int CreateProductID(string name, decimal price)
    {
        int id = 0;
        bool state = false;
        state = WarehouseState.Exists(x => x.Name == name) && WarehouseState.Exists(x => x.Price == price);
        List<int> listId = new List<int>();

        if (state)
        {
            foreach (Product product in WarehouseState)
            {
                if (product.Name == name && product.Price == price)
                    return product.ProductId;
            }
        }
        else
        {
            Random random = new Random();

            foreach (var property in GetUniqeProduct())
                listId.Add(property.ProductId);

            do id = random.Next();
            while (listId.Contains(id));
        }
        return id;
    }
}

