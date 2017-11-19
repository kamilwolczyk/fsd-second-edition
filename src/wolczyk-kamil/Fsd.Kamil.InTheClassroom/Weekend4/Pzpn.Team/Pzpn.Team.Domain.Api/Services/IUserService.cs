namespace Pzpn.Team.Domain.Api.Services
{
    public interface IUserService
    {
        bool TryLoginUser(string login, string password);
    }
}
