using Exercism.LogAnalysis;

namespace Exercism.Test.LogAnalysis;

[TestClass]
public class LogAnalysisTests
{
    [TestMethod]
    public void SubstringAfter_delimiter_present()
    {
        const string log = "[INFO]: File Deleted.";
        Assert.AreEqual("File Deleted.", log.SubstringAfter(": "));
    }
    
    [TestMethod]
    public void SubstringBetween_start_and_end_present()
    {
        const string log = "[INFO]: File Deleted.";
        Assert.AreEqual("INFO", log.SubstringBetween("[", "]:"));
    }
    
    [TestMethod]
    public void Message()
    {
        const string log = "[INFO]: File Deleted.";
        Assert.AreEqual("File Deleted.", log.Message());
    }
    
    [TestMethod]
    public void LogLevel()
    {
        const string log = "[INFO]: File Deleted.";
        Assert.AreEqual("INFO", log.LogLevel());
    }
}