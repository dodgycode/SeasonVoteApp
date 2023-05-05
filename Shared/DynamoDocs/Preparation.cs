using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;

namespace SeasonVoting.Shared.DynamoDocs
{
    [DynamoDBTable("SeasonVoting_Preparation")]
    public class Preparation
    {
        [DynamoDBHashKey] public string Season { get; set; }
        [DynamoDBRangeKey] public string Series { get; set; }

        public List<PreparationTier> Tiers { get; set; } = new List<PreparationTier>();
        
        public static Preparation Example()
        {
            return new Preparation()
            {
                Season = "2023_S2",
                Series = "Formula Renault 3.5",
                Tiers = new List<PreparationTier>()
                {
                    new PreparationTier()
                    {
                        Name = "Free tracks",
                        Order = 1,
                        Tracks = new List<PreparationTrack>
                        {
                            new PreparationTrack()
                            {
                                TrackId = "boop",
                                Name = "Circuito de Jerez"
                            }
                        }
                    }
                }
            };
        }
    }

    public class PreparationTier
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public List<PreparationTrack> Tracks { get; set; } = new List<PreparationTrack>();

        #region Rules
        /// <summary>
        /// How many tracks are to be selected from this teir?
        /// </summary>
        public int NumberToBeSelected { get; set; }

        /// <summary>
        /// How many tracks are voters to select during voting?
        /// </summary>
        public int NumberToBeVotedOn { get; set; }

        /// <summary>
        /// What is the maximum number of times in a year (4 seasons) the track can be run once selected?
        /// </summary>
        public int MaxSeasonsTrackCanRunPerYear { get; set; }

        /// <summary>
        /// What is the maximum number of consecutive seasons the track can run before it's given a break?
        /// </summary>
        public int MaxConsecutiveSeasonsTracksCanRun { get; set; }

        /// <summary>
        /// Once a track is selected, how many seasons should it be locked in for (e.g. Skippy Rotation)?
        /// </summary>
        public int MinConsecutiveSeasonsTrackWillRunOnceSelected { get; set; }

        /// <summary>
        /// Voters should number their choices (e.g. 1,2,3).
        /// </summary>
        public bool SelectionsShouldBeOrdered { get; set; }

        #endregion

    }

    public class PreparationTrack
    {
        public string TrackId { get; set; }
        public string Name { get; set; }
    }
}
