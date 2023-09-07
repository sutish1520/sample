using System;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UserService.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Contact")]
        public string Contact { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        
        public DateTime AddedDate { get; set; }
    }
}
