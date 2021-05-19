using MongoDB.Bson;

namespace SeasonVoting.Api.StaticClasses
{
    public static class BsonTools
    {
        /// <summary>
        /// Check ObjectId is valid. If not, return a new ObjectId.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ObjectId ResolveObjectId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return ObjectId.GenerateNewId();
            }
            if(new ObjectId(id) == ObjectId.Empty)
            {
                return ObjectId.GenerateNewId();
            }
            return new ObjectId(id);
        }

        /// <summary>
        /// Check ObjectId is valid. If not, return a new ObjectId.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ObjectId ResolveObjectId(ObjectId id)
        {
            if(id == ObjectId.Empty)
            {
                return ObjectId.GenerateNewId();
            }
            return id;
        }
    }
}
