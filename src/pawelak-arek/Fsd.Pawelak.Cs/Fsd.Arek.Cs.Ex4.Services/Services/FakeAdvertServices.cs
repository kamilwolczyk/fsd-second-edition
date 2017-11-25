using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Services.Services
{
    public class FakeAdvertServices : IAdvertsServices
    {
        private List<Advert> _advertsList = new List<Advert>()
        {
            new Advert
            {
                name = "Nike"
            },
            new Advert
            {
                name = "Puma"
            },
            new Advert
            {
                name = "Ryś"
            },
            new Advert
            {
                name = "4F"
            },
            new Advert
            {
                name = "Adidas"
            },
        };

        public IEnumerable<Advert> GetAllAdverts()
        {
            return _advertsList;
        }
    }
}
