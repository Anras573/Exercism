namespace Exercism.WizardsAndWarriors;

public class Wizard() : Character(nameof(Wizard))
{
    private bool _spellPrepared = false;

    public override int DamagePoints(Character target)
    {
        if (!_spellPrepared) return 3;

        _spellPrepared = false;
        return 12;
    }
    
    public override bool Vulnerable() => !_spellPrepared;
    
    public void PrepareSpell() => _spellPrepared = true;
}