using System;
using System.Collections.Generic;

namespace DateMatcher.LevelMatcher
{
    interface ILevelMatcher : IEqualityComparer<DateTime>
    {
        DateMatchLevel MatchLevel { get; }
    }
}