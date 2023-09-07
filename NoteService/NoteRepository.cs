using Microsoft.EntityFrameworkCore;
using NoteService.Context;
using NoteService.Models;

namespace NoteService
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteDbContext _context;

        public NoteRepository(NoteDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _context.Notes.ToList();
        }

        public Note GetNoteById(int id)
        {
            return _context.Notes.FirstOrDefault(n => n.Id == id);
        }

        public void AddNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public void UpdateNote(Note note)
        {
            _context.Entry(note).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteNote(int id)
        {
            var noteToDelete = _context.Notes.Find(id);
            if (noteToDelete != null)
            {
                _context.Notes.Remove(noteToDelete);
                _context.SaveChanges();
            }
        }
    }
}
