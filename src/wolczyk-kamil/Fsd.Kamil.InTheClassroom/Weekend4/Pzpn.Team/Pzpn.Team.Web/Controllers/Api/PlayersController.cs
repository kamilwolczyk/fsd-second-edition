using Pzpn.Team.Domain.Api.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace Pzpn.Team.Web.Controllers.Api
{
    public class PlayersController : ApiController
    {
        public List<User> Users { get; set; }

        public PlayersController()
        {
            Users = new List<User>
            {
                new User(){Email = "jan@kowalski.com", Password="króliczek"},
                new User(){Email = "maria@gmail.com", Password="123456"},
                new User(){Email = "stefan@gmail.com", Password="qwerty"},
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }
    }
}
