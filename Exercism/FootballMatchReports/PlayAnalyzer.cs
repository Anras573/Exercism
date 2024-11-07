namespace Exercism.FootballMatchReports;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException(nameof(shirtNum), "Shirt number must be between 1 and 11")
        };
    }

    public static string AnalyzeOffField(object report)
    {
        return report switch
        {
            string announcement => announcement,
            int supporters => $"There are {supporters} supporters at the match.",
            Incident i and Foul => i.GetDescription(),
            Incident i and Injury => $"Oh no! {i.GetDescription()} Medics are on the field.",
            Incident i => i.GetDescription(),
            Manager m => PrintManager(m),
            _ => throw new ArgumentException("Invalid report", nameof(report))
        };

        string PrintManager(Manager m)
        {
            var postFix = m.Club is null ? string.Empty : $" ({m.Club})";
            return $"{m.Name}{postFix}";
        }
    }
}