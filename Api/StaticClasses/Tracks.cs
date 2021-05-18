using MongoDB.Bson;
using SeasonVoting.Api.Enums;
using SeasonVoting.Api.Models;
using System.Collections.Generic;

namespace SeasonVoting.Api.StaticClasses
{
    public static class Tracks
    {
        public static List<Track> AllTracks = new List<Track>
        {
            LimeRockPark_2008Legacy,
            VirginiaInternationalRaceway,
            SummitPointRaceway
        };

        public static Track LimeRockPark_2008Legacy => new Track
        {
            Id = new ObjectId("60a3d739c08b85a955d360c4"),
            Name = "[Legacy] Lime Rock Park - 2008",
            TrackAvailability = TrackAvailability.Legacy,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=1",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Chicane",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "School",
                    TrackType = TrackType.Road
                }
            }
        };

        public static Track VirginiaInternationalRaceway => new Track
        {
            Id = new ObjectId("60a3d8558c2949e22a8803b2"),
            Name = "Virginia International Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=2",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "South",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "North",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Patriot",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Grand West",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Grand East",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Patriot Reverse",
                    TrackType = TrackType.Road
                }
            }
        };

        public static Track SummitPointRaceway => new Track
        {
            Id = new ObjectId("60a3d86027eb790644a10656"),
            Name = "Summit Point Raceway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=9",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Summit Point Raceway",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Jefferson Circuit",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Short",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Jefferson Reverse",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "School",
                    TrackType = TrackType.Road
                }
            }
        };
    }
}
