namespace ReminderService.Models
{
    public interface IReminderDatabaseSettings
    {
        string RemindersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
namespace ReminderService.Models
{
    public class ReminderDatabaseSettings : IReminderDatabaseSettings
    {
        public string RemindersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}