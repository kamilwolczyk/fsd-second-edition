using Fsd.Artur.Cs3.WareHouse;
using Fsd.Artur.Cs3.ShopActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs3.ShopActions
{
    public class CheckingDecision
    {
        public static void Check(int decision, Warehouse store)
        {
            switch (decision)
            {
                case 1:
                    BuingProducts.BuyOne(store);
                    break;
                case 2:
                    CheckingStateOfWarehouse.CheckProducts(store);
                    break;
                case 3:
                    AddingProducts.AddOne(store);
                    break;
                case 4:
                    LeavingShop.Leave(store);
                    break;
                default:
                    break;
            }
        }
    }
}
