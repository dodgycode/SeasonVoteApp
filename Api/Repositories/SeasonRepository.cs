using MongoDB.Bson;
using MongoDB.Driver;
using SeasonVoting.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeasonVoting.Api.Repositories
{
    public class SeasonRepository : RepositoryBase
    {
        private readonly IMongoCollection<Season> _season;
        public SeasonRepository()
        {
            _season = Database.GetCollection<Season>(CollectionNames.Season);
        }

        public List<Season> GetAll()
        {
            return _season.Find(c => true).ToList();
        }

        public List<Season> GetAllIncomplete()
        {
            return _season.Find(c => !c.IsComplete).ToList();
        }

        public Season GetById(ObjectId id)
        {
            return  _season.Find(c => c.Id == id).FirstOrDefault();
        }
        public Season Create(Season customer)
        {
            _season.InsertOne(customer);
            return customer;
        }
        public void Update(ObjectId id, Season customer)
        {
            _season.ReplaceOne(c => c.Id == id, customer);
        }
        public void Delete(ObjectId id)
        {
            _season.DeleteOne(c => c.Id == id);
        }
    }
}
