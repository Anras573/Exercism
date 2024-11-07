namespace Exercism.FootballMatchReports;

public class Manager(string name, string? club)
{
    public string Name { get; } = name;

    public string? Club { get; } = club;
}