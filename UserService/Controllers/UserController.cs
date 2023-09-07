using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get() =>
            _userService.Get();

        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<User> Get(string id)
        {
            var emp = _userService.Get(id);

            if (emp == null)
            {
                return NotFound();
            }

            return emp;
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.Post(user);
            return Ok();

        }

        [HttpPut("{id:length(24)}")]

        public IActionResult EditUser(string id, User user)
        {
            _userService.Edit(id, user);
            return Ok();

        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult DeleteUser(string id)
        {
            _userService.Delete(id);
            return Ok();

        }


    }
}
