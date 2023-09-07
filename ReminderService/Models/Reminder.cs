using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReminderService.Models
{
    public class Reminder
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }


        [JsonPropertyName("Description")]
        public string Description { get; set; }


        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("CreatedBy")]
        public string CreatedBy { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime AddedDate { get; set; }

    }
}

