using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Web.Models.Users;

namespace Pzpn.Team.Web.Mappings
{
    public class UserMapper
    {
        public static LoginModel ToLoginModel(User user)
        {
            return new LoginModel
            {
                Login = user.Email,
                Password = user.Password
            };
        }
    }
}