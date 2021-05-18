using MongoDB.Bson;

namespace SeasonVoting.Shared
{
    public class SeasonViewModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
