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
            AtlantaMotorSpeedway,
            AutoClubSpeedway,
            AutodromoInternazionaleEnzoeDinoFerrari,
            AutodromoJoseCarlosPace,
            AutodromoNazionaleMonza,
            BarberMotorsportsPark,
            BarkRiverInternationalRaceway,
            BrandsHatchCircuit,
            BristolMotorSpeedway,
            CanadianTireMotorsportsPark,
            CedarLakeSpeedway,
            CentripetalCircuit,
            CharlotteMotorSpeedway,
            CharlotteMotorSpeedway_2008Legacy,
            ChicagolandSpeedway,
            ChiliBowl,
            CircuitdeBarcelonaCatalunya,
            Circuitdes24HeuresduMans,
            CircuitdeSpaFrancorchamps,
            CircuitGillesVilleneuve,
            CircuitoftheAmericas,
            CircuitZolder,
            ConcordSpeedway,
            CrandonInternationalRaceway,
            DarlingtonRaceway,
            DaytonaInternationalSpeedway,
            DaytonaInternationalSpeedway_2008Legacy,
            DetroitGrandPrixatBelleIsle,
            DoningtonParkRacingCircuit,
            DoverInternationalSpeedway,
            EldoraSpeedway,
            FairburySpeedway,
            FiveFlagsSpeedway,
            HockenheimringBadenWurttemberg,
            HomesteadMiamiSpeedway,
            IndianapolisMotorSpeedway,
            IowaSpeedway,
            IRacingSuperspeedway,
            IrwindaleSpeedway,
            KansasSpeedway,
            KentuckySpeedway_2011Legacy,
            KnoxvilleRaceway,
            KokomoSpeedway,
            LagunaSeca,
            LangleySpeedway,
            LanierNationalSpeedway,
            LankebanenHellRx,
            LasVegasMotorSpeedway,
            LernervilleSpeedway,
            LimalandMotorsportsPark,
            LimeRockPark_2008Legacy,
            LongBeachStreetCircuit,
            LucasOilRaceway,
            MartinsvilleSpeedway,
            MichiganInternationalSpeedway,
            MidOhioSportsCarCourse,
            MountPanoramaCircuit,
            MyrtleBeachSpeedway,
            NashvilleFairgroundsSpeedway,
            NewHampshireMotorSpeedway,
            NewSmyrnaSpeedway,
            NorthWilkesboroSpeedway,
            NurburgringGrandPrixStrecke,
            NurburgringNordschleife,
            OkayamaInternationalCircuit,
            OranParkRaceway,
            OultonParkCircuit,
            OxfordPlainsSpeedway,
            PhillipIslandCircuit,
            PhoenixRaceway,
            PoconoRaceway,
            RichmondRaceway,
            RoadAmerica,
            RockinghamSpeedway,
            SebringInternationalRaceway,
            SilverstoneCircuit,
            SilverstoneCircuit_2008Legacy,
            SnettertonCircuit,
            SonomaRaceway,
            SouthBostonSpeedway,
            StaffordMotorSpeedway,
            SummitPointRaceway,
            SuzukaInternationalRacingCourse,
            TalladegaSuperspeedway,
            TexasMotorSpeedway,
            TheBullring,
            TheDirtTrackatCharlotte,
            TheMilwaukeeMile,
            ThompsonSpeedwayMotorsportsPark,
            TsukubaCircuit,
            TwinRingMotegi,
            UsaInternationalSpeedway,
            VirginiaInternationalRaceway,
            VolusiaSpeedwayPark,
            WatkinsGlenInternational,
            WeedsportSpeedway,
            WildHorsePassMotorsportsPark,
            WildWestMotorsportsPark,
            WilliamsGroveSpeedway,
            WorldWideTechnologyRaceway,
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
        public static Track DarlingtonRaceway => new Track
        {
            Id = new ObjectId("60a7d52750a5905bc3dbedfb"),
            Name = "Darlington Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=115",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track DetroitGrandPrixatBelleIsle => new Track
        {
            Id = new ObjectId("60a7d5827a89ba7052c113c9"),
            Name = "Detroit Grand Prix at Belle Isle",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=319",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Belle Isle",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track DoverInternationalSpeedway => new Track
        {
            Id = new ObjectId("60a7d5dcef43898af68fd69e"),
            Name = "Dover International Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=162",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track EldoraSpeedway => new Track
        {
            Id = new ObjectId("60a7d63fbd666f1cd3437387"),
            Name = "Eldora Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=273",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track FairburySpeedway => new Track
        {
            Id = new ObjectId("60a7d68d57fa35606f0e2cab"),
            Name = "Fairbury Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=344",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track FiveFlagsSpeedway => new Track
        {
            Id = new ObjectId("60a7d6c8aa8a176f23669006"),
            Name = "Five Flags Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=248",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track IRacingSuperspeedway => new Track
        {
            Id = new ObjectId("60a7d72c5dd59c3745bd0c79"),
            Name = "IRacing Superspeedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=384",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track IndianapolisMotorSpeedway => new Track
        {
            Id = new ObjectId("60a7e104d25b00971ceed4a3"),
            Name = "Indianapolis Motor Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=178",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "IndyCar Oval",
                    TrackType = TrackType.Oval
                },
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
                    Name = "Bike",
                    TrackType = TrackType.Road
                },
            }
        }; 
        public static Track IowaSpeedway => new Track
        {
            Id = new ObjectId("60a904ef26d8249eb4b137b5"),
            Name = "Iowa Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=169",
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
                    Name = "Legends",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Infield Legends",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Rallycross",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
        public static Track KansasSpeedway => new Track
        {
            Id = new ObjectId("60a905905b66a0b5e1e36be2"),
            Name = "Kansas Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=214",
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
                    Name = "Infield Road Course",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track KnoxvilleRaceway => new Track
        {
            Id = new ObjectId("60a905dc1eae62455f505fbe"),
            Name = "Knoxville Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=305",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track KokomoSpeedway => new Track
        {
            Id = new ObjectId("60a906a0c2725313138940fd"),
            Name = "Kokomo Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=320",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track LasVegasMotorSpeedway => new Track
        {
            Id = new ObjectId("60a906f51a2a718deb0975cc"),
            Name = "Las Vegas Motor Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=103",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Legends Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Road Course Combined",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Road Course Long",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Road Course Short",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Infield Legends Oval",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track LernervilleSpeedway => new Track
        {
            Id = new ObjectId("60a907bd019ed68e0f0d4ccf"),
            Name = "Lernerville Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=351",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track LongBeachStreetCircuit => new Track
        {
            Id = new ObjectId("60a907df7e53be293f45019d"),
            Name = "Long Beach Street Circuit",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=179",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track LucasOilRaceway => new Track
        {
            Id = new ObjectId("60a9083d0fd1151654f7e97e"),
            Name = "Lucas Oil Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=232",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Rallycross",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
        public static Track LankebanenHellRx => new Track
        {
            Id = new ObjectId("60a9089cf51e1851bfc5d385"),
            Name = "Hell Rallycross",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=358",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Hell Rallycross",
                    TrackType = TrackType.DirtRoad
                },
                new TrackVariant
                {
                    Name = "Club",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Rallycross Short",
                    TrackType = TrackType.DirtRoad
                },
                new TrackVariant
                {
                    Name = "Road Short",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Road Long",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track MichiganInternationalSpeedway => new Track
        {
            Id = new ObjectId("60a909e9a5062a2e43465688"),
            Name = "Michigan International Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=276",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track MyrtleBeachSpeedway => new Track
        {
            Id = new ObjectId("60a909ec844e07122c25e1ff"),
            Name = "Myrtle Beach Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=286",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track NashvilleFairgroundsSpeedway => new Track
        {
            Id = new ObjectId("60a90a274304c584343b2374"),
            Name = "Nashville Fairgrounds Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=374",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Mini",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track NewHampshireMotorSpeedway => new Track
        {
            Id = new ObjectId("60a90a7f37f513fd6956c6dd"),
            Name = "New Hampshire Motor Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=131",
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
                    Name = "Road Course with South Oval",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Road Course with North Oval",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Legends",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track NewSmyrnaSpeedway => new Track
        {
            Id = new ObjectId("60a90b04ed05ab3d04fb9c7a"),
            Name = "New Smyrna Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=190",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track NorthWilkesboroSpeedway => new Track
        {
            Id = new ObjectId("60a90b546cffcfe1281f8d62"),
            Name = "North Wilkesboro Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=366",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "1987",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track NurburgringNordschleife => new Track
        {
            Id = new ObjectId("60a90b9b8d4da6e3b238a423"),
            Name = "Nürburgring Nordschleife",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=249",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Industriefahrten",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Touristenfahrten",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track PhoenixRaceway => new Track
        {
            Id = new ObjectId("60a90ca08f258e3ce666c4c2"),
            Name = "PhoenixRaceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=236",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval w/open dogleg",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track PoconoRaceway => new Track
        {
            Id = new ObjectId("60a90d13e625e21d92d5b059"),
            Name = "Pocono Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=277",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                }
            }
        };
        public static Track RockinghamSpeedway => new Track
        {
            Id = new ObjectId("60a90d533192602b68c81db3"),
            Name = "Rockingham Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=203",
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
                    Name = "Infield Road Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Short Road Course",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track SilverstoneCircuit => new Track
        {
            Id = new ObjectId("60a90ddd32ac885bfac0b170"),
            Name = "Silverstone Circuit",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=341",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "International",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "National",
                    TrackType = TrackType.Road
                }
            }
        };
        public static Track SnettertonCircuit => new Track
        {
            Id = new ObjectId("60a90e2fdbec4f274a28ec0b"),
            Name = "Snetterton Circuit",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=297",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "300",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "200",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "100",
                    TrackType = TrackType.Road
                }
            }
        };
        public static Track TalladegaSuperspeedway => new Track
        {
            Id = new ObjectId("60a90eaed47436cfc9efbdca"),
            Name = "Talladega Superspeedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=116",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track TexasMotorSpeedway => new Track
        {
            Id = new ObjectId("60a90effbf2e50bfd6e75a73"),
            Name = "Texas Motor Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=357",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Legends Oval",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track TheBullring => new Track
        {
            Id = new ObjectId("60a90f56b297b6c3490a982d"),
            Name = "The Bullring",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=271",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track TheDirtTrackatCharlotte => new Track
        {
            Id = new ObjectId("60a90f8fdf97ac861126eebf"),
            Name = "The Dirt Track at Charlotte",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=271",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track TheMilwaukeeMile => new Track
        {
            Id = new ObjectId("60aa59b3af9787f03033f7bd"),
            Name = "The Milwaukee Mile",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=94",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track VolusiaSpeedwayPark => new Track
        {
            Id = new ObjectId("60aa5a0937bbb8ef24ddb378"),
            Name = "Volusia Speedway Park",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=279",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track WeedsportSpeedway => new Track
        {
            Id = new ObjectId("60aa5a50713e253ef11f4ed5"),
            Name = "Weedsport Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=373",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track WildHorsePassMotorsportsPark => new Track
        {
            Id = new ObjectId("60aa5a9ea0d2175fe9e099d2"),
            Name = "Wild Horse Pass Motorsports Park",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=334",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
        public static Track WildWestMotorsportsPark => new Track
        {
            Id = new ObjectId("60aa5af0070bdf01c3cfbd09"),
            Name = "Wild West Motorsports Park",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=332",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
        public static Track WilliamsGroveSpeedway => new Track
        {
            Id = new ObjectId("60aa5b35d29ea38173c2397b"),
            Name = "Williams Grove Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=274",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track WorldWideTechnologyRaceway => new Track
        {
            Id = new ObjectId("60aa5b8d9f5a4144e554f26b"),
            Name = "World Wide Technology Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=237",
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
            }
        };
        public static Track KentuckySpeedway_2011Legacy => new Track
        {
            Id = new ObjectId("60aa5bf79ddc6589e8d75281"),
            Name = "[Legacy] Kentucky Speedway - 2011",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=188",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Legends",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track AutodromoInternazionaleEnzoeDinoFerrari => new Track
        {
            Id = new ObjectId("60aa5cf022a42919ff35ef73"),
            Name = "Autodromo Internazionale Enzo e Dino Ferrari",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=266",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Moto",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track AutodromoNazionaleMonza => new Track
        {
            Id = new ObjectId("60aa5cf44a46d5095fcbc770"),
            Name = "Autodromo Nazionale Monza",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=239",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "GP without first chicane",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "GP without chicanes",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Combined",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Combined without first chicane",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Combined without chicanes",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Junior",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Oval - Right turning",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Oval - Left turning",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track AutodromoJoseCarlosPace => new Track
        {
            Id = new ObjectId("60aa5d9c906a934a03c74b09"),
            Name = "Autódromo José Carlos Pace",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=212",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Moto",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track BrandsHatchCircuit => new Track
        {
            Id = new ObjectId("60aa5e082eb0e000650446da"),
            Name = "Brands Hatch Circuit",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=290",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Indy",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Rallycross",
                    TrackType = TrackType.DirtRoad
                },
            }
        };
        public static Track CentripetalCircuit => new Track
        {
            Id = new ObjectId("60aa5eb18e7a4b634f5fa71c"),
            Name = "Centripetal Circuit",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=143",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track CharlotteMotorSpeedway => new Track
        {
            Id = new ObjectId("60aa5ebaa383b7007266c904"),
            Name = "Charlotte Motor Speedway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=350",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Roval",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Rallycross",
                    TrackType = TrackType.DirtRoad
                },
                new TrackVariant
                {
                    Name = "Oval - 2018",
                    TrackType = TrackType.DirtRoad
                },
                new TrackVariant
                {
                    Name = "Roval - 2018",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Roval Long - 2018",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Legends Oval - 2018",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Legends RC Short - 2018",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Legends RC Medium - 2018",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Legends RC Long - 2018",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track CircuitdeSpaFrancorchamps => new Track
        {
            Id = new ObjectId("60aa5fb8bb1d8e4b17382389"),
            Name = "Circuit de Spa-Francorchamps",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=165",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Endurance",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Classic Pits",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Grand Prix Pits",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track CircuitoftheAmericas => new Track
        {
            Id = new ObjectId("60aa602438e6de629c3b859a"),
            Name = "Circuit of the Americas",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=229",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "East",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "West",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track DaytonaInternationalSpeedway => new Track
        {
            Id = new ObjectId("60aa60a03aa3b86fb4a38749"),
            Name = "Daytona International Speedway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=191",
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
                    Name = "NASCAR Road",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track DoningtonParkRacingCircuit => new Track
        {
            Id = new ObjectId("60aa6134488a4b8efb5166b7"),
            Name = "Donington Park Racing Circuit",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=233",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "National",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track HockenheimringBadenWurttemberg => new Track
        {
            Id = new ObjectId("60aa618c426cb2f9c646944c"),
            Name = "Hockenheimring Baden-Württemberg",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=390",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "National A",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "National B",
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
                },
                new TrackVariant
                {
                    Name = "Outer",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track LangleySpeedway => new Track
        {
            Id = new ObjectId("60aa624b95cb38a97c73547f"),
            Name = "Langley Speedway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=201",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track LimalandMotorsportsPark => new Track
        {
            Id = new ObjectId("60aa6289f75d120025a9928c"),
            Name = "Limaland Motorsports Park",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=303",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.DirtOval
                },
            }
        };
        public static Track MidOhioSportsCarCourse => new Track
        {
            Id = new ObjectId("60aa6301bbdd2fcde9c9a631"),
            Name = "Mid-Ohio Sports Car Course",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=153",
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
                    Name = "Short",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
                new TrackVariant
                {
                    Name = "Alt Oval",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track MountPanoramaCircuit => new Track
        {
            Id = new ObjectId("60aa6392d23e0937efd40ce8"),
            Name = "Mount Panorama Circuit",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=219",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track NurburgringGrandPrixStrecke => new Track
        {
            Id = new ObjectId("60ab5b8b482e6b9f9e09b0b2"),
            Name = "Nürburgring Grand-Prix-Strecke",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=257",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix w/out Arena",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "BES/WEC",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Sprintstrecke",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Kurzanbindung w/out Arena",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Müllenbachschleife",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track OkayamaInternationalCircuit => new Track
        {
            Id = new ObjectId("60ab5c25f5c06d93d72881dd"),
            Name = "Okayama International Circuit",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=166",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Full Course",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Short",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track OranParkRaceway => new Track
        {
            Id = new ObjectId("60ab5c67c65a4e286dcad434"),
            Name = "Oran Park Raceway",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=202",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
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
                    Name = "North A",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "North B",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Moto",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track OultonParkCircuit => new Track
        {
            Id = new ObjectId("60ab64a7d43627b974f475bc"),
            Name = "Oulton Park Circuit",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=180",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "International",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Fosters",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Island",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Intl w/out Hislop",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Intl w/out Brittens",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Intl w/out Chicanes",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Fosters w/Hislop",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Island Historic",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track PhillipIslandCircuit => new Track
        {
            Id = new ObjectId("60ab690160a0be6c02ea4d2b"),
            Name = "Phillip Island Circuit",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=152",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track SebringInternationalRaceway => new Track
        {
            Id = new ObjectId("60ab69e08394c39d67d982b8"),
            Name = "Sebring International Raceway",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=95",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "International",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Club",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Modified",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track SouthernNationalMotorsportsPark => new Track
        {
            Id = new ObjectId("60ab69380ad35a52d91ed43f"),
            Name = "Southern National Motorsports Park",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=256",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track SuzukaInternationalRacingCourse => new Track
        {
            Id = new ObjectId("60ab6aae53968194d679950c"),
            Name = "Suzuka International Racing Course",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=168",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Moto",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "East",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "West",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "West w/chicane",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track ThompsonSpeedwayMotorsportsPark => new Track
        {
            Id = new ObjectId("60ab6bdd317f72fb7279ee4d"),
            Name = "Thompson Speedway Motorsports Park",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=161",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track TsukubaCircuit => new Track
        {
            Id = new ObjectId("60ab6bf663605423d6cbece7"),
            Name = "Tsukuba Circuit",
            TrackAvailability = TrackAvailability.Free,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=324",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "2000 Full",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "2000 Moto",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "2000 Short",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "1000 Full",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "1000 Outer",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "1000 Chicane",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "1000 Full Reverse",
                    TrackType = TrackType.Road
                },
            }
        };
        public static Track TwinRingMotegi => new Track
        {
            Id = new ObjectId("60ab6ce59020bcc2acafc513"),
            Name = "Twin Ring Motegi",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=195",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Grand Prix",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "East",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "West",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Oval",
                    TrackType = TrackType.Oval
                },
            }
        };
        public static Track WatkinsGlenInternational => new Track
        {
            Id = new ObjectId("60ab6ced40c4451039390bdd"),
            Name = "Watkins Glen International",
            TrackAvailability = TrackAvailability.Paid,
            Url = "https://members.iracing.com/membersite/member/TrackDetail.do?trkid=106",
            Variants = new List<TrackVariant>
            {
                new TrackVariant
                {
                    Name = "Cup",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Boot",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Classic Boot",
                    TrackType = TrackType.Road
                },
                new TrackVariant
                {
                    Name = "Classic",
                    TrackType = TrackType.Oval
                },
            }
        };
    }
}
