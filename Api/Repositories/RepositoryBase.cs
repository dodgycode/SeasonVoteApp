using MongoDB.Driver;
using SeasonVoting.Api.Models;

namespace SeasonVoting.Api.Repositories
{
    public abstract class RepositoryBase
    {
        protected MongoClient Client { get; }
        protected IMongoDatabase Database { get; }
        public RepositoryBase()
        {
            Client = new MongoClient(DbConnection.ConnectionString);
            Database = Client.GetDatabase(DbConnection.DatabaseName);
        }
    }
}
