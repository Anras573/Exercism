using Exercism.WizardsAndWarriors;

namespace Exercism.Test.WizardsAndWarriors;

[TestClass]
public class WarriorTests
{
    [TestMethod]
    public void Warrior_deals_6_damage_to_non_vulnerable_target()
    {
        var warrior = new Warrior();
        var target = new Wizard();
        target.PrepareSpell();

        var damage = warrior.DamagePoints(target);

        Assert.AreEqual(6, damage);
    }
    
    [TestMethod]
    public void Warrior_deals_10_damage_to_vulnerable_target()
    {
        var warrior = new Warrior();
        var target = new Wizard();

        var damage = warrior.DamagePoints(target);

        Assert.AreEqual(10, damage);
    }
    
    [TestMethod]
    public void Warrior_is_not_vulnerable()
    {
        var warrior = new Warrior();

        var vulnerable = warrior.Vulnerable();

        Assert.IsFalse(vulnerable);
    }
    
    [TestMethod]
    public void Warrior_to_string()
    {
        var warrior = new Warrior();

        var description = warrior.ToString();

        Assert.AreEqual("Character is a Warrior", description);
    }
}