using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReminderService.Models;



namespace ReminderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReminderController : ControllerBase
    {
        private readonly ReminderService _reminderService;

        public ReminderController(ReminderService reminderService)
        {
            _reminderService = reminderService;
        }

        [HttpGet]
        public ActionResult<List<Reminder>> Get()
        {
            var reminders = _reminderService.GetAllReminders();
            return Ok(reminders);
        }

        [HttpGet("{id:length(24)}", Name = "GetReminder")]
        public ActionResult<Reminder> Get(string id)
        {
            var reminder = _reminderService.GetReminderById(id);

            if (reminder == null)
            {
                return NotFound();
            }

            return Ok(reminder);
        }

        [HttpPost]
        public IActionResult AddReminder(Reminder reminder)
        {
            _reminderService.CreateReminder(reminder);
            return Ok();
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult EditReminder(string id, Reminder reminder)
        {
            

            _reminderService.UpdateReminder(id, reminder);
            return Ok();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult DeleteReminder(string id)
        {
            var existingReminder = _reminderService.GetReminderById(id);

            if (existingReminder == null)
            {
                return NotFound();
            }

            _reminderService.DeleteReminder(id);
            return Ok();
        }
    }
}
