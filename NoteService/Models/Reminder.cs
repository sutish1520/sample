namespace NoteService.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; }
    }
}
