using Sut = Exercism.Leap.Leap;

namespace Exercism.Test.Leap;

[TestClass]
public class LeapTests
{
    [TestMethod]
    public void Year_not_divisible_by_4_is_common_year()
    {
        Assert.IsFalse(Sut.IsLeapYear(2015));
    }
    
    [TestMethod]
    public void Year_divisible_by_4_not_divisible_by_100_is_leap_year()
    {
        Assert.IsTrue(Sut.IsLeapYear(2016));
    }
    
    [TestMethod]
    public void Year_divisible_by_100_not_divisible_by_400_is_common_year()
    {
        Assert.IsFalse(Sut.IsLeapYear(2100));
    }
    
    [TestMethod]
    public void Year_divisible_by_400_is_leap_year()
    {
        Assert.IsTrue(Sut.IsLeapYear(2000));
    }
}