using System;
using Xunit;

namespace LeapYear
{
    public class LeapYearTest
    {
        [Fact]
        public void IsLeapYear_NumberDivisibleByFour_true()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.Equal(true, testLeapYear.IsLeapYear(2012));
        }
        [Fact]
        public void IsLeapYear_NumberNotDivisibleByFour_false()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.Equal(false, testLeapYear.IsLeapYear(2011));
        }
        [Fact]
        public void IsLeapYear_NumberDivisibleByOneHundred_false()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.Equal(false, testLeapYear.IsLeapYear(1900));
        }
        [Fact]
        public void IsLeapYear_NumberDivisibleByFourHundred_true()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.Equal(true, testLeapYear.IsLeapYear(2000));
        }
    }
}
