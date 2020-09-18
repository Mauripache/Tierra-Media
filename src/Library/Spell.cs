using System;

namespace MiddleEarth
{
    public class Spell
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        private int attack;
        public int Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                if(value >= 0)
                {
                    this.attack = value;
                }
                else
                {
                    this.attack = 0;
                }
            }
        }
        public Spell(int newAttack, string spellName)
        {
            this.Attack = newAttack;
            this.Name = spellName;
        }
    }
}