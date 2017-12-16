using Pzpn.Team.Domain.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pzpn.Team.Domain.Api.Entities;

namespace Pzpn.Team.Domain.Services 
{
    public class InMemoryUserService : IUserService
    {
        private List<User> _users;


        public InMemoryUserService()
        {
            _users = new List<User>
            {
                new User
                {
                    Email = "jk@gmail.com",
                    Password ="123456"
                },
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public bool CheckUser(string email, string password)
        {
            if (_users.Any(entity => (entity.Email == email) && (entity.Password == password)))
            return true;

            return false;
        }
    }
}
