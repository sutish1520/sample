using AuthenticationService.Model;

namespace AuthenticationService
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public User RegisterUser(string username, string password, string mobile)
        {
            // You can add validation and hashing of passwords here
            var newUser = new User
            {
                Username = username,
                Password = password,
                Mobile = mobile
            };

            return _authRepository.CreateUser(newUser);
        }

        public User Login(string username, string password)
        {
            var user = _authRepository.GetUserByUsername(username);

            if (user != null && user.Password == password)
            {
                return user;
            }

            return null;
        }
    }

}



