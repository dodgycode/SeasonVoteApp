using System;

namespace SeasonVoting.Api
{
    public class VoteAlreadyCastException : Exception
    {
        public VoteAlreadyCastException(string message) : base(message) { }
    }
}
