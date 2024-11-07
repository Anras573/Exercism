using Exercism.CarsAssemble;

namespace Exercism.Test.CarsAssemble;

[TestClass]
public class AssemblyLineTests
{
    [TestMethod]
    [DataRow(0, 0.0)]
    [DataRow(1, 1.0)]
    [DataRow(4, 1.0)]
    [DataRow(5, 0.9)]
    [DataRow(8, 0.9)]
    [DataRow(9, 0.8)]
    [DataRow(10, 0.77)]
    [DataRow(11, 0.0)]
    public void SuccessRate(int speed, double successRate)
    {
        Assert.AreEqual(successRate, AssemblyLine.SuccessRate(speed));
    }
    
    [TestMethod]
    [DataRow(0, 0.0)]
    [DataRow(1, 221.0)]
    [DataRow(4, 884.0)]
    [DataRow(5, 994.5)]
    [DataRow(8, 1591.2)]
    [DataRow(9, 1591.2)]
    [DataRow(10, 1701.7)]
    [DataRow(11, 0.0)]
    public void ProductionRatePerHour(int speed, double productionRatePerHour)
    {
        Assert.AreEqual(productionRatePerHour, AssemblyLine.ProductionRatePerHour(speed));
    }
    
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 3)]
    [DataRow(4, 14)]
    [DataRow(5, 16)]
    [DataRow(8, 26)]
    [DataRow(9, 26)]
    [DataRow(10, 28)]
    [DataRow(11, 0)]
    public void WorkingItemsPerMinute(int speed, int workingItemsPerMinute)
    {
        Assert.AreEqual(workingItemsPerMinute, AssemblyLine.WorkingItemsPerMinute(speed));
    }
}