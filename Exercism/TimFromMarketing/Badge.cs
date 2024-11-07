namespace Exercism.TimFromMarketing;

public static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var prefix = id is null ? string.Empty : $"[{id}] - ";
        var postfix = department is null ? " - OWNER" : $" - {department.ToUpper()}";
        
        return $"{prefix}{name}{postfix}";
    }
}