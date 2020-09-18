using System;
using System.Collections;

namespace MiddleEarth
{
    public class Dwarf
    {
        public Axe Axe{get;set;}
        public GoldenArmor Armor{get;set;}
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
        public int health;
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
        public Dwarf(string name)
        {
            this.Health = 100;
            this.Name = name;
        }
        public void ChangeWeapon(Axe axe)
        {
            this.Axe = axe;
        }
        public void RemoveWeapon()
        {
            this.Axe = null;
        }
        public void ChangeArmor(GoldenArmor armor)
        {
            this.Armor = armor;
        }
        public void RemoveArmor()
        {
            this.Armor = null;
        }
        public void Heal()
        {
            Dwarf newDwarf = new Dwarf("Alive Dwarf");
            this.Health = newDwarf.Health;
        }
        public int GetAttack()
        {
            return this.Axe.Attack;
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
