using MongoDB.Bson;
using System.Text.Json;

namespace TestBsonDocument.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public BsonDocument ProductMetadata { get; set; }

    }
}
