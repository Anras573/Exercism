using System.Diagnostics;
using Exercism.BuildingTelemetry;

namespace Exercism.Test.BuildingTelemetry;

[TestClass]
public class RemoteControlCarTests
{
    [TestMethod]
    public void GetBatteryUsagePerMeter_NoDistanceDriven_ReturnsNoData()
    {
        var car = RemoteControlCar.Buy();
        var client = new TelemetryClient(car);
        var result = client.GetBatteryUsagePerMeter(0);
        Assert.AreEqual("no data", result);
    }
    
    [TestMethod]
    public void GetBatteryUsagePerMeter_LowerSerialNumber_ReturnsNoData()
    {
        var car = RemoteControlCar.Buy();
        var client = new TelemetryClient(car);
        var _ = client.GetBatteryUsagePerMeter(1);
        var result = client.GetBatteryUsagePerMeter(0);
        Assert.AreEqual("no data", result);
    }
    
    [TestMethod]
    public void GetBatteryUsagePerMeter_ReturnsUsagePerMeter()
    {
        var car = RemoteControlCar.Buy();
        var client = new TelemetryClient(car);
        car.Drive();
        car.Drive();
        var result = client.GetBatteryUsagePerMeter(0);
        Assert.AreEqual("usage-per-meter=5", result);
    }
    
    [TestMethod]
    public void GetBatteryUsagePerMeter_WithSerialNum_ReturnsUsagePerMeter()
    {
        var car = RemoteControlCar.Buy();
        var client = new TelemetryClient(car);
        car.Drive();
        car.Drive();
        var result = client.GetBatteryUsagePerMeter(1);
        Assert.AreEqual("usage-per-meter=5", result);
    }
    
    [TestMethod]
    public void GetSponsor_NoSponsorFound_ReturnsNoSponsorFound()
    {
        var car = RemoteControlCar.Buy();
        car.SetSponsors("sponsor1", "sponsor2");
        var result = car.DisplaySponsor(2);
        Assert.AreEqual("No sponsor found", result);
    }
    
    [TestMethod]
    public void GetSponsor_ReturnsSponsor()
    {
        var car = RemoteControlCar.Buy();
        car.SetSponsors("sponsor1", "sponsor2");
        var result = car.DisplaySponsor(1);
        Assert.AreEqual("sponsor2", result);
    }
    
    [TestMethod]
    public void GetTelemetryData_ReturnsTrue()
    {
        var car = RemoteControlCar.Buy();
        var serialNum = 0;
        var result = car.GetTelemetryData(ref serialNum, out var batteryPercentage, out var distanceDrivenInMeters);
        Assert.IsTrue(result);
        Assert.AreEqual(100, batteryPercentage);
        Assert.AreEqual(0, distanceDrivenInMeters);
    }
    
    [TestMethod]
    public void GetTelemetryData_CarDriven_ReturnsTrue()
    {
        var car = RemoteControlCar.Buy();
        car.Drive();
        var serialNum = 0;
        var result = car.GetTelemetryData(ref serialNum, out var batteryPercentage, out var distanceDrivenInMeters);
        Assert.IsTrue(result);
        Assert.AreEqual(90, batteryPercentage);
        Assert.AreEqual(2, distanceDrivenInMeters);
    }
    
    [TestMethod]
    public void GetTelemetryData_LowerSerialNum_ReturnsFalse()
    {
        var car = RemoteControlCar.Buy();
        car.Drive();
        var serialNum = 1;
        var _ = car.GetTelemetryData(ref serialNum, out var batteryPercentage, out var distanceDrivenInMeters);
        serialNum = 0;
        var result = car.GetTelemetryData(ref serialNum, out batteryPercentage, out distanceDrivenInMeters);
        Assert.IsFalse(result);
        Assert.AreEqual(-1, batteryPercentage);
        Assert.AreEqual(-1, distanceDrivenInMeters);
    }
    
    [TestMethod]
    public void GetTelemetryDataOnEmptyBattery_Drive_DoesNotIncreaseDistanceDriven()
    {
        var car = RemoteControlCar.Buy();
        for (var i = 0; i < 10; i++)
        {
            car.Drive();
        }
        var serialNum = 0;
        var result = car.GetTelemetryData(ref serialNum, out var batteryPercentage, out var distanceDrivenInMeters);
        Assert.IsTrue(result);
        Assert.AreEqual(0, batteryPercentage);
        Assert.AreEqual(20, distanceDrivenInMeters);
        car.Drive();
        serialNum++;
        result = car.GetTelemetryData(ref serialNum, out var newBatteryPercentage, out var newDistanceDrivenInMeters);
        Assert.IsTrue(result);
        Assert.AreEqual(0, newBatteryPercentage);
        Assert.AreEqual(batteryPercentage, newBatteryPercentage);
        Assert.AreEqual(20, newDistanceDrivenInMeters);
        Assert.AreEqual(distanceDrivenInMeters, newDistanceDrivenInMeters);
    }
}