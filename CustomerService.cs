using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Jacek.Cs3.Tools
{
    class CustomerService
    {
        public const int BUY_PRODUCT = 1;
        public const int CHEAK_STATE = 2;
        public const int ADD_PRODUCT = 3;
        public const int LEWAVE = 4;

        public void Service()
        {
            Warehouse warehouse = new Warehouse();
            int decision = 0;
            bool stayInStore = true;
            while (stayInStore)
            {
                warehouse.ShowMenu();
                Console.Write("Decision: ");
                string input = Console.ReadLine();
                decision = int.Parse(input);
                switch (decision)
                {
                    case BUY_PRODUCT:
                        warehouse.BuyProduct();
                        stayInStore = warehouse.LeaveShowpPrompt();
                        break;

                    case CHEAK_STATE:
                        warehouse.ShowStack();
                        stayInStore = warehouse.LeaveShowpPrompt();
                        break;

                    case ADD_PRODUCT:
                        warehouse.AddProduct();
                        stayInStore = warehouse.LeaveShowpPrompt();
                        break;

                    case LEWAVE:
                        stayInStore = false;
                        break;
                }
            }
        }
    }
}
