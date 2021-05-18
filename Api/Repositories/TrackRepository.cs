using MongoDB.Bson;
using MongoDB.Driver;
using SeasonVoting.Api.Models;
using System.Collections.Generic;

namespace SeasonVoting.Api.Repositories
{
    public class TrackRepository : RepositoryBase
    {
        private readonly IMongoCollection<Track> _track;
        public TrackRepository()
        {
           // _track = Database.GetCollection<Track>(CollectionNames.Track);
        }

        public List<Track> GetAll()
        {
            //  return _track.Find(c => true).ToList();
            return StaticClasses.Tracks.AllTracks;
        }

        public Track GetById(ObjectId id)
        {
            return  _track.Find(c => c.Id == id).FirstOrDefault();
        }
        public Track Create(Track track)
        {
            _track.InsertOne(track);
            return track;
        }
        public void Update(ObjectId id, Track track)
        {
            _track.ReplaceOne(c => c.Id == id, track);
        }
        public void Delete(ObjectId id)
        {
            _track.DeleteOne(c => c.Id == id);
        }
    }
}
