using System.Text;

namespace Exercism.SqueakyClean;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier)) return string.Empty;

        var sb = new StringBuilder();
        var isAfterDash = false;

        foreach (var c in identifier)
        {
            sb.Append(c switch {
                _ when IsGreekLetter(c) => default,
                _ when isAfterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default
            });
            
            isAfterDash = c == '-';
        }
        
        return sb.ToString();

        bool IsGreekLetter(char c) => c is >= 'α' and <= 'ω';
    }
}