namespace Exercism.WizardsAndWarriors;

public class Warrior() : Character(nameof(Warrior))
{
    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}