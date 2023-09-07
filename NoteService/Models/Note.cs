namespace NoteService.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public string Category { get; set; }
        public string CreatedBy { get; set; }
    }
}
