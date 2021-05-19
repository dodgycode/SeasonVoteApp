using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SeasonVoting.Api.StaticClasses;
using SeasonVoting.Shared;
using System.Collections.Generic;

namespace SeasonVoting.Api.Models
{
    public class TrackTier
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public int NumberToBeSelectedFromTier { get; set; }

        public List<Track> Tracks { get; set; } = new List<Track>();

        #region Public Methods
        public static TierViewModel ToViewModel(TrackTier tier)
        {
            var tierVm = new TierViewModel
            {
                Id = BsonTools.ResolveObjectId(tier.Id).ToString(),
                Name = tier.Name,
                NumberToBeSelectedFromTier = tier.NumberToBeSelectedFromTier,
            };
            if (tier.Tracks == null) { tier.Tracks = new List<Track>(); }
            foreach (var track in tier.Tracks)
            {
                tierVm.Tracks.Add(Track.ToViewModel(track));
            }

            return tierVm;
        } 
        #endregion
    }
}
