using System;

namespace DateMatcher.LevelMatcher
{
    class YearMonthMatcher : ILevelMatcher
    {
        public DateMatchLevel MatchLevel => DateMatchLevel.YearAndMonth;

        public bool Equals(DateTime x, DateTime y)
        {
            return x.Month == y.Month && x.Year == y.Year;
        }

        public int GetHashCode(DateTime obj)
        {
            unchecked
            {
                return (obj.Month * 397) ^ obj.Year;
            }
        }
    }
}