namespace Exercism.LogLevels;

public static class LogLine
{
    public static string Message(string logLine)
    {
        var message = string
            .Join(string.Empty, logLine.Split(':').Skip(1))
            .Trim();
        
        message = message
            .Replace("\r", string.Empty)
            .Replace("\n", string.Empty);

        return message;
    }

    public static string LogLevel(string logLine)
    {
        var level = logLine
            .Split(':')[0]
            .Replace("[", string.Empty)
            .Replace("]", string.Empty);

        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
        var message = Message(logLine);
        var level = LogLevel(logLine);
        
        return $"{message} ({level})";
    }
}