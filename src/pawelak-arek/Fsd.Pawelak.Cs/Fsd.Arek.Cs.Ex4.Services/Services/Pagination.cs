using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Services.Services
{
    public class Pagination : IPaginationPage
    {
        public IEnumerable<Product> CreatePagePositionList(IEnumerable<Product> list, int pageNumber, int item)
        {
            int startIndex = ((pageNumber * item) - item);
            IEnumerable<Product> pagginationList = new List<Product>();

            if (pageNumber * item < list.Count())
                return pagginationList = list.Skip(startIndex).Take(item);
            else
                return list;
        }
    }
}
