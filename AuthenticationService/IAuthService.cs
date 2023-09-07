using AuthenticationService.Model;

namespace AuthenticationService
{
    public interface IAuthService
    {

        User RegisterUser(string username, string password, string mobile);
        User Login(string username, string password);
    }
}
