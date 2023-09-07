using MongoDB.Driver;
using ReminderService.Models;
using System;
using System.Collections.Generic;

namespace ReminderService
{
    public class ReminderService
    {
        private readonly IMongoCollection<Reminder> _reminders;

        public ReminderService(IReminderDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _reminders = database.GetCollection<Reminder>(settings.RemindersCollectionName);
        }

        public List<Reminder> GetAllReminders()
        {
            List<Reminder> reminders;
            reminders = _reminders.Find(rem => true).ToList();
            return reminders;
        }

        public Reminder GetReminderById(string id) =>
            _reminders.Find<Reminder>(rem => rem.Id == id).FirstOrDefault();

        public void CreateReminder(Reminder reminder) =>
            _reminders.InsertOne(reminder);

        public void UpdateReminder(string id, Reminder reminder) =>
         _reminders.ReplaceOne(n => n.Id.Equals(id), reminder, new UpdateOptions { IsUpsert = true });

        public void DeleteReminder(string id) =>
            _reminders.DeleteOne(r => r.Id == id);
    }
}
