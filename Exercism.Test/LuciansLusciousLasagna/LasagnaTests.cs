using Exercism.LuciansLusciousLasagna;

namespace Exercism.Test.LuciansLusciousLasagna;

[TestClass]
public class LasagnaTests
{
    [TestMethod]
    public void Expected_minutes_in_oven()
    {
        Assert.AreEqual(40, new Lasagna().ExpectedMinutesInOven());
    }
    
    [TestMethod]
    public void Remaining_minutes_in_oven()
    {
        Assert.AreEqual(15, new Lasagna().RemainingMinutesInOven(25));
    }
    
    [TestMethod]
    public void Preparation_time_in_minutes_for_one_layer()
    {
        Assert.AreEqual(2, new Lasagna().PreparationTimeInMinutes(1));
    }
    
    [TestMethod]
    public void Preparation_time_in_minutes_for_multiple_layers()
    {
        Assert.AreEqual(8, new Lasagna().PreparationTimeInMinutes(4));
    }
    
    [TestMethod]
    public void Total_elapsed_time_in_minutes_for_one_layer()
    {
        Assert.AreEqual(32, new Lasagna().ElapsedTimeInMinutes(1, 30));
    }
    
    [TestMethod]
    public void Total_elapsed_time_in_minutes_for_multiple_layers()
    {
        Assert.AreEqual(16, new Lasagna().ElapsedTimeInMinutes(4, 8));
    }
}