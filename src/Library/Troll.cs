using System;
using System.Collections;

namespace MiddleEarth
{
    public class Troll
    {
        public Troll(string name)
        {
            this.Name = name;
            this.Health = 150;

        }
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
        public WoodenHammer Hammer{get;set;}
        public IronArmor Armor{get;set;}

        public void ChangeWeapon(WoodenHammer hammer)
        {
            this.Hammer = hammer;
        }
        public void RemoveWeapon()
        {
            this.Hammer = null;
        }
        public void ChangeArmor(IronArmor armor)
        {
            this.Armor = armor;
        }
        public void RemoveArmor()
        {
            this.Armor = null;
        }
        public void Heal()
        {
            Troll newTroll = new Troll("NewTroll");
            this.Health = newTroll.Health;
        }
        public int GetAttack()
        {
            return this.Hammer.Attack;
        }
        public void ReceiveDamage(int damage)
        {
            if(this.Armor.Defense >= damage)
            {
                this.Armor.Defense -= damage;
            }
            else
            {
                damage -= this.Armor.Defense;
                this.Armor.Defense = 0;
                this.Health -= damage;
            }
        }
    }
}