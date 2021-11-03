using System;
using System.Collections.Generic;
using System.Linq;
using DateMatcher.LevelMatcher;

namespace DateMatcher.Services
{
    class DateMatcher : IDateMatcher
    {
        private readonly IList<ILevelMatcher> _levelMatchers;
        
        public DateMatcher(IEnumerable<ILevelMatcher> levelMatchers)
        {
            _levelMatchers = levelMatchers
                .OrderByDescending(l => l.MatchLevel)
                .ToList();
        }
        public DateMatchLevel Match(DateTime date1, DateTime date2)
        {
            var matcher = _levelMatchers.FirstOrDefault(l => l.Equals(date1, date2));
            return matcher?.MatchLevel ?? DateMatchLevel.NoMatch;
        }
    }
}