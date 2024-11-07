using Exercism.LogsLogsLogs;

namespace Exercism.Test.LogsLogsLogs;

[TestClass]
public class LogLineTests
{
    [TestMethod]
    [DataRow("[TRC] This is a trace message", LogLevel.Trace)]
    [DataRow("[DBG] This is a debug message", LogLevel.Debug)]
    [DataRow("[INF] This is an info message", LogLevel.Info)]
    [DataRow("[WRN] This is a warning message", LogLevel.Warning)]
    [DataRow("[ERR] This is an error message", LogLevel.Error)]
    [DataRow("[FTL] This is a fatal message", LogLevel.Fatal)]
    [DataRow("[XXX] This is an unknown message", LogLevel.Unknown)]
    public void ParseLogLevel_Trace(string logLine, LogLevel expected)
    {
        var actual = LogLine.ParseLogLevel(logLine);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow(LogLevel.Unknown, "This is an unknown message", "0:This is an unknown message")]
    [DataRow(LogLevel.Trace, "This is a trace message", "1:This is a trace message")]
    [DataRow(LogLevel.Debug, "This is a debug message", "2:This is a debug message")]
    [DataRow(LogLevel.Info, "This is an info message", "4:This is an info message")]
    [DataRow(LogLevel.Warning, "This is a warning message", "5:This is a warning message")]
    [DataRow(LogLevel.Error, "This is an error message", "6:This is an error message")]
    [DataRow(LogLevel.Fatal, "This is a fatal message", "42:This is a fatal message")]
    public void OutputForShortLog(LogLevel logLevel, string message, string expected)
    {
        var actual = LogLine.OutputForShortLog(logLevel, message);
        Assert.AreEqual(expected, actual);
    }
}