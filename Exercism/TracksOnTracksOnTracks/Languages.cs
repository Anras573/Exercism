namespace Exercism.TracksOnTracksOnTracks;

public static class Languages
{
    public static List<string> NewList() => [];

    public static List<string> GetExistingLanguages() => ["C#", "Clojure", "Elm"];

    public static List<string> AddLanguage(List<string> languages, string language) => languages.Append(language).ToList();

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    {
        var reversed = languages.ToList();
        reversed.Reverse();
        return reversed;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) return false;
        
        if (string.Equals(languages[0], "C#", StringComparison.OrdinalIgnoreCase))
            return true;
        
        return languages.Count is 2 or 3
               && string.Equals(languages[1], "C#", StringComparison.OrdinalIgnoreCase);
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        var removed = languages.ToList();
        removed.Remove(language);
        return removed;
    }

    public static bool IsUnique(List<string> languages)
    {
        var distinct = languages.Distinct().ToList();
        return distinct.Count == languages.Count;
    }
}