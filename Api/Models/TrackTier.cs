﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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

        public List<Track> Tracks { get; set; }
    }
}
