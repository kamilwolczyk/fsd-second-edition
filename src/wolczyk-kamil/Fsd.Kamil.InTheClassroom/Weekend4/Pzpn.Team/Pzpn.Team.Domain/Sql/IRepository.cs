using System.Collections.Generic;

namespace Pzpn.Team.Domain.Sql
{
    public interface IRepository<T>
    {
        T Get(int id);

        IEnumerable<T> GetAll();
    }
}
