using System;
using System.Collections;

namespace MiddleEarth
{
    class Elf
    {
        public ArrayList Items{get;set;}
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
    }
}
