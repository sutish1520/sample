using AuthenticationService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthService _userService;

        public UserController(IAuthService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] User model)
        {
            // Validate and create a new user
            var newUser = _userService.RegisterUser(model.Username, model.Password, model.Mobile);
            return Ok(newUser);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User model)
        {
            // Validate and perform user login
            var user = _userService.Login(model.Username, model.Password);

            if (user != null)
            {
                return Ok(user);
            }

            return BadRequest("Invalid username or password.");
        }
    }
}

