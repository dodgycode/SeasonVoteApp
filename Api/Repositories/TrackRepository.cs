using MongoDB.Bson;
using MongoDB.Driver;
using SeasonVoting.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace SeasonVoting.Api.Repositories
{
    public class TrackRepository : RepositoryBase
    {
        public List<Track> GetAll()
        {
            //  return _track.Find(c => true).ToList();
            return StaticClasses.Tracks.AllTracks;
        }

        public Track GetById(ObjectId id)
        {
            return  StaticClasses.Tracks.AllTracks.FirstOrDefault(t=>t.Id == id);
        }
        public Track GetByName(string name)
        {
            return  StaticClasses.Tracks.AllTracks.FirstOrDefault(t=>t.Name == name);
        }
        
    }
}
