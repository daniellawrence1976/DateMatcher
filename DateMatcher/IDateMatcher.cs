using System;

namespace DateMatcher.Interfaces
{
    public interface IDateMatcher
    {
        DateMatchLevel Match(DateTime date1, DateTime date2);
    }
}