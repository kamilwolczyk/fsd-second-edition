using Fsd.Arek.Cs3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

public class SubMenu
{
    Warehouse warehouse = new Warehouse();

    public int ShowMainMenu()
    {
        System.Console.WriteLine("What do you want?");
        System.Console.WriteLine("[1] Buy our product \n[2] Check our warehouse state \n[3] Add new product \n[4] Leave\n");
        System.Console.WriteLine("Decision: ");
        return int.Parse(Console.ReadLine());
    }

    public void ShowWareHauseState()
    {
        Console.Clear();
        foreach (Product product in warehouse.GetUniqeProduct())
            Console.WriteLine($"{product.Name} {product.Price} {warehouse.GetUniqecount(product.ProductId, warehouse.WarehouseState)} ");

        Console.ReadKey();
    }

}