using System;

namespace MiddleEarth
{
    class Elf
    {
        public Bow Bow{get;set;}
        public LeatherArmor Armor{get;set;}
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
        public Elf(string name)
        {
            this.Health = 100;
            this.Name = name;
        }
        public void ChangeWeapon(Bow bow)
        {
            this.Bow = bow;
        }
        public void RemoveWeapon()
        {
            this.Bow = null;
        }
        public void ChangeArmor(LeatherArmor armor)
        {
            this.Armor = armor;
        }
        public void RemoveArmor()
        {
            this.Armor = null;
        }
        public void Heal()
        {
            Elf newElf = new Elf("Alive Elf");
            this.Health = newElf.Health;
        }
        public int GetAttack()
        {
            return this.Bow.Attack;
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
