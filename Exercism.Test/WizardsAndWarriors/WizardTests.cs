using Exercism.WizardsAndWarriors;

namespace Exercism.Test.WizardsAndWarriors;

[TestClass]
public class WizardTests
{
    [TestMethod]
    public void Wizard_deals_3_damage_when_spell_not_prepared()
    {
        var wizard = new Wizard();
        var target = new Warrior();

        var damage = wizard.DamagePoints(target);

        Assert.AreEqual(3, damage);
    }
    
    [TestMethod]
    public void Wizard_deals_12_damage_when_spell_prepared()
    {
        var wizard = new Wizard();
        var target = new Warrior();
        wizard.PrepareSpell();

        var damage = wizard.DamagePoints(target);

        Assert.AreEqual(12, damage);
    }
    
    [TestMethod]
    public void Wizard_is_vulnerable_when_spell_not_prepared()
    {
        var wizard = new Wizard();

        var vulnerable = wizard.Vulnerable();

        Assert.IsTrue(vulnerable);
    }
    
    [TestMethod]
    public void Wizard_is_not_vulnerable_when_spell_prepared()
    {
        var wizard = new Wizard();
        wizard.PrepareSpell();

        var vulnerable = wizard.Vulnerable();

        Assert.IsFalse(vulnerable);
    }
    
    [TestMethod]
    public void Wizard_to_string()
    {
        var wizard = new Wizard();

        var description = wizard.ToString();

        Assert.AreEqual("Character is a Wizard", description);
    }
}