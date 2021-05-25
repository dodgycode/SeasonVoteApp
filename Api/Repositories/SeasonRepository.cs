using MongoDB.Bson;
using MongoDB.Driver;
using SeasonVoting.Api.Models.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeasonVoting.Api.Repositories
{
    public class SeasonRepository : RepositoryBase
    {
        private readonly IMongoCollection<Season> _season;
        public SeasonRepository()
        {
            _season = Database.GetCollection<Season>(CollectionNames.Season);
        }

        #region Gets
        public List<Season> GetAll()
        {
            return _season.Find(c => true).ToList();
        }

        public Season GetCurrentSeason()
        {
            var seasons = GetAllIncomplete();
            var now = DateTime.UtcNow;
            return seasons.OrderBy(s => s.Order).FirstOrDefault();
        }

        public List<Season> GetAllIncomplete()
        {
            return _season.Find(c => !c.IsComplete).ToList();
        }

        public Season GetById(ObjectId id)
        {
            return _season.Find(c => c.Id == id).FirstOrDefault();
        }

        public Season GetByYearAndQuarter(int year, int quarter)
        {
            return _season.Find(c => c.Year == year && c.Quarter == quarter).FirstOrDefault();
        }

        public Season GetLastSeason()
        {
            return _season.Find(s => s.IsComplete).ToList().OrderByDescending(l => l.Order).FirstOrDefault();
        }
        #endregion

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
