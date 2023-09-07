using AuthenticationService.Context;
using AuthenticationService.Model;

namespace AuthenticationService
{

    public class AuthRepository : IAuthRepository
    {
        private readonly AuthDbContext _context;

        public AuthRepository(AuthDbContext context)
        {
            _context = context;
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }

}
