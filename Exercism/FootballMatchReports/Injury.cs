namespace Exercism.FootballMatchReports;

public class Injury(int player) : Incident
{
    public override string GetDescription() => $"Player {player} is injured.";
}