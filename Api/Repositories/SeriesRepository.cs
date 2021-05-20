using MongoDB.Bson;
using MongoDB.Driver;
using SeasonVoting.Api.Models;
using System.Collections.Generic;

namespace SeasonVoting.Api.Repositories
{
    public class SeriesRepository : RepositoryBase
    {
        private readonly IMongoCollection<Series> _series;
        public SeriesRepository()
        {
            _series = Database.GetCollection<Series>(CollectionNames.Series);
        }

        public List<Series> GetAll()
        {
            return _series.Find(c => true).ToList();
        }

        public Series GetById(ObjectId id)
        {
            return  _series.Find(c => c.Id == id).FirstOrDefault();
        }

        public List<Series> GetBySeasonId(ObjectId seasonId)
        {
            return  _series.Find(c => c.SeasonId == seasonId).ToList();
        }

        public Series Create(Series series)
        {
            _series.InsertOne(series);
            return series;
        }
        public void Update(ObjectId id, Series series)
        {
            _series.ReplaceOne(c => c.Id == id, series);
        }
        public void Delete(ObjectId id)
        {
            _series.DeleteOne(c => c.Id == id);
        }
    }
}
