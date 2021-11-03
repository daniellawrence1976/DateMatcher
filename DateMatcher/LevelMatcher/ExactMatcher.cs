using System;

namespace DateMatcher.LevelMatcher
{
    class ExactMatcher : ILevelMatcher
    {
        public DateMatchLevel MatchLevel => DateMatchLevel.Exact;

        public bool Equals(DateTime x, DateTime y)
        {
            return x.Date.Equals(y.Date);
        }

        public int GetHashCode(DateTime obj)
        {
            return obj.Date.GetHashCode();
        }
    }
}