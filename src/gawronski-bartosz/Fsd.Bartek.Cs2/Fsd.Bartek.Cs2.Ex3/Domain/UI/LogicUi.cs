using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.UI
{
    public abstract class LogicUi
    {
        public static void Check(int decision)
        {
            switch(decision){
                case 1:
                    ProgramUi.BuyProducts();
                    break;
                case 2:
                    ProgramUi.CheckProducts();
                    break;
                case 3:
                    ProgramUi.AddProducts();
                    break;
                case 4:
                    break;
            }
        }

        public static void LeaveShop(string check)
        {
            switch (check)
            {
                case "Y":
                    break;
                case "N":
                    ProgramUi.Decision(true);
                    break;
            }
        }

        public static string SearchProduct(string name)
        {
            return "bartek";
        }

        public static string Buy(string check)
        {
            switch (check)
            {
                case "Y":
                    return "Products buy positive";
                case "N":
                    ProgramUi.Decision(true);
                    break;
            }
            return "";
        }
    } 
}
