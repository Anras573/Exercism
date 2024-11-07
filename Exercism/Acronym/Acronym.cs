namespace Exercism.Acronym;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var separator = new[] { ' ', '-', '_' };
        
        var abbreviations = phrase
            .Split(separator, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word[0]);
        
        return string.Concat(abbreviations).ToUpperInvariant();
    }
}