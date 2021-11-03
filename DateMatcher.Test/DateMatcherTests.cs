using System;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace DateMatcher.Test
{
    public class DateMatcherTests
    {
        private readonly IDateMatcher _sut;

        public DateMatcherTests()
        {
            ServiceCollection servicesCollection = new ServiceCollection();
            servicesCollection.AddDateMatcher();
            var serviceProvider = servicesCollection.BuildServiceProvider();
            _sut = serviceProvider.GetRequiredService<IDateMatcher>();

        }
        [Theory]
        [InlineData("2020-01-01","2020-02-02", DateMatchLevel.YearOnly)]
        [InlineData("2020-01-01","2020-01-02", DateMatchLevel.YearAndMonth)]
        [InlineData("2020-01-01","2020-01-01", DateMatchLevel.Exact)]
        public void DateMatcher_Match_ReturnsCorrectLevel(string strDate1, string strDate2, DateMatchLevel expected)
        {
            var date1 = DateTime.Parse(strDate1);
            var date2 = DateTime.Parse(strDate2);
            var actual = _sut.Match(date1, date2);
            Assert.Equal(expected, actual);
        }
    }
}