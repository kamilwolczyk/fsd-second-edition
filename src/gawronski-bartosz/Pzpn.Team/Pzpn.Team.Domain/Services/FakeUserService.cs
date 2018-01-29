using Pzpn.Core.Cryptography;
using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Domain.Api.Services;
using System.Collections.Generic;
using System.Linq;

namespace Pzpn.Team.Domain.Services
{
    public class FakeUserService : IUserService
    {
        private readonly ISecurityService _securityService;
        private readonly IEnumerable<User> _users;

        public FakeUserService(ISecurityService securityService)
        {
            _securityService = securityService;

            _users = new List<User>{
                new User
                {
                    Email = "jk@gmail.com",
                    Password = _securityService.GetHash("123456")
                }
            };
        }

        public bool TryLoginUser(string login, string password)
        {
            return _users.Any(user => user.Email == login && user.Password == _securityService.GetHash(password));
        }
    }
}
