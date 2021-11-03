using System;

namespace DateMatcher
{
    public interface IDateMatcher
    {
        DateMatchLevel Match(DateTime date1, DateTime date2);
    }
}