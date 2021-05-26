using MongoDB.Bson;
using MongoDB.Driver;
using SeasonVoting.Api.Models.Voting;
using System.Collections.Generic;

namespace SeasonVoting.Api.Repositories
{
    public class SeriesVotingRepository : RepositoryBase
    {
        private readonly IMongoCollection<SeriesVoting> _series;
        public SeriesVotingRepository()
        {
            _series = Database.GetCollection<SeriesVoting>(CollectionNames.Voting);
        }

        public List<SeriesVoting> GetAll()
        {
            return _series.Find(c => true).ToList();
        }

        public SeriesVoting GetBySeriesAndVoter(ObjectId seriesId, string voterName)
        {
            return  _series.Find(c => c.SeriesId == seriesId && c.VoterName == voterName).FirstOrDefault();
        }

        public SeriesVoting Create(SeriesVoting series)
        {
            _series.InsertOne(series);
            return series;
        }
        public void Update(ObjectId id, SeriesVoting series)
        {
            _series.ReplaceOne(c => c.Id == id, series);
        }
        public void Delete(ObjectId id)
        {
            _series.DeleteOne(c => c.Id == id);
        }
    }
}
