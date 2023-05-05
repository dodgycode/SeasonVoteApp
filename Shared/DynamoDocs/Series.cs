using Amazon.DynamoDBv2.DataModel;
using EnumsNET;
using System.Collections.Generic;
using System.ComponentModel;

namespace SeasonVoting.Shared.DynamoDocs
{
    [DynamoDBTable("SeasonVoting_Series")]
    public class Series
    {
        [DynamoDBHashKey] public string Name { get; set; }
        [DynamoDBRangeKey] public string Discipline { get; set; }
        [DynamoDBProperty] public string? Description { get; set; }

        public static List<Series> AllSeries()
        {
            return new List<Series>
        {
            new Series
            {
                Name = "Formula Renault 3.5",
                Discipline = SeriesDiscipline.Road.AsString(EnumFormat.Description),
                Description = "Where Ricciardo made his start. And others."
            },
            new Series
            {
                Name = "Skippy",
                Discipline = SeriesDiscipline.Road.AsString(EnumFormat.Description),
                Description = "The bush kangaroo"
            },
            new Series
            {
                Name = "NASCAR",
                Discipline = SeriesDiscipline.Oval.AsString(EnumFormat.Description),
                Description = "Rednecks and bump drafts"
            }
        };
        }
    }

    public enum SeriesDiscipline
    {
        [Description("Road")] Road,
        [Description("Oval")] Oval,
        [Description("DirtRoad")] DirtRoad,
        [Description("DirtOval")] DirtOval,
        [Description("RoadAndOval")] RoadAndOval
    }

}
