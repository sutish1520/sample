namespace NoteService.Models
{
    public class NoteUser
    {
        public int UserId { get; set; }
        public List<Note> Notes { get; set; }

    }
}
