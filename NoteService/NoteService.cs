using NoteService.Models;

namespace NoteService
{

    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _noteRepository.GetAllNotes();
        }

        public Note GetNoteById(int id)
        {
            return _noteRepository.GetNoteById(id);
        }

        public void AddNote(Note note)
        {
            _noteRepository.AddNote(note);
        }

        public void UpdateNote(Note note)
        {
            _noteRepository.UpdateNote(note);
        }

        public void DeleteNote(int id)
        {
            _noteRepository.DeleteNote(id);
        }
    }
}

