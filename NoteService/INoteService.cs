using NoteService.Models;

namespace NoteService
{
    public interface INoteService
    {
        IEnumerable<Note> GetAllNotes();
        Note GetNoteById(int id);
        void AddNote(Note note);
        void UpdateNote(Note note);
        void DeleteNote(int id);
    }
}
