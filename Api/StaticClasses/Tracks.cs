using MongoDB.Bson;
using SeasonVoting.Api.Enums;
using SeasonVoting.Api.Models.Config;
using System.Collections.Generic;

namespace SeasonVoting.Api.StaticClasses
{
    public static class Tracks
    {
        public static List<Track> AllTracks = new List<Track>
        {
            LimeRockPark_2008Legacy,
            VirginiaInternationalRaceway,
            SummitPointRaceway,
            StaffordMotorSpeedway,
            OxfordPlainsSpeedway,
            SouthBostonSpeedway,
            ConcordSpeedway,
            UsaInternationalSpeedway,
            LanierNationalSpeedway,
            RoadAmerica,
            IrwindaleSpeedway,
            HomesteadMiamiSpeedway,
            DaytonaInternationalSpeedway_2008Legacy,
            RichmondRaceway
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
        public static Track StaffordMotorSpeedway => new Track
        {
            Id = new ObjectId("60a657d2fad4fe9114d53c86"),
            Name = "Stafford Motor Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=11",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full Course",
                    TrackType = TrackType.Oval
                }
            }
        };
        public static Track OxfordPlainsSpeedway => new Track
        {
            Id = new ObjectId("60a658f8dd6ba2ac4035ae91"),
            Name = "Oxford Plains Speedway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=12",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                }
            }
        };
        public static Track SouthBostonSpeedway => new Track
        {
            Id = new ObjectId("60a6598dce5ec032fd979834"),
            Name = "South Boston Speedway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=14",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                }
            }
        };        
        public static Track ConcordSpeedway => new Track
        {
            Id = new ObjectId("60a659f506535082c6d86a56"),
            Name = "Concord Speedway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=15",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                }
            }
        };  
        public static Track UsaInternationalSpeedway => new Track
        {
            Id = new ObjectId("60a65a4b6a40a65e8bee584e"),
            Name = "USA International Speedway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=16",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Asphalt",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Dirt",
                    TrackType = TrackType.DirtOval
                },
            }
        };        
        public static Track LanierNationalSpeedway => new Track
        {
            Id = new ObjectId("60a65a82a34a0301d19e8c30"),
            Name = "Lanier National Speedway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=17",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Asphalt",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Dirt",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track RoadAmerica => new Track
        {
            Id = new ObjectId("60a65ace5f8478847c840493"),
            Name = "Road America",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=18",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Bend",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track IrwindaleSpeedway => new Track
        {
            Id = new ObjectId("60a65b4c58170ade3cf41548"),
            Name = "Irwindale Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=19",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Figure Eight Jump",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Outer",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Inner",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Outer - Inner",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Figure Eight",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track HomesteadMiamiSpeedway => new Track
        {
            Id = new ObjectId("60a65bf46170deeb06b8bb1a"),
            Name = "Homestead Miami Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=20",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Road Course A",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Road Course B",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Indycar Oval",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track DaytonaInternationalSpeedway_2008Legacy => new Track
        {
            Id = new ObjectId("60a65c7e27502ccf1c98ea49"),
            Name = "[Legacy] Daytona International Speedway - 2008",
            TrackAvailability = TrackAvailability.Legacy,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=26",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Road Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Moto",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Short",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Rallycross Short",
                    TrackType = TrackType.DirtRoad
                },
                new TrackVariant
                {
                    Name = "Rallycross Long",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
        public static Track RichmondRaceway => new Track
        {
            Id = new ObjectId("60a6610d6869228f49c0a041"),
            Name = "Richmond Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=31",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };

    }
}
