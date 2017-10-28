using Fsd.Arek.Cs3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

public class AplicationMenu
{
    const string _line = "-----------------------------";
    Warehouse _warehouse = new Warehouse();

    public void Run()
    {
        int option = ShowMainMenu();

        switch (option)
        {
            case 1:
                BuyMenu();
                break;
            case 2:
                ShowWareHauseState();
                break;
            case 3:
                AddProductMenu();
                break;
            case 4:
                break;
            default:
                try
                {
                    throw new Exception("You didn't choose correct number of action.");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    Run();
                    break;
                }
        }
    }

    public int ShowMainMenu()
    {
        Console.Clear();
        try
        {
            SetHeader(3, "Objects");
            System.Console.WriteLine("What do you want?");
            System.Console.WriteLine("[1] Buy our product \n[2] Check our warehouse state \n[3] Add new product \n[4] Leave\n");
            System.Console.WriteLine("Decision: ");
            return int.Parse(Console.ReadLine());
        }
        catch (FormatException fEx)
        {
            Console.WriteLine(fEx.Message);
            return 0;
        }
    }

    public void ShowWareHauseState()
    {
        Console.Clear();
        WareHauseStateTable();

        if (IfCloseAplication())
            Run();
        else
            ShowWareHauseState();
    }

    public void WareHauseStateTable()
    {
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("    Product Id     |         Name         |   Price   |   Count   |");
        Console.WriteLine("-------------------------------------------------------------------");

        foreach (Product product in _warehouse.GetUniqeProduct())
            Console.WriteLine(String.Format("{0,-18} | {1,20} | {2,9} | {3,9} |", product.ProductId, product.Name, product.Price, _warehouse.GetUniqecount(product.ProductId, _warehouse.WarehouseState)));
        Console.WriteLine("------------------------------------------------------------------\n");
    }

    public void BuyMenu()
    {
        Product productToBuy = null;
        Console.Clear();
        WareHauseStateTable();
        bool close;

        do
        {
            try
            {
                Console.WriteLine("Enter Id's: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter count: ");
                int count = int.Parse(Console.ReadLine());
                productToBuy = _warehouse.WarehouseState.FindLast(x => x.ProductId == id);

                if (productToBuy != null)
                    _warehouse.SellProduct(count, productToBuy);
                else
                    Console.WriteLine("You didn't choose correct ID");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            close = IfCloseAplication();
        } while (!close);
        Run();
    }

    public void AddProductMenu()
    {
        Console.Clear();
        bool close;

        do
        {
            try
            {
                Console.WriteLine("Enter name of product: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price of product: ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter count of product: ");
                int count = int.Parse(Console.ReadLine());
                _warehouse.AddProductToWareHouse(count, new Product(_warehouse, name, price));
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            close = IfCloseAplication();
        } while (!close);
        Run();
    }

    public bool IfCloseAplication()
    {
        Console.WriteLine("Do you want to leave [(Y)es] [(N)o] ?");
        return Console.ReadLine() == "Y" ? true : false;
    }

    public void SetHeader(int numberExcercise, string subject)
    {
        Console.WriteLine($"Exercise {numberExcercise} - {subject} \n{_line}");
    }
}