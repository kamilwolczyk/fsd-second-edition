using Pzpn.Team.Domain.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pzpn.Team.Domain.Api.Services
{
    public interface IUserService
    {
        bool CheckUser(string login, string password);
    }
}
