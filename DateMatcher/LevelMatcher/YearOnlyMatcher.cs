using System;

namespace DateMatcher.LevelMatcher
{
    class YearOnlyMatcher : ILevelMatcher
    {
        public DateMatchLevel MatchLevel => DateMatchLevel.YearOnly;

        public bool Equals(DateTime x, DateTime y)
        {
            return x.Year == y.Year;
        }

        public int GetHashCode(DateTime obj)
        {
            return obj.Year;
        }
    }
}