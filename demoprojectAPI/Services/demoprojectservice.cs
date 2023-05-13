namespace demoprojectAPI.Services
{
    using demoprojectAPI.Models;
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;
    using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

    public class DemoProjectAPIService
    {
        private readonly IMongoCollection<Document> _documentsCollection;

        public DemoProjectAPIService(
            IOptions<MyDatabaseSettings> MyDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                MyDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                MyDatabaseSettings.Value.DatabaseName);

            _documentsCollection = mongoDatabase.GetCollection<Document>(
                MyDatabaseSettings.Value.DocumentsCollectionName);
        }

        public async Task<List<Document>> GetAsync() =>
            await _documentsCollection.Find(_ => true).ToListAsync();

        //public async Task<Document?> GetAsync(string id) =>
        //    await _documentsCollection.Find(x => x.ID == id).FirstOrDefaultAsync();

        //public async Task CreateAsync(Document newDocument) =>
        //    await _documentsCollection.InsertOneAsync(newDocument);

        //public async Task UpdateAsync(string id, Document updatedDocument) =>
        //    await _documentsCollection.ReplaceOneAsync(x => x.ID == id, updatedDocument);

        //public async Task RemoveAsync(string id) =>
        //    await _documentsCollection.DeleteOneAsync(x => x.ID == id);
        public async Task<List<Document>> GetSearchData(string searchby, string value)
        {
            switch (searchby)
            {             
                case "Contributor":
                    return await _documentsCollection.Find(x => x.formElements.Contributor.Contains(value)).ToListAsync();
                    break;

                case "Coverage":
                    return await _documentsCollection.Find(x => x.formElements.Coverage.Contains(value)).ToListAsync();
                    break;

                case "Creator":
                    return await _documentsCollection.Find(x => x.formElements.Creator.Contains(value)).ToListAsync();
                    break;

                case "Year":
                    return await _documentsCollection.Find(x => x.formElements.Date.Contains(value)).ToListAsync();
                    break;

                case "Description":
                    return await _documentsCollection.Find(x => x.formElements.Description.Contains(value)).ToListAsync();
                    break;

                case "Format":
                    return await _documentsCollection.Find(x => x.formElements.Format.Contains(value)).ToListAsync();
                    break;
                
                case "Identifier":
                    return await _documentsCollection.Find(x => x.formElements.Identifier.Contains(value)).ToListAsync();
                    break;

                case "Language":
                    return await _documentsCollection.Find(x => x.formElements.Language.Contains(value)).ToListAsync();
                    break;

                case "Publisher":
                    return await _documentsCollection.Find(x => x.formElements.Publisher.Contains(value)).ToListAsync();
                    break;

                case "Relation":
                    return await _documentsCollection.Find(x => x.formElements.Relation.Contains(value)).ToListAsync();
                    break;

                case "Rights":
                    return await _documentsCollection.Find(x => x.formElements.Rights.Contains(value)).ToListAsync();
                    break;

                case "Source":
                    return await _documentsCollection.Find(x => x.formElements.Source.Contains(value)).ToListAsync();
                    break;

                case "Subject":
                    return await _documentsCollection.Find(x => x.formElements.Subject.Contains(value)).ToListAsync();
                    break;

                case "Title":
                    return await _documentsCollection.Find(x => x.formElements.Title.Contains(value)).ToListAsync();
                    break;

                case "Type":
                    return await _documentsCollection.Find(x => x.formElements.Type.Contains(value)).ToListAsync();
                    break;

                case "Email":
                    return await _documentsCollection.Find(x => x.formElements.Email.Contains(value)).ToListAsync();
                    break;

                case "Name":
                    return await _documentsCollection.Find(x => x.formElements.Name.Contains(value)).ToListAsync();
                    break;
            }
            return new List<Document> ();
        }
    }
    public class demoprojectservice
    {
    }
}
