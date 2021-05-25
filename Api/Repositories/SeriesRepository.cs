using MongoDB.Bson;
using MongoDB.Driver;
using SeasonVoting.Api.Models.Preparation;
using System.Collections.Generic;

namespace SeasonVoting.Api.Repositories
{
    public class SeriesRepository : RepositoryBase
    {
        private readonly IMongoCollection<ScheduleSeries> _series;
        public SeriesRepository()
        {
            _series = Database.GetCollection<ScheduleSeries>(CollectionNames.Series);
        }

        public List<ScheduleSeries> GetAll()
        {
            return _series.Find(c => true).ToList();
        }

        public ScheduleSeries GetById(ObjectId id)
        {
            return  _series.Find(c => c.Id == id).FirstOrDefault();
        }

        public List<ScheduleSeries> GetBySeasonId(ObjectId seasonId)
        {
            return  _series.Find(c => c.SeasonId == seasonId).ToList();
        }

        public ScheduleSeries Create(ScheduleSeries series)
        {
            _series.InsertOne(series);
            return series;
        }
        public void Update(ObjectId id, ScheduleSeries series)
        {
            _series.ReplaceOne(c => c.Id == id, series);
        }
        public void Delete(ObjectId id)
        {
            _series.DeleteOne(c => c.Id == id);
        }
    }
}
