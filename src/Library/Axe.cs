namespace MiddleEarth
{
    class Axe
    {
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
        private int defense;
        public int Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                if(value >= 0)
                {
                    this.defense = value;
                }
                else
                {
                    this.defense = 0;
                }
            }
        }
        public Axe(int newAttack, int newDefense)
        {
            this.Attack = newAttack;
            this.Defense = newDefense;
        }
    }
}