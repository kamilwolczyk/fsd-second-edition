using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex3.ProductMagazine
{
    public class Presenter : Text
    {
        public void ProductApplication()
        {
            char _choice;
            Menu menu = new Menu();

            try
            {
                StartText(3);
                Menu.StartMenu();

                for (; ; )
                {
                    do
                    {
                        _choice = (char)Console.Read();
                    } while (_choice == '\n' || _choice == '\r');

                    switch (_choice)
                    {
                        case '1':
                            menu.ProductsDetails();
                            menu.EndMenuBuy();
                            menu.ProductsDecision();
                            menu.EndMenuWarehouse();
                            break;
                        case '2':
                            menu.ProductsDetails();
                            menu.EndMenuWarehouse();
                            menu.LeaveOrNotDecision();
                            break;
                        case '3':
                            menu.NewProduct();
                            menu.EndMenuWarehouse();
                            menu.LeaveOrNotDecision();
                            break;
                        case '4':
                            Console.Clear(); Environment.Exit(0); break;
                        default: Console.Clear(); Menu.StartMenu(); break;
                    }
                }
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Brak pamięci");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                EndText();
                Console.ReadKey();
            }
        }
    }
}
