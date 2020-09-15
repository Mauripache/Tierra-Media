using System;
using System.Collections;

namespace MiddleEarth
{
    public class Troll
    {
        public Troll(string name, int health)
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
        public ArrayList Items{get;set;}
    }
}