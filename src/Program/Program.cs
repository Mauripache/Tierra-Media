using System;

namespace MiddleEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard1 = new Wizard("Phoenix");
            Spell firstSpell = new Spell(70,"Fireball");
            wizard1.FireSpear = new FireSpear(50,0);
            wizard1.SpellBook = new Spellbook(firstSpell);
            wizard1.MagicWand = new MagicWand(30,30);

            Console.WriteLine(wizard1.GetWizardAttack());
            Console.WriteLine(wizard1.Health);

        }
    }
}
