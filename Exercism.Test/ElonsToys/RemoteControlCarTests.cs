using Exercism.ElonsToys;

namespace Exercism.Test.ElonsToys;

[TestClass]
public class RemoteControlCarTests
{
    [TestMethod]
    public void Buy_new_car()
    {
        var car = RemoteControlCar.Buy();
        Assert.AreEqual("Battery at 100%", car.BatteryDisplay());
        Assert.AreEqual("Driven 0 meters", car.DistanceDisplay());
    }
    
    [TestMethod]
    public void Drive_car()
    {
        var car = RemoteControlCar.Buy();
        car.Drive();
        Assert.AreEqual("Battery at 99%", car.BatteryDisplay());
        Assert.AreEqual("Driven 20 meters", car.DistanceDisplay());
    }
    
    [TestMethod]
    public void Drive_car_twice()
    {
        var car = RemoteControlCar.Buy();
        car.Drive();
        car.Drive();
        Assert.AreEqual("Battery at 98%", car.BatteryDisplay());
        Assert.AreEqual("Driven 40 meters", car.DistanceDisplay());
    }
    
    [TestMethod]
    public void Drive_car_until_battery_empty()
    {
        var car = RemoteControlCar.Buy();
        for (var i = 0; i < 100; i++)
        {
            car.Drive();
        }
        Assert.AreEqual("Battery empty", car.BatteryDisplay());
        Assert.AreEqual("Driven 2000 meters", car.DistanceDisplay());
    }
    
    [TestMethod]
    public void Drive_car_after_battery_empty()
    {
        var car = RemoteControlCar.Buy();
        for (var i = 0; i < 101; i++)
        {
            car.Drive();
        }
        Assert.AreEqual("Battery empty", car.BatteryDisplay());
        Assert.AreEqual("Driven 2000 meters", car.DistanceDisplay());
    }
}