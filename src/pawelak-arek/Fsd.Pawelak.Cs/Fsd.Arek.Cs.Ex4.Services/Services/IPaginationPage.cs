using Fsd.Arek.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Arek.Cs.Ex4.Services.Services
{
    public interface IPaginationPage<TItems>
    {
        IEnumerable<TItems> CreatePagePositionList(IEnumerable<TItems> list, int pageNumber, int item);
    }
}