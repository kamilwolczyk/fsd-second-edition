using System.Collections.Generic;
using Weekend3.Data.Entities;

namespace Weekend3.Services.Services.Users
{
    public class FakeUserService : IUserService
    {
        public IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    FirstName = "Jan",
                    LastName = "Kowalski",
                },
                new User
                {
                    FirstName = "Stefan",
                    LastName = "Siara",
                }
            };
        }
    }
}
