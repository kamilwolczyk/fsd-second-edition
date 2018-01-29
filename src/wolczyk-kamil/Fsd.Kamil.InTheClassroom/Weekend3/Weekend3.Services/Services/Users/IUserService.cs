using System.Collections.Generic;
using Weekend3.Data.Entities;

namespace Weekend3.Services.Services.Users
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}