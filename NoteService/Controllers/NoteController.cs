using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteService.Models;

namespace NoteService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {

        private readonly INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        // GET: api/Note
        [HttpGet]
        public ActionResult<IEnumerable<Note>> Get()
        {
            var notes = _noteService.GetAllNotes();
            return Ok(notes);
        }

        // GET: api/Note/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Note> Get(int id)
        {
            var note = _noteService.GetNoteById(id);
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }

        // POST: api/Note
        [HttpPost]
        public ActionResult Post([FromBody] Note note)
        {
            if (note == null)
            {
                return BadRequest("Invalid data.");
            }

            _noteService.AddNote(note);
            return CreatedAtAction("Get", new { id = note.Id }, note);
        }

        // PUT: api/Note/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Note note)
        {
            if (note == null || id != note.Id)
            {
                return BadRequest("Invalid data.");
            }

            var existingNote = _noteService.GetNoteById(id);
            if (existingNote == null)
            {
                return NotFound();
            }

            _noteService.UpdateNote(note);
            return NoContent();
        }

        // DELETE: api/Note/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var note = _noteService.GetNoteById(id);
            if (note == null)
            {
                return NotFound();
            }

            _noteService.DeleteNote(id);
            return NoContent();
        }
    }

}

