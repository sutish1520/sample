using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationService.Model
{
    public class User
    {

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
    }
}
