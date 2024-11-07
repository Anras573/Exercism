using Sut = Exercism.WeighingMachine.WeighingMachine;

namespace Exercism.Test.WeighingMachine;

[TestClass]
public class WeighingMachineTests
{
    // The original Culture
    private System.Globalization.CultureInfo _originalCulture = Thread.CurrentThread.CurrentCulture;
    
    [TestInitialize]
    public void Initialize()
    {
        // Save the original culture
        _originalCulture = Thread.CurrentThread.CurrentCulture;
        // Force the culture to en-US to ensure consistent formatting
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
    }
    
    [TestCleanup]
    public void Cleanup()
    {
        // Reset the culture to the default
        Thread.CurrentThread.CurrentCulture = _originalCulture;
    }
    
    [TestMethod]
    public void Precision()
    {
        var machine = new Sut(3);
        
        Assert.AreEqual(3, machine.Precision);
    }
    
    [TestMethod]
    public void Weight()
    {
        var machine = new Sut(3)
        {
            Weight = 5.678
        };
        
        Assert.AreEqual(5.678, machine.Weight);
    }
    
    [TestMethod]
    public void Weight_ThrowsException_WhenNegative()
    {
        var machine = new Sut(3);
        
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => machine.Weight = -1);
    }
    
    [TestMethod]
    public void TareAdjustment()
    {
        var machine = new Sut(3)
        {
            TareAdjustment = 2
        };
        
        Assert.AreEqual(2, machine.TareAdjustment);
    }
    
    [TestMethod]
    public void DisplayWeight_WithTareAdjustment()
    {
        var machine = new Sut(3)
        {
            Weight = 5.678,
            TareAdjustment = 2
        };
        
        Assert.AreEqual("3.678 kg", machine.DisplayWeight);
    }
    
    [TestMethod]
    public void TareAdjustment_DefaultsTo5()
    {
        var machine = new Sut(3);
        
        Assert.AreEqual(5, machine.TareAdjustment);
    }
    
    [TestMethod]
    public void TareAdjustment_CanBeSetTo0()
    {
        var machine = new Sut(3)
        {
            TareAdjustment = 0
        };
        
        Assert.AreEqual(0, machine.TareAdjustment);
    }
    
    [TestMethod]
    public void TareAdjustment_CanBeSetToNegative()
    {
        var machine = new Sut(3)
        {
            TareAdjustment = -2
        };
        
        Assert.AreEqual(-2, machine.TareAdjustment);
    }
    
    [TestMethod]
    public void DisplayWeight_WithNegativeTareAdjustment()
    {
        var machine = new Sut(3)
        {
            Weight = 5.678,
            TareAdjustment = -2
        };
        
        Assert.AreEqual("7.678 kg", machine.DisplayWeight);
    }
    
    [TestMethod]
    public void DisplayWeight_WithNegativeTareAdjustment_CanResultInNegativeWeight()
    {
        var machine = new Sut(3)
        {
            Weight = 1,
            TareAdjustment = 2
        };
        
        Assert.AreEqual("-1.000 kg", machine.DisplayWeight);
    }
}