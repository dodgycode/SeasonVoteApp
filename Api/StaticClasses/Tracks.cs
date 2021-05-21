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
            RichmondRaceway,
            MartinsvilleSpeedway,
            CharlotteMotorSpeedway_2008Legacy,
            SilverstoneCircuit_2008Legacy,
            BarberMotorsportsPark,
            LagunaSeca,
            SonomaRaceway,
            AtlantaMotorSpeedway,
            AutoClubSpeedway,
            BarkRiverInternationalRaceway,
            BristolMotorSpeedway,
            CanadianTireMotorsportsPark,
            CedarLakeSpeedway,
            ChicagolandSpeedway,
            ChiliBowl,
            CircuitGillesVilleneuve,
            CircuitZolder,
            CircuitdeBarcelonaCatalunya,
            Circuitdes24HeuresduMans,
            CrandonInternationalRaceway
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
        public static Track MartinsvilleSpeedway => new Track
        {
            Id = new ObjectId("60a766d19bda052b17d6b759"),
            Name = "Martinsville Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=33",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track CharlotteMotorSpeedway_2008Legacy => new Track
        {
            Id = new ObjectId("60a767a7a736cd3fbe584262"),
            Name = "[Legacy] Charlotte Motor Speedway - 2008",
            TrackAvailability = TrackAvailability.Legacy,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=37",
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
                    Name = "Legends Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Infield Road Course",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track SilverstoneCircuit_2008Legacy => new Track
        {
            Id = new ObjectId("60a767b63f84af2df0f088c8"),
            Name = "[Legacy] Silverstone Circuit - 2008",
            TrackAvailability = TrackAvailability.Legacy,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=41",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Historical Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "International",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Southern",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "National",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track BarberMotorsportsPark => new Track
        {
            Id = new ObjectId("60a7684dd8a7e31362a12bf8"),
            Name = "Barber Motorsports Park",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=46",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Short A",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Short B",
                    TrackType = TrackType.Road
                }
            }
        };
        public static Track LagunaSeca => new Track
        {
            Id = new ObjectId("60a7696b28d3e4f15b444b97"),
            Name = "WeatherTech Raceway at Laguna Seca",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=47",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "School",
                    TrackType = TrackType.Road
                }
            }
        };
        public static Track SonomaRaceway => new Track
        {
            Id = new ObjectId("60a76a806d3015dbc6cc637e"),
            Name = "Sonoma Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=48",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "IndyCar 2012-2018",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "IndyCar 2008-2011",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Cup Historic",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Cup",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "IndyCar pre-2008",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "RallyCross",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
        public static Track AtlantaMotorSpeedway => new Track
        {
            Id = new ObjectId("60a76adf236a0839f3a372ad"),
            Name = "Atlanta Motor Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=51",
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
                    Name = "Legends Oval",
                    TrackType = TrackType.Oval
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
                }
            }
        };
        public static Track AutoClubSpeedway => new Track
        {
            Id = new ObjectId("60a76bc750485f1e24f20db2"),
            Name = "Auto Club Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=225",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Competition",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Moto",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Interior",
                    TrackType = TrackType.Road
                }
            }
        };
        public static Track BarkRiverInternationalRaceway => new Track
        {
            Id = new ObjectId("60a76c8935ad5e6b2c6ef81c"),
            Name = "Bark River International Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=396",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtRoad
                }
            }
        };
        public static Track BristolMotorSpeedway => new Track
        {
            Id = new ObjectId("60a76cdd7c4161dd0bc049b9"),
            Name = "Bristol Motor Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=287",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Dirt",
                    TrackType = TrackType.DirtOval
                },
                new TrackVariant
                {
                    Name = "Dual Pit Roads",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Single Pit Road",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track CanadianTireMotorsportsPark => new Track
        {
            Id = new ObjectId("60a76d0cfd9c78806421428d"),
            Name = "Canadian Tire Motorsports Park",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=144",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Road
                }
            }
        };
        public static Track CedarLakeSpeedway => new Track
        {
            Id = new ObjectId("60a76d9b4f8aa37f2335316c"),
            Name = "Cedar Lake Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=387",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                }
            }
        };
        public static Track ChicagolandSpeedway => new Track
        {
            Id = new ObjectId("60a7abb43cb3058fbfcf465a"),
            Name = "Chicagoland Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=123",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                }
            }
        };
        public static Track ChiliBowl => new Track
        {
            Id = new ObjectId("60a7abe5d3a31f5b9363f248"),
            Name = "Chili Bowl",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=331",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                }
            }
        };
        public static Track CircuitGillesVilleneuve => new Track
        {
            Id = new ObjectId("60a7ac2ca0c56341a1315577"),
            Name = "Circuit Gilles Villeneuve",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=218",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Road
                }
            }
        };
        public static Track CircuitZolder => new Track
        {
            Id = new ObjectId("60a7ac6329022cca60a900ef"),
            Name = "Circuit Zolder",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=199",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Alternate",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track CircuitdeBarcelonaCatalunya => new Track
        {
            Id = new ObjectId("60a7ad26ed683e5b20971266"),
            Name = "Circuit de Barcelona Catalunya",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=345",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Rallycross",
                    TrackType = TrackType.DirtRoad
                },
                new TrackVariant
                {
                    Name = "National",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Club",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Moto",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Historic",
                    TrackType = TrackType.Road
                },
            }
        }; 
        public static Track Circuitdes24HeuresduMans => new Track
        {
            Id = new ObjectId("60a7ad2d21e1604463c3d6e5"),
            Name = "Circuit des 24 Heures du Mans",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=268",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "24 Heures du Mans",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Historic",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track CrandonInternationalRaceway => new Track
        {
            Id = new ObjectId("60a7ad7967ad3044e125a3a6"),
            Name = "CrandonInternationalRaceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=382",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full",
                    TrackType = TrackType.DirtRoad
                },
                new TrackVariant
                {
                    Name = "Short",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
    }
}
