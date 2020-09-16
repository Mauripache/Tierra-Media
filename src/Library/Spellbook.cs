namespace MiddleEarth
{
    class Spellbook
    {
        public Spell Spell{get;set;}
        public Spellbook(Spell spell)
        {
            this.Spell = spell;
        }

        public int CastSpell()
        {
            return Spell.Attack;
        }
    }
}