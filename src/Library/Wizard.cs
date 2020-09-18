using System;
using System.Collections;

namespace MiddleEarth
{
    public class Wizard
    {
        public FireSpear FireSpear{get; set;}

        public MagicWand MagicWand{get; set;}

        public Spellbook SpellBook{get; set;}

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
        private int health;
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if(value >= 0)
                {
                    this.health = value;
                }
                else
                {
                    this.health = 0;
                }
            }
        }
        public Wizard(string name)
        {
            this.Health = 80;
            this.Name = name;
        }


        public void Heal()
        {
            Wizard FullLife = new Wizard("Merlín");
            this.Health = FullLife.Health;
        }


         public void ChangeWand(MagicWand wand)
        {
            this.MagicWand = wand;
        }
        public void RemoveWand(MagicWand wand)
        {
            this.MagicWand = null;
        }
        public void ChangeSpear(FireSpear spear)
        {
            this.FireSpear = spear;
        }
        public void RemoveSpear()
        {
            this.FireSpear = null;
        }

        public int GetWizardAttack()
        {
           return this.MagicWand.Attack + this.FireSpear.Attack + this.SpellBook.CastSpell();
        }

        public void ReceiveDamage(int damage)
        {
            if(this.MagicWand.Defense >= damage)
            {
                this.MagicWand.Defense -= damage;
            }
            else
            {
                damage -= this.MagicWand.Defense;
                this.MagicWand.Defense = 0;
                this.Health -= damage;
            }
        }
      
    }
}