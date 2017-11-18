using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Domain.Api.Services;
using System.Collections.Generic;
using System.Linq;

namespace Pzpn.Team.Domain.Services
{
    public class FakeUserList : IUserService
    {
        private List<User> _users;

        public FakeUserList()
        {
            _users = new List<User>
            {
                new User
                {
                    Login = "jk@gmail.com",
                    Password = "123456"
                }
            };
        }

        public bool CheckUser(User posibleUser)
        {
            User CheckedUser = _users.FirstOrDefault(user => user.Login == posibleUser.Login);
            if(CheckedUser.Password == posibleUser.Password)            
                return true;
            
            return false;
        }
    }
}
