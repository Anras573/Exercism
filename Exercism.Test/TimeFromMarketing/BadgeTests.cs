using Exercism.TimFromMarketing;

namespace Exercism.Test.TimeFromMarketing;

[TestClass]
public class BadgeTests
{
    [TestMethod]
    public void Print_WithIdAndDepartment_ReturnsFormattedString()
    {
        var result = Badge.Print(1, "John Doe", "Marketing");
        Assert.AreEqual("[1] - John Doe - MARKETING", result);
    }
    
    [TestMethod]
    public void Print_WithIdAndNoDepartment_ReturnsFormattedString()
    {
        var result = Badge.Print(1, "John Doe", null);
        Assert.AreEqual("[1] - John Doe - OWNER", result);
    }
    
    [TestMethod]
    public void Print_WithNoIdAndDepartment_ReturnsFormattedString()
    {
        var result = Badge.Print(null, "John Doe", "Marketing");
        Assert.AreEqual("John Doe - MARKETING", result);
    }
    
    [TestMethod]
    public void Print_WithNoIdAndNoDepartment_ReturnsFormattedString()
    {
        var result = Badge.Print(null, "John Doe", null);
        Assert.AreEqual("John Doe - OWNER", result);
    }
}