using System.Collections.Generic;
using Fsd.Kamil.Cs.Ex3.Models;

namespace Fsd.Kamil.Cs.Ex3.UserInterface
{
    public interface ISalesman
    {
        void WelcomeCustomer();

        SalesmanAction AskAboutAction();

        Product ReadProductInformation(bool getPrice, bool getCount);

        void ShowAvailableProducts(IEnumerable<Product> products);

        void ShowError(string message);

        bool Finish();
    }
}