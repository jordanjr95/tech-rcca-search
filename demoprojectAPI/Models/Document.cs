using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ThirdParty.Json.LitJson;

namespace demoprojectAPI.Models
{
    public class MyDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string DocumentsCollectionName { get; set; } = null!;

    }
    // Root myDeserializedClass = JsonConvert.Deserializestring<Root>(myJsonResponse);
    public class FormElements
    {
        public string Contributor { get; set; }
        public string Coverage { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string Identifier { get; set; }
        public string Language { get; set; }
        public string Publisher { get; set; }
        public string Relation { get; set; }
        public string Rights { get; set; }
        public string Source { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
    public class Document
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int documentID { get; set; }
        public int templateID { get; set; }
        public string documentReference { get; set; }
        public bool waitingforAdminApproval { get; set; }
        public FormElements formElements { get; set; }
    }



}
