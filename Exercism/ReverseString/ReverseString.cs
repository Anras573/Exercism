namespace Exercism.ReverseString;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var result = string.Empty;
        
        for (var i = input.Length - 1; i >= 0; i--)
        {
            result += input[i];
        }

        return result;
    }
}