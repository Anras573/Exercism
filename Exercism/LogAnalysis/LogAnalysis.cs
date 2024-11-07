namespace Exercism.LogAnalysis;

public static class LogAnalysis
{
    public static string SubstringAfter(this string input, string delimiter)
    {
        var index = input.IndexOf(delimiter, StringComparison.Ordinal);
        return index == -1 ? input : input[(index + delimiter.Length)..];
    }
    
    public static string SubstringBetween(this string input, string start, string end)
    {
        var startIndex = input.IndexOf(start, StringComparison.Ordinal) + start.Length;
        var endIndex = input.IndexOf(end, startIndex, StringComparison.Ordinal);
        return input.Substring(startIndex, endIndex - startIndex);
    }
    
    public static string Message(this string input) => input.SubstringAfter(": ");
    
    public static string LogLevel(this string input) => input.SubstringBetween("[", "]");
}