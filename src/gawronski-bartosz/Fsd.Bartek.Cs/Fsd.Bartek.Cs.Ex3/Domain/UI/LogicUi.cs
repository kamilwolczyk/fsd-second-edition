using Fsd.Bartek.Cs2.Ex3.Domain.Magazine;
using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.UI
{
    public abstract class LogicUi
    {
        
        public static void Check(int decision, Warehouse shop)
        {
            switch(decision){
                case 1:
                    ProgramUi.BuyProducts(shop);
                    break;
                case 2:
                    ProgramUi.CheckProducts(shop);
                    break;
                case 3:
                    ProgramUi.AddProducts(shop);
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        public static void LeaveShop(string check, Warehouse shop)
        {
            switch (check)
            {
                case "y":
                    break;
                case "n":
                    ProgramUi.Decision(true, shop);
                    break;
                default:
                    break;
            }
        }

        public static string SearchProduct(string name, Warehouse shop)
        {
            name = name.ToLower();

            return shop.BuyItem(name) ;
        }
    } 
}
