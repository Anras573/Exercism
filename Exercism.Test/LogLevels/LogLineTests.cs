using Exercism.LogLevels;

namespace Exercism.Test.LogLevels;

[TestClass]
public class LogLineTests
{
    [TestMethod]
    public void Message()
    {
        Assert.AreEqual("This is an info message", LogLine.Message("[INFO]: This is an info message"));
        Assert.AreEqual("This is a warning", LogLine.Message("[WARNING]: This is a warning"));
        Assert.AreEqual("This is an error message", LogLine.Message("[ERROR]: This is an error message"));
        
        Assert.AreEqual("Invalid operation", LogLine.Message("[ERROR]: Invalid operation"));
        Assert.AreEqual("Disk almost full", LogLine.Message("[WARNING]:  Disk almost full\r\n"));
    }
    
    [TestMethod]
    public void LogLevel()
    {
        Assert.AreEqual("info", LogLine.LogLevel("[INFO]: This is an info message"));
        Assert.AreEqual("warning", LogLine.LogLevel("[WARNING]: This is a warning"));
        Assert.AreEqual("error", LogLine.LogLevel("[ERROR]: This is an error message"));
        
        Assert.AreEqual("error", LogLine.LogLevel("[ERROR]: Invalid operation"));
        Assert.AreEqual("warning", LogLine.LogLevel("[WARNING]:  Disk almost full\r\n"));
    }
    
    [TestMethod]
    public void Reformat()
    {
        Assert.AreEqual("This is an info message (info)", LogLine.Reformat("[INFO]: This is an info message"));
        Assert.AreEqual("This is a warning (warning)", LogLine.Reformat("[WARNING]: This is a warning"));
        Assert.AreEqual("This is an error message (error)", LogLine.Reformat("[ERROR]: This is an error message"));
        
        Assert.AreEqual("Invalid operation (error)", LogLine.Reformat("[ERROR]: Invalid operation"));
        Assert.AreEqual("Disk almost full (warning)", LogLine.Reformat("[WARNING]:  Disk almost full\r\n"));
    }
}