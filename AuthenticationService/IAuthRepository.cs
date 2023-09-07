using AuthenticationService.Model;

namespace AuthenticationService
{
    public interface IAuthRepository
    {
        User GetUserByUsername(string username);
        User CreateUser(User user);
    }
}

