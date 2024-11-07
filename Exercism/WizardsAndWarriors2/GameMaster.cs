namespace Exercism.WizardsAndWarriors2;

public static class GameMaster
{
    public static string Describe(Character character)
        => $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";

    public static string Describe(Destination destination)
        => $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";

    public static string Describe(TravelMethod travelMethod)
    {
        var methodOfTraveling = travelMethod switch
        {
            TravelMethod.Walking => "by walking.",
            TravelMethod.Horseback => "on horseback.",
            _ => throw new ArgumentException("Invalid travel method.")
        };
        
        return $"You're traveling to your destination {methodOfTraveling}";
    }

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
    {
        var characterDescription = Describe(character);
        var destinationDescription = Describe(destination);
        var travelMethodDescription = Describe(travelMethod);
        return $"{characterDescription} {travelMethodDescription} {destinationDescription}";
    }

    public static string Describe(Character character, Destination destination)
        => Describe(character, destination, TravelMethod.Walking);
}