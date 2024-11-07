using Exercism.NeedForSpeed;

namespace Exercism.Test.NeedForSpeed;

[TestClass]
public class RemoteControlCarTests
{
    [TestMethod]
    public void BatteryDrained_returns_true_when_battery_percentage_is_0()
    {
        var car = new RemoteControlCar(10, 50);
        
        car.Drive();
        car.Drive();

        Assert.IsTrue(car.BatteryDrained());
    }
    
    [TestMethod]
    public void BatteryDrained_returns_false_when_battery_percentage_is_not_0()
    {
        var car = new RemoteControlCar(10, 50);
        
        car.Drive();

        Assert.IsFalse(car.BatteryDrained());
    }
    
    [TestMethod]
    public void DistanceDriven_returns_distance_driven()
    {
        var car = new RemoteControlCar(10, 50);
        
        car.Drive();
        car.Drive();

        Assert.AreEqual(20, car.DistanceDriven());
    }
    
    [TestMethod]
    public void Drive_increments_distance_driven_by_speed()
    {
        var car = new RemoteControlCar(10, 50);
        
        car.Drive();

        Assert.AreEqual(10, car.DistanceDriven());
    }
    
    [TestMethod]
    public void Super_hungry_car_after_one_drive_is_drained()
    {
        var car = new RemoteControlCar(100, 60);
        
        car.Drive();

        Assert.IsTrue(car.BatteryDrained());
    }
    
    [TestMethod]
    public void Super_hungry_car_can_try_driving_but_is_drained()
    {
        var car = new RemoteControlCar(100, 60);
        
        car.Drive();
        car.Drive();

        Assert.IsTrue(car.BatteryDrained());
        Assert.AreEqual(100, car.DistanceDriven());
    }
    
    [TestMethod]
    public void Nitro_car_has_speed_of_50()
    {
        var car = RemoteControlCar.Nitro();
        
        car.Drive();
        
        Assert.AreEqual(50, car.DistanceDriven());
    }
    
    [TestMethod]
    public void Nitro_car_has_battery_drain_of_4()
    {
        var car = RemoteControlCar.Nitro();
        
        // Drive 24 times and the car should still have battery
        foreach (var _ in Enumerable.Range(0, 24))
        {
            car.Drive();
        }
        
        Assert.IsFalse(car.BatteryDrained());
        
        // Drive 25th time and the car should be drained
        car.Drive();
        
        Assert.IsTrue(car.BatteryDrained());
    }
}