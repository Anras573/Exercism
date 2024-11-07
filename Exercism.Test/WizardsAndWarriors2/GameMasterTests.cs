using Exercism.WizardsAndWarriors2;

namespace Exercism.Test.WizardsAndWarriors2;

[TestClass]
public class GameMasterTests
{
    [TestMethod]
    [DataRow("Warrior", 1, 10, "You're a level 1 Warrior with 10 hit points.")]
    [DataRow("Warrior", 2, 20, "You're a level 2 Warrior with 20 hit points.")]
    [DataRow("Wizard", 3, 30, "You're a level 3 Wizard with 30 hit points.")]
    public void Describe_Character(string name, int level, int hitPoints, string expected)
    {
        var character = new Character
        {
            Class = name,
            Level = level,
            HitPoints = hitPoints
        };
        
        var actual = GameMaster.Describe(character);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow("Village", 100, "You've arrived at Village, which has 100 inhabitants.")]
    [DataRow("Town", 200, "You've arrived at Town, which has 200 inhabitants.")]
    [DataRow("City", 300, "You've arrived at City, which has 300 inhabitants.")]
    public void Describe_Destination(string name, int inhabitants, string expected)
    {
        var destination = new Destination
        {
            Name = name,
            Inhabitants = inhabitants
        };
        
        var actual = GameMaster.Describe(destination);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow(TravelMethod.Walking, "You're traveling to your destination by walking.")]
    [DataRow(TravelMethod.Horseback, "You're traveling to your destination on horseback.")]
    public void Describe_TravelMethod(TravelMethod travelMethod, string expected)
    {
        var actual = GameMaster.Describe(travelMethod);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow("Warrior", 1, 10, "Village", 100, TravelMethod.Walking, "You're a level 1 Warrior with 10 hit points. You're traveling to your destination by walking. You've arrived at Village, which has 100 inhabitants.")]
    [DataRow("Warrior", 2, 20, "Town", 200, TravelMethod.Horseback, "You're a level 2 Warrior with 20 hit points. You're traveling to your destination on horseback. You've arrived at Town, which has 200 inhabitants.")]
    [DataRow("Wizard", 3, 30, "City", 300, TravelMethod.Walking, "You're a level 3 Wizard with 30 hit points. You're traveling to your destination by walking. You've arrived at City, which has 300 inhabitants.")]
    public void Describe_Character_Destination_TravelMethod(string name, int level, int hitPoints, string destinationName, int inhabitants, TravelMethod travelMethod, string expected)
    {
        var character = new Character
        {
            Class = name,
            Level = level,
            HitPoints = hitPoints
        };
        
        var destination = new Destination
        {
            Name = destinationName,
            Inhabitants = inhabitants
        };
        
        var actual = GameMaster.Describe(character, destination, travelMethod);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow("Warrior", 1, 10, "Village", 100, "You're a level 1 Warrior with 10 hit points. You're traveling to your destination by walking. You've arrived at Village, which has 100 inhabitants.")]
    [DataRow("Warrior", 2, 20, "Town", 200, "You're a level 2 Warrior with 20 hit points. You're traveling to your destination by walking. You've arrived at Town, which has 200 inhabitants.")]
    [DataRow("Wizard", 3, 30, "City", 300, "You're a level 3 Wizard with 30 hit points. You're traveling to your destination by walking. You've arrived at City, which has 300 inhabitants.")]
    public void Describe_Character_Destination(string name, int level, int hitPoints, string destinationName, int inhabitants, string expected)
    {
        var character = new Character
        {
            Class = name,
            Level = level,
            HitPoints = hitPoints
        };
        
        var destination = new Destination
        {
            Name = destinationName,
            Inhabitants = inhabitants
        };
        
        var actual = GameMaster.Describe(character, destination);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Describe_IncorrectTravelMethod_ThrowsException()
    {
        const TravelMethod travelMethod = (TravelMethod) 999;

        Assert.ThrowsException<ArgumentException>(() => GameMaster.Describe(travelMethod));
    }
}