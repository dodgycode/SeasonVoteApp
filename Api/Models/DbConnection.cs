namespace SeasonVoting.Api.Models
{
    public static class DbConnection
    {
        public const string ConnectionString = "mongodb+srv://SeasonVotingUser:sXKWVG65bPaMebx@seasonvoting.ys7dr.mongodb.net/season_voting?retryWrites=true&w=majority";
        public const string DatabaseName = "season_voting";
    }

    public static class CollectionNames
    {
        public const string Season = "season";
    }
}
